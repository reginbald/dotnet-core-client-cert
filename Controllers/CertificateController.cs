using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.Certificate;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Certificate_Example.Controllers
{
    [Authorize(AuthenticationSchemes = CertificateAuthenticationDefaults.AuthenticationScheme)]
    [ApiController]
    [Route("[controller]")]
    public class CertificateController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return this.HttpContext.Connection.ClientCertificate?.ToString();
        }
    }
}
