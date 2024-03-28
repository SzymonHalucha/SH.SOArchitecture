using UnityEngine;

namespace SH.SOArchitecture.ScriptableListeners
{
    [CreateAssetMenu(menuName = "SH/Architecture/Listeners/Unity/" + nameof(Vector2), fileName = "New " + nameof(Vector2) + " Listener", order = 10)]
    public class ScriptableEventListenerVector2 : ScriptableEventListener<Vector2> { }
}