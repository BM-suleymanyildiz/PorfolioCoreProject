using NuGet.Protocol.Core.Types;

namespace PorfolioCore.Entities
{
    public class Service
    {
        public int ServiceId { get; set; }
        public string ServiceHead { get; set; }
        public string ServiceIcon { get; set; }
        public string ServiceName { get; set; }
        public string ServiceDescription { get; set; }
    }
}
