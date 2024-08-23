using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JpMorgans_chaysCo_MortugageLoan.BusinessEntities.ModelDtos
{
    public class UserRegistrationDtos
    {
        public int Id { get; set; }

        public string? Username { get; set; }

        public string? Email { get; set; }

        public string? FullName { get; set; }

        public string? Password { get; set; }
    }
}
