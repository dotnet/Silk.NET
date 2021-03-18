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
    [NativeName("Name", "CD3D11_BUFFER_DESC")]
    public unsafe partial struct CD3D11BufferDesc
    {
        public CD3D11BufferDesc
        (
            uint? byteWidth = null,
            Usage? usage = null,
            uint? bindFlags = null,
            uint? cPUAccessFlags = null,
            uint? miscFlags = null,
            uint? structureByteStride = null
        ) : this()
        {
            if (byteWidth is not null)
            {
                ByteWidth = byteWidth.Value;
            }

            if (usage is not null)
            {
                Usage = usage.Value;
            }

            if (bindFlags is not null)
            {
                BindFlags = bindFlags.Value;
            }

            if (cPUAccessFlags is not null)
            {
                CPUAccessFlags = cPUAccessFlags.Value;
            }

            if (miscFlags is not null)
            {
                MiscFlags = miscFlags.Value;
            }

            if (structureByteStride is not null)
            {
                StructureByteStride = structureByteStride.Value;
            }
        }


        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "ByteWidth")]
        public uint ByteWidth;

        [NativeName("Type", "D3D11_USAGE")]
        [NativeName("Type.Name", "D3D11_USAGE")]
        [NativeName("Name", "Usage")]
        public Usage Usage;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "BindFlags")]
        public uint BindFlags;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "CPUAccessFlags")]
        public uint CPUAccessFlags;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "MiscFlags")]
        public uint MiscFlags;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "StructureByteStride")]
        public uint StructureByteStride;
    }
}
