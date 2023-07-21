// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinBase.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='COMMPROP.xml' path='doc/member[@name="COMMPROP"]/*' />
public unsafe partial struct COMMPROP
{
    /// <include file='COMMPROP.xml' path='doc/member[@name="COMMPROP.wPacketLength"]/*' />
    [NativeTypeName("WORD")]
    public ushort wPacketLength;

    /// <include file='COMMPROP.xml' path='doc/member[@name="COMMPROP.wPacketVersion"]/*' />
    [NativeTypeName("WORD")]
    public ushort wPacketVersion;

    /// <include file='COMMPROP.xml' path='doc/member[@name="COMMPROP.dwServiceMask"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwServiceMask;

    /// <include file='COMMPROP.xml' path='doc/member[@name="COMMPROP.dwReserved1"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwReserved1;

    /// <include file='COMMPROP.xml' path='doc/member[@name="COMMPROP.dwMaxTxQueue"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwMaxTxQueue;

    /// <include file='COMMPROP.xml' path='doc/member[@name="COMMPROP.dwMaxRxQueue"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwMaxRxQueue;

    /// <include file='COMMPROP.xml' path='doc/member[@name="COMMPROP.dwMaxBaud"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwMaxBaud;

    /// <include file='COMMPROP.xml' path='doc/member[@name="COMMPROP.dwProvSubType"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwProvSubType;

    /// <include file='COMMPROP.xml' path='doc/member[@name="COMMPROP.dwProvCapabilities"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwProvCapabilities;

    /// <include file='COMMPROP.xml' path='doc/member[@name="COMMPROP.dwSettableParams"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwSettableParams;

    /// <include file='COMMPROP.xml' path='doc/member[@name="COMMPROP.dwSettableBaud"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwSettableBaud;

    /// <include file='COMMPROP.xml' path='doc/member[@name="COMMPROP.wSettableData"]/*' />
    [NativeTypeName("WORD")]
    public ushort wSettableData;

    /// <include file='COMMPROP.xml' path='doc/member[@name="COMMPROP.wSettableStopParity"]/*' />
    [NativeTypeName("WORD")]
    public ushort wSettableStopParity;

    /// <include file='COMMPROP.xml' path='doc/member[@name="COMMPROP.dwCurrentTxQueue"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwCurrentTxQueue;

    /// <include file='COMMPROP.xml' path='doc/member[@name="COMMPROP.dwCurrentRxQueue"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwCurrentRxQueue;

    /// <include file='COMMPROP.xml' path='doc/member[@name="COMMPROP.dwProvSpec1"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwProvSpec1;

    /// <include file='COMMPROP.xml' path='doc/member[@name="COMMPROP.dwProvSpec2"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwProvSpec2;

    /// <include file='COMMPROP.xml' path='doc/member[@name="COMMPROP.wcProvChar"]/*' />
    [NativeTypeName("WCHAR[1]")]
    public fixed ushort wcProvChar[1];
}
