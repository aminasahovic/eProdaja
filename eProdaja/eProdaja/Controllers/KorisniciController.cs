using AutoMapper;
using eProdaja.Model;
using eProdaja.Model.Requests;
using eProdaja.Services;
using eProdaja.Services.Database;
using Microsoft.AspNetCore.Mvc;

namespace eProdaja.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class KorisniciController : ControllerBase
    {
        private readonly IKorisniciService korisniciService;


        public KorisniciController( IKorisniciService service, IMapper mapper)
        {
            korisniciService= service;
        }

        [HttpGet]
        public IEnumerable<Model.Korisnici> Get()
        {
            return korisniciService.GetKorisnici();
        }
        [HttpPost]
        public Model.Korisnici Insert(KorisniciInsertRequest request)
        {
            return korisniciService.Insert(request);
        }
    }
}