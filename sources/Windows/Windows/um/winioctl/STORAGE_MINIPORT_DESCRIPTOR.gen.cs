// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;
/// <include file='STORAGE_MINIPORT_DESCRIPTOR.xml' path='doc/member[@name="STORAGE_MINIPORT_DESCRIPTOR"]/*'/>
public unsafe partial struct STORAGE_MINIPORT_DESCRIPTOR
{
    /// <include file='STORAGE_MINIPORT_DESCRIPTOR.xml' path='doc/member[@name="STORAGE_MINIPORT_DESCRIPTOR.Version"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Version;
    /// <include file='STORAGE_MINIPORT_DESCRIPTOR.xml' path='doc/member[@name="STORAGE_MINIPORT_DESCRIPTOR.Size"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Size;
    /// <include file='STORAGE_MINIPORT_DESCRIPTOR.xml' path='doc/member[@name="STORAGE_MINIPORT_DESCRIPTOR.Portdriver"]/*'/>
    public STORAGE_PORT_CODE_SET Portdriver;
    /// <include file='STORAGE_MINIPORT_DESCRIPTOR.xml' path='doc/member[@name="STORAGE_MINIPORT_DESCRIPTOR.LUNResetSupported"]/*'/>
    [NativeTypeName("BOOLEAN")]
    public byte LUNResetSupported;
    /// <include file='STORAGE_MINIPORT_DESCRIPTOR.xml' path='doc/member[@name="STORAGE_MINIPORT_DESCRIPTOR.TargetResetSupported"]/*'/>
    [NativeTypeName("BOOLEAN")]
    public byte TargetResetSupported;
    /// <include file='STORAGE_MINIPORT_DESCRIPTOR.xml' path='doc/member[@name="STORAGE_MINIPORT_DESCRIPTOR.IoTimeoutValue"]/*'/>
    [NativeTypeName("WORD")]
    public ushort IoTimeoutValue;
    /// <include file='STORAGE_MINIPORT_DESCRIPTOR.xml' path='doc/member[@name="STORAGE_MINIPORT_DESCRIPTOR.ExtraIoInfoSupported"]/*'/>
    [NativeTypeName("BOOLEAN")]
    public byte ExtraIoInfoSupported;
    /// <include file='STORAGE_MINIPORT_DESCRIPTOR.xml' path='doc/member[@name="STORAGE_MINIPORT_DESCRIPTOR.Flags"]/*'/>
    [NativeTypeName("__AnonymousRecord_winioctl_L1474_C5")]
    public _Flags_e__Union Flags;
    /// <include file='STORAGE_MINIPORT_DESCRIPTOR.xml' path='doc/member[@name="STORAGE_MINIPORT_DESCRIPTOR.Reserved0"]/*'/>
    [NativeTypeName("BYTE[2]")]
    public fixed byte Reserved0[2];
    /// <include file='STORAGE_MINIPORT_DESCRIPTOR.xml' path='doc/member[@name="STORAGE_MINIPORT_DESCRIPTOR.Reserved1"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Reserved1;
    /// <include file='_Flags_e__Union.xml' path='doc/member[@name="_Flags_e__Union"]/*'/>
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Flags_e__Union
    {
        /// <include file='_Flags_e__Union.xml' path='doc/member[@name="_Flags_e__Union.Anonymous"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_winioctl_L1475_C9")]
        public _Anonymous_e__Struct Anonymous;
        /// <include file='_Flags_e__Union.xml' path='doc/member[@name="_Flags_e__Union.AsBYTE"]/*'/>
        [FieldOffset(0)]
        public byte AsBYTE;
        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.LogicalPoFxForDisk"]/*'/>
        public byte LogicalPoFxForDisk
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return Anonymous.LogicalPoFxForDisk;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                Anonymous.LogicalPoFxForDisk = value;
            }
        }

        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.Reserved"]/*'/>
        public byte Reserved
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return Anonymous.Reserved;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                Anonymous.Reserved = value;
            }
        }

        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct"]/*'/>
        public partial struct _Anonymous_e__Struct
        {
            public byte _bitfield;
            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.LogicalPoFxForDisk"]/*'/>
            [NativeTypeName("byte : 1")]
            public byte LogicalPoFxForDisk
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return (byte)(_bitfield & 0x1u);
                }

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set
                {
                    _bitfield = (byte)((_bitfield & ~0x1u) | (value & 0x1u));
                }
            }

            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.Reserved"]/*'/>
            [NativeTypeName("byte : 7")]
            public byte Reserved
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return (byte)((_bitfield >> 1) & 0x7Fu);
                }

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set
                {
                    _bitfield = (byte)((_bitfield & ~(0x7Fu << 1)) | ((value & 0x7Fu) << 1));
                }
            }
        }
    }
}