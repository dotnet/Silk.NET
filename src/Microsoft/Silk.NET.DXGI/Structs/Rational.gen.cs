// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


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

namespace Silk.NET.DXGI
{
    [NativeName("Name", "DXGI_RATIONAL")]
    public unsafe partial struct Rational
    {
        public Rational
        (
            uint? numerator = null,
            uint? denominator = null
        ) : this()
        {
            if (numerator is not null)
            {
                Numerator = numerator.Value;
            }

            if (denominator is not null)
            {
                Denominator = denominator.Value;
            }
        }


        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "Numerator")]
        public uint Numerator;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "Denominator")]
        public uint Denominator;
    }
}
