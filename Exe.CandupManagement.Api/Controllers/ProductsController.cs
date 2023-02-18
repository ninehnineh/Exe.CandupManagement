using Exe.CandupManagement.Application.DTOs.Product;
using Exe.CandupManagement.Application.Features.Products.Requests.Commands;
using Exe.CandupManagement.Application.Features.Products.Requests.Queries;
using Exe.CandupManagement.Application.Models;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using System.Net.NetworkInformation;

namespace Exe.CandupManagement.Api.Controllers
{
    //[Authorize]
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
            return product == null ? NotFound() : Ok(product);
        }

        [HttpGet("availableProduct")]
        public async Task<ActionResult<IEnumerable<ProductListDto>>> GetAvailableProducts()
        {
            var products = await _mediator.Send(new GetProductAvailableRequest());
            return Ok(products);
        }

        [HttpGet("Paging")]
        public async Task<ActionResult<PagedResult<ProductListDto>>> PagingProduct([FromQuery] int pageNumber, [FromQuery] int pageSize)
        {
            var products = await _mediator.Send(new GetProductPageRequest { PageNumber = pageNumber, PageSize = pageSize });
            return Ok(products);
        }

        [HttpGet("SearchProductName/{productName}")]
        public async Task<ActionResult<IEnumerable<ProductListDto>>> GetProductsByName(string productName, int pageNumber = 1, int pageSize = 5)
        {
            var products = await _mediator.Send(new GetProductsByNameRequest
            {
                SearchProductByNameDto = new SearchProductByNameDto
                {
                    ProductName = productName,
                    PagedRequest = new PagedRequest { PageSize = pageSize, PageNumber = pageNumber }
                }
            });
            return Ok(products);
        }


        [HttpPost]
        public async Task<ActionResult> Post(IFormFile file, [FromForm] CreateProductDto createProductDto)
        {
            var command = new CreateProductCommand { Image = file , CreateProductDto = createProductDto };
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
        public async Task<ActionResult> Put(int id, [FromBody] ChangeProductStatusDto changeProductStatusDto)
        {
            var command = new ChangeProductStatusCommand { Id = id, ChangeProductStatusDto = changeProductStatusDto };
            await _mediator.Send(command);
            return NoContent();
        }

    }
}
