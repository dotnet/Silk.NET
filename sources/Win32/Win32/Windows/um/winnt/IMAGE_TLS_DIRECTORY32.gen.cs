// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct IMAGE_TLS_DIRECTORY32
{
    [NativeTypeName("DWORD")]
    public uint StartAddressOfRawData;

    [NativeTypeName("DWORD")]
    public uint EndAddressOfRawData;

    [NativeTypeName("DWORD")]
    public uint AddressOfIndex;

    [NativeTypeName("DWORD")]
    public uint AddressOfCallBacks;

    [NativeTypeName("DWORD")]
    public uint SizeOfZeroFill;

    [NativeTypeName("__AnonymousRecord_winnt_L20564_C5")]
    public _Anonymous_e__Union Anonymous;

    [UnscopedRef]
    public ref uint Characteristics
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Characteristics; }
    }
    public uint Reserved0
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return Anonymous.Anonymous.Reserved0; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { Anonymous.Anonymous.Reserved0 = value; }
    }
    public uint Alignment
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return Anonymous.Anonymous.Alignment; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { Anonymous.Anonymous.Alignment = value; }
    }
    public uint Reserved1
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return Anonymous.Anonymous.Reserved1; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { Anonymous.Anonymous.Reserved1 = value; }
    }

    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint Characteristics;

        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_winnt_L20566_C9")]
        public _Anonymous_e__Struct Anonymous;

        public partial struct _Anonymous_e__Struct
        {
            public uint _bitfield;

            [NativeTypeName("DWORD : 20")]
            public uint Reserved0
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                readonly get { return _bitfield & 0xFFFFFu; }
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set { _bitfield = (_bitfield & ~0xFFFFFu) | (value & 0xFFFFFu); }
            }

            [NativeTypeName("DWORD : 4")]
            public uint Alignment
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                readonly get { return (_bitfield >> 20) & 0xFu; }
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set { _bitfield = (_bitfield & ~(0xFu << 20)) | ((value & 0xFu) << 20); }
            }

            [NativeTypeName("DWORD : 8")]
            public uint Reserved1
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                readonly get { return (_bitfield >> 24) & 0xFFu; }
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set { _bitfield = (_bitfield & ~(0xFFu << 24)) | ((value & 0xFFu) << 24); }
            }
        }
    }
}
