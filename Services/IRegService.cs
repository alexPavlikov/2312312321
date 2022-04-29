using Airport_v2.Entities;

namespace Airport_v2.Services
{
    interface IRegService
    {
        Account Account { get; set; }
        IAuthService auth { get; }

        string Check(string login, string password1, string password2, string firstname, string lastname);
    }
}