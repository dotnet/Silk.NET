// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/wtypes.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct userBITMAP
{
    [NativeTypeName("LONG")]
    public int bmType;

    [NativeTypeName("LONG")]
    public int bmWidth;

    [NativeTypeName("LONG")]
    public int bmHeight;

    [NativeTypeName("LONG")]
    public int bmWidthBytes;

    [NativeTypeName("WORD")]
    public ushort bmPlanes;

    [NativeTypeName("WORD")]
    public ushort bmBitsPixel;

    [NativeTypeName("ULONG")]
    public uint cbSize;

    [NativeTypeName("byte[1]")]
    public _pBuffer_e__FixedBuffer pBuffer;

    public partial struct _pBuffer_e__FixedBuffer
    {
        public byte e0;

        [UnscopedRef]
        public ref byte this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref Unsafe.Add(ref e0, index); }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<byte> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
    }
}
