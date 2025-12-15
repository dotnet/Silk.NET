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
    [NativeName("Name", "D3D12_SUBRESOURCE_RANGE_UINT64")]
    public unsafe partial struct SubresourceRangeUint64
    {
        public SubresourceRangeUint64
        (
            uint? subresource = null,
            RangeUint64? range = null
        ) : this()
        {
            if (subresource is not null)
            {
                Subresource = subresource.Value;
            }

            if (range is not null)
            {
                Range = range.Value;
            }
        }


        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "Subresource")]
        public uint Subresource;

        [NativeName("Type", "D3D12_RANGE_UINT64")]
        [NativeName("Type.Name", "D3D12_RANGE_UINT64")]
        [NativeName("Name", "Range")]
        public RangeUint64 Range;
    }
}
