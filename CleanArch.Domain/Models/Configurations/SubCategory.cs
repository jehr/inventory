using Core.Models.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Models.Configurations
{
    public class SubCategory : EntityWithIntId
    {
        public string Name { get; set; }
        public int CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public Category Category { get; set; }
        public bool Active { get; set; }
    }
}
