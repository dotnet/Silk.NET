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
    [NativeName("Name", "_DXVAHD_BLT_STATE_BACKGROUND_COLOR_DATA")]
    public unsafe partial struct HDBltStateBackgroundColorData
    {
        public HDBltStateBackgroundColorData
        (
            Silk.NET.Core.Bool32? yCbCr = null,
            HDColor? backgroundColor = null
        ) : this()
        {
            if (yCbCr is not null)
            {
                YCbCr = yCbCr.Value;
            }

            if (backgroundColor is not null)
            {
                BackgroundColor = backgroundColor.Value;
            }
        }


        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "YCbCr")]
        public Silk.NET.Core.Bool32 YCbCr;

        [NativeName("Type", "DXVAHD_COLOR")]
        [NativeName("Type.Name", "DXVAHD_COLOR")]
        [NativeName("Name", "BackgroundColor")]
        public HDColor BackgroundColor;
    }
}
