namespace LafargeApp.Server.Utility
{
    public interface IUtility
    {
        Task<bool> Log(Log logEntry);
    }
}
