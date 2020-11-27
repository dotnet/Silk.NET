// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
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
            VideoFrameFormat? inputFrameFormat = null,
            Silk.NET.DXGI.Rational? inputFrameRate = null,
            uint? inputWidth = null,
            uint? inputHeight = null,
            Silk.NET.DXGI.Rational? outputFrameRate = null,
            uint? outputWidth = null,
            uint? outputHeight = null,
            VideoUsage? usage = null
        ) : this()
        {
            if (inputFrameFormat is not null)
            {
                InputFrameFormat = inputFrameFormat.Value;
            }

            if (inputFrameRate is not null)
            {
                InputFrameRate = inputFrameRate.Value;
            }

            if (inputWidth is not null)
            {
                InputWidth = inputWidth.Value;
            }

            if (inputHeight is not null)
            {
                InputHeight = inputHeight.Value;
            }

            if (outputFrameRate is not null)
            {
                OutputFrameRate = outputFrameRate.Value;
            }

            if (outputWidth is not null)
            {
                OutputWidth = outputWidth.Value;
            }

            if (outputHeight is not null)
            {
                OutputHeight = outputHeight.Value;
            }

            if (usage is not null)
            {
                Usage = usage.Value;
            }
        }


        [NativeName("Type", "D3D11_VIDEO_FRAME_FORMAT")]
        [NativeName("Type.Name", "D3D11_VIDEO_FRAME_FORMAT")]
        [NativeName("Name", "InputFrameFormat")]
        public VideoFrameFormat InputFrameFormat;

        [NativeName("Type", "DXGI_RATIONAL")]
        [NativeName("Type.Name", "DXGI_RATIONAL")]
        [NativeName("Name", "InputFrameRate")]
        public Silk.NET.DXGI.Rational InputFrameRate;

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
        public Silk.NET.DXGI.Rational OutputFrameRate;

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
