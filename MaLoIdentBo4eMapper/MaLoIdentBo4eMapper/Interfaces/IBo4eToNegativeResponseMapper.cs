using MaLoIdentBo4eMapper.Models;

namespace MaLoIdentBo4eMapper.Interfaces;

/// <summary>
/// defines a class that can map BO4E (<typeparamref name="TBoneyComb"/>) to negative MaLo Ident responses (by a VNB)
/// </summary>
public interface IBo4eToNegativeResponseMapper<TBoneyComb>
{
    /// <summary>
    /// maps a <typeparamref name="TBoneyComb"/> to the respective MaLo Ident model
    /// </summary>
    /// <param name="response">the response to map</param>
    /// <returns>the mapped MaLo Ident model</returns>
    NegativeMaLoIdentResponseAndQueryParameters MapToResponse(TBoneyComb response);
}
