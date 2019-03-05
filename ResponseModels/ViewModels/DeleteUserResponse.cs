using ResponseModels.Models;

namespace ResponseModels.ViewModels
{
    public class DeleteUserResponse : ResponseModelBase
    {
        public DeleteUserResponse() { }

        public DeleteUserResponse(
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

        
        public string Id { get; set; }
        public string Email { get; set; }
    }
}
