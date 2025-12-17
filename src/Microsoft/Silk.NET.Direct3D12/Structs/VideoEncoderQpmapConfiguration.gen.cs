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
    [NativeName("Name", "D3D12_VIDEO_ENCODER_QPMAP_CONFIGURATION")]
    public unsafe partial struct VideoEncoderQpmapConfiguration
    {
        public VideoEncoderQpmapConfiguration
        (
            Silk.NET.Core.Bool32? enabled = null,
            VideoEncoderInputMapSource? mapSource = null
        ) : this()
        {
            if (enabled is not null)
            {
                Enabled = enabled.Value;
            }

            if (mapSource is not null)
            {
                MapSource = mapSource.Value;
            }
        }


        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "Enabled")]
        public Silk.NET.Core.Bool32 Enabled;

        [NativeName("Type", "D3D12_VIDEO_ENCODER_INPUT_MAP_SOURCE")]
        [NativeName("Type.Name", "D3D12_VIDEO_ENCODER_INPUT_MAP_SOURCE")]
        [NativeName("Name", "MapSource")]
        public VideoEncoderInputMapSource MapSource;
    }
}
