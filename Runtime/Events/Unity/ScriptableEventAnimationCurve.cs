using UnityEngine;

namespace SH.SOArchitecture.Events
{
    [CreateAssetMenu(menuName = "SH/Architecture/Events/Unity/" + nameof(AnimationCurve), fileName = "New " + nameof(AnimationCurve) + " Event", order = 0)]
    public class ScriptableEventAnimationCurve : ScriptableEvent<AnimationCurve> { }
}