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
    [NativeName("Name", "_DXVA_VideoSample")]
    public unsafe partial struct VideoSample
    {
        public VideoSample
        (
            long? rtStart = null,
            long? rtEnd = null,
            SampleFormat? sampleFormat = null,
            void* lpDDSSrcSurface = null
        ) : this()
        {
            if (rtStart is not null)
            {
                RtStart = rtStart.Value;
            }

            if (rtEnd is not null)
            {
                RtEnd = rtEnd.Value;
            }

            if (sampleFormat is not null)
            {
                SampleFormat = sampleFormat.Value;
            }

            if (lpDDSSrcSurface is not null)
            {
                LpDDSSrcSurface = lpDDSSrcSurface;
            }
        }


        [NativeName("Type", "REFERENCE_TIME")]
        [NativeName("Type.Name", "REFERENCE_TIME")]
        [NativeName("Name", "rtStart")]
        public long RtStart;

        [NativeName("Type", "REFERENCE_TIME")]
        [NativeName("Type.Name", "REFERENCE_TIME")]
        [NativeName("Name", "rtEnd")]
        public long RtEnd;

        [NativeName("Type", "DXVA_SampleFormat")]
        [NativeName("Type.Name", "DXVA_SampleFormat")]
        [NativeName("Name", "SampleFormat")]
        public SampleFormat SampleFormat;

        [NativeName("Type", "void *")]
        [NativeName("Type.Name", "void *")]
        [NativeName("Name", "lpDDSSrcSurface")]
        public void* LpDDSSrcSurface;
    }
}
