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
    [NativeName("Name", "_DXVA2_AYUVSample16")]
    public unsafe partial struct DXVA2AYUVSample16
    {
        public DXVA2AYUVSample16
        (
            ushort? cr = null,
            ushort? cb = null,
            ushort? y = null,
            ushort? alpha = null
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


        [NativeName("Type", "USHORT")]
        [NativeName("Type.Name", "USHORT")]
        [NativeName("Name", "Cr")]
        public ushort Cr;

        [NativeName("Type", "USHORT")]
        [NativeName("Type.Name", "USHORT")]
        [NativeName("Name", "Cb")]
        public ushort Cb;

        [NativeName("Type", "USHORT")]
        [NativeName("Type.Name", "USHORT")]
        [NativeName("Name", "Y")]
        public ushort Y;

        [NativeName("Type", "USHORT")]
        [NativeName("Type.Name", "USHORT")]
        [NativeName("Name", "Alpha")]
        public ushort Alpha;
    }
}
