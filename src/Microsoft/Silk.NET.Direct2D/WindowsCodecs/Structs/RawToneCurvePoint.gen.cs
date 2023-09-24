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

namespace Silk.NET.WindowsCodecs
{
    [NativeName("Name", "WICRawToneCurvePoint")]
    public unsafe partial struct RawToneCurvePoint
    {
        public RawToneCurvePoint
        (
            double? input = null,
            double? output = null
        ) : this()
        {
            if (input is not null)
            {
                Input = input.Value;
            }

            if (output is not null)
            {
                Output = output.Value;
            }
        }


        [NativeName("Type", "double")]
        [NativeName("Type.Name", "double")]
        [NativeName("Name", "Input")]
        public double Input;

        [NativeName("Type", "double")]
        [NativeName("Type.Name", "double")]
        [NativeName("Name", "Output")]
        public double Output;
    }
}
