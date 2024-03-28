namespace SH.SOArchitecture.Callers
{
    public class CallerOnUpdate : CallerBase
    {
        private void Update()
        {
            OnCall?.Invoke();
        }
    }
}