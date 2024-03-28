using UnityEngine;

namespace SH.SOArchitecture.Events
{
    [CreateAssetMenu(menuName = "SH/Architecture/Events/Unity/" + nameof(Vector4), fileName = "New " + nameof(Vector4) + " Event", order = 14)]
    public class ScriptableEventVector4 : ScriptableEvent<Vector4> { }
}