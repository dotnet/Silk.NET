// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinBase.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct UMS_SYSTEM_THREAD_INFORMATION
{
    [NativeTypeName("ULONG")]
    public uint UmsVersion;

    [NativeTypeName("__AnonymousRecord_winbase_L1637_C5")]
    public _Anonymous_e__Union Anonymous;
    public uint IsUmsSchedulerThread
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return Anonymous.Anonymous.IsUmsSchedulerThread; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { Anonymous.Anonymous.IsUmsSchedulerThread = value; }
    }
    public uint IsUmsWorkerThread
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return Anonymous.Anonymous.IsUmsWorkerThread; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { Anonymous.Anonymous.IsUmsWorkerThread = value; }
    }

    [UnscopedRef]
    public ref uint ThreadUmsFlags
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.ThreadUmsFlags; }
    }

    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_winbase_L1638_C9")]
        public _Anonymous_e__Struct Anonymous;

        [FieldOffset(0)]
        [NativeTypeName("ULONG")]
        public uint ThreadUmsFlags;

        public partial struct _Anonymous_e__Struct
        {
            public uint _bitfield;

            [NativeTypeName("ULONG : 1")]
            public uint IsUmsSchedulerThread
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                readonly get { return _bitfield & 0x1u; }
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set { _bitfield = (_bitfield & ~0x1u) | (value & 0x1u); }
            }

            [NativeTypeName("ULONG : 1")]
            public uint IsUmsWorkerThread
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                readonly get { return (_bitfield >> 1) & 0x1u; }
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set { _bitfield = (_bitfield & ~(0x1u << 1)) | ((value & 0x1u) << 1); }
            }
        }
    }
}
