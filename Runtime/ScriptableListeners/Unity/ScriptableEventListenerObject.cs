using UnityEngine;

namespace SH.SOArchitecture.ScriptableListeners
{
    [CreateAssetMenu(menuName = "SH/Architecture/Listeners/Unity/" + nameof(Object), fileName = "New " + nameof(Object) + " Listener", order = 7)]
    public class ScriptableEventListenerObject : ScriptableEventListener<Object> { }
}