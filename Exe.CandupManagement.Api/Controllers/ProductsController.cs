using Exe.CandupManagement.Application.DTOs.Product;
using Exe.CandupManagement.Application.Features.Products.Requests.Queries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;

namespace Exe.CandupManagement.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ProductsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [EnableQuery]
        public async Task<ActionResult<List<ProductListDto>>> Get()
        {
            var products = await _mediator.Send(new GetProductListRequest());
            return Ok(products);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ProductDto>> Get(int id)
        {
            var product = await _mediator.Send(new GetProductDetailsRequest { Id = id});
            return product == null ? BadRequest() : Ok(product);
        }
    }
}
