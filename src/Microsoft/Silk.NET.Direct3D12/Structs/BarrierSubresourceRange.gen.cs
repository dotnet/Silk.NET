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
    [NativeName("Name", "D3D12_BARRIER_SUBRESOURCE_RANGE")]
    public unsafe partial struct BarrierSubresourceRange
    {
        public BarrierSubresourceRange
        (
            uint? indexOrFirstMipLevel = null,
            uint? numMipLevels = null,
            uint? firstArraySlice = null,
            uint? numArraySlices = null,
            uint? firstPlane = null,
            uint? numPlanes = null
        ) : this()
        {
            if (indexOrFirstMipLevel is not null)
            {
                IndexOrFirstMipLevel = indexOrFirstMipLevel.Value;
            }

            if (numMipLevels is not null)
            {
                NumMipLevels = numMipLevels.Value;
            }

            if (firstArraySlice is not null)
            {
                FirstArraySlice = firstArraySlice.Value;
            }

            if (numArraySlices is not null)
            {
                NumArraySlices = numArraySlices.Value;
            }

            if (firstPlane is not null)
            {
                FirstPlane = firstPlane.Value;
            }

            if (numPlanes is not null)
            {
                NumPlanes = numPlanes.Value;
            }
        }


        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "IndexOrFirstMipLevel")]
        public uint IndexOrFirstMipLevel;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "NumMipLevels")]
        public uint NumMipLevels;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "FirstArraySlice")]
        public uint FirstArraySlice;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "NumArraySlices")]
        public uint NumArraySlices;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "FirstPlane")]
        public uint FirstPlane;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "NumPlanes")]
        public uint NumPlanes;
    }
}
