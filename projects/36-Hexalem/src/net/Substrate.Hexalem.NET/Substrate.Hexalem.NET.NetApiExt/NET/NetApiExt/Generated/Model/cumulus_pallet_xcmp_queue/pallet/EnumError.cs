//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Substrate.NetApi.Model.Types.Base;
using System.Collections.Generic;


namespace Substrate.Hexalem.NET.NetApiExt.Generated.Model.cumulus_pallet_xcmp_queue.pallet
{
    
    
    public enum Error
    {
        
        FailedToSend = 0,
        
        BadXcmOrigin = 1,
        
        BadXcm = 2,
        
        BadOverweightIndex = 3,
        
        WeightOverLimit = 4,
    }
    
    /// <summary>
    /// >> 404 - Variant[cumulus_pallet_xcmp_queue.pallet.Error]
    /// The `Error` enum of this pallet.
    /// </summary>
    public sealed class EnumError : BaseEnum<Error>
    {
    }
}
