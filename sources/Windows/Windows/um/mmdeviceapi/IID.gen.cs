// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mmdeviceapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;
public static partial class IID
{
    public static ref readonly Guid IID_IMMNotificationClient
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xC9,
                0xEE,
                0x91,
                0x79,
                0x89,
                0x7E,
                0x85,
                0x4D,
                0x83,
                0x90,
                0x6C,
                0x70,
                0x3C,
                0xEC,
                0x60,
                0xC0
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMMDevice
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x3F,
                0x06,
                0x66,
                0xD6,
                0x87,
                0x15,
                0x43,
                0x4E,
                0x81,
                0xF1,
                0xB9,
                0x48,
                0xE8,
                0x07,
                0x36,
                0x3F
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMMDeviceCollection
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xBE,
                0xA1,
                0xD7,
                0x0B,
                0x1A,
                0x7A,
                0xDB,
                0x44,
                0x83,
                0x97,
                0xCC,
                0x53,
                0x92,
                0x38,
                0x7B,
                0x5E
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMMEndpoint
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x88,
                0x97,
                0xE0,
                0x1B,
                0x94,
                0x68,
                0x89,
                0x40,
                0x85,
                0x86,
                0x9A,
                0x2A,
                0x6C,
                0x26,
                0x5A,
                0xC5
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMMDeviceEnumerator
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xD2,
                0x64,
                0x56,
                0xA9,
                0x14,
                0x96,
                0x35,
                0x4F,
                0xA7,
                0x46,
                0xDE,
                0x8D,
                0xB6,
                0x36,
                0x17,
                0xE6
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMMDeviceActivator
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xA4,
                0x0E,
                0x0D,
                0x3B,
                0xA9,
                0xD0,
                0x0E,
                0x4B,
                0x93,
                0x5B,
                0x09,
                0x51,
                0x67,
                0x46,
                0xFA,
                0xC0
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IActivateAudioInterfaceCompletionHandler
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xAB,
                0x49,
                0xD9,
                0x41,
                0x62,
                0x98,
                0x4A,
                0x44,
                0x80,
                0xF6,
                0xC2,
                0x61,
                0x33,
                0x4D,
                0xA5,
                0xEB
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IActivateAudioInterfaceAsyncOperation
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x78,
                0x2D,
                0xA2,
                0x72,
                0xE4,
                0xCD,
                0x1D,
                0x43,
                0xB8,
                0xCC,
                0x84,
                0x3A,
                0x71,
                0x19,
                0x9B,
                0x6D
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IAudioSystemEffectsPropertyChangeNotificationClient
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x40,
                0x9D,
                0x04,
                0x20,
                0xD5,
                0x56,
                0x0E,
                0x40,
                0xA2,
                0xEF,
                0x38,
                0x55,
                0x99,
                0xFE,
                0xED,
                0x49
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IAudioSystemEffectsPropertyStore
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xF9,
                0xE7,
                0x2A,
                0x30,
                0xE0,
                0xD7,
                0xE4,
                0x43,
                0x97,
                0x1B,
                0x1F,
                0x82,
                0x93,
                0x61,
                0x3D,
                0x2A
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}