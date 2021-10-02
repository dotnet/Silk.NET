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

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_SAMPLE_POSITION")]
    public unsafe partial struct SamplePosition
    {
        public SamplePosition
        (
            byte? x = null,
            byte? y = null
        ) : this()
        {
            if (x is not null)
            {
                X = x.Value;
            }

            if (y is not null)
            {
                Y = y.Value;
            }
        }


        [NativeName("Type", "INT8")]
        [NativeName("Type.Name", "INT8")]
        [NativeName("Name", "X")]
        public byte X;

        [NativeName("Type", "INT8")]
        [NativeName("Type.Name", "INT8")]
        [NativeName("Name", "Y")]
        public byte Y;
    }
}
