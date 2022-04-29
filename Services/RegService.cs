using Airport_v2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport_v2.Services
{
    class RegService : IRegService
    {
        public Account Account { get; set; }
        public IAuthService auth { get; } = new AuthService();
        public string Check(string login, string password1, string password2, string firstname, string lastname)
        {
            if (password1.Length >= 8)
            {
                bool en = true;
                bool number = false;
                for (int i = 0; i < password1.Length; i++)
                {
                    if (password1[i] >= 'A' & password1[i] <= 'Z') en = false;
                    if (password1[i] >= '0' & password1[i] <= '9') number = true;
                }
                if (!en)
                    return "Only English layout available";
                else if (!number)
                    return "Enter data";
                if (en && number)
                {
                    var randomizer = new Random();
                    if (password1 == password2)
                    {
                        Account = new Account
                        {
                            Id = randomizer.Next(),
                            FirstName = firstname,
                            LastName = lastname,
                            Login = login,
                            Password = password1,
                            Roles = "User"
                        };
                        auth.GetAccounts();
                        auth.AddAccount(Account);
                        return "User successfully registered";
                    }
                    else
                    {
                        return "Passwords do not match";
                    }
                }
                else return null;
            }
            else return "Password is too short, at least 8 characters";
        }
    }
}
