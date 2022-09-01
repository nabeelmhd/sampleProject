
using testApi.Interface;

namespace testApi.Services
{
    /// <summary>
    /// TestService
    /// </summary>
    /// <seealso cref="testApi.Interface.ITestService" />
    public class TestService : ITestService
    {
        /// <summary>
        /// Gets the data.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public bool getData(int id)
        {
            var data = new
            {
                id = 1,
                name = "nabeel"
            };
            if(data.id == id)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
