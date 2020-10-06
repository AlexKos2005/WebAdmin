using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CwAuthorizationService.Models
{
    public class RefreshToken
    { 
        public Guid Id { get; set; }
        public DateTime CreateDt { get; set; }
        public DateTime ExpiresDt { get; set; }
        public Guid AccountId { get; set; }
        public RefreshToken() { }
        public RefreshToken(Guid accountId, DateTime createDt, int expiresSec)
        {
            AccountId = accountId;
            CreateDt = createDt;
            ExpiresDt = CreateDt.AddSeconds(expiresSec);
        }
    }
}
