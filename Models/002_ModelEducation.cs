using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week20AdvanceTaskMarsPart2SPecflowPOMJson.Models
{
    public class _002_ModelEducation
    {
        public string TestCaseId { get; set; }
        public string UniversityName { get; set; }
        public string Country { get; set; }
        public string Title { get; set; }
        public string Degree { get; set; }
        public string YearOfGraduate { get; set; }
        public string UniversityNameDelete { get; set; }
        public string UniversityNameEdit { get; set; }
        public string CountryEdit { get; set; }
        public string TitleEdit { get; set; }
        public string DegreeEdit { get; set; }
        public string YearOfGraduateEdit { get; set; }
        public string UniversityNameDeleteEdit { get; set; }
        public string UniversityName2 { get; set; }
        public string UniversityNameEdit2 { get; set; }
        public string Scenario { get; set; }
        public string Data { get; set; }
    }
    public class TestDataEducation
    {
        public List<_002_ModelEducation> Education { get; set; }

    }
}
