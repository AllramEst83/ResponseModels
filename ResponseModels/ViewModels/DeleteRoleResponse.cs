using ResponseModels.Models;

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
        {

        }
        public DeleteRoleResponse(string _roleName, string _roleId, int _statusCode, string _error, string _description, string _code) : base(
                _statusCode,
                _error,
                _description,
                _code
                )
        {
            RoleName = _roleName;
            RoleId = _roleId;
        }

        public string RoleName { get; set; }
        public string RoleId { get; set; }
    }
}
