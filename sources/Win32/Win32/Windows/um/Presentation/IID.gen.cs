// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/UIAnimation.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class IID
{
    public static ref readonly Guid IID_IPresentationBuffer
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x3A,
                0x7D,
                0x21,
                0x2E,
                0xBB,
                0x5A,
                0x38,
                0x41,
                0x9A,
                0x13,
                0xA7,
                0x75,
                0x59,
                0x3C,
                0x89,
                0xCA,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPresentationContent
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x79,
                0xBB,
                0x68,
                0x56,
                0x8E,
                0x3D,
                0x5C,
                0x41,
                0xB2,
                0x15,
                0xF3,
                0x80,
                0x20,
                0xF2,
                0xD2,
                0x52,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPresentationSurface
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xFB,
                0x10,
                0x67,
                0x95,
                0x40,
                0xEA,
                0xBA,
                0x4E,
                0xA3,
                0xEB,
                0x43,
                0x75,
                0xA0,
                0xEB,
                0x4E,
                0xDC,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPresentationSurface2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x69,
                0x95,
                0x60,
                0x95,
                0xF0,
                0xC5,
                0xF9,
                0x47,
                0x88,
                0x04,
                0x53,
                0x45,
                0xF2,
                0xE2,
                0x76,
                0x7E,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPresentStatistics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xDA,
                0x8B,
                0x4B,
                0xB4,
                0x82,
                0x72,
                0x5D,
                0x49,
                0x9D,
                0xD7,
                0xCE,
                0xAD,
                0xD8,
                0xB4,
                0xBB,
                0x86,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPresentationManager
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x82,
                0x2F,
                0x56,
                0xFB,
                0x92,
                0x62,
                0x0A,
                0x47,
                0x88,
                0xB1,
                0x84,
                0x36,
                0x61,
                0xE7,
                0xF2,
                0x0C,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPresentationFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x58,
                0x7B,
                0xB3,
                0x8F,
                0x74,
                0x1D,
                0x64,
                0x4F,
                0xA4,
                0x9C,
                0x1F,
                0x97,
                0xA8,
                0x0A,
                0x2E,
                0xC0,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPresentationFactory_SupportHdrAware
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x85,
                0xB8,
                0xD0,
                0x2B,
                0x6F,
                0xA1,
                0xD9,
                0x4B,
                0xA5,
                0x9A,
                0xD0,
                0x73,
                0xE0,
                0x69,
                0xD4,
                0x16,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPresentStatusPresentStatistics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x41,
                0x2A,
                0xED,
                0xC9,
                0xCB,
                0x79,
                0x5E,
                0x43,
                0x96,
                0x4E,
                0xC8,
                0x55,
                0x30,
                0x55,
                0x42,
                0x0C,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICompositionFramePresentStatistics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x27,
                0xD1,
                0x41,
                0xAB,
                0x01,
                0xC1,
                0x0A,
                0x4C,
                0x91,
                0x1D,
                0xF9,
                0xF2,
                0xE9,
                0xD0,
                0x8E,
                0x64,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IIndependentFlipFramePresentStatistics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x27,
                0xBE,
                0x93,
                0x8C,
                0x94,
                0xAD,
                0xA0,
                0x4D,
                0x8F,
                0xD4,
                0x24,
                0x13,
                0x13,
                0x2D,
                0x12,
                0x4E,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
