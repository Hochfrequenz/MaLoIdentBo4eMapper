using MaLoIdentBo4eMapper.Models;

namespace MaLoIdentBo4eMapper.Interfaces;

/// <summary>
/// defines a class that can map MaLo Ident Requests (by a LIEF) to BO4E (<typeparamref name="TBoneyComb"/>)
/// </summary>
public interface IRequestToBo4eMapper<TBoneyComb>
{
    /// <summary>
    /// maps a MaLo Ident Request <paramref name="request"/> to a BO4E object of type <typeparamref name="TBoneyComb"/>
    /// </summary>
    /// <param name="request">the request to map</param>
    /// <returns>the mapped BO4E object/BoneyComb</returns>
    TBoneyComb MapRequestToBo4e(MaLoIdentRequestAndQueryParameters request);
}
