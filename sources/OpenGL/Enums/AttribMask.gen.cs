// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
[Transformed]
public enum AttribMask
{
    DepthBufferBit = 0x00000100,
    StencilBufferBit = 0x00000400,
    ColorBufferBit = 0x00004000,
    CurrentBit = 0x00000001,
    PointBit = 0x00000002,
    LineBit = 0x00000004,
    PolygonBit = 0x00000008,
    PolygonStippleBit = 0x00000010,
    PixelModeBit = 0x00000020,
    LightingBit = 0x00000040,
    FogBit = 0x00000080,
    AccumBufferBit = 0x00000200,
    ViewportBit = 0x00000800,
    TransformBit = 0x00001000,
    EnableBit = 0x00002000,
    HintBit = 0x00008000,
    EvalBit = 0x00010000,
    ListBit = 0x00020000,
    TextureBit = 0x00040000,
    ScissorBit = 0x00080000,
    AllAttribBits = 0xFFFFFFFF,
    MultisampleBit = 0x20000000,
    MultisampleBitARB = 0x20000000,
    MultisampleBit3DFX = 0x20000000,
    MultisampleBitEXT = 0x20000000
}
