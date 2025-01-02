namespace AppDomainWrapper;

public class AppDomain(System.AppDomain appDomain) : IAppDomain
{
    /// <inheritdoc />
    public string BaseDirectory => appDomain.BaseDirectory;

    /// <inheritdoc />
    public string? DynamicDirectory => appDomain.DynamicDirectory;

    /// <inheritdoc />
    public string FriendlyName => appDomain.FriendlyName;

    /// <inheritdoc />
    public int Id => appDomain.Id;

    /// <inheritdoc />
    public bool IsFullyTrusted => appDomain.IsFullyTrusted;

    /// <inheritdoc />
    public bool IsHomogenous => appDomain.IsHomogenous;

    /// <inheritdoc />
    public bool MonitoringIsEnabled
    {
        get => System.AppDomain.MonitoringIsEnabled;
        set => System.AppDomain.MonitoringIsEnabled = value;
    }

    /// <inheritdoc />
    public long MonitoringSurvivedMemorySize => appDomain.MonitoringSurvivedMemorySize;

    /// <inheritdoc />
    public long MonitoringSurvivedProcessMemorySize => System.AppDomain.MonitoringSurvivedProcessMemorySize;

    /// <inheritdoc />
    public long MonitoringTotalAllocatedMemorySize => appDomain.MonitoringTotalAllocatedMemorySize;

    /// <inheritdoc />
    public TimeSpan MonitoringTotalProcessorTime => appDomain.MonitoringTotalProcessorTime;

    /// <inheritdoc />
    public System.Security.PermissionSet PermissionSet => appDomain.PermissionSet;

    /// <inheritdoc />
    public string? RelativeSearchPath => appDomain.RelativeSearchPath;

    /// <inheritdoc />
    public AppDomainSetup SetupInformation => appDomain.SetupInformation;

    /// <inheritdoc />
    public bool ShadowCopyFiles => appDomain.ShadowCopyFiles;

    /// <inheritdoc />
    public void AppendPrivatePath(string? path) => appDomain.AppendPrivatePath(path);

    /// <inheritdoc />
    public string ApplyPolicy(string assemblyName) => appDomain.ApplyPolicy(assemblyName);

    /// <inheritdoc />
    public void ClearPrivatePath() => appDomain.ClearPrivatePath();

    /// <inheritdoc />
    public void ClearShadowCopyPath() => appDomain.ClearShadowCopyPath();

    /// <inheritdoc />
    public System.Runtime.Remoting.ObjectHandle? CreateInstance(string assemblyName, string typeName) =>
        appDomain.CreateInstance(assemblyName, typeName);

    /// <inheritdoc />
    public System.Runtime.Remoting.ObjectHandle? CreateInstance(string assemblyName, string typeName, object?[]? activationAttributes) =>
        appDomain.CreateInstance(assemblyName, typeName, activationAttributes);

    /// <inheritdoc />
    public System.Runtime.Remoting.ObjectHandle? CreateInstance(string assemblyName, string typeName, bool ignoreCase, System.Reflection.BindingFlags bindingAttr, System.Reflection.Binder? binder, object?[]? args, System.Globalization.CultureInfo? culture, object?[]? activationAttributes) =>
        appDomain.CreateInstance(assemblyName, typeName, ignoreCase, bindingAttr, binder, args, culture, activationAttributes);

    /// <inheritdoc />
    public object? CreateInstanceAndUnwrap(string assemblyName, string typeName) =>
        appDomain.CreateInstanceAndUnwrap(assemblyName, typeName);

    /// <inheritdoc />
    public object? CreateInstanceAndUnwrap(string assemblyName, string typeName, object?[]? activationAttributes) =>
        appDomain.CreateInstanceAndUnwrap(assemblyName, typeName, activationAttributes);

