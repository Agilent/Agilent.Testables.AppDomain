namespace AppDomainWrapper;

public class AppDomain : IAppDomain
{
    private readonly System.AppDomain _appDomain;

    public AppDomain(System.AppDomain appDomain)
    {
        _appDomain = appDomain;
    }

    /// <inheritdoc />
    public string BaseDirectory => _appDomain.BaseDirectory;

    /// <inheritdoc />
    public string? DynamicDirectory => _appDomain.DynamicDirectory;

    /// <inheritdoc />
    public string FriendlyName => _appDomain.FriendlyName;

    /// <inheritdoc />
    public int Id => _appDomain.Id;

    /// <inheritdoc />
    public bool IsFullyTrusted => _appDomain.IsFullyTrusted;

    /// <inheritdoc />
    public bool IsHomogenous => _appDomain.IsHomogenous;

    /// <inheritdoc />
    public bool MonitoringIsEnabled
    {
        get => System.AppDomain.MonitoringIsEnabled;
        set => System.AppDomain.MonitoringIsEnabled = value;
    }

    /// <inheritdoc />
    public long MonitoringSurvivedMemorySize => _appDomain.MonitoringSurvivedMemorySize;

    /// <inheritdoc />
    public long MonitoringSurvivedProcessMemorySize => System.AppDomain.MonitoringSurvivedProcessMemorySize;

    /// <inheritdoc />
    public long MonitoringTotalAllocatedMemorySize => _appDomain.MonitoringTotalAllocatedMemorySize;

    /// <inheritdoc />
    public TimeSpan MonitoringTotalProcessorTime => _appDomain.MonitoringTotalProcessorTime;

    /// <inheritdoc />
    public System.Security.PermissionSet PermissionSet => _appDomain.PermissionSet;

    /// <inheritdoc />
    public string? RelativeSearchPath => _appDomain.RelativeSearchPath;

    /// <inheritdoc />
    public AppDomainSetup SetupInformation => _appDomain.SetupInformation;

    /// <inheritdoc />
    public bool ShadowCopyFiles => _appDomain.ShadowCopyFiles;

    /// <inheritdoc />
    public void AppendPrivatePath(string? path) => _appDomain.AppendPrivatePath(path);

    /// <inheritdoc />
    public string ApplyPolicy(string assemblyName) => _appDomain.ApplyPolicy(assemblyName);

    /// <inheritdoc />
    public void ClearPrivatePath() => _appDomain.ClearPrivatePath();

    /// <inheritdoc />
    public void ClearShadowCopyPath() => _appDomain.ClearShadowCopyPath();

    /// <inheritdoc />
    public System.Runtime.Remoting.ObjectHandle? CreateInstance(string assemblyName, string typeName) =>
        _appDomain.CreateInstance(assemblyName, typeName);

    /// <inheritdoc />
    public System.Runtime.Remoting.ObjectHandle? CreateInstance(string assemblyName, string typeName, object?[]? activationAttributes) =>
        _appDomain.CreateInstance(assemblyName, typeName, activationAttributes);

    /// <inheritdoc />
    public System.Runtime.Remoting.ObjectHandle? CreateInstance(string assemblyName, string typeName, bool ignoreCase, System.Reflection.BindingFlags bindingAttr, System.Reflection.Binder? binder, object?[]? args, System.Globalization.CultureInfo? culture, object?[]? activationAttributes) =>
        _appDomain.CreateInstance(assemblyName, typeName, ignoreCase, bindingAttr, binder, args, culture, activationAttributes);

    /// <inheritdoc />
    public object? CreateInstanceAndUnwrap(string assemblyName, string typeName) =>
        _appDomain.CreateInstanceAndUnwrap(assemblyName, typeName);

    /// <inheritdoc />
    public object? CreateInstanceAndUnwrap(string assemblyName, string typeName, object?[]? activationAttributes) =>
        _appDomain.CreateInstanceAndUnwrap(assemblyName, typeName, activationAttributes);

