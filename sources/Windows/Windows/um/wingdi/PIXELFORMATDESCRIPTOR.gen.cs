// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='PIXELFORMATDESCRIPTOR.xml' path='doc/member[@name="PIXELFORMATDESCRIPTOR"]/*' />
public partial struct PIXELFORMATDESCRIPTOR
{
    /// <include file='PIXELFORMATDESCRIPTOR.xml' path='doc/member[@name="PIXELFORMATDESCRIPTOR.nSize"]/*' />
    [NativeTypeName("WORD")]
    public ushort nSize;

    /// <include file='PIXELFORMATDESCRIPTOR.xml' path='doc/member[@name="PIXELFORMATDESCRIPTOR.nVersion"]/*' />
    [NativeTypeName("WORD")]
    public ushort nVersion;

    /// <include file='PIXELFORMATDESCRIPTOR.xml' path='doc/member[@name="PIXELFORMATDESCRIPTOR.dwFlags"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwFlags;

    /// <include file='PIXELFORMATDESCRIPTOR.xml' path='doc/member[@name="PIXELFORMATDESCRIPTOR.iPixelType"]/*' />
    public byte iPixelType;

    /// <include file='PIXELFORMATDESCRIPTOR.xml' path='doc/member[@name="PIXELFORMATDESCRIPTOR.cColorBits"]/*' />
    public byte cColorBits;

    /// <include file='PIXELFORMATDESCRIPTOR.xml' path='doc/member[@name="PIXELFORMATDESCRIPTOR.cRedBits"]/*' />
    public byte cRedBits;

    /// <include file='PIXELFORMATDESCRIPTOR.xml' path='doc/member[@name="PIXELFORMATDESCRIPTOR.cRedShift"]/*' />
    public byte cRedShift;

    /// <include file='PIXELFORMATDESCRIPTOR.xml' path='doc/member[@name="PIXELFORMATDESCRIPTOR.cGreenBits"]/*' />
    public byte cGreenBits;

    /// <include file='PIXELFORMATDESCRIPTOR.xml' path='doc/member[@name="PIXELFORMATDESCRIPTOR.cGreenShift"]/*' />
    public byte cGreenShift;

    /// <include file='PIXELFORMATDESCRIPTOR.xml' path='doc/member[@name="PIXELFORMATDESCRIPTOR.cBlueBits"]/*' />
    public byte cBlueBits;

    /// <include file='PIXELFORMATDESCRIPTOR.xml' path='doc/member[@name="PIXELFORMATDESCRIPTOR.cBlueShift"]/*' />
    public byte cBlueShift;

    /// <include file='PIXELFORMATDESCRIPTOR.xml' path='doc/member[@name="PIXELFORMATDESCRIPTOR.cAlphaBits"]/*' />
    public byte cAlphaBits;

    /// <include file='PIXELFORMATDESCRIPTOR.xml' path='doc/member[@name="PIXELFORMATDESCRIPTOR.cAlphaShift"]/*' />
    public byte cAlphaShift;

    /// <include file='PIXELFORMATDESCRIPTOR.xml' path='doc/member[@name="PIXELFORMATDESCRIPTOR.cAccumBits"]/*' />
    public byte cAccumBits;

    /// <include file='PIXELFORMATDESCRIPTOR.xml' path='doc/member[@name="PIXELFORMATDESCRIPTOR.cAccumRedBits"]/*' />
    public byte cAccumRedBits;

    /// <include file='PIXELFORMATDESCRIPTOR.xml' path='doc/member[@name="PIXELFORMATDESCRIPTOR.cAccumGreenBits"]/*' />
    public byte cAccumGreenBits;

    /// <include file='PIXELFORMATDESCRIPTOR.xml' path='doc/member[@name="PIXELFORMATDESCRIPTOR.cAccumBlueBits"]/*' />
    public byte cAccumBlueBits;

    /// <include file='PIXELFORMATDESCRIPTOR.xml' path='doc/member[@name="PIXELFORMATDESCRIPTOR.cAccumAlphaBits"]/*' />
    public byte cAccumAlphaBits;

    /// <include file='PIXELFORMATDESCRIPTOR.xml' path='doc/member[@name="PIXELFORMATDESCRIPTOR.cDepthBits"]/*' />
    public byte cDepthBits;

    /// <include file='PIXELFORMATDESCRIPTOR.xml' path='doc/member[@name="PIXELFORMATDESCRIPTOR.cStencilBits"]/*' />
    public byte cStencilBits;

    /// <include file='PIXELFORMATDESCRIPTOR.xml' path='doc/member[@name="PIXELFORMATDESCRIPTOR.cAuxBuffers"]/*' />
    public byte cAuxBuffers;

    /// <include file='PIXELFORMATDESCRIPTOR.xml' path='doc/member[@name="PIXELFORMATDESCRIPTOR.iLayerType"]/*' />
    public byte iLayerType;

    /// <include file='PIXELFORMATDESCRIPTOR.xml' path='doc/member[@name="PIXELFORMATDESCRIPTOR.bReserved"]/*' />
    public byte bReserved;

    /// <include file='PIXELFORMATDESCRIPTOR.xml' path='doc/member[@name="PIXELFORMATDESCRIPTOR.dwLayerMask"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwLayerMask;

    /// <include file='PIXELFORMATDESCRIPTOR.xml' path='doc/member[@name="PIXELFORMATDESCRIPTOR.dwVisibleMask"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwVisibleMask;

    /// <include file='PIXELFORMATDESCRIPTOR.xml' path='doc/member[@name="PIXELFORMATDESCRIPTOR.dwDamageMask"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwDamageMask;
}
