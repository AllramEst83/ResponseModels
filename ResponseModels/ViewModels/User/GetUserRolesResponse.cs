using ResponseModels.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ResponseModels.ViewModels
{
   public class GetUserRolesResponse : ResponseModelBase
    {
        public GetUserRolesResponse() { }
        public GetUserRolesResponse(
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
        public GetUserRolesResponse(
            string _email,
            List<string> _roles,
            string userId,
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
            Email = _email;
            Roles = _roles;
            UserId = userId;
        }
        public string Email { get; set; }
        public List<string> Roles { get; set; }
        public string UserId { get; set; }
    }
}
