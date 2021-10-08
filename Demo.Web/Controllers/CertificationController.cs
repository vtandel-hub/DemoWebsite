using Demo.Web.Models;
using Demo.Web.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Demo.Web.Controllers
{
    public class CertificationController : Controller
    {
        protected readonly IApiClient _apiClient;

        public CertificationController(ApiClient apiClient)
        {
            _apiClient = apiClient;
        }
        // GET: CertificationController
        public async Task<ActionResult> Index()
        {
            List<CertificationResponse> certifications = new List<CertificationResponse>();
            certifications = await _apiClient.GetAllCertificationsAsync();
            return View(certifications);
        }

        // GET: CertificationController/Details/5
        public async Task<ActionResult> Details(int id)
        {
            CertificationResponse certification = new CertificationResponse();
            certification = await _apiClient.GetCertificationById(id);
            return View(certification);
        }        

        // GET: CertificationController/Edit/5
        public async Task<ActionResult> Edit(int id)
        {
            CertificationResponse certification = new CertificationResponse();
            certification = await _apiClient.GetCertificationById(id);
            return View(certification);            
        }

        // POST: CertificationController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(int id, IFormCollection collection)
        {
            try
            {
                CertificationResponse certificationResponse = new CertificationResponse();
                certificationResponse.Id = id;
                certificationResponse.Code = collection["Code"];
                certificationResponse.Name = collection["Name"];
                certificationResponse.Cost = collection["Cost"];
                certificationResponse.Description = collection["Description"];
                certificationResponse.Prerequisite = collection["Prerequisite"];
                await _apiClient.UpdateCertificationById(id, certificationResponse);
                List<CertificationResponse> certifications = new List<CertificationResponse>();
                certifications = await _apiClient.GetAllCertificationsAsync();
                return RedirectToAction(nameof(Index), certifications);
            }
            catch
            {
                return View();
            }
        }         

        
    }
}
