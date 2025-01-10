// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct EMRPOLYTEXTOUTA
{
    public EMR emr;
    public RECTL rclBounds;

    [NativeTypeName("DWORD")]
    public uint iGraphicsMode;
    public float exScale;
    public float eyScale;

    [NativeTypeName("LONG")]
    public int cStrings;

    [NativeTypeName("EMRTEXT[1]")]
    public _aemrtext_e__FixedBuffer aemrtext;

    public partial struct _aemrtext_e__FixedBuffer
    {
        public EMRTEXT e0;

        [UnscopedRef]
        public ref EMRTEXT this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref Unsafe.Add(ref e0, index); }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<EMRTEXT> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
    }
}
