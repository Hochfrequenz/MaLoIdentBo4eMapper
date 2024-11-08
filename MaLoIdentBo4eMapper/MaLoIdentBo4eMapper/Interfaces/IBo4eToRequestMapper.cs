using MaLoIdentBo4eMapper.Models;

namespace MaLoIdentBo4eMapper.Interfaces;

/// <summary>
/// defines a class that can map boneycombs BO4E (<typeparamref name="TBoneyComb"/>) to  MaLo Ident Requests (by a LIEF)
/// </summary>
public interface IBo4eToRequestMapper<TBoneyComb>
{
    /// <summary>
    /// maps a BO4E object of type <typeparamref name="TBoneyComb"/> to a MaLo Ident model
    /// </summary>
    /// <param name="request">the request to map</param>
    /// <returns>the mapped BO4E object/BoneyComb</returns>
    MaLoIdentRequestAndQueryParameters MapToRequest(TBoneyComb request);
}
