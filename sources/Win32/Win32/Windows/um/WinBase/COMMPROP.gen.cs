// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinBase.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct COMMPROP
{
    [NativeTypeName("WORD")]
    public ushort wPacketLength;

    [NativeTypeName("WORD")]
    public ushort wPacketVersion;

    [NativeTypeName("DWORD")]
    public uint dwServiceMask;

    [NativeTypeName("DWORD")]
    public uint dwReserved1;

    [NativeTypeName("DWORD")]
    public uint dwMaxTxQueue;

    [NativeTypeName("DWORD")]
    public uint dwMaxRxQueue;

    [NativeTypeName("DWORD")]
    public uint dwMaxBaud;

    [NativeTypeName("DWORD")]
    public uint dwProvSubType;

    [NativeTypeName("DWORD")]
    public uint dwProvCapabilities;

    [NativeTypeName("DWORD")]
    public uint dwSettableParams;

    [NativeTypeName("DWORD")]
    public uint dwSettableBaud;

    [NativeTypeName("WORD")]
    public ushort wSettableData;

    [NativeTypeName("WORD")]
    public ushort wSettableStopParity;

    [NativeTypeName("DWORD")]
    public uint dwCurrentTxQueue;

    [NativeTypeName("DWORD")]
    public uint dwCurrentRxQueue;

    [NativeTypeName("DWORD")]
    public uint dwProvSpec1;

    [NativeTypeName("DWORD")]
    public uint dwProvSpec2;

    [NativeTypeName("WCHAR[1]")]
    public _wcProvChar_e__FixedBuffer wcProvChar;

    public partial struct _wcProvChar_e__FixedBuffer
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
