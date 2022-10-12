using Core.Models.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Models.Product
{
    public class TypeProduct : EntityWithIntId
    {
        public string Name { get; set; }
        public bool Active { get; set; }
    }
}
