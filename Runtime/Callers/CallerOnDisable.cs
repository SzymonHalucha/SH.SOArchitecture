namespace SH.SOArchitecture.Callers
{
    public class CallerOnDisable : CallerBase
    {
        private void OnDisable()
        {
            OnCall?.Invoke();
        }
    }
}