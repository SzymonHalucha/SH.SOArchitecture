using UnityEngine;
using UnityEngine.SceneManagement;

namespace SH.SOArchitecture.Variables
{
    [CreateAssetMenu(menuName = "SH/Architecture/Variables/Unity/" + nameof(Scene), fileName = "New " + nameof(Scene) + " Variable", order = 9)]
    public class ScriptableVariableScene : ScriptableVariable<Scene> { }
}