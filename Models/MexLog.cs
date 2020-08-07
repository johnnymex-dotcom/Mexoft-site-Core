using Microsoft.AspNetCore.Http;
using Microsoft.VisualStudio.Web.CodeGeneration.Templating;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mexoft_site.Models
{
    public class MexLog
    {
        private readonly RequestDelegate _next;
        private IHttpContextAccessor accessor;

        public MexLog(RequestDelegate next, IHttpContextAccessor _accessor)
        {
            _next = next;
            accessor = _accessor;
        }

        private async Task<string> GetIP()
        {
            var ip = accessor.HttpContext.Connection.RemoteIpAddress.ToString();
            System.Threading.Thread.Sleep(20000);

            return await Task.FromResult<string>(ip);
        }

        public async Task Invoke(HttpContext context)
        {
            var req = context.Request.Path;
            if (req.Value == "/home/cvmain") 
            {
                //var ip = await GetIP();
            
            }
            await _next(context);

        }


    }
}
