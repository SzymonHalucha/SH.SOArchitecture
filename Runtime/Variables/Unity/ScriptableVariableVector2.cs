using UnityEngine;

namespace SH.SOArchitecture.Variables
{
    [CreateAssetMenu(menuName = "SH/Architecture/Variables/Unity/" + nameof(Vector2), fileName = "New " + nameof(Vector2) + " Variable", order = 10)]
    public class ScriptableVariableVector2 : ScriptableVariable<Vector2> { }
}