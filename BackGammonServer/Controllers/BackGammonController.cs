using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BackGammonServerBL.Models;

namespace BackGammonServer.Controllers
{
    [Route("BackGammonAPI")]
    [ApiController]
    public class BackGammonController : ControllerBase
    {
        BackGammonDBContext context;
        public BackGammonController(BackGammonDBContext context)
        {
            this.context = context;
        }
    }
}
