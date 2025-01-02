namespace AppDomainWrapper;

public interface IAppDomain
{
    /// <inheritdoc cref="System.AppDomain.BaseDirectory"/>
    string BaseDirectory { get; }

    /// <inheritdoc cref="System.AppDomain.DynamicDirectory"/>
    string? DynamicDirectory { get; }

    /// <inheritdoc cref="System.AppDomain.FriendlyName"/>
    string FriendlyName { get; }

    /// <inheritdoc cref="System.AppDomain.Id"/>
    int Id { get; }

    /// <inheritdoc cref="System.AppDomain.IsFullyTrusted"/>
    bool IsFullyTrusted { get; }

    /// <inheritdoc cref="System.AppDomain.IsHomogenous"/>
    bool IsHomogenous { get; }

    /// <inheritdoc cref="System.AppDomain.MonitoringIsEnabled"/>
    bool MonitoringIsEnabled { get; set; }

    /// <inheritdoc cref="System.AppDomain.MonitoringSurvivedMemorySize"/>
    long MonitoringSurvivedMemorySize { get; }

    /// <inheritdoc cref="System.AppDomain.MonitoringSurvivedProcessMemorySize"/>
    long MonitoringSurvivedProcessMemorySize { get; }

    /// <inheritdoc cref="System.AppDomain.MonitoringTotalAllocatedMemorySize"/>
    long MonitoringTotalAllocatedMemorySize { get; }

    /// <inheritdoc cref="System.AppDomain.MonitoringTotalProcessorTime"/>
    TimeSpan MonitoringTotalProcessorTime { get; }

