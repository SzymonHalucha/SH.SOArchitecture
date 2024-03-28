namespace SH.SOArchitecture.Callers
{
    public class CallerOnEnable : CallerBase
    {
        private void OnEnable()
        {
            OnCall?.Invoke();
        }
    }
}