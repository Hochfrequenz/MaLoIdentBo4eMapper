using FluentAssertions;
using MaLoIdentBo4eMapper;
using MaLoIdentBo4eMapper.Models;
using MaLoIdentModels;

namespace MaLoIdentBo4eMapperTests;

public class RequestsTests
{
    /// <summary>
    /// MWE of a round trip test
    /// </summary>
    [Fact]
    public void Test_RoundTrip()
    {
        var start = new MaLoIdentRequestAndQueryParameters
        {
            IdentificationParameter = new IdentificationParameter(),
            TransactionId = Guid.NewGuid(),
            CreationDateTime = default,
        };
        var mapper = new MaLoIdentRequestMapper();
        var bo4e = mapper.MapRequestToBo4e(start);
        bo4e.Should().NotBeNull();
        var roundTrip = mapper.MapToRequest(bo4e);
        roundTrip.Should().NotBeNull();
        roundTrip.Should().BeEquivalentTo(start);
    }
}
