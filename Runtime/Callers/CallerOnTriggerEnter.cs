using UnityEngine;

namespace SH.SOArchitecture.Callers
{
    public class CallerOnTriggerEnter : CallerBase
    {
        private void OnTriggerEnter(Collider collider)
        {
            OnCall?.Invoke();
        }
    }
}