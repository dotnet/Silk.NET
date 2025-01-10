// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct IMAGE_HOT_PATCH_MACHINE
{
    [NativeTypeName("__AnonymousRecord_winnt_L21113_C5")]
    public _Anonymous_e__Struct Anonymous;
    public uint _x86
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return Anonymous._x86; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { Anonymous._x86 = value; }
    }
    public uint Amd64
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return Anonymous.Amd64; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { Anonymous.Amd64 = value; }
    }
    public uint Arm64
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return Anonymous.Arm64; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { Anonymous.Arm64 = value; }
    }
    public uint Amd64EC
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return Anonymous.Amd64EC; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { Anonymous.Amd64EC = value; }
    }

    public partial struct _Anonymous_e__Struct
    {
        public uint _bitfield;

        [NativeTypeName("DWORD : 1")]
        public uint _x86
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get { return _bitfield & 0x1u; }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { _bitfield = (_bitfield & ~0x1u) | (value & 0x1u); }
        }

        [NativeTypeName("DWORD : 1")]
        public uint Amd64
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get { return (_bitfield >> 1) & 0x1u; }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { _bitfield = (_bitfield & ~(0x1u << 1)) | ((value & 0x1u) << 1); }
        }

        [NativeTypeName("DWORD : 1")]
        public uint Arm64
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get { return (_bitfield >> 2) & 0x1u; }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { _bitfield = (_bitfield & ~(0x1u << 2)) | ((value & 0x1u) << 2); }
        }

        [NativeTypeName("DWORD : 1")]
        public uint Amd64EC
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get { return (_bitfield >> 3) & 0x1u; }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { _bitfield = (_bitfield & ~(0x1u << 3)) | ((value & 0x1u) << 3); }
        }
    }
}
