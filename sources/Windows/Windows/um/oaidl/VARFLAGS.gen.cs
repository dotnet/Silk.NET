// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/oaidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='VARFLAGS.xml' path='doc/member[@name="VARFLAGS"]/*'/>
public enum VARFLAGS
{
    /// <include file='VARFLAGS.xml' path='doc/member[@name="VARFLAGS.VARFLAG_FREADONLY"]/*'/>
    VARFLAG_FREADONLY = 0x1,
    /// <include file='VARFLAGS.xml' path='doc/member[@name="VARFLAGS.VARFLAG_FSOURCE"]/*'/>
    VARFLAG_FSOURCE = 0x2,
    /// <include file='VARFLAGS.xml' path='doc/member[@name="VARFLAGS.VARFLAG_FBINDABLE"]/*'/>
    VARFLAG_FBINDABLE = 0x4,
    /// <include file='VARFLAGS.xml' path='doc/member[@name="VARFLAGS.VARFLAG_FREQUESTEDIT"]/*'/>
    VARFLAG_FREQUESTEDIT = 0x8,
    /// <include file='VARFLAGS.xml' path='doc/member[@name="VARFLAGS.VARFLAG_FDISPLAYBIND"]/*'/>
    VARFLAG_FDISPLAYBIND = 0x10,
    /// <include file='VARFLAGS.xml' path='doc/member[@name="VARFLAGS.VARFLAG_FDEFAULTBIND"]/*'/>
    VARFLAG_FDEFAULTBIND = 0x20,
    /// <include file='VARFLAGS.xml' path='doc/member[@name="VARFLAGS.VARFLAG_FHIDDEN"]/*'/>
    VARFLAG_FHIDDEN = 0x40,
    /// <include file='VARFLAGS.xml' path='doc/member[@name="VARFLAGS.VARFLAG_FRESTRICTED"]/*'/>
    VARFLAG_FRESTRICTED = 0x80,
    /// <include file='VARFLAGS.xml' path='doc/member[@name="VARFLAGS.VARFLAG_FDEFAULTCOLLELEM"]/*'/>
    VARFLAG_FDEFAULTCOLLELEM = 0x100,
    /// <include file='VARFLAGS.xml' path='doc/member[@name="VARFLAGS.VARFLAG_FUIDEFAULT"]/*'/>
    VARFLAG_FUIDEFAULT = 0x200,
    /// <include file='VARFLAGS.xml' path='doc/member[@name="VARFLAGS.VARFLAG_FNONBROWSABLE"]/*'/>
    VARFLAG_FNONBROWSABLE = 0x400,
    /// <include file='VARFLAGS.xml' path='doc/member[@name="VARFLAGS.VARFLAG_FREPLACEABLE"]/*'/>
    VARFLAG_FREPLACEABLE = 0x800,
    /// <include file='VARFLAGS.xml' path='doc/member[@name="VARFLAGS.VARFLAG_FIMMEDIATEBIND"]/*'/>
    VARFLAG_FIMMEDIATEBIND = 0x1000,
}