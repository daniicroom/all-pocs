using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using prueba.Repository;

namespace prueba.Filters
{
    public class verify : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            //var uUser = (user)Http

            base.OnActionExecuting(context);
        }
    }
}
