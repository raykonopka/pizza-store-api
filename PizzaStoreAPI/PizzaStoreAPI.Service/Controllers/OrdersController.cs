using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PizzaStoreAPI.Service.Controllers
{
    public class OrdersController : ApiController
    {
        ApplicationLogic processedData = new ApplicationLogic();

        [HttpGet]
        public HttpResponseMessage GetAllOrders()
        {
            return Request.CreateResponse(HttpStatusCode.OK, processedData.GetOrders(), "application/json");
        }
    }
}
