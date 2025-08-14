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
    [StructLayout(LayoutKind.Explicit)]
    [NativeName("Name", "__AnonymousRecord_d3d12_L3249_C5")]
    public unsafe partial struct TextureCopyLocationUnion
    {
        public TextureCopyLocationUnion
        (
            PlacedSubresourceFootprint? placedFootprint = null,
            uint? subresourceIndex = null
        ) : this()
        {
            if (placedFootprint is not null)
            {
                PlacedFootprint = placedFootprint.Value;
            }

            if (subresourceIndex is not null)
            {
                SubresourceIndex = subresourceIndex.Value;
            }
        }


        [FieldOffset(0)]
        [NativeName("Type", "D3D12_PLACED_SUBRESOURCE_FOOTPRINT")]
        [NativeName("Type.Name", "D3D12_PLACED_SUBRESOURCE_FOOTPRINT")]
        [NativeName("Name", "PlacedFootprint")]
        public PlacedSubresourceFootprint PlacedFootprint;

        [FieldOffset(0)]
        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "SubresourceIndex")]
        public uint SubresourceIndex;
    }
}
