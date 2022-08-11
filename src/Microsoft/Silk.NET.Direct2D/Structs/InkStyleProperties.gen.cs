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
    [NativeName("Name", "D2D1_INK_STYLE_PROPERTIES")]
    public unsafe partial struct InkStyleProperties
    {
        public InkStyleProperties
        (
            InkNibShape? nibShape = null,
            Silk.NET.Maths.Matrix3X2<float>? nibTransform = null
        ) : this()
        {
            if (nibShape is not null)
            {
                NibShape = nibShape.Value;
            }

            if (nibTransform is not null)
            {
                NibTransform = nibTransform.Value;
            }
        }


        [NativeName("Type", "D2D1_INK_NIB_SHAPE")]
        [NativeName("Type.Name", "D2D1_INK_NIB_SHAPE")]
        [NativeName("Name", "nibShape")]
        public InkNibShape NibShape;

        [NativeName("Type", "D2D1_MATRIX_3X2_F")]
        [NativeName("Type.Name", "D2D1_MATRIX_3X2_F")]
        [NativeName("Name", "nibTransform")]
        public Silk.NET.Maths.Matrix3X2<float> NibTransform;
    }
}
