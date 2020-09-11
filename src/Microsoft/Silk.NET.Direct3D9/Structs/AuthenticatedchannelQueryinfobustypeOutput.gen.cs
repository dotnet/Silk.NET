// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Direct3D9
{
    [NativeName("Name", "_D3DAUTHENTICATEDCHANNEL_QUERYINFOBUSTYPE_OUTPUT")]
    public unsafe partial struct AuthenticatedchannelQueryinfobustypeOutput
    {
        public AuthenticatedchannelQueryinfobustypeOutput
        (
            AuthenticatedchannelQueryOutput output = default,
            Bustype busType = default,
            int bAccessibleInContiguousBlocks = default,
            int bAccessibleInNonContiguousBlocks = default
        )
        {
            Output = output;
            BusType = busType;
            BAccessibleInContiguousBlocks = bAccessibleInContiguousBlocks;
            BAccessibleInNonContiguousBlocks = bAccessibleInNonContiguousBlocks;
        }


        [NativeName("Type", "D3DAUTHENTICATEDCHANNEL_QUERY_OUTPUT")]
        [NativeName("Type.Name", "D3DAUTHENTICATEDCHANNEL_QUERY_OUTPUT")]
        [NativeName("Name", "Output")]
        public AuthenticatedchannelQueryOutput Output;

        [NativeName("Type", "D3DBUSTYPE")]
        [NativeName("Type.Name", "D3DBUSTYPE")]
        [NativeName("Name", "BusType")]
        public Bustype BusType;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "bAccessibleInContiguousBlocks")]
        public int BAccessibleInContiguousBlocks;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "bAccessibleInNonContiguousBlocks")]
        public int BAccessibleInNonContiguousBlocks;
    }
}
