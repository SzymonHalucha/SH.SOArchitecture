using UnityEngine;

namespace SH.SOArchitecture.Events
{
    [CreateAssetMenu(menuName = "SH/Architecture/Events/Unity/" + nameof(Vector3Int), fileName = "New " + nameof(Vector3Int) + " Event", order = 13)]
    public class ScriptableEventVector3Int : ScriptableEvent<Vector3Int> { }
}