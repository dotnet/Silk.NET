// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/oaidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='FUNCFLAGS.xml' path='doc/member[@name="FUNCFLAGS"]/*' />
public enum FUNCFLAGS
{
    /// <include file='FUNCFLAGS.xml' path='doc/member[@name="FUNCFLAGS.FUNCFLAG_FRESTRICTED"]/*' />
    FUNCFLAG_FRESTRICTED = 0x1,

    /// <include file='FUNCFLAGS.xml' path='doc/member[@name="FUNCFLAGS.FUNCFLAG_FSOURCE"]/*' />
    FUNCFLAG_FSOURCE = 0x2,

    /// <include file='FUNCFLAGS.xml' path='doc/member[@name="FUNCFLAGS.FUNCFLAG_FBINDABLE"]/*' />
    FUNCFLAG_FBINDABLE = 0x4,

    /// <include file='FUNCFLAGS.xml' path='doc/member[@name="FUNCFLAGS.FUNCFLAG_FREQUESTEDIT"]/*' />
    FUNCFLAG_FREQUESTEDIT = 0x8,

    /// <include file='FUNCFLAGS.xml' path='doc/member[@name="FUNCFLAGS.FUNCFLAG_FDISPLAYBIND"]/*' />
    FUNCFLAG_FDISPLAYBIND = 0x10,

    /// <include file='FUNCFLAGS.xml' path='doc/member[@name="FUNCFLAGS.FUNCFLAG_FDEFAULTBIND"]/*' />
    FUNCFLAG_FDEFAULTBIND = 0x20,

    /// <include file='FUNCFLAGS.xml' path='doc/member[@name="FUNCFLAGS.FUNCFLAG_FHIDDEN"]/*' />
    FUNCFLAG_FHIDDEN = 0x40,

    /// <include file='FUNCFLAGS.xml' path='doc/member[@name="FUNCFLAGS.FUNCFLAG_FUSESGETLASTERROR"]/*' />
    FUNCFLAG_FUSESGETLASTERROR = 0x80,

    /// <include file='FUNCFLAGS.xml' path='doc/member[@name="FUNCFLAGS.FUNCFLAG_FDEFAULTCOLLELEM"]/*' />
    FUNCFLAG_FDEFAULTCOLLELEM = 0x100,

    /// <include file='FUNCFLAGS.xml' path='doc/member[@name="FUNCFLAGS.FUNCFLAG_FUIDEFAULT"]/*' />
    FUNCFLAG_FUIDEFAULT = 0x200,

    /// <include file='FUNCFLAGS.xml' path='doc/member[@name="FUNCFLAGS.FUNCFLAG_FNONBROWSABLE"]/*' />
    FUNCFLAG_FNONBROWSABLE = 0x400,

    /// <include file='FUNCFLAGS.xml' path='doc/member[@name="FUNCFLAGS.FUNCFLAG_FREPLACEABLE"]/*' />
    FUNCFLAG_FREPLACEABLE = 0x800,

    /// <include file='FUNCFLAGS.xml' path='doc/member[@name="FUNCFLAGS.FUNCFLAG_FIMMEDIATEBIND"]/*' />
    FUNCFLAG_FIMMEDIATEBIND = 0x1000,
}
