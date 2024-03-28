using UnityEngine;

namespace SH.SOArchitecture.Variables
{
    [CreateAssetMenu(menuName = "SH/Architecture/Variables/Unity/" + nameof(Vector3Int), fileName = "New " + nameof(Vector3Int) + " Variable", order = 13)]
    public class ScriptableVariableVector3Int : ScriptableVariable<Vector3Int> { }
}