// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfcaptureengine.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;
public static partial class IID
{
    public static ref readonly Guid IID_IMFCaptureEngineOnEventCallback
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xC0,
                0x51,
                0xDA,
                0xAE,
                0x25,
                0x90,
                0x83,
                0x49,
                0x90,
                0x12,
                0xDE,
                0x59,
                0x7B,
                0x88,
                0xB0,
                0x89
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFCaptureEngineOnSampleCallback
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x82,
                0x0B,
                0x15,
                0x52,
                0x39,
                0xAB,
                0x67,
                0x44,
                0x98,
                0x0F,
                0xE4,
                0x8B,
                0xF0,
                0x82,
                0x2E,
                0xCD
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFCaptureSink
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x5B,
                0x13,
                0xD6,
                0x72,
                0xE9,
                0x35,
                0x2C,
                0x41,
                0xB9,
                0x26,
                0xFD,
                0x52,
                0x65,
                0xF2,
                0xA8,
                0x85
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFCaptureRecordSink
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x5A,
                0xB5,
                0x23,
                0x33,
                0x2A,
                0xF9,
                0xE2,
                0x4F,
                0x8E,
                0xDC,
                0xE9,
                0xBF,
                0xC0,
                0x63,
                0x4D,
                0x77
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFCapturePreviewSink
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xFD,
                0x6C,
                0x34,
                0x77,
                0x49,
                0x5B,
                0x73,
                0x4D,
                0xAC,
                0xE0,
                0x5B,
                0x52,
                0xA8,
                0x59,
                0xF2,
                0xE0
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFCapturePhotoSink
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xC8,
                0x3C,
                0xD4,
                0xD2,
                0xBB,
                0x48,
                0xA7,
                0x4A,
                0x95,
                0xDB,
                0x10,
                0xC0,
                0x69,
                0x77,
                0xE7,
                0x77
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFCaptureSource
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xA8,
                0x42,
                0x9A,
                0x43,
                0x2C,
                0x0D,
                0x05,
                0x45,
                0xBE,
                0x83,
                0xF7,
                0x9B,
                0x2A,
                0x05,
                0xD5,
                0xC4
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFCaptureEngine
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x33,
                0xA4,
                0xBB,
                0xA6,
                0x6B,
                0x17,
                0xB2,
                0x48,
                0xB3,
                0x75,
                0x53,
                0xAA,
                0x03,
                0x47,
                0x32,
                0x07
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFCaptureEngineClassFactory
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x40,
                0xD1,
                0x02,
                0x8F,
                0xFC,
                0x56,
                0x02,
                0x43,
                0xA7,
                0x05,
                0x3A,
                0x97,
                0xC7,
                0x8B,
                0xE7,
                0x79
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFCaptureEngineOnSampleCallback2
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xD7,
                0xEE,
                0x7C,
                0xE3,
                0x0F,
                0x34,
                0x14,
                0x45,
                0x9F,
                0x4D,
                0x9C,
                0x2A,
                0xE0,
                0x26,
                0x10,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFCaptureSink2
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x9E,
                0x21,
                0xE4,
                0xF9,
                0x97,
                0x61,
                0x5E,
                0x4B,
                0xB8,
                0x88,
                0xBE,
                0xE3,
                0x10,
                0xAB,
                0x2C,
                0x59
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}