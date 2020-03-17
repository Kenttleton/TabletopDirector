using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using TabletopDirector.Auth.Services;
using TabletopDirector.Auth.Models;

namespace TabletopDirector.Auth.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {
        //private IAuthService _userService;

        //public UsersController(IAuthService userService)
        //{
        //    _userService = userService;
        //}

        //[AllowAnonymous]
        //[HttpPost("authenticate")]
        //public IActionResult Authenticate([FromBody]IAuthContainerModel model)
        //{
        //    var user = _userService.Authenticate(model.Username, model.Password);

        //    if (user == null)
        //    {
        //        return BadRequest(new { message = "Username or password is incorrect" });
        //    }

        //    return Ok(user);
        //}

        //[HttpGet]
        //public IActionResult GetAll()
        //{
        //    var users = _userService.GetAll();
        //    return Ok(users);
        //}
    }
}
