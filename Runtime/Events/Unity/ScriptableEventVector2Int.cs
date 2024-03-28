using UnityEngine;

namespace SH.SOArchitecture.Events
{
    [CreateAssetMenu(menuName = "SH/Architecture/Events/Unity/" + nameof(Vector2Int), fileName = "New " + nameof(Vector2Int) + " Event", order = 11)]
    public class ScriptableEventVector2Int : ScriptableEvent<Vector2Int> { }
}