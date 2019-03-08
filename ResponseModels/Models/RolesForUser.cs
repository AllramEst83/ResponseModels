using System;
using System.Collections.Generic;
using System.Text;

namespace ResponseModels.Models
{
    public class RolesForUser
    {

        public RolesForUser() { }

        public RolesForUser(IList<string> _roles)
        {
            Roles = _roles;
        }

        public IList<string> Roles { get; set; }

        public bool IsNull
        {
            get
            {
                if (Roles == null)
                {
                    return true;
                }

                return false;
            }
        }
    }
}
