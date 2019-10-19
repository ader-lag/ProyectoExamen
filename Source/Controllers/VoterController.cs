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
    public class VoterController : ControllerBase
    {
        private readonly VoterService _voterService;
        public VoterController()
        {
            _voterService = new VoterService();
        }
        public Voter Get(int ci)
        {
            return _voterService.Get(ci);
        }
        [HttpGet]
        public List<Voter> GetAll()
        {
            return _voterService.Get();
        }
        public void Delete(Voter voter)
        {
            _voterService.Remove(voter);
        }
        public void Insert(Voter voter)
        {
            _voterService.Create(voter);
        }
        public void Update(string id, Voter voter)
        {
            _voterService.Update(id, voter);
        }
    }
}