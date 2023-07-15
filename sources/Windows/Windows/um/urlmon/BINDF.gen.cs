// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;

namespace TerraFX.Interop.Windows;
/// <include file='BINDF.xml' path='doc/member[@name="BINDF"]/*'/>
[Flags]
public enum BINDF
{
    /// <include file='BINDF.xml' path='doc/member[@name="BINDF.BINDF_ASYNCHRONOUS"]/*'/>
    BINDF_ASYNCHRONOUS = 0x1,
    /// <include file='BINDF.xml' path='doc/member[@name="BINDF.BINDF_ASYNCSTORAGE"]/*'/>
    BINDF_ASYNCSTORAGE = 0x2,
    /// <include file='BINDF.xml' path='doc/member[@name="BINDF.BINDF_NOPROGRESSIVERENDERING"]/*'/>
    BINDF_NOPROGRESSIVERENDERING = 0x4,
    /// <include file='BINDF.xml' path='doc/member[@name="BINDF.BINDF_OFFLINEOPERATION"]/*'/>
    BINDF_OFFLINEOPERATION = 0x8,
    /// <include file='BINDF.xml' path='doc/member[@name="BINDF.BINDF_GETNEWESTVERSION"]/*'/>
    BINDF_GETNEWESTVERSION = 0x10,
    /// <include file='BINDF.xml' path='doc/member[@name="BINDF.BINDF_NOWRITECACHE"]/*'/>
    BINDF_NOWRITECACHE = 0x20,
    /// <include file='BINDF.xml' path='doc/member[@name="BINDF.BINDF_NEEDFILE"]/*'/>
    BINDF_NEEDFILE = 0x40,
    /// <include file='BINDF.xml' path='doc/member[@name="BINDF.BINDF_PULLDATA"]/*'/>
    BINDF_PULLDATA = 0x80,
    /// <include file='BINDF.xml' path='doc/member[@name="BINDF.BINDF_IGNORESECURITYPROBLEM"]/*'/>
    BINDF_IGNORESECURITYPROBLEM = 0x100,
    /// <include file='BINDF.xml' path='doc/member[@name="BINDF.BINDF_RESYNCHRONIZE"]/*'/>
    BINDF_RESYNCHRONIZE = 0x200,
    /// <include file='BINDF.xml' path='doc/member[@name="BINDF.BINDF_HYPERLINK"]/*'/>
    BINDF_HYPERLINK = 0x400,
    /// <include file='BINDF.xml' path='doc/member[@name="BINDF.BINDF_NO_UI"]/*'/>
    BINDF_NO_UI = 0x800,
    /// <include file='BINDF.xml' path='doc/member[@name="BINDF.BINDF_SILENTOPERATION"]/*'/>
    BINDF_SILENTOPERATION = 0x1000,
    /// <include file='BINDF.xml' path='doc/member[@name="BINDF.BINDF_PRAGMA_NO_CACHE"]/*'/>
    BINDF_PRAGMA_NO_CACHE = 0x2000,
    /// <include file='BINDF.xml' path='doc/member[@name="BINDF.BINDF_GETCLASSOBJECT"]/*'/>
    BINDF_GETCLASSOBJECT = 0x4000,
    /// <include file='BINDF.xml' path='doc/member[@name="BINDF.BINDF_RESERVED_1"]/*'/>
    BINDF_RESERVED_1 = 0x8000,
    /// <include file='BINDF.xml' path='doc/member[@name="BINDF.BINDF_FREE_THREADED"]/*'/>
    BINDF_FREE_THREADED = 0x10000,
    /// <include file='BINDF.xml' path='doc/member[@name="BINDF.BINDF_DIRECT_READ"]/*'/>
    BINDF_DIRECT_READ = 0x20000,
    /// <include file='BINDF.xml' path='doc/member[@name="BINDF.BINDF_FORMS_SUBMIT"]/*'/>
    BINDF_FORMS_SUBMIT = 0x40000,
    /// <include file='BINDF.xml' path='doc/member[@name="BINDF.BINDF_GETFROMCACHE_IF_NET_FAIL"]/*'/>
    BINDF_GETFROMCACHE_IF_NET_FAIL = 0x80000,
    /// <include file='BINDF.xml' path='doc/member[@name="BINDF.BINDF_FROMURLMON"]/*'/>
    BINDF_FROMURLMON = 0x100000,
    /// <include file='BINDF.xml' path='doc/member[@name="BINDF.BINDF_FWD_BACK"]/*'/>
    BINDF_FWD_BACK = 0x200000,
    /// <include file='BINDF.xml' path='doc/member[@name="BINDF.BINDF_PREFERDEFAULTHANDLER"]/*'/>
    BINDF_PREFERDEFAULTHANDLER = 0x400000,
    /// <include file='BINDF.xml' path='doc/member[@name="BINDF.BINDF_ENFORCERESTRICTED"]/*'/>
    BINDF_ENFORCERESTRICTED = 0x800000,
    /// <include file='BINDF.xml' path='doc/member[@name="BINDF.BINDF_RESERVED_2"]/*'/>
    BINDF_RESERVED_2 = unchecked((int)(0x80000000)),
    /// <include file='BINDF.xml' path='doc/member[@name="BINDF.BINDF_RESERVED_3"]/*'/>
    BINDF_RESERVED_3 = 0x1000000,
    /// <include file='BINDF.xml' path='doc/member[@name="BINDF.BINDF_RESERVED_4"]/*'/>
    BINDF_RESERVED_4 = 0x2000000,
    /// <include file='BINDF.xml' path='doc/member[@name="BINDF.BINDF_RESERVED_5"]/*'/>
    BINDF_RESERVED_5 = 0x4000000,
    /// <include file='BINDF.xml' path='doc/member[@name="BINDF.BINDF_RESERVED_6"]/*'/>
    BINDF_RESERVED_6 = 0x8000000,
    /// <include file='BINDF.xml' path='doc/member[@name="BINDF.BINDF_RESERVED_7"]/*'/>
    BINDF_RESERVED_7 = 0x40000000,
    /// <include file='BINDF.xml' path='doc/member[@name="BINDF.BINDF_RESERVED_8"]/*'/>
    BINDF_RESERVED_8 = 0x20000000,
}