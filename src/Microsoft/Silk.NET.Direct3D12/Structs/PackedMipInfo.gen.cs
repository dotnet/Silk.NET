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
    [NativeName("Name", "D3D12_PACKED_MIP_INFO")]
    public unsafe partial struct PackedMipInfo
    {
        public PackedMipInfo
        (
            byte? numStandardMips = null,
            byte? numPackedMips = null,
            uint? numTilesForPackedMips = null,
            uint? startTileIndexInOverallResource = null
        ) : this()
        {
            if (numStandardMips is not null)
            {
                NumStandardMips = numStandardMips.Value;
            }

            if (numPackedMips is not null)
            {
                NumPackedMips = numPackedMips.Value;
            }

            if (numTilesForPackedMips is not null)
            {
                NumTilesForPackedMips = numTilesForPackedMips.Value;
            }

            if (startTileIndexInOverallResource is not null)
            {
                StartTileIndexInOverallResource = startTileIndexInOverallResource.Value;
            }
        }


        [NativeName("Type", "UINT8")]
        [NativeName("Type.Name", "UINT8")]
        [NativeName("Name", "NumStandardMips")]
        public byte NumStandardMips;

        [NativeName("Type", "UINT8")]
        [NativeName("Type.Name", "UINT8")]
        [NativeName("Name", "NumPackedMips")]
        public byte NumPackedMips;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "NumTilesForPackedMips")]
        public uint NumTilesForPackedMips;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "StartTileIndexInOverallResource")]
        public uint StartTileIndexInOverallResource;
    }
}
