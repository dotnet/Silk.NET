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
    [NativeName("Name", "_DXVA_Frequency")]
    public unsafe partial struct Frequency
    {
        public Frequency
        (
            int? numerator = null,
            int? denominator = null
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


        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "Numerator")]
        public int Numerator;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "Denominator")]
        public int Denominator;
    }
}
