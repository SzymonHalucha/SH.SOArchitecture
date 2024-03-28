using UnityEngine;
using UnityEngine.SceneManagement;

namespace SH.SOArchitecture.ScriptableListeners
{
    [CreateAssetMenu(menuName = "SH/Architecture/Listeners/Unity/" + nameof(Scene), fileName = "New " + nameof(Scene) + " Listener", order = 9)]
    public class ScriptableEventListenerScene : ScriptableEventListener<Scene> { }
}