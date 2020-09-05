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
    [NativeName("Name", "D3D11_VIDEO_PROCESSOR_CONTENT_DESC")]
    public unsafe partial struct VideoProcessorContentDesc
    {
        public VideoProcessorContentDesc
        (
            VideoFrameFormat inputFrameFormat = default,
            DXGI_RATIONAL inputFrameRate = default,
            uint inputWidth = default,
            uint inputHeight = default,
            DXGI_RATIONAL outputFrameRate = default,
            uint outputWidth = default,
            uint outputHeight = default,
            VideoUsage usage = default
        )
        {
            InputFrameFormat = inputFrameFormat;
            InputFrameRate = inputFrameRate;
            InputWidth = inputWidth;
            InputHeight = inputHeight;
            OutputFrameRate = outputFrameRate;
            OutputWidth = outputWidth;
            OutputHeight = outputHeight;
            Usage = usage;
        }


        [NativeName("Type", "D3D11_VIDEO_FRAME_FORMAT")]
        [NativeName("Type.Name", "D3D11_VIDEO_FRAME_FORMAT")]
        [NativeName("Name", "InputFrameFormat")]
        public VideoFrameFormat InputFrameFormat;

        [NativeName("Type", "DXGI_RATIONAL")]
        [NativeName("Type.Name", "DXGI_RATIONAL")]
        [NativeName("Name", "InputFrameRate")]
        public DXGI_RATIONAL InputFrameRate;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "InputWidth")]
        public uint InputWidth;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "InputHeight")]
        public uint InputHeight;

        [NativeName("Type", "DXGI_RATIONAL")]
        [NativeName("Type.Name", "DXGI_RATIONAL")]
        [NativeName("Name", "OutputFrameRate")]
        public DXGI_RATIONAL OutputFrameRate;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "OutputWidth")]
        public uint OutputWidth;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "OutputHeight")]
        public uint OutputHeight;

        [NativeName("Type", "D3D11_VIDEO_USAGE")]
        [NativeName("Type.Name", "D3D11_VIDEO_USAGE")]
        [NativeName("Name", "Usage")]
        public VideoUsage Usage;
    }
}
