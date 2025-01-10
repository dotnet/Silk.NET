// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct CHANGER_ELEMENT_STATUS_EX
{
    public CHANGER_ELEMENT Element;
    public CHANGER_ELEMENT SrcElementAddress;

    [NativeTypeName("DWORD")]
    public uint Flags;

    [NativeTypeName("DWORD")]
    public uint ExceptionCode;
    public byte TargetId;
    public byte Lun;

    [NativeTypeName("WORD")]
    public ushort Reserved;

    [NativeTypeName("BYTE[36]")]
    public _PrimaryVolumeID_e__FixedBuffer PrimaryVolumeID;

    [NativeTypeName("BYTE[36]")]
    public _AlternateVolumeID_e__FixedBuffer AlternateVolumeID;

    [NativeTypeName("BYTE[8]")]
    public _VendorIdentification_e__FixedBuffer VendorIdentification;

    [NativeTypeName("BYTE[16]")]
    public _ProductIdentification_e__FixedBuffer ProductIdentification;

    [NativeTypeName("BYTE[32]")]
    public _SerialNumber_e__FixedBuffer SerialNumber;

    [InlineArray(36)]
    public partial struct _PrimaryVolumeID_e__FixedBuffer
    {
        public byte e0;
    }

    [InlineArray(36)]
    public partial struct _AlternateVolumeID_e__FixedBuffer
    {
        public byte e0;
    }

    [InlineArray(8)]
    public partial struct _VendorIdentification_e__FixedBuffer
    {
        public byte e0;
    }

    [InlineArray(16)]
    public partial struct _ProductIdentification_e__FixedBuffer
    {
        public byte e0;
    }

    [InlineArray(32)]
    public partial struct _SerialNumber_e__FixedBuffer
    {
        public byte e0;
    }
}
