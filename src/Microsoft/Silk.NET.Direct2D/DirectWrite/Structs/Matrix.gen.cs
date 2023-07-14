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
    [NativeName("Name", "DWRITE_MATRIX")]
    public unsafe partial struct Matrix
    {
        public Matrix
        (
            float? m11 = null,
            float? m12 = null,
            float? m21 = null,
            float? m22 = null,
            float? dx = null,
            float? dy = null
        ) : this()
        {
            if (m11 is not null)
            {
                M11 = m11.Value;
            }

            if (m12 is not null)
            {
                M12 = m12.Value;
            }

            if (m21 is not null)
            {
                M21 = m21.Value;
            }

            if (m22 is not null)
            {
                M22 = m22.Value;
            }

            if (dx is not null)
            {
                Dx = dx.Value;
            }

            if (dy is not null)
            {
                Dy = dy.Value;
            }
        }


        [NativeName("Type", "FLOAT")]
        [NativeName("Type.Name", "FLOAT")]
        [NativeName("Name", "m11")]
        public float M11;

        [NativeName("Type", "FLOAT")]
        [NativeName("Type.Name", "FLOAT")]
        [NativeName("Name", "m12")]
        public float M12;

        [NativeName("Type", "FLOAT")]
        [NativeName("Type.Name", "FLOAT")]
        [NativeName("Name", "m21")]
        public float M21;

        [NativeName("Type", "FLOAT")]
        [NativeName("Type.Name", "FLOAT")]
        [NativeName("Name", "m22")]
        public float M22;

        [NativeName("Type", "FLOAT")]
        [NativeName("Type.Name", "FLOAT")]
        [NativeName("Name", "dx")]
        public float Dx;

        [NativeName("Type", "FLOAT")]
        [NativeName("Type.Name", "FLOAT")]
        [NativeName("Name", "dy")]
        public float Dy;
    }
}
