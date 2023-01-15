// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.WGL;

public struct PixelFormatDescriptor
{
    public ushort NSize;
    public ushort NVersion;
    public uint DwFlags;
    public byte IPixelType;
    public byte CColorBits;
    public byte CRedBits;
    public byte CRedShift;
    public byte CGreenBits;
    public byte CGreenShift;
    public byte CBlueBits;
    public byte CBlueShift;
    public byte CAlphaBits;
    public byte CAlphaShift;
    public byte CAccumBits;
    public byte CAccumRedBits;
    public byte CAccumGreenBits;
    public byte CAccumBlueBits;
    public byte CAccumAlphaBits;
    public byte CDepthBits;
    public byte CStencilBits;
    public byte CAuxBuffers;
    public byte ILayerType;
    public byte BReserved;
    public uint DwLayerMask;
    public uint DwVisibleMask;
    public uint DwDamageMask;
}
