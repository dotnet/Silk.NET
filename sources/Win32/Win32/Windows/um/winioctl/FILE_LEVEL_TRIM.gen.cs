// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[SupportedOSPlatform("windows6.2")]
public partial struct FILE_LEVEL_TRIM
{
    [NativeTypeName("DWORD")]
    public uint Key;

    [NativeTypeName("DWORD")]
    public uint NumRanges;

    [NativeTypeName("FILE_LEVEL_TRIM_RANGE[1]")]
    public _Ranges_e__FixedBuffer Ranges;

    public partial struct _Ranges_e__FixedBuffer
    {
        public FILE_LEVEL_TRIM_RANGE e0;

        [UnscopedRef]
        public ref FILE_LEVEL_TRIM_RANGE this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref Unsafe.Add(ref e0, index); }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<FILE_LEVEL_TRIM_RANGE> AsSpan(int length) =>
            MemoryMarshal.CreateSpan(ref e0, length);
    }
}