    /// <inheritdoc cref="System.AppDomain.PermissionSet"/>
#if NET8_0_OR_GREATER
    [System.Obsolete("Code Access Security is not supported or honored by the runtime.", DiagnosticId = "SYSLIB0003", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
#endif
    System.Security.PermissionSet PermissionSet { get; }

    /// <inheritdoc cref="System.AppDomain.RelativeSearchPath"/>
    string? RelativeSearchPath { get; }

    /// <inheritdoc cref="System.AppDomain.SetupInformation"/>
    AppDomainSetup SetupInformation { get; }

    /// <inheritdoc cref="System.AppDomain.ShadowCopyFiles"/>
    bool ShadowCopyFiles { get; }

    /// <inheritdoc cref="System.AppDomain.AppendPrivatePath(string)"/>
    [System.Obsolete("AppDomain.AppendPrivatePath has been deprecated and is not supported.")]
    void AppendPrivatePath(string? path);

    /// <inheritdoc cref="System.AppDomain.ApplyPolicy(string)"/>
    string ApplyPolicy(string assemblyName);

    /// <inheritdoc cref="System.AppDomain.ClearPrivatePath"/>
    [System.Obsolete("AppDomain.ClearPrivatePath has been deprecated and is not supported.")]
    void ClearPrivatePath();

    /// <inheritdoc cref="System.AppDomain.ClearShadowCopyPath"/>
    [System.Obsolete("AppDomain.ClearShadowCopyPath has been deprecated and is not supported.")]
    void ClearShadowCopyPath();

    /// <inheritdoc cref="System.AppDomain.CreateInstance(string, string)"/>
    System.Runtime.Remoting.ObjectHandle? CreateInstance(string assemblyName, string typeName);

    /// <inheritdoc cref="System.AppDomain.CreateInstance(string, string, object?[])"/>
    System.Runtime.Remoting.ObjectHandle? CreateInstance(string assemblyName, string typeName, object?[]? activationAttributes);


    /// <inheritdoc cref="System.AppDomain.CreateInstance(string, string, bool, System.Reflection.BindingFlags, System.Reflection.Binder?, object?[], System.Globalization.CultureInfo?, object?[])"/>
    System.Runtime.Remoting.ObjectHandle? CreateInstance(string assemblyName, string typeName, bool ignoreCase, System.Reflection.BindingFlags bindingAttr, System.Reflection.Binder? binder, object?[]? args, System.Globalization.CultureInfo? culture, object?[]? activationAttributes);

    /// <inheritdoc cref="System.AppDomain.CreateInstanceAndUnwrap(string, string)"/>
    object? CreateInstanceAndUnwrap(string assemblyName, string typeName);

    /// <inheritdoc cref="System.AppDomain.CreateInstanceAndUnwrap(string, string, object?[])"/>
    object? CreateInstanceAndUnwrap(string assemblyName, string typeName, object?[]? activationAttributes);

    /// <inheritdoc cref="System.AppDomain.CreateInstanceAndUnwrap(string, string, bool, System.Reflection.BindingFlags, System.Reflection.Binder?, object?[], System.Globalization.CultureInfo?, object?[])"/>
    object? CreateInstanceAndUnwrap(string assemblyName, string typeName, bool ignoreCase, System.Reflection.BindingFlags bindingAttr, System.Reflection.Binder? binder, object?[]? args, System.Globalization.CultureInfo? culture, object?[]? activationAttributes);

    /// <inheritdoc cref="System.AppDomain.CreateInstanceFrom(string, string, bool, System.Reflection.BindingFlags, System.Reflection.Binder?, object?[], System.Globalization.CultureInfo?, object?[])"/>
    System.Runtime.Remoting.ObjectHandle? CreateInstanceFrom(string assemblyFile, string typeName, bool ignoreCase, System.Reflection.BindingFlags bindingAttr, System.Reflection.Binder? binder, object?[]? args, System.Globalization.CultureInfo? culture, object?[]? activationAttributes);

    /// <inheritdoc cref="System.AppDomain.CreateInstanceFrom(string, string, object?[])"/>
    System.Runtime.Remoting.ObjectHandle? CreateInstanceFrom(string assemblyFile, string typeName, object?[]? activationAttributes);

    /// <inheritdoc cref="System.AppDomain.CreateInstanceFrom(string, string)"/>
    System.Runtime.Remoting.ObjectHandle? CreateInstanceFrom(string assemblyFile, string typeName);

    /// <inheritdoc cref="System.AppDomain.CreateInstanceFromAndUnwrap(string, string)"/>
    object? CreateInstanceFromAndUnwrap(string assemblyFile, string typeName);

    /// <inheritdoc cref="System.AppDomain.CreateInstanceFromAndUnwrap(string, string, object?[])"/>
    object? CreateInstanceFromAndUnwrap(string assemblyFile, string typeName, object?[]? activationAttributes);

    /// <inheritdoc cref="System.AppDomain.CreateInstanceFromAndUnwrap(string, string, bool, System.Reflection.BindingFlags, System.Reflection.Binder?, object?[], System.Globalization.CultureInfo?, object?[])"/>
    object? CreateInstanceFromAndUnwrap(string assemblyFile, string typeName, bool ignoreCase, System.Reflection.BindingFlags bindingAttr, System.Reflection.Binder? binder, object?[]? args, System.Globalization.CultureInfo? culture, object?[]? activationAttributes);

#if NET8_0_OR_GREATER
    [System.Obsolete("Code Access Security is not supported or honored by the runtime.", DiagnosticId = "SYSLIB0003", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
#endif
    /// <inheritdoc cref="System.AppDomain.ExecuteAssembly(string, string?[], byte[]?, System.Configuration.Assemblies.AssemblyHashAlgorithm)"/>
    int ExecuteAssembly(string assemblyFile, string?[]? args, byte[]? hashValue, System.Configuration.Assemblies.AssemblyHashAlgorithm hashAlgorithm);

    /// <inheritdoc cref="System.AppDomain.ExecuteAssembly(string, string?[])"/>
    int ExecuteAssembly(string assemblyFile, string?[]? args);

    /// <inheritdoc cref="System.AppDomain.ExecuteAssembly(string)"/>
    int ExecuteAssembly(string assemblyFile);

    /// <inheritdoc cref="System.AppDomain.ExecuteAssemblyByName(string)"/>
    int ExecuteAssemblyByName(string assemblyName);

    /// <inheritdoc cref="System.AppDomain.ExecuteAssemblyByName(System.Reflection.AssemblyName, string?[])"/>
    int ExecuteAssemblyByName(System.Reflection.AssemblyName assemblyName, params string?[]? args);

    /// <inheritdoc cref="System.AppDomain.ExecuteAssemblyByName(string, string?[])"/>
    int ExecuteAssemblyByName(string assemblyName, params string?[]? args);

    /// <inheritdoc cref="System.AppDomain.GetAssemblies"/>
    System.Reflection.Assembly[] GetAssemblies();

    /// <inheritdoc cref="System.AppDomain.GetCurrentThreadId"/>
    [System.Obsolete("AppDomain.GetCurrentThreadId has been deprecated because it does not provide a stable Id when managed threads are running on fibers (aka lightweight threads). To get a stable identifier for a managed thread, use the ManagedThreadId property on Thread instead.")]
    int GetCurrentThreadId();

    /// <inheritdoc cref="System.AppDomain.GetData(string)"/>
    object? GetData(string name);

    /// <inheritdoc cref="System.AppDomain.IsCompatibilitySwitchSet(string)"/>
    bool? IsCompatibilitySwitchSet(string value);


    /// <inheritdoc cref="System.AppDomain.IsDefaultAppDomain"/>
    bool IsDefaultAppDomain();

    /// <inheritdoc cref="System.AppDomain.IsFinalizingForUnload"/>
    bool IsFinalizingForUnload();

    /// <inheritdoc cref="System.AppDomain.Load(byte[])"/>
    System.Reflection.Assembly Load(byte[] rawAssembly);

    /// <inheritdoc cref="System.AppDomain.Load(System.Reflection.AssemblyName)"/>
    System.Reflection.Assembly Load(System.Reflection.AssemblyName assemblyRef);

    /// <inheritdoc cref="System.AppDomain.Load(string)"/>
    System.Reflection.Assembly Load(string assemblyString);

    /// <inheritdoc cref="System.AppDomain.Load(byte[], byte[]?)"/>
    System.Reflection.Assembly Load(byte[] rawAssembly, byte[]? rawSymbolStore);

    /// <inheritdoc cref="System.AppDomain.ReflectionOnlyGetAssemblies"/>
    System.Reflection.Assembly[] ReflectionOnlyGetAssemblies();

    /// <inheritdoc cref="System.AppDomain.SetCachePath(string)"/>
    [System.Obsolete("AppDomain.SetCachePath has been deprecated and is not supported.")]
    public void SetCachePath(string? path);


    /// <inheritdoc cref="System.AppDomain.SetData(string, object?)"/>
    void SetData(string name, object? data);

    /// <inheritdoc cref="System.AppDomain.SetDynamicBase(string)"/>
    [System.Obsolete("AppDomain.SetDynamicBase has been deprecated and is not supported.")]
    void SetDynamicBase(string? path);

    /// <inheritdoc cref="System.AppDomain.SetPrincipalPolicy(System.Security.Principal.PrincipalPolicy)"/>
    void SetPrincipalPolicy(System.Security.Principal.PrincipalPolicy policy);

    /// <inheritdoc cref="System.AppDomain.SetShadowCopyFiles"/>
    [System.Obsolete("AppDomain.SetShadowCopyFiles has been deprecated and is not supported.")]
    void SetShadowCopyFiles();

    /// <inheritdoc cref="System.AppDomain.SetShadowCopyPath(string)"/>
    [System.Obsolete("AppDomain.SetShadowCopyPath has been deprecated and is not supported.")]
    void SetShadowCopyPath(string? path);

    /// <inheritdoc cref="System.AppDomain.SetThreadPrincipal(System.Security.Principal.IPrincipal)"/>
    void SetThreadPrincipal(System.Security.Principal.IPrincipal principal);

    /// <inheritdoc cref="System.AppDomain.ToString"/>
    string ToString();

    /// <inheritdoc cref="System.AppDomain.Unload(System.AppDomain)"/>
#if NET8_0_OR_GREATER
    [System.Obsolete("Creating and unloading AppDomains is not supported and throws an exception.", DiagnosticId = "SYSLIB0024", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
#endif
    void Unload(System.AppDomain domain);

    /// <inheritdoc cref="System.AppDomain.AssemblyLoad"/>
    event AssemblyLoadEventHandler? AssemblyLoad;

    /// <inheritdoc cref="System.AppDomain.AssemblyResolve"/>
    event ResolveEventHandler? AssemblyResolve;

    /// <inheritdoc cref="System.AppDomain.DomainUnload"/>
    event EventHandler? DomainUnload;

    /// <inheritdoc cref="System.AppDomain.FirstChanceException"/>
    event EventHandler<System.Runtime.ExceptionServices.FirstChanceExceptionEventArgs>? FirstChanceException;

    /// <inheritdoc cref="System.AppDomain.ProcessExit"/>
    event EventHandler? ProcessExit;

    /// <inheritdoc cref="System.AppDomain.ReflectionOnlyAssemblyResolve"/>
    event ResolveEventHandler? ReflectionOnlyAssemblyResolve;

    /// <inheritdoc cref="System.AppDomain.ResourceResolve"/>
    event ResolveEventHandler? ResourceResolve;

    /// <inheritdoc cref="System.AppDomain.TypeResolve"/>
    event ResolveEventHandler? TypeResolve;

    /// <inheritdoc cref="System.AppDomain.UnhandledException"/>
    event UnhandledExceptionEventHandler? UnhandledException;
}