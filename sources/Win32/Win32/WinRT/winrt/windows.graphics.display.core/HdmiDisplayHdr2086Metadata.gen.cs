// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.graphics.display.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public partial struct HdmiDisplayHdr2086Metadata
{
    [NativeTypeName("UINT16")]
    public ushort RedPrimaryX;

    [NativeTypeName("UINT16")]
    public ushort RedPrimaryY;

    [NativeTypeName("UINT16")]
    public ushort GreenPrimaryX;

    [NativeTypeName("UINT16")]
    public ushort GreenPrimaryY;

    [NativeTypeName("UINT16")]
    public ushort BluePrimaryX;

    [NativeTypeName("UINT16")]
    public ushort BluePrimaryY;

    [NativeTypeName("UINT16")]
    public ushort WhitePointX;

    [NativeTypeName("UINT16")]
    public ushort WhitePointY;

    [NativeTypeName("UINT16")]
    public ushort MaxMasteringLuminance;

    [NativeTypeName("UINT16")]
    public ushort MinMasteringLuminance;

    [NativeTypeName("UINT16")]
    public ushort MaxContentLightLevel;

    [NativeTypeName("UINT16")]
    public ushort MaxFrameAverageLightLevel;
}
