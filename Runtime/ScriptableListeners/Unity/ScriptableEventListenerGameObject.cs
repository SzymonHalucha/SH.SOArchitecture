using UnityEngine;

namespace SH.SOArchitecture.ScriptableListeners
{
    [CreateAssetMenu(menuName = "SH/Architecture/Listeners/Unity/" + nameof(GameObject), fileName = "New " + nameof(GameObject) + " Listener", order = 5)]
    public class ScriptableEventListenerGameObject : ScriptableEventListener<GameObject> { }
}