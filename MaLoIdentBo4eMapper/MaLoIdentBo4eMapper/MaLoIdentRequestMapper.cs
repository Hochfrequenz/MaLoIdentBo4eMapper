using MaLoIdentBo4eMapper.Interfaces;
using MaLoIdentBo4eMapper.Models;
using MaLoIdentModels;

namespace MaLoIdentBo4eMapper;

/// <summary>
/// class that does something
/// </summary>
public class MaLoIdentRequestMapper
    : IRequestToBo4eMapper<BOneyComb>,
        IBo4eToRequestMapper<BOneyComb>
{
    public BOneyComb MapRequestToBo4e(MaLoIdentRequestAndQueryParameters request)
    {
        return new BOneyComb
        {
            Transaktionsdaten = new Dictionary<string, string>
            {
                { "foo", request.TransactionId.ToString() },
            },
        };
    }

    public MaLoIdentRequestAndQueryParameters MapToRequest(BOneyComb request)
    {
        if (request?.Transaktionsdaten?.TryGetValue("foo", out var fooValue) == true)
        {
            return new MaLoIdentRequestAndQueryParameters
            {
                IdentificationParameter = new IdentificationParameter(),
                TransactionId = Guid.Parse(fooValue),
                CreationDateTime = default,
            };
        }

        throw new NotImplementedException("todo");
    }
}
