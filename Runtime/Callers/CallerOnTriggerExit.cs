using UnityEngine;

namespace SH.SOArchitecture.Callers
{
    public class CallerOnTriggerExit : CallerBase
    {
        private void OnTriggerExit(Collider collider)
        {
            OnCall?.Invoke();
        }
    }
}