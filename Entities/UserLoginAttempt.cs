using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi_JWT.Entities
{
    public class UserLoginAttempt : BaseEntity
    {
        public DateTime? AttemptTime { get; set; }
        public bool? IsSuccess { get; set; }
    }
}
