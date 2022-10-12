using System;

namespace Application.DTOs.Product
{
    public class ProductDto
    {
        public int Id { get; set; }
        public int ProductBaseId { get; set; }
        public string Code { get; set; }
        public string Serial { get; set; }
        public DateTime Date { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public string Description { get; set; }
    }
}
