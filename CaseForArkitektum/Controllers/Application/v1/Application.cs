using CaseForArkitektum.Contracts;
using CaseForArkitektum.Controllers.Application.v1.Requests;

namespace CaseForArkitektum.Controllers.Application.v1
{
    public class Application : IApplication
    {
        private int _gs1ForetaksPrefiks = 7072913;
        private static int _lopeNummer = 0;
        //Vil kanskje endre dette til en DB Look up siden jeg ikke vet om dette kommer til å fungere 100%
        //Hvis dette fungerer 100% trengs det bare en DB Look up for å se hvilket tall som var sist on start up
        public long Create(CreateRequest request)
        {
            throw new NotImplementedException();
            // Legg til validering og ting som det, har ikke nok info til å skrive noe produktivt
            return GTIN13();
        }

        private long GTIN13()
        {
            long output = _gs1ForetaksPrefiks * 1000000;
            output += _lopeNummer * 10;
            output += ControllNumber(output);
            return output;
        }

        private int ControllNumber(long input)
        {
            return 9; //Jeg fant ikke algorytmen, men den skal inn her.
        }

        public bool ConnectPrierARColde(CreateARCodeInfo aRCode, long ftBID)
        {
            throw new NotImplementedException();
            return false;
        }
    }
}
