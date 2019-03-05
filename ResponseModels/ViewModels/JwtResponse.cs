using ResponseModels.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ResponseModels.ViewModels
{
   public class JwtResponse : ResponseModelBase
    {
        public JwtResponse() { }

        public JwtResponse(
            int _statusCode,
            string _error,
            string _description,
            string _code
            ) : base(
                _statusCode,
                _error,
                _description,
                _code
                )
        { }

        public string Id { get; set; }
        public string Auth_Token { get; set; }
        public int Expires_In { get; set; }
    }
}
