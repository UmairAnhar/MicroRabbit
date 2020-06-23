using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MicroRabbit.Banking.Application.Interfaces;
using MicroRabbit.Banking.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace MicroRabbit.Banking.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BankingController : ControllerBase
    {
        private readonly IAccountService accountService;

        public BankingController(IAccountService accountService)
        {
            this.accountService = accountService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Account>> Get()
        {
            return Ok(accountService.GetAccounts());
        }
    }
}
