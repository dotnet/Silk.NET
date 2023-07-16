// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/windows.media.core.interop.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;
public static partial class IID
{
    public static ref readonly Guid IID_IAudioFrameNative
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x2E,
                0x1E,
                0xBE,
                0x20,
                0x0F,
                0x93,
                0x46,
                0x47,
                0x93,
                0x35,
                0x3C,
                0x33,
                0x2F,
                0x25,
                0x50,
                0x93
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IVideoFrameNative
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x2B,
                0x70,
                0xBA,
                0x26,
                0x4A,
                0x31,
                0x20,
                0x46,
                0xAA,
                0xF6,
                0x7A,
                0x51,
                0xAA,
                0x58,
                0xFA,
                0x18
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IAudioFrameNativeFactory
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xF8,
                0x7C,
                0xD6,
                0x7B,
                0x7D,
                0xBF,
                0xE6,
                0x43,
                0xAF,
                0x8D,
                0xB1,
                0x70,
                0xEE,
                0x0C,
                0x01,
                0x10
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IVideoFrameNativeFactory
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x3E,
                0x69,
                0xE3,
                0x69,
                0x1E,
                0x8E,
                0x63,
                0x4E,
                0xAC,
                0x4C,
                0x7F,
                0xDC,
                0x21,
                0xD9,
                0x73,
                0x1D
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}