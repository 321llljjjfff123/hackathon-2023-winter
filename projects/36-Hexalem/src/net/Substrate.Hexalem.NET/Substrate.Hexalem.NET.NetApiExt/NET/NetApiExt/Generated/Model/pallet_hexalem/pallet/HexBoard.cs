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


namespace Substrate.Hexalem.NET.NetApiExt.Generated.Model.pallet_hexalem.pallet
{
    
    
    /// <summary>
    /// >> 348 - Composite[pallet_hexalem.pallet.HexBoard]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class HexBoard : BaseType
    {
        
        /// <summary>
        /// >> resources
        /// </summary>
        private Substrate.Hexalem.NET.NetApiExt.Generated.Types.Base.Arr7U8 _resources;
        
        /// <summary>
        /// >> hex_grid
        /// </summary>
        private Substrate.Hexalem.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT23 _hexGrid;
        
        /// <summary>
        /// >> game_id
        /// </summary>
        private Substrate.Hexalem.NET.NetApiExt.Generated.Types.Base.Arr32U8 _gameId;
        
        public Substrate.Hexalem.NET.NetApiExt.Generated.Types.Base.Arr7U8 Resources
        {
            get
            {
                return this._resources;
            }
            set
            {
                this._resources = value;
            }
        }
        
        public Substrate.Hexalem.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT23 HexGrid
        {
            get
            {
                return this._hexGrid;
            }
            set
            {
                this._hexGrid = value;
            }
        }
        
        public Substrate.Hexalem.NET.NetApiExt.Generated.Types.Base.Arr32U8 GameId
        {
            get
            {
                return this._gameId;
            }
            set
            {
                this._gameId = value;
            }
        }
        
        public override string TypeName()
        {
            return "HexBoard";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Resources.Encode());
            result.AddRange(HexGrid.Encode());
            result.AddRange(GameId.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Resources = new Substrate.Hexalem.NET.NetApiExt.Generated.Types.Base.Arr7U8();
            Resources.Decode(byteArray, ref p);
            HexGrid = new Substrate.Hexalem.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT23();
            HexGrid.Decode(byteArray, ref p);
            GameId = new Substrate.Hexalem.NET.NetApiExt.Generated.Types.Base.Arr32U8();
            GameId.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}
