namespace SH.SOArchitecture.Callers
{
    public class CallerOnAwake : CallerBase
    {
        private void Awake()
        {
            OnCall?.Invoke();
        }
    }
}