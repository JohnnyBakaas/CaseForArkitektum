using CaseForArkitektum.Contracts;
using CaseForArkitektum.Controllers.Application.v1.Requests;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CaseForArkitektum.Controllers.Application.v1
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApplicationController : ControllerBase
    {
        private IApplication _application;
        public ApplicationController(IApplication application)
        {
            _application = application;
        }

        [HttpPost]
        public long Create([FromBody] CreateRequest request)
        {
            if (request == null) { throw new ArgumentNullException(nameof(request)); }
            return _application.Create(request);
        }

        [HttpPost]
        public bool UpdateInfo([FromBody] object request)
        {
            if (request == null) { throw new ArgumentNullException(nameof(request)); }
            return true;
        }

        [HttpPost]
        public bool ConnectPrierARColde([FromBody] CreateARCodeInfo aRCode, long ftBID)
        {
            return _application.ConnectPrierARColde(aRCode, ftBID);
        }
    }
}
