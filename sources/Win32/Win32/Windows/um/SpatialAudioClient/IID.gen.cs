// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/SpatialAudioClient.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class IID
{
    public static ref readonly Guid IID_IAudioFormatEnumerator
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x58,
                0xA8,
                0xDA,
                0xDC,
                0x5A,
                0x89,
                0x22,
                0x4A,
                0xA5,
                0xEB,
                0x67,
                0xBD,
                0xA5,
                0x06,
                0x09,
                0x6D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISpatialAudioObjectBase
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF2,
                0xB8,
                0xE0,
                0xCC,
                0x4D,
                0x8D,
                0xFB,
                0x4E,
                0xA8,
                0xCF,
                0x3D,
                0x6E,
                0xCF,
                0x1C,
                0x30,
                0xE0,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISpatialAudioObject
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x67,
                0x89,
                0xE2,
                0xDD,
                0x1B,
                0x52,
                0xE5,
                0x46,
                0x8F,
                0x00,
                0xBD,
                0x6F,
                0x2B,
                0xC8,
                0xAB,
                0x1D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISpatialAudioObjectRenderStreamBase
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x03,
                0xF4,
                0xAA,
                0xFE,
                0xD8,
                0xC1,
                0x0D,
                0x45,
                0xAA,
                0x05,
                0xE0,
                0xCC,
                0xEE,
                0x75,
                0x02,
                0xA8,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISpatialAudioObjectRenderStream
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x73,
                0xF4,
                0xB5,
                0xBA,
                0x23,
                0xB4,
                0x7B,
                0x47,
                0x85,
                0xF5,
                0xB5,
                0xA3,
                0x32,
                0xA0,
                0x41,
                0x53,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISpatialAudioObjectRenderStreamNotify
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE6,
                0x83,
                0xDF,
                0xDD,
                0xD7,
                0x68,
                0x70,
                0x4C,
                0x88,
                0x3F,
                0xA1,
                0x83,
                0x6A,
                0xFB,
                0x4A,
                0x50,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISpatialAudioClient
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x66,
                0xE0,
                0xF8,
                0xBB,
                0xAA,
                0xAA,
                0xBE,
                0x49,
                0x9A,
                0x4D,
                0xFD,
                0x2A,
                0x85,
                0x8E,
                0xA2,
                0x7F,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISpatialAudioClient2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x52,
                0xE4,
                0xAB,
                0xCA,
                0x6A,
                0xA6,
                0xEE,
                0x4B,
                0xA9,
                0x3E,
                0xE3,
                0x20,
                0x46,
                0x3F,
                0x6A,
                0x53,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
