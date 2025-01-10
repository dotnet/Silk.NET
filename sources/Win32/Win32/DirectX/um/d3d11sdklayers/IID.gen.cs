// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d11sdklayers.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.DirectX;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class IID
{
    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D11Debug
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x33,
                0x22,
                0xCF,
                0x79,
                0x36,
                0x75,
                0x48,
                0x49,
                0x9D,
                0x36,
                0x1E,
                0x46,
                0x92,
                0xDC,
                0x57,
                0x60,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D11SwitchToRef
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE3,
                0x37,
                0xF3,
                0x1E,
                0xE7,
                0x58,
                0x83,
                0x4F,
                0xA6,
                0x92,
                0xDB,
                0x22,
                0x1F,
                0x5E,
                0xD4,
                0x7E,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D11TracingDevice
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x71,
                0xC7,
                0x11,
                0x19,
                0x87,
                0x15,
                0x3E,
                0x41,
                0xA7,
                0xE0,
                0xFB,
                0x26,
                0xC3,
                0xDE,
                0x02,
                0x68,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D11RefTrackingOptions
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xDF,
                0xAC,
                0x3D,
                0x19,
                0xB2,
                0x0D,
                0x05,
                0x4C,
                0xA5,
                0x5C,
                0xEF,
                0x06,
                0xCA,
                0xC5,
                0x6F,
                0xD9,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D11RefDefaultTrackingOptions
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x15,
                0x66,
                0x91,
                0x03,
                0x44,
                0xC6,
                0x8C,
                0x41,
                0x9B,
                0xF4,
                0x75,
                0xDB,
                0x5B,
                0xE6,
                0x3C,
                0xA0,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D11InfoQueue
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB6,
                0xDB,
                0x43,
                0x65,
                0x48,
                0x1B,
                0xF5,
                0x42,
                0xAB,
                0x82,
                0xE9,
                0x7E,
                0xC7,
                0x43,
                0x26,
                0xF6,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
