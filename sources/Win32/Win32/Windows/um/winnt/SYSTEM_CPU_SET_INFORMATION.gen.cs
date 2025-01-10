// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[SupportedOSPlatform("windows10.0")]
public partial struct SYSTEM_CPU_SET_INFORMATION
{
    [NativeTypeName("DWORD")]
    public uint Size;
    public CPU_SET_INFORMATION_TYPE Type;

    [NativeTypeName("__AnonymousRecord_winnt_L14071_C5")]
    public _Anonymous_e__Union Anonymous;

    [UnscopedRef]
    public ref _Anonymous_e__Union._CpuSet_e__Struct CpuSet
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.CpuSet; }
    }

    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_winnt_L14072_C9")]
        public _CpuSet_e__Struct CpuSet;

        public partial struct _CpuSet_e__Struct
        {
            [NativeTypeName("DWORD")]
            public uint Id;

            [NativeTypeName("WORD")]
            public ushort Group;
            public byte LogicalProcessorIndex;
            public byte CoreIndex;
            public byte LastLevelCacheIndex;
            public byte NumaNodeIndex;
            public byte EfficiencyClass;

            [NativeTypeName("__AnonymousRecord_winnt_L14080_C13")]
            public _Anonymous1_e__Union Anonymous1;

            [NativeTypeName("__AnonymousRecord_winnt_L14097_C13")]
            public _Anonymous2_e__Union Anonymous2;

            [NativeTypeName("DWORD64")]
            public ulong AllocationTag;

            [UnscopedRef]
            public ref byte AllFlags
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get { return ref Anonymous1.AllFlags; }
            }
            public byte Parked
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                readonly get { return Anonymous1.Anonymous.Parked; }
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set { Anonymous1.Anonymous.Parked = value; }
            }
            public byte Allocated
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                readonly get { return Anonymous1.Anonymous.Allocated; }
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set { Anonymous1.Anonymous.Allocated = value; }
            }
            public byte AllocatedToTargetProcess
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                readonly get { return Anonymous1.Anonymous.AllocatedToTargetProcess; }
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set { Anonymous1.Anonymous.AllocatedToTargetProcess = value; }
            }
            public byte RealTime
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                readonly get { return Anonymous1.Anonymous.RealTime; }
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set { Anonymous1.Anonymous.RealTime = value; }
            }
            public byte ReservedFlags
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                readonly get { return Anonymous1.Anonymous.ReservedFlags; }
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set { Anonymous1.Anonymous.ReservedFlags = value; }
            }

            [UnscopedRef]
            public ref uint Reserved
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get { return ref Anonymous2.Reserved; }
            }

            [UnscopedRef]
            public ref byte SchedulingClass
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get { return ref Anonymous2.SchedulingClass; }
            }

            [StructLayout(LayoutKind.Explicit)]
            public partial struct _Anonymous1_e__Union
            {
                [FieldOffset(0)]
                public byte AllFlags;

                [FieldOffset(0)]
                [NativeTypeName("__AnonymousRecord_winnt_L14088_C17")]
                public _Anonymous_e__Struct Anonymous;

                public partial struct _Anonymous_e__Struct
                {
                    public byte _bitfield;

                    [NativeTypeName("byte : 1")]
                    public byte Parked
                    {
                        [MethodImpl(MethodImplOptions.AggressiveInlining)]
                        readonly get { return (byte)(_bitfield & 0x1u); }
                        [MethodImpl(MethodImplOptions.AggressiveInlining)]
                        set { _bitfield = (byte)((_bitfield & ~0x1u) | (value & 0x1u)); }
                    }

                    [NativeTypeName("byte : 1")]
                    public byte Allocated
                    {
                        [MethodImpl(MethodImplOptions.AggressiveInlining)]
                        readonly get { return (byte)((_bitfield >> 1) & 0x1u); }
                        [MethodImpl(MethodImplOptions.AggressiveInlining)]
                        set
                        {
                            _bitfield = (byte)((_bitfield & ~(0x1u << 1)) | ((value & 0x1u) << 1));
                        }
                    }

                    [NativeTypeName("byte : 1")]
                    public byte AllocatedToTargetProcess
                    {
                        [MethodImpl(MethodImplOptions.AggressiveInlining)]
                        readonly get { return (byte)((_bitfield >> 2) & 0x1u); }
                        [MethodImpl(MethodImplOptions.AggressiveInlining)]
                        set
                        {
                            _bitfield = (byte)((_bitfield & ~(0x1u << 2)) | ((value & 0x1u) << 2));
                        }
                    }

                    [NativeTypeName("byte : 1")]
                    public byte RealTime
                    {
                        [MethodImpl(MethodImplOptions.AggressiveInlining)]
                        readonly get { return (byte)((_bitfield >> 3) & 0x1u); }
                        [MethodImpl(MethodImplOptions.AggressiveInlining)]
                        set
                        {
                            _bitfield = (byte)((_bitfield & ~(0x1u << 3)) | ((value & 0x1u) << 3));
                        }
                    }

                    [NativeTypeName("byte : 4")]
                    public byte ReservedFlags
                    {
                        [MethodImpl(MethodImplOptions.AggressiveInlining)]
                        readonly get { return (byte)((_bitfield >> 4) & 0xFu); }
                        [MethodImpl(MethodImplOptions.AggressiveInlining)]
                        set
                        {
                            _bitfield = (byte)((_bitfield & ~(0xFu << 4)) | ((value & 0xFu) << 4));
                        }
                    }
                }
            }

            [StructLayout(LayoutKind.Explicit)]
            public partial struct _Anonymous2_e__Union
            {
                [FieldOffset(0)]
                [NativeTypeName("DWORD")]
                public uint Reserved;

                [FieldOffset(0)]
                public byte SchedulingClass;
            }
        }
    }
}
