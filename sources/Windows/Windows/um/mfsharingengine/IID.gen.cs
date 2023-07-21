// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfsharingengine.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;

public static partial class IID
{
    public static ref readonly Guid IID_IMFSharingEngineClassFactory
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x92, 0x1F, 0xA6, 0x2B,
                0x05, 0x83,
                0x3B, 0x41,
                0x97,
                0x33,
                0xFA,
                0xF1,
                0x5F,
                0x25,
                0x93,
                0x84
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFMediaSharingEngine
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xBF, 0xE1, 0x3C, 0x8D,
                0x67, 0x23,
                0xE0, 0x40,
                0x9E,
                0xEE,
                0x40,
                0xD3,
                0x77,
                0xCC,
                0x1B,
                0x46
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFMediaSharingEngineClassFactory
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xC4, 0x2B, 0x4D, 0x52,
                0xB1, 0xB2,
                0xE5, 0x4F,
                0x8F,
                0xAC,
                0xFA,
                0x4E,
                0x45,
                0x12,
                0xB4,
                0xE0
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFImageSharingEngine
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x8E, 0xAE, 0xA0, 0xCF,
                0x1C, 0x7E,
                0xD2, 0x44,
                0xAE,
                0x68,
                0xFC,
                0x4C,
                0x14,
                0x8A,
                0x63,
                0x54
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFImageSharingEngineClassFactory
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x27, 0x57, 0xC5, 0x1F,
                0xFB, 0xA7,
                0xC8, 0x4F,
                0x83,
                0xAE,
                0x8A,
                0xF0,
                0x24,
                0x99,
                0x0A,
                0xF1
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IPlayToControl
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xEB, 0x74, 0x75, 0x60,
                0xB6, 0xF4,
                0xC1, 0x45,
                0xB0,
                0x8C,
                0xCB,
                0x71,
                0x51,
                0x22,
                0x90,
                0x1D
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IPlayToControlWithCapabilities
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x0F, 0xD8, 0x9D, 0xAA,
                0x0A, 0xC5,
                0x20, 0x42,
                0x91,
                0xC1,
                0x33,
                0x22,
                0x87,
                0xF8,
                0x2A,
                0x34
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IPlayToSourceClassFactory
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xA3, 0x32, 0x2B, 0x84,
                0x9B, 0x9B,
                0x1C, 0x4D,
                0xB3,
                0xF3,
                0x49,
                0x19,
                0x32,
                0x48,
                0xA5,
                0x54
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
