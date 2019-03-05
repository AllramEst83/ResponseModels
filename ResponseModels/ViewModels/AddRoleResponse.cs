using ResponseModels.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ResponseModels.ViewModels
{
   public class AddRoleResponse : ResponseModelBase
    {
        public AddRoleResponse() { }

        public AddRoleResponse(
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
        public string Role { get; set; }
    }
}
