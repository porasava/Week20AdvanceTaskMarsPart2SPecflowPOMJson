using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using Week20AdvanceTaskMarsPart2SPecflowPOMJson.Models;
using AventStack.ExtentReports.MarkupUtils;

namespace Week20AdvanceTaskMarsPart2SPecflowPOMJson.Utilities
{
    public static class JsonReader
    {
        public static List<ModelLogin> ReadLoginData(string filePath)
        {
            var jsonString = File.ReadAllText(filePath);
            var testData = JsonSerializer.Deserialize<TestData>(jsonString);

            if (testData != null && testData.Login.Any())
            {
                return testData.Login;
            }
            else
            {
                // Handle the case where no data is found or return an empty list
                return new List<ModelLogin>();
            }
        }
        public static List<_001_ModelPassword> ReadPasswordData(string filePath)
        {
            var jsonString = File.ReadAllText(filePath);
            var testData = JsonSerializer.Deserialize<TestDataPassword>(jsonString);
            return testData?.Password ?? new List<_001_ModelPassword>();
        }

        public static List<_002_ModelEducation> ReadEducationData(string filePath)
        {
            var jsonString = File.ReadAllText(filePath);
            var testData = JsonSerializer.Deserialize<TestDataEducation>(jsonString);
            return testData?.Education ?? new List<_002_ModelEducation>();

        }
        public static List<_003_ModelCertification> ReadCertificationData(string filePath)
        {
            var jsonString = File.ReadAllText(filePath);
            var testData = JsonSerializer.Deserialize<TestDataCertification>(jsonString);
            return testData?.Certification ?? new List<_003_ModelCertification>();
           
        }
        public static List<_004_ModelDescription> ReadDescriptionData(string filePath)
        {
            var jsonString = File.ReadAllText(filePath);
            var testData = JsonSerializer.Deserialize<TestDataDescription>(jsonString);

            return testData?.Description ?? new List<_004_ModelDescription>();
        }
        public static List<_005_ModelManageListing> ReadManageListingData(string filePath)
        {
            var jsonString = File.ReadAllText(filePath);
            var testData = JsonSerializer.Deserialize<TestDataManageListing>(jsonString);

            return testData?.ManageListing ?? new List<_005_ModelManageListing>();
        }
            public static List<_006_ModelManageRequest> ReadManageRequestData(string filePath)
            {
                var jsonString = File.ReadAllText(filePath);
                var testData = JsonSerializer.Deserialize<TestDataManageRequest>(jsonString);
                return testData?.ManageRequest ?? new List<_006_ModelManageRequest>();
            }
        }

   
}
