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

[SupportedOSPlatform("windows10.0")]
public partial struct STORAGE_PROTOCOL_COMMAND
{
    [NativeTypeName("DWORD")]
    public uint Version;

    [NativeTypeName("DWORD")]
    public uint Length;
    public STORAGE_PROTOCOL_TYPE ProtocolType;

    [NativeTypeName("DWORD")]
    public uint Flags;

    [NativeTypeName("DWORD")]
    public uint ReturnStatus;

    [NativeTypeName("DWORD")]
    public uint ErrorCode;

    [NativeTypeName("DWORD")]
    public uint CommandLength;

    [NativeTypeName("DWORD")]
    public uint ErrorInfoLength;

    [NativeTypeName("DWORD")]
    public uint DataToDeviceTransferLength;

    [NativeTypeName("DWORD")]
    public uint DataFromDeviceTransferLength;

    [NativeTypeName("DWORD")]
    public uint TimeOutValue;

    [NativeTypeName("DWORD")]
    public uint ErrorInfoOffset;

    [NativeTypeName("DWORD")]
    public uint DataToDeviceBufferOffset;

    [NativeTypeName("DWORD")]
    public uint DataFromDeviceBufferOffset;

    [NativeTypeName("DWORD")]
    public uint CommandSpecific;

    [NativeTypeName("DWORD")]
    public uint Reserved0;

    [NativeTypeName("DWORD")]
    public uint FixedProtocolReturnData;

    [NativeTypeName("DWORD")]
    public uint FixedProtocolReturnData2;

    [NativeTypeName("DWORD[2]")]
    public _Reserved1_e__FixedBuffer Reserved1;

    [NativeTypeName("BYTE[1]")]
    public _Command_e__FixedBuffer Command;

    [InlineArray(2)]
    public partial struct _Reserved1_e__FixedBuffer
    {
        public uint e0;
    }

    public partial struct _Command_e__FixedBuffer
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
