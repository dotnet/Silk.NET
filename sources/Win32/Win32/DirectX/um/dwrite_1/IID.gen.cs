// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dwrite_1.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class IID
{
    public static ref readonly Guid IID_IDWriteFactory1
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x99,
                0x2F,
                0x57,
                0x30,
                0xC6,
                0xDA,
                0xDB,
                0x41,
                0xA1,
                0x6E,
                0x04,
                0x86,
                0x30,
                0x7E,
                0x60,
                0x6A,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDWriteFontFace1
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB4,
                0xFD,
                0x1E,
                0xA7,
                0xDB,
                0x9F,
                0x38,
                0x48,
                0xAD,
                0x90,
                0xCF,
                0xC3,
                0xBE,
                0x8C,
                0x3D,
                0xAF,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDWriteFont1
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x96,
                0x66,
                0xD1,
                0xAC,
                0x14,
                0x8C,
                0x5D,
                0x4F,
                0x87,
                0x7E,
                0xFE,
                0x3F,
                0xC1,
                0xD3,
                0x27,
                0x38,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDWriteRenderingParams1
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF4,
                0x3C,
                0x41,
                0x94,
                0xFC,
                0xA6,
                0x48,
                0x42,
                0x8B,
                0x50,
                0x66,
                0x74,
                0x34,
                0x8F,
                0xCA,
                0xD3,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDWriteTextAnalyzer1
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x00,
                0xD8,
                0xDA,
                0x80,
                0x1F,
                0xE2,
                0x83,
                0x4E,
                0x96,
                0xCE,
                0xBF,
                0xCC,
                0xE5,
                0x00,
                0xDB,
                0x7C,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDWriteTextAnalysisSource1
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD8,
                0xFA,
                0x9C,
                0x63,
                0xB4,
                0x0F,
                0x21,
                0x4B,
                0xA5,
                0x8A,
                0x06,
                0x79,
                0x20,
                0x12,
                0x00,
                0x09,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDWriteTextAnalysisSink1
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA0,
                0x41,
                0xD9,
                0xB0,
                0xE7,
                0x85,
                0x8B,
                0x4D,
                0x9F,
                0xD3,
                0x5C,
                0xED,
                0x99,
                0x34,
                0x48,
                0x2A,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDWriteTextLayout1
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x22,
                0xD8,
                0x64,
                0x90,
                0xA7,
                0x80,
                0x5C,
                0x46,
                0xA9,
                0x86,
                0xDF,
                0x65,
                0xF7,
                0x8B,
                0x8F,
                0xEB,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDWriteBitmapRenderTarget1
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x98,
                0x82,
                0x1E,
                0x79,
                0xF3,
                0x3E,
                0x30,
                0x42,
                0x98,
                0x80,
                0xC9,
                0xBD,
                0xEC,
                0xC4,
                0x20,
                0x64,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
