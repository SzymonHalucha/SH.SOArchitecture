namespace SH.SOArchitecture.Callers
{
    public class CallerOnFixedUpdate : CallerBase
    {
        private void FixedUpdate()
        {
            OnCall?.Invoke();
        }
    }
}