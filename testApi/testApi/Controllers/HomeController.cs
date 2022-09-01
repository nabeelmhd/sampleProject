using System;
using System.Web.Http;
using testApi.Interface;
using Microsoft.AspNetCore.Mvc;

namespace testApi.Controllers
{
    [System.Web.Http.Route("api/test")]
    public class HomeController : ApiController
    {
        private readonly ITestService _testService;
        public HomeController(ITestService testService)
        {
            this._testService = testService;
        }
        public IActionResult Index()
        {
            throw new Exception();
        }

        [System.Web.Http.Route("getData/{id}")]
        [System.Web.Http.HttpGet]
        public IActionResult getData(int id)
        {
            var isExist =  this._testService.getData(id);
            return (IActionResult)this.Ok<object>(isExist);
        }
    }
}
