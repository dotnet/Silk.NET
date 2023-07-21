// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='LOGCOLORSPACEW.xml' path='doc/member[@name="LOGCOLORSPACEW"]/*' />
public unsafe partial struct LOGCOLORSPACEW
{
    /// <include file='LOGCOLORSPACEW.xml' path='doc/member[@name="LOGCOLORSPACEW.lcsSignature"]/*' />
    [NativeTypeName("DWORD")]
    public uint lcsSignature;

    /// <include file='LOGCOLORSPACEW.xml' path='doc/member[@name="LOGCOLORSPACEW.lcsVersion"]/*' />
    [NativeTypeName("DWORD")]
    public uint lcsVersion;

    /// <include file='LOGCOLORSPACEW.xml' path='doc/member[@name="LOGCOLORSPACEW.lcsSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint lcsSize;

    /// <include file='LOGCOLORSPACEW.xml' path='doc/member[@name="LOGCOLORSPACEW.lcsCSType"]/*' />
    [NativeTypeName("LCSCSTYPE")]
    public int lcsCSType;

    /// <include file='LOGCOLORSPACEW.xml' path='doc/member[@name="LOGCOLORSPACEW.lcsIntent"]/*' />
    [NativeTypeName("LCSGAMUTMATCH")]
    public int lcsIntent;

    /// <include file='LOGCOLORSPACEW.xml' path='doc/member[@name="LOGCOLORSPACEW.lcsEndpoints"]/*' />
    public CIEXYZTRIPLE lcsEndpoints;

    /// <include file='LOGCOLORSPACEW.xml' path='doc/member[@name="LOGCOLORSPACEW.lcsGammaRed"]/*' />
    [NativeTypeName("DWORD")]
    public uint lcsGammaRed;

    /// <include file='LOGCOLORSPACEW.xml' path='doc/member[@name="LOGCOLORSPACEW.lcsGammaGreen"]/*' />
    [NativeTypeName("DWORD")]
    public uint lcsGammaGreen;

    /// <include file='LOGCOLORSPACEW.xml' path='doc/member[@name="LOGCOLORSPACEW.lcsGammaBlue"]/*' />
    [NativeTypeName("DWORD")]
    public uint lcsGammaBlue;

    /// <include file='LOGCOLORSPACEW.xml' path='doc/member[@name="LOGCOLORSPACEW.lcsFilename"]/*' />
    [NativeTypeName("WCHAR[260]")]
    public fixed ushort lcsFilename[260];
}
