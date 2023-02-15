using Exe.CandupManagement.Application.DTOs.Product;
using Exe.CandupManagement.Application.Features.Products.Requests.Commands;
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

        [HttpPost]
        public async Task<ActionResult> Post(CreateProductDto createProductDto)
        {
            var command = new CreateProductCommand { CreateProductDto = createProductDto };
            var response = await _mediator.Send(command);

            return Ok(response);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, UpdateProductDto updateProductDto)
        {
            var command = new UpdateProductCommand { Id = id , UpdateProductDto = updateProductDto };
            await _mediator.Send(command);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var command = new DeleteProductCommand { Id = id };
            await _mediator.Send(command);

            return NoContent();
        }

        [HttpPut("changestatus/{id}")]
        public async Task<ActionResult> Puta(int id, [FromBody] ChangeProductStatusDto changeProductStatusDto)
        {
            var command = new ChangeProductStatusCommand { Id = id, ChangeProductStatusDto = changeProductStatusDto };
            await _mediator.Send(command);
            return NoContent();
        }

    }
}
