using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using revolut.domain;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountsController : ControllerBase
    {
        private List<Account> _accounts;

        public AccountsController()
        {
            _accounts = new List<Account>()
            {
                new Account(300),
                new Account(500)
            };
        }

        [HttpGet]
        public IEnumerable<Account> Get()
        {
            return _accounts;
        }

        /*
        [HttpPost]
        public something<> Post()
        {

        }
        */
    }
}