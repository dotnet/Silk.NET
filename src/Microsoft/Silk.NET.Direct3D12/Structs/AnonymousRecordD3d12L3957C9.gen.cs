// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
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
            uint? rootParameterIndex = null,
            uint? destOffsetIn32BitValues = null,
            uint? num32BitValuesToSet = null
        ) : this()
        {
            if (rootParameterIndex is not null)
            {
                RootParameterIndex = rootParameterIndex.Value;
            }

            if (destOffsetIn32BitValues is not null)
            {
                DestOffsetIn32BitValues = destOffsetIn32BitValues.Value;
            }

            if (num32BitValuesToSet is not null)
            {
                Num32BitValuesToSet = num32BitValuesToSet.Value;
            }
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
