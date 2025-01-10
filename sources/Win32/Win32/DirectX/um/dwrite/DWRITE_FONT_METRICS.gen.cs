// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dwrite.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public partial struct DWRITE_FONT_METRICS
{
    [NativeTypeName("UINT16")]
    public ushort designUnitsPerEm;

    [NativeTypeName("UINT16")]
    public ushort ascent;

    [NativeTypeName("UINT16")]
    public ushort descent;

    [NativeTypeName("INT16")]
    public short lineGap;

    [NativeTypeName("UINT16")]
    public ushort capHeight;

    [NativeTypeName("UINT16")]
    public ushort xHeight;

    [NativeTypeName("INT16")]
    public short underlinePosition;

    [NativeTypeName("UINT16")]
    public ushort underlineThickness;

    [NativeTypeName("INT16")]
    public short strikethroughPosition;

    [NativeTypeName("UINT16")]
    public ushort strikethroughThickness;
}
