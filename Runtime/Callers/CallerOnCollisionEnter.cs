using UnityEngine;

namespace SH.SOArchitecture.Callers
{
    public class CallerOnCollisionEnter : CallerBase
    {
        private void OnCollisionEnter(Collision collision)
        {
            OnCall?.Invoke();
        }
    }
}