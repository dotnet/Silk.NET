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
    [NativeName("Name", "D3D12_BUFFER_SRV")]
    public unsafe partial struct BufferSrv
    {
        public BufferSrv
        (
            ulong firstElement = default,
            uint numElements = default,
            uint structureByteStride = default,
            BufferSrvFlags flags = default
        )
        {
            FirstElement = firstElement;
            NumElements = numElements;
            StructureByteStride = structureByteStride;
            Flags = flags;
        }


        [NativeName("Type", "UINT64")]
        [NativeName("Type.Name", "UINT64")]
        [NativeName("Name", "FirstElement")]
        public ulong FirstElement;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "NumElements")]
        public uint NumElements;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "StructureByteStride")]
        public uint StructureByteStride;

        [NativeName("Type", "D3D12_BUFFER_SRV_FLAGS")]
        [NativeName("Type.Name", "D3D12_BUFFER_SRV_FLAGS")]
        [NativeName("Name", "Flags")]
        public BufferSrvFlags Flags;
    }
}
