// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Core.Win32Extras
{
    [Flags]
    [NativeName("Name", "tagTYPEFLAGS")]
    public enum TypeFlags : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"Fappobject\"")]
        [NativeName("Name", "TYPEFLAG_FAPPOBJECT")]
        TypeflagFappobject = 0x1,
        [Obsolete("Deprecated in favour of \"Fcancreate\"")]
        [NativeName("Name", "TYPEFLAG_FCANCREATE")]
        TypeflagFcancreate = 0x2,
        [Obsolete("Deprecated in favour of \"Flicensed\"")]
        [NativeName("Name", "TYPEFLAG_FLICENSED")]
        TypeflagFlicensed = 0x4,
        [Obsolete("Deprecated in favour of \"Fpredeclid\"")]
        [NativeName("Name", "TYPEFLAG_FPREDECLID")]
        TypeflagFpredeclid = 0x8,
        [Obsolete("Deprecated in favour of \"Fhidden\"")]
        [NativeName("Name", "TYPEFLAG_FHIDDEN")]
        TypeflagFhidden = 0x10,
        [Obsolete("Deprecated in favour of \"Fcontrol\"")]
        [NativeName("Name", "TYPEFLAG_FCONTROL")]
        TypeflagFcontrol = 0x20,
        [Obsolete("Deprecated in favour of \"Fdual\"")]
        [NativeName("Name", "TYPEFLAG_FDUAL")]
        TypeflagFdual = 0x40,
        [Obsolete("Deprecated in favour of \"Fnonextensible\"")]
        [NativeName("Name", "TYPEFLAG_FNONEXTENSIBLE")]
        TypeflagFnonextensible = 0x80,
        [Obsolete("Deprecated in favour of \"Foleautomation\"")]
        [NativeName("Name", "TYPEFLAG_FOLEAUTOMATION")]
        TypeflagFoleautomation = 0x100,
        [Obsolete("Deprecated in favour of \"Frestricted\"")]
        [NativeName("Name", "TYPEFLAG_FRESTRICTED")]
        TypeflagFrestricted = 0x200,
        [Obsolete("Deprecated in favour of \"Faggregatable\"")]
        [NativeName("Name", "TYPEFLAG_FAGGREGATABLE")]
        TypeflagFaggregatable = 0x400,
        [Obsolete("Deprecated in favour of \"Freplaceable\"")]
        [NativeName("Name", "TYPEFLAG_FREPLACEABLE")]
        TypeflagFreplaceable = 0x800,
        [Obsolete("Deprecated in favour of \"Fdispatchable\"")]
        [NativeName("Name", "TYPEFLAG_FDISPATCHABLE")]
        TypeflagFdispatchable = 0x1000,
        [Obsolete("Deprecated in favour of \"Freversebind\"")]
        [NativeName("Name", "TYPEFLAG_FREVERSEBIND")]
        TypeflagFreversebind = 0x2000,
        [Obsolete("Deprecated in favour of \"Fproxy\"")]
        [NativeName("Name", "TYPEFLAG_FPROXY")]
        TypeflagFproxy = 0x4000,
        [NativeName("Name", "TYPEFLAG_FAPPOBJECT")]
        Fappobject = 0x1,
        [NativeName("Name", "TYPEFLAG_FCANCREATE")]
        Fcancreate = 0x2,
        [NativeName("Name", "TYPEFLAG_FLICENSED")]
        Flicensed = 0x4,
        [NativeName("Name", "TYPEFLAG_FPREDECLID")]
        Fpredeclid = 0x8,
        [NativeName("Name", "TYPEFLAG_FHIDDEN")]
        Fhidden = 0x10,
        [NativeName("Name", "TYPEFLAG_FCONTROL")]
        Fcontrol = 0x20,
        [NativeName("Name", "TYPEFLAG_FDUAL")]
        Fdual = 0x40,
        [NativeName("Name", "TYPEFLAG_FNONEXTENSIBLE")]
        Fnonextensible = 0x80,
        [NativeName("Name", "TYPEFLAG_FOLEAUTOMATION")]
        Foleautomation = 0x100,
        [NativeName("Name", "TYPEFLAG_FRESTRICTED")]
        Frestricted = 0x200,
        [NativeName("Name", "TYPEFLAG_FAGGREGATABLE")]
        Faggregatable = 0x400,
        [NativeName("Name", "TYPEFLAG_FREPLACEABLE")]
        Freplaceable = 0x800,
        [NativeName("Name", "TYPEFLAG_FDISPATCHABLE")]
        Fdispatchable = 0x1000,
        [NativeName("Name", "TYPEFLAG_FREVERSEBIND")]
        Freversebind = 0x2000,
        [NativeName("Name", "TYPEFLAG_FPROXY")]
        Fproxy = 0x4000,
    }
}
