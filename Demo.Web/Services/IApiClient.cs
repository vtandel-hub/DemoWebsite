using Demo.Web.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Demo.Web.Services
{
    public interface IApiClient
    {
        Task<List<CertificationResponse>> GetAllCertificationsAsync();
        Task<CertificationResponse> GetCertificationById(int id);

        Task<bool> UpdateCertificationById(int id, CertificationResponse certificationResponse);
    }
}
