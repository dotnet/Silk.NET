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
    [NativeName("Name", "_DXVA2_AYUVSample8")]
    public unsafe partial struct DXVA2AYUVSample8
    {
        public DXVA2AYUVSample8
        (
            byte? cr = null,
            byte? cb = null,
            byte? y = null,
            byte? alpha = null
        ) : this()
        {
            if (cr is not null)
            {
                Cr = cr.Value;
            }

            if (cb is not null)
            {
                Cb = cb.Value;
            }

            if (y is not null)
            {
                Y = y.Value;
            }

            if (alpha is not null)
            {
                Alpha = alpha.Value;
            }
        }


        [NativeName("Type", "UCHAR")]
        [NativeName("Type.Name", "UCHAR")]
        [NativeName("Name", "Cr")]
        public byte Cr;

        [NativeName("Type", "UCHAR")]
        [NativeName("Type.Name", "UCHAR")]
        [NativeName("Name", "Cb")]
        public byte Cb;

        [NativeName("Type", "UCHAR")]
        [NativeName("Type.Name", "UCHAR")]
        [NativeName("Name", "Y")]
        public byte Y;

        [NativeName("Type", "UCHAR")]
        [NativeName("Type.Name", "UCHAR")]
        [NativeName("Name", "Alpha")]
        public byte Alpha;
    }
}
