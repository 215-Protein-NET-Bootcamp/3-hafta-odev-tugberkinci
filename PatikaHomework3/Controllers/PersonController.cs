using Microsoft.AspNetCore.Mvc;
using PatikaHomework3.Service.IServices;

namespace PatikaHomework3.Controllers
{
    [Route("[Controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly IPersonService _personService;

        public PersonController(IPersonService personService)
        {
            _personService = personService;
        }

    }
}
