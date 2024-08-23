using JpMorgans_chaysCo_MortugageLoan.BusinessEntities.ModelDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JpMorgans_chaysCo_MortugageLoan.BusinessEntities.Interfaces
{
    public interface IUserRegistrationServices
    {
        Task<List<UserRegistrationDtos>> GetAllUserRegistrations();
        Task<UserRegistrationDtos> GetAllUserRegistrationById(int Id);
        Task<bool> AddUserRegistration(UserRegistrationDtos userregdetail);
        Task<bool> UpdateUserRegistration(UserRegistrationDtos userregdetail);
        Task<bool> DelateUserRegistation(int Id);
    }
}
