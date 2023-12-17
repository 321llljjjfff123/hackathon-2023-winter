//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Substrate.NetApi.Attributes;
using Substrate.NetApi.Model.Types.Base;
using Substrate.NetApi.Model.Types.Metadata.V14;
using System.Collections.Generic;


namespace Substrate.Hexalem.NET.NetApiExt.Generated.Model.polkadot_primitives.v6
{
    
    
    /// <summary>
    /// >> 196 - Composite[polkadot_primitives.v6.AbridgedHostConfiguration]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class AbridgedHostConfiguration : BaseType
    {
        
        /// <summary>
        /// >> max_code_size
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U32 _maxCodeSize;
        
        /// <summary>
        /// >> max_head_data_size
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U32 _maxHeadDataSize;
        
        /// <summary>
        /// >> max_upward_queue_count
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U32 _maxUpwardQueueCount;
        
        /// <summary>
        /// >> max_upward_queue_size
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U32 _maxUpwardQueueSize;
        
        /// <summary>
        /// >> max_upward_message_size
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U32 _maxUpwardMessageSize;
        
        /// <summary>
        /// >> max_upward_message_num_per_candidate
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U32 _maxUpwardMessageNumPerCandidate;
        
        /// <summary>
        /// >> hrmp_max_message_num_per_candidate
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U32 _hrmpMaxMessageNumPerCandidate;
        
        /// <summary>
        /// >> validation_upgrade_cooldown
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U32 _validationUpgradeCooldown;
        
        /// <summary>
        /// >> validation_upgrade_delay
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U32 _validationUpgradeDelay;
        
        /// <summary>
        /// >> async_backing_params
        /// </summary>
        private Substrate.Hexalem.NET.NetApiExt.Generated.Model.polkadot_primitives.v6.async_backing.AsyncBackingParams _asyncBackingParams;
        
        public Substrate.NetApi.Model.Types.Primitive.U32 MaxCodeSize
        {
            get
            {
                return this._maxCodeSize;
            }
            set
            {
                this._maxCodeSize = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Primitive.U32 MaxHeadDataSize
        {
            get
            {
                return this._maxHeadDataSize;
            }
            set
            {
                this._maxHeadDataSize = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Primitive.U32 MaxUpwardQueueCount
        {
            get
            {
                return this._maxUpwardQueueCount;
            }
            set
            {
                this._maxUpwardQueueCount = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Primitive.U32 MaxUpwardQueueSize
        {
            get
            {
                return this._maxUpwardQueueSize;
            }
            set
            {
                this._maxUpwardQueueSize = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Primitive.U32 MaxUpwardMessageSize
        {
            get
            {
                return this._maxUpwardMessageSize;
            }
            set
            {
                this._maxUpwardMessageSize = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Primitive.U32 MaxUpwardMessageNumPerCandidate
        {
            get
            {
                return this._maxUpwardMessageNumPerCandidate;
            }
            set
            {
                this._maxUpwardMessageNumPerCandidate = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Primitive.U32 HrmpMaxMessageNumPerCandidate
        {
            get
            {
                return this._hrmpMaxMessageNumPerCandidate;
            }
            set
            {
                this._hrmpMaxMessageNumPerCandidate = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Primitive.U32 ValidationUpgradeCooldown
        {
            get
            {
                return this._validationUpgradeCooldown;
            }
            set
            {
                this._validationUpgradeCooldown = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Primitive.U32 ValidationUpgradeDelay
        {
            get
            {
                return this._validationUpgradeDelay;
            }
            set
            {
                this._validationUpgradeDelay = value;
            }
        }
        
        public Substrate.Hexalem.NET.NetApiExt.Generated.Model.polkadot_primitives.v6.async_backing.AsyncBackingParams AsyncBackingParams
        {
            get
            {
                return this._asyncBackingParams;
            }
            set
            {
                this._asyncBackingParams = value;
            }
        }
        
        public override string TypeName()
        {
            return "AbridgedHostConfiguration";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(MaxCodeSize.Encode());
            result.AddRange(MaxHeadDataSize.Encode());
            result.AddRange(MaxUpwardQueueCount.Encode());
            result.AddRange(MaxUpwardQueueSize.Encode());
            result.AddRange(MaxUpwardMessageSize.Encode());
            result.AddRange(MaxUpwardMessageNumPerCandidate.Encode());
            result.AddRange(HrmpMaxMessageNumPerCandidate.Encode());
            result.AddRange(ValidationUpgradeCooldown.Encode());
            result.AddRange(ValidationUpgradeDelay.Encode());
            result.AddRange(AsyncBackingParams.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            MaxCodeSize = new Substrate.NetApi.Model.Types.Primitive.U32();
            MaxCodeSize.Decode(byteArray, ref p);
            MaxHeadDataSize = new Substrate.NetApi.Model.Types.Primitive.U32();
            MaxHeadDataSize.Decode(byteArray, ref p);
            MaxUpwardQueueCount = new Substrate.NetApi.Model.Types.Primitive.U32();
            MaxUpwardQueueCount.Decode(byteArray, ref p);
            MaxUpwardQueueSize = new Substrate.NetApi.Model.Types.Primitive.U32();
            MaxUpwardQueueSize.Decode(byteArray, ref p);
            MaxUpwardMessageSize = new Substrate.NetApi.Model.Types.Primitive.U32();
            MaxUpwardMessageSize.Decode(byteArray, ref p);
            MaxUpwardMessageNumPerCandidate = new Substrate.NetApi.Model.Types.Primitive.U32();
            MaxUpwardMessageNumPerCandidate.Decode(byteArray, ref p);
            HrmpMaxMessageNumPerCandidate = new Substrate.NetApi.Model.Types.Primitive.U32();
            HrmpMaxMessageNumPerCandidate.Decode(byteArray, ref p);
            ValidationUpgradeCooldown = new Substrate.NetApi.Model.Types.Primitive.U32();
            ValidationUpgradeCooldown.Decode(byteArray, ref p);
            ValidationUpgradeDelay = new Substrate.NetApi.Model.Types.Primitive.U32();
            ValidationUpgradeDelay.Decode(byteArray, ref p);
            AsyncBackingParams = new Substrate.Hexalem.NET.NetApiExt.Generated.Model.polkadot_primitives.v6.async_backing.AsyncBackingParams();
            AsyncBackingParams.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}
