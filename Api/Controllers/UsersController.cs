using Microsoft.AspNetCore.Mvc;
using Persistence.Models;
using Persistence.Repositories;

namespace Api.Controllers;
[Route("api/[controller]")]
[ApiController]
public class UsersController : ControllerBase
{
    private GenericRepository<User> _userRepository { get; set; }

    public UsersController(GenericRepository<User> userRepository)
    {
        _userRepository = userRepository;
    }

    [HttpGet]
    public async Task<IActionResult> GetUsers()
    {
        return Ok(await this._userRepository.ListAsync());
    }
}
