using csharp_api.Helpers;
using csharp_api.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Services.Interfaces;

namespace csharp_api.Controllers
{
    [Route("api/[controller]")]
    public class ChantierController : Controller
    {

        private readonly IChantierService _chantierService;

        public ChantierController(IChantierService chantierService)
        {
            _chantierService = chantierService;
        }

        [HttpGet]
        public async Task<ActionResult> GetOneChantier()
        {
            try
            {
                ActionResult result = StatusCode(500);

                Chantier chantier = await _chantierService.FindChantier(RandomHelper.GetRandomInt(0, 999));
                if (chantier != null)
                {
                    result = Ok(chantier);
                }

                return result;
            }
            catch (Exception e)
            {
                return StatusCode(500);
            }
        }

        [HttpPost]
        public async Task<ActionResult> UpdateChantier()
        {
            try
            {
                ActionResult result = StatusCode(500);

                Chantier chantier = await _chantierService.UpdateChantier(RandomHelper.GetRandomInt(0, 999));

                if(chantier != null)
                {
                    result = Ok(chantier);
                }

                return result;
            } catch(Exception e)
            {
                return StatusCode(500);
            }
        }
    }
}
