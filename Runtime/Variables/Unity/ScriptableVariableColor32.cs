using UnityEngine;

namespace SH.SOArchitecture.Variables
{
    [CreateAssetMenu(menuName = "SH/Architecture/Variables/Unity/" + nameof(Color32), fileName = "New " + nameof(Color32) + " Variable", order = 4)]
    public class ScriptableVariableColor32 : ScriptableVariable<Color32> { }
}