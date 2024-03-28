using UnityEngine;

namespace SH.SOArchitecture.ScriptableListeners
{
    [CreateAssetMenu(menuName = "SH/Architecture/Listeners/Unity/" + nameof(Vector4), fileName = "New " + nameof(Vector4) + " Listener", order = 14)]
    public class ScriptableEventListenerVector4 : ScriptableEventListener<Vector4> { }
}