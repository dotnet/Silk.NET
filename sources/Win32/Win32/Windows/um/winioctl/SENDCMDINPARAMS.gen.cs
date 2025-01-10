// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct SENDCMDINPARAMS
{
    [NativeTypeName("DWORD")]
    public uint cBufferSize;
    public IDEREGS irDriveRegs;
    public byte bDriveNumber;

    [NativeTypeName("BYTE[3]")]
    public _bReserved_e__FixedBuffer bReserved;

    [NativeTypeName("DWORD[4]")]
    public _dwReserved_e__FixedBuffer dwReserved;

    [NativeTypeName("BYTE[1]")]
    public _bBuffer_e__FixedBuffer bBuffer;

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    [InlineArray(3)]
    public partial struct _bReserved_e__FixedBuffer
    {
        public byte e0;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    [InlineArray(4)]
    public partial struct _dwReserved_e__FixedBuffer
    {
        public uint e0;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct _bBuffer_e__FixedBuffer
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
