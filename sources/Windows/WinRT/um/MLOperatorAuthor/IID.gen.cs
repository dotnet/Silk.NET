// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MLOperatorAuthor.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;

public static partial class IID
{
    public static ref readonly Guid IID_IMLOperatorAttributes
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x59, 0x17, 0x1B, 0x4B,
                0x40, 0xEC,
                0x6C, 0x46,
                0xAA,
                0xB4,
                0xBE,
                0xB5,
                0x34,
                0x7F,
                0xD2,
                0x4C
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMLOperatorTensorShapeDescription
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xBE, 0x8C, 0x0E, 0xF2,
                0x28, 0x3B,
                0x48, 0x42,
                0xBE,
                0x95,
                0xF9,
                0x6F,
                0xBC,
                0x6E,
                0x46,
                0x43
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMLOperatorKernelCreationContext
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x3D, 0xB5, 0x59, 0x54,
                0xFC, 0xA0,
                0x65, 0x46,
                0xAD,
                0xDD,
                0x70,
                0x17,
                0x1E,
                0xF7,
                0xE6,
                0x31
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMLOperatorTensor
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x41, 0x1F, 0xE4, 0x7F,
                0x30, 0xF4,
                0x0E, 0x44,
                0xAE,
                0xCE,
                0x54,
                0x41,
                0x6D,
                0xC8,
                0xB9,
                0xDB
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMLOperatorKernelContext
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x28, 0x6A, 0x53, 0x82,
                0x22, 0xF0,
                0x69, 0x47,
                0x9D,
                0x3F,
                0x8B,
                0x27,
                0x8F,
                0x84,
                0xC0,
                0xC3
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMLOperatorKernel
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xA0, 0xB4, 0xC4, 0x11,
                0x67, 0xB4,
                0xAA, 0x4E,
                0xA1,
                0xA6,
                0xB9,
                0x61,
                0xD8,
                0xD0,
                0xED,
                0x79
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMLOperatorShapeInferenceContext
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x29, 0x6B, 0x5B, 0x10,
                0x08, 0x54,
                0x68, 0x4A,
                0x99,
                0x59,
                0x09,
                0xB5,
                0x95,
                0x5A,
                0x34,
                0x92
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMLOperatorTypeInferenceContext
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xB1, 0x3B, 0x89, 0xEC,
                0x38, 0xF9,
                0x7B, 0x42,
                0x84,
                0x88,
                0xC8,
                0xDC,
                0xF7,
                0x75,
                0xF1,
                0x38
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMLOperatorTypeInferrer
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x48, 0xEB, 0x1A, 0x78,
                0xCB, 0x9B,
                0x97, 0x47,
                0xBF,
                0x77,
                0x8B,
                0xF4,
                0x55,
                0x21,
                0x7B,
                0xEB
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMLOperatorShapeInferrer
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xBE, 0xE5, 0x0B, 0x54,
                0xC9, 0xA6,
                0xEE, 0x40,
                0x83,
                0xF6,
                0xD2,
                0xB8,
                0xB4,
                0x0A,
                0x77,
                0x98
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMLOperatorKernelFactory
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x6F, 0xAD, 0x15, 0xEF,
                0xC9, 0x0D,
                0x08, 0x49,
                0xAB,
                0x35,
                0xA5,
                0x75,
                0xA3,
                0x0D,
                0xFB,
                0xF8
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMLOperatorRegistry
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x2D, 0xDD, 0xF9, 0x2A,
                0x16, 0xB5,
                0x72, 0x46,
                0x9A,
                0xB5,
                0x53,
                0x0C,
                0x20,
                0x84,
                0x93,
                0xAD
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
