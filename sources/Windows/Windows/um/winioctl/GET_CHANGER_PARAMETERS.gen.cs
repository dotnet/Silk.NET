// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='GET_CHANGER_PARAMETERS.xml' path='doc/member[@name="GET_CHANGER_PARAMETERS"]/*' />
public unsafe partial struct GET_CHANGER_PARAMETERS
{
    /// <include file='GET_CHANGER_PARAMETERS.xml' path='doc/member[@name="GET_CHANGER_PARAMETERS.Size"]/*' />
    [NativeTypeName("DWORD")]
    public uint Size;

    /// <include file='GET_CHANGER_PARAMETERS.xml' path='doc/member[@name="GET_CHANGER_PARAMETERS.NumberTransportElements"]/*' />
    [NativeTypeName("WORD")]
    public ushort NumberTransportElements;

    /// <include file='GET_CHANGER_PARAMETERS.xml' path='doc/member[@name="GET_CHANGER_PARAMETERS.NumberStorageElements"]/*' />
    [NativeTypeName("WORD")]
    public ushort NumberStorageElements;

    /// <include file='GET_CHANGER_PARAMETERS.xml' path='doc/member[@name="GET_CHANGER_PARAMETERS.NumberCleanerSlots"]/*' />
    [NativeTypeName("WORD")]
    public ushort NumberCleanerSlots;

    /// <include file='GET_CHANGER_PARAMETERS.xml' path='doc/member[@name="GET_CHANGER_PARAMETERS.NumberIEElements"]/*' />
    [NativeTypeName("WORD")]
    public ushort NumberIEElements;

    /// <include file='GET_CHANGER_PARAMETERS.xml' path='doc/member[@name="GET_CHANGER_PARAMETERS.NumberDataTransferElements"]/*' />
    [NativeTypeName("WORD")]
    public ushort NumberDataTransferElements;

    /// <include file='GET_CHANGER_PARAMETERS.xml' path='doc/member[@name="GET_CHANGER_PARAMETERS.NumberOfDoors"]/*' />
    [NativeTypeName("WORD")]
    public ushort NumberOfDoors;

    /// <include file='GET_CHANGER_PARAMETERS.xml' path='doc/member[@name="GET_CHANGER_PARAMETERS.FirstSlotNumber"]/*' />
    [NativeTypeName("WORD")]
    public ushort FirstSlotNumber;

    /// <include file='GET_CHANGER_PARAMETERS.xml' path='doc/member[@name="GET_CHANGER_PARAMETERS.FirstDriveNumber"]/*' />
    [NativeTypeName("WORD")]
    public ushort FirstDriveNumber;

    /// <include file='GET_CHANGER_PARAMETERS.xml' path='doc/member[@name="GET_CHANGER_PARAMETERS.FirstTransportNumber"]/*' />
    [NativeTypeName("WORD")]
    public ushort FirstTransportNumber;

    /// <include file='GET_CHANGER_PARAMETERS.xml' path='doc/member[@name="GET_CHANGER_PARAMETERS.FirstIEPortNumber"]/*' />
    [NativeTypeName("WORD")]
    public ushort FirstIEPortNumber;

    /// <include file='GET_CHANGER_PARAMETERS.xml' path='doc/member[@name="GET_CHANGER_PARAMETERS.FirstCleanerSlotAddress"]/*' />
    [NativeTypeName("WORD")]
    public ushort FirstCleanerSlotAddress;

    /// <include file='GET_CHANGER_PARAMETERS.xml' path='doc/member[@name="GET_CHANGER_PARAMETERS.MagazineSize"]/*' />
    [NativeTypeName("WORD")]
    public ushort MagazineSize;

    /// <include file='GET_CHANGER_PARAMETERS.xml' path='doc/member[@name="GET_CHANGER_PARAMETERS.DriveCleanTimeout"]/*' />
    [NativeTypeName("DWORD")]
    public uint DriveCleanTimeout;

    /// <include file='GET_CHANGER_PARAMETERS.xml' path='doc/member[@name="GET_CHANGER_PARAMETERS.Features0"]/*' />
    [NativeTypeName("DWORD")]
    public uint Features0;

    /// <include file='GET_CHANGER_PARAMETERS.xml' path='doc/member[@name="GET_CHANGER_PARAMETERS.Features1"]/*' />
    [NativeTypeName("DWORD")]
    public uint Features1;

    /// <include file='GET_CHANGER_PARAMETERS.xml' path='doc/member[@name="GET_CHANGER_PARAMETERS.MoveFromTransport"]/*' />
    public byte MoveFromTransport;

    /// <include file='GET_CHANGER_PARAMETERS.xml' path='doc/member[@name="GET_CHANGER_PARAMETERS.MoveFromSlot"]/*' />
    public byte MoveFromSlot;

    /// <include file='GET_CHANGER_PARAMETERS.xml' path='doc/member[@name="GET_CHANGER_PARAMETERS.MoveFromIePort"]/*' />
    public byte MoveFromIePort;

    /// <include file='GET_CHANGER_PARAMETERS.xml' path='doc/member[@name="GET_CHANGER_PARAMETERS.MoveFromDrive"]/*' />
    public byte MoveFromDrive;

    /// <include file='GET_CHANGER_PARAMETERS.xml' path='doc/member[@name="GET_CHANGER_PARAMETERS.ExchangeFromTransport"]/*' />
    public byte ExchangeFromTransport;

    /// <include file='GET_CHANGER_PARAMETERS.xml' path='doc/member[@name="GET_CHANGER_PARAMETERS.ExchangeFromSlot"]/*' />
    public byte ExchangeFromSlot;

    /// <include file='GET_CHANGER_PARAMETERS.xml' path='doc/member[@name="GET_CHANGER_PARAMETERS.ExchangeFromIePort"]/*' />
    public byte ExchangeFromIePort;

    /// <include file='GET_CHANGER_PARAMETERS.xml' path='doc/member[@name="GET_CHANGER_PARAMETERS.ExchangeFromDrive"]/*' />
    public byte ExchangeFromDrive;

    /// <include file='GET_CHANGER_PARAMETERS.xml' path='doc/member[@name="GET_CHANGER_PARAMETERS.LockUnlockCapabilities"]/*' />
    public byte LockUnlockCapabilities;

    /// <include file='GET_CHANGER_PARAMETERS.xml' path='doc/member[@name="GET_CHANGER_PARAMETERS.PositionCapabilities"]/*' />
    public byte PositionCapabilities;

    /// <include file='GET_CHANGER_PARAMETERS.xml' path='doc/member[@name="GET_CHANGER_PARAMETERS.Reserved1"]/*' />
    [NativeTypeName("BYTE[2]")]
    public fixed byte Reserved1[2];

    /// <include file='GET_CHANGER_PARAMETERS.xml' path='doc/member[@name="GET_CHANGER_PARAMETERS.Reserved2"]/*' />
    [NativeTypeName("DWORD[2]")]
    public fixed uint Reserved2[2];
}
