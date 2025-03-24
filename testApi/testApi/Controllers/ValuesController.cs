using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using testApi.Interface;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace testApi.Controllers
{
    /// <summary>
    ///  view test api
    /// </summary>
    /// <seealso cref="Microsoft.AspNetCore.Mvc.ControllerBase" />
    [Route("api/test")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        /// <summary>
        /// The test service
        /// </summary>
        private readonly ITestService _testService;

        /// <summary>
        /// Initializes a new instance of the <see cref="ValuesController"/> class.
        /// </summary>
        /// <param name="testService">The test service.</param>
        public ValuesController(ITestService testService)
        {
            this._testService = testService;
        }

        /// <summary>
        /// Gets the data.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        [Route("getData/{id}")]
        [HttpGet]
        public IActionResult getData(int id)
        {
            var isExist = this._testService.getData(id);
            return Ok(isExist);
        }
    }
}
