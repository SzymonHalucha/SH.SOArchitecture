using UnityEngine;

namespace SH.SOArchitecture.ScriptableListeners
{
    [CreateAssetMenu(menuName = "SH/Architecture/Listeners/Unity/" + nameof(Vector2Int), fileName = "New " + nameof(Vector2Int) + " Listener", order = 11)]
    public class ScriptableEventListenerVector2Int : ScriptableEventListener<Vector2Int> { }
}