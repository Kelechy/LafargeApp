using LafargeApp.Client.Pages;
using Microsoft.Extensions.Logging.Abstractions;

namespace LafargeApp.Server.Utility
{
    public class Utility : IUtility
    {
        private readonly DataContext _context;

        public Utility(DataContext context)
        {
            _context = context;
        }

        public async Task<bool> Log(Log logEntry)
        {
            _context.Logs.Add(logEntry);
            _context.SaveChanges();
            return true;

        }

    }
}
