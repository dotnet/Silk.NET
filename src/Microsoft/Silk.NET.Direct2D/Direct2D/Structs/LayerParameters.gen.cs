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
    [NativeName("Name", "D2D1_LAYER_PARAMETERS")]
    public unsafe partial struct LayerParameters
    {
        public LayerParameters
        (
            Silk.NET.Maths.Box2D<float>? contentBounds = null,
            ID2D1Geometry* geometricMask = null,
            AntialiasMode? maskAntialiasMode = null,
            Silk.NET.Maths.Matrix3X2<float>? maskTransform = null,
            float? opacity = null,
            ID2D1Brush* opacityBrush = null,
            LayerOptions? layerOptions = null
        ) : this()
        {
            if (contentBounds is not null)
            {
                ContentBounds = contentBounds.Value;
            }

            if (geometricMask is not null)
            {
                GeometricMask = geometricMask;
            }

            if (maskAntialiasMode is not null)
            {
                MaskAntialiasMode = maskAntialiasMode.Value;
            }

            if (maskTransform is not null)
            {
                MaskTransform = maskTransform.Value;
            }

            if (opacity is not null)
            {
                Opacity = opacity.Value;
            }

            if (opacityBrush is not null)
            {
                OpacityBrush = opacityBrush;
            }

            if (layerOptions is not null)
            {
                LayerOptions = layerOptions.Value;
            }
        }


        [NativeName("Type", "D2D1_RECT_F")]
        [NativeName("Type.Name", "D2D1_RECT_F")]
        [NativeName("Name", "contentBounds")]
        public Silk.NET.Maths.Box2D<float> ContentBounds;

        [NativeName("Type", "ID2D1Geometry *")]
        [NativeName("Type.Name", "ID2D1Geometry *")]
        [NativeName("Name", "geometricMask")]
        public ID2D1Geometry* GeometricMask;

        [NativeName("Type", "D2D1_ANTIALIAS_MODE")]
        [NativeName("Type.Name", "D2D1_ANTIALIAS_MODE")]
        [NativeName("Name", "maskAntialiasMode")]
        public AntialiasMode MaskAntialiasMode;

        [NativeName("Type", "D2D1_MATRIX_3X2_F")]
        [NativeName("Type.Name", "D2D1_MATRIX_3X2_F")]
        [NativeName("Name", "maskTransform")]
        public Silk.NET.Maths.Matrix3X2<float> MaskTransform;

        [NativeName("Type", "FLOAT")]
        [NativeName("Type.Name", "FLOAT")]
        [NativeName("Name", "opacity")]
        public float Opacity;

        [NativeName("Type", "ID2D1Brush *")]
        [NativeName("Type.Name", "ID2D1Brush *")]
        [NativeName("Name", "opacityBrush")]
        public ID2D1Brush* OpacityBrush;

        [NativeName("Type", "D2D1_LAYER_OPTIONS")]
        [NativeName("Type.Name", "D2D1_LAYER_OPTIONS")]
        [NativeName("Name", "layerOptions")]
        public LayerOptions LayerOptions;
    }
}
