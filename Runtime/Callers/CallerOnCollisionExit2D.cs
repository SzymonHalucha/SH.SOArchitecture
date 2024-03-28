using UnityEngine;

namespace SH.SOArchitecture.Callers
{
    public class CallerOnCollisionExit2D : CallerBase
    {
        private void OnCollisionExit2D(Collision2D collision)
        {
            OnCall?.Invoke();
        }
    }
}