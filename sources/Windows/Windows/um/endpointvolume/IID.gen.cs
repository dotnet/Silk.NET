// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/endpointvolume.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;
public static partial class IID
{
    public static ref readonly Guid IID_IAudioEndpointVolumeCallback
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xFA,
                0x04,
                0x78,
                0x65,
                0xAD,
                0xD6,
                0x96,
                0x44,
                0x8A,
                0x60,
                0x35,
                0x27,
                0x52,
                0xAF,
                0x4F,
                0x89
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IAudioEndpointVolume
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x82,
                0x2C,
                0xDF,
                0x5C,
                0x1E,
                0x84,
                0x46,
                0x45,
                0x97,
                0x22,
                0x0C,
                0xF7,
                0x40,
                0x78,
                0x22,
                0x9A
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IAudioEndpointVolumeEx
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x84,
                0x17,
                0xE1,
                0x66,
                0x95,
                0xF6,
                0x28,
                0x4F,
                0xA5,
                0x05,
                0xA7,
                0x08,
                0x00,
                0x81,
                0xA7,
                0x8F
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IAudioMeterInformation
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xF6,
                0x16,
                0x22,
                0xC0,
                0x67,
                0x8C,
                0x5B,
                0x4B,
                0x9D,
                0x00,
                0xD0,
                0x08,
                0xE7,
                0x3E,
                0x00,
                0x64
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}