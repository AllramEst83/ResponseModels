namespace ResponseModels.Models
{
    public class ResponseModelBase
    {
        public ResponseModelBase(
            int _statusCode = 0, 
            string _error = "", 
            string _description = "", 
            string _code = ""
            )
        {
            StatusCode = _statusCode;
            Error = _error;
            Description = _description;
            Code = _code;
        }

        public int StatusCode { get; set; }
        public string Error { get; set; }
        public string Description { get; set; }
        public string Code { get; set; }
    }
}
