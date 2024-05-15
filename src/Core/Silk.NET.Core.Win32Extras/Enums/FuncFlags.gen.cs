// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Core.Win32Extras
{
    [Flags]
    [NativeName("Name", "tagFUNCFLAGS")]
    public enum FuncFlags : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"Frestricted\"")]
        [NativeName("Name", "FUNCFLAG_FRESTRICTED")]
        FuncflagFrestricted = 0x1,
        [Obsolete("Deprecated in favour of \"Fsource\"")]
        [NativeName("Name", "FUNCFLAG_FSOURCE")]
        FuncflagFsource = 0x2,
        [Obsolete("Deprecated in favour of \"Fbindable\"")]
        [NativeName("Name", "FUNCFLAG_FBINDABLE")]
        FuncflagFbindable = 0x4,
        [Obsolete("Deprecated in favour of \"Frequestedit\"")]
        [NativeName("Name", "FUNCFLAG_FREQUESTEDIT")]
        FuncflagFrequestedit = 0x8,
        [Obsolete("Deprecated in favour of \"Fdisplaybind\"")]
        [NativeName("Name", "FUNCFLAG_FDISPLAYBIND")]
        FuncflagFdisplaybind = 0x10,
        [Obsolete("Deprecated in favour of \"Fdefaultbind\"")]
        [NativeName("Name", "FUNCFLAG_FDEFAULTBIND")]
        FuncflagFdefaultbind = 0x20,
        [Obsolete("Deprecated in favour of \"Fhidden\"")]
        [NativeName("Name", "FUNCFLAG_FHIDDEN")]
        FuncflagFhidden = 0x40,
        [Obsolete("Deprecated in favour of \"Fusesgetlasterror\"")]
        [NativeName("Name", "FUNCFLAG_FUSESGETLASTERROR")]
        FuncflagFusesgetlasterror = 0x80,
        [Obsolete("Deprecated in favour of \"Fdefaultcollelem\"")]
        [NativeName("Name", "FUNCFLAG_FDEFAULTCOLLELEM")]
        FuncflagFdefaultcollelem = 0x100,
        [Obsolete("Deprecated in favour of \"Fuidefault\"")]
        [NativeName("Name", "FUNCFLAG_FUIDEFAULT")]
        FuncflagFuidefault = 0x200,
        [Obsolete("Deprecated in favour of \"Fnonbrowsable\"")]
        [NativeName("Name", "FUNCFLAG_FNONBROWSABLE")]
        FuncflagFnonbrowsable = 0x400,
        [Obsolete("Deprecated in favour of \"Freplaceable\"")]
        [NativeName("Name", "FUNCFLAG_FREPLACEABLE")]
        FuncflagFreplaceable = 0x800,
        [Obsolete("Deprecated in favour of \"Fimmediatebind\"")]
        [NativeName("Name", "FUNCFLAG_FIMMEDIATEBIND")]
        FuncflagFimmediatebind = 0x1000,
        [NativeName("Name", "FUNCFLAG_FRESTRICTED")]
        Frestricted = 0x1,
        [NativeName("Name", "FUNCFLAG_FSOURCE")]
        Fsource = 0x2,
        [NativeName("Name", "FUNCFLAG_FBINDABLE")]
        Fbindable = 0x4,
        [NativeName("Name", "FUNCFLAG_FREQUESTEDIT")]
        Frequestedit = 0x8,
        [NativeName("Name", "FUNCFLAG_FDISPLAYBIND")]
        Fdisplaybind = 0x10,
        [NativeName("Name", "FUNCFLAG_FDEFAULTBIND")]
        Fdefaultbind = 0x20,
        [NativeName("Name", "FUNCFLAG_FHIDDEN")]
        Fhidden = 0x40,
        [NativeName("Name", "FUNCFLAG_FUSESGETLASTERROR")]
        Fusesgetlasterror = 0x80,
        [NativeName("Name", "FUNCFLAG_FDEFAULTCOLLELEM")]
        Fdefaultcollelem = 0x100,
        [NativeName("Name", "FUNCFLAG_FUIDEFAULT")]
        Fuidefault = 0x200,
        [NativeName("Name", "FUNCFLAG_FNONBROWSABLE")]
        Fnonbrowsable = 0x400,
        [NativeName("Name", "FUNCFLAG_FREPLACEABLE")]
        Freplaceable = 0x800,
        [NativeName("Name", "FUNCFLAG_FIMMEDIATEBIND")]
        Fimmediatebind = 0x1000,
    }
}
