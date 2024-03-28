using UnityEngine;

namespace SH.SOArchitecture.Variables
{
    [CreateAssetMenu(menuName = "SH/Architecture/Variables/Unity/" + nameof(AudioClip), fileName = "New " + nameof(AudioClip) + " Variable", order = 2)]
    public class ScriptableVariableAudioClip : ScriptableVariable<AudioClip> { }
}