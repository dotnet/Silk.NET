// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;
/// <include file='STORAGE_ZONED_DEVICE_DESCRIPTOR.xml' path='doc/member[@name="STORAGE_ZONED_DEVICE_DESCRIPTOR"]/*'/>
public partial struct STORAGE_ZONED_DEVICE_DESCRIPTOR
{
    /// <include file='STORAGE_ZONED_DEVICE_DESCRIPTOR.xml' path='doc/member[@name="STORAGE_ZONED_DEVICE_DESCRIPTOR.Version"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Version;
    /// <include file='STORAGE_ZONED_DEVICE_DESCRIPTOR.xml' path='doc/member[@name="STORAGE_ZONED_DEVICE_DESCRIPTOR.Size"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Size;
    /// <include file='STORAGE_ZONED_DEVICE_DESCRIPTOR.xml' path='doc/member[@name="STORAGE_ZONED_DEVICE_DESCRIPTOR.DeviceType"]/*'/>
    public STORAGE_ZONED_DEVICE_TYPES DeviceType;
    /// <include file='STORAGE_ZONED_DEVICE_DESCRIPTOR.xml' path='doc/member[@name="STORAGE_ZONED_DEVICE_DESCRIPTOR.ZoneCount"]/*'/>
    [NativeTypeName("DWORD")]
    public uint ZoneCount;
    /// <include file='STORAGE_ZONED_DEVICE_DESCRIPTOR.xml' path='doc/member[@name="STORAGE_ZONED_DEVICE_DESCRIPTOR.ZoneAttributes"]/*'/>
    [NativeTypeName("__AnonymousRecord_winioctl_L2821_C5")]
    public _ZoneAttributes_e__Union ZoneAttributes;
    /// <include file='STORAGE_ZONED_DEVICE_DESCRIPTOR.xml' path='doc/member[@name="STORAGE_ZONED_DEVICE_DESCRIPTOR.ZoneGroupCount"]/*'/>
    [NativeTypeName("DWORD")]
    public uint ZoneGroupCount;
    /// <include file='STORAGE_ZONED_DEVICE_DESCRIPTOR.xml' path='doc/member[@name="STORAGE_ZONED_DEVICE_DESCRIPTOR.ZoneGroup"]/*'/>
    [NativeTypeName("STORAGE_ZONE_GROUP[1]")]
    public _ZoneGroup_e__FixedBuffer ZoneGroup;
    /// <include file='_ZoneAttributes_e__Union.xml' path='doc/member[@name="_ZoneAttributes_e__Union"]/*'/>
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _ZoneAttributes_e__Union
    {
        /// <include file='_ZoneAttributes_e__Union.xml' path='doc/member[@name="_ZoneAttributes_e__Union.SequentialRequiredZone"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_winioctl_L2822_C9")]
        public _SequentialRequiredZone_e__Struct SequentialRequiredZone;
        /// <include file='_ZoneAttributes_e__Union.xml' path='doc/member[@name="_ZoneAttributes_e__Union.SequentialPreferredZone"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_winioctl_L2832_C9")]
        public _SequentialPreferredZone_e__Struct SequentialPreferredZone;
        /// <include file='_SequentialRequiredZone_e__Struct.xml' path='doc/member[@name="_SequentialRequiredZone_e__Struct"]/*'/>
        public unsafe partial struct _SequentialRequiredZone_e__Struct
        {
            /// <include file='_SequentialRequiredZone_e__Struct.xml' path='doc/member[@name="_SequentialRequiredZone_e__Struct.MaxOpenZoneCount"]/*'/>
            [NativeTypeName("DWORD")]
            public uint MaxOpenZoneCount;
            /// <include file='_SequentialRequiredZone_e__Struct.xml' path='doc/member[@name="_SequentialRequiredZone_e__Struct.UnrestrictedRead"]/*'/>
            [NativeTypeName("BOOLEAN")]
            public byte UnrestrictedRead;
            /// <include file='_SequentialRequiredZone_e__Struct.xml' path='doc/member[@name="_SequentialRequiredZone_e__Struct.Reserved"]/*'/>
            [NativeTypeName("BYTE[3]")]
            public fixed byte Reserved[3];
        }

        /// <include file='_SequentialPreferredZone_e__Struct.xml' path='doc/member[@name="_SequentialPreferredZone_e__Struct"]/*'/>
        public partial struct _SequentialPreferredZone_e__Struct
        {
            /// <include file='_SequentialPreferredZone_e__Struct.xml' path='doc/member[@name="_SequentialPreferredZone_e__Struct.OptimalOpenZoneCount"]/*'/>
            [NativeTypeName("DWORD")]
            public uint OptimalOpenZoneCount;
            /// <include file='_SequentialPreferredZone_e__Struct.xml' path='doc/member[@name="_SequentialPreferredZone_e__Struct.Reserved"]/*'/>
            [NativeTypeName("DWORD")]
            public uint Reserved;
        }
    }

    /// <include file='_ZoneGroup_e__FixedBuffer.xml' path='doc/member[@name="_ZoneGroup_e__FixedBuffer"]/*'/>
    public partial struct _ZoneGroup_e__FixedBuffer
    {
        public STORAGE_ZONE_GROUP e0;
        [UnscopedRef]
        public ref STORAGE_ZONE_GROUP this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref AsSpan(int.MaxValue)[index];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<STORAGE_ZONE_GROUP> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
    }
}