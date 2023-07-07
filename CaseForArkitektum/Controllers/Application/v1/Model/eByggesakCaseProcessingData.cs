namespace CaseForArkitektum.Controllers.Application.v1.Model
{
    public class eByggesakCaseProcessingData
    {
        public long FtBID;

        public string Receipt;
        public string Resolution;
        public List<string> Missing;

        eByggesakCaseProcessingData()
        {
            Missing = new List<string>();
        }
    }
}
