// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct FORMAT_EX_PARAMETERS
{
    public MEDIA_TYPE MediaType;

    [NativeTypeName("DWORD")]
    public uint StartCylinderNumber;

    [NativeTypeName("DWORD")]
    public uint EndCylinderNumber;

    [NativeTypeName("DWORD")]
    public uint StartHeadNumber;

    [NativeTypeName("DWORD")]
    public uint EndHeadNumber;

    [NativeTypeName("WORD")]
    public ushort FormatGapLength;

    [NativeTypeName("WORD")]
    public ushort SectorsPerTrack;

    [NativeTypeName("WORD[1]")]
    public _SectorNumber_e__FixedBuffer SectorNumber;

    public partial struct _SectorNumber_e__FixedBuffer
    {
        public ushort e0;

        [UnscopedRef]
        public ref ushort this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref Unsafe.Add(ref e0, index); }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<ushort> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
    }
}
