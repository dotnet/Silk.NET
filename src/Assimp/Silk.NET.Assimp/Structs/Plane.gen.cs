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
            float a = default,
            float b = default,
            float c = default,
            float d = default
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
