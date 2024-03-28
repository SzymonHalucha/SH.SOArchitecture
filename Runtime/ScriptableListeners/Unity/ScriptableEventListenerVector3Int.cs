using UnityEngine;

namespace SH.SOArchitecture.ScriptableListeners
{
    [CreateAssetMenu(menuName = "SH/Architecture/Listeners/Unity/" + nameof(Vector3Int), fileName = "New " + nameof(Vector3Int) + " Listener", order = 13)]
    public class ScriptableEventListenerVector3Int : ScriptableEventListener<Vector3Int> { }
}