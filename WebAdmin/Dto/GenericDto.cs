using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CwAuthorizationService.Dto
{
    public class GenericDto<T>
    {
        public T Value { get; set; }
    }
}
