using ResponseModels.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ResponseModels.ViewModels
{
   public class AddRoleResponse : ResponseModelBase
    {
        public AddRoleResponse() { }
        public AddRoleResponse(int _statusCode,
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
        public AddRoleResponse(
            string _id,
            string _role,
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
            Id = _id;
            Role = _role;
        }
        public string Id { get; set; }
        public string Role { get; set; }
    }
}
