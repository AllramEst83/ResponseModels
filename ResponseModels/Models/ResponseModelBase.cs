using System;
using System.Collections.Generic;
using System.Text;

namespace ResponseModels.Models
{
    public class ResponseModelBase
    {
        public ResponseModelBase(int _statusCode)
        {
            StatusCode = _statusCode;
        }

        public int StatusCode { get; set; }
        public string Error { get; set; }
        public string Description { get; set; }
        public string Code { get; set; }
    }
}
