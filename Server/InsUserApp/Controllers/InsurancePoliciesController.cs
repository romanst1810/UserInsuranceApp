using Core.Models;
using DAL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InsUserApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InsurancePoliciesController : ControllerBase
    {
        private readonly InsurancePolicyRepository _repository;

        public InsurancePoliciesController(InsurancePolicyRepository repository)
        {
            _repository = repository;
        }

        // GET: api/InsurancePolicies
        [HttpGet]
        public async Task<IEnumerable<InsurancePolicy>> GetInsurancePolicies()
        {
            return await _repository.GetInsurancePolicies();
        }

        // GET: api/InsurancePolicies/5
        [HttpGet("{id}")]
        public async Task<ActionResult<InsurancePolicy>> GetInsurancePolicy(int id)
        {
            var insurancePolicy = await _repository.GetInsurancePolicy(id);

            return insurancePolicy;
        }

        // POST: api/InsurancePolicies
        [HttpPost]
        public async Task<ActionResult<InsurancePolicy>> AddInsurancePolicy(InsurancePolicy insurancePolicy)
        {
            await _repository.AddInsurancePolicy(insurancePolicy);

            return CreatedAtAction("GetInsurancePolicy", new { id = insurancePolicy.PolicyNumber }, insurancePolicy);
        }

        // PUT: api/InsurancePolicies/5
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateInsurancePolicy(int id, InsurancePolicy insurancePolicy)
        {
            await _repository.UpdateInsurancePolicy(insurancePolicy);

            return NoContent();
        }

        // DELETE: api/InsurancePolicies/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteInsurancePolicy(int id)
        {
            await _repository.DeleteInsurancePolicy(id);

            return NoContent();
        }


        [HttpGet("user/{userId}/policies")]
        public IActionResult GetInsurancePoliciesForUser(int userId)
        {
            var policies = _repository.GetInsurancePoliciesForUser(userId);

            if (policies == null)
            {
                return NotFound();
            }

            return Ok(policies);
        }
    }
}