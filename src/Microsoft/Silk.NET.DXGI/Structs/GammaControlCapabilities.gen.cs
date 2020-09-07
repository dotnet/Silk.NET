// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
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
            int scaleAndOffsetSupported = default,
            float maxConvertedValue = default,
            float minConvertedValue = default,
            uint numGammaControlPoints = default
        )
        {
            ScaleAndOffsetSupported = scaleAndOffsetSupported;
            MaxConvertedValue = maxConvertedValue;
            MinConvertedValue = minConvertedValue;
            NumGammaControlPoints = numGammaControlPoints;
        }


        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "ScaleAndOffsetSupported")]
        public int ScaleAndOffsetSupported;

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
        [NativeName("Type", "float [1025]")]
        [NativeName("Type.Name", "float [1025]")]
        [NativeName("Name", "ControlPointPositions")]
        public fixed float ControlPointPositions[1025];
    }
}
