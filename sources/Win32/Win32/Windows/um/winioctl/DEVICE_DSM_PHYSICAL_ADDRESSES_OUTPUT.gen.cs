// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct DEVICE_DSM_PHYSICAL_ADDRESSES_OUTPUT
{
    [NativeTypeName("DWORD")]
    public uint Version;

    [NativeTypeName("DWORD")]
    public uint Flags;

    [NativeTypeName("DWORD")]
    public uint TotalNumberOfRanges;

    [NativeTypeName("DWORD")]
    public uint NumberOfRangesReturned;

    [NativeTypeName("DEVICE_STORAGE_ADDRESS_RANGE[1]")]
    public _Ranges_e__FixedBuffer Ranges;

    public partial struct _Ranges_e__FixedBuffer
    {
        public DEVICE_STORAGE_ADDRESS_RANGE e0;

        [UnscopedRef]
        public ref DEVICE_STORAGE_ADDRESS_RANGE this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref Unsafe.Add(ref e0, index); }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<DEVICE_STORAGE_ADDRESS_RANGE> AsSpan(int length) =>
            MemoryMarshal.CreateSpan(ref e0, length);
    }
}
