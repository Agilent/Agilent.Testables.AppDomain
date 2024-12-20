using System.Diagnostics.CodeAnalysis;
using Snapshooter;
using Snapshooter.MSTest;
using static System.Reflection.BindingFlags;

namespace AppDomainWrapper.Tests;
[TestClass]
[ExcludeFromCodeCoverage]
public class ApiParityTests
{


    [TestMethod]
    public void MessageBox()
    {
        AssertParity(
            referenceType: typeof(System.AppDomain),
            abstractionType: typeof(AppDomain)
        );
    }

    private static void AssertParity(Type referenceType, Type abstractionType)
    {
        IEnumerable<string> GetMembers(Type type)
        {
            return type
                .GetMembers(bindingAttr: Instance | Static | Public | FlattenHierarchy)
                .Select(x => x.ToString())
                .OrderBy(x => x, StringComparer.Ordinal);
        }

        var referenceMembers = GetMembers(referenceType);
        var abstractionMembers = GetMembers(abstractionType);
        var diff = new ApiDiff(
            extraMembers: abstractionMembers.Except(referenceMembers),
            missingMembers: referenceMembers.Except(abstractionMembers)
        );
        Snapshot.Match(diff, SnapshotNameExtension.Create(SnapshotSuffix));
    }


#if NET48
        private const string SnapshotSuffix = ".NET Framework 4.8";

#elif NET8_0
        private const string SnapshotSuffix = ".NET 8.0";
#elif NET9_0
    private const string SnapshotSuffix = ".NET 9.0";
#else
#error Unknown target framework.
#endif

    private readonly struct ApiDiff
    {
        public ApiDiff(IEnumerable<string> extraMembers, IEnumerable<string> missingMembers)
        {
            ExtraMembers = extraMembers.ToArray();
            MissingMembers = missingMembers.ToArray();

        }

        public string[] ExtraMembers { get; }
        public string[] MissingMembers { get; }
    }
}
