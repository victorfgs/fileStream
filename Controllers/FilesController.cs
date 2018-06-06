using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace testestream.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilesController : ControllerBase
    {
        string baseFilePath = @"/home/victorfgs/Área de Trabalho/Research/Arquivos";
        // GET api/values
        [HttpGet("{fileName}")]
        public FileResult Get(string fileName)
        {
            var content = new FileStream(baseFilePath + $"/{fileName}",FileMode.Open, FileAccess.Read, FileShare.Read);
            var response = File(content, "application/octet-stream");//FileStreamResult
            return response;
        }

    }
}
