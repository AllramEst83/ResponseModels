using ResponseModels.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ResponseModels.ViewModels
{
   public class GetAllUsersResponse : ResponseModelBase
    {
        public GetAllUsersResponse() { }

        public GetAllUsersResponse(
           List<UsersResponse> _listOfUsers,
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
            ListOfAllUsers = _listOfUsers;
        }

        public List<UsersResponse> ListOfAllUsers { get; set; }
    }
}
