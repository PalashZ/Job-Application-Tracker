namespace Job_Application_Tracker.Classes
{

    // Detta är en klass som representerar en Jobapplication. Den innehåller information om företaget, positionen, ansökningsdatumet, svarsdagen, löneförväntningar och statusen för ansökan.
    public class JobApplication
    {
        // Detta är en enum som representerar de olika statusarna för en ansökan. Den kan vara Applied, Interview, Offer eller Rejected.
        public enum ApplicationStatus
        {
            Applied,
            Interview,
            Offer,
            Rejected,

        }
        // Detta är egenskaperna för JobApplication-klassen. De innehåller information om företaget, positionen, ansökningsdatumet, svarsdagen, löneförväntningar och statusen för ansökan.
        // Attributer för klassen JobApplication
        public string CompanyName { get; set; }
        public string PositionTitle { get; set; }
        public DateTime ApplicationDate { get; set; }
        public DateTime? ResponseDate { get; set; }
        public int SalaryExpectation { get; set; }
        public ApplicationStatus Status { get; set; }

        // Konstruktor för JobApplication-klassen. Den tar in företagsnamn, positionstitel, ansökningsdatum och löneförväntningar som parametrar och sätter statusen till Applied.
        public JobApplication(string companyName, string positionTitle, DateTime applicationDate, int salaryExpectation)
        {
            CompanyName = companyName;
            PositionTitle = positionTitle;
            ApplicationDate = applicationDate;
            SalaryExpectation = salaryExpectation;
            Status = ApplicationStatus.Applied;
        }

        // Metod som beräknar antalet dagar sedan ansökan skickades in. Den returnerar skillnaden mellan dagens datum och ansökningsdatumet i dagar.
        public int GetDaysSinceApplied()
        {
            return (DateTime.Today - ApplicationDate.Date).Days;
        }
        // Metod som returnerar en sammanfattning av ansökan. Den innehåller företagsnamn, positionstitel, ansökningsdatum, svarsdagen (om det finns något svar) och löneförväntningar.
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
