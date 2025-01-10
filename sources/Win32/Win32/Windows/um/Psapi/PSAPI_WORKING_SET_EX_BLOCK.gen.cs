// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/Psapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[StructLayout(LayoutKind.Explicit)]
public partial struct PSAPI_WORKING_SET_EX_BLOCK
{
    [FieldOffset(0)]
    [NativeTypeName("ULONG_PTR")]
    public nuint Flags;

    [FieldOffset(0)]
    [NativeTypeName("__AnonymousRecord_Psapi_L406_C5")]
    public _Anonymous_e__Union Anonymous;
    public nuint Valid
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return Anonymous.Anonymous.Valid; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { Anonymous.Anonymous.Valid = value; }
    }
    public nuint ShareCount
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return Anonymous.Anonymous.ShareCount; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { Anonymous.Anonymous.ShareCount = value; }
    }
    public nuint Win32Protection
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return Anonymous.Anonymous.Win32Protection; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { Anonymous.Anonymous.Win32Protection = value; }
    }
    public nuint Shared
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return Anonymous.Anonymous.Shared; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { Anonymous.Anonymous.Shared = value; }
    }
    public nuint Node
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return Anonymous.Anonymous.Node; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { Anonymous.Anonymous.Node = value; }
    }
    public nuint Locked
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return Anonymous.Anonymous.Locked; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { Anonymous.Anonymous.Locked = value; }
    }
    public nuint LargePage
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return Anonymous.Anonymous.LargePage; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { Anonymous.Anonymous.LargePage = value; }
    }
    public nuint Reserved
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return Anonymous.Anonymous.Reserved; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { Anonymous.Anonymous.Reserved = value; }
    }
    public nuint Bad
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return Anonymous.Anonymous.Bad; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { Anonymous.Anonymous.Bad = value; }
    }
    public nuint ReservedUlong
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return Anonymous.Anonymous.ReservedUlong; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { Anonymous.Anonymous.ReservedUlong = value; }
    }

    [UnscopedRef]
    public ref _Anonymous_e__Union._Invalid_e__Struct Invalid
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Invalid; }
    }

    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_Psapi_L407_C9")]
        public _Anonymous_e__Struct Anonymous;

        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_Psapi_L422_C9")]
        public _Invalid_e__Struct Invalid;

        public partial struct _Anonymous_e__Struct
        {
            public nuint _bitfield;

            [NativeTypeName("ULONG_PTR : 1")]
            public nuint Valid
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                readonly get { return _bitfield & 0x1u; }
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set { _bitfield = (_bitfield & ~0x1u) | (value & 0x1u); }
            }

            [NativeTypeName("ULONG_PTR : 3")]
            public nuint ShareCount
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                readonly get { return (_bitfield >> 1) & 0x7u; }
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set { _bitfield = (_bitfield & ~(0x7u << 1)) | ((value & 0x7u) << 1); }
            }

            [NativeTypeName("ULONG_PTR : 11")]
            public nuint Win32Protection
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                readonly get { return (_bitfield >> 4) & 0x7FFu; }
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set { _bitfield = (_bitfield & ~(0x7FFu << 4)) | ((value & 0x7FFu) << 4); }
            }

            [NativeTypeName("ULONG_PTR : 1")]
            public nuint Shared
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                readonly get { return (_bitfield >> 15) & 0x1u; }
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set { _bitfield = (_bitfield & ~(0x1u << 15)) | ((value & 0x1u) << 15); }
            }

            [NativeTypeName("ULONG_PTR : 6")]
            public nuint Node
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                readonly get { return (_bitfield >> 16) & 0x3Fu; }
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set { _bitfield = (_bitfield & ~(0x3Fu << 16)) | ((value & 0x3Fu) << 16); }
            }

            [NativeTypeName("ULONG_PTR : 1")]
            public nuint Locked
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                readonly get { return (_bitfield >> 22) & 0x1u; }
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set { _bitfield = (_bitfield & ~(0x1u << 22)) | ((value & 0x1u) << 22); }
            }

            [NativeTypeName("ULONG_PTR : 1")]
            public nuint LargePage
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                readonly get { return (_bitfield >> 23) & 0x1u; }
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set { _bitfield = (_bitfield & ~(0x1u << 23)) | ((value & 0x1u) << 23); }
            }

            [NativeTypeName("ULONG_PTR : 7")]
            public nuint Reserved
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                readonly get { return (_bitfield >> 24) & 0x7Fu; }
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set { _bitfield = (_bitfield & ~(0x7Fu << 24)) | ((value & 0x7Fu) << 24); }
            }

            [NativeTypeName("ULONG_PTR : 1")]
            public nuint Bad
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                readonly get { return (_bitfield >> 31) & 0x1u; }
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set { _bitfield = (_bitfield & ~(0x1u << 31)) | ((value & 0x1u) << 31); }
            }

            [NativeTypeName("ULONG_PTR : 32")]
            public nuint ReservedUlong
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                readonly get { return (_bitfield >> 32) & 0x0u; }
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set { _bitfield = (_bitfield & ~(0x0u << 32)) | ((value & 0x0u) << 32); }
            }
        }

        public partial struct _Invalid_e__Struct
        {
            public nuint _bitfield;

            [NativeTypeName("ULONG_PTR : 1")]
            public nuint Valid
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                readonly get { return _bitfield & 0x1u; }
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set { _bitfield = (_bitfield & ~0x1u) | (value & 0x1u); }
            }

            [NativeTypeName("ULONG_PTR : 14")]
            public nuint Reserved0
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                readonly get { return (_bitfield >> 1) & 0x3FFFu; }
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set { _bitfield = (_bitfield & ~(0x3FFFu << 1)) | ((value & 0x3FFFu) << 1); }
            }

            [NativeTypeName("ULONG_PTR : 1")]
            public nuint Shared
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                readonly get { return (_bitfield >> 15) & 0x1u; }
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set { _bitfield = (_bitfield & ~(0x1u << 15)) | ((value & 0x1u) << 15); }
            }

            [NativeTypeName("ULONG_PTR : 15")]
            public nuint Reserved1
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                readonly get { return (_bitfield >> 16) & 0x7FFFu; }
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set { _bitfield = (_bitfield & ~(0x7FFFu << 16)) | ((value & 0x7FFFu) << 16); }
            }

            [NativeTypeName("ULONG_PTR : 1")]
            public nuint Bad
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                readonly get { return (_bitfield >> 31) & 0x1u; }
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set { _bitfield = (_bitfield & ~(0x1u << 31)) | ((value & 0x1u) << 31); }
            }

            [NativeTypeName("ULONG_PTR : 32")]
            public nuint ReservedUlong
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                readonly get { return (_bitfield >> 32) & 0x0u; }
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set { _bitfield = (_bitfield & ~(0x0u << 32)) | ((value & 0x0u) << 32); }
            }
        }
    }
}
