using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using WebApplication3.Domain;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthorController
    {
        private readonly IMapper _mapper;

        public AuthorController(IMapper mapper)
        {
            _mapper = mapper;
        }

        [HttpGet]
        public AuthorApiModel Get()
        {
            var authorEntity = new AuthorEntity
            {
                Id = new Random().Next(100, 999),
                FirstName = "Randika",
                LastName = "Ratnayake",
                Address = "Melbourne, 3000 VIC"
            };

            return _mapper.Map<AuthorApiModel>(authorEntity);
        }
    }
}
