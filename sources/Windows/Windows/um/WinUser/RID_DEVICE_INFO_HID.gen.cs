// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='RID_DEVICE_INFO_HID.xml' path='doc/member[@name="RID_DEVICE_INFO_HID"]/*' />
public partial struct RID_DEVICE_INFO_HID
{
    /// <include file='RID_DEVICE_INFO_HID.xml' path='doc/member[@name="RID_DEVICE_INFO_HID.dwVendorId"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwVendorId;

    /// <include file='RID_DEVICE_INFO_HID.xml' path='doc/member[@name="RID_DEVICE_INFO_HID.dwProductId"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwProductId;

    /// <include file='RID_DEVICE_INFO_HID.xml' path='doc/member[@name="RID_DEVICE_INFO_HID.dwVersionNumber"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwVersionNumber;

    /// <include file='RID_DEVICE_INFO_HID.xml' path='doc/member[@name="RID_DEVICE_INFO_HID.usUsagePage"]/*' />
    public ushort usUsagePage;

    /// <include file='RID_DEVICE_INFO_HID.xml' path='doc/member[@name="RID_DEVICE_INFO_HID.usUsage"]/*' />
    public ushort usUsage;
}
