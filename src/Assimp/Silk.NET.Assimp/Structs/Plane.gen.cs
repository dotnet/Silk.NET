// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.Assimp
{
    [NativeName("Name", "aiPlane")]
    public unsafe struct Plane
    {
        public Plane
        (
            double a = default,
            double b = default,
            double c = default,
            double d = default
        )
        {
           A = a;
           B = b;
           C = c;
           D = d;
        }


        [NativeName("Type", "ai_real")]
        [NativeName("Type.Name", "ai_real")]
        [NativeName("Name", "a")]
        public double A;

        [NativeName("Type", "ai_real")]
        [NativeName("Type.Name", "ai_real")]
        [NativeName("Name", "b")]
        public double B;

        [NativeName("Type", "ai_real")]
        [NativeName("Type.Name", "ai_real")]
        [NativeName("Name", "c")]
        public double C;

        [NativeName("Type", "ai_real")]
        [NativeName("Type.Name", "ai_real")]
        [NativeName("Name", "d")]
        public double D;
    }
}
