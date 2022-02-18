using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using AutoMapper;
using FluentValidation;
using NetworkWebAPI.WebAPI.DataAccess;
using NetworkWebAPI.WebAPI.Entities;
using NetworkWebAPI.WebAPI.Entities.ViewModels;
using NetworkWebAPI.WebAPI.Validations;

namespace NetworkWebAPI.WebAPI.Controllers
{
    [Route("api/[controller]s")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;

        public ProductController(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var products = _productRepository.GetProductWithCategory();

            //var getProducts =  products.GetProductsViewModel();

           var result = _mapper.Map<List<GetProductViewModel>>(products);

           
            return Ok(result);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var product = _productRepository.GetById(id);
            return Ok(product);
        }

        [HttpPost]
        public IActionResult Create([FromBody] PostProductQueryViewModel postProduct)
        {
            var validator = new ProductValidator();

            validator.ValidateAndThrow( postProduct);

            var product = _mapper.Map<Product>(postProduct);
            product.Price = 100;
            product.CreatedDate = DateTime.Now.AddDays(-1);

            _productRepository.Create(product);
            return Ok("Eklendi");
                
        }

        [HttpPut]
        public IActionResult Update([FromBody] Product product)
        {
            _productRepository.Update(product);
            return Ok("Güncellendi");
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _productRepository.Delete(id);
            return Ok("Silindi");
        }
    }
}

