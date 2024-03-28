using UnityEngine;
using UnityEngine.UIElements;
using UnityEditor.UIElements;

namespace SH.SOArchitecture.Editor
{
    public static class FieldExtensions
    {
        public static VisualElement CreateSpacerField(float height = 18f)
        {
            var field = new VisualElement();
            field.style.height = height;
            return field;
        }

        public static TextField CreateTextField(string title, string currentValue, System.Action<string> callback, string tooltip = "", int labelMinWidth = 150)
        {
            var field = new TextField(title) { value = currentValue, isDelayed = true, tooltip = tooltip };
            field.RegisterValueChangedCallback(x => callback(x.newValue));
            field.labelElement.style.minWidth = labelMinWidth;
            return field;
        }

        public static ObjectField CreateObjectField(string title, System.Action<Object> callback, string tooltip = "", int labelMinWidth = 150)
        {
            var field = new ObjectField(title) { objectType = typeof(Object), allowSceneObjects = false, tooltip = tooltip };
            field.RegisterValueChangedCallback(x => callback(x.newValue));
            field.labelElement.style.minWidth = labelMinWidth;
            return field;
        }

        public static Button CreateButtonField(string title, System.Action callback, string tooltip = "")
        {
            return new Button(callback) { text = title, tooltip = tooltip };
        }
    }
}