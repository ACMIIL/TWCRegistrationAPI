using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace TWCRegistration.Core.Models.Individual
{
    public class ResultModel
    {
        public HttpStatusCode Code { get; set; }
        public string Message { get; set; }
        public object Data { get; set; }
        public string Token { get; set; }
    }
}
