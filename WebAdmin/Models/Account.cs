using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CwAuthorizationService.Dto;

namespace CwAuthorizationService.Models
{
    public class Account
    { 
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Roles Role { get; set; }
        public string Description { get; set; }
        public string PasswordHash { get; set; }
        public string Salt { get; set; }

        /*public AccountDto ToDto()
        {
            return new AccountDto()
            {
                Description = Description,
                Id = Id,
                Name = Name,
                Role = Role, 
                CustomerId = CustomerId
            };
        }*/
    }
}
