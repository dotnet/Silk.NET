// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Core.Win32Extras
{
    [Flags]
    [NativeName("Name", "tagVARFLAGS")]
    public enum VarFlags : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"Freadonly\"")]
        [NativeName("Name", "VARFLAG_FREADONLY")]
        VarflagFreadonly = 0x1,
        [Obsolete("Deprecated in favour of \"Fsource\"")]
        [NativeName("Name", "VARFLAG_FSOURCE")]
        VarflagFsource = 0x2,
        [Obsolete("Deprecated in favour of \"Fbindable\"")]
        [NativeName("Name", "VARFLAG_FBINDABLE")]
        VarflagFbindable = 0x4,
        [Obsolete("Deprecated in favour of \"Frequestedit\"")]
        [NativeName("Name", "VARFLAG_FREQUESTEDIT")]
        VarflagFrequestedit = 0x8,
        [Obsolete("Deprecated in favour of \"Fdisplaybind\"")]
        [NativeName("Name", "VARFLAG_FDISPLAYBIND")]
        VarflagFdisplaybind = 0x10,
        [Obsolete("Deprecated in favour of \"Fdefaultbind\"")]
        [NativeName("Name", "VARFLAG_FDEFAULTBIND")]
        VarflagFdefaultbind = 0x20,
        [Obsolete("Deprecated in favour of \"Fhidden\"")]
        [NativeName("Name", "VARFLAG_FHIDDEN")]
        VarflagFhidden = 0x40,
        [Obsolete("Deprecated in favour of \"Frestricted\"")]
        [NativeName("Name", "VARFLAG_FRESTRICTED")]
        VarflagFrestricted = 0x80,
        [Obsolete("Deprecated in favour of \"Fdefaultcollelem\"")]
        [NativeName("Name", "VARFLAG_FDEFAULTCOLLELEM")]
        VarflagFdefaultcollelem = 0x100,
        [Obsolete("Deprecated in favour of \"Fuidefault\"")]
        [NativeName("Name", "VARFLAG_FUIDEFAULT")]
        VarflagFuidefault = 0x200,
        [Obsolete("Deprecated in favour of \"Fnonbrowsable\"")]
        [NativeName("Name", "VARFLAG_FNONBROWSABLE")]
        VarflagFnonbrowsable = 0x400,
        [Obsolete("Deprecated in favour of \"Freplaceable\"")]
        [NativeName("Name", "VARFLAG_FREPLACEABLE")]
        VarflagFreplaceable = 0x800,
        [Obsolete("Deprecated in favour of \"Fimmediatebind\"")]
        [NativeName("Name", "VARFLAG_FIMMEDIATEBIND")]
        VarflagFimmediatebind = 0x1000,
        [NativeName("Name", "VARFLAG_FREADONLY")]
        Freadonly = 0x1,
        [NativeName("Name", "VARFLAG_FSOURCE")]
        Fsource = 0x2,
        [NativeName("Name", "VARFLAG_FBINDABLE")]
        Fbindable = 0x4,
        [NativeName("Name", "VARFLAG_FREQUESTEDIT")]
        Frequestedit = 0x8,
        [NativeName("Name", "VARFLAG_FDISPLAYBIND")]
        Fdisplaybind = 0x10,
        [NativeName("Name", "VARFLAG_FDEFAULTBIND")]
        Fdefaultbind = 0x20,
        [NativeName("Name", "VARFLAG_FHIDDEN")]
        Fhidden = 0x40,
        [NativeName("Name", "VARFLAG_FRESTRICTED")]
        Frestricted = 0x80,
        [NativeName("Name", "VARFLAG_FDEFAULTCOLLELEM")]
        Fdefaultcollelem = 0x100,
        [NativeName("Name", "VARFLAG_FUIDEFAULT")]
        Fuidefault = 0x200,
        [NativeName("Name", "VARFLAG_FNONBROWSABLE")]
        Fnonbrowsable = 0x400,
        [NativeName("Name", "VARFLAG_FREPLACEABLE")]
        Freplaceable = 0x800,
        [NativeName("Name", "VARFLAG_FIMMEDIATEBIND")]
        Fimmediatebind = 0x1000,
    }
}
