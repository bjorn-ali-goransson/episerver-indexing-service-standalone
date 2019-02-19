using EPiServer.Logging.Compatibility;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace IndexingService
{
    public class DefaultHandler : IHttpHandler
    {
        public bool IsReusable => false;

        public void ProcessRequest(HttpContext context)
        {
            context.Response.Write("IndexingService");
        }
    }
}