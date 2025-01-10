// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from dia2.h in the Debug Interface Access SDK
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class IID
{
    public static ref readonly Guid IID_IDiaLoadCallback
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x82,
                0xDB,
                0x2A,
                0xC3,
                0xF4,
                0x73,
                0x1B,
                0x42,
                0x95,
                0xD5,
                0xA4,
                0x70,
                0x6E,
                0xDF,
                0x5D,
                0xBE,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDiaLoadCallback2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x74,
                0xA0,
                0x88,
                0x46,
                0x4D,
                0x5A,
                0x86,
                0x44,
                0xAE,
                0xA8,
                0x7B,
                0x90,
                0x71,
                0x1D,
                0x9F,
                0x7C,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDiaReadExeAtOffsetCallback
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x1C,
                0x46,
                0x7A,
                0x58,
                0x0B,
                0xB8,
                0x54,
                0x4F,
                0x91,
                0x94,
                0x50,
                0x32,
                0x58,
                0x9A,
                0x63,
                0x19,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDiaReadExeAtRVACallback
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xCA,
                0x80,
                0x3F,
                0x8E,
                0x17,
                0x75,
                0x2A,
                0x43,
                0xBA,
                0x07,
                0x28,
                0x51,
                0x34,
                0xAA,
                0xEA,
                0x8E,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDiaDataSource
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x5F,
                0xBB,
                0xF1,
                0x79,
                0x6E,
                0xB6,
                0xE5,
                0x48,
                0xB6,
                0xA9,
                0x15,
                0x45,
                0xC3,
                0x23,
                0xCA,
                0x3D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDiaDataSourceEx
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x69,
                0xEB,
                0x21,
                0x1A,
                0x2A,
                0x96,
                0xC4,
                0x4B,
                0x8B,
                0xD3,
                0x68,
                0x17,
                0x97,
                0xD3,
                0x8B,
                0x23,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDiaEnumSymbols
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x48,
                0x2C,
                0xB7,
                0xCA,
                0x3B,
                0x44,
                0xF5,
                0x48,
                0x9B,
                0x0B,
                0x42,
                0xF0,
                0x82,
                0x0A,
                0xB2,
                0x9A,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDiaEnumSymbolsByAddr
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x9C,
                0x7D,
                0x4B,
                0x62,
                0xEA,
                0x24,
                0x21,
                0x44,
                0x9D,
                0x06,
                0x3B,
                0x57,
                0x74,
                0x71,
                0xC1,
                0xFA,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDiaEnumSymbolsByAddr2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x02,
                0xBD,
                0x45,
                0x1E,
                0x45,
                0xBE,
                0x71,
                0x4D,
                0xBA,
                0x32,
                0x0E,
                0x57,
                0x6C,
                0xFC,
                0xD5,
                0x9F,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDiaEnumSourceFiles
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD9,
                0xDB,
                0xF3,
                0x10,
                0x4F,
                0x66,
                0x69,
                0x44,
                0xB8,
                0x08,
                0x94,
                0x71,
                0xC7,
                0xA5,
                0x05,
                0x38,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDiaEnumInputAssemblyFiles
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x53,
                0xF6,
                0x7F,
                0x1C,
                0xF7,
                0x51,
                0x7E,
                0x45,
                0x84,
                0x19,
                0xB2,
                0x0F,
                0x57,
                0xEF,
                0x7E,
                0x4D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDiaEnumLineNumbers
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x78,
                0xE8,
                0x30,
                0xFE,
                0xAC,
                0x54,
                0xF1,
                0x44,
                0x81,
                0xBA,
                0x39,
                0xDE,
                0x94,
                0x0F,
                0x60,
                0x52,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDiaEnumInjectedSources
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x73,
                0x25,
                0x61,
                0xD5,
                0x25,
                0x69,
                0x68,
                0x44,
                0x88,
                0x83,
                0x98,
                0xCD,
                0xEC,
                0x8C,
                0x38,
                0x4A,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDiaEnumSegments
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA9,
                0x8C,
                0x36,
                0xE8,
                0xD1,
                0x01,
                0x9D,
                0x41,
                0xAC,
                0x0C,
                0xE3,
                0x12,
                0x35,
                0xDB,
                0xDA,
                0x9F,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDiaEnumSectionContribs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB2,
                0xDE,
                0x94,
                0x19,
                0x82,
                0x2C,
                0x1D,
                0x4B,
                0xA5,
                0x7F,
                0xAF,
                0xF4,
                0x24,
                0xD5,
                0x4A,
                0x68,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDiaEnumFrameData
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x4B,
                0x7A,
                0xC7,
                0x9F,
                0x1C,
                0x3C,
                0xED,
                0x44,
                0xA7,
                0x98,
                0x6C,
                0x1D,
                0xEE,
                0xA5,
                0x3E,
                0x1F,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDiaEnumDebugStreamData
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE8,
                0x43,
                0x69,
                0x48,
                0x87,
                0xD1,
                0x6B,
                0x4A,
                0xA3,
                0xC4,
                0x29,
                0x12,
                0x59,
                0xFF,
                0xF6,
                0x0D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDiaEnumDebugStreams
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x1E,
                0xB4,
                0xCB,
                0x08,
                0xA6,
                0x47,
                0x87,
                0x4F,
                0x92,
                0xF1,
                0x1C,
                0x9C,
                0x87,
                0xCE,
                0xD0,
                0x44,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDiaAddressMap
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x7A,
                0x2E,
                0x2A,
                0xB6,
                0x7A,
                0x06,
                0xA3,
                0x4E,
                0xB5,
                0x98,
                0x04,
                0xC0,
                0x97,
                0x17,
                0x50,
                0x2C,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDiaSession
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE1,
                0x9E,
                0x60,
                0x2F,
                0xC8,
                0xD1,
                0x24,
                0x4E,
                0x82,
                0x88,
                0x33,
                0x26,
                0xBA,
                0xDC,
                0xD2,
                0x11,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDiaSessionEx
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD5,
                0xEE,
                0x24,
                0xCD,
                0xEA,
                0x5F,
                0x42,
                0x47,
                0xA3,
                0x20,
                0x62,
                0x54,
                0xC9,
                0x20,
                0xE7,
                0x8B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDiaSymbol
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x2F,
                0x7B,
                0x78,
                0xCB,
                0x6C,
                0xBD,
                0x35,
                0x46,
                0xBA,
                0x52,
                0x93,
                0x31,
                0x26,
                0xBD,
                0x2D,
                0xCD,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDiaSymbol2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xCD,
                0x86,
                0x1E,
                0x61,
                0xD1,
                0xB7,
                0x46,
                0x45,
                0x8A,
                0x15,
                0x07,
                0x0E,
                0x2B,
                0x07,
                0xA4,
                0x27,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDiaSymbol3
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF7,
                0x65,
                0xB6,
                0x99,
                0xB2,
                0xC1,
                0xD3,
                0x49,
                0x89,
                0xB2,
                0xA3,
                0x84,
                0x36,
                0x1A,
                0xCA,
                0xB5,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDiaSymbol4
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA7,
                0x88,
                0x6C,
                0xBF,
                0xD6,
                0xE9,
                0x46,
                0x43,
                0x99,
                0xA1,
                0xD0,
                0x53,
                0xDE,
                0x5A,
                0x78,
                0x08,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDiaSymbol5
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x00,
                0xDE,
                0xE2,
                0xAB,
                0x2D,
                0xDC,
                0x93,
                0x47,
                0xAF,
                0x9A,
                0xEF,
                0x1D,
                0x90,
                0x83,
                0x26,
                0x44,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDiaSymbol6
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD3,
                0xDA,
                0x33,
                0x81,
                0xFE,
                0x75,
                0x34,
                0x42,
                0xAC,
                0x7E,
                0xF8,
                0xE7,
                0xA1,
                0xD3,
                0xCB,
                0xB3,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDiaSymbol7
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD5,
                0x6C,
                0xCE,
                0x64,
                0x15,
                0x73,
                0x28,
                0x43,
                0x86,
                0xD6,
                0x10,
                0xE3,
                0x03,
                0xE0,
                0x10,
                0xB4,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDiaSymbol8
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x1F,
                0x04,
                0x2E,
                0x7F,
                0x94,
                0x12,
                0xBD,
                0x41,
                0xB8,
                0x3A,
                0xE7,
                0x15,
                0x97,
                0x2D,
                0x2C,
                0xE3,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDiaSymbol9
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x69,
                0x59,
                0x9E,
                0xA8,
                0xA1,
                0x92,
                0x8A,
                0x4F,
                0xB7,
                0x04,
                0x00,
                0x12,
                0x1C,
                0x37,
                0xAB,
                0xBB,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDiaSymbol10
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x0B,
                0xA7,
                0x34,
                0x90,
                0xB7,
                0xB0,
                0x05,
                0x46,
                0x8A,
                0x97,
                0x33,
                0x77,
                0x2F,
                0x3A,
                0x7B,
                0x8C,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDiaSymbol11
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xCD,
                0x4F,
                0xF5,
                0xB6,
                0xE3,
                0x05,
                0x3D,
                0x43,
                0xB3,
                0x05,
                0xB0,
                0xC1,
                0x43,
                0x7D,
                0x2D,
                0x16,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDiaSourceFile
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x53,
                0x53,
                0xEF,
                0xA2,
                0xA8,
                0xF5,
                0xB3,
                0x4E,
                0x90,
                0xD2,
                0xCB,
                0x52,
                0x6A,
                0xCB,
                0x3C,
                0xDD,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDiaInputAssemblyFile
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB0,
                0x56,
                0xFE,
                0x3B,
                0x0C,
                0x39,
                0x63,
                0x48,
                0x94,
                0x30,
                0x1F,
                0x3D,
                0x08,
                0x3B,
                0x76,
                0x84,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDiaLineNumber
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x14,
                0xEB,
                0x88,
                0xB3,
                0x4D,
                0xBE,
                0x1D,
                0x42,
                0xA8,
                0xA1,
                0x6C,
                0xF7,
                0xAB,
                0x05,
                0x70,
                0x86,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDiaSectionContrib
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x0E,
                0xB6,
                0xF4,
                0x0C,
                0xB1,
                0x35,
                0x6C,
                0x4C,
                0xBD,
                0xD8,
                0x85,
                0x4B,
                0x9C,
                0x8E,
                0x38,
                0x57,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDiaSegment
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x84,
                0xB7,
                0x75,
                0x07,
                0x5B,
                0xC7,
                0x49,
                0x44,
                0x84,
                0x8B,
                0xB7,
                0xBD,
                0x31,
                0x59,
                0x54,
                0x5B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDiaInjectedSource
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xDC,
                0x5C,
                0x60,
                0xAE,
                0x05,
                0x81,
                0x23,
                0x4A,
                0xB7,
                0x10,
                0x32,
                0x59,
                0xF1,
                0xE2,
                0x61,
                0x12,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDiaStackWalkFrame
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC1,
                0x90,
                0xC5,
                0x07,
                0x8D,
                0x43,
                0x47,
                0x4F,
                0xBD,
                0xCD,
                0x43,
                0x97,
                0xBC,
                0x81,
                0xAD,
                0x75,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDiaFrameData
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB7,
                0x84,
                0x91,
                0xA3,
                0x36,
                0x6A,
                0xDE,
                0x42,
                0x8E,
                0xEC,
                0x7D,
                0xF9,
                0xF3,
                0xF5,
                0x9F,
                0x33,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDiaImageData
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD2,
                0x0E,
                0xE4,
                0xC8,
                0xD9,
                0xA1,
                0x21,
                0x42,
                0x86,
                0x92,
                0x3C,
                0xE6,
                0x61,
                0x18,
                0x4B,
                0x44,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDiaTable
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x77,
                0xFB,
                0x59,
                0x4A,
                0xAC,
                0xAB,
                0x9B,
                0x46,
                0xA3,
                0x0B,
                0x9E,
                0xCC,
                0x85,
                0xBF,
                0xEF,
                0x14,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDiaEnumTables
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x0A,
                0x2B,
                0x5C,
                0xC6,
                0x50,
                0x11,
                0x7A,
                0x4D,
                0xAF,
                0xCC,
                0xE0,
                0x5B,
                0xF3,
                0xDE,
                0xE8,
                0x1E,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDiaEnumSourceLink
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB3,
                0x1E,
                0xCD,
                0x45,
                0x6C,
                0x5C,
                0xE3,
                0x43,
                0xB2,
                0x0A,
                0xA4,
                0xD8,
                0x03,
                0x5D,
                0xE4,
                0xE2,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDiaEnumSourceLink2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x51,
                0x81,
                0x6D,
                0x13,
                0xE7,
                0xAD,
                0x04,
                0x47,
                0xAF,
                0x13,
                0x32,
                0x40,
                0x80,
                0x76,
                0x2E,
                0x8F,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDiaPropertyStorage
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x9C,
                0x6F,
                0x41,
                0x9D,
                0x84,
                0xE1,
                0xB2,
                0x45,
                0xA4,
                0xF0,
                0xCE,
                0x51,
                0x7F,
                0x71,
                0x9E,
                0x9B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDiaStackFrame
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x6D,
                0xC9,
                0xDB,
                0x5E,
                0xD6,
                0xCD,
                0x92,
                0x47,
                0xAF,
                0xBE,
                0xCC,
                0x89,
                0x00,
                0x7D,
                0x96,
                0x10,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDiaEnumStackFrames
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x1D,
                0x46,
                0x9D,
                0xEC,
                0x74,
                0xCE,
                0x11,
                0x47,
                0xA0,
                0x20,
                0x7D,
                0x8F,
                0x9A,
                0x1D,
                0xD2,
                0x55,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDiaStackWalkHelper
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x1B,
                0x1B,
                0xF8,
                0x21,
                0xBB,
                0xC5,
                0xA3,
                0x42,
                0xBC,
                0x4F,
                0xCC,
                0xBA,
                0xA7,
                0x5B,
                0x9F,
                0x19,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDiaStackWalker
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x6B,
                0x21,
                0x85,
                0x54,
                0x4C,
                0xA5,
                0x9F,
                0x46,
                0x96,
                0x70,
                0x52,
                0xB2,
                0x4D,
                0x52,
                0x29,
                0xBB,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDiaStackWalkHelper2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x90,
                0xC4,
                0x22,
                0x82,
                0x7B,
                0x50,
                0xEF,
                0x4B,
                0xB3,
                0xBD,
                0x41,
                0xDC,
                0xA7,
                0xB5,
                0x93,
                0x4C,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDiaStackWalker2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x85,
                0x58,
                0x18,
                0x7C,
                0x15,
                0xA0,
                0xAC,
                0x4C,
                0x94,
                0x11,
                0x0F,
                0x4F,
                0xB3,
                0x9B,
                0x1F,
                0x3A,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
