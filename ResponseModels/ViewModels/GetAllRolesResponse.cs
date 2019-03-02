using ResponseModels.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ResponseModels.ViewModels
{
    public class GetAllRolesResponse : ResponseModelBase
    {
        public GetAllRolesResponse(){ }

        public GetAllRolesResponse(
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

        public List<GetAllRoles> ListOfAllRoles { get; set; }
    }
}
