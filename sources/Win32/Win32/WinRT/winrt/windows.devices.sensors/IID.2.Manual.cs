// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Win32;

public static unsafe partial class IID
{
    public static ref readonly Guid IID_IDetectedPerson
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x16,
                0x8c,
                0xc0,
                0xd9,
                0x3f,
                0x05,
                0x50,
                0x29,
                0xa0,
                0xbf,
                0xcd,
                0xca,
                0xb4,
                0xbe,
                0x3f,
                0x9e,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHeadOrientation
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x51,
                0x9f,
                0x54,
                0xa9,
                0x51,
                0x3e,
                0x55,
                0xe8,
                0x9c,
                0x35,
                0x3e,
                0x8d,
                0xa2,
                0x1d,
                0xee,
                0x69,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHeadPosition
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x58,
                0x5a,
                0xeb,
                0x65,
                0xcf,
                0x35,
                0x5e,
                0x6d,
                0xa7,
                0x6a,
                0x37,
                0xdb,
                0x13,
                0x1e,
                0x17,
                0xde,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHumanPresenceSensor3
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x96,
                0x3f,
                0x00,
                0x6d,
                0x09,
                0x0d,
                0x53,
                0x2c,
                0x9e,
                0xaf,
                0x80,
                0x3a,
                0x9f,
                0x69,
                0x28,
                0x5b,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHumanPresenceSensorReading3
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xb8,
                0x76,
                0xd9,
                0x18,
                0xf0,
                0x69,
                0x58,
                0x6f,
                0x90,
                0xe3,
                0x7c,
                0x6f,
                0xa5,
                0xc5,
                0xd3,
                0x3a,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
