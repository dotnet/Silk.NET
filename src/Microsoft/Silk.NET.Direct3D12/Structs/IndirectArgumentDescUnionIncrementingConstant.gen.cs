// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


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
    [NativeName("Name", "__AnonymousRecord_d3d12_L4551_C9")]
    public unsafe partial struct IndirectArgumentDescUnionIncrementingConstant
    {
        public IndirectArgumentDescUnionIncrementingConstant
        (
            uint? rootParameterIndex = null,
            uint? destOffsetIn32BitValues = null
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
        }


        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "RootParameterIndex")]
        public uint RootParameterIndex;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "DestOffsetIn32BitValues")]
        public uint DestOffsetIn32BitValues;
    }
}
