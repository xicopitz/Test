using Bussiness.Contracts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestController : ControllerBase
    {
        private readonly IValues values;

        public TestController(IValues values)
        {
            this.values = values;
        }

        [HttpGet]
        public async Task<bool> GetAsync()
        {
            return await values.CallServices();
        }
    }
}
