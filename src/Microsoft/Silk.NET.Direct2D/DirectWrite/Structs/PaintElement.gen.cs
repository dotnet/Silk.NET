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
    [NativeName("Name", "DWRITE_PAINT_ELEMENT")]
    public unsafe partial struct PaintElement
    {
        public PaintElement
        (
            PaintType? paintType = null,
            PaintUnion? paint = null
        ) : this()
        {
            if (paintType is not null)
            {
                PaintType = paintType.Value;
            }

            if (paint is not null)
            {
                Paint = paint.Value;
            }
        }


        [NativeName("Type", "DWRITE_PAINT_TYPE")]
        [NativeName("Type.Name", "DWRITE_PAINT_TYPE")]
        [NativeName("Name", "paintType")]
        public PaintType PaintType;

        [NativeName("Type", "union PAINT_UNION")]
        [NativeName("Type.Name", "union PAINT_UNION")]
        [NativeName("Name", "paint")]
        public PaintUnion Paint;
    }
}
