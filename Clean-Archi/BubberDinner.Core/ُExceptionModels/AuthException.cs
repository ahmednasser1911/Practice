using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubberDinner.Core._ُExceptionModels
{
    public class AuthException : Exception
    {
        public int StatusCode { get; set; }
        public string? Message { get; set; } = null;
        public string? Title { get; set; } = "Authentication Exception";
    }
}
