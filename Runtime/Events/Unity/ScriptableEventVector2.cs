using UnityEngine;

namespace SH.SOArchitecture.Events
{
    [CreateAssetMenu(menuName = "SH/Architecture/Events/Unity/" + nameof(Vector2), fileName = "New " + nameof(Vector2) + " Event", order = 10)]
    public class ScriptableEventVector2 : ScriptableEvent<Vector2> { }
}