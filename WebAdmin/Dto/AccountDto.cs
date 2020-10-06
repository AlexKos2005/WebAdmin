using System;
using CwAuthorizationService.Models;

namespace CwAuthorizationService.Dto
{
    public class AccountDto
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public Roles Role { get; set; }

        public string Description { get; set; }

        public Account ToModel()
        {
            return new Account()
            {
                Id = Id, 
                Name = Name, 
                Role = Role, 
                Description = Description,
            }; 
        }

        public static AccountDto FromModel(Account model)
        {
            return new AccountDto()
            {
                Id = model.Id, 
                Name = model.Name, 
                Role = model.Role, 
                Description = model.Description,
            }; 
        }

    }
}