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
    [NativeName("Name", "D3D12_TEX3D_SRV")]
    public unsafe partial struct Tex3DSrv
    {
        public Tex3DSrv
        (
            uint? mostDetailedMip = null,
            uint? mipLevels = null,
            float? resourceMinLODClamp = null
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

            if (resourceMinLODClamp is not null)
            {
                ResourceMinLODClamp = resourceMinLODClamp.Value;
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

        [NativeName("Type", "FLOAT")]
        [NativeName("Type.Name", "FLOAT")]
        [NativeName("Name", "ResourceMinLODClamp")]
        public float ResourceMinLODClamp;
    }
}
