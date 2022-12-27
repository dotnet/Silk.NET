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

namespace Silk.NET.DXGI
{
    [NativeName("Name", "DXGI_GAMMA_CONTROL_CAPABILITIES")]
    public unsafe partial struct GammaControlCapabilities
    {
        public GammaControlCapabilities
        (
            Silk.NET.Core.Bool32? scaleAndOffsetSupported = null,
            float? maxConvertedValue = null,
            float? minConvertedValue = null,
            uint? numGammaControlPoints = null
        ) : this()
        {
            if (scaleAndOffsetSupported is not null)
            {
                ScaleAndOffsetSupported = scaleAndOffsetSupported.Value;
            }

            if (maxConvertedValue is not null)
            {
                MaxConvertedValue = maxConvertedValue.Value;
            }

            if (minConvertedValue is not null)
            {
                MinConvertedValue = minConvertedValue.Value;
            }

            if (numGammaControlPoints is not null)
            {
                NumGammaControlPoints = numGammaControlPoints.Value;
            }
        }


        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "ScaleAndOffsetSupported")]
        public Silk.NET.Core.Bool32 ScaleAndOffsetSupported;

        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "MaxConvertedValue")]
        public float MaxConvertedValue;

        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "MinConvertedValue")]
        public float MinConvertedValue;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "NumGammaControlPoints")]
        public uint NumGammaControlPoints;
        [NativeName("Type", "float[1025]")]
        [NativeName("Type.Name", "float[1025]")]
        [NativeName("Name", "ControlPointPositions")]
        public fixed float ControlPointPositions[1025];
    }
}
