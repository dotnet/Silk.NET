// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct MOVEREGION_INFO
{
    public uint FrameNumber;
    public uint NumMoveRegions;

    [NativeTypeName("MOVE_RECT[1]")]
    public _MoveRegions_e__FixedBuffer MoveRegions;

    public partial struct _MoveRegions_e__FixedBuffer
    {
        public MOVE_RECT e0;

        [UnscopedRef]
        public ref MOVE_RECT this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref Unsafe.Add(ref e0, index); }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<MOVE_RECT> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
    }
}
