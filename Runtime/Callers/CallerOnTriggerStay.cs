using UnityEngine;

namespace SH.SOArchitecture.Callers
{
    public class CallerOnTriggerStay : CallerBase
    {
        private void OnTriggerStay(Collider collider)
        {
            OnCall?.Invoke();
        }
    }
}