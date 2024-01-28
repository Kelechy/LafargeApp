namespace LafargeApp.Server.Utility
{
    public interface IDistanceCalculation
    {
        double CalculateDistance(double lat1, double lon1, double lat2, double lon2);
    }
}
