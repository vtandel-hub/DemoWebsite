using Demo.Micro.Models;
using System;
using System.Collections.Generic;

namespace Demo.Micro.Data
{
    public class MockCertificationRepository : ICertificationRepository
    {
        public IEnumerable<Certification> GetAllCertifications()
        {
            var certifications = new List<Certification>
            {
                new Certification {Id = 0, Code="AZ-900", Name= "Azure Fundamentals", Cost="$99", Description="test", Prerequisite="N/A"},
                new Certification {Id = 0, Code="AZ-204", Name= "Azure Developer", Cost="$160", Description="test", Prerequisite="AZ-900"}
            };

            return certifications;
        }

        public Certification GetCertificationById(int Id)
        {
            throw new NotImplementedException();
        }

        
        public bool UpdateCertificationById(Certification certification)
        {
            throw new NotImplementedException();
        }
    }
}
