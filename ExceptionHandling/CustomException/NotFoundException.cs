using System;
using System.Net;

namespace ExceptionHandling.CustomException
{
    public sealed class NotFoundException:BaseException
    {
        public NotFoundException() : base(HttpStatusCode.NotFound)
        {
        }

        public NotFoundException(string message) : base(message, HttpStatusCode.NotFound)
        {
        }

        public NotFoundException(string message, Exception innerException) : base(message, innerException, HttpStatusCode.NotFound)
        {
        }
    }
}
