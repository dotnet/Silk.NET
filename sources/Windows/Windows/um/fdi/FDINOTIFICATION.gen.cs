// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/fdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='FDINOTIFICATION.xml' path='doc/member[@name="FDINOTIFICATION"]/*' />
public unsafe partial struct FDINOTIFICATION
{
    /// <include file='FDINOTIFICATION.xml' path='doc/member[@name="FDINOTIFICATION.cb"]/*' />
    [NativeTypeName("long")]
    public int cb;

    /// <include file='FDINOTIFICATION.xml' path='doc/member[@name="FDINOTIFICATION.psz1"]/*' />
    [NativeTypeName("char *")]
    public sbyte* psz1;

    /// <include file='FDINOTIFICATION.xml' path='doc/member[@name="FDINOTIFICATION.psz2"]/*' />
    [NativeTypeName("char *")]
    public sbyte* psz2;

    /// <include file='FDINOTIFICATION.xml' path='doc/member[@name="FDINOTIFICATION.psz3"]/*' />
    [NativeTypeName("char *")]
    public sbyte* psz3;

    /// <include file='FDINOTIFICATION.xml' path='doc/member[@name="FDINOTIFICATION.pv"]/*' />
    public void* pv;

    /// <include file='FDINOTIFICATION.xml' path='doc/member[@name="FDINOTIFICATION.hf"]/*' />
    [NativeTypeName("INT_PTR")]
    public nint hf;

    /// <include file='FDINOTIFICATION.xml' path='doc/member[@name="FDINOTIFICATION.date"]/*' />
    public ushort date;

    /// <include file='FDINOTIFICATION.xml' path='doc/member[@name="FDINOTIFICATION.time"]/*' />
    public ushort time;

    /// <include file='FDINOTIFICATION.xml' path='doc/member[@name="FDINOTIFICATION.attribs"]/*' />
    public ushort attribs;

    /// <include file='FDINOTIFICATION.xml' path='doc/member[@name="FDINOTIFICATION.setID"]/*' />
    public ushort setID;

    /// <include file='FDINOTIFICATION.xml' path='doc/member[@name="FDINOTIFICATION.iCabinet"]/*' />
    public ushort iCabinet;

    /// <include file='FDINOTIFICATION.xml' path='doc/member[@name="FDINOTIFICATION.iFolder"]/*' />
    public ushort iFolder;

    /// <include file='FDINOTIFICATION.xml' path='doc/member[@name="FDINOTIFICATION.fdie"]/*' />
    public FDIERROR fdie;
}
