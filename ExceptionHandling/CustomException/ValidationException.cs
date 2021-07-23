using System;
using System.Net;

namespace ExceptionHandling.CustomException
{
    public sealed class ValidationException:BaseException
    {
        public ValidationException() : base(HttpStatusCode.BadRequest)
        {
        }

        public ValidationException(string message) : base(message, HttpStatusCode.BadRequest)
        {
        }

        public ValidationException(string message, Exception innerException) : base(message, innerException, HttpStatusCode.BadRequest)
        {
        }
    }
}
