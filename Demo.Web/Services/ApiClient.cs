using Demo.Web.Models;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace Demo.Web.Services
{
    public class ApiClient : IApiClient
    {
        private readonly HttpClient _httpClient;

        public ApiClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<List<CertificationResponse>> GetAllCertificationsAsync()
        {
            var response = await _httpClient.GetAsync("http://localhost:5002/api/certifications");
            
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsAsync<List<CertificationResponse>>();
        }

        public async Task<CertificationResponse> GetCertificationById(int id)
        {
            var response = await _httpClient.GetAsync($"http://localhost:5002/api/certifications/{id}");
            if(response.StatusCode == HttpStatusCode.NotFound)
            {
                return null;
            }

            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsAsync<CertificationResponse>();
        }

        public async Task<bool> UpdateCertificationById(int id, CertificationResponse certificationResponse)
        {
            var response = await _httpClient.PutAsJsonAsync($"http://localhost:5002/api/certifications/{id}", certificationResponse);
            if (response.StatusCode == HttpStatusCode.NotFound)
            {
                return false;
            }

            response.EnsureSuccessStatusCode();
            return true;
        }
        
    }
}
