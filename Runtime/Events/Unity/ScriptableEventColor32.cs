using UnityEngine;

namespace SH.SOArchitecture.Events
{
    [CreateAssetMenu(menuName = "SH/Architecture/Events/Unity/" + nameof(Color32), fileName = "New " + nameof(Color32) + " Event", order = 4)]
    public class ScriptableEventColor32 : ScriptableEvent<Color32> { }
}