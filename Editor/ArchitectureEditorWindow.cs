using System.IO;
using UnityEditor;
using UnityEngine;

namespace SH.SOArchitecture.Editor
{
    public class ArchitectureEditorWindow : EditorWindow
    {
        private Object _selectedObject;

        [MenuItem("Window/SO Architecture Generator")]
        private static void OpenWindow()
        {
            var window = GetWindow<ArchitectureEditorWindow>();
            window.titleContent = new GUIContent("SO Architecture Generator");
            window.minSize = new Vector2(350f, 350f);
            window.Show();
        }

        private void CreateGUI()
        {
            SetEditorPrefs();
            rootVisualElement.Add
            (
                FieldExtensions.CreateObjectField
                (
                    ArchitectureEditorConsts.SelectedObjectLabel,
                    OnNewObjectSelected,
                    ArchitectureEditorConsts.SelectedObjectTooltip
                )
            );

            rootVisualElement.Add(FieldExtensions.CreateSpacerField());

            rootVisualElement.Add
            (
                FieldExtensions.CreateButtonField
                (
                    ArchitectureEditorConsts.CreateVariableLabel,
                    OnCreateVariableButtonClicked,
                    ArchitectureEditorConsts.CreateVariableTooltip
                )
            );
            rootVisualElement.Add
            (
                FieldExtensions.CreateButtonField
                (
                    ArchitectureEditorConsts.CreateListenerLabel,
                    OnCreateListenerButtonClicked,
                    ArchitectureEditorConsts.CreateListenerTooltip
                )
            );
            rootVisualElement.Add
            (
                FieldExtensions.CreateButtonField
                (
                    ArchitectureEditorConsts.CreateEventLabel,
                    OnCreateEventButtonClicked,
                    ArchitectureEditorConsts.CreateEventTooltip
                )
            );

            rootVisualElement.Add(FieldExtensions.CreateSpacerField());

            rootVisualElement.Add
            (
                FieldExtensions.CreateTextField
                (
                    ArchitectureEditorConsts.ScriptsPathLabel,
                    GetEditorPrefs(ArchitectureEditorConsts.ScriptsPathKey),
                    OnScriptsPathChanged,
                    ArchitectureEditorConsts.ScriptsPathTooltip
                )
            );
            rootVisualElement.Add
            (
                FieldExtensions.CreateTextField
                (
                    ArchitectureEditorConsts.NamespacePathLabel,
                    GetEditorPrefs(ArchitectureEditorConsts.NamespacePathKey),
                    OnNamespacePathChanged,
                    ArchitectureEditorConsts.NamespacePathTooltip
                )
            );
            rootVisualElement.Add
            (
                FieldExtensions.CreateTextField
                (
                    ArchitectureEditorConsts.MenuPathLabel,
                    GetEditorPrefs(ArchitectureEditorConsts.MenuPathKey),
                    OnContextMenuPathChanged,
                    ArchitectureEditorConsts.MenuPathTooltip
                )
            );

            rootVisualElement.Add(FieldExtensions.CreateSpacerField());

            rootVisualElement.Add
            (
                FieldExtensions.CreateButtonField
                (
                    ArchitectureEditorConsts.ResetLabel,
                    OnResetButtonClicked,
                    ArchitectureEditorConsts.ResetTooltip
                )
            );
        }

        private void SetEditorPrefs()
        {
            if (!EditorPrefs.HasKey(ArchitectureEditorConsts.ScriptsPathKey))
            {
                SetEditorPrefs(ArchitectureEditorConsts.ScriptsPathKey, ArchitectureEditorConsts.ScriptsPathDefaultValue);
            }
            if (!EditorPrefs.HasKey(ArchitectureEditorConsts.NamespacePathKey))
            {
                SetEditorPrefs(ArchitectureEditorConsts.NamespacePathKey, ArchitectureEditorConsts.NamespacePathDefaultValue);
            }
            if (!EditorPrefs.HasKey(ArchitectureEditorConsts.MenuPathKey))
            {
                SetEditorPrefs(ArchitectureEditorConsts.MenuPathKey, ArchitectureEditorConsts.MenuPathDefaultValue);
            }
        }

        private void OnNewObjectSelected(Object newObj)
        {
            _selectedObject = newObj;
        }

        private void OnCreateVariableButtonClicked()
        {
            if (_selectedObject != null)
            {
                CreateSOScript("ScriptableVariable");
            }
        }

        private void OnCreateListenerButtonClicked()
        {
            if (_selectedObject != null)
            {
                var path = CreateSOScript(nameof(ScriptableListeners.ScriptableEventListener));
            }
        }

        private void OnCreateEventButtonClicked()
        {
            if (_selectedObject != null)
            {
                CreateSOScript(nameof(Events.ScriptableEvent));
            }
        }

        private void OnScriptsPathChanged(string text)
        {
            SetEditorPrefs(ArchitectureEditorConsts.ScriptsPathKey, text);
        }

        private void OnNamespacePathChanged(string text)
        {
            SetEditorPrefs(ArchitectureEditorConsts.NamespacePathKey, text);
        }

        private void OnContextMenuPathChanged(string text)
        {
            SetEditorPrefs(ArchitectureEditorConsts.MenuPathKey, text);
        }

        private void OnResetButtonClicked()
        {
            SetEditorPrefs(ArchitectureEditorConsts.ScriptsPathKey, ArchitectureEditorConsts.ScriptsPathDefaultValue);
            SetEditorPrefs(ArchitectureEditorConsts.NamespacePathKey, ArchitectureEditorConsts.NamespacePathDefaultValue);
            SetEditorPrefs(ArchitectureEditorConsts.MenuPathKey, ArchitectureEditorConsts.MenuPathDefaultValue);

            rootVisualElement.Clear();
            CreateGUI();
        }

        private string CreateSOScript(string type)
        {
            var keywords = new string[] { "class", "struct", "record", "interface" };
            var scriptLines = File.ReadAllLines(AssetDatabase.GetAssetPath(_selectedObject.GetInstanceID()));
            var path = $"{Application.dataPath}/{GetEditorPrefs(ArchitectureEditorConsts.ScriptsPathKey)}/{type}s";

            foreach (var item in CodeBuilderExtensions.GetIdentifiers(keywords, scriptLines))
            {
                var builder = new CodeBuilder();
                builder.ExtractAndAddAllUsings(scriptLines);
                builder.CreateNamespace(GetEditorPrefs(ArchitectureEditorConsts.NamespacePathKey));
                builder.CreateAssetMenu(GetEditorPrefs(ArchitectureEditorConsts.MenuPathKey), item, type);
                builder.CreateSOClass(item, type);
                builder.CreateFile(path, $"{item}{type}");
            }
            AssetDatabase.Refresh(ImportAssetOptions.ForceUpdate);
            return path;
        }

        private string GetEditorPrefs(string key)
        {
            return EditorPrefs.GetString(key);
        }

        private void SetEditorPrefs(string key, string value)
        {
            if (value.StartsWith('/'))
            {
                value = value[1..];
            }
            if (value.EndsWith('/'))
            {
                value = value[..^1];
            }
            EditorPrefs.SetString(key, value);
        }
    }
}