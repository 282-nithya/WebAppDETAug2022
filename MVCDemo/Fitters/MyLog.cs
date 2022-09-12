using Microsoft.AspNetCore.Mvc.Filters;

namespace MVCDemo.Fitters
{
    public class MyLog : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            Console.WriteLine($"-{nameof(MyLog)}.{nameof(OnActionExecuted)}");
            base.OnActionExecuting(context);
        }
       

        public override void OnActionExecuted(ActionExecutedContext context)
        {
            Console.WriteLine($"-{nameof(MyLog)}.{nameof(OnActionExecuted)}");
            base.OnActionExecuted(context);
        }
    }
}
