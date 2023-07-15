// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;
/// <include file='SYSTEM_CPU_SET_INFORMATION.xml' path='doc/member[@name="SYSTEM_CPU_SET_INFORMATION"]/*'/>
[SupportedOSPlatform("windows10.0")]
public partial struct SYSTEM_CPU_SET_INFORMATION
{
    /// <include file='SYSTEM_CPU_SET_INFORMATION.xml' path='doc/member[@name="SYSTEM_CPU_SET_INFORMATION.Size"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Size;
    /// <include file='SYSTEM_CPU_SET_INFORMATION.xml' path='doc/member[@name="SYSTEM_CPU_SET_INFORMATION.Type"]/*'/>
    public CPU_SET_INFORMATION_TYPE Type;
    /// <include file='SYSTEM_CPU_SET_INFORMATION.xml' path='doc/member[@name="SYSTEM_CPU_SET_INFORMATION.Anonymous"]/*'/>
    [NativeTypeName("__AnonymousRecord_winnt_L13565_C5")]
    public _Anonymous_e__Union Anonymous;
    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.CpuSet"]/*'/>
    [UnscopedRef]
    public ref _Anonymous_e__Union._CpuSet_e__Struct CpuSet
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.CpuSet;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*'/>
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.CpuSet"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_winnt_L13566_C9")]
        public _CpuSet_e__Struct CpuSet;
        /// <include file='_CpuSet_e__Struct.xml' path='doc/member[@name="_CpuSet_e__Struct"]/*'/>
        public partial struct _CpuSet_e__Struct
        {
            /// <include file='_CpuSet_e__Struct.xml' path='doc/member[@name="_CpuSet_e__Struct.Id"]/*'/>
            [NativeTypeName("DWORD")]
            public uint Id;
            /// <include file='_CpuSet_e__Struct.xml' path='doc/member[@name="_CpuSet_e__Struct.Group"]/*'/>
            [NativeTypeName("WORD")]
            public ushort Group;
            /// <include file='_CpuSet_e__Struct.xml' path='doc/member[@name="_CpuSet_e__Struct.LogicalProcessorIndex"]/*'/>
            public byte LogicalProcessorIndex;
            /// <include file='_CpuSet_e__Struct.xml' path='doc/member[@name="_CpuSet_e__Struct.CoreIndex"]/*'/>
            public byte CoreIndex;
            /// <include file='_CpuSet_e__Struct.xml' path='doc/member[@name="_CpuSet_e__Struct.LastLevelCacheIndex"]/*'/>
            public byte LastLevelCacheIndex;
            /// <include file='_CpuSet_e__Struct.xml' path='doc/member[@name="_CpuSet_e__Struct.NumaNodeIndex"]/*'/>
            public byte NumaNodeIndex;
            /// <include file='_CpuSet_e__Struct.xml' path='doc/member[@name="_CpuSet_e__Struct.EfficiencyClass"]/*'/>
            public byte EfficiencyClass;
            /// <include file='_CpuSet_e__Struct.xml' path='doc/member[@name="_CpuSet_e__Struct.Anonymous1"]/*'/>
            [NativeTypeName("__AnonymousRecord_winnt_L13574_C13")]
            public _Anonymous1_e__Union Anonymous1;
            /// <include file='_CpuSet_e__Struct.xml' path='doc/member[@name="_CpuSet_e__Struct.Anonymous2"]/*'/>
            [NativeTypeName("__AnonymousRecord_winnt_L13591_C13")]
            public _Anonymous2_e__Union Anonymous2;
            /// <include file='_CpuSet_e__Struct.xml' path='doc/member[@name="_CpuSet_e__Struct.AllocationTag"]/*'/>
            [NativeTypeName("DWORD64")]
            public ulong AllocationTag;
            /// <include file='_Anonymous1_e__Union.xml' path='doc/member[@name="_Anonymous1_e__Union.AllFlags"]/*'/>
            [UnscopedRef]
            public ref byte AllFlags
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref Anonymous1.AllFlags;
                }
            }

            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.Parked"]/*'/>
            public byte Parked
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return Anonymous1.Anonymous.Parked;
                }

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set
                {
                    Anonymous1.Anonymous.Parked = value;
                }
            }

            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.Allocated"]/*'/>
            public byte Allocated
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return Anonymous1.Anonymous.Allocated;
                }

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set
                {
                    Anonymous1.Anonymous.Allocated = value;
                }
            }

            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.AllocatedToTargetProcess"]/*'/>
            public byte AllocatedToTargetProcess
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return Anonymous1.Anonymous.AllocatedToTargetProcess;
                }

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set
                {
                    Anonymous1.Anonymous.AllocatedToTargetProcess = value;
                }
            }

            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.RealTime"]/*'/>
            public byte RealTime
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return Anonymous1.Anonymous.RealTime;
                }

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set
                {
                    Anonymous1.Anonymous.RealTime = value;
                }
            }

            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.ReservedFlags"]/*'/>
            public byte ReservedFlags
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return Anonymous1.Anonymous.ReservedFlags;
                }

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set
                {
                    Anonymous1.Anonymous.ReservedFlags = value;
                }
            }

            /// <include file='_Anonymous2_e__Union.xml' path='doc/member[@name="_Anonymous2_e__Union.Reserved"]/*'/>
            [UnscopedRef]
            public ref uint Reserved
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref Anonymous2.Reserved;
                }
            }

            /// <include file='_Anonymous2_e__Union.xml' path='doc/member[@name="_Anonymous2_e__Union.SchedulingClass"]/*'/>
            [UnscopedRef]
            public ref byte SchedulingClass
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref Anonymous2.SchedulingClass;
                }
            }

            /// <include file='_Anonymous1_e__Union.xml' path='doc/member[@name="_Anonymous1_e__Union"]/*'/>
            [StructLayout(LayoutKind.Explicit)]
            public partial struct _Anonymous1_e__Union
            {
                /// <include file='_Anonymous1_e__Union.xml' path='doc/member[@name="_Anonymous1_e__Union.AllFlags"]/*'/>
                [FieldOffset(0)]
                public byte AllFlags;
                /// <include file='_Anonymous1_e__Union.xml' path='doc/member[@name="_Anonymous1_e__Union.Anonymous"]/*'/>
                [FieldOffset(0)]
                [NativeTypeName("__AnonymousRecord_winnt_L13582_C17")]
                public _Anonymous_e__Struct Anonymous;
                /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct"]/*'/>
                public partial struct _Anonymous_e__Struct
                {
                    public byte _bitfield;
                    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.Parked"]/*'/>
                    [NativeTypeName("byte : 1")]
                    public byte Parked
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

                    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.Allocated"]/*'/>
                    [NativeTypeName("byte : 1")]
                    public byte Allocated
                    {
                        [MethodImpl(MethodImplOptions.AggressiveInlining)]
                        get
                        {
                            return (byte)((_bitfield >> 1) & 0x1u);
                        }

                        [MethodImpl(MethodImplOptions.AggressiveInlining)]
                        set
                        {
                            _bitfield = (byte)((_bitfield & ~(0x1u << 1)) | ((value & 0x1u) << 1));
                        }
                    }

                    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.AllocatedToTargetProcess"]/*'/>
                    [NativeTypeName("byte : 1")]
                    public byte AllocatedToTargetProcess
                    {
                        [MethodImpl(MethodImplOptions.AggressiveInlining)]
                        get
                        {
                            return (byte)((_bitfield >> 2) & 0x1u);
                        }

                        [MethodImpl(MethodImplOptions.AggressiveInlining)]
                        set
                        {
                            _bitfield = (byte)((_bitfield & ~(0x1u << 2)) | ((value & 0x1u) << 2));
                        }
                    }

                    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.RealTime"]/*'/>
                    [NativeTypeName("byte : 1")]
                    public byte RealTime
                    {
                        [MethodImpl(MethodImplOptions.AggressiveInlining)]
                        get
                        {
                            return (byte)((_bitfield >> 3) & 0x1u);
                        }

                        [MethodImpl(MethodImplOptions.AggressiveInlining)]
                        set
                        {
                            _bitfield = (byte)((_bitfield & ~(0x1u << 3)) | ((value & 0x1u) << 3));
                        }
                    }

                    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.ReservedFlags"]/*'/>
                    [NativeTypeName("byte : 4")]
                    public byte ReservedFlags
                    {
                        [MethodImpl(MethodImplOptions.AggressiveInlining)]
                        get
                        {
                            return (byte)((_bitfield >> 4) & 0xFu);
                        }

                        [MethodImpl(MethodImplOptions.AggressiveInlining)]
                        set
                        {
                            _bitfield = (byte)((_bitfield & ~(0xFu << 4)) | ((value & 0xFu) << 4));
                        }
                    }
                }
            }

            /// <include file='_Anonymous2_e__Union.xml' path='doc/member[@name="_Anonymous2_e__Union"]/*'/>
            [StructLayout(LayoutKind.Explicit)]
            public partial struct _Anonymous2_e__Union
            {
                /// <include file='_Anonymous2_e__Union.xml' path='doc/member[@name="_Anonymous2_e__Union.Reserved"]/*'/>
                [FieldOffset(0)]
                [NativeTypeName("DWORD")]
                public uint Reserved;
                /// <include file='_Anonymous2_e__Union.xml' path='doc/member[@name="_Anonymous2_e__Union.SchedulingClass"]/*'/>
                [FieldOffset(0)]
                public byte SchedulingClass;
            }
        }
    }
}