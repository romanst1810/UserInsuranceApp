using Core.Models;

namespace Core.Interfaces
{
    public interface IInsurancePolicyRepository
    {
        Task<IEnumerable<InsurancePolicy>> GetInsurancePoliciesForUser(int userId);
        Task<IEnumerable<InsurancePolicy>> GetInsurancePolicies();
        Task<InsurancePolicy> GetInsurancePolicy(int id);
        Task AddInsurancePolicy(InsurancePolicy insurancePolicy);
        Task UpdateInsurancePolicy(InsurancePolicy insurancePolicy);
        Task DeleteInsurancePolicy(int id);
    }
}
