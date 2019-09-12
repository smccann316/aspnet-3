using Microsoft.AspNetCore.Mvc;
using Speaker.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Speaker.Controllers
{
    public class ConferenceController : Controller 
    {
        public ConferenceController(IConferenceService service)
        {

        }
    }
}
