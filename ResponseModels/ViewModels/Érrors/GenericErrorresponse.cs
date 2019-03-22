using ResponseModels.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ResponseModels.ViewModels.Érrors
{
   public class GenericErrorresponse : ResponseModelBase
    {
        public GenericErrorresponse()
        {

        }

        public GenericErrorresponse(
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
    }
}
