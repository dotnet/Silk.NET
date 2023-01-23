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

namespace Silk.NET.DXVA
{
    [NativeName("Name", "_DXVA_ProcAmpControlBlt")]
    public unsafe partial struct ProcAmpControlBlt
    {
        public ProcAmpControlBlt
        (
            uint? size = null,
            Silk.NET.Maths.Box2D<int>? dstRect = null,
            Silk.NET.Maths.Box2D<int>? srcRect = null,
            float? alpha = null,
            float? brightness = null,
            float? contrast = null,
            float? hue = null,
            float? saturation = null
        ) : this()
        {
            if (size is not null)
            {
                Size = size.Value;
            }

            if (dstRect is not null)
            {
                DstRect = dstRect.Value;
            }

            if (srcRect is not null)
            {
                SrcRect = srcRect.Value;
            }

            if (alpha is not null)
            {
                Alpha = alpha.Value;
            }

            if (brightness is not null)
            {
                Brightness = brightness.Value;
            }

            if (contrast is not null)
            {
                Contrast = contrast.Value;
            }

            if (hue is not null)
            {
                Hue = hue.Value;
            }

            if (saturation is not null)
            {
                Saturation = saturation.Value;
            }
        }


        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "Size")]
        public uint Size;

        [NativeName("Type", "RECT")]
        [NativeName("Type.Name", "RECT")]
        [NativeName("Name", "DstRect")]
        public Silk.NET.Maths.Box2D<int> DstRect;

        [NativeName("Type", "RECT")]
        [NativeName("Type.Name", "RECT")]
        [NativeName("Name", "SrcRect")]
        public Silk.NET.Maths.Box2D<int> SrcRect;

        [NativeName("Type", "FLOAT")]
        [NativeName("Type.Name", "FLOAT")]
        [NativeName("Name", "Alpha")]
        public float Alpha;

        [NativeName("Type", "FLOAT")]
        [NativeName("Type.Name", "FLOAT")]
        [NativeName("Name", "Brightness")]
        public float Brightness;

        [NativeName("Type", "FLOAT")]
        [NativeName("Type.Name", "FLOAT")]
        [NativeName("Name", "Contrast")]
        public float Contrast;

        [NativeName("Type", "FLOAT")]
        [NativeName("Type.Name", "FLOAT")]
        [NativeName("Name", "Hue")]
        public float Hue;

        [NativeName("Type", "FLOAT")]
        [NativeName("Type.Name", "FLOAT")]
        [NativeName("Name", "Saturation")]
        public float Saturation;
    }
}
