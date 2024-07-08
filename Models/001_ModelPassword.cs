using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week20AdvanceTaskMarsPart2SPecflowPOMJson.Models
{
    public class _001_ModelPassword
    {
        public string TestCaseId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string CurrentPassword { get; set; }
        public string NewPassword { get; set; }
        public string ConfirmPassword { get; set; }
        public string CurrentPassword2 { get; set; }
        public string NewPassword2 { get; set; }
        public string ConfirmPassword2 { get; set; }

    }

    public class TestDataPassword
    {
        public List<_001_ModelPassword> Password { get; set; }

    }
}
