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

namespace Silk.NET.Direct3D11
{
    [NativeName("Name", "D3D11_TEX2D_SRV1")]
    public unsafe partial struct Tex2DSrv1
    {
        public Tex2DSrv1
        (
            uint? mostDetailedMip = null,
            uint? mipLevels = null,
            uint? planeSlice = null
        ) : this()
        {
            if (mostDetailedMip is not null)
            {
                MostDetailedMip = mostDetailedMip.Value;
            }

            if (mipLevels is not null)
            {
                MipLevels = mipLevels.Value;
            }

            if (planeSlice is not null)
            {
                PlaneSlice = planeSlice.Value;
            }
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
    }
}
