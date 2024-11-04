﻿using CandidateManagement_DAL.Entities;
using System.Collections;

namespace CandidateManagement_BLL.Services
{
    public class HRAccountService : IHRAccountService
    {
        private HRAccountDAO _hrAccountDAO;

        public HRAccountService()
        {
            _hrAccountDAO = new HRAccountDAO();
        }

        public ArrayList GetAllHRAccounts()
        {
            return _hrAccountDAO.LoadHRAccounts();
        }
        public bool AddHRAccount(Hraccount account)
        {
            try
            {
                if (string.IsNullOrEmpty(account.Email) || string.IsNullOrEmpty(account.Password))
                    return false;

                var accounts = _hrAccountDAO.LoadHRAccounts();
                foreach (Hraccount acc in accounts)
                {
                    if (acc.Email.Equals(account.Email))
                        return false;
                }

                return _hrAccountDAO.AddHRAccount(account);
            }
            catch
            {
                return false;
            }
        }

        public bool UpdateHRAccount(Hraccount account)
        {
            try
            {
                if (string.IsNullOrEmpty(account.Email) || string.IsNullOrEmpty(account.Password))
                    return false;

                return _hrAccountDAO.UpdateHRAccount(account);
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteHRAccount(string email)
        {
            try
            {
                if (string.IsNullOrEmpty(email))
                    return false;

                return _hrAccountDAO.DeleteHRAccount(email);
            }
            catch
            {
                return false;
            }
        }

        public Hraccount GetHraccountByEmail(string email)
        {
            try
            {
                if (string.IsNullOrEmpty(email))
                    return null;

                return _hrAccountDAO.GetHraccountByEmail(email);
            }
            catch
            {
                return null;
            }
        }
        public ArrayList GetHraccountsByNameOrRole(string? name, int? Role) => _hrAccountDAO.GetHraccountsByNameOrRole(name, Role);
    }
}
