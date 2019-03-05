using ResponseModels.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ResponseModels.ViewModels
{
    public class DeleteRoleResponse : ResponseModelBase
    {
        public DeleteRoleResponse() { }

        public DeleteRoleResponse(
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

        public string RoleName { get; set; }
        public string RoleId { get; set; }
    }
}
