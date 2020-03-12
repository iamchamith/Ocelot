using Microsoft.AspNetCore.Mvc;
using UserModule.Model;

namespace UserModule.Controllers
{
    [Route("api/users")]
    [ApiController]
    public class UserController : ControllerBase
    {
        UserRepository _userRepository;
        public UserController()
        {
            _userRepository = new UserRepository();
        }
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_userRepository.Get());
        }
        [HttpGet("{id:int}")]
        public IActionResult Get(int id)
        {
            return Ok(_userRepository.Get(id));
        }
        [HttpPost]
        public IActionResult Create([FromBody]User model) {

            _userRepository.AddUser(model);
            return Ok("Created");
        }
        [HttpPut]
        public IActionResult Update([FromBody]User model)
        {
            _userRepository.UpdateUser(model);
            return Ok("Updated");
        }
        [HttpDelete("{id:int}")]
        public IActionResult Delete(int id)
        {
            _userRepository.Deleteuser(id);
            return Ok("Deleted");
        }
    }
}
