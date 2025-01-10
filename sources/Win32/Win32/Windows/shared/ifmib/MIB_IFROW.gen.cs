// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/ifmib.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct MIB_IFROW
{
    [NativeTypeName("WCHAR[256]")]
    public _wszName_e__FixedBuffer wszName;

    [NativeTypeName("IF_INDEX")]
    public uint dwIndex;

    [NativeTypeName("IFTYPE")]
    public uint dwType;

    [NativeTypeName("DWORD")]
    public uint dwMtu;

    [NativeTypeName("DWORD")]
    public uint dwSpeed;

    [NativeTypeName("DWORD")]
    public uint dwPhysAddrLen;

    [NativeTypeName("UCHAR[8]")]
    public _bPhysAddr_e__FixedBuffer bPhysAddr;

    [NativeTypeName("DWORD")]
    public uint dwAdminStatus;
    public INTERNAL_IF_OPER_STATUS dwOperStatus;

    [NativeTypeName("DWORD")]
    public uint dwLastChange;

    [NativeTypeName("DWORD")]
    public uint dwInOctets;

    [NativeTypeName("DWORD")]
    public uint dwInUcastPkts;

    [NativeTypeName("DWORD")]
    public uint dwInNUcastPkts;

    [NativeTypeName("DWORD")]
    public uint dwInDiscards;

    [NativeTypeName("DWORD")]
    public uint dwInErrors;

    [NativeTypeName("DWORD")]
    public uint dwInUnknownProtos;

    [NativeTypeName("DWORD")]
    public uint dwOutOctets;

    [NativeTypeName("DWORD")]
    public uint dwOutUcastPkts;

    [NativeTypeName("DWORD")]
    public uint dwOutNUcastPkts;

    [NativeTypeName("DWORD")]
    public uint dwOutDiscards;

    [NativeTypeName("DWORD")]
    public uint dwOutErrors;

    [NativeTypeName("DWORD")]
    public uint dwOutQLen;

    [NativeTypeName("DWORD")]
    public uint dwDescrLen;

    [NativeTypeName("UCHAR[256]")]
    public _bDescr_e__FixedBuffer bDescr;

    [InlineArray(256)]
    public partial struct _wszName_e__FixedBuffer
    {
        public ushort e0;
    }

    [InlineArray(8)]
    public partial struct _bPhysAddr_e__FixedBuffer
    {
        public byte e0;
    }

    [InlineArray(256)]
    public partial struct _bDescr_e__FixedBuffer
    {
        public byte e0;
    }
}
