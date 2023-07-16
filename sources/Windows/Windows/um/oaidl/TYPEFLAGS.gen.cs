// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/oaidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='TYPEFLAGS.xml' path='doc/member[@name="TYPEFLAGS"]/*'/>
public enum TYPEFLAGS
{
    /// <include file='TYPEFLAGS.xml' path='doc/member[@name="TYPEFLAGS.TYPEFLAG_FAPPOBJECT"]/*'/>
    TYPEFLAG_FAPPOBJECT = 0x1,
    /// <include file='TYPEFLAGS.xml' path='doc/member[@name="TYPEFLAGS.TYPEFLAG_FCANCREATE"]/*'/>
    TYPEFLAG_FCANCREATE = 0x2,
    /// <include file='TYPEFLAGS.xml' path='doc/member[@name="TYPEFLAGS.TYPEFLAG_FLICENSED"]/*'/>
    TYPEFLAG_FLICENSED = 0x4,
    /// <include file='TYPEFLAGS.xml' path='doc/member[@name="TYPEFLAGS.TYPEFLAG_FPREDECLID"]/*'/>
    TYPEFLAG_FPREDECLID = 0x8,
    /// <include file='TYPEFLAGS.xml' path='doc/member[@name="TYPEFLAGS.TYPEFLAG_FHIDDEN"]/*'/>
    TYPEFLAG_FHIDDEN = 0x10,
    /// <include file='TYPEFLAGS.xml' path='doc/member[@name="TYPEFLAGS.TYPEFLAG_FCONTROL"]/*'/>
    TYPEFLAG_FCONTROL = 0x20,
    /// <include file='TYPEFLAGS.xml' path='doc/member[@name="TYPEFLAGS.TYPEFLAG_FDUAL"]/*'/>
    TYPEFLAG_FDUAL = 0x40,
    /// <include file='TYPEFLAGS.xml' path='doc/member[@name="TYPEFLAGS.TYPEFLAG_FNONEXTENSIBLE"]/*'/>
    TYPEFLAG_FNONEXTENSIBLE = 0x80,
    /// <include file='TYPEFLAGS.xml' path='doc/member[@name="TYPEFLAGS.TYPEFLAG_FOLEAUTOMATION"]/*'/>
    TYPEFLAG_FOLEAUTOMATION = 0x100,
    /// <include file='TYPEFLAGS.xml' path='doc/member[@name="TYPEFLAGS.TYPEFLAG_FRESTRICTED"]/*'/>
    TYPEFLAG_FRESTRICTED = 0x200,
    /// <include file='TYPEFLAGS.xml' path='doc/member[@name="TYPEFLAGS.TYPEFLAG_FAGGREGATABLE"]/*'/>
    TYPEFLAG_FAGGREGATABLE = 0x400,
    /// <include file='TYPEFLAGS.xml' path='doc/member[@name="TYPEFLAGS.TYPEFLAG_FREPLACEABLE"]/*'/>
    TYPEFLAG_FREPLACEABLE = 0x800,
    /// <include file='TYPEFLAGS.xml' path='doc/member[@name="TYPEFLAGS.TYPEFLAG_FDISPATCHABLE"]/*'/>
    TYPEFLAG_FDISPATCHABLE = 0x1000,
    /// <include file='TYPEFLAGS.xml' path='doc/member[@name="TYPEFLAGS.TYPEFLAG_FREVERSEBIND"]/*'/>
    TYPEFLAG_FREVERSEBIND = 0x2000,
    /// <include file='TYPEFLAGS.xml' path='doc/member[@name="TYPEFLAGS.TYPEFLAG_FPROXY"]/*'/>
    TYPEFLAG_FPROXY = 0x4000,
}