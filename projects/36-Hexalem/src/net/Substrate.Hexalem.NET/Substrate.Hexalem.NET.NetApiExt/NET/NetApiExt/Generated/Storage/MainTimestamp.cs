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
    
    
    public sealed class TimestampStorage
    {
        
        // Substrate client for the storage calls.
        private SubstrateClientExt _client;
        
        public TimestampStorage(SubstrateClientExt client)
        {
            this._client = client;
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("Timestamp", "Now"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(null, null, typeof(Substrate.NetApi.Model.Types.Primitive.U64)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("Timestamp", "DidUpdate"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(null, null, typeof(Substrate.NetApi.Model.Types.Primitive.Bool)));
        }
        
        /// <summary>
        /// >> NowParams
        ///  The current time for the current block.
        /// </summary>
        public static string NowParams()
        {
            return RequestGenerator.GetStorage("Timestamp", "Now", Substrate.NetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> NowDefault
        /// Default value as hex string
        /// </summary>
        public static string NowDefault()
        {
            return "0x0000000000000000";
        }
        
        /// <summary>
        /// >> Now
        ///  The current time for the current block.
        /// </summary>
        public async Task<Substrate.NetApi.Model.Types.Primitive.U64> Now(CancellationToken token)
        {
            string parameters = TimestampStorage.NowParams();
            var result = await _client.GetStorageAsync<Substrate.NetApi.Model.Types.Primitive.U64>(parameters, token);
            return result;
        }
        
        /// <summary>
        /// >> DidUpdateParams
        ///  Whether the timestamp has been updated in this block.
        /// 
        ///  This value is updated to `true` upon successful submission of a timestamp by a node.
        ///  It is then checked at the end of each block execution in the `on_finalize` hook.
        /// </summary>
        public static string DidUpdateParams()
        {
            return RequestGenerator.GetStorage("Timestamp", "DidUpdate", Substrate.NetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> DidUpdateDefault
        /// Default value as hex string
        /// </summary>
        public static string DidUpdateDefault()
        {
            return "0x00";
        }
        
        /// <summary>
        /// >> DidUpdate
        ///  Whether the timestamp has been updated in this block.
        /// 
        ///  This value is updated to `true` upon successful submission of a timestamp by a node.
        ///  It is then checked at the end of each block execution in the `on_finalize` hook.
        /// </summary>
        public async Task<Substrate.NetApi.Model.Types.Primitive.Bool> DidUpdate(CancellationToken token)
        {
            string parameters = TimestampStorage.DidUpdateParams();
            var result = await _client.GetStorageAsync<Substrate.NetApi.Model.Types.Primitive.Bool>(parameters, token);
            return result;
        }
    }
    
    public sealed class TimestampCalls
    {
        
        /// <summary>
        /// >> set
        /// Contains a variant per dispatchable extrinsic that this pallet has.
        /// </summary>
        public static Method Set(Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U64> now)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(now.Encode());
            return new Method(2, "Timestamp", 0, "set", byteArray.ToArray());
        }
    }
    
    public sealed class TimestampConstants
    {
        
        /// <summary>
        /// >> MinimumPeriod
        ///  The minimum period between blocks.
        /// 
        ///  Be aware that this is different to the *expected* period that the block production
        ///  apparatus provides. Your chosen consensus system will generally work with this to
        ///  determine a sensible block time. For example, in the Aura pallet it will be double this
        ///  period on default settings.
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U64 MinimumPeriod()
        {
            var result = new Substrate.NetApi.Model.Types.Primitive.U64();
            result.Create("0x7017000000000000");
            return result;
        }
    }
}
