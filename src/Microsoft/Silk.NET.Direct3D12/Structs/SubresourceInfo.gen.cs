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
    [NativeName("Name", "D3D12_SUBRESOURCE_INFO")]
    public unsafe partial struct SubresourceInfo
    {
        public SubresourceInfo
        (
            ulong? offset = null,
            uint? rowPitch = null,
            uint? depthPitch = null
        ) : this()
        {
            if (offset is not null)
            {
                Offset = offset.Value;
            }

            if (rowPitch is not null)
            {
                RowPitch = rowPitch.Value;
            }

            if (depthPitch is not null)
            {
                DepthPitch = depthPitch.Value;
            }
        }


        [NativeName("Type", "UINT64")]
        [NativeName("Type.Name", "UINT64")]
        [NativeName("Name", "Offset")]
        public ulong Offset;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "RowPitch")]
        public uint RowPitch;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "DepthPitch")]
        public uint DepthPitch;
    }
}
