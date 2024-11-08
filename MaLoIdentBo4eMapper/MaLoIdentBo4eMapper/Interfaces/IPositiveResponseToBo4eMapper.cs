using MaLoIdentBo4eMapper.Models;

namespace MaLoIdentBo4eMapper.Interfaces;

/// <summary>
/// defines a class that can map MaLo Ident responses (by a VNB) to BO4E (<typeparamref name="TBoneyComb"/>)
/// </summary>
public interface IPositiveResponseToBo4eMapper<TBoneyComb>
{
    /// <summary>
    /// maps a MaLo Ident response <paramref name="response"/> to a BO4E object of type <typeparamref name="TBoneyComb"/>
    /// </summary>
    /// <param name="response">the response to map</param>
    /// <returns>the mapped BO4E object/BoneyComb</returns>
    TBoneyComb MapResponseToBo4e(PositiveMaLoIdentResponseAndQueryParameters response);
}
