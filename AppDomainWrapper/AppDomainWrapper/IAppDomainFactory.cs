namespace AppDomainWrapper;

public interface IAppDomainFactory
{
    /// <inheritdoc cref="System.AppDomain.CurrentDomain" />
    IAppDomain CurrentDomain { get; }

#if NET8_0_OR_GREATER
    /// <inheritdoc cref="System.AppDomain.CreateDomain(string)" />
    [System.Obsolete("Creating and unloading AppDomains is not supported and throws an exception.", DiagnosticId = "SYSLIB0024", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
#endif
    IAppDomain CreateDomain(string friendlyName);
}