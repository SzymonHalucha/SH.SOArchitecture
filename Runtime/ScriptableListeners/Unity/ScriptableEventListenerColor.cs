using UnityEngine;

namespace SH.SOArchitecture.ScriptableListeners
{
    [CreateAssetMenu(menuName = "SH/Architecture/Listeners/Unity/" + nameof(Color), fileName = "New " + nameof(Color) + " Listener", order = 3)]
    public class ScriptableEventListenerColor : ScriptableEventListener<Color> { }
}