using System;
using System.Net;

namespace ExceptionHandling.CustomException
{
    public sealed class ForbiddenException:BaseException
    {
        public ForbiddenException() : base(HttpStatusCode.Forbidden)
        {
        }

        public ForbiddenException(string message) : base(message, HttpStatusCode.Forbidden)
        {
        }

        public ForbiddenException(string message, Exception innerException) : base(message, innerException, HttpStatusCode.Forbidden)
        {
        }
    }
}
