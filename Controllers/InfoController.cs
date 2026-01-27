using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace AzureSamples.AzureSQL.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class InfoController : ControllerBase
    {
        private readonly ILogger<InfoController> _logger;
        private readonly IConfiguration _config;

        public InfoController(IConfiguration config, ILogger<InfoController> logger)
        {
            _logger = logger;
            _config = config;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var info = new
            {
                Name = "Azure SQL DB .NET REST API",
                Version = "1.0.0",
                Framework = ".NET Core 3.0",
                Description = "A modern REST API with .NET Core and Azure SQL, using Dapper",
                Technologies = new[]
                {
                    "ASP.NET Core 3.0",
                    "Azure SQL Database",
                    "Dapper ORM",
                    "System.Text.Json"
                },
                Endpoints = new[]
                {
                    "/customer/{customerId} - GET, PUT, PATCH, DELETE",
                    "/customers - GET",
                    "/info - GET (this endpoint)"
                }
            };

            return Ok(info);
        }
    }
}
