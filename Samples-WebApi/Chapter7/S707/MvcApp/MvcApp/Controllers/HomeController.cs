using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace MvcApp.Controllers
{
    public class HomeController : AsyncController
    {
        public ActionResult Index()
        {
            Dictionary<Type, IEnumerable<ActionDescriptor>> actionDescritors = new Dictionary<Type, IEnumerable<ActionDescriptor>>();
            actionDescritors.Add(typeof(Controller1), this.GetActionDescriptors(new Controller1()));
            actionDescritors.Add(typeof(Controller2), this.GetActionDescriptors(new Controller2()));
            return View(actionDescritors);
        }

        private IEnumerable<ActionDescriptor> GetActionDescriptors(
            Controller controller)
        {
            ControllerContext.Controller = controller;
            IActionInvoker actionInvoker = controller.ActionInvoker;
            MethodInfo method = actionInvoker.GetType().GetMethod("GetControllerDescriptor",BindingFlags.Instance | BindingFlags.NonPublic);
            ControllerDescriptor controllerDescriptor = (ControllerDescriptor)method.Invoke(actionInvoker, new object[] { ControllerContext });
            string[] actionNames = new string[] { "Foo", "FooAsync", "FooCompleted", "Bar" };
            foreach (string actionName in actionNames)
            {
                ActionDescriptor actionDescriptor = controllerDescriptor.FindAction(ControllerContext, actionName);
                if (null != actionDescriptor)
                {
                    yield return actionDescriptor;
                }
            }
        }
    }


}
