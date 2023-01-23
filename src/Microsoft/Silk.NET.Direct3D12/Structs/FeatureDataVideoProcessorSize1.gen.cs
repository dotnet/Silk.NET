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
    [NativeName("Name", "D3D12_FEATURE_DATA_VIDEO_PROCESSOR_SIZE1")]
    public unsafe partial struct FeatureDataVideoProcessorSize1
    {
        public FeatureDataVideoProcessorSize1
        (
            uint? nodeMask = null,
            VideoProcessOutputStreamDesc* pOutputStreamDesc = null,
            uint? numInputStreamDescs = null,
            VideoProcessInputStreamDesc* pInputStreamDescs = null,
            Silk.NET.Core.Bool32? @protected = null,
            ulong? memoryPoolL0Size = null,
            ulong? memoryPoolL1Size = null
        ) : this()
        {
            if (nodeMask is not null)
            {
                NodeMask = nodeMask.Value;
            }

            if (pOutputStreamDesc is not null)
            {
                POutputStreamDesc = pOutputStreamDesc;
            }

            if (numInputStreamDescs is not null)
            {
                NumInputStreamDescs = numInputStreamDescs.Value;
            }

            if (pInputStreamDescs is not null)
            {
                PInputStreamDescs = pInputStreamDescs;
            }

            if (@protected is not null)
            {
                Protected = @protected.Value;
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


        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "NodeMask")]
        public uint NodeMask;

        [NativeName("Type", "const D3D12_VIDEO_PROCESS_OUTPUT_STREAM_DESC *")]
        [NativeName("Type.Name", "const D3D12_VIDEO_PROCESS_OUTPUT_STREAM_DESC *")]
        [NativeName("Name", "pOutputStreamDesc")]
        public VideoProcessOutputStreamDesc* POutputStreamDesc;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "NumInputStreamDescs")]
        public uint NumInputStreamDescs;

        [NativeName("Type", "const D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC *")]
        [NativeName("Type.Name", "const D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC *")]
        [NativeName("Name", "pInputStreamDescs")]
        public VideoProcessInputStreamDesc* PInputStreamDescs;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "Protected")]
        public Silk.NET.Core.Bool32 Protected;

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
