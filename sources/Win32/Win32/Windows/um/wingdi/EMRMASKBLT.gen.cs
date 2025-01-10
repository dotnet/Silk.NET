// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct EMRMASKBLT
{
    public EMR emr;
    public RECTL rclBounds;

    [NativeTypeName("LONG")]
    public int xDest;

    [NativeTypeName("LONG")]
    public int yDest;

    [NativeTypeName("LONG")]
    public int cxDest;

    [NativeTypeName("LONG")]
    public int cyDest;

    [NativeTypeName("DWORD")]
    public uint dwRop;

    [NativeTypeName("LONG")]
    public int xSrc;

    [NativeTypeName("LONG")]
    public int ySrc;
    public XFORM xformSrc;
    public COLORREF crBkColorSrc;

    [NativeTypeName("DWORD")]
    public uint iUsageSrc;

    [NativeTypeName("DWORD")]
    public uint offBmiSrc;

    [NativeTypeName("DWORD")]
    public uint cbBmiSrc;

    [NativeTypeName("DWORD")]
    public uint offBitsSrc;

    [NativeTypeName("DWORD")]
    public uint cbBitsSrc;

    [NativeTypeName("LONG")]
    public int xMask;

    [NativeTypeName("LONG")]
    public int yMask;

    [NativeTypeName("DWORD")]
    public uint iUsageMask;

    [NativeTypeName("DWORD")]
    public uint offBmiMask;

    [NativeTypeName("DWORD")]
    public uint cbBmiMask;

    [NativeTypeName("DWORD")]
    public uint offBitsMask;

    [NativeTypeName("DWORD")]
    public uint cbBitsMask;
}
