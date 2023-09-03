using DrivingSchool.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DrivingSchool.API.Controllers
{
    [Route("api/[controller]")]
    public class CandidateController : Controller
    {
        private readonly ICandidateRepository _candidateRepository;

        public CandidateController(ICandidateRepository candidateRepository) 
        {
            _candidateRepository = candidateRepository;
        }

        [HttpGet]
        [Route("candidates")]
        public async Task<IActionResult> Get()
        {
            return Ok( _candidateRepository.GetAllCandidate());
        }
    }
}
