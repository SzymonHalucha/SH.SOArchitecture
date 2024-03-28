using UnityEngine;
using UnityEngine.Events;

namespace SH.SOArchitecture.Callers
{
    public abstract class CallerBase : MonoBehaviour
    {
        [SerializeField] protected UnityEvent OnCall;
    }
}