using UnityEngine;

namespace SH.SOArchitecture.Events
{
    [CreateAssetMenu(menuName = "SH/Architecture/Events/Unity/" + nameof(AudioClip), fileName = "New " + nameof(AudioClip) + " Event", order = 2)]
    public class ScriptableEventAudioClip : ScriptableEvent<AudioClip> { }
}