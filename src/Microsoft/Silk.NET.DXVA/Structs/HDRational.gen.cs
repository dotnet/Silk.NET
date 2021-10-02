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
    [NativeName("Name", "_DXVAHD_RATIONAL")]
    public unsafe partial struct HDRational
    {
        public HDRational
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
