using UnityEngine;

namespace SH.SOArchitecture.Callers
{
    public class CallerOnTriggerEnter2D : CallerBase
    {
        private void OnTriggerEnter2D(Collider2D collider)
        {
            OnCall?.Invoke();
        }
    }
}