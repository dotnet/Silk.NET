// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct CHANGER_PRODUCT_DATA
{
    [NativeTypeName("BYTE[8]")]
    public _VendorId_e__FixedBuffer VendorId;

    [NativeTypeName("BYTE[16]")]
    public _ProductId_e__FixedBuffer ProductId;

    [NativeTypeName("BYTE[4]")]
    public _Revision_e__FixedBuffer Revision;

    [NativeTypeName("BYTE[32]")]
    public _SerialNumber_e__FixedBuffer SerialNumber;
    public byte DeviceType;

    [InlineArray(8)]
    public partial struct _VendorId_e__FixedBuffer
    {
        public byte e0;
    }

    [InlineArray(16)]
    public partial struct _ProductId_e__FixedBuffer
    {
        public byte e0;
    }

    [InlineArray(4)]
    public partial struct _Revision_e__FixedBuffer
    {
        public byte e0;
    }

    [InlineArray(32)]
    public partial struct _SerialNumber_e__FixedBuffer
    {
        public byte e0;
    }
}
