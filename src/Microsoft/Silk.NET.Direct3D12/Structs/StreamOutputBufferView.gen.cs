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
    [NativeName("Name", "D3D12_STREAM_OUTPUT_BUFFER_VIEW")]
    public unsafe partial struct StreamOutputBufferView
    {
        public StreamOutputBufferView
        (
            ulong? bufferLocation = null,
            ulong? sizeInBytes = null,
            ulong? bufferFilledSizeLocation = null
        ) : this()
        {
            if (bufferLocation is not null)
            {
                BufferLocation = bufferLocation.Value;
            }

            if (sizeInBytes is not null)
            {
                SizeInBytes = sizeInBytes.Value;
            }

            if (bufferFilledSizeLocation is not null)
            {
                BufferFilledSizeLocation = bufferFilledSizeLocation.Value;
            }
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
