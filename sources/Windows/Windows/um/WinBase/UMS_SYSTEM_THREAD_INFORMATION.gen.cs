// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinBase.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;

/// <include file='UMS_SYSTEM_THREAD_INFORMATION.xml' path='doc/member[@name="UMS_SYSTEM_THREAD_INFORMATION"]/*' />
public partial struct UMS_SYSTEM_THREAD_INFORMATION
{
    /// <include file='UMS_SYSTEM_THREAD_INFORMATION.xml' path='doc/member[@name="UMS_SYSTEM_THREAD_INFORMATION.UmsVersion"]/*' />
    [NativeTypeName("ULONG")]
    public uint UmsVersion;

    /// <include file='UMS_SYSTEM_THREAD_INFORMATION.xml' path='doc/member[@name="UMS_SYSTEM_THREAD_INFORMATION.Anonymous"]/*' />
    [NativeTypeName("__AnonymousRecord_WinBase_L1614_C5")]
    public _Anonymous_e__Union Anonymous;

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.IsUmsSchedulerThread"]/*' />
    public uint IsUmsSchedulerThread
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return Anonymous.Anonymous.IsUmsSchedulerThread;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            Anonymous.Anonymous.IsUmsSchedulerThread = value;
        }
    }

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.IsUmsWorkerThread"]/*' />
    public uint IsUmsWorkerThread
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return Anonymous.Anonymous.IsUmsWorkerThread;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            Anonymous.Anonymous.IsUmsWorkerThread = value;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.ThreadUmsFlags"]/*' />
    [UnscopedRef]
    public ref uint ThreadUmsFlags
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.ThreadUmsFlags;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Anonymous"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_WinBase_L1615_C9")]
        public _Anonymous_e__Struct Anonymous;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.ThreadUmsFlags"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("ULONG")]
        public uint ThreadUmsFlags;

        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct"]/*' />
        public partial struct _Anonymous_e__Struct
        {
            public uint _bitfield;

            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.IsUmsSchedulerThread"]/*' />
            [NativeTypeName("ULONG : 1")]
            public uint IsUmsSchedulerThread
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return _bitfield & 0x1u;
                }

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set
                {
                    _bitfield = (_bitfield & ~0x1u) | (value & 0x1u);
                }
            }

            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.IsUmsWorkerThread"]/*' />
            [NativeTypeName("ULONG : 1")]
            public uint IsUmsWorkerThread
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return (_bitfield >> 1) & 0x1u;
                }

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set
                {
                    _bitfield = (_bitfield & ~(0x1u << 1)) | ((value & 0x1u) << 1);
                }
            }
        }
    }
}
