using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CwAuthorizationService.Dto
{
    public class TokenDto
    {   
        public AccountDto Account { get; set; }

        /// <summary>
        /// Строка JSON Web Token
        /// </summary>
        public string Jwt { get; set; }

        /// <summary>
        /// Время истечения
        /// </summary>
        public DateTime Expires { get; set; }

        public Guid RefreshTokenId { get; set; }

        /// <summary>
        /// Время истечения в тиках от 1st Jan 1970
        /// </summary>
        public long ExpiresJsTicks
        {
            get
            {
                var janFirst1970 = new DateTime(1970, 1, 1);
                return (long)((DateTime.Now.ToUniversalTime() - janFirst1970).TotalMilliseconds);
            }
        }
    }
}
