// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace Silk.NET.Windows;

/// <include file='BITMAPFILEHEADER.xml' path='doc/member[@name="BITMAPFILEHEADER"]/*' />
[StructLayout(LayoutKind.Sequential, Pack = 2)]
public partial struct BITMAPFILEHEADER
{
    /// <include file='BITMAPFILEHEADER.xml' path='doc/member[@name="BITMAPFILEHEADER.bfType"]/*' />
    [NativeTypeName("WORD")]
    public ushort bfType;

    /// <include file='BITMAPFILEHEADER.xml' path='doc/member[@name="BITMAPFILEHEADER.bfSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint bfSize;

    /// <include file='BITMAPFILEHEADER.xml' path='doc/member[@name="BITMAPFILEHEADER.bfReserved1"]/*' />
    [NativeTypeName("WORD")]
    public ushort bfReserved1;

    /// <include file='BITMAPFILEHEADER.xml' path='doc/member[@name="BITMAPFILEHEADER.bfReserved2"]/*' />
    [NativeTypeName("WORD")]
    public ushort bfReserved2;

    /// <include file='BITMAPFILEHEADER.xml' path='doc/member[@name="BITMAPFILEHEADER.bfOffBits"]/*' />
    [NativeTypeName("DWORD")]
    public uint bfOffBits;
}
