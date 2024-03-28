using UnityEngine;

namespace SH.SOArchitecture.Variables
{
    [CreateAssetMenu(menuName = "SH/Architecture/Variables/Unity/" + nameof(Object), fileName = "New " + nameof(Object) + " Variable", order = 7)]
    public class ScriptableVariableObject : ScriptableVariable<Object> { }
}