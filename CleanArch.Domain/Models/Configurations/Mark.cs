using Core.Models.Common;

namespace Domain.Models.Configurations
{
    public class Mark : EntityWithIntId
    {
        public string Name { get; set; }
        public bool Active { get; set; }
    }
}
