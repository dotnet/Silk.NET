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
    [NativeName("Name", "_DXVA2_ProcAmpValues")]
    public unsafe partial struct DXVA2ProcAmpValues
    {
        public DXVA2ProcAmpValues
        (
            DXVA2Fixed32? brightness = null,
            DXVA2Fixed32? contrast = null,
            DXVA2Fixed32? hue = null,
            DXVA2Fixed32? saturation = null
        ) : this()
        {
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


        [NativeName("Type", "DXVA2_Fixed32")]
        [NativeName("Type.Name", "DXVA2_Fixed32")]
        [NativeName("Name", "Brightness")]
        public DXVA2Fixed32 Brightness;

        [NativeName("Type", "DXVA2_Fixed32")]
        [NativeName("Type.Name", "DXVA2_Fixed32")]
        [NativeName("Name", "Contrast")]
        public DXVA2Fixed32 Contrast;

        [NativeName("Type", "DXVA2_Fixed32")]
        [NativeName("Type.Name", "DXVA2_Fixed32")]
        [NativeName("Name", "Hue")]
        public DXVA2Fixed32 Hue;

        [NativeName("Type", "DXVA2_Fixed32")]
        [NativeName("Type.Name", "DXVA2_Fixed32")]
        [NativeName("Name", "Saturation")]
        public DXVA2Fixed32 Saturation;
    }
}
