namespace CaseForArkitektum.Controllers.Application.v1.Requests
{
    public class CreateARCodeInfo
    {
        public string ApplicationType { get; set; }
        public string Address { get; set; }
        public string Municipality { get; set; }
        public string MeasureType { get; set; }
        public string Dispensation { get; set; }
    }
}
