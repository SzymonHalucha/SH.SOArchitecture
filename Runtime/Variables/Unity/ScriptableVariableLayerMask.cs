using UnityEngine;

namespace SH.SOArchitecture.Variables
{
    [CreateAssetMenu(menuName = "SH/Architecture/Variables/Unity/" + nameof(LayerMask), fileName = "New " + nameof(LayerMask) + " Variable", order = 6)]
    public class ScriptableVariableLayerMask : ScriptableVariable<LayerMask> { }
}