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

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "__AnonymousRecord_d3d12_L3957_C9")]
    public unsafe partial struct AnonymousRecordD3d12L3957C9
    {
        public AnonymousRecordD3d12L3957C9
        (
            uint rootParameterIndex = default,
            uint destOffsetIn32BitValues = default,
            uint num32BitValuesToSet = default
        )
        {
            RootParameterIndex = rootParameterIndex;
            DestOffsetIn32BitValues = destOffsetIn32BitValues;
            Num32BitValuesToSet = num32BitValuesToSet;
        }


        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "RootParameterIndex")]
        public uint RootParameterIndex;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "DestOffsetIn32BitValues")]
        public uint DestOffsetIn32BitValues;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "Num32BitValuesToSet")]
        public uint Num32BitValuesToSet;
    }
}
