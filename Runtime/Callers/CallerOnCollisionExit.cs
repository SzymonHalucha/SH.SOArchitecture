using UnityEngine;

namespace SH.SOArchitecture.Callers
{
    public class CallerOnCollisionExit : CallerBase
    {
        private void OnCollisionExit(Collision collision)
        {
            OnCall?.Invoke();
        }
    }
}