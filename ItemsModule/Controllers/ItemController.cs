using ItemsModule.Model;
using Microsoft.AspNetCore.Mvc;

namespace ItemsModule.Controllers
{
    [Route("api/items")]
    [ApiController]
    public class ItemController : ControllerBase
    {
        ItemRepository _itemRepository;
        public ItemController()
        {
            _itemRepository = new ItemRepository();
        }
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_itemRepository.Get());
        }
        [HttpGet("{id:int}")]
        public IActionResult Get(int id)
        {
            return Ok(_itemRepository.Get(id));
        }
    }
}
