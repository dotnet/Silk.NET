// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct STORAGE_ZONED_DEVICE_DESCRIPTOR
{
    [NativeTypeName("DWORD")]
    public uint Version;

    [NativeTypeName("DWORD")]
    public uint Size;
    public STORAGE_ZONED_DEVICE_TYPES DeviceType;

    [NativeTypeName("DWORD")]
    public uint ZoneCount;

    [NativeTypeName("__AnonymousRecord_winioctl_L3016_C5")]
    public _ZoneAttributes_e__Union ZoneAttributes;

    [NativeTypeName("DWORD")]
    public uint ZoneGroupCount;

    [NativeTypeName("STORAGE_ZONE_GROUP[1]")]
    public _ZoneGroup_e__FixedBuffer ZoneGroup;

    [StructLayout(LayoutKind.Explicit)]
    public partial struct _ZoneAttributes_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_winioctl_L3017_C9")]
        public _SequentialRequiredZone_e__Struct SequentialRequiredZone;

        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_winioctl_L3027_C9")]
        public _SequentialPreferredZone_e__Struct SequentialPreferredZone;

        public partial struct _SequentialRequiredZone_e__Struct
        {
            [NativeTypeName("DWORD")]
            public uint MaxOpenZoneCount;

            [NativeTypeName("BOOLEAN")]
            public byte UnrestrictedRead;

            [NativeTypeName("BYTE[3]")]
            public _Reserved_e__FixedBuffer Reserved;

            [InlineArray(3)]
            public partial struct _Reserved_e__FixedBuffer
            {
                public byte e0;
            }
        }

        public partial struct _SequentialPreferredZone_e__Struct
        {
            [NativeTypeName("DWORD")]
            public uint OptimalOpenZoneCount;

            [NativeTypeName("DWORD")]
            public uint Reserved;
        }
    }

    public partial struct _ZoneGroup_e__FixedBuffer
    {
        public STORAGE_ZONE_GROUP e0;

        [UnscopedRef]
        public ref STORAGE_ZONE_GROUP this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref Unsafe.Add(ref e0, index); }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<STORAGE_ZONE_GROUP> AsSpan(int length) =>
            MemoryMarshal.CreateSpan(ref e0, length);
    }
}
