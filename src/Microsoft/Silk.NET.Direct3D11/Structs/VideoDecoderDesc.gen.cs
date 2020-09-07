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
    [NativeName("Name", "D3D11_VIDEO_DECODER_DESC")]
    public unsafe partial struct VideoDecoderDesc
    {
        public VideoDecoderDesc
        (
            Guid guid = default,
            uint sampleWidth = default,
            uint sampleHeight = default,
            Silk.NET.DXGI.Format outputFormat = default
        )
        {
            Guid = guid;
            SampleWidth = sampleWidth;
            SampleHeight = sampleHeight;
            OutputFormat = outputFormat;
        }


        [NativeName("Type", "GUID")]
        [NativeName("Type.Name", "GUID")]
        [NativeName("Name", "Guid")]
        public Guid Guid;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "SampleWidth")]
        public uint SampleWidth;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "SampleHeight")]
        public uint SampleHeight;

        [NativeName("Type", "DXGI_FORMAT")]
        [NativeName("Type.Name", "DXGI_FORMAT")]
        [NativeName("Name", "OutputFormat")]
        public Silk.NET.DXGI.Format OutputFormat;
    }
}
