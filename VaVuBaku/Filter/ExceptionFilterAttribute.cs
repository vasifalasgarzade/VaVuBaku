using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VaVuBaku.Filter
{
    public class ExceptionFilterAttribute : Attribute, IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            if (!context.ExceptionHandled)
            {
                context.Result = new BadRequestObjectResult(new
                {
                    RealStatusCode = 500,
                    ErrorMessage = context.Exception.Message,
                    ErrorType = context.Exception.StackTrace
                });
                context.ExceptionHandled = true;
            }
        }
    }
}
