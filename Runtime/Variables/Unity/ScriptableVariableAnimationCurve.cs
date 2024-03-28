using UnityEngine;

namespace SH.SOArchitecture.Variables
{
    [CreateAssetMenu(menuName = "SH/Architecture/Variables/Unity/" + nameof(AnimationCurve), fileName = "New " + nameof(AnimationCurve) + " Variable", order = 0)]
    public class ScriptableVariableAnimationCurve : ScriptableVariable<AnimationCurve> { }
}