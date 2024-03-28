using UnityEngine;

namespace SH.SOArchitecture.Callers
{
    public class CallerOnCollisionEnter2D : CallerBase
    {
        private void OnCollisionEnter2D(Collision2D collision)
        {
            OnCall?.Invoke();
        }
    }
}