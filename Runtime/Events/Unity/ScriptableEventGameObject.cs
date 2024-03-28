using UnityEngine;

namespace SH.SOArchitecture.Events
{
    [CreateAssetMenu(menuName = "SH/Architecture/Events/Unity/" + nameof(GameObject), fileName = "New " + nameof(GameObject) + " Event", order = 5)]
    public class ScriptableEventGameObject : ScriptableEvent<GameObject> { }
}