// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='EXTLOGFONTW.xml' path='doc/member[@name="EXTLOGFONTW"]/*' />
public unsafe partial struct EXTLOGFONTW
{
    /// <include file='EXTLOGFONTW.xml' path='doc/member[@name="EXTLOGFONTW.elfLogFont"]/*' />
    public LOGFONTW elfLogFont;

    /// <include file='EXTLOGFONTW.xml' path='doc/member[@name="EXTLOGFONTW.elfFullName"]/*' />
    [NativeTypeName("WCHAR[64]")]
    public fixed ushort elfFullName[64];

    /// <include file='EXTLOGFONTW.xml' path='doc/member[@name="EXTLOGFONTW.elfStyle"]/*' />
    [NativeTypeName("WCHAR[32]")]
    public fixed ushort elfStyle[32];

    /// <include file='EXTLOGFONTW.xml' path='doc/member[@name="EXTLOGFONTW.elfVersion"]/*' />
    [NativeTypeName("DWORD")]
    public uint elfVersion;

    /// <include file='EXTLOGFONTW.xml' path='doc/member[@name="EXTLOGFONTW.elfStyleSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint elfStyleSize;

    /// <include file='EXTLOGFONTW.xml' path='doc/member[@name="EXTLOGFONTW.elfMatch"]/*' />
    [NativeTypeName("DWORD")]
    public uint elfMatch;

    /// <include file='EXTLOGFONTW.xml' path='doc/member[@name="EXTLOGFONTW.elfReserved"]/*' />
    [NativeTypeName("DWORD")]
    public uint elfReserved;

    /// <include file='EXTLOGFONTW.xml' path='doc/member[@name="EXTLOGFONTW.elfVendorId"]/*' />
    [NativeTypeName("BYTE[4]")]
    public fixed byte elfVendorId[4];

    /// <include file='EXTLOGFONTW.xml' path='doc/member[@name="EXTLOGFONTW.elfCulture"]/*' />
    [NativeTypeName("DWORD")]
    public uint elfCulture;

    /// <include file='EXTLOGFONTW.xml' path='doc/member[@name="EXTLOGFONTW.elfPanose"]/*' />
    public PANOSE elfPanose;
}
