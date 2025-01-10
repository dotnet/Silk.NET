// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/Psapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[StructLayout(LayoutKind.Explicit)]
public partial struct PSAPI_WORKING_SET_BLOCK
{
    [FieldOffset(0)]
    [NativeTypeName("ULONG_PTR")]
    public nuint Flags;

    [FieldOffset(0)]
    [NativeTypeName("__AnonymousRecord_Psapi_L386_C5")]
    public _Anonymous_e__Struct Anonymous;
    public nuint Protection
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return Anonymous.Protection; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { Anonymous.Protection = value; }
    }
    public nuint ShareCount
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return Anonymous.ShareCount; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { Anonymous.ShareCount = value; }
    }
    public nuint Shared
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return Anonymous.Shared; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { Anonymous.Shared = value; }
    }
    public nuint Reserved
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return Anonymous.Reserved; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { Anonymous.Reserved = value; }
    }
    public nuint VirtualPage
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return Anonymous.VirtualPage; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { Anonymous.VirtualPage = value; }
    }

    public partial struct _Anonymous_e__Struct
    {
        public nuint _bitfield;

        [NativeTypeName("ULONG_PTR : 5")]
        public nuint Protection
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get { return _bitfield & 0x1Fu; }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { _bitfield = (_bitfield & ~0x1Fu) | (value & 0x1Fu); }
        }

        [NativeTypeName("ULONG_PTR : 3")]
        public nuint ShareCount
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get { return (_bitfield >> 5) & 0x7u; }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { _bitfield = (_bitfield & ~(0x7u << 5)) | ((value & 0x7u) << 5); }
        }

        [NativeTypeName("ULONG_PTR : 1")]
        public nuint Shared
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get { return (_bitfield >> 8) & 0x1u; }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { _bitfield = (_bitfield & ~(0x1u << 8)) | ((value & 0x1u) << 8); }
        }

        [NativeTypeName("ULONG_PTR : 3")]
        public nuint Reserved
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get { return (_bitfield >> 9) & 0x7u; }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { _bitfield = (_bitfield & ~(0x7u << 9)) | ((value & 0x7u) << 9); }
        }

        [NativeTypeName("ULONG_PTR : 52")]
        public nuint VirtualPage
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get { return (_bitfield >> 12) & 0xFFFFFu; }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { _bitfield = (_bitfield & ~(0xFFFFFu << 12)) | ((value & 0xFFFFFu) << 12); }
        }
    }
}
