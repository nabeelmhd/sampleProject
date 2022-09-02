using System;
using System.Web.Http;
using testApi.Interface;

namespace testApi.Controllers
{
    [Route("api/test")]
    public class TestApiController : ApiController
    {
        private readonly ITestService _testService;
        public TestApiController(ITestService testService)
        {
            this._testService = testService;
        }

        [System.Web.Http.Route("getData/{id}")]
        [System.Web.Http.HttpGet]
        public bool getData(int id)
        {
            var isExist =  this._testService.getData(id);
            return isExist;
        }
    }
}
