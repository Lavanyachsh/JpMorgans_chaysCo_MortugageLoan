using JpMorgans_chaysCo_MortugageLoan.BusinessEntities;
using JpMorgans_chaysCo_MortugageLoan.BusinessEntities.Interfaces;
using JpMorgans_chaysCo_MortugageLoan.BusinessEntities.ModelDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JpMorgans_chaysCo_MortugageLoan.ServiceLayer
{
    public class UserRegistrationServices : IUserRegistrationServices
    {
        IUserRegistrationRepository _usrrgrep;
        public UserRegistrationServices(IUserRegistrationRepository usrrgrep)
        {
            _usrrgrep = usrrgrep;
        }
        public async Task<bool> AddUserRegistration(UserRegistrationDtos userregdetail)
        {
            UserRegistration ur = new UserRegistration();
            // obj.id = bookingDetail.id; because of identity we cant pass here
            ur.FullName = userregdetail.FullName;
            ur.Username = userregdetail.Username;
            ur.Email = userregdetail.Email;
            ur.Password = userregdetail.Password;


            await _usrrgrep.AddUserRegistration(ur);
            return true;
        }

        public async Task<bool> DelateUserRegistation(int Id)
        {
            await _usrrgrep.DelateUserRegistation(Id);
            return true;
        }

        public async Task<UserRegistrationDtos> GetAllUserRegistrationById(int Id)
        {
            var urobj = await _usrrgrep.GetAllUserRegistrationById(Id);

            UserRegistrationDtos urdto = new UserRegistrationDtos();
           urdto.FullName = urobj.FullName;
            urdto.Username = urobj.Username;
            urdto.Email = urobj.Email;
            urdto.Password = urobj.Password;
            urdto.Id =urobj.Id;

            return urdto;
        }

        public async Task<List<UserRegistrationDtos>> GetAllUserRegistrations()
        {
            List<UserRegistrationDtos> objurreg = new List<UserRegistrationDtos>();
            var result = await _usrrgrep.GetAllUserRegistrations();
            foreach (UserRegistration usrpbj in result)
            {
                UserRegistrationDtos obj = new UserRegistrationDtos();
                obj.Id = usrpbj.Id;
                obj.FullName = usrpbj.FullName;
                obj.Username = usrpbj.Username;
                obj.Email = usrpbj.Email;
                obj.Password = usrpbj.Password;
                objurreg.Add(obj);
            }
            return objurreg;
        }

        public async Task<bool> UpdateUserRegistration(UserRegistrationDtos userregdetail)
        {
            UserRegistration obj = new UserRegistration();
            obj.Id = userregdetail.Id;
           obj.FullName=userregdetail.FullName;
            obj.Username = userregdetail.Username;
            obj.Password=userregdetail.Password;
            obj.Email = userregdetail.Email;


            await _usrrgrep.UpdateUserRegistration(obj);
            return true;
        }
    }
}
