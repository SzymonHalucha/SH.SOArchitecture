using UnityEngine;

namespace SH.SOArchitecture.Events
{
    [CreateAssetMenu(menuName = "SH/Architecture/Events/Unity/" + nameof(Color), fileName = "New " + nameof(Color) + " Event", order = 3)]
    public class ScriptableEventColor : ScriptableEvent<Color> { }
}