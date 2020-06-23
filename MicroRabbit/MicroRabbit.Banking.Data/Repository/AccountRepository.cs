using MicroRabbit.Banking.Data.Context;
using MicroRabbit.Banking.Domain.Interfaces;
using MicroRabbit.Banking.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroRabbit.Banking.Data.Repository
{
    public class AccountRepository : IAccountRepository
    {
        private BankingDbContext context;
        public AccountRepository(BankingDbContext context)
        {
            this.context = context;
        }
        public IEnumerable<Account> GetAccounts()
        {
            return context.Accounts;
        }
    }
}
