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

namespace Silk.NET.DirectWrite
{
    [NativeName("Name", "DWRITE_CARET_METRICS")]
    public unsafe partial struct CaretMetrics
    {
        public CaretMetrics
        (
            short? slopeRise = null,
            short? slopeRun = null,
            short? offset = null
        ) : this()
        {
            if (slopeRise is not null)
            {
                SlopeRise = slopeRise.Value;
            }

            if (slopeRun is not null)
            {
                SlopeRun = slopeRun.Value;
            }

            if (offset is not null)
            {
                Offset = offset.Value;
            }
        }


        [NativeName("Type", "INT16")]
        [NativeName("Type.Name", "INT16")]
        [NativeName("Name", "slopeRise")]
        public short SlopeRise;

        [NativeName("Type", "INT16")]
        [NativeName("Type.Name", "INT16")]
        [NativeName("Name", "slopeRun")]
        public short SlopeRun;

        [NativeName("Type", "INT16")]
        [NativeName("Type.Name", "INT16")]
        [NativeName("Name", "offset")]
        public short Offset;
    }
}
