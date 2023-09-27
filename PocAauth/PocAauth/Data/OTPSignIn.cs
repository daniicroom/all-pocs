using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PocAauth.Data
{
    public class OTPSignIn : IEntity
    {
        public string Code { get; set; }
        public UserApp UserApp { get; set; }
        public int? UserAppId { get; set; }
        public DateTime ExpirationTime { get; set; }
    }
}
