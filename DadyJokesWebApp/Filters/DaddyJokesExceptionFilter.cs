using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Hosting;

namespace DaddyJokesWebApp.Filters
{
    public class DaddyJokesExceptionFilter : IExceptionFilter
    {
        private readonly IHostEnvironment _hostEnvironment;
        public DaddyJokesExceptionFilter(IHostEnvironment hostEnvironment)
        {
            _hostEnvironment = hostEnvironment;
        }
        public void OnException(ExceptionContext context)
        {
            context.Result = new RedirectResult("/Home/Error");
            context.ExceptionHandled = true;
        }
    }
}

