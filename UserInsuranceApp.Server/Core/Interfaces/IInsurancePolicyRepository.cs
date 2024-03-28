using UserInsuranceApp.Server.Core.Models;

namespace UserInsuranceApp.Server.Core.Interfaces
{
    public interface IInsurancePolicyRepository
    {
        Task<IEnumerable<InsurancePolicy>> GetInsurancePolicies();
        Task<InsurancePolicy> GetInsurancePolicy(int id);
        Task AddInsurancePolicy(InsurancePolicy insurancePolicy);
        Task UpdateInsurancePolicy(InsurancePolicy insurancePolicy);
        Task DeleteInsurancePolicy(int id);
    }
}
