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
    [StructLayout(LayoutKind.Explicit)]
    [NativeName("Name", "_DXVAHD_COLOR")]
    public unsafe partial struct HDColor
    {
        public HDColor
        (
            HDColorRgba? rGB = null,
            HDCOLORYCbCrA? yCbCr = null
        ) : this()
        {
            if (rGB is not null)
            {
                RGB = rGB.Value;
            }

            if (yCbCr is not null)
            {
                YCbCr = yCbCr.Value;
            }
        }


        [FieldOffset(0)]
        [NativeName("Type", "DXVAHD_COLOR_RGBA")]
        [NativeName("Type.Name", "DXVAHD_COLOR_RGBA")]
        [NativeName("Name", "RGB")]
        public HDColorRgba RGB;

        [FieldOffset(0)]
        [NativeName("Type", "DXVAHD_COLOR_YCbCrA")]
        [NativeName("Type.Name", "DXVAHD_COLOR_YCbCrA")]
        [NativeName("Name", "YCbCr")]
        public HDCOLORYCbCrA YCbCr;
    }
}
