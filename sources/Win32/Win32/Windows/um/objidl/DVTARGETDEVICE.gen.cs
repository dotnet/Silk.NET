// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/objidl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct DVTARGETDEVICE
{
    [NativeTypeName("DWORD")]
    public uint tdSize;

    [NativeTypeName("WORD")]
    public ushort tdDriverNameOffset;

    [NativeTypeName("WORD")]
    public ushort tdDeviceNameOffset;

    [NativeTypeName("WORD")]
    public ushort tdPortNameOffset;

    [NativeTypeName("WORD")]
    public ushort tdExtDevmodeOffset;

    [NativeTypeName("BYTE[1]")]
    public _tdData_e__FixedBuffer tdData;

    public partial struct _tdData_e__FixedBuffer
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
