namespace Job_Application_Tracker.Classes
{
    public class JobApplication
    {
        public enum ApplicationStatus
        {
            Applied,
            Interview,
            Offer,
            Rejected,

        }
    
        public string CompanyName { get; set; }
        public string PositionTitle { get; set; }
        public DateTime ApplicationDate { get; set; }
        public DateTime? ResponseDate { get; set; }
        public int SalaryExpectation { get; set; }
        public ApplicationStatus Status { get; set; }


        public JobApplication(string companyName, string positionTitle, DateTime applicationDate, int salaryExpectation)
        {
            CompanyName = companyName;
            PositionTitle = positionTitle;
            ApplicationDate = applicationDate;
            SalaryExpectation = salaryExpectation;
            Status = ApplicationStatus.Applied;
        }

        public int GetDaysSinceApplied()
        {
            return (DateTime.Today - ApplicationDate.Date).Days;
        }

        public string GetSummary()
        {
            string response = ResponseDate.HasValue
                ? ResponseDate.Value.ToString("yyyy-mm-dd")
                : "No answer yet";

            return $"Company: {CompanyName}, Position: {PositionTitle}, Applied on: {ApplicationDate.ToString("yyyy-mm-dd")}," +
                $" Response: {response}, Salary Expectation: {SalaryExpectation}, Status: {Status}";
        }
        
        
    }
}
