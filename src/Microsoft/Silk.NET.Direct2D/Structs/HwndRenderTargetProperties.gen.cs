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
    [NativeName("Name", "D2D1_HWND_RENDER_TARGET_PROPERTIES")]
    public unsafe partial struct HwndRenderTargetProperties
    {
        public HwndRenderTargetProperties
        (
            nint? hwnd = null,
            Silk.NET.Maths.Vector2D<uint>? pixelSize = null,
            PresentOptions? presentOptions = null
        ) : this()
        {
            if (hwnd is not null)
            {
                Hwnd = hwnd.Value;
            }

            if (pixelSize is not null)
            {
                PixelSize = pixelSize.Value;
            }

            if (presentOptions is not null)
            {
                PresentOptions = presentOptions.Value;
            }
        }


        [NativeName("Type", "HWND")]
        [NativeName("Type.Name", "HWND")]
        [NativeName("Name", "hwnd")]
        public nint Hwnd;

        [NativeName("Type", "D2D1_SIZE_U")]
        [NativeName("Type.Name", "D2D1_SIZE_U")]
        [NativeName("Name", "pixelSize")]
        public Silk.NET.Maths.Vector2D<uint> PixelSize;

        [NativeName("Type", "D2D1_PRESENT_OPTIONS")]
        [NativeName("Type.Name", "D2D1_PRESENT_OPTIONS")]
        [NativeName("Name", "presentOptions")]
        public PresentOptions PresentOptions;
    }
}
