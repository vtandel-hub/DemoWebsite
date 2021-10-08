using Demo.Micro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo.Micro.Data
{
    public interface ICertificationRepository
    {
        IEnumerable<Certification> GetAllCertifications();
        Certification GetCertificationById(int Id);
        bool UpdateCertificationById(Certification certification);
    }
}
