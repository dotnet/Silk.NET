// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct DRIVE_LAYOUT_INFORMATION_EX
{
    [NativeTypeName("DWORD")]
    public uint PartitionStyle;

    [NativeTypeName("DWORD")]
    public uint PartitionCount;

    [NativeTypeName("__AnonymousRecord_winioctl_L9364_C5")]
    public _Anonymous_e__Union Anonymous;

    [NativeTypeName("PARTITION_INFORMATION_EX[1]")]
    public _PartitionEntry_e__FixedBuffer PartitionEntry;

    [UnscopedRef]
    public ref DRIVE_LAYOUT_INFORMATION_MBR Mbr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Mbr; }
    }

    [UnscopedRef]
    public ref DRIVE_LAYOUT_INFORMATION_GPT Gpt
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Gpt; }
    }

    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        public DRIVE_LAYOUT_INFORMATION_MBR Mbr;

        [FieldOffset(0)]
        public DRIVE_LAYOUT_INFORMATION_GPT Gpt;
    }

    public partial struct _PartitionEntry_e__FixedBuffer
    {
        public PARTITION_INFORMATION_EX e0;

        [UnscopedRef]
        public ref PARTITION_INFORMATION_EX this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref Unsafe.Add(ref e0, index); }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<PARTITION_INFORMATION_EX> AsSpan(int length) =>
            MemoryMarshal.CreateSpan(ref e0, length);
    }
}
