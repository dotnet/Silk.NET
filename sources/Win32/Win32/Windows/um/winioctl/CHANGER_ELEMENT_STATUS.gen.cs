// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct CHANGER_ELEMENT_STATUS
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
}
