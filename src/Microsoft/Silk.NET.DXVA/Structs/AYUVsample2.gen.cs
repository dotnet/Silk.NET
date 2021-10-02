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
    [NativeName("Name", "_DXVA_AYUVsample2")]
    public unsafe partial struct AYUVsample2
    {
        public AYUVsample2
        (
            byte? bCrValue = null,
            byte? bCbValue = null,
            byte? bYValue = null,
            byte? bSampleAlpha8 = null
        ) : this()
        {
            if (bCrValue is not null)
            {
                BCrValue = bCrValue.Value;
            }

            if (bCbValue is not null)
            {
                BCbValue = bCbValue.Value;
            }

            if (bYValue is not null)
            {
                BYValue = bYValue.Value;
            }

            if (bSampleAlpha8 is not null)
            {
                BSampleAlpha8 = bSampleAlpha8.Value;
            }
        }


        [NativeName("Type", "BYTE")]
        [NativeName("Type.Name", "BYTE")]
        [NativeName("Name", "bCrValue")]
        public byte BCrValue;

        [NativeName("Type", "BYTE")]
        [NativeName("Type.Name", "BYTE")]
        [NativeName("Name", "bCbValue")]
        public byte BCbValue;

        [NativeName("Type", "BYTE")]
        [NativeName("Type.Name", "BYTE")]
        [NativeName("Name", "bY_Value")]
        public byte BYValue;

        [NativeName("Type", "BYTE")]
        [NativeName("Type.Name", "BYTE")]
        [NativeName("Name", "bSampleAlpha8")]
        public byte BSampleAlpha8;
    }
}
