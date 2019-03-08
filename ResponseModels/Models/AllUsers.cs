using ResponseModels.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace ResponseModels.Models
{
   public class AllUsers
    {
        public AllUsers() { }

        public AllUsers(List<UsersResponse> _allUsers)
        {
            _AllUsers = _allUsers;
        }

        public List<UsersResponse> _AllUsers { get; set; }

        public bool IsNull
        {
            get
            {
                if (_AllUsers == null)
                {
                    return true;
                }

                return false;
            }
        }
    }
}
