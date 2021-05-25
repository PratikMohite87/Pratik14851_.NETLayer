using Microsoft.AspNetCore.Mvc;
using MVCWebApp1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCWebApp1.Controllers
{
    public class ServiceDemoController : Controller
    {
        private readonly ITransientService _transientService1, _transientService2;
        private readonly IScopedService _scopedService1, _scopedService2;
        private readonly ISingletonService _singletonService1, _singletonService2;

        // here dependency injection happens as we regiester the services in ConfigureService method.
        public ServiceDemoController(                   
            ISingletonService singletonService1,
            ISingletonService singletonService2,
            ITransientService transientService1,
            ITransientService transientService2,
            IScopedService scopedService1,
            IScopedService scopedService2)
        {
            _singletonService1 = singletonService1;
            _singletonService2 = singletonService2;

            _transientService1 = transientService1;
            _transientService2 = transientService2;

            _scopedService1 = scopedService1;
            _scopedService2 = scopedService2;
        }

        public IActionResult Index()
        {
            ViewBag.transient1 = _transientService1.GetOperationID().ToString();
            ViewBag.transient2 = _transientService2.GetOperationID().ToString();

            ViewBag.scoped1 = _scopedService1.GetOperationID().ToString();
            ViewBag.scoped2 = _scopedService2.GetOperationID().ToString();

            ViewBag.singleton1 = _singletonService1.GetOperationID().ToString();
            ViewBag.singleton2 = _singletonService2.GetOperationID().ToString();

            return View();
        }
    }
}
