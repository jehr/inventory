using System;
using System.Collections.Generic;
using System.Text;

namespace Application.DTOs.Configurations
{
    public class CategoryDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Active { get; set; } = true;
    }
}
