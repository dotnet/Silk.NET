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
    [NativeName("Name", "D3D12_VIDEO_PROCESS_INPUT_STREAM_ARGUMENTS1")]
    public unsafe partial struct VideoProcessInputStreamArguments1
    {
        public VideoProcessInputStreamArguments1
        (
            VideoProcessTransform transform = default,
            VideoProcessInputStreamFlags flags = default,
            VideoProcessInputStreamRate rateInfo = default,
            VideoProcessAlphaBlending alphaBlending = default,
            VideoFieldType fieldType = default
        )
        {
           InputStream_0 = default;
           InputStream_1 = default;
            Transform = transform;
            Flags = flags;
            RateInfo = rateInfo;
            AlphaBlending = alphaBlending;
            FieldType = fieldType;
        }

        
        [NativeName("Type", "D3D12_VIDEO_PROCESS_INPUT_STREAM [2]")]
        [NativeName("Type.Name", "D3D12_VIDEO_PROCESS_INPUT_STREAM [2]")]
        [NativeName("Name", "InputStream")]
        public VideoProcessInputStream InputStream_0;
        
        [NativeName("Type", "D3D12_VIDEO_PROCESS_INPUT_STREAM [2]")]
        [NativeName("Type.Name", "D3D12_VIDEO_PROCESS_INPUT_STREAM [2]")]
        [NativeName("Name", "InputStream")]
        public VideoProcessInputStream InputStream_1;

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
        [NativeName("Type", "INT [32]")]
        [NativeName("Type.Name", "INT [32]")]
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
