namespace AspNetHangfireDemo
{
    public interface IHangfireTestJobService
    {
        void AddFireAndForgetJob();
        void AddReccuringJob();
        void AddDelayedJob();
        void AddContinuationJob();
    }
}
