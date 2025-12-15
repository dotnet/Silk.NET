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
    [NativeName("Name", "D3D12_VIDEO_PROCESS_INPUT_STREAM_ARGUMENTS1")]
    public unsafe partial struct VideoProcessInputStreamArguments1
    {
        public VideoProcessInputStreamArguments1
        (
            VideoProcessTransform? transform = null,
            VideoProcessInputStreamFlags? flags = null,
            VideoProcessInputStreamRate? rateInfo = null,
            VideoProcessAlphaBlending? alphaBlending = null,
            VideoFieldType? fieldType = null
        ) : this()
        {
            if (transform is not null)
            {
                Transform = transform.Value;
            }

            if (flags is not null)
            {
                Flags = flags.Value;
            }

            if (rateInfo is not null)
            {
                RateInfo = rateInfo.Value;
            }

            if (alphaBlending is not null)
            {
                AlphaBlending = alphaBlending.Value;
            }

            if (fieldType is not null)
            {
                FieldType = fieldType.Value;
            }
        }

        
        [NativeName("Type", "D3D12_VIDEO_PROCESS_INPUT_STREAM[2]")]
        [NativeName("Type.Name", "D3D12_VIDEO_PROCESS_INPUT_STREAM[2]")]
        [NativeName("Name", "InputStream")]
        public InputStreamBuffer InputStream;

        public struct InputStreamBuffer
        {
            public VideoProcessInputStream Element0;
            public VideoProcessInputStream Element1;
            public ref VideoProcessInputStream this[int index]
            {
                get
                {
                    if (index > 1 || index < 0)
                    {
                        throw new ArgumentOutOfRangeException(nameof(index));
                    }

                    fixed (VideoProcessInputStream* ptr = &Element0)
                    {
                        return ref ptr[index];
                    }
                }
            }

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
            public Span<VideoProcessInputStream> AsSpan()
                => MemoryMarshal.CreateSpan(ref Element0, 2);
#endif
        }


        [NativeName("Type", "D3D12_VIDEO_PROCESS_TRANSFORM")]
        [NativeName("Type.Name", "D3D12_VIDEO_PROCESS_TRANSFORM")]
        [NativeName("Name", "Transform")]
        public VideoProcessTransform Transform;

        [NativeName("Type", "D3D12_VIDEO_PROCESS_INPUT_STREAM_FLAGS")]
        [NativeName("Type.Name", "D3D12_VIDEO_PROCESS_INPUT_STREAM_FLAGS")]
        [NativeName("Name", "Flags")]
        public VideoProcessInputStreamFlags Flags;

        [NativeName("Type", "D3D12_VIDEO_PROCESS_INPUT_STREAM_RATE")]
        [NativeName("Type.Name", "D3D12_VIDEO_PROCESS_INPUT_STREAM_RATE")]
        [NativeName("Name", "RateInfo")]
        public VideoProcessInputStreamRate RateInfo;
        [NativeName("Type", "INT[32]")]
        [NativeName("Type.Name", "INT[32]")]
        [NativeName("Name", "FilterLevels")]
        public fixed int FilterLevels[32];

        [NativeName("Type", "D3D12_VIDEO_PROCESS_ALPHA_BLENDING")]
        [NativeName("Type.Name", "D3D12_VIDEO_PROCESS_ALPHA_BLENDING")]
        [NativeName("Name", "AlphaBlending")]
        public VideoProcessAlphaBlending AlphaBlending;

        [NativeName("Type", "D3D12_VIDEO_FIELD_TYPE")]
        [NativeName("Type.Name", "D3D12_VIDEO_FIELD_TYPE")]
        [NativeName("Name", "FieldType")]
        public VideoFieldType FieldType;
    }
}
