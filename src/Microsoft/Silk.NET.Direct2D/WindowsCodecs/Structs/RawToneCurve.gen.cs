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
    [NativeName("Name", "WICRawToneCurve")]
    public unsafe partial struct RawToneCurve
    {
        public RawToneCurve
        (
            uint? cPoints = null
        ) : this()
        {
            if (cPoints is not null)
            {
                CPoints = cPoints.Value;
            }
        }


        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "cPoints")]
        public uint CPoints;
        
        [NativeName("Type", "WICRawToneCurvePoint[1]")]
        [NativeName("Type.Name", "WICRawToneCurvePoint[1]")]
        [NativeName("Name", "aPoints")]
        public APointsBuffer APoints;

        public struct APointsBuffer
        {
            public RawToneCurvePoint Element0;
            public ref RawToneCurvePoint this[int index]
            {
                get
                {
                    if (index > 0 || index < 0)
                    {
                        throw new ArgumentOutOfRangeException(nameof(index));
                    }

                    fixed (RawToneCurvePoint* ptr = &Element0)
                    {
                        return ref ptr[index];
                    }
                }
            }

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
            public Span<RawToneCurvePoint> AsSpan()
                => MemoryMarshal.CreateSpan(ref Element0, 1);
#endif
        }

    }
}
