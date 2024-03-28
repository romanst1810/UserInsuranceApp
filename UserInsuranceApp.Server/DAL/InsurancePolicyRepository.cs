using Microsoft.EntityFrameworkCore;
using UserInsuranceApp.Server.Core.Interfaces;
using UserInsuranceApp.Server.Core.Models;

namespace UserInsuranceApp.Server.DAL
{
    public class InsurancePolicyRepository : IInsurancePolicyRepository
    {
        private readonly AppDbContext _context;

        public InsurancePolicyRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<InsurancePolicy>> GetInsurancePolicies()
        {
            return await _context.InsurancePolicies.ToListAsync();
        }

        public async Task<InsurancePolicy> GetInsurancePolicy(int id)
        {
            return await _context.InsurancePolicies.FindAsync(id);
        }

        public async Task AddInsurancePolicy(InsurancePolicy insurancePolicy)
        {
            _context.InsurancePolicies.Add(insurancePolicy);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateInsurancePolicy(InsurancePolicy insurancePolicy)
        {
            _context.Entry(insurancePolicy).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task DeleteInsurancePolicy(int id)
        {
            var insurancePolicy = await _context.InsurancePolicies.FindAsync(id);
            _context.InsurancePolicies.Remove(insurancePolicy);
            await _context.SaveChangesAsync();
        }
    }
}
