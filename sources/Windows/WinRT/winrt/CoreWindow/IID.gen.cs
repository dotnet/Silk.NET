// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/CoreWindow.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;
public static partial class IID
{
    public static ref readonly Guid IID_ICoreWindowInterop
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x29,
                0x4A,
                0xD6,
                0x45,
                0x3E,
                0xA6,
                0xB6,
                0x4C,
                0xB4,
                0x98,
                0x57,
                0x81,
                0xD2,
                0x98,
                0xCB,
                0x4F
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ICoreInputInterop
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xE3,
                0xE3,
                0xBF,
                0x40,
                0x5A,
                0xB7,
                0x79,
                0x44,
                0xAC,
                0x96,
                0x47,
                0x53,
                0x65,
                0x74,
                0x9B,
                0xB8
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ICoreWindowComponentInterop
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x31,
                0xAB,
                0x76,
                0x05,
                0x10,
                0xA3,
                0x40,
                0x4C,
                0xBA,
                0x31,
                0xFD,
                0x37,
                0xE0,
                0x29,
                0x8D,
                0xFA
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ICoreWindowAdapterInterop
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xD1,
                0x6F,
                0x5B,
                0x7A,
                0x73,
                0xCD,
                0x6C,
                0x4B,
                0x9C,
                0xF4,
                0x2E,
                0x86,
                0x9E,
                0xAF,
                0x47,
                0x0A
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}