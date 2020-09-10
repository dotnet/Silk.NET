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
    [NativeName("Name", "D3D12_FEATURE_DATA_VIDEO_DECODER_HEAP_SIZE1")]
    public unsafe partial struct FeatureDataVideoDecoderHeapSize1
    {
        public FeatureDataVideoDecoderHeapSize1
        (
            VideoDecoderHeapDesc videoDecoderHeapDesc = default,
            int @protected = default,
            ulong memoryPoolL0Size = default,
            ulong memoryPoolL1Size = default
        )
        {
            VideoDecoderHeapDesc = videoDecoderHeapDesc;
            Protected = @protected;
            MemoryPoolL0Size = memoryPoolL0Size;
            MemoryPoolL1Size = memoryPoolL1Size;
        }


        [NativeName("Type", "D3D12_VIDEO_DECODER_HEAP_DESC")]
        [NativeName("Type.Name", "D3D12_VIDEO_DECODER_HEAP_DESC")]
        [NativeName("Name", "VideoDecoderHeapDesc")]
        public VideoDecoderHeapDesc VideoDecoderHeapDesc;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "Protected")]
        public int Protected;

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
