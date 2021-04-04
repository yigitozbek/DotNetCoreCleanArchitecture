<<<<<<< HEAD
﻿using Microsoft.AspNetCore.Builder;
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
>>>>>>> 10be876906c4d0feadf4fc0a5acc95dead24cc9c
using Nightrain.Base.Core.Middlewares;

namespace Nightrain.Base.Core.Extensions
{
    public static class ExceptionMiddlewareExtension
    {
        public static IApplicationBuilder UseCustomException(
            this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<ExceptionMiddleware>();
        }
    }
}
