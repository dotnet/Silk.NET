// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct TXFS_START_RM_INFORMATION
{
    [NativeTypeName("DWORD")]
    public uint Flags;

    [NativeTypeName("DWORDLONG")]
    public ulong LogContainerSize;

    [NativeTypeName("DWORD")]
    public uint LogContainerCountMin;

    [NativeTypeName("DWORD")]
    public uint LogContainerCountMax;

    [NativeTypeName("DWORD")]
    public uint LogGrowthIncrement;

    [NativeTypeName("DWORD")]
    public uint LogAutoShrinkPercentage;

    [NativeTypeName("DWORD")]
    public uint TmLogPathOffset;

    [NativeTypeName("WORD")]
    public ushort TmLogPathLength;

    [NativeTypeName("WORD")]
    public ushort LoggingMode;

    [NativeTypeName("WORD")]
    public ushort LogPathLength;

    [NativeTypeName("WORD")]
    public ushort Reserved;

    [NativeTypeName("WCHAR[1]")]
    public _LogPath_e__FixedBuffer LogPath;

    public partial struct _LogPath_e__FixedBuffer
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
