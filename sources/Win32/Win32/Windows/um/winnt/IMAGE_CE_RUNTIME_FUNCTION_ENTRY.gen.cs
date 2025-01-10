// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct IMAGE_CE_RUNTIME_FUNCTION_ENTRY
{
    [NativeTypeName("DWORD")]
    public uint FuncStart;
    public uint _bitfield;

    [NativeTypeName("DWORD : 8")]
    public uint PrologLen
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return _bitfield & 0xFFu; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { _bitfield = (_bitfield & ~0xFFu) | (value & 0xFFu); }
    }

    [NativeTypeName("DWORD : 22")]
    public uint FuncLen
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (_bitfield >> 8) & 0x3FFFFFu; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { _bitfield = (_bitfield & ~(0x3FFFFFu << 8)) | ((value & 0x3FFFFFu) << 8); }
    }

    [NativeTypeName("DWORD : 1")]
    public uint ThirtyTwoBit
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (_bitfield >> 30) & 0x1u; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { _bitfield = (_bitfield & ~(0x1u << 30)) | ((value & 0x1u) << 30); }
    }

    [NativeTypeName("DWORD : 1")]
    public uint ExceptionFlag
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (_bitfield >> 31) & 0x1u; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { _bitfield = (_bitfield & ~(0x1u << 31)) | ((value & 0x1u) << 31); }
    }
}
