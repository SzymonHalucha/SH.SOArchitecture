using UnityEngine;

namespace SH.SOArchitecture.Events
{
    [CreateAssetMenu(menuName = "SH/Architecture/Events/Unity/" + nameof(Quaternion), fileName = "New " + nameof(Quaternion) + " Event", order = 8)]
    public class ScriptableEventQuaternion : ScriptableEvent<Quaternion> { }
}