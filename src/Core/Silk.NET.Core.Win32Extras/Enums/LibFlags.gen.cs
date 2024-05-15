// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Core.Win32Extras
{
    [Flags]
    [NativeName("Name", "tagLIBFLAGS")]
    public enum LibFlags : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"Frestricted\"")]
        [NativeName("Name", "LIBFLAG_FRESTRICTED")]
        LibflagFrestricted = 0x1,
        [Obsolete("Deprecated in favour of \"Fcontrol\"")]
        [NativeName("Name", "LIBFLAG_FCONTROL")]
        LibflagFcontrol = 0x2,
        [Obsolete("Deprecated in favour of \"Fhidden\"")]
        [NativeName("Name", "LIBFLAG_FHIDDEN")]
        LibflagFhidden = 0x4,
        [Obsolete("Deprecated in favour of \"Fhasdiskimage\"")]
        [NativeName("Name", "LIBFLAG_FHASDISKIMAGE")]
        LibflagFhasdiskimage = 0x8,
        [NativeName("Name", "LIBFLAG_FRESTRICTED")]
        Frestricted = 0x1,
        [NativeName("Name", "LIBFLAG_FCONTROL")]
        Fcontrol = 0x2,
        [NativeName("Name", "LIBFLAG_FHIDDEN")]
        Fhidden = 0x4,
        [NativeName("Name", "LIBFLAG_FHASDISKIMAGE")]
        Fhasdiskimage = 0x8,
    }
}
