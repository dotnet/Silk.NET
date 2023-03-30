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
    [NativeName("Name", "DWRITE_GLYPH_IMAGE_DATA")]
    public unsafe partial struct GlyphImageData
    {
        public GlyphImageData
        (
            void* imageData = null,
            uint? imageDataSize = null,
            uint? uniqueDataId = null,
            uint? pixelsPerEm = null,
            Silk.NET.Maths.Vector2D<uint>? pixelSize = null,
            Silk.NET.Maths.Vector2D<int>? horizontalLeftOrigin = null,
            Silk.NET.Maths.Vector2D<int>? horizontalRightOrigin = null,
            Silk.NET.Maths.Vector2D<int>? verticalTopOrigin = null,
            Silk.NET.Maths.Vector2D<int>? verticalBottomOrigin = null
        ) : this()
        {
            if (imageData is not null)
            {
                ImageData = imageData;
            }

            if (imageDataSize is not null)
            {
                ImageDataSize = imageDataSize.Value;
            }

            if (uniqueDataId is not null)
            {
                UniqueDataId = uniqueDataId.Value;
            }

            if (pixelsPerEm is not null)
            {
                PixelsPerEm = pixelsPerEm.Value;
            }

            if (pixelSize is not null)
            {
                PixelSize = pixelSize.Value;
            }

            if (horizontalLeftOrigin is not null)
            {
                HorizontalLeftOrigin = horizontalLeftOrigin.Value;
            }

            if (horizontalRightOrigin is not null)
            {
                HorizontalRightOrigin = horizontalRightOrigin.Value;
            }

            if (verticalTopOrigin is not null)
            {
                VerticalTopOrigin = verticalTopOrigin.Value;
            }

            if (verticalBottomOrigin is not null)
            {
                VerticalBottomOrigin = verticalBottomOrigin.Value;
            }
        }


        [NativeName("Type", "const void *")]
        [NativeName("Type.Name", "const void *")]
        [NativeName("Name", "imageData")]
        public void* ImageData;

        [NativeName("Type", "UINT32")]
        [NativeName("Type.Name", "UINT32")]
        [NativeName("Name", "imageDataSize")]
        public uint ImageDataSize;

        [NativeName("Type", "UINT32")]
        [NativeName("Type.Name", "UINT32")]
        [NativeName("Name", "uniqueDataId")]
        public uint UniqueDataId;

        [NativeName("Type", "UINT32")]
        [NativeName("Type.Name", "UINT32")]
        [NativeName("Name", "pixelsPerEm")]
        public uint PixelsPerEm;

        [NativeName("Type", "D2D1_SIZE_U")]
        [NativeName("Type.Name", "D2D1_SIZE_U")]
        [NativeName("Name", "pixelSize")]
        public Silk.NET.Maths.Vector2D<uint> PixelSize;

        [NativeName("Type", "D2D1_POINT_2L")]
        [NativeName("Type.Name", "D2D1_POINT_2L")]
        [NativeName("Name", "horizontalLeftOrigin")]
        public Silk.NET.Maths.Vector2D<int> HorizontalLeftOrigin;

        [NativeName("Type", "D2D1_POINT_2L")]
        [NativeName("Type.Name", "D2D1_POINT_2L")]
        [NativeName("Name", "horizontalRightOrigin")]
        public Silk.NET.Maths.Vector2D<int> HorizontalRightOrigin;

        [NativeName("Type", "D2D1_POINT_2L")]
        [NativeName("Type.Name", "D2D1_POINT_2L")]
        [NativeName("Name", "verticalTopOrigin")]
        public Silk.NET.Maths.Vector2D<int> VerticalTopOrigin;

        [NativeName("Type", "D2D1_POINT_2L")]
        [NativeName("Type.Name", "D2D1_POINT_2L")]
        [NativeName("Name", "verticalBottomOrigin")]
        public Silk.NET.Maths.Vector2D<int> VerticalBottomOrigin;
    }
}
