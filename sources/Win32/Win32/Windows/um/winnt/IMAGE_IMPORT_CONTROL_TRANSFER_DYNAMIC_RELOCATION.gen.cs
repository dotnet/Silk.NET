// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct IMAGE_IMPORT_CONTROL_TRANSFER_DYNAMIC_RELOCATION
{
    public uint _bitfield;

    [NativeTypeName("DWORD : 12")]
    public uint PageRelativeOffset
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return _bitfield & 0xFFFu; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { _bitfield = (_bitfield & ~0xFFFu) | (value & 0xFFFu); }
    }

    [NativeTypeName("DWORD : 1")]
    public uint IndirectCall
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (_bitfield >> 12) & 0x1u; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { _bitfield = (_bitfield & ~(0x1u << 12)) | ((value & 0x1u) << 12); }
    }

    [NativeTypeName("DWORD : 19")]
    public uint IATIndex
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (_bitfield >> 13) & 0x7FFFFu; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { _bitfield = (_bitfield & ~(0x7FFFFu << 13)) | ((value & 0x7FFFFu) << 13); }
    }
}
