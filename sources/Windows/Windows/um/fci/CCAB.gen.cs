// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/fci.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='CCAB.xml' path='doc/member[@name="CCAB"]/*' />
public unsafe partial struct CCAB
{
    /// <include file='CCAB.xml' path='doc/member[@name="CCAB.cb"]/*' />
    [NativeTypeName("ULONG")]
    public uint cb;

    /// <include file='CCAB.xml' path='doc/member[@name="CCAB.cbFolderThresh"]/*' />
    [NativeTypeName("ULONG")]
    public uint cbFolderThresh;

    /// <include file='CCAB.xml' path='doc/member[@name="CCAB.cbReserveCFHeader"]/*' />
    public uint cbReserveCFHeader;

    /// <include file='CCAB.xml' path='doc/member[@name="CCAB.cbReserveCFFolder"]/*' />
    public uint cbReserveCFFolder;

    /// <include file='CCAB.xml' path='doc/member[@name="CCAB.cbReserveCFData"]/*' />
    public uint cbReserveCFData;

    /// <include file='CCAB.xml' path='doc/member[@name="CCAB.iCab"]/*' />
    public int iCab;

    /// <include file='CCAB.xml' path='doc/member[@name="CCAB.iDisk"]/*' />
    public int iDisk;

    /// <include file='CCAB.xml' path='doc/member[@name="CCAB.fFailOnIncompressible"]/*' />
    public int fFailOnIncompressible;

    /// <include file='CCAB.xml' path='doc/member[@name="CCAB.setID"]/*' />
    public ushort setID;

    /// <include file='CCAB.xml' path='doc/member[@name="CCAB.szDisk"]/*' />
    [NativeTypeName("char[256]")]
    public fixed sbyte szDisk[256];

    /// <include file='CCAB.xml' path='doc/member[@name="CCAB.szCab"]/*' />
    [NativeTypeName("char[256]")]
    public fixed sbyte szCab[256];

    /// <include file='CCAB.xml' path='doc/member[@name="CCAB.szCabPath"]/*' />
    [NativeTypeName("char[256]")]
    public fixed sbyte szCabPath[256];
}
