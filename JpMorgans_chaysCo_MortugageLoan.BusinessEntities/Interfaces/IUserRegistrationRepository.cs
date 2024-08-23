using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JpMorgans_chaysCo_MortugageLoan.BusinessEntities.Interfaces
{
    public interface IUserRegistrationRepository
    {
        Task<List<UserRegistration>> GetAllUserRegistrations();
        Task<UserRegistration> GetAllUserRegistrationById(int Id);
        Task<bool> AddUserRegistration(UserRegistration userregdetail);
        Task<bool> UpdateUserRegistration(UserRegistration userregdetail);
        Task<bool> DelateUserRegistation(int Id);
    }
}
