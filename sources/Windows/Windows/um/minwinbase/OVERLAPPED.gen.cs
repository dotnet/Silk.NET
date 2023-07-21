// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/minwinbase.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;

/// <include file='OVERLAPPED.xml' path='doc/member[@name="OVERLAPPED"]/*' />
public unsafe partial struct OVERLAPPED
{
    /// <include file='OVERLAPPED.xml' path='doc/member[@name="OVERLAPPED.Internal"]/*' />
    [NativeTypeName("ULONG_PTR")]
    public nuint Internal;

    /// <include file='OVERLAPPED.xml' path='doc/member[@name="OVERLAPPED.InternalHigh"]/*' />
    [NativeTypeName("ULONG_PTR")]
    public nuint InternalHigh;

    /// <include file='OVERLAPPED.xml' path='doc/member[@name="OVERLAPPED.Anonymous"]/*' />
    [NativeTypeName("__AnonymousRecord_minwinbase_L55_C5")]
    public _Anonymous_e__Union Anonymous;

    /// <include file='OVERLAPPED.xml' path='doc/member[@name="OVERLAPPED.hEvent"]/*' />
    public HANDLE hEvent;

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.Offset"]/*' />
    [UnscopedRef]
    public ref uint Offset
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Anonymous.Offset;
        }
    }

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.OffsetHigh"]/*' />
    [UnscopedRef]
    public ref uint OffsetHigh
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Anonymous.OffsetHigh;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Pointer"]/*' />
    [UnscopedRef]
    public ref void* Pointer
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Pointer;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Anonymous"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_minwinbase_L56_C9")]
        public _Anonymous_e__Struct Anonymous;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Pointer"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("PVOID")]
        public void* Pointer;

        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct"]/*' />
        public partial struct _Anonymous_e__Struct
        {
            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.Offset"]/*' />
            [NativeTypeName("DWORD")]
            public uint Offset;

            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.OffsetHigh"]/*' />
            [NativeTypeName("DWORD")]
            public uint OffsetHigh;
        }
    }
}
