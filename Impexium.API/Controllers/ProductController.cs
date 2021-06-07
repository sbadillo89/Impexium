using AutoMapper;
using Impexium.API.DTO;
using Impexium.API.Models;
using Impexium.API.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Impexium.API.Utils;
using Microsoft.AspNetCore.Cors; 

namespace Impexium.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController] 
    [EnableCors("CorsPolicy")]
    public class ProductController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IProductService _productService;

        public ProductController(IProductService productService, IMapper mapper)
        {
            _productService = productService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductDto>>> GetAll()
        {
            IEnumerable<Product> products = await _productService.GetAll();

            return Ok(_mapper.Map<IEnumerable<ProductDto>>(products));
        }

        [HttpGet("{id:Guid}")]
        public async Task<ActionResult<ProductDto>> GetById(Guid id)
        {
            Product product = await _productService.GetById(id);

            if (product == null)
            {
                return NotFound(new ErrorReponse($"No product found with id {id}", System.Net.HttpStatusCode.NotFound));
            }

            return _mapper.Map<ProductDto>(product);
        }

        [HttpPost]
        [Authorize]
        public async Task<ActionResult<ProductDto>> Post(ProductCreateDto productCreateDto)
        {
            Product newProduct;
            try
            {
                newProduct = _mapper.Map<Product>(productCreateDto);
                newProduct.Id = Guid.NewGuid();
                newProduct.CreatedDate = DateTime.Now;
                await _productService.Create(newProduct);

            }
            catch (Exception ex)
            {
                return BadRequest(new ErrorReponse(ex.Message, System.Net.HttpStatusCode.BadRequest));
            }

            return CreatedAtAction("GetById", new { id = newProduct.Id }, newProduct);
        }


        [HttpPut("{id:Guid}")]
        [Authorize]
        public async Task<ActionResult<ProductDto>> Put(Guid id, [FromBody] ProductCreateDto product)
        {
            var productFromDB = await _productService.GetById(id);
            if (productFromDB == null)
            {
                return NotFound(new ErrorReponse($"No product found with id {id}", System.Net.HttpStatusCode.BadRequest));
            }
            try
            {
                _mapper.Map(product, productFromDB);
                await _productService.Update(productFromDB);

            }
            catch (Exception ex)
            {
                return BadRequest(new ErrorReponse(ex.Message, System.Net.HttpStatusCode.BadRequest));
            }

            return NoContent();
        }
    }
}
