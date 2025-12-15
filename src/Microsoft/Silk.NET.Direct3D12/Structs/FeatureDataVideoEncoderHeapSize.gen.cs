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
    [NativeName("Name", "D3D12_FEATURE_DATA_VIDEO_ENCODER_HEAP_SIZE")]
    public unsafe partial struct FeatureDataVideoEncoderHeapSize
    {
        public FeatureDataVideoEncoderHeapSize
        (
            VideoEncoderHeapDesc? heapDesc = null,
            Silk.NET.Core.Bool32? isSupported = null,
            ulong? memoryPoolL0Size = null,
            ulong? memoryPoolL1Size = null
        ) : this()
        {
            if (heapDesc is not null)
            {
                HeapDesc = heapDesc.Value;
            }

            if (isSupported is not null)
            {
                IsSupported = isSupported.Value;
            }

            if (memoryPoolL0Size is not null)
            {
                MemoryPoolL0Size = memoryPoolL0Size.Value;
            }

            if (memoryPoolL1Size is not null)
            {
                MemoryPoolL1Size = memoryPoolL1Size.Value;
            }
        }


        [NativeName("Type", "D3D12_VIDEO_ENCODER_HEAP_DESC")]
        [NativeName("Type.Name", "D3D12_VIDEO_ENCODER_HEAP_DESC")]
        [NativeName("Name", "HeapDesc")]
        public VideoEncoderHeapDesc HeapDesc;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "IsSupported")]
        public Silk.NET.Core.Bool32 IsSupported;

        [NativeName("Type", "UINT64")]
        [NativeName("Type.Name", "UINT64")]
        [NativeName("Name", "MemoryPoolL0Size")]
        public ulong MemoryPoolL0Size;

        [NativeName("Type", "UINT64")]
        [NativeName("Type.Name", "UINT64")]
        [NativeName("Name", "MemoryPoolL1Size")]
        public ulong MemoryPoolL1Size;
    }
}
