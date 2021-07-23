using System;
using System.Net;

namespace ExceptionHandling.CustomException
{
    public abstract class BaseException:Exception
    {
        private HttpStatusCode _statusCode;

        protected BaseException(HttpStatusCode statusCode)
        {
            SetStatusCode(statusCode);
        }

        protected BaseException(string message, HttpStatusCode statusCode) : base(message)
        {
            SetStatusCode(statusCode);
        }

        protected BaseException(string message, Exception innerException, HttpStatusCode statusCode) : base(message, innerException)
        {
            SetStatusCode(statusCode);
        }

        public int StatusCode => (int) _statusCode;

        private void SetStatusCode(HttpStatusCode statusCode)
        {
            _statusCode = statusCode;
        }
    }
}
