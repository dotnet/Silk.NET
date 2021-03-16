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

namespace Silk.NET.Direct3D11
{
    [NativeName("Name", "D3D11_VIDEO_DECODER_DESC")]
    public unsafe partial struct VideoDecoderDesc
    {
        public VideoDecoderDesc
        (
            Guid? guid = null,
            uint? sampleWidth = null,
            uint? sampleHeight = null,
            Silk.NET.DXGI.Format? outputFormat = null
        ) : this()
        {
            if (guid is not null)
            {
                Guid = guid.Value;
            }

            if (sampleWidth is not null)
            {
                SampleWidth = sampleWidth.Value;
            }

            if (sampleHeight is not null)
            {
                SampleHeight = sampleHeight.Value;
            }

            if (outputFormat is not null)
            {
                OutputFormat = outputFormat.Value;
            }
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
