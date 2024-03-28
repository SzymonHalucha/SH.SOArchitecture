using UnityEngine;

namespace SH.SOArchitecture.ScriptableListeners
{
    [CreateAssetMenu(menuName = "SH/Architecture/Listeners/Unity/" + nameof(AnimationCurve), fileName = "New " + nameof(AnimationCurve) + " Listener", order = 0)]
    public class ScriptableEventListenerAnimationCurve : ScriptableEventListener<AnimationCurve> { }
}