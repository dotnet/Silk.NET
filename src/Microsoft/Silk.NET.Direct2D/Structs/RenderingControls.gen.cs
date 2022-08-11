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
    [NativeName("Name", "D2D1_RENDERING_CONTROLS")]
    public unsafe partial struct RenderingControls
    {
        public RenderingControls
        (
            BufferPrecision? bufferPrecision = null,
            Silk.NET.Maths.Vector2D<uint>? tileSize = null
        ) : this()
        {
            if (bufferPrecision is not null)
            {
                BufferPrecision = bufferPrecision.Value;
            }

            if (tileSize is not null)
            {
                TileSize = tileSize.Value;
            }
        }


        [NativeName("Type", "D2D1_BUFFER_PRECISION")]
        [NativeName("Type.Name", "D2D1_BUFFER_PRECISION")]
        [NativeName("Name", "bufferPrecision")]
        public BufferPrecision BufferPrecision;

        [NativeName("Type", "D2D1_SIZE_U")]
        [NativeName("Type.Name", "D2D1_SIZE_U")]
        [NativeName("Name", "tileSize")]
        public Silk.NET.Maths.Vector2D<uint> TileSize;
    }
}