    /// <inheritdoc />
    public object? CreateInstanceAndUnwrap(string assemblyName, string typeName, bool ignoreCase, System.Reflection.BindingFlags bindingAttr, System.Reflection.Binder? binder, object?[]? args, System.Globalization.CultureInfo? culture, object?[]? activationAttributes) =>
        _appDomain.CreateInstanceAndUnwrap(assemblyName, typeName, ignoreCase, bindingAttr, binder, args, culture, activationAttributes);

    /// <inheritdoc />
    public System.Runtime.Remoting.ObjectHandle? CreateInstanceFrom(string assemblyFile, string typeName, bool ignoreCase, System.Reflection.BindingFlags bindingAttr, System.Reflection.Binder? binder, object?[]? args, System.Globalization.CultureInfo? culture, object?[]? activationAttributes) =>
        _appDomain.CreateInstanceFrom(assemblyFile, typeName, ignoreCase, bindingAttr, binder, args, culture, activationAttributes);

    /// <inheritdoc />
    public System.Runtime.Remoting.ObjectHandle? CreateInstanceFrom(string assemblyFile, string typeName, object?[]? activationAttributes) =>
        _appDomain.CreateInstanceFrom(assemblyFile, typeName, activationAttributes);

    /// <inheritdoc />
    public System.Runtime.Remoting.ObjectHandle? CreateInstanceFrom(string assemblyFile, string typeName) =>
        _appDomain.CreateInstanceFrom(assemblyFile, typeName);

    /// <inheritdoc />
    public object? CreateInstanceFromAndUnwrap(string assemblyFile, string typeName) =>
        _appDomain.CreateInstanceFromAndUnwrap(assemblyFile, typeName);

    /// <inheritdoc />
    public object? CreateInstanceFromAndUnwrap(string assemblyFile, string typeName, object?[]? activationAttributes) =>
        _appDomain.CreateInstanceFromAndUnwrap(assemblyFile, typeName, activationAttributes);

    /// <inheritdoc />
    public object? CreateInstanceFromAndUnwrap(string assemblyFile, string typeName, bool ignoreCase, System.Reflection.BindingFlags bindingAttr, System.Reflection.Binder? binder, object?[]? args, System.Globalization.CultureInfo? culture, object?[]? activationAttributes) =>
        _appDomain.CreateInstanceFromAndUnwrap(assemblyFile, typeName, ignoreCase, bindingAttr, binder, args, culture, activationAttributes);

    /// <inheritdoc />
    public int ExecuteAssembly(string assemblyFile, string?[]? args, byte[]? hashValue, System.Configuration.Assemblies.AssemblyHashAlgorithm hashAlgorithm) =>
        _appDomain.ExecuteAssembly(assemblyFile, args, hashValue, hashAlgorithm);

    /// <inheritdoc />
    public int ExecuteAssembly(string assemblyFile, string?[]? args) =>
        _appDomain.ExecuteAssembly(assemblyFile, args);

    /// <inheritdoc />
    public int ExecuteAssembly(string assemblyFile) =>
        _appDomain.ExecuteAssembly(assemblyFile);

    /// <inheritdoc />
    public int ExecuteAssemblyByName(string assemblyName) =>
        _appDomain.ExecuteAssemblyByName(assemblyName);

    /// <inheritdoc />
    public int ExecuteAssemblyByName(System.Reflection.AssemblyName assemblyName, params string?[]? args) =>
        _appDomain.ExecuteAssemblyByName(assemblyName, args);

    /// <inheritdoc />
    public int ExecuteAssemblyByName(string assemblyName, params string?[]? args) =>
        _appDomain.ExecuteAssemblyByName(assemblyName, args);

    /// <inheritdoc />
    public System.Reflection.Assembly[] GetAssemblies() => _appDomain.GetAssemblies();

    /// <inheritdoc />
    public int GetCurrentThreadId() => System.AppDomain.GetCurrentThreadId();

    /// <inheritdoc />
    public object? GetData(string name) => _appDomain.GetData(name);

    /// <inheritdoc />
    public bool? IsCompatibilitySwitchSet(string value) => _appDomain.IsCompatibilitySwitchSet(value);

