using UnityEngine;

namespace SH.SOArchitecture.ScriptableListeners
{
    [CreateAssetMenu(menuName = "SH/Architecture/Listeners/Unity/" + nameof(Color32), fileName = "New " + nameof(Color32) + " Listener", order = 4)]
    public class ScriptableEventListenerColor32 : ScriptableEventListener<Color32> { }
}