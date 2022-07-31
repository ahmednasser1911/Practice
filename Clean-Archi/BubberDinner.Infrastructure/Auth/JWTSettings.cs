using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubberDinner.Infrastructure.Auth
{
    public class JWTSettings
    {
        public static string SectionName = "JWTSettings";
        public string Issuer { get; set; } = null!;
        public string Expiration { get; set; } = null!;
        public string Secret { get; set; } = null!;
    }
}