    /// <inheritdoc />
    public bool IsDefaultAppDomain() => _appDomain.IsDefaultAppDomain();

    /// <inheritdoc />
    public bool IsFinalizingForUnload() => _appDomain.IsFinalizingForUnload();

    /// <inheritdoc />
    public System.Reflection.Assembly Load(byte[] rawAssembly) => _appDomain.Load(rawAssembly);

    /// <inheritdoc />
    public System.Reflection.Assembly Load(System.Reflection.AssemblyName assemblyRef) => _appDomain.Load(assemblyRef);

    /// <inheritdoc />
    public System.Reflection.Assembly Load(string assemblyString) => _appDomain.Load(assemblyString);

    /// <inheritdoc />
    public System.Reflection.Assembly Load(byte[] rawAssembly, byte[]? rawSymbolStore) => _appDomain.Load(rawAssembly, rawSymbolStore);

    /// <inheritdoc />
    public System.Reflection.Assembly[] ReflectionOnlyGetAssemblies() => _appDomain.ReflectionOnlyGetAssemblies();

    /// <inheritdoc />
    public void SetCachePath(string? path) => _appDomain.SetCachePath(path);

    /// <inheritdoc />
    public void SetData(string name, object? data) => _appDomain.SetData(name, data);

    /// <inheritdoc />
    public void SetDynamicBase(string? path) => _appDomain.SetDynamicBase(path);

    /// <inheritdoc />
    public void SetPrincipalPolicy(System.Security.Principal.PrincipalPolicy policy) => _appDomain.SetPrincipalPolicy(policy);

    /// <inheritdoc />
    public void SetShadowCopyFiles() => _appDomain.SetShadowCopyFiles();

    /// <inheritdoc />
    public void SetShadowCopyPath(string? path) => _appDomain.SetShadowCopyPath(path);

    /// <inheritdoc />
    public void SetThreadPrincipal(System.Security.Principal.IPrincipal principal) => _appDomain.SetThreadPrincipal(principal);

    /// <inheritdoc />
    public string ToString() => _appDomain.ToString();

    /// <inheritdoc />
    public void Unload(System.AppDomain domain) => System.AppDomain.Unload(domain);

    /// <inheritdoc />
    public event AssemblyLoadEventHandler? AssemblyLoad
    {
        add => _appDomain.AssemblyLoad += value;
        remove => _appDomain.AssemblyLoad -= value;
    }

    /// <inheritdoc />
    public event ResolveEventHandler? AssemblyResolve
    {
        add => _appDomain.AssemblyResolve += value;
        remove => _appDomain.AssemblyResolve -= value;
    }

    /// <inheritdoc />
    public event EventHandler? DomainUnload
    {
        add => _appDomain.DomainUnload += value;
        remove => _appDomain.DomainUnload -= value;
    }

    /// <inheritdoc />
    public event EventHandler<System.Runtime.ExceptionServices.FirstChanceExceptionEventArgs>? FirstChanceException
    {
        add => _appDomain.FirstChanceException += value;
        remove => _appDomain.FirstChanceException -= value;
    }

    /// <inheritdoc />
    public event EventHandler? ProcessExit
    {
        add => _appDomain.ProcessExit += value;
        remove => _appDomain.ProcessExit -= value;
    }

    /// <inheritdoc />
    public event ResolveEventHandler? ReflectionOnlyAssemblyResolve
    {
        add => _appDomain.ReflectionOnlyAssemblyResolve += value;
        remove => _appDomain.ReflectionOnlyAssemblyResolve -= value;
    }

    /// <inheritdoc />
    public event ResolveEventHandler? ResourceResolve
    {
        add => _appDomain.ResourceResolve += value;
        remove => _appDomain.ResourceResolve -= value;
    }

    /// <inheritdoc />
    public event ResolveEventHandler? TypeResolve
    {
        add => _appDomain.TypeResolve += value;
        remove => _appDomain.TypeResolve -= value;
    }

    /// <inheritdoc />
    public event UnhandledExceptionEventHandler? UnhandledException
    {
        add => _appDomain.UnhandledException += value;
        remove => _appDomain.UnhandledException -= value;
    }

}