using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fr.WebApp
{
    public abstract class BaseAttribute : FilterAttribute, IActionFilter
    { 
        public virtual void OnActionExecuted(ActionExecutedContext filterContext)
        {

        }

        public virtual void OnActionExecuting(ActionExecutingContext filterContext)
        {

        }
    }
}