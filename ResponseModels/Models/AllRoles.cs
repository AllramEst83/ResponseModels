using System;
using System.Collections.Generic;
using System.Text;

namespace ResponseModels.Models
{
   public class AllRoles
    {
        public AllRoles() { }

        public AllRoles(List<GetAllRoles> _allRoles)
        {
            _AllRoles = _allRoles;
        }

        public List<GetAllRoles> _AllRoles { get; set; }

        public bool IsNull
        {
            get
            {
                if (_AllRoles == null)
                {
                    return true;
                }

                return false;
            }
        }
    }
}
