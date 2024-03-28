using UnityEngine;

namespace SH.SOArchitecture.Variables
{
    [CreateAssetMenu(menuName = "SH/Architecture/Variables/Unity/" + nameof(Vector2Int), fileName = "New " + nameof(Vector2Int) + " Variable", order = 11)]
    public class ScriptableVariableVector2Int : ScriptableVariable<Vector2Int> { }
}