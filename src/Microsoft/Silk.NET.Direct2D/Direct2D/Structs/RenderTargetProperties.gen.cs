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

namespace Silk.NET.Direct2D
{
    [NativeName("Name", "D2D1_RENDER_TARGET_PROPERTIES")]
    public unsafe partial struct RenderTargetProperties
    {
        public RenderTargetProperties
        (
            RenderTargetType? type = null,
            PixelFormat? pixelFormat = null,
            float? dpiX = null,
            float? dpiY = null,
            RenderTargetUsage? usage = null,
            FeatureLevel? minLevel = null
        ) : this()
        {
            if (type is not null)
            {
                Type = type.Value;
            }

            if (pixelFormat is not null)
            {
                PixelFormat = pixelFormat.Value;
            }

            if (dpiX is not null)
            {
                DpiX = dpiX.Value;
            }

            if (dpiY is not null)
            {
                DpiY = dpiY.Value;
            }

            if (usage is not null)
            {
                Usage = usage.Value;
            }

            if (minLevel is not null)
            {
                MinLevel = minLevel.Value;
            }
        }


        [NativeName("Type", "D2D1_RENDER_TARGET_TYPE")]
        [NativeName("Type.Name", "D2D1_RENDER_TARGET_TYPE")]
        [NativeName("Name", "type")]
        public RenderTargetType Type;

        [NativeName("Type", "D2D1_PIXEL_FORMAT")]
        [NativeName("Type.Name", "D2D1_PIXEL_FORMAT")]
        [NativeName("Name", "pixelFormat")]
        public PixelFormat PixelFormat;

        [NativeName("Type", "FLOAT")]
        [NativeName("Type.Name", "FLOAT")]
        [NativeName("Name", "dpiX")]
        public float DpiX;

        [NativeName("Type", "FLOAT")]
        [NativeName("Type.Name", "FLOAT")]
        [NativeName("Name", "dpiY")]
        public float DpiY;

        [NativeName("Type", "D2D1_RENDER_TARGET_USAGE")]
        [NativeName("Type.Name", "D2D1_RENDER_TARGET_USAGE")]
        [NativeName("Name", "usage")]
        public RenderTargetUsage Usage;

        [NativeName("Type", "D2D1_FEATURE_LEVEL")]
        [NativeName("Type.Name", "D2D1_FEATURE_LEVEL")]
        [NativeName("Name", "minLevel")]
        public FeatureLevel MinLevel;
    }
}
