﻿using BS.Domain;
using BS.Domain.Services;
using BS.DTO;
using Microsoft.AspNetCore.Mvc;

namespace BS.API.Controllers
{
    public class UsersController : BsController
    {
        public UsersController(IService _service, IDispatcher _dispatcher) : base(_service, _dispatcher)
        {
        }

        [HttpPost("Register")]
        public IActionResult PostRegister([FromBody] UserDTO dto)
        {
            var response = _service.RegisterUser(dto);

            return Ok(response.data);
        }

        [HttpPost("Login")]
        public IActionResult PostLogin([FromBody] LoginDTO dto)
        {
            var response = _service.SignIn(dto);

            return Ok(response);
        }
    }
}