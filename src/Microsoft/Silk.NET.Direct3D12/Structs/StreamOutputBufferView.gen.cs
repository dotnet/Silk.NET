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
    [NativeName("Name", "D3D12_STREAM_OUTPUT_BUFFER_VIEW")]
    public unsafe partial struct StreamOutputBufferView
    {
        public StreamOutputBufferView
        (
            ulong bufferLocation = default,
            ulong sizeInBytes = default,
            ulong bufferFilledSizeLocation = default
        )
        {
            BufferLocation = bufferLocation;
            SizeInBytes = sizeInBytes;
            BufferFilledSizeLocation = bufferFilledSizeLocation;
        }


        [NativeName("Type", "D3D12_GPU_VIRTUAL_ADDRESS")]
        [NativeName("Type.Name", "D3D12_GPU_VIRTUAL_ADDRESS")]
        [NativeName("Name", "BufferLocation")]
        public ulong BufferLocation;

        [NativeName("Type", "UINT64")]
        [NativeName("Type.Name", "UINT64")]
        [NativeName("Name", "SizeInBytes")]
        public ulong SizeInBytes;

        [NativeName("Type", "D3D12_GPU_VIRTUAL_ADDRESS")]
        [NativeName("Type.Name", "D3D12_GPU_VIRTUAL_ADDRESS")]
        [NativeName("Name", "BufferFilledSizeLocation")]
        public ulong BufferFilledSizeLocation;
    }
}
