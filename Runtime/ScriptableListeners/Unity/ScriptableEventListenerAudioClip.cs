using UnityEngine;

namespace SH.SOArchitecture.ScriptableListeners
{
    [CreateAssetMenu(menuName = "SH/Architecture/Listeners/Unity/" + nameof(AudioClip), fileName = "New " + nameof(AudioClip) + " Listener", order = 2)]
    public class ScriptableEventListenerAudioClip : ScriptableEventListener<AudioClip> { }
}