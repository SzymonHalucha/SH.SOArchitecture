using UnityEngine;

namespace SH.SOArchitecture.Callers
{
    public class CallerOnCollisionStay : CallerBase
    {
        private void OnCollisionStay(Collision collision)
        {
            OnCall?.Invoke();
        }
    }
}