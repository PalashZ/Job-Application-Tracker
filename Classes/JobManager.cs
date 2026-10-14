
namespace Job_Application_Tracker.Classes
{
    public class JobManager
    {
        public List <JobApplication> Applications = new List<JobApplication>();

        public int Count => Applications.Count;

        public void AddJob(JobApplication application)
        {
            Applications.Add(application);
        }

        public bool UpdateStatus (int index, JobApplication.ApplicationStatus newStatus)
        {
            if (index < 0 || index >= Applications.Count)
            {
                return false;
            }

            JobApplication job = Applications[index];
            job.Status = newStatus;

            if (newStatus == JobApplication.ApplicationStatus.Applied)
            {
                job.ResponseDate = null;
            }
            else if (job.ResponseDate == null)
            {
                job.ResponseDate = DateTime.Now.Date;
            }

            return true;
        }



    }
}
