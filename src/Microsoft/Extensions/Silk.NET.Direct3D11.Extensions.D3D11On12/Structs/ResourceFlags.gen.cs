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

namespace Silk.NET.Direct3D11.Extensions.D3D11On12
{
    [NativeName("Name", "D3D11_RESOURCE_FLAGS")]
    public unsafe partial struct ResourceFlags
    {
        public ResourceFlags
        (
            uint? bindFlags = null,
            uint? miscFlags = null,
            uint? cPUAccessFlags = null,
            uint? structureByteStride = null
        ) : this()
        {
            if (bindFlags is not null)
            {
                BindFlags = bindFlags.Value;
            }

            if (miscFlags is not null)
            {
                MiscFlags = miscFlags.Value;
            }

            if (cPUAccessFlags is not null)
            {
                CPUAccessFlags = cPUAccessFlags.Value;
            }

            if (structureByteStride is not null)
            {
                StructureByteStride = structureByteStride.Value;
            }
        }


        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "BindFlags")]
        public uint BindFlags;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "MiscFlags")]
        public uint MiscFlags;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "CPUAccessFlags")]
        public uint CPUAccessFlags;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "StructureByteStride")]
        public uint StructureByteStride;
    }
}
