using ResponseModels.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ResponseModels.ViewModels
{
   public class RemoveUserfromRoleResponse : ResponseModelBase
    {
        public RemoveUserfromRoleResponse() { }
        public RemoveUserfromRoleResponse(
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
        {

        }
        public RemoveUserfromRoleResponse(
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

        public string Email { get; set; }
        public string Role { get; set; }
        public string UserId { get; set; }
    }
}
