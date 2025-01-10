// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct IMAGE_RESOURCE_DIRECTORY_ENTRY
{
    [NativeTypeName("__AnonymousRecord_winnt_L20697_C5")]
    public _Anonymous1_e__Union Anonymous1;

    [NativeTypeName("__AnonymousRecord_winnt_L20705_C5")]
    public _Anonymous2_e__Union Anonymous2;
    public uint NameOffset
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return Anonymous1.Anonymous.NameOffset; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { Anonymous1.Anonymous.NameOffset = value; }
    }
    public uint NameIsString
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return Anonymous1.Anonymous.NameIsString; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { Anonymous1.Anonymous.NameIsString = value; }
    }

    [UnscopedRef]
    public ref uint Name
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous1.Name; }
    }

    [UnscopedRef]
    public ref ushort Id
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous1.Id; }
    }

    [UnscopedRef]
    public ref uint OffsetToData
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous2.OffsetToData; }
    }
    public uint OffsetToDirectory
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return Anonymous2.Anonymous.OffsetToDirectory; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { Anonymous2.Anonymous.OffsetToDirectory = value; }
    }
    public uint DataIsDirectory
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return Anonymous2.Anonymous.DataIsDirectory; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { Anonymous2.Anonymous.DataIsDirectory = value; }
    }

    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous1_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_winnt_L20698_C9")]
        public _Anonymous_e__Struct Anonymous;

        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint Name;

        [FieldOffset(0)]
        [NativeTypeName("WORD")]
        public ushort Id;

        public partial struct _Anonymous_e__Struct
        {
            public uint _bitfield;

            [NativeTypeName("DWORD : 31")]
            public uint NameOffset
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                readonly get { return _bitfield & 0x7FFFFFFFu; }
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set { _bitfield = (_bitfield & ~0x7FFFFFFFu) | (value & 0x7FFFFFFFu); }
            }

            [NativeTypeName("DWORD : 1")]
            public uint NameIsString
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                readonly get { return (_bitfield >> 31) & 0x1u; }
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set { _bitfield = (_bitfield & ~(0x1u << 31)) | ((value & 0x1u) << 31); }
            }
        }
    }

    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous2_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint OffsetToData;

        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_winnt_L20707_C9")]
        public _Anonymous_e__Struct Anonymous;

        public partial struct _Anonymous_e__Struct
        {
            public uint _bitfield;

            [NativeTypeName("DWORD : 31")]
            public uint OffsetToDirectory
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                readonly get { return _bitfield & 0x7FFFFFFFu; }
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set { _bitfield = (_bitfield & ~0x7FFFFFFFu) | (value & 0x7FFFFFFFu); }
            }

            [NativeTypeName("DWORD : 1")]
            public uint DataIsDirectory
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                readonly get { return (_bitfield >> 31) & 0x1u; }
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set { _bitfield = (_bitfield & ~(0x1u << 31)) | ((value & 0x1u) << 31); }
            }
        }
    }
}
