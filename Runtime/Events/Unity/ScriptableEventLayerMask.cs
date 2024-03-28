using UnityEngine;

namespace SH.SOArchitecture.Events
{
    [CreateAssetMenu(menuName = "SH/Architecture/Events/Unity/" + nameof(LayerMask), fileName = "New " + nameof(LayerMask) + " Event", order = 6)]
    public class ScriptableEventLayerMask : ScriptableEvent<LayerMask> { }
}