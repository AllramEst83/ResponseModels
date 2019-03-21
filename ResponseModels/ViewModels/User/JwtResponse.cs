using ResponseModels.Models;

namespace ResponseModels.ViewModels
{
    public class JwtResponse : ResponseModelBase
    {
        public JwtResponse() { }

        public JwtResponse(string _id, string _auth_token, int _expires_in,
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
            Id = _id;
            Auth_Token = _auth_token;
            Expires_In = _expires_in;
        }

        public string Id { get; set; }
        public string Auth_Token { get; set; }
        public int Expires_In { get; set; }
    }
}
