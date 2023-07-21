// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace Silk.NET.Windows;

/// <include file='DEVICEDUMP_STORAGESTACK_PUBLIC_STATE_RECORD.xml' path='doc/member[@name="DEVICEDUMP_STORAGESTACK_PUBLIC_STATE_RECORD"]/*' />
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe partial struct DEVICEDUMP_STORAGESTACK_PUBLIC_STATE_RECORD
{
    /// <include file='DEVICEDUMP_STORAGESTACK_PUBLIC_STATE_RECORD.xml' path='doc/member[@name="DEVICEDUMP_STORAGESTACK_PUBLIC_STATE_RECORD.Cdb"]/*' />
    [NativeTypeName("BYTE[16]")]
    public fixed byte Cdb[16];

    /// <include file='DEVICEDUMP_STORAGESTACK_PUBLIC_STATE_RECORD.xml' path='doc/member[@name="DEVICEDUMP_STORAGESTACK_PUBLIC_STATE_RECORD.Command"]/*' />
    [NativeTypeName("BYTE[16]")]
    public fixed byte Command[16];

    /// <include file='DEVICEDUMP_STORAGESTACK_PUBLIC_STATE_RECORD.xml' path='doc/member[@name="DEVICEDUMP_STORAGESTACK_PUBLIC_STATE_RECORD.StartTime"]/*' />
    [NativeTypeName("DWORDLONG")]
    public ulong StartTime;

    /// <include file='DEVICEDUMP_STORAGESTACK_PUBLIC_STATE_RECORD.xml' path='doc/member[@name="DEVICEDUMP_STORAGESTACK_PUBLIC_STATE_RECORD.EndTime"]/*' />
    [NativeTypeName("DWORDLONG")]
    public ulong EndTime;

    /// <include file='DEVICEDUMP_STORAGESTACK_PUBLIC_STATE_RECORD.xml' path='doc/member[@name="DEVICEDUMP_STORAGESTACK_PUBLIC_STATE_RECORD.OperationStatus"]/*' />
    [NativeTypeName("DWORD")]
    public uint OperationStatus;

    /// <include file='DEVICEDUMP_STORAGESTACK_PUBLIC_STATE_RECORD.xml' path='doc/member[@name="DEVICEDUMP_STORAGESTACK_PUBLIC_STATE_RECORD.OperationError"]/*' />
    [NativeTypeName("DWORD")]
    public uint OperationError;

    /// <include file='DEVICEDUMP_STORAGESTACK_PUBLIC_STATE_RECORD.xml' path='doc/member[@name="DEVICEDUMP_STORAGESTACK_PUBLIC_STATE_RECORD.StackSpecific"]/*' />
    [NativeTypeName("__AnonymousRecord_winioctl_L6033_C9")]
    public _StackSpecific_e__Union StackSpecific;

    /// <include file='_StackSpecific_e__Union.xml' path='doc/member[@name="_StackSpecific_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _StackSpecific_e__Union
    {
        /// <include file='_StackSpecific_e__Union.xml' path='doc/member[@name="_StackSpecific_e__Union.ExternalStack"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_winioctl_L6034_C10")]
        public _ExternalStack_e__Struct ExternalStack;

        /// <include file='_StackSpecific_e__Union.xml' path='doc/member[@name="_StackSpecific_e__Union.AtaPort"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_winioctl_L6038_C10")]
        public _AtaPort_e__Struct AtaPort;

        /// <include file='_StackSpecific_e__Union.xml' path='doc/member[@name="_StackSpecific_e__Union.StorPort"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_winioctl_L6042_C10")]
        public _StorPort_e__Struct StorPort;

        /// <include file='_ExternalStack_e__Struct.xml' path='doc/member[@name="_ExternalStack_e__Struct"]/*' />
        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public partial struct _ExternalStack_e__Struct
        {
            /// <include file='_ExternalStack_e__Struct.xml' path='doc/member[@name="_ExternalStack_e__Struct.dwReserved"]/*' />
            [NativeTypeName("DWORD")]
            public uint dwReserved;
        }

        /// <include file='_AtaPort_e__Struct.xml' path='doc/member[@name="_AtaPort_e__Struct"]/*' />
        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public partial struct _AtaPort_e__Struct
        {
            /// <include file='_AtaPort_e__Struct.xml' path='doc/member[@name="_AtaPort_e__Struct.dwAtaPortSpecific"]/*' />
            [NativeTypeName("DWORD")]
            public uint dwAtaPortSpecific;
        }

        /// <include file='_StorPort_e__Struct.xml' path='doc/member[@name="_StorPort_e__Struct"]/*' />
        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public partial struct _StorPort_e__Struct
        {
            /// <include file='_StorPort_e__Struct.xml' path='doc/member[@name="_StorPort_e__Struct.SrbTag"]/*' />
            [NativeTypeName("DWORD")]
            public uint SrbTag;
        }
    }
}
