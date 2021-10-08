using Demo.Micro.Models;
using System.Collections.Generic;
using System.Linq;

namespace Demo.Micro.Data
{
    public class CertificationRepository : ICertificationRepository
    {
        public readonly CertificationDbContext _context;
        public CertificationRepository(CertificationDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Certification> GetAllCertifications()
        {
            var certifications = _context.Certifications.ToList();

            return certifications;
        }

        public Certification GetCertificationById(int Id)
        {
            return _context.Certifications.FirstOrDefault(p => p.Id == Id);
        }
             

        public bool UpdateCertificationById(Certification certification)
        {
            _context.Entry(_context.Certifications.FirstOrDefault(x => x.Id == certification.Id)).CurrentValues.SetValues(certification);
            return (_context.SaveChanges()) > 0;
        }
    }
}
