using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week20AdvanceTaskMarsPart2SPecflowPOMJson.Models
{
    public class _005_ModelManageListing
    {
        public string TestCaseId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public string SubCategory { get; set; }
        public string Tags { get; set; }
        public string SkillExchange { get; set; }
        public string TitleEdit { get; set; }
        public string DescriptionEdit { get; set; }
        public string CategoryEdit { get; set; }
        public string SubCategoryEdit { get; set; }
        public string TagsEdit { get; set; }
        public string SkillExchangeEdit { get; set; }
        public string LocationType { get; set; }
        


    }
    public class TestDataManageListing
    {
        public List<_005_ModelManageListing> ManageListing { get; set; }

    }
}
