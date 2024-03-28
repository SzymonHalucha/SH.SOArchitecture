using UnityEngine;

namespace SH.SOArchitecture.Callers
{
    public class CallerOnCollisionStay2D : CallerBase
    {
        private void OnCollisionStay2D(Collision2D collision)
        {
            OnCall?.Invoke();
        }
    }
}