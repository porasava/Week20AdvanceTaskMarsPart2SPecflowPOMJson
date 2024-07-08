using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week20AdvanceTaskMarsPart2SPecflowPOMJson.Models
{
    public class _003_ModelCertification
    {
        public string TestCaseId { get; set; }
        public string certificationName { get; set; }
        public string certificationFrom { get; set; }
        public string CertificationYear { get; set; }
        public string certificationNameDelete { get; set; }
        public string certificationNameEdit { get; set; }
        public string certificationFromEdit { get; set; }
        public string CertificationYearEdit { get; set; }
        public string certificationNameDeleteEdit { get; set; }
        public string certificationName2 { get; set; }
    }
    public class TestDataCertification
    {
        public List<_003_ModelCertification> Certification { get; set; }

    }
}
