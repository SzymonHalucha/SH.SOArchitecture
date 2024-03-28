using UnityEngine;

namespace SH.SOArchitecture.ScriptableListeners
{
    [CreateAssetMenu(menuName = "SH/Architecture/Listeners/Unity/" + nameof(Quaternion), fileName = "New " + nameof(Quaternion) + " Listener", order = 8)]
    public class ScriptableEventListenerQuaternion : ScriptableEventListener<Quaternion> { }
}