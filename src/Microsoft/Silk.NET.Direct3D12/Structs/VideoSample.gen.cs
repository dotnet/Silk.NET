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
    [NativeName("Name", "D3D12_VIDEO_SAMPLE")]
    public unsafe partial struct VideoSample
    {
        public VideoSample
        (
            uint width = default,
            uint height = default,
            VideoFormat format = default
        )
        {
            Width = width;
            Height = height;
            Format = format;
        }


        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "Width")]
        public uint Width;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "Height")]
        public uint Height;

        [NativeName("Type", "D3D12_VIDEO_FORMAT")]
        [NativeName("Type.Name", "D3D12_VIDEO_FORMAT")]
        [NativeName("Name", "Format")]
        public VideoFormat Format;
    }
}
