// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct IMPORT_OBJECT_HEADER
{
    [NativeTypeName("WORD")]
    public ushort Sig1;

    [NativeTypeName("WORD")]
    public ushort Sig2;

    [NativeTypeName("WORD")]
    public ushort Version;

    [NativeTypeName("WORD")]
    public ushort Machine;

    [NativeTypeName("DWORD")]
    public uint TimeDateStamp;

    [NativeTypeName("DWORD")]
    public uint SizeOfData;

    [NativeTypeName("__AnonymousRecord_winnt_L21619_C5")]
    public _Anonymous_e__Union Anonymous;
    public ushort _bitfield;

    [NativeTypeName("WORD : 2")]
    public ushort Type
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (ushort)(_bitfield & 0x3u); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { _bitfield = (ushort)((_bitfield & ~0x3u) | (value & 0x3u)); }
    }

    [NativeTypeName("WORD : 3")]
    public ushort NameType
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (ushort)((_bitfield >> 2) & 0x7u); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { _bitfield = (ushort)((_bitfield & ~(0x7u << 2)) | ((value & 0x7u) << 2)); }
    }

    [NativeTypeName("WORD : 11")]
    public ushort Reserved
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (ushort)((_bitfield >> 5) & 0x7FFu); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { _bitfield = (ushort)((_bitfield & ~(0x7FFu << 5)) | ((value & 0x7FFu) << 5)); }
    }

    [UnscopedRef]
    public ref ushort Ordinal
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Ordinal; }
    }

    [UnscopedRef]
    public ref ushort Hint
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Hint; }
    }

    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("WORD")]
        public ushort Ordinal;

        [FieldOffset(0)]
        [NativeTypeName("WORD")]
        public ushort Hint;
    }
}
