using ResponseModels.Models;

namespace ResponseModels.ViewModels
{
    public class SignUpResponse : ResponseModelBase
    {
        public SignUpResponse() { }

        public SignUpResponse(
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
