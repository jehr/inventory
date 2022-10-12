using Application.DTOs.Product;
using Application.Interfaces.Product;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Products.Command.Create
{
    public class ProductResponseViewModel
    {
        public int ProductBaseId { get; set; }
        public string Code { get; set; }
        public string Serial { get; set; }
        public DateTime Date { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public string Description { get; set; }
    }

    public class DetailsProductViewModel
    {
        public int SupplierId { get; set; }
        public DateTime Date { get; set; }
        public string NumberBill { get; set; }
        public int TypeMovement { get; set; }
        public int CampusId { get; set; }
        public string Property { get; set; }
        public string TypeProduct { get; set; }
        public DateTime DateEndLicingh { get; set; }
        public string Iva { get; set; }
        public double PriceBill { get; set; }



    }
    public class PostProductCommand : IRequest<bool>
    {
        public List<ProductResponseViewModel> Products { get; set; }

        public DetailsProductViewModel DetailsProduct { get; set; }
    }

    public class PostProductCommandHandler : IRequestHandler<PostProductCommand, bool>
    {
        private readonly IMapper _mapper;
        private readonly IProductService _productService;


        public PostProductCommandHandler(IMapper mapper, IProductService productService)
        {
            _mapper = mapper;
            _productService = productService;
        }

        public async Task<bool> Handle(PostProductCommand request, CancellationToken cancellationToken)
        {
            return await _productService.Post(request, cancellationToken);
        }
    }
}
