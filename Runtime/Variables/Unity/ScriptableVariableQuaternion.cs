using UnityEngine;

namespace SH.SOArchitecture.Variables
{
    [CreateAssetMenu(menuName = "SH/Architecture/Variables/Unity/" + nameof(Quaternion), fileName = "New " + nameof(Quaternion) + " Variable", order = 8)]
    public class ScriptableVariableQuaternion : ScriptableVariable<Quaternion> { }
}