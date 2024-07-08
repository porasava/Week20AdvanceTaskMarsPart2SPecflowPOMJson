using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week20AdvanceTaskMarsPart2SPecflowPOMJson.Models
{
    public class _006_ModelManageRequest
    {
        public string TestCaseId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public string Subcategory { get; set; }
        public string Tags { get; set; }
        public string SkillExchange { get; set; }
        public string UserName1 { get; set; }
        public string UserName2 { get; set; }
        public string Password { get; set; }
    }
    public class TestDataManageRequest
    {
        public List<_006_ModelManageRequest> ManageRequest { get; set; }

    }
}
