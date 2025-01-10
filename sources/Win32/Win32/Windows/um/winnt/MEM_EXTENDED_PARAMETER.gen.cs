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
public unsafe partial struct MEM_EXTENDED_PARAMETER
{
    [NativeTypeName("__AnonymousRecord_winnt_L14664_C5")]
    public _Anonymous1_e__Struct Anonymous1;

    [NativeTypeName("__AnonymousRecord_winnt_L14669_C5")]
    public _Anonymous2_e__Union Anonymous2;
    public ulong Type
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return Anonymous1.Type; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { Anonymous1.Type = value; }
    }
    public ulong Reserved
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return Anonymous1.Reserved; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { Anonymous1.Reserved = value; }
    }

    [UnscopedRef]
    public ref ulong ULong64
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous2.ULong64; }
    }

    [UnscopedRef]
    public ref void* Pointer
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous2.Pointer; }
    }

    [UnscopedRef]
    public ref nuint Size
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous2.Size; }
    }

    [UnscopedRef]
    public ref HANDLE Handle
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous2.Handle; }
    }

    [UnscopedRef]
    public ref uint ULong
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous2.ULong; }
    }

    public partial struct _Anonymous1_e__Struct
    {
        public ulong _bitfield;

        [NativeTypeName("DWORD64 : 8")]
        public ulong Type
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get { return _bitfield & 0xFFUL; }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { _bitfield = (_bitfield & ~0xFFUL) | (value & 0xFFUL); }
        }

        [NativeTypeName("DWORD64 : 56")]
        public ulong Reserved
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get { return (_bitfield >> 8) & 0xFFFFFFUL; }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { _bitfield = (_bitfield & ~(0xFFFFFFUL << 8)) | ((value & 0xFFFFFFUL) << 8); }
        }
    }

    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _Anonymous2_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("DWORD64")]
        public ulong ULong64;

        [FieldOffset(0)]
        [NativeTypeName("PVOID")]
        public void* Pointer;

        [FieldOffset(0)]
        [NativeTypeName("SIZE_T")]
        public nuint Size;

        [FieldOffset(0)]
        public HANDLE Handle;

        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint ULong;
    }
}
