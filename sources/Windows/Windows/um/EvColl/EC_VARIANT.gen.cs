// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/EvColl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;

/// <include file='EC_VARIANT.xml' path='doc/member[@name="EC_VARIANT"]/*' />
public unsafe partial struct EC_VARIANT
{
    /// <include file='EC_VARIANT.xml' path='doc/member[@name="EC_VARIANT.Anonymous"]/*' />
    [NativeTypeName("__AnonymousRecord_EvColl_L121_C5")]
    public _Anonymous_e__Union Anonymous;

    /// <include file='EC_VARIANT.xml' path='doc/member[@name="EC_VARIANT.Count"]/*' />
    [NativeTypeName("DWORD")]
    public uint Count;

    /// <include file='EC_VARIANT.xml' path='doc/member[@name="EC_VARIANT.Type"]/*' />
    [NativeTypeName("DWORD")]
    public uint Type;

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.BooleanVal"]/*' />
    [UnscopedRef]
    public ref BOOL BooleanVal
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.BooleanVal;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.UInt32Val"]/*' />
    [UnscopedRef]
    public ref uint UInt32Val
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.UInt32Val;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.DateTimeVal"]/*' />
    [UnscopedRef]
    public ref ulong DateTimeVal
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.DateTimeVal;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.StringVal"]/*' />
    [UnscopedRef]
    public ref ushort* StringVal
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.StringVal;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.BinaryVal"]/*' />
    [UnscopedRef]
    public ref byte* BinaryVal
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.BinaryVal;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.BooleanArr"]/*' />
    [UnscopedRef]
    public ref BOOL* BooleanArr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.BooleanArr;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Int32Arr"]/*' />
    [UnscopedRef]
    public ref int* Int32Arr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Int32Arr;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.StringArr"]/*' />
    [UnscopedRef]
    public ref ushort** StringArr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.StringArr;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.PropertyHandleVal"]/*' />
    [UnscopedRef]
    public ref EC_OBJECT_ARRAY_PROPERTY_HANDLE PropertyHandleVal
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.PropertyHandleVal;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.BooleanVal"]/*' />
        [FieldOffset(0)]
        public BOOL BooleanVal;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.UInt32Val"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("UINT32")]
        public uint UInt32Val;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.DateTimeVal"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("ULONGLONG")]
        public ulong DateTimeVal;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.StringVal"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("LPCWSTR")]
        public ushort* StringVal;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.BinaryVal"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("PBYTE")]
        public byte* BinaryVal;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.BooleanArr"]/*' />
        [FieldOffset(0)]
        public BOOL* BooleanArr;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Int32Arr"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("INT32 *")]
        public int* Int32Arr;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.StringArr"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("LPWSTR *")]
        public ushort** StringArr;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.PropertyHandleVal"]/*' />
        [FieldOffset(0)]
        public EC_OBJECT_ARRAY_PROPERTY_HANDLE PropertyHandleVal;
    }
}
