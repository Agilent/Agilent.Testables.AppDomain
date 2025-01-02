# Agilent.Testables.AppDomain

This package contains an abstraction of the static `System.AppDomain` class found in .NET Framework 4.8 and above. It allows for an `IAppDominFactory` interface to be used instead of the static class and for mocks to be created.

## Usage

1. Pass `IAppDomainFactory` as a dependency _via_ the constructor into the class utilize `IAppDomain`:
```csharp
public class TestableClass
{
    private readonly IAppDomainFactory _appDomainFactory;

    public TestableClass(IAppDomainFactory appDomainFactory)
    {
        _appDomainFactory = appDomainFactory;
    }

    public string GetBaseDirectory()
    {
        IAppDomain appDomain = _appDomainFactory.CurrentDomain;
        return _appDomain.BaseDirectory;
    }
}
```
2. In your IOC Container register `IAppDomainFactory` and `Agilent.Testables.AppDomainFactory`:
```csharp
_services.AddTransient<IAppDomainFactory, AppDomainFactory>();
```
3. In your tests, setup and use IAppDomainFactory and IAppDomain as required:
```csharp
    [TestMethod]
    public void Should_GetBaseDirectory()
    {
        // Arrange
        var baseDirectory = @"C:\AppBaseDirectory";
        var mockAppDomain = new Mock<IAppDomain>();
        mockAppDomain.Setup(x => x.BaseDirectory).Returns(baseDirectory);
        var mockAppDomainFactory = new Mock<IAppDomainFactory>();
        mockAppDomainFactory.Setup(x => x.CurrentDomain).Returns(mockAppDomain.Object);
        var sut = new TestableClass(mockAppDomainFactory.Object);

        // Act
        var result = sut.GetBaseDirectory();

        // Assert
        result.Should().Be(baseDirectory);
    }
```
