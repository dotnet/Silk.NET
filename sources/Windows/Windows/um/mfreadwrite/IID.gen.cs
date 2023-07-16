// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfreadwrite.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;
public static partial class IID
{
    public static ref readonly Guid IID_IMFReadWriteClassFactory
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x12,
                0x2E,
                0xFE,
                0xE7,
                0x1C,
                0x66,
                0xDA,
                0x40,
                0x92,
                0xF9,
                0x4F,
                0x00,
                0x2A,
                0xB6,
                0x76,
                0x27
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFSourceReader
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xF2,
                0x66,
                0xAE,
                0x70,
                0x09,
                0xC8,
                0x4F,
                0x4E,
                0x89,
                0x15,
                0xBD,
                0xCB,
                0x40,
                0x6B,
                0x79,
                0x93
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFSourceReaderEx
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xF0,
                0x1C,
                0x98,
                0x7B,
                0x0E,
                0x56,
                0x16,
                0x41,
                0x98,
                0x75,
                0xB0,
                0x99,
                0x89,
                0x5F,
                0x23,
                0xD7
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFSourceReaderCallback
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x99,
                0x8D,
                0xEC,
                0xDE,
                0x1D,
                0xFA,
                0x82,
                0x4D,
                0x84,
                0xC2,
                0x2C,
                0x89,
                0x69,
                0x94,
                0x48,
                0x67
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFSourceReaderCallback2
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xE6,
                0x9F,
                0x83,
                0xCF,
                0x2A,
                0x8C,
                0xD2,
                0x4D,
                0xB6,
                0xEA,
                0xC2,
                0x2D,
                0x69,
                0x61,
                0xAF,
                0x05
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFSinkWriter
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xCD,
                0xF1,
                0x37,
                0x31,
                0x5E,
                0xFE,
                0x05,
                0x48,
                0xA5,
                0xD8,
                0xFB,
                0x47,
                0x74,
                0x48,
                0xCB,
                0x3D
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFSinkWriterEx
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xAB,
                0x72,
                0x8D,
                0x58,
                0xC1,
                0x5B,
                0x6A,
                0x49,
                0x87,
                0x14,
                0xB7,
                0x06,
                0x17,
                0x14,
                0x1B,
                0x25
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFSinkWriterEncoderConfig
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x9E,
                0x77,
                0xC3,
                0x17,
                0xDE,
                0x3C,
                0xDE,
                0x4E,
                0x8C,
                0x60,
                0x38,
                0x99,
                0xF5,
                0xF5,
                0x3A,
                0xD6
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFSinkWriterCallback
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xDE,
                0x76,
                0x6F,
                0x66,
                0xD2,
                0x33,
                0xB9,
                0x41,
                0xA4,
                0x58,
                0x29,
                0xED,
                0x0A,
                0x97,
                0x2C,
                0x58
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFSinkWriterCallback2
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x58,
                0xBD,
                0x56,
                0x24,
                0x67,
                0xC0,
                0x13,
                0x45,
                0x84,
                0xFE,
                0x8D,
                0x0C,
                0x88,
                0xFF,
                0xDC,
                0x61
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}