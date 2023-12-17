//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Substrate.NetApi;
using Substrate.NetApi.Model.Extrinsics;
using Substrate.NetApi.Model.Meta;
using Substrate.NetApi.Model.Types;
using Substrate.NetApi.Model.Types.Base;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace Substrate.Hexalem.NET.NetApiExt.Generated.Storage
{
    
    
    public sealed class UtilityStorage
    {
        
        // Substrate client for the storage calls.
        private SubstrateClientExt _client;
        
        public UtilityStorage(SubstrateClientExt client)
        {
            this._client = client;
        }
    }
    
    public sealed class UtilityCalls
    {
        
        /// <summary>
        /// >> batch
        /// Contains a variant per dispatchable extrinsic that this pallet has.
        /// </summary>
        public static Method Batch(Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.Hexalem.NET.NetApiExt.Generated.Model.container_chain_template_simple_runtime.EnumRuntimeCall> calls)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(calls.Encode());
            return new Method(5, "Utility", 0, "batch", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> as_derivative
        /// Contains a variant per dispatchable extrinsic that this pallet has.
        /// </summary>
        public static Method AsDerivative(Substrate.NetApi.Model.Types.Primitive.U16 index, Substrate.Hexalem.NET.NetApiExt.Generated.Model.container_chain_template_simple_runtime.EnumRuntimeCall call)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(index.Encode());
            byteArray.AddRange(call.Encode());
            return new Method(5, "Utility", 1, "as_derivative", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> batch_all
        /// Contains a variant per dispatchable extrinsic that this pallet has.
        /// </summary>
        public static Method BatchAll(Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.Hexalem.NET.NetApiExt.Generated.Model.container_chain_template_simple_runtime.EnumRuntimeCall> calls)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(calls.Encode());
            return new Method(5, "Utility", 2, "batch_all", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> dispatch_as
        /// Contains a variant per dispatchable extrinsic that this pallet has.
        /// </summary>
        public static Method DispatchAs(Substrate.Hexalem.NET.NetApiExt.Generated.Model.container_chain_template_simple_runtime.EnumOriginCaller as_origin, Substrate.Hexalem.NET.NetApiExt.Generated.Model.container_chain_template_simple_runtime.EnumRuntimeCall call)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(as_origin.Encode());
            byteArray.AddRange(call.Encode());
            return new Method(5, "Utility", 3, "dispatch_as", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> force_batch
        /// Contains a variant per dispatchable extrinsic that this pallet has.
        /// </summary>
        public static Method ForceBatch(Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.Hexalem.NET.NetApiExt.Generated.Model.container_chain_template_simple_runtime.EnumRuntimeCall> calls)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(calls.Encode());
            return new Method(5, "Utility", 4, "force_batch", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> with_weight
        /// Contains a variant per dispatchable extrinsic that this pallet has.
        /// </summary>
        public static Method WithWeight(Substrate.Hexalem.NET.NetApiExt.Generated.Model.container_chain_template_simple_runtime.EnumRuntimeCall call, Substrate.Hexalem.NET.NetApiExt.Generated.Model.sp_weights.weight_v2.Weight weight)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(call.Encode());
            byteArray.AddRange(weight.Encode());
            return new Method(5, "Utility", 5, "with_weight", byteArray.ToArray());
        }
    }
    
    public sealed class UtilityConstants
    {
        
        /// <summary>
        /// >> batched_calls_limit
        ///  The limit on the number of batched calls.
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 batched_calls_limit()
        {
            var result = new Substrate.NetApi.Model.Types.Primitive.U32();
            result.Create("0xAA2A0000");
            return result;
        }
    }
    
    public enum UtilityErrors
    {
        
        /// <summary>
        /// >> TooManyCalls
        /// Too many calls batched.
        /// </summary>
        TooManyCalls,
    }
}
