using Agilent.Testables.AppDomain.Abstractions;

namespace Agilent.Testables.AppDomain.Wrappers;

public class AppDomainFactory : IAppDomainFactory
{
    /// <inheritdoc />
    public IAppDomain CurrentDomain => new AppDomain(System.AppDomain.CurrentDomain);

    /// <inheritdoc />
    public IAppDomain CreateDomain(string friendlyName)
    {
        var domain = System.AppDomain.CreateDomain(friendlyName);
        return new AppDomain(domain);
    }
}