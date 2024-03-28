using UnityEngine;

namespace SH.SOArchitecture.Variables
{
    [CreateAssetMenu(menuName = "SH/Architecture/Variables/Unity/" + nameof(Vector4), fileName = "New " + nameof(Vector4) + " Variable", order = 14)]
    public class ScriptableVariableVector4 : ScriptableVariable<Vector4> { }
}