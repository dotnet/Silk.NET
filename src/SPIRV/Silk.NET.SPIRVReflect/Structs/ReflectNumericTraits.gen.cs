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

namespace Silk.NET.SPIRVReflect
{
    [NativeName("Name", "SpvReflectNumericTraits")]
    public unsafe partial struct ReflectNumericTraits
    {
        public ReflectNumericTraits
        (
            Scalar? scalar = null,
            Vector? vector = null,
            Matrix? matrix = null
        ) : this()
        {
            if (scalar is not null)
            {
                Scalar = scalar.Value;
            }

            if (vector is not null)
            {
                Vector = vector.Value;
            }

            if (matrix is not null)
            {
                Matrix = matrix.Value;
            }
        }


        [NativeName("Type", "struct Scalar")]
        [NativeName("Type.Name", "struct Scalar")]
        [NativeName("Name", "scalar")]
        public Scalar Scalar;

        [NativeName("Type", "struct Vector")]
        [NativeName("Type.Name", "struct Vector")]
        [NativeName("Name", "vector")]
        public Vector Vector;

        [NativeName("Type", "struct Matrix")]
        [NativeName("Type.Name", "struct Matrix")]
        [NativeName("Name", "matrix")]
        public Matrix Matrix;
    }
}
