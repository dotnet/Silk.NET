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

namespace Silk.NET.Assimp
{
    [NativeName("Name", "aiPlane")]
    public unsafe partial struct Plane
    {
        public Plane
        (
            float? a = null,
            float? b = null,
            float? c = null,
            float? d = null
        ) : this()
        {
            if (a is not null)
            {
                A = a.Value;
            }

            if (b is not null)
            {
                B = b.Value;
            }

            if (c is not null)
            {
                C = c.Value;
            }

            if (d is not null)
            {
                D = d.Value;
            }
        }


        [NativeName("Type", "ai_real")]
        [NativeName("Type.Name", "ai_real")]
        [NativeName("Name", "a")]
        public float A;

        [NativeName("Type", "ai_real")]
        [NativeName("Type.Name", "ai_real")]
        [NativeName("Name", "b")]
        public float B;

        [NativeName("Type", "ai_real")]
        [NativeName("Type.Name", "ai_real")]
        [NativeName("Name", "c")]
        public float C;

        [NativeName("Type", "ai_real")]
        [NativeName("Type.Name", "ai_real")]
        [NativeName("Name", "d")]
        public float D;
    }
}
