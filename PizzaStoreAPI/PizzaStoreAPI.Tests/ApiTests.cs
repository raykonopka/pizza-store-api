using PizzaStoreAPI.Service;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace PizzaStoreAPI.Tests
{
    public class ApiTests
    {
        //Test After API Is Published

        [Fact]
        public void Test_GetAllSauces()
        {
            ApplicationLogic processedData = new ApplicationLogic();

            var actual = processedData.GetSauceTypes();

            Assert.NotNull(actual);
        }

    }
}
