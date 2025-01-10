// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/audiopolicy.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class IID
{
    public static ref readonly Guid IID_IAudioSessionEvents
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xCC,
                0x8A,
                0x91,
                0x24,
                0xB3,
                0x64,
                0xC1,
                0x37,
                0x8C,
                0xA9,
                0x74,
                0xA6,
                0x6E,
                0x99,
                0x57,
                0xA8,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAudioSessionControl
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x99,
                0xA5,
                0xB1,
                0xF4,
                0x66,
                0x72,
                0x19,
                0x43,
                0xA8,
                0xCA,
                0xE7,
                0x0A,
                0xCB,
                0x11,
                0xE8,
                0xCD,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAudioSessionControl2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x88,
                0xFF,
                0xB7,
                0xBF,
                0x39,
                0x72,
                0xC9,
                0x4F,
                0x8F,
                0xA2,
                0x07,
                0xC9,
                0x50,
                0xBE,
                0x9C,
                0x6D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAudioSessionManager
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF1,
                0x71,
                0xA9,
                0xBF,
                0x5E,
                0x4D,
                0xBB,
                0x40,
                0x93,
                0x5E,
                0x96,
                0x70,
                0x39,
                0xBF,
                0xBE,
                0xE4,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAudioVolumeDuckNotification
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD4,
                0x84,
                0xB2,
                0xC3,
                0x39,
                0x6D,
                0x59,
                0x43,
                0xB3,
                0xCF,
                0xB5,
                0x6D,
                0xDB,
                0x3B,
                0xB3,
                0x9C,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAudioSessionNotification
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x0B,
                0xD2,
                0x1D,
                0x64,
                0x41,
                0x4D,
                0xCC,
                0x49,
                0xAB,
                0xA3,
                0x17,
                0x4B,
                0x94,
                0x77,
                0xBB,
                0x08,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAudioSessionEnumerator
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x11,
                0xBB,
                0xF5,
                0xE2,
                0x70,
                0x05,
                0xCA,
                0x40,
                0xAC,
                0xDD,
                0x3A,
                0xA0,
                0x12,
                0x77,
                0xDE,
                0xE8,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAudioSessionManager2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA0,
                0x99,
                0xAA,
                0x77,
                0xD6,
                0x1B,
                0x4F,
                0x48,
                0x8B,
                0xC7,
                0x2C,
                0x65,
                0x4C,
                0x9A,
                0x9B,
                0x6F,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
