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

namespace Silk.NET.DXVA
{
    [NativeName("Name", "__AnonymousRecord_dxva2api_L467_C9")]
    public unsafe partial struct DXVA2Fixed32UnionUnion
    {
        public DXVA2Fixed32UnionUnion
        (
            ushort? fraction = null,
            short? value = null
        ) : this()
        {
            if (fraction is not null)
            {
                Fraction = fraction.Value;
            }

            if (value is not null)
            {
                Value = value.Value;
            }
        }


        [NativeName("Type", "USHORT")]
        [NativeName("Type.Name", "USHORT")]
        [NativeName("Name", "Fraction")]
        public ushort Fraction;

        [NativeName("Type", "SHORT")]
        [NativeName("Type.Name", "SHORT")]
        [NativeName("Name", "Value")]
        public short Value;
    }
}
