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
    [NativeName("Name", "D2D1_DRAWING_STATE_DESCRIPTION")]
    public unsafe partial struct DrawingStateDescription
    {
        public DrawingStateDescription
        (
            AntialiasMode? antialiasMode = null,
            TextAntialiasMode? textAntialiasMode = null,
            ulong? tag1 = null,
            ulong? tag2 = null,
            Silk.NET.Maths.Matrix3X2<float>? transform = null
        ) : this()
        {
            if (antialiasMode is not null)
            {
                AntialiasMode = antialiasMode.Value;
            }

            if (textAntialiasMode is not null)
            {
                TextAntialiasMode = textAntialiasMode.Value;
            }

            if (tag1 is not null)
            {
                Tag1 = tag1.Value;
            }

            if (tag2 is not null)
            {
                Tag2 = tag2.Value;
            }

            if (transform is not null)
            {
                Transform = transform.Value;
            }
        }


        [NativeName("Type", "D2D1_ANTIALIAS_MODE")]
        [NativeName("Type.Name", "D2D1_ANTIALIAS_MODE")]
        [NativeName("Name", "antialiasMode")]
        public AntialiasMode AntialiasMode;

        [NativeName("Type", "D2D1_TEXT_ANTIALIAS_MODE")]
        [NativeName("Type.Name", "D2D1_TEXT_ANTIALIAS_MODE")]
        [NativeName("Name", "textAntialiasMode")]
        public TextAntialiasMode TextAntialiasMode;

        [NativeName("Type", "D2D1_TAG")]
        [NativeName("Type.Name", "D2D1_TAG")]
        [NativeName("Name", "tag1")]
        public ulong Tag1;

        [NativeName("Type", "D2D1_TAG")]
        [NativeName("Type.Name", "D2D1_TAG")]
        [NativeName("Name", "tag2")]
        public ulong Tag2;

        [NativeName("Type", "D2D1_MATRIX_3X2_F")]
        [NativeName("Type.Name", "D2D1_MATRIX_3X2_F")]
        [NativeName("Name", "transform")]
        public Silk.NET.Maths.Matrix3X2<float> Transform;
    }
}
