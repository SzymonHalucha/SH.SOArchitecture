using UnityEngine;

namespace SH.SOArchitecture.Variables
{
    [CreateAssetMenu(menuName = "SH/Architecture/Variables/Unity/" + nameof(Color), fileName = "New " + nameof(Color) + " Variable", order = 3)]
    public class ScriptableVariableColor : ScriptableVariable<Color> { }
}