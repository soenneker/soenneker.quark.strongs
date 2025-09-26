using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.Quark.Strongs.Tests;

[Collection("Collection")]
public sealed class StrongTests : FixturedUnitTest
{
    public StrongTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
    }

    [Fact]
    public void Default()
    {

    }
}
