using Microsoft.AspNetCore.Mvc;
using ShippingModule.Model;

namespace ShippingModule.Controllers
{
    [Route("api/shippings")]
    [ApiController]
    public class ShippingController : ControllerBase
    {
        ShippingRepository _shippingRepository;
        public ShippingController()
        {
            _shippingRepository = new ShippingRepository();
        }
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_shippingRepository.Get());
        }
        [HttpGet("users/{id:int}/items")]
        public IActionResult GetByUserId(int id)
        {
            return Ok(_shippingRepository.GetByUserId(id));
        }
        [HttpGet("items/{id:int}/users")]
        public IActionResult GetByItemId([FromBody] int id)
        {
            return Ok(_shippingRepository.GetByItemId(id));
        }
    }
}
