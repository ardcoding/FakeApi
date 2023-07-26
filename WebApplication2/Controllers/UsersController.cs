using Microsoft.AspNetCore.Mvc;
using WebApplication2.Fake;
using WebApplication2.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication2.Controllers
{
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        // GET: api/<UsersController>


        private List<User> _users = FakeData.GetUsers();
        [HttpGet]
        public List<User> Get()
        {
            return _users;
        }
        [HttpGet("{id}")]
        public User Get(int id)
        {
            var user  = _users.FirstOrDefault(x => x.Id == id);
            return user;
        }
    }
}
