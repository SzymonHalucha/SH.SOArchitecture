namespace SH.SOArchitecture.Callers
{
    public class CallerOnStart : CallerBase
    {
        private void Start()
        {
            OnCall?.Invoke();
        }
    }
}