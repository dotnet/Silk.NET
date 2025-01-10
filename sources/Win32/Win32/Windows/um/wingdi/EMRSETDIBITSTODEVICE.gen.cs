// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct EMRSETDIBITSTODEVICE
{
    public EMR emr;
    public RECTL rclBounds;

    [NativeTypeName("LONG")]
    public int xDest;

    [NativeTypeName("LONG")]
    public int yDest;

    [NativeTypeName("LONG")]
    public int xSrc;

    [NativeTypeName("LONG")]
    public int ySrc;

    [NativeTypeName("LONG")]
    public int cxSrc;

    [NativeTypeName("LONG")]
    public int cySrc;

    [NativeTypeName("DWORD")]
    public uint offBmiSrc;

    [NativeTypeName("DWORD")]
    public uint cbBmiSrc;

    [NativeTypeName("DWORD")]
    public uint offBitsSrc;

    [NativeTypeName("DWORD")]
    public uint cbBitsSrc;

    [NativeTypeName("DWORD")]
    public uint iUsageSrc;

    [NativeTypeName("DWORD")]
    public uint iStartScan;

    [NativeTypeName("DWORD")]
    public uint cScans;
}
