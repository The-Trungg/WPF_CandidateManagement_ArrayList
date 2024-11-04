using CandidateManagement_DAL.Entities;
using System.Collections;

namespace CandidateManagement_BLL.Services
{
    public interface IHRAccountService
    {
        public ArrayList GetAllHRAccounts();
        public bool AddHRAccount(Hraccount account);
        public bool UpdateHRAccount(Hraccount account);
        public bool DeleteHRAccount(string email);
        public Hraccount GetHraccountByEmail(string email);
        public ArrayList GetHraccountsByNameOrRole(string? Name, int? Role);
    }
}
