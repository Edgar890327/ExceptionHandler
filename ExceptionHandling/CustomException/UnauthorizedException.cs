using System;
using System.Net;

namespace ExceptionHandling.CustomException
{
    public sealed class UnauthorizedException:BaseException
    {
        public UnauthorizedException() : base(HttpStatusCode.Unauthorized)
        {
        }

        public UnauthorizedException(string message) : base(message, HttpStatusCode.Unauthorized)
        {
        }

        public UnauthorizedException(string message, Exception innerException) : base(message, innerException, HttpStatusCode.Unauthorized)
        {
        }
    }
}
