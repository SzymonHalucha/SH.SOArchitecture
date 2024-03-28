using UnityEngine;

namespace SH.SOArchitecture.Variables
{
    [CreateAssetMenu(menuName = "SH/Architecture/Variables/Unity/" + nameof(Vector3), fileName = "New " + nameof(Vector3) + " Variable", order = 12)]
    public class ScriptableVariableVector3 : ScriptableVariable<Vector3> { }
}