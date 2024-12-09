using HepsiBurada.Application.Interfaces.AutoMapper;
using HepsiBurada.Application.Interfaces.UnitOfWorks;
using HepsiBurada.Domain.Entities;
using MediatR;

namespace HepsiBurada.Application.Features.Products.Queries.GetAllProducts
{
    public class GetAllProductsQueryHandler : IRequestHandler<GetAllProductsQueryRequest, IList<GetAllProductsQueryResponse>>
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public GetAllProductsQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }
        public async Task<IList<GetAllProductsQueryResponse>> Handle(GetAllProductsQueryRequest request, CancellationToken cancellationToken)
        {
            var products = await unitOfWork.GetReadRepository<Product>().GetAllAsync();

            List<GetAllProductsQueryResponse> response = new();

            //foreach (var product in products)
            //{
            //    response.Add(new GetAllProductsQueryResponse()
            //    {
            //        Description = product.Description,
            //        Discount = product.Discount,
            //        Price = product.Price - (product.Price * product.Discount / 100),
            //        Title = product.Title
            //    });
            //}

            var responseDto = mapper.Map<GetAllProductsQueryResponse, Product>(products);

            return responseDto;
        }
    }
}
