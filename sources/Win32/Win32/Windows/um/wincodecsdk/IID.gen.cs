// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincodecsdk.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class IID
{
    public static ref readonly Guid IID_IWICMetadataBlockReader
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x8D,
                0x2A,
                0xAA,
                0xFE,
                0xF3,
                0xB3,
                0xE4,
                0x43,
                0xB2,
                0x5C,
                0xD1,
                0xDE,
                0x99,
                0x0A,
                0x1A,
                0xE1,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IWICMetadataBlockWriter
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x76,
                0x96,
                0xFB,
                0x08,
                0x44,
                0xB4,
                0xE8,
                0x41,
                0x8D,
                0xBE,
                0x6A,
                0x53,
                0xA5,
                0x42,
                0xBF,
                0xF1,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IWICMetadataReader
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x99,
                0xFE,
                0x04,
                0x92,
                0xFC,
                0xD8,
                0xD5,
                0x4F,
                0xA0,
                0x01,
                0x95,
                0x36,
                0xB0,
                0x67,
                0xA8,
                0x99,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IWICMetadataWriter
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x16,
                0x6E,
                0x83,
                0xF7,
                0xE0,
                0x3B,
                0x0B,
                0x47,
                0x86,
                0xBB,
                0x16,
                0x0D,
                0x0A,
                0xEC,
                0xD7,
                0xDE,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IWICStreamProvider
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xBC,
                0x94,
                0x94,
                0x44,
                0x68,
                0xB4,
                0x27,
                0x49,
                0x96,
                0xD7,
                0xBA,
                0x90,
                0xD3,
                0x1A,
                0xB5,
                0x05,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IWICPersistStream
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x40,
                0x50,
                0x67,
                0x00,
                0x08,
                0x69,
                0xF8,
                0x45,
                0x86,
                0xA3,
                0x49,
                0xC7,
                0xDF,
                0xD6,
                0xD9,
                0xAD,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IWICMetadataHandlerInfo
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xBF,
                0x58,
                0xA9,
                0xAB,
                0x72,
                0xC6,
                0xD1,
                0x44,
                0x8D,
                0x61,
                0xCE,
                0x6D,
                0xF2,
                0xE6,
                0x82,
                0xC2,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IWICMetadataReaderInfo
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x5B,
                0x1F,
                0xBF,
                0xEE,
                0xC1,
                0x07,
                0x47,
                0x44,
                0xA3,
                0xAB,
                0x22,
                0xAC,
                0xAF,
                0x78,
                0xA8,
                0x04,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IWICMetadataWriterInfo
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xBA,
                0x3F,
                0x2E,
                0xB2,
                0x25,
                0x39,
                0x23,
                0x43,
                0xB5,
                0xC1,
                0x9E,
                0xBF,
                0xC4,
                0x30,
                0xF2,
                0x36,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IWICComponentFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x3A,
                0x0C,
                0x2D,
                0x41,
                0x50,
                0x96,
                0xFA,
                0x44,
                0xAF,
                0x5B,
                0xDD,
                0x2A,
                0x06,
                0xC8,
                0xE8,
                0xFB,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
