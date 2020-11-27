// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
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
            int? scaleAndOffsetSupported = null,
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
