﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TheTheoryFarmAPI.Models.DTOs;

namespace TheTheoryFarmAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly UserManager<IdentityUser> userManager;

        public AuthController(UserManager<IdentityUser> userManager)
        {
            this.userManager = userManager;
        }

        // register a user
        [HttpPost]
        [Route("Register")]
        public async Task<IActionResult> Register([FromBody]RegisterUserDto registerUserDto)
        {

            var identityUser = new IdentityUser
            {
                UserName = registerUserDto.Email,
                Email = registerUserDto.Email,
            };

           var identityResult = await userManager.CreateAsync(identityUser, registerUserDto.Password);
          
            if (identityResult.Succeeded)
            {

                if(registerUserDto.Roles != null && registerUserDto.Roles.Any())
                {
                // attach roles to this user (reader, writer or both)
              identityResult = await userManager.AddToRolesAsync(identityUser, registerUserDto.Roles);

                    if(identityResult.Succeeded)
                    {
                        return Ok("User successfully registered. Permitted to login now.");
                    }
                }

            }
            return BadRequest("Something went wrong");
        }

        // login a user
        [HttpPost]
        [Route("Login")]
        public async Task<IActionResult> Login([FromBody] LoginUserDto loginUserDto)
        {
            var user = await userManager.FindByEmailAsync(loginUserDto.Email);

            if (user != null) {
                var checkPasswordResult = await userManager.CheckPasswordAsync(user, loginUserDto.Password);

                if (checkPasswordResult)
                {
                    // create a token to send back to client


                    // create the token & roles



                    // send token to client
                    return Ok();
                };
            };


            return BadRequest("Either the username or password or BOTH are wrong. Please try again");
        }
    }

}
