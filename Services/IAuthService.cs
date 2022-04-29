using Airport_v2.Entities;
using System.Collections.Generic;

namespace Airport_v2.Services
{
    interface IAuthService
    {
        void AddAccount(Account account);
        bool Authorize(string login, string password);
        Account AuthUser(string login, string password);
        IEnumerable<Account> GetAccounts();
        IEnumerable<Account> GetListAccounts();
        void Save();
    }
}