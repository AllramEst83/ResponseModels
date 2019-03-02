using ResponseModels.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ResponseModels.ViewModels
{
    public class GetAllRolesResponse : ResponseModelBase
    {
        public GetAllRolesResponse(int _statusCode) : base(_statusCode) { }

        public List<GetAllRoles> ListOfAllRoles { get; set; }
    }
}
