using CaseForArkitektum.Controllers.Application.v1.Requests;

namespace CaseForArkitektum.Contracts
{
    public interface IApplication
    {
        long Create(CreateRequest data);
        bool ConnectPrierARColde(CreateARCodeInfo aRCode, long ftBID);
    }
}
