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
    [NativeName("Name", "__AnonymousRecord_evntrace_L1069_C9")]
    public unsafe partial struct TraceLogfileHeaderUnion1VersionDetail
    {
        public TraceLogfileHeaderUnion1VersionDetail
        (
            byte? majorVersion = null,
            byte? minorVersion = null,
            byte? subVersion = null,
            byte? subMinorVersion = null
        ) : this()
        {
            if (majorVersion is not null)
            {
                MajorVersion = majorVersion.Value;
            }

            if (minorVersion is not null)
            {
                MinorVersion = minorVersion.Value;
            }

            if (subVersion is not null)
            {
                SubVersion = subVersion.Value;
            }

            if (subMinorVersion is not null)
            {
                SubMinorVersion = subMinorVersion.Value;
            }
        }


        [NativeName("Type", "UCHAR")]
        [NativeName("Type.Name", "UCHAR")]
        [NativeName("Name", "MajorVersion")]
        public byte MajorVersion;

        [NativeName("Type", "UCHAR")]
        [NativeName("Type.Name", "UCHAR")]
        [NativeName("Name", "MinorVersion")]
        public byte MinorVersion;

        [NativeName("Type", "UCHAR")]
        [NativeName("Type.Name", "UCHAR")]
        [NativeName("Name", "SubVersion")]
        public byte SubVersion;

        [NativeName("Type", "UCHAR")]
        [NativeName("Type.Name", "UCHAR")]
        [NativeName("Name", "SubMinorVersion")]
        public byte SubMinorVersion;
    }
}
