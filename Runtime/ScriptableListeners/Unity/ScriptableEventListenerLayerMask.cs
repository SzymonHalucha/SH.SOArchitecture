using UnityEngine;

namespace SH.SOArchitecture.ScriptableListeners
{
    [CreateAssetMenu(menuName = "SH/Architecture/Listeners/Unity/" + nameof(LayerMask), fileName = "New " + nameof(LayerMask) + " Listener", order = 6)]
    public class ScriptableEventListenerLayerMask : ScriptableEventListener<LayerMask> { }
}