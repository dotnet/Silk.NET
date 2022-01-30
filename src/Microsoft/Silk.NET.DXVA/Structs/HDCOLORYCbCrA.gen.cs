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
    [NativeName("Name", "_DXVAHD_COLOR_YCbCrA")]
    public unsafe partial struct HDCOLORYCbCrA
    {
        public HDCOLORYCbCrA
        (
            float? y = null,
            float? cb = null,
            float? cr = null,
            float? a = null
        ) : this()
        {
            if (y is not null)
            {
                Y = y.Value;
            }

            if (cb is not null)
            {
                Cb = cb.Value;
            }

            if (cr is not null)
            {
                Cr = cr.Value;
            }

            if (a is not null)
            {
                A = a.Value;
            }
        }


        [NativeName("Type", "FLOAT")]
        [NativeName("Type.Name", "FLOAT")]
        [NativeName("Name", "Y")]
        public float Y;

        [NativeName("Type", "FLOAT")]
        [NativeName("Type.Name", "FLOAT")]
        [NativeName("Name", "Cb")]
        public float Cb;

        [NativeName("Type", "FLOAT")]
        [NativeName("Type.Name", "FLOAT")]
        [NativeName("Name", "Cr")]
        public float Cr;

        [NativeName("Type", "FLOAT")]
        [NativeName("Type.Name", "FLOAT")]
        [NativeName("Name", "A")]
        public float A;
    }
}
