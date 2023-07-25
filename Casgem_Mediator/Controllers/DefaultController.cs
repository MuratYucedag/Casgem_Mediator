using Casgem_Mediator.MediatorPattern.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Casgem_Mediator.Controllers
{
    public class DefaultController : Controller
    {
        private readonly IMediator _meditor;
        public DefaultController(IMediator meditor)
        {
            _meditor = meditor;
        }
        public async Task<IActionResult> Index()
        {
            var values =await _meditor.Send(new GetProductQuery());
            return View(values);
        }
    }
}
