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
public partial struct DEVICEDUMP_PUBLIC_SUBSECTION
{
    [NativeTypeName("DWORD")]
    public uint dwFlags;

    [NativeTypeName("GP_LOG_PAGE_DESCRIPTOR[16]")]
    public _GPLogTable_e__FixedBuffer GPLogTable;

    [NativeTypeName("CHAR[16]")]
    public _szDescription_e__FixedBuffer szDescription;

    [NativeTypeName("BYTE[1]")]
    public _bData_e__FixedBuffer bData;

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    [InlineArray(16)]
    public partial struct _GPLogTable_e__FixedBuffer
    {
        public GP_LOG_PAGE_DESCRIPTOR e0;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    [InlineArray(16)]
    public partial struct _szDescription_e__FixedBuffer
    {
        public sbyte e0;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct _bData_e__FixedBuffer
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
