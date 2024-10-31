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

namespace Silk.NET.Core.Win32Extras
{
    [NativeName("Name", "__AnonymousRecord_evntrace_L916_C9")]
    public unsafe partial struct EventTraceHeaderUnion1Union
    {
        public EventTraceHeaderUnion1Union
        (
            byte? headerType = null,
            byte? markerFlags = null
        ) : this()
        {
            if (headerType is not null)
            {
                HeaderType = headerType.Value;
            }

            if (markerFlags is not null)
            {
                MarkerFlags = markerFlags.Value;
            }
        }


        [NativeName("Type", "UCHAR")]
        [NativeName("Type.Name", "UCHAR")]
        [NativeName("Name", "HeaderType")]
        public byte HeaderType;

        [NativeName("Type", "UCHAR")]
        [NativeName("Type.Name", "UCHAR")]
        [NativeName("Name", "MarkerFlags")]
        public byte MarkerFlags;
    }
}
