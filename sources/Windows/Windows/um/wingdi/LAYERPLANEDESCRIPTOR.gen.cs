// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='LAYERPLANEDESCRIPTOR.xml' path='doc/member[@name="LAYERPLANEDESCRIPTOR"]/*' />
public partial struct LAYERPLANEDESCRIPTOR
{
    /// <include file='LAYERPLANEDESCRIPTOR.xml' path='doc/member[@name="LAYERPLANEDESCRIPTOR.nSize"]/*' />
    [NativeTypeName("WORD")]
    public ushort nSize;

    /// <include file='LAYERPLANEDESCRIPTOR.xml' path='doc/member[@name="LAYERPLANEDESCRIPTOR.nVersion"]/*' />
    [NativeTypeName("WORD")]
    public ushort nVersion;

    /// <include file='LAYERPLANEDESCRIPTOR.xml' path='doc/member[@name="LAYERPLANEDESCRIPTOR.dwFlags"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwFlags;

    /// <include file='LAYERPLANEDESCRIPTOR.xml' path='doc/member[@name="LAYERPLANEDESCRIPTOR.iPixelType"]/*' />
    public byte iPixelType;

    /// <include file='LAYERPLANEDESCRIPTOR.xml' path='doc/member[@name="LAYERPLANEDESCRIPTOR.cColorBits"]/*' />
    public byte cColorBits;

    /// <include file='LAYERPLANEDESCRIPTOR.xml' path='doc/member[@name="LAYERPLANEDESCRIPTOR.cRedBits"]/*' />
    public byte cRedBits;

    /// <include file='LAYERPLANEDESCRIPTOR.xml' path='doc/member[@name="LAYERPLANEDESCRIPTOR.cRedShift"]/*' />
    public byte cRedShift;

    /// <include file='LAYERPLANEDESCRIPTOR.xml' path='doc/member[@name="LAYERPLANEDESCRIPTOR.cGreenBits"]/*' />
    public byte cGreenBits;

    /// <include file='LAYERPLANEDESCRIPTOR.xml' path='doc/member[@name="LAYERPLANEDESCRIPTOR.cGreenShift"]/*' />
    public byte cGreenShift;

    /// <include file='LAYERPLANEDESCRIPTOR.xml' path='doc/member[@name="LAYERPLANEDESCRIPTOR.cBlueBits"]/*' />
    public byte cBlueBits;

    /// <include file='LAYERPLANEDESCRIPTOR.xml' path='doc/member[@name="LAYERPLANEDESCRIPTOR.cBlueShift"]/*' />
    public byte cBlueShift;

    /// <include file='LAYERPLANEDESCRIPTOR.xml' path='doc/member[@name="LAYERPLANEDESCRIPTOR.cAlphaBits"]/*' />
    public byte cAlphaBits;

    /// <include file='LAYERPLANEDESCRIPTOR.xml' path='doc/member[@name="LAYERPLANEDESCRIPTOR.cAlphaShift"]/*' />
    public byte cAlphaShift;

    /// <include file='LAYERPLANEDESCRIPTOR.xml' path='doc/member[@name="LAYERPLANEDESCRIPTOR.cAccumBits"]/*' />
    public byte cAccumBits;

    /// <include file='LAYERPLANEDESCRIPTOR.xml' path='doc/member[@name="LAYERPLANEDESCRIPTOR.cAccumRedBits"]/*' />
    public byte cAccumRedBits;

    /// <include file='LAYERPLANEDESCRIPTOR.xml' path='doc/member[@name="LAYERPLANEDESCRIPTOR.cAccumGreenBits"]/*' />
    public byte cAccumGreenBits;

    /// <include file='LAYERPLANEDESCRIPTOR.xml' path='doc/member[@name="LAYERPLANEDESCRIPTOR.cAccumBlueBits"]/*' />
    public byte cAccumBlueBits;

    /// <include file='LAYERPLANEDESCRIPTOR.xml' path='doc/member[@name="LAYERPLANEDESCRIPTOR.cAccumAlphaBits"]/*' />
    public byte cAccumAlphaBits;

    /// <include file='LAYERPLANEDESCRIPTOR.xml' path='doc/member[@name="LAYERPLANEDESCRIPTOR.cDepthBits"]/*' />
    public byte cDepthBits;

    /// <include file='LAYERPLANEDESCRIPTOR.xml' path='doc/member[@name="LAYERPLANEDESCRIPTOR.cStencilBits"]/*' />
    public byte cStencilBits;

    /// <include file='LAYERPLANEDESCRIPTOR.xml' path='doc/member[@name="LAYERPLANEDESCRIPTOR.cAuxBuffers"]/*' />
    public byte cAuxBuffers;

    /// <include file='LAYERPLANEDESCRIPTOR.xml' path='doc/member[@name="LAYERPLANEDESCRIPTOR.iLayerPlane"]/*' />
    public byte iLayerPlane;

    /// <include file='LAYERPLANEDESCRIPTOR.xml' path='doc/member[@name="LAYERPLANEDESCRIPTOR.bReserved"]/*' />
    public byte bReserved;

    /// <include file='LAYERPLANEDESCRIPTOR.xml' path='doc/member[@name="LAYERPLANEDESCRIPTOR.crTransparent"]/*' />
    public COLORREF crTransparent;
}
