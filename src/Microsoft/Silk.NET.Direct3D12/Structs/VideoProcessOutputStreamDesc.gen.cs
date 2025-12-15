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
    [NativeName("Name", "D3D12_VIDEO_PROCESS_OUTPUT_STREAM_DESC")]
    public unsafe partial struct VideoProcessOutputStreamDesc
    {
        public VideoProcessOutputStreamDesc
        (
            Silk.NET.DXGI.Format? format = null,
            Silk.NET.DXGI.ColorSpaceType? colorSpace = null,
            VideoProcessAlphaFillMode? alphaFillMode = null,
            uint? alphaFillModeSourceStreamIndex = null,
            Silk.NET.DXGI.Rational? frameRate = null,
            Silk.NET.Core.Bool32? enableStereo = null
        ) : this()
        {
            if (format is not null)
            {
                Format = format.Value;
            }

            if (colorSpace is not null)
            {
                ColorSpace = colorSpace.Value;
            }

            if (alphaFillMode is not null)
            {
                AlphaFillMode = alphaFillMode.Value;
            }

            if (alphaFillModeSourceStreamIndex is not null)
            {
                AlphaFillModeSourceStreamIndex = alphaFillModeSourceStreamIndex.Value;
            }

            if (frameRate is not null)
            {
                FrameRate = frameRate.Value;
            }

            if (enableStereo is not null)
            {
                EnableStereo = enableStereo.Value;
            }
        }


        [NativeName("Type", "DXGI_FORMAT")]
        [NativeName("Type.Name", "DXGI_FORMAT")]
        [NativeName("Name", "Format")]
        public Silk.NET.DXGI.Format Format;

        [NativeName("Type", "DXGI_COLOR_SPACE_TYPE")]
        [NativeName("Type.Name", "DXGI_COLOR_SPACE_TYPE")]
        [NativeName("Name", "ColorSpace")]
        public Silk.NET.DXGI.ColorSpaceType ColorSpace;

        [NativeName("Type", "D3D12_VIDEO_PROCESS_ALPHA_FILL_MODE")]
        [NativeName("Type.Name", "D3D12_VIDEO_PROCESS_ALPHA_FILL_MODE")]
        [NativeName("Name", "AlphaFillMode")]
        public VideoProcessAlphaFillMode AlphaFillMode;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "AlphaFillModeSourceStreamIndex")]
        public uint AlphaFillModeSourceStreamIndex;
        [NativeName("Type", "FLOAT[4]")]
        [NativeName("Type.Name", "FLOAT[4]")]
        [NativeName("Name", "BackgroundColor")]
        public fixed float BackgroundColor[4];

        [NativeName("Type", "DXGI_RATIONAL")]
        [NativeName("Type.Name", "DXGI_RATIONAL")]
        [NativeName("Name", "FrameRate")]
        public Silk.NET.DXGI.Rational FrameRate;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "EnableStereo")]
        public Silk.NET.Core.Bool32 EnableStereo;
    }
}
