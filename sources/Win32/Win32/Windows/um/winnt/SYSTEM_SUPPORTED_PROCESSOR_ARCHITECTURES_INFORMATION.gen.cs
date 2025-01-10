// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct SYSTEM_SUPPORTED_PROCESSOR_ARCHITECTURES_INFORMATION
{
    public uint _bitfield;

    [NativeTypeName("DWORD : 16")]
    public uint Machine
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return _bitfield & 0xFFFFu; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { _bitfield = (_bitfield & ~0xFFFFu) | (value & 0xFFFFu); }
    }

    [NativeTypeName("DWORD : 1")]
    public uint KernelMode
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (_bitfield >> 16) & 0x1u; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { _bitfield = (_bitfield & ~(0x1u << 16)) | ((value & 0x1u) << 16); }
    }

    [NativeTypeName("DWORD : 1")]
    public uint UserMode
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (_bitfield >> 17) & 0x1u; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { _bitfield = (_bitfield & ~(0x1u << 17)) | ((value & 0x1u) << 17); }
    }

    [NativeTypeName("DWORD : 1")]
    public uint Native
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (_bitfield >> 18) & 0x1u; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { _bitfield = (_bitfield & ~(0x1u << 18)) | ((value & 0x1u) << 18); }
    }

    [NativeTypeName("DWORD : 1")]
    public uint Process
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (_bitfield >> 19) & 0x1u; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { _bitfield = (_bitfield & ~(0x1u << 19)) | ((value & 0x1u) << 19); }
    }

    [NativeTypeName("DWORD : 1")]
    public uint WoW64Container
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (_bitfield >> 20) & 0x1u; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { _bitfield = (_bitfield & ~(0x1u << 20)) | ((value & 0x1u) << 20); }
    }

    [NativeTypeName("DWORD : 11")]
    public uint ReservedZero0
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (_bitfield >> 21) & 0x7FFu; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { _bitfield = (_bitfield & ~(0x7FFu << 21)) | ((value & 0x7FFu) << 21); }
    }
}
