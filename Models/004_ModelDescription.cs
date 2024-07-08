using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week20AdvanceTaskMarsPart2SPecflowPOMJson.Models
{
    public class _004_ModelDescription
    {
        public string TestCaseId { get; set; }
        public string Description { get; set; }
        public string OriginalDescription { get; set; }
    }
    public class TestDataDescription
    {
        public List<_004_ModelDescription> Description { get; set; }

    }
}
