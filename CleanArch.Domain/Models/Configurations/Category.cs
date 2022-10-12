using Core.Models.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Models.Configurations
{
    public class Category : EntityWithIntId
    {
        public string Name { get; set; }
        public bool Active { get; set; } = true;
    }
}
