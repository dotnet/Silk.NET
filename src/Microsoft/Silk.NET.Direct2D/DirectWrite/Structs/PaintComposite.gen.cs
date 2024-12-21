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

namespace Silk.NET.DirectWrite
{
    [NativeName("Name", "PAINT_COMPOSITE")]
    public unsafe partial struct PaintComposite
    {
        public PaintComposite
        (
            ColorCompositeMode? mode = null
        ) : this()
        {
            if (mode is not null)
            {
                Mode = mode.Value;
            }
        }


        [NativeName("Type", "DWRITE_COLOR_COMPOSITE_MODE")]
        [NativeName("Type.Name", "DWRITE_COLOR_COMPOSITE_MODE")]
        [NativeName("Name", "mode")]
        public ColorCompositeMode Mode;
    }
}
