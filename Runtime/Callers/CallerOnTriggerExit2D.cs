using UnityEngine;

namespace SH.SOArchitecture.Callers
{
    public class CallerOnTriggerExit3D : CallerBase
    {
        private void OnTriggerExit2D(Collider2D collider)
        {
            OnCall?.Invoke();
        }
    }
}