    /// <inheritdoc />
    public object? CreateInstanceAndUnwrap(string assemblyName, string typeName, bool ignoreCase, System.Reflection.BindingFlags bindingAttr, System.Reflection.Binder? binder, object?[]? args, System.Globalization.CultureInfo? culture, object?[]? activationAttributes) =>
        appDomain.CreateInstanceAndUnwrap(assemblyName, typeName, ignoreCase, bindingAttr, binder, args, culture, activationAttributes);

    /// <inheritdoc />
    public System.Runtime.Remoting.ObjectHandle? CreateInstanceFrom(string assemblyFile, string typeName, bool ignoreCase, System.Reflection.BindingFlags bindingAttr, System.Reflection.Binder? binder, object?[]? args, System.Globalization.CultureInfo? culture, object?[]? activationAttributes) =>
        appDomain.CreateInstanceFrom(assemblyFile, typeName, ignoreCase, bindingAttr, binder, args, culture, activationAttributes);

    /// <inheritdoc />
    public System.Runtime.Remoting.ObjectHandle? CreateInstanceFrom(string assemblyFile, string typeName, object?[]? activationAttributes) =>
        appDomain.CreateInstanceFrom(assemblyFile, typeName, activationAttributes);

    /// <inheritdoc />
    public System.Runtime.Remoting.ObjectHandle? CreateInstanceFrom(string assemblyFile, string typeName) =>
        appDomain.CreateInstanceFrom(assemblyFile, typeName);

    /// <inheritdoc />
    public object? CreateInstanceFromAndUnwrap(string assemblyFile, string typeName) =>
        appDomain.CreateInstanceFromAndUnwrap(assemblyFile, typeName);

    /// <inheritdoc />
    public object? CreateInstanceFromAndUnwrap(string assemblyFile, string typeName, object?[]? activationAttributes) =>
        appDomain.CreateInstanceFromAndUnwrap(assemblyFile, typeName, activationAttributes);

    /// <inheritdoc />
    public object? CreateInstanceFromAndUnwrap(string assemblyFile, string typeName, bool ignoreCase, System.Reflection.BindingFlags bindingAttr, System.Reflection.Binder? binder, object?[]? args, System.Globalization.CultureInfo? culture, object?[]? activationAttributes) =>
        appDomain.CreateInstanceFromAndUnwrap(assemblyFile, typeName, ignoreCase, bindingAttr, binder, args, culture, activationAttributes);

    /// <inheritdoc />
    public int ExecuteAssembly(string assemblyFile, string?[]? args, byte[]? hashValue, System.Configuration.Assemblies.AssemblyHashAlgorithm hashAlgorithm) =>
        appDomain.ExecuteAssembly(assemblyFile, args, hashValue, hashAlgorithm);

    /// <inheritdoc />
    public int ExecuteAssembly(string assemblyFile, string?[]? args) =>
        appDomain.ExecuteAssembly(assemblyFile, args);

    /// <inheritdoc />
    public int ExecuteAssembly(string assemblyFile) =>
        appDomain.ExecuteAssembly(assemblyFile);

    /// <inheritdoc />
    public int ExecuteAssemblyByName(string assemblyName) =>
        appDomain.ExecuteAssemblyByName(assemblyName);

    /// <inheritdoc />
    public int ExecuteAssemblyByName(System.Reflection.AssemblyName assemblyName, params string?[]? args) =>
        appDomain.ExecuteAssemblyByName(assemblyName, args);

    /// <inheritdoc />
    public int ExecuteAssemblyByName(string assemblyName, params string?[]? args) =>
        appDomain.ExecuteAssemblyByName(assemblyName, args);

    /// <inheritdoc />
    public System.Reflection.Assembly[] GetAssemblies() => appDomain.GetAssemblies();

    /// <inheritdoc />
    public int GetCurrentThreadId() => System.AppDomain.GetCurrentThreadId();

    /// <inheritdoc />
    public object? GetData(string name) => appDomain.GetData(name);

    /// <inheritdoc />
    public bool? IsCompatibilitySwitchSet(string value) => appDomain.IsCompatibilitySwitchSet(value);

    /// <inheritdoc />
    public bool IsDefaultAppDomain() => appDomain.IsDefaultAppDomain();

