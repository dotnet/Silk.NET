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
    [NativeName("Name", "D3D12_TEX3D_UAV")]
    public unsafe partial struct Tex3DUav
    {
        public Tex3DUav
        (
            uint? mipSlice = null,
            uint? firstWSlice = null,
            uint? wSize = null
        ) : this()
        {
            if (mipSlice is not null)
            {
                MipSlice = mipSlice.Value;
            }

            if (firstWSlice is not null)
            {
                FirstWSlice = firstWSlice.Value;
            }

            if (wSize is not null)
            {
                WSize = wSize.Value;
            }
        }


        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "MipSlice")]
        public uint MipSlice;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "FirstWSlice")]
        public uint FirstWSlice;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "WSize")]
        public uint WSize;
    }
}
