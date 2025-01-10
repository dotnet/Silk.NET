// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct FILE_REGION_OUTPUT
{
    [NativeTypeName("DWORD")]
    public uint Flags;

    [NativeTypeName("DWORD")]
    public uint TotalRegionEntryCount;

    [NativeTypeName("DWORD")]
    public uint RegionEntryCount;

    [NativeTypeName("DWORD")]
    public uint Reserved;

    [NativeTypeName("FILE_REGION_INFO[1]")]
    public _Region_e__FixedBuffer Region;

    public partial struct _Region_e__FixedBuffer
    {
        public FILE_REGION_INFO e0;

        [UnscopedRef]
        public ref FILE_REGION_INFO this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref Unsafe.Add(ref e0, index); }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<FILE_REGION_INFO> AsSpan(int length) =>
            MemoryMarshal.CreateSpan(ref e0, length);
    }
}
