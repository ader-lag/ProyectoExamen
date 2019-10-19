using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Source.Models;

namespace ProyectoVotaciones.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PartyController : ControllerBase
    {
        private readonly PartyService _partyService;
        public PartyController()
        {
            _partyService = new PartyService();
        }
        public Party Get(string abbreviation)
        {
            return _partyService.Get(abbreviation);
        }
        [HttpGet]
        public List<Party> GetAll()
        {
            return _partyService.Get();
        }
        public void Delete(Party party)
        {
            _partyService.Remove(party);
        }
        public void Insert(Party party)
        {
            _partyService.Create(party);
        }
        public void Update(string id, Party partyIn)
        {
            _partyService.Update(id, partyIn);
        }
    }
}