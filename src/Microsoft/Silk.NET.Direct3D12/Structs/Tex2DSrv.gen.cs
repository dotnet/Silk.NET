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
    [NativeName("Name", "D3D12_TEX2D_SRV")]
    public unsafe partial struct Tex2DSrv
    {
        public Tex2DSrv
        (
            uint mostDetailedMip = default,
            uint mipLevels = default,
            uint planeSlice = default,
            float resourceMinLODClamp = default
        )
        {
            MostDetailedMip = mostDetailedMip;
            MipLevels = mipLevels;
            PlaneSlice = planeSlice;
            ResourceMinLODClamp = resourceMinLODClamp;
        }


        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "MostDetailedMip")]
        public uint MostDetailedMip;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "MipLevels")]
        public uint MipLevels;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "PlaneSlice")]
        public uint PlaneSlice;

        [NativeName("Type", "FLOAT")]
        [NativeName("Type.Name", "FLOAT")]
        [NativeName("Name", "ResourceMinLODClamp")]
        public float ResourceMinLODClamp;
    }
}
