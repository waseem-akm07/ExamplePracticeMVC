using System.Web.Http;
using Exmples;
using Exmples.ViewModel;

namespace ExamplePractice_Mvc.Controllers
{
    public class exampleController : ApiController
    {
        private IPredicate pedicate = new PedicateExample();

        // GET: api/example
        [HttpGet]
        [Route("api/example/get1")]
        public string Get()
        {
            var data = pedicate.Main();
           
            return data;
        }

        // GET: api/example/5
        [HttpGet]
        [Route("api/example/get2")]
        public string Get2()
        {
            return pedicate.PredicateMain2();
        }

        // GET: api/example/5
        [HttpGet]
        [Route("api/example/get3")]
        public string Get3()
        {
            return pedicate.PredicateMain3();
        }

        [HttpGet]
        [Route("api/example/get4")]
        public string Get4()
        {
            return pedicate.PredicateMain4();
        }

        [HttpGet]
        [Route("api/example/get5")]
        public Employee Get5()
        {
            return pedicate.PredicateMain5();
        }

        [HttpGet]
        [Route("api/example/get6")]
        public string Get6()
        {
            return pedicate.DelegateMulticast();
        }

        [HttpGet]
        [Route("api/example/get7")]
        public string Get7()
        {
            return pedicate.DelegateSinglecast();
        }

        [HttpGet]
        [Route("api/example/get8")]
        public string Get8()
        {
            return pedicate.DelegateGeneric();
        }

    }
}
