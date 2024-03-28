using UnityEngine;

namespace SH.SOArchitecture.Variables
{
    [CreateAssetMenu(menuName = "SH/Architecture/Variables/Unity/" + nameof(GameObject), fileName = "New " + nameof(GameObject) + " Variable", order = 5)]
    public class ScriptableVariableGameObject : ScriptableVariable<GameObject> { }
}