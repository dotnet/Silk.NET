// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct RID_DEVICE_INFO_HID
{
    [NativeTypeName("DWORD")]
    public uint dwVendorId;

    [NativeTypeName("DWORD")]
    public uint dwProductId;

    [NativeTypeName("DWORD")]
    public uint dwVersionNumber;
    public ushort usUsagePage;
    public ushort usUsage;
}
