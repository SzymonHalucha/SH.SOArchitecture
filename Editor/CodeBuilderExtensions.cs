using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace SH.SOArchitecture.Editor
{
    public static class CodeBuilderExtensions
    {
        public static void CreateFile(this CodeBuilder builder, string path, string name)
        {
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            File.WriteAllText($"{path}/{name}.cs", builder.ToString(), Encoding.UTF8);
        }

        public static CodeBuilder AddDefaultUsings(this CodeBuilder builder)
        {
            builder.WriteLine("using UnityEngine;");
            builder.WriteLine("using SH.SOArchitecture.ScriptableListeners;");
            builder.WriteLine("using SH.SOArchitecture.Variables;");
            builder.WriteLine("using SH.SOArchitecture.Events;");
            return builder;
        }

        public static CodeBuilder AddUsings(this CodeBuilder builder, IEnumerable<string> names)
        {
            foreach (var item in names)
            {
                builder.Write("using ").Write(item).WriteLine(";");
            }
            return builder;
        }

        public static CodeBuilder ExtractAndAddAllUsings(this CodeBuilder builder, string[] scriptLines)
        {
            var namespaces = GetIdentifiers("namespace", scriptLines);
            builder.AddDefaultUsings();
            builder.AddUsings(namespaces);
            return builder;
        }

        public static CodeBuilder CreateNamespace(this CodeBuilder builder, string name)
        {
            builder.WriteLine("").Write("namespace ").WriteLine(name).OpenBlock();
            return builder;
        }

        public static CodeBuilder CreateAssetMenu(this CodeBuilder builder, string path, string name, string type)
        {
            builder.Write(@"[CreateAssetMenu(menuName = """)
                .Write(path)
                .Write("/")
                .Write(type.Replace("Scriptable", ""))
                .Write("s/")
                .Write(name)
                .Write(@""", fileName = ""New ")
                .Write(name)
                .Write(" ")
                .Write(type)
                .WriteLine(@""")]");
            return builder;
        }

        public static CodeBuilder CreateSOClass(this CodeBuilder builder, string name, string type)
        {
            builder.Write("public class ")
                .Write(name)
                .Write(type)
                .Write(" : ")
                .Write(type)
                .Write("<")
                .Write(name)
                .WriteLine("> { }")
                .CloseBlock();
            return builder;
        }

        public static IEnumerable<string> GetIdentifiers(string[] keywords, string[] scriptLines)
        {
            return keywords.SelectMany(x => GetIdentifiers(x, scriptLines));
        }

        public static IEnumerable<string> GetIdentifiers(string keyword, string[] scriptLines)
        {
            var objects = ExtractAllKeywordsIndexes(keyword, scriptLines);
            objects = RemoveLineCommentedIndexes(objects, scriptLines);
            objects = RemoveBlockCommentedIndexes(objects, scriptLines);
            var names = ExtractKeywordsIdentifiers(objects, scriptLines);
            return names.Select(x =>
            {
                return x.Replace(keyword, "").Trim(' ');
            });
        }

        private static IEnumerable<(int Line, int Index)> ExtractAllKeywordsIndexes(string keyword, string[] scriptLines)
        {
            var keywords = new List<(int Line, int Index)>();
            var length = keyword.Length;
            for (int line = 0; line < scriptLines.Length; line++)
            {
                var index = scriptLines[line].IndexOf(keyword);
                while (index >= 0)
                {
                    keywords.Add((line, index));
                    index = scriptLines[line].IndexOf(keyword, index + length);
                }
            }
            return keywords;
        }

        private static IEnumerable<(int Line, int Index)> RemoveLineCommentedIndexes(IEnumerable<(int Line, int Index)> keywords, string[] scriptLines)
        {
            return keywords.Where(x =>
            {
                var lineComment = scriptLines[x.Line].IndexOf("//");
                return lineComment < 0 || lineComment > x.Index;
            });
        }

        private static IEnumerable<(int Line, int Index)> RemoveBlockCommentedIndexes(IEnumerable<(int Line, int Index)> keywords, string[] scriptLines)
        {
            bool isCommeted = false;
            var comments = scriptLines.Select(x =>
            {
                int start = x.IndexOf("/*");
                isCommeted = isCommeted || start >= 0;
                int end = x.IndexOf("*/");
                isCommeted = isCommeted && end < 0;
                return (IsCommented: isCommeted, Start: start, End: end);
            }).ToArray();

            return keywords.Where(x =>
            {
                return (!comments[x.Line].IsCommented && comments[x.Line].End < x.Index)
                    || (!comments[x.Line].IsCommented && comments[x.Line].Start > x.Index)
                    || (comments[x.Line].IsCommented && comments[x.Line].Start > x.Index);
            });
        }

        private static IEnumerable<string> ExtractKeywordsIdentifiers(IEnumerable<(int Line, int Index)> keywords, string[] scriptsLines)
        {
            var chars = new char[] { '\n', '{', ';', '/', '<', ':', '(', '[', '$', '?', '!', '@' };
            return keywords.Select(x =>
            {
                var line = scriptsLines[x.Line].Substring(x.Index).Trim(' ');
                var index = line.IndexOfAny(chars);
                return index < 0 ? line : line.Substring(0, index);
            });
        }

        // private static List<string> GetAllNamespaces(string[] scriptLines)
        // {
        //     const string namespaceKeyword = "namespace";
        //     int keywordLength = namespaceKeyword.Length;
        //     char[] endChars = new char[] { '{', '/', ';', '\n' };

        //     var names = new List<string>();
        //     var isInBlockComment = false;

        //     foreach (var line in scriptLines)
        //     {
        //         var trimed = line.Trim(' ');
        //         int commentIndex = trimed.IndexOf("//");
        //         int blockCommentIndex = trimed.IndexOf("/*");
        //         int blockCommentEndIndex = trimed.IndexOf("*/");
        //         int start = trimed.IndexOf(namespaceKeyword);
        //         if (blockCommentEndIndex >= 0)
        //         {
        //             isInBlockComment = false;
        //             if (blockCommentEndIndex >= start)
        //             {
        //                 continue;
        //             }
        //         }
        //         if (isInBlockComment)
        //         {
        //             continue;
        //         }
        //         if (commentIndex >= 0 && commentIndex < start)
        //         {
        //             continue;
        //         }
        //         if (blockCommentIndex >= 0)
        //         {
        //             isInBlockComment = true;
        //             if (blockCommentIndex < start)
        //             {
        //                 continue;
        //             }
        //         }
        //         if (start >= 0)
        //         {
        //             start += keywordLength;
        //             int end = trimed.IndexOfAny(endChars, start);
        //             if (end >= 0)
        //             {
        //                 names.Add(trimed[start..end]);
        //             }
        //             else
        //             {
        //                 names.Add(trimed[start..]);
        //             }
        //         }
        //     }
        //     return names;
        // }
    }
}