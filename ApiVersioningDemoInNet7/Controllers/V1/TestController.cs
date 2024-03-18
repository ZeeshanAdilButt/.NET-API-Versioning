using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;

namespace ApiVersioningDemoInNet7.Controllers.V1
{
    [Route("api/[controller]")]
    [ApiVersion(1.0)]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        [HttpGet, Route("testmethod")]
        public string TestMethod()
        {
            return "Test method call successful";
        }

        //[ApiVersion(2.0)]
        //[HttpGet, Route("testmethod")]
        //public string TestMethod2()
        //{
        //    return "Test method 22 call successful";
        //}
    }
}
