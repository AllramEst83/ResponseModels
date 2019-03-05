using ResponseModels.Models;

namespace ResponseModels.ViewModels
{
   public class AddUserToRoleResponse : ResponseModelBase
    {
        public AddUserToRoleResponse() { }

        public AddUserToRoleResponse(
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

        public string UserId { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
    }
}
