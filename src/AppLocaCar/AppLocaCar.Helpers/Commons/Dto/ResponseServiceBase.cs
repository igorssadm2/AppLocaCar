using AppLocaCar.Helpers.Enums;
using System;

namespace AppLocaCar.Helpers.Commons.Dto
{
    public abstract class ResponseServiceBase
    {
        public ResponseServiceBase()  
        {
            TypeResponse = TypeResponse.Ok;
        }
        public string Response { get; private set; }
        public TypeResponse TypeResponse { get; set; }
        public void ChangeResponse(string response)
        {
            Response = response;
        }
        
    }
}
