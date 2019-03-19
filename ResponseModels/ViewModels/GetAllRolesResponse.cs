using ResponseModels.Models;
using System.Collections.Generic;

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
        {

        }
        public GetAllRolesResponse(
            List<GetAllRoles> _listOfRoles,
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
            ListOfAllRoles = _listOfRoles;
        }

        public List<GetAllRoles> ListOfAllRoles { get; set; }
    }
}
