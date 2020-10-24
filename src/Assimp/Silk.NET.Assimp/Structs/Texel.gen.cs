// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Assimp
{
    [NativeName("Name", "aiTexel")]
    public unsafe partial struct Texel
    {
        public Texel
        (
            byte? b = null,
            byte? g = null,
            byte? r = null,
            byte? a = null
        ) : this()
        {
            if (b is not null)
            {
                B = b.Value;
            }

            if (g is not null)
            {
                G = g.Value;
            }

            if (r is not null)
            {
                R = r.Value;
            }

            if (a is not null)
            {
                A = a.Value;
            }
        }


        [NativeName("Type", "unsigned char")]
        [NativeName("Type.Name", "unsigned char")]
        [NativeName("Name", "b")]
        public byte B;

        [NativeName("Type", "unsigned char")]
        [NativeName("Type.Name", "unsigned char")]
        [NativeName("Name", "g")]
        public byte G;

        [NativeName("Type", "unsigned char")]
        [NativeName("Type.Name", "unsigned char")]
        [NativeName("Name", "r")]
        public byte R;

        [NativeName("Type", "unsigned char")]
        [NativeName("Type.Name", "unsigned char")]
        [NativeName("Name", "a")]
        public byte A;
    }
}
