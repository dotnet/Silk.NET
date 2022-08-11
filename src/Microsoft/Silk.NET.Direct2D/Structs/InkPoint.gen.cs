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
    [NativeName("Name", "D2D1_INK_POINT")]
    public unsafe partial struct InkPoint
    {
        public InkPoint
        (
            float? x = null,
            float? y = null,
            float? radius = null
        ) : this()
        {
            if (x is not null)
            {
                X = x.Value;
            }

            if (y is not null)
            {
                Y = y.Value;
            }

            if (radius is not null)
            {
                Radius = radius.Value;
            }
        }


        [NativeName("Type", "FLOAT")]
        [NativeName("Type.Name", "FLOAT")]
        [NativeName("Name", "x")]
        public float X;

        [NativeName("Type", "FLOAT")]
        [NativeName("Type.Name", "FLOAT")]
        [NativeName("Name", "y")]
        public float Y;

        [NativeName("Type", "FLOAT")]
        [NativeName("Type.Name", "FLOAT")]
        [NativeName("Name", "radius")]
        public float Radius;
    }
}
