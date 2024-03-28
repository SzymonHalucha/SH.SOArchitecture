namespace SH.SOArchitecture.Callers
{
    public class CallerOnLateUpdate : CallerBase
    {
        private void LateUpdate()
        {
            OnCall?.Invoke();
        }
    }
}