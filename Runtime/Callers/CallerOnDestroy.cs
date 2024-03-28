namespace SH.SOArchitecture.Callers
{
    public class CallerOnDestroy : CallerBase
    {
        private void OnDestroy()
        {
            OnCall?.Invoke();
        }
    }
}