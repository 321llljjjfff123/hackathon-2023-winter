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


namespace Substrate.Hexalem.NET.NetApiExt.Generated.Model.pallet_cc_authorities_noting.pallet
{
    
    
    public enum Call
    {
        
        set_latest_authorities_data = 0,
        
        set_authorities = 1,
        
        set_orchestrator_para_id = 2,
    }
    
    /// <summary>
    /// >> 267 - Variant[pallet_cc_authorities_noting.pallet.Call]
    /// Contains a variant per dispatchable extrinsic that this pallet has.
    /// </summary>
    public sealed class EnumCall : BaseEnumExt<Call, Substrate.Hexalem.NET.NetApiExt.Generated.Model.ccp_authorities_noting_inherent.ContainerChainAuthoritiesInherentData, Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.Hexalem.NET.NetApiExt.Generated.Model.nimbus_primitives.nimbus_crypto.Public>, Substrate.Hexalem.NET.NetApiExt.Generated.Model.polkadot_parachain_primitives.primitives.Id>
    {
    }
}
