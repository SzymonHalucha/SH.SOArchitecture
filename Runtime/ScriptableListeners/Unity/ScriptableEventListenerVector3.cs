using UnityEngine;

namespace SH.SOArchitecture.ScriptableListeners
{
    [CreateAssetMenu(menuName = "SH/Architecture/Listeners/Unity/" + nameof(Vector3), fileName = "New " + nameof(Vector3) + " Listener", order = 12)]
    public class ScriptableEventListenerVector3 : ScriptableEventListener<Vector3> { }
}