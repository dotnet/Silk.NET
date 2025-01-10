// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dxcapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the University of Illinois Open Source License.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class IID
{
    public static ref readonly Guid IID_IDxcBlob
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x08,
                0xFB,
                0xA5,
                0x8B,
                0x95,
                0x51,
                0xE2,
                0x40,
                0xAC,
                0x58,
                0x0D,
                0x98,
                0x9C,
                0x3A,
                0x01,
                0x02,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDxcBlobEncoding
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x24,
                0xD4,
                0x41,
                0x72,
                0x46,
                0x26,
                0x91,
                0x41,
                0x97,
                0xC0,
                0x98,
                0xE9,
                0x6E,
                0x42,
                0xFC,
                0x68,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDxcBlobWide
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xAB,
                0x4E,
                0xF8,
                0xA3,
                0xAA,
                0x0F,
                0x7E,
                0x49,
                0xA3,
                0x9C,
                0xEE,
                0x6E,
                0xD6,
                0x0B,
                0x2D,
                0x84,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDxcBlobUtf8
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC9,
                0x36,
                0xA6,
                0x3D,
                0x71,
                0xBA,
                0x24,
                0x40,
                0xA3,
                0x01,
                0x30,
                0xCB,
                0xF1,
                0x25,
                0x30,
                0x5B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDxcIncludeHandler
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x7D,
                0xFC,
                0x61,
                0x7F,
                0x0D,
                0x95,
                0x7F,
                0x46,
                0xB3,
                0xE3,
                0x3C,
                0x02,
                0xFB,
                0x49,
                0x18,
                0x7C,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDxcCompilerArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x2A,
                0xFE,
                0xEF,
                0x73,
                0xDC,
                0x70,
                0xF8,
                0x45,
                0x96,
                0x90,
                0xEF,
                0xF6,
                0x4C,
                0x02,
                0x42,
                0x9D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDxcLibrary
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC7,
                0x4D,
                0x20,
                0xE5,
                0x8C,
                0xD1,
                0x3C,
                0x4C,
                0xBD,
                0xFB,
                0x85,
                0x16,
                0x73,
                0x98,
                0x0F,
                0xE7,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDxcOperationResult
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x4A,
                0x48,
                0xDB,
                0xCE,
                0xE9,
                0xD4,
                0x5A,
                0x44,
                0xB9,
                0x91,
                0xCA,
                0x21,
                0xCA,
                0x15,
                0x7D,
                0xC2,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDxcCompiler
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF3,
                0x0B,
                0x21,
                0x8C,
                0x1F,
                0x01,
                0x22,
                0x44,
                0x8D,
                0x70,
                0x6F,
                0x9A,
                0xCB,
                0x8D,
                0xB6,
                0x17,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDxcCompiler2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD9,
                0xA9,
                0x05,
                0xA0,
                0xBB,
                0xB8,
                0x94,
                0x45,
                0xB5,
                0xC9,
                0x0E,
                0x63,
                0x3B,
                0xEC,
                0x4D,
                0x37,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDxcLinker
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x2A,
                0xBE,
                0xB5,
                0xF1,
                0xDD,
                0x62,
                0x27,
                0x43,
                0xA1,
                0xC2,
                0x42,
                0xAC,
                0x1E,
                0x1E,
                0x78,
                0xE6,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDxcUtils
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xCB,
                0xC4,
                0x05,
                0x46,
                0x19,
                0x20,
                0x2A,
                0x49,
                0xAD,
                0xA4,
                0x65,
                0xF2,
                0x0B,
                0xB7,
                0xD6,
                0x7F,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDxcResult
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xDA,
                0x6C,
                0x34,
                0x58,
                0xE7,
                0xDD,
                0x97,
                0x44,
                0x94,
                0x61,
                0x6F,
                0x87,
                0xAF,
                0x5E,
                0x06,
                0x59,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDxcExtraOutputs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA2,
                0x37,
                0x9B,
                0x31,
                0xC2,
                0xA5,
                0x4A,
                0x49,
                0xA5,
                0xDE,
                0x48,
                0x01,
                0xB2,
                0xFA,
                0xF9,
                0x89,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDxcCompiler3
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x87,
                0x46,
                0x8B,
                0x22,
                0x6A,
                0x5A,
                0x30,
                0x47,
                0x90,
                0x0C,
                0x97,
                0x02,
                0xB2,
                0x20,
                0x3F,
                0x54,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDxcValidator
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD2,
                0x2B,
                0xE8,
                0xA6,
                0xD7,
                0x1F,
                0x26,
                0x48,
                0x98,
                0x11,
                0x28,
                0x57,
                0xE7,
                0x97,
                0xF4,
                0x9A,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDxcValidator2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD1,
                0x1F,
                0x8E,
                0x45,
                0xB2,
                0xB1,
                0x50,
                0x47,
                0xA6,
                0xE1,
                0x9C,
                0x10,
                0xF0,
                0x3B,
                0xED,
                0x92,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDxcContainerBuilder
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x50,
                0x1F,
                0x4B,
                0x33,
                0x92,
                0x22,
                0x35,
                0x4B,
                0x99,
                0xA1,
                0x25,
                0x58,
                0x8D,
                0x8C,
                0x17,
                0xFE,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDxcAssembler
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x26,
                0x7A,
                0x1F,
                0x09,
                0x1F,
                0x1C,
                0x48,
                0x49,
                0x90,
                0x4B,
                0xE6,
                0xE3,
                0xA8,
                0xA7,
                0x71,
                0xD5,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDxcContainerReflection
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x26,
                0x1B,
                0xC2,
                0xD2,
                0x50,
                0x83,
                0xDC,
                0x4B,
                0x97,
                0x6A,
                0x33,
                0x1C,
                0xE6,
                0xF4,
                0xC5,
                0x4C,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDxcOptimizerPass
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x9F,
                0xD7,
                0x2C,
                0xAE,
                0x22,
                0xCC,
                0x3F,
                0x45,
                0x9B,
                0x6B,
                0xB1,
                0x24,
                0xE7,
                0xA5,
                0x20,
                0x4C,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDxcOptimizer
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x2E,
                0x0E,
                0x74,
                0x25,
                0xBA,
                0x9C,
                0x1B,
                0x40,
                0x91,
                0x19,
                0x4F,
                0xB4,
                0x2F,
                0x39,
                0xF2,
                0x70,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDxcVersionInfo
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x50,
                0x5B,
                0x4F,
                0xB0,
                0x59,
                0x20,
                0x12,
                0x4F,
                0xA8,
                0xFF,
                0xA1,
                0xE0,
                0xCD,
                0xE1,
                0xCC,
                0x7E,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDxcVersionInfo2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC4,
                0x04,
                0x69,
                0xFB,
                0xF0,
                0x42,
                0x62,
                0x4B,
                0x9C,
                0x46,
                0x98,
                0x3A,
                0xF7,
                0xDA,
                0x7C,
                0x83,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDxcVersionInfo3
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x43,
                0xE8,
                0x13,
                0x5E,
                0x25,
                0x9D,
                0x3C,
                0x47,
                0x9A,
                0xD2,
                0x03,
                0xB2,
                0xD0,
                0xB4,
                0x4B,
                0x1E,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDxcPdbUtils
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x7E,
                0x64,
                0xC9,
                0xE6,
                0x6A,
                0x9D,
                0x3B,
                0x4C,
                0xB9,
                0x4C,
                0x52,
                0x4B,
                0x5A,
                0x6C,
                0x34,
                0x3D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDxcPdbUtils2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x38,
                0xD9,
                0x15,
                0x43,
                0x69,
                0xF3,
                0x93,
                0x4F,
                0x95,
                0xA2,
                0x25,
                0x20,
                0x17,
                0xCC,
                0x38,
                0x07,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
