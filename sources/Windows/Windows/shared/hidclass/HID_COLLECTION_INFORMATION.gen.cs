// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/hidclass.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='HID_COLLECTION_INFORMATION.xml' path='doc/member[@name="HID_COLLECTION_INFORMATION"]/*' />
public unsafe partial struct HID_COLLECTION_INFORMATION
{
    /// <include file='HID_COLLECTION_INFORMATION.xml' path='doc/member[@name="HID_COLLECTION_INFORMATION.DescriptorSize"]/*' />
    [NativeTypeName("ULONG")]
    public uint DescriptorSize;

    /// <include file='HID_COLLECTION_INFORMATION.xml' path='doc/member[@name="HID_COLLECTION_INFORMATION.Polled"]/*' />
    [NativeTypeName("BOOLEAN")]
    public byte Polled;

    /// <include file='HID_COLLECTION_INFORMATION.xml' path='doc/member[@name="HID_COLLECTION_INFORMATION.Reserved1"]/*' />
    [NativeTypeName("UCHAR[1]")]
    public fixed byte Reserved1[1];

    /// <include file='HID_COLLECTION_INFORMATION.xml' path='doc/member[@name="HID_COLLECTION_INFORMATION.VendorID"]/*' />
    public ushort VendorID;

    /// <include file='HID_COLLECTION_INFORMATION.xml' path='doc/member[@name="HID_COLLECTION_INFORMATION.ProductID"]/*' />
    public ushort ProductID;

    /// <include file='HID_COLLECTION_INFORMATION.xml' path='doc/member[@name="HID_COLLECTION_INFORMATION.VersionNumber"]/*' />
    public ushort VersionNumber;
}
