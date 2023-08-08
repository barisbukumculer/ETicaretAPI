using ETicaretAPI.Application.Repositories;
using ETicaretAPI.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ETicaretAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        readonly private IProductWriteRepository _productWriteRepository;
        readonly private IProductReadRepository _productReadRepository;

        readonly private IOrderWriteRepository _orderWriteRepository;
        readonly private IOrderReadRepository _orderReadRepository;

        readonly private ICustomerWriteRepository _customerWriteRepository;
        readonly private ICustomerReadRepository _customerReadRepository;
        public ProductController(
            IProductWriteRepository productWriteRepository,
            IProductReadRepository productReadRepository,
            IOrderWriteRepository orderWriteRepository,
            ICustomerWriteRepository customerWriteRepository,
            ICustomerReadRepository customerReadRepository,
            IOrderReadRepository orderReadRepository)
        {
            _productWriteRepository = productWriteRepository;
            _productReadRepository = productReadRepository;
            _orderWriteRepository = orderWriteRepository;
            _customerWriteRepository = customerWriteRepository;
            _customerReadRepository = customerReadRepository;
            _orderReadRepository = orderReadRepository;
        }
        [HttpGet]
        public async Task Get()
        {
            Order order = await _orderReadRepository.GetByIDAsync("44ef85a7-7ec1-4d60-b319-316ea186256d");
            order.Adress = "İstanbul";
            await _orderWriteRepository.SaveAsync();
        }

    }
}
