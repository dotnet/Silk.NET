// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='RGNDATAHEADER.xml' path='doc/member[@name="RGNDATAHEADER"]/*' />
public partial struct RGNDATAHEADER
{
    /// <include file='RGNDATAHEADER.xml' path='doc/member[@name="RGNDATAHEADER.dwSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwSize;

    /// <include file='RGNDATAHEADER.xml' path='doc/member[@name="RGNDATAHEADER.iType"]/*' />
    [NativeTypeName("DWORD")]
    public uint iType;

    /// <include file='RGNDATAHEADER.xml' path='doc/member[@name="RGNDATAHEADER.nCount"]/*' />
    [NativeTypeName("DWORD")]
    public uint nCount;

    /// <include file='RGNDATAHEADER.xml' path='doc/member[@name="RGNDATAHEADER.nRgnSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint nRgnSize;

    /// <include file='RGNDATAHEADER.xml' path='doc/member[@name="RGNDATAHEADER.rcBound"]/*' />
    public RECT rcBound;
}
