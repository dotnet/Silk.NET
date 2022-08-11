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
    [NativeName("Name", "D2D1_TRANSFORMED_IMAGE_SOURCE_PROPERTIES")]
    public unsafe partial struct TransformedImageSourceProperties
    {
        public TransformedImageSourceProperties
        (
            Orientation? orientation = null,
            float? scaleX = null,
            float? scaleY = null,
            InterpolationMode? interpolationMode = null,
            TransformedImageSourceOptions? options = null
        ) : this()
        {
            if (orientation is not null)
            {
                Orientation = orientation.Value;
            }

            if (scaleX is not null)
            {
                ScaleX = scaleX.Value;
            }

            if (scaleY is not null)
            {
                ScaleY = scaleY.Value;
            }

            if (interpolationMode is not null)
            {
                InterpolationMode = interpolationMode.Value;
            }

            if (options is not null)
            {
                Options = options.Value;
            }
        }


        [NativeName("Type", "D2D1_ORIENTATION")]
        [NativeName("Type.Name", "D2D1_ORIENTATION")]
        [NativeName("Name", "orientation")]
        public Orientation Orientation;

        [NativeName("Type", "FLOAT")]
        [NativeName("Type.Name", "FLOAT")]
        [NativeName("Name", "scaleX")]
        public float ScaleX;

        [NativeName("Type", "FLOAT")]
        [NativeName("Type.Name", "FLOAT")]
        [NativeName("Name", "scaleY")]
        public float ScaleY;

        [NativeName("Type", "D2D1_INTERPOLATION_MODE")]
        [NativeName("Type.Name", "D2D1_INTERPOLATION_MODE")]
        [NativeName("Name", "interpolationMode")]
        public InterpolationMode InterpolationMode;

        [NativeName("Type", "D2D1_TRANSFORMED_IMAGE_SOURCE_OPTIONS")]
        [NativeName("Type.Name", "D2D1_TRANSFORMED_IMAGE_SOURCE_OPTIONS")]
        [NativeName("Name", "options")]
        public TransformedImageSourceOptions Options;
    }
}
