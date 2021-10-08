using Demo.Micro.Data;
using Demo.Micro.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Demo.Micro.Controllers
{
    [Route("api/certifications")]
    [ApiController]
    public class CertificationsController : Controller
    {
        private readonly ICertificationRepository _repository;
        
        public CertificationsController(ICertificationRepository repository)
        {
            _repository = repository;
        }
        //GET api/certifications
        [HttpGet]
        public ActionResult<IEnumerable<Certification>> GetAllCertifications()
        {
            var certifications = _repository.GetAllCertifications();

            return Ok(certifications);
        }

        //GET api/certifications/{id}
        [HttpGet("{id}")]
        public ActionResult<Certification> GetCertificationById(int id)
        {
            var commandItem = _repository.GetCertificationById(id);

            return Ok(commandItem);
        }

        //PUT api/certifications/{id}
        [HttpPut("{id}")]
        public ActionResult UpdateCertificationById(int id, [FromBody] Certification certification)
        {
            var commandItem = _repository.GetCertificationById(id);
            if(commandItem == null)
            {
                return NotFound();
            }
            _repository.UpdateCertificationById(certification);

            return NoContent();
        }
    }
}
