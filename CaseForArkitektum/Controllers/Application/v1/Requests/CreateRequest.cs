namespace CaseForArkitektum.Controllers.Application.v1.Requests
{
    public class CreateRequest
    {
        /*
        Informasjon for å skille tiltak på samme eiendom
        Prosjektnavn/nummer til søknadssystemet (to felter i FtB)
        Søker
        Marikkelnummer? Kan forandre seg gjennom søknaden
        Noe eiendomsinformasjon er ønskelig for å knytte ID til et prosjekt
        Knytter ID opp mot kvalitetsikringssystem
        FtB registerer systemet som har reservert ID
         */

        public string PropertyInfromation { get; set; } // Skal atagelig vis ikke være en string, heller ett eget objekt
        public string ProjectName { get; set; }
        public long ProjectNumber { get; set; }
        public string Applicant { get; set; } // Skal atagelig vis ikke være en string, heller ett eget objekt
        public long Marikkelnummer { get; set; } //Null ide hva dette er

    }
}
