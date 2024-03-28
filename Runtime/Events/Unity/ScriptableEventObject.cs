using UnityEngine;

namespace SH.SOArchitecture.Events
{
    [CreateAssetMenu(menuName = "SH/Architecture/Events/Unity/" + nameof(Object), fileName = "New " + nameof(Object) + " Event", order = 7)]
    public class ScriptableEventObject : ScriptableEvent<Object> { }
}