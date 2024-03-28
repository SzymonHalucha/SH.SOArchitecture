using UnityEngine;

namespace SH.SOArchitecture.Callers
{
    public class CallerOnTriggerStay2D : CallerBase
    {
        private void OnTriggerStay2D(Collider2D collider)
        {
            OnCall?.Invoke();
        }
    }
}