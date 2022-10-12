using System;
using System.Collections.Generic;
using System.Text;

namespace Application.DTOs.Configurations
{
    public class SubCategoryDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public CategoryDto Category { get; set; }
        public bool Active { get; set; }
    }
}
