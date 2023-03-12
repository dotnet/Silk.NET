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

namespace Silk.NET.WebGPU.Extensions.WGPU
{
    [NativeName("Name", "WGPUSurfaceCapabilities")]
    public unsafe partial struct SurfaceCapabilities
    {
        public SurfaceCapabilities
        (
            nuint? formatCount = null,
            TextureFormat* formats = null,
            nuint? presentModeCount = null,
            PresentMode* presentModes = null,
            nuint? alphaModeCount = null,
            CompositeAlphaMode* alphaModes = null
        ) : this()
        {
            if (formatCount is not null)
            {
                FormatCount = formatCount.Value;
            }

            if (formats is not null)
            {
                Formats = formats;
            }

            if (presentModeCount is not null)
            {
                PresentModeCount = presentModeCount.Value;
            }

            if (presentModes is not null)
            {
                PresentModes = presentModes;
            }

            if (alphaModeCount is not null)
            {
                AlphaModeCount = alphaModeCount.Value;
            }

            if (alphaModes is not null)
            {
                AlphaModes = alphaModes;
            }
        }


        [NativeName("Type", "size_t")]
        [NativeName("Type.Name", "size_t")]
        [NativeName("Name", "formatCount")]
        public nuint FormatCount;

        [NativeName("Type", "WGPUTextureFormat *")]
        [NativeName("Type.Name", "WGPUTextureFormat *")]
        [NativeName("Name", "formats")]
        public TextureFormat* Formats;

        [NativeName("Type", "size_t")]
        [NativeName("Type.Name", "size_t")]
        [NativeName("Name", "presentModeCount")]
        public nuint PresentModeCount;

        [NativeName("Type", "WGPUPresentMode *")]
        [NativeName("Type.Name", "WGPUPresentMode *")]
        [NativeName("Name", "presentModes")]
        public PresentMode* PresentModes;

        [NativeName("Type", "size_t")]
        [NativeName("Type.Name", "size_t")]
        [NativeName("Name", "alphaModeCount")]
        public nuint AlphaModeCount;

        [NativeName("Type", "WGPUCompositeAlphaMode *")]
        [NativeName("Type.Name", "WGPUCompositeAlphaMode *")]
        [NativeName("Name", "alphaModes")]
        public CompositeAlphaMode* AlphaModes;
    }
}
