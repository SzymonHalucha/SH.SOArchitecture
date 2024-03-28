using UnityEngine;

namespace SH.SOArchitecture.Events
{
    [CreateAssetMenu(menuName = "SH/Architecture/Events/Unity/" + nameof(Vector3), fileName = "New " + nameof(Vector3) + " Event", order = 12)]
    public class ScriptableEventVector3 : ScriptableEvent<Vector3> { }
}