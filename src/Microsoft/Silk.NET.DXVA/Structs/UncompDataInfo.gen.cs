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

namespace Silk.NET.DXVA
{
    [NativeName("Name", "_DXVAUncompDataInfo")]
    public unsafe partial struct UncompDataInfo
    {
        public UncompDataInfo
        (
            uint? uncompWidth = null,
            uint? uncompHeight = null,
            Silk.NET.Direct3D9.Format? uncompFormat = null
        ) : this()
        {
            if (uncompWidth is not null)
            {
                UncompWidth = uncompWidth.Value;
            }

            if (uncompHeight is not null)
            {
                UncompHeight = uncompHeight.Value;
            }

            if (uncompFormat is not null)
            {
                UncompFormat = uncompFormat.Value;
            }
        }


        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "UncompWidth")]
        public uint UncompWidth;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "UncompHeight")]
        public uint UncompHeight;

        [NativeName("Type", "D3DFORMAT")]
        [NativeName("Type.Name", "D3DFORMAT")]
        [NativeName("Name", "UncompFormat")]
        public Silk.NET.Direct3D9.Format UncompFormat;
    }
}
