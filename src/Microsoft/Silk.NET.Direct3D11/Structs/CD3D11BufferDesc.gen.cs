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

namespace Silk.NET.Direct3D11
{
    [NativeName("Name", "CD3D11_BUFFER_DESC")]
    public unsafe partial struct CD3D11BufferDesc
    {
        public CD3D11BufferDesc
        (
            uint byteWidth = default,
            Usage usage = default,
            uint bindFlags = default,
            uint cPUAccessFlags = default,
            uint miscFlags = default,
            uint structureByteStride = default
        )
        {
            ByteWidth = byteWidth;
            Usage = usage;
            BindFlags = bindFlags;
            CPUAccessFlags = cPUAccessFlags;
            MiscFlags = miscFlags;
            StructureByteStride = structureByteStride;
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
