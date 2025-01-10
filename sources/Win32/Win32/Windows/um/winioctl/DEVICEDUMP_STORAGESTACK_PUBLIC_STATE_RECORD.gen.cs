// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct DEVICEDUMP_STORAGESTACK_PUBLIC_STATE_RECORD
{
    [NativeTypeName("BYTE[16]")]
    public _Cdb_e__FixedBuffer Cdb;

    [NativeTypeName("BYTE[16]")]
    public _Command_e__FixedBuffer Command;

    [NativeTypeName("DWORDLONG")]
    public ulong StartTime;

    [NativeTypeName("DWORDLONG")]
    public ulong EndTime;

    [NativeTypeName("DWORD")]
    public uint OperationStatus;

    [NativeTypeName("DWORD")]
    public uint OperationError;

    [NativeTypeName("__AnonymousRecord_winioctl_L6294_C9")]
    public _StackSpecific_e__Union StackSpecific;

    [StructLayout(LayoutKind.Explicit)]
    public partial struct _StackSpecific_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_winioctl_L6295_C10")]
        public _ExternalStack_e__Struct ExternalStack;

        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_winioctl_L6299_C10")]
        public _AtaPort_e__Struct AtaPort;

        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_winioctl_L6303_C10")]
        public _StorPort_e__Struct StorPort;

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public partial struct _ExternalStack_e__Struct
        {
            [NativeTypeName("DWORD")]
            public uint dwReserved;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public partial struct _AtaPort_e__Struct
        {
            [NativeTypeName("DWORD")]
            public uint dwAtaPortSpecific;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public partial struct _StorPort_e__Struct
        {
            [NativeTypeName("DWORD")]
            public uint SrbTag;
        }
    }

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    [InlineArray(16)]
    public partial struct _Cdb_e__FixedBuffer
    {
        public byte e0;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    [InlineArray(16)]
    public partial struct _Command_e__FixedBuffer
    {
        public byte e0;
    }
}