    /// <inheritdoc />
    public bool IsFinalizingForUnload() => appDomain.IsFinalizingForUnload();

    /// <inheritdoc />
    public System.Reflection.Assembly Load(byte[] rawAssembly) => appDomain.Load(rawAssembly);

    /// <inheritdoc />
    public System.Reflection.Assembly Load(System.Reflection.AssemblyName assemblyRef) => appDomain.Load(assemblyRef);

    /// <inheritdoc />
    public System.Reflection.Assembly Load(string assemblyString) => appDomain.Load(assemblyString);

    /// <inheritdoc />
    public System.Reflection.Assembly Load(byte[] rawAssembly, byte[]? rawSymbolStore) => appDomain.Load(rawAssembly, rawSymbolStore);

    /// <inheritdoc />
    public System.Reflection.Assembly[] ReflectionOnlyGetAssemblies() => appDomain.ReflectionOnlyGetAssemblies();

    /// <inheritdoc />
    public void SetCachePath(string? path) => appDomain.SetCachePath(path);

    /// <inheritdoc />
    public void SetData(string name, object? data) => appDomain.SetData(name, data);

    /// <inheritdoc />
    public void SetDynamicBase(string? path) => appDomain.SetDynamicBase(path);

    /// <inheritdoc />
    public void SetPrincipalPolicy(System.Security.Principal.PrincipalPolicy policy) => appDomain.SetPrincipalPolicy(policy);

    /// <inheritdoc />
    public void SetShadowCopyFiles() => appDomain.SetShadowCopyFiles();

    /// <inheritdoc />
    public void SetShadowCopyPath(string? path) => appDomain.SetShadowCopyPath(path);

    /// <inheritdoc />
    public void SetThreadPrincipal(System.Security.Principal.IPrincipal principal) => appDomain.SetThreadPrincipal(principal);

    /// <inheritdoc />
    public string ToString() => appDomain.ToString();

    /// <inheritdoc />
    public void Unload(System.AppDomain domain) => System.AppDomain.Unload(domain);

    /// <inheritdoc />
    public event AssemblyLoadEventHandler? AssemblyLoad
    {
        add => appDomain.AssemblyLoad += value;
        remove => appDomain.AssemblyLoad -= value;
    }

    /// <inheritdoc />
    public event ResolveEventHandler? AssemblyResolve
    {
        add => appDomain.AssemblyResolve += value;
        remove => appDomain.AssemblyResolve -= value;
    }

    /// <inheritdoc />
    public event EventHandler? DomainUnload
    {
        add => appDomain.DomainUnload += value;
        remove => appDomain.DomainUnload -= value;
    }

    /// <inheritdoc />
    public event EventHandler<System.Runtime.ExceptionServices.FirstChanceExceptionEventArgs>? FirstChanceException
    {
        add => appDomain.FirstChanceException += value;
        remove => appDomain.FirstChanceException -= value;
    }

    /// <inheritdoc />
    public event EventHandler? ProcessExit
    {
        add => appDomain.ProcessExit += value;
        remove => appDomain.ProcessExit -= value;
    }

    /// <inheritdoc />
    public event ResolveEventHandler? ReflectionOnlyAssemblyResolve
    {
        add => appDomain.ReflectionOnlyAssemblyResolve += value;
        remove => appDomain.ReflectionOnlyAssemblyResolve -= value;
    }

    /// <inheritdoc />
    public event ResolveEventHandler? ResourceResolve
    {
        add => appDomain.ResourceResolve += value;
        remove => appDomain.ResourceResolve -= value;
    }

    /// <inheritdoc />
    public event ResolveEventHandler? TypeResolve
    {
        add => appDomain.TypeResolve += value;
        remove => appDomain.TypeResolve -= value;
    }

    /// <inheritdoc />
    public event UnhandledExceptionEventHandler? UnhandledException
    {
        add => appDomain.UnhandledException += value;
        remove => appDomain.UnhandledException -= value;
    }

}