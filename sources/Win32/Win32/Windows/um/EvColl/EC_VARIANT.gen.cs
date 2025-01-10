// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/EvColl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public unsafe partial struct EC_VARIANT
{
    [NativeTypeName("__AnonymousRecord_EvColl_L121_C5")]
    public _Anonymous_e__Union Anonymous;

    [NativeTypeName("DWORD")]
    public uint Count;

    [NativeTypeName("DWORD")]
    public uint Type;

    [UnscopedRef]
    public ref BOOL BooleanVal
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.BooleanVal; }
    }

    [UnscopedRef]
    public ref uint UInt32Val
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.UInt32Val; }
    }

    [UnscopedRef]
    public ref ulong DateTimeVal
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.DateTimeVal; }
    }

    [UnscopedRef]
    public ref ushort* StringVal
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.StringVal; }
    }

    [UnscopedRef]
    public ref byte* BinaryVal
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.BinaryVal; }
    }

    [UnscopedRef]
    public ref BOOL* BooleanArr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.BooleanArr; }
    }

    [UnscopedRef]
    public ref int* Int32Arr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Int32Arr; }
    }

    [UnscopedRef]
    public ref ushort** StringArr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.StringArr; }
    }

    [UnscopedRef]
    public ref EC_OBJECT_ARRAY_PROPERTY_HANDLE PropertyHandleVal
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.PropertyHandleVal; }
    }

    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        public BOOL BooleanVal;

        [FieldOffset(0)]
        [NativeTypeName("UINT32")]
        public uint UInt32Val;

        [FieldOffset(0)]
        [NativeTypeName("ULONGLONG")]
        public ulong DateTimeVal;

        [FieldOffset(0)]
        [NativeTypeName("LPCWSTR")]
        public ushort* StringVal;

        [FieldOffset(0)]
        [NativeTypeName("PBYTE")]
        public byte* BinaryVal;

        [FieldOffset(0)]
        public BOOL* BooleanArr;

        [FieldOffset(0)]
        [NativeTypeName("INT32 *")]
        public int* Int32Arr;

        [FieldOffset(0)]
        [NativeTypeName("LPWSTR *")]
        public ushort** StringArr;

        [FieldOffset(0)]
        public EC_OBJECT_ARRAY_PROPERTY_HANDLE PropertyHandleVal;
    }
}
