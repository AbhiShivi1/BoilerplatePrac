using System.Collections.Generic;

namespace MYDEMOPROJ.Authentication.External
{
    public interface IExternalAuthConfiguration
    {
        List<ExternalLoginProviderInfo> Providers { get; }
    }
}
