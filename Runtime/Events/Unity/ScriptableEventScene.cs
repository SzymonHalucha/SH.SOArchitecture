using UnityEngine;
using UnityEngine.SceneManagement;

namespace SH.SOArchitecture.Events
{
    [CreateAssetMenu(menuName = "SH/Architecture/Events/Unity/" + nameof(Scene), fileName = "New " + nameof(Scene) + " Event", order = 9)]
    public class ScriptableEventScene : ScriptableEvent<Scene> { }
}