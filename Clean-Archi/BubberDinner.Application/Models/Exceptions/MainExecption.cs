using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubberDinner.Application.Models.Exceptions
{
    public class MainExecption : Exception
    {
        public string Title { get; set; }
        public string Message { get; set; }
        public int Status { get; set; }
    }
}
