// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.power.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;

public static unsafe partial class IID
{
    public static ref readonly Guid IID_IBattery
    {
        get
        {
            ReadOnlySpan<byte> data = [
                0xC6, 0x4F, 0x89, 0xBC,
                0x72, 0x00,
                0xC8, 0x47,
                0x8B,
                0x5D,
                0x61,
                0x4A,
                0xAA,
                0x7A,
                0x43,
                0x7E
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IBatteryReport
    {
        get
        {
            ReadOnlySpan<byte> data = [
                0x3A, 0x8C, 0x85, 0xC9,
                0x13, 0x4E,
                0x0A, 0x42,
                0xA8,
                0xD0,
                0x24,
                0xF1,
                0x8F,
                0x39,
                0x54,
                0x01
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IBatteryStatics
    {
        get
        {
            ReadOnlySpan<byte> data = [
                0xB6, 0x72, 0xCD, 0x79,
                0x5E, 0x9E,
                0x52, 0x44,
                0xBE,
                0xA6,
                0xDF,
                0xCD,
                0x54,
                0x1E,
                0x59,
                0x7F
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IPowerGridData
    {
        get
        {
            ReadOnlySpan<byte> data = [
                0x17, 0xFB, 0x60, 0xC3,
                0x92, 0xFC,
                0x6E, 0x5F,
                0x99,
                0x9D,
                0x16,
                0xA4,
                0xCF,
                0x9D,
                0x6C,
                0x40
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IPowerGridForecast
    {
        get
        {
            ReadOnlySpan<byte> data = [
                0xE9, 0x4D, 0x7E, 0x07,
                0x60, 0xED,
                0xBB, 0x58,
                0xA8,
                0x50,
                0x00,
                0x3C,
                0x6A,
                0x13,
                0x86,
                0x85
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IPowerGridForecastStatics
    {
        get
        {
            ReadOnlySpan<byte> data = [
                0x06, 0xC8, 0x78, 0x5B,
                0x4E, 0x2E,
                0xCC, 0x5B,
                0xBB,
                0x34,
                0xCB,
                0x81,
                0xC6,
                0x0F,
                0x9E,
                0x12
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
