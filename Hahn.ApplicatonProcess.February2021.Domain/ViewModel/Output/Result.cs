using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace Hahn.ApplicatonProcess.February2021.Domain.ViewModel.Output
{
    public class Result<T> : Result where T : class
    {
        public Result()
        {
        }

        public Result(T value)
        {
            Value = value;
        }

        public T Value { get; set; }
    }

    public class Result
    {
        public bool Success { get; protected set; }
        public string Message { get; set; }
        public bool HasError => !Success;
        public IList<string> Errors { get; }
        public HttpStatusCode HttpStatusCode { get; set; }

        public Result()
        {
            Success = true;
            HttpStatusCode = HttpStatusCode.OK;
            Errors = new List<string>();
        }

        public Result(bool _success, string _message)
        {
            Success = _success;
            Message = _message;
        }
        public void WithError(string errorMessage)
        {
            HttpStatusCode = HttpStatusCode.BadRequest;
            Success = false;
            Errors.Add(errorMessage);
        }

        public void WithNotFound(string errorMessage)
        {
            HttpStatusCode = HttpStatusCode.NotFound;
            Success = false;
            Errors.Add(errorMessage);
        }

        public void WithException(string errorMessage)
        {
            HttpStatusCode = HttpStatusCode.InternalServerError;
            Success = false;
            Errors.Add(errorMessage);
        }

    }
}
