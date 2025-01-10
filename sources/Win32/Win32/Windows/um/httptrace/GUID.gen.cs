// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/httptrace.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class GUID
{
    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_IIS_ALL_TRACE_PROVIDERS
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x00,
                0x00,
                0x00,
                0x00,
                0x00,
                0x00,
                0x00,
                0x00,
                0x00,
                0x00,
                0x00,
                0x00,
                0x00,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_IIS_WWW_SERVER_TRACE_PROVIDER
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x84,
                0x4E,
                0x2A,
                0x3A,
                0x21,
                0x4C,
                0x81,
                0x49,
                0xAE,
                0x10,
                0x3F,
                0xDA,
                0x0D,
                0x9B,
                0x0F,
                0x83,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_IIS_WWW_SERVER_V2_TRACE_PROVIDER
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC9,
                0x49,
                0x46,
                0xDE,
                0xE8,
                0x15,
                0xEA,
                0x4F,
                0x9D,
                0x85,
                0x1C,
                0xDD,
                0xA5,
                0x20,
                0xC3,
                0x34,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_IIS_ASPNET_TRACE_PROVIDER
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xFE,
                0x81,
                0xF0,
                0xAF,
                0x47,
                0x02,
                0x75,
                0x42,
                0x9C,
                0x4E,
                0x02,
                0x1F,
                0x3D,
                0xC1,
                0xDA,
                0x35,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_IIS_ASP_TRACE_TRACE_PROVIDER
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x9A,
                0x4D,
                0xB9,
                0x06,
                0x5E,
                0xB1,
                0x6E,
                0x45,
                0xA4,
                0xEF,
                0x37,
                0xC9,
                0x84,
                0xA2,
                0xCB,
                0x4B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_IIS_WWW_GLOBAL_TRACE_PROVIDER
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC9,
                0x3B,
                0x5D,
                0xD5,
                0xA9,
                0xCB,
                0xDF,
                0x44,
                0x82,
                0x7E,
                0x13,
                0x2D,
                0x3A,
                0x45,
                0x96,
                0xC2,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_IIS_ISAPI_TRACE_PROVIDER
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x0E,
                0x04,
                0xC2,
                0xA1,
                0x40,
                0x88,
                0x31,
                0x4C,
                0xBA,
                0x11,
                0x98,
                0x71,
                0x03,
                0x1A,
                0x19,
                0xEA,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
