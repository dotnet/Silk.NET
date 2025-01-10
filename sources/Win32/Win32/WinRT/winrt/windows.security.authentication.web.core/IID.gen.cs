// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.security.authentication.web.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static unsafe partial class IID
{
    public static ref readonly Guid IID_IFindAllAccountsResult
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x5D,
                0x2B,
                0x81,
                0xA5,
                0x2E,
                0xB7,
                0x0C,
                0x42,
                0x86,
                0xAB,
                0xAA,
                0xC0,
                0xD7,
                0xB7,
                0x26,
                0x1F,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IWebAccountEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x7D,
                0x03,
                0xB7,
                0x6F,
                0x4E,
                0x42,
                0xEC,
                0x44,
                0x97,
                0x7C,
                0xEF,
                0x24,
                0x15,
                0x46,
                0x2A,
                0x5A,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IWebAccountMonitor
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xFD,
                0xF5,
                0x45,
                0x74,
                0x9D,
                0xAA,
                0x19,
                0x46,
                0x8D,
                0x5D,
                0xC1,
                0x38,
                0xA4,
                0xED,
                0xE3,
                0xE5,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IWebAccountMonitor2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF8,
                0xC1,
                0xAD,
                0xA7,
                0xB8,
                0x24,
                0x01,
                0x4F,
                0x9A,
                0xE5,
                0x24,
                0x54,
                0x5E,
                0x71,
                0x23,
                0x3A,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IWebAuthenticationCoreManagerStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x92,
                0x7C,
                0xCA,
                0x6A,
                0x81,
                0xA5,
                0x79,
                0x44,
                0x9C,
                0x10,
                0x75,
                0x2E,
                0xFF,
                0x44,
                0xFD,
                0x34,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IWebAuthenticationCoreManagerStatics2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x4A,
                0x18,
                0x84,
                0xF5,
                0x57,
                0x8B,
                0x20,
                0x48,
                0xB6,
                0xA4,
                0x70,
                0xA5,
                0xB6,
                0xFC,
                0xF4,
                0x4A,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IWebAuthenticationCoreManagerStatics3
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB2,
                0xEE,
                0x04,
                0x24,
                0x24,
                0x89,
                0x93,
                0x4D,
                0xAB,
                0x3A,
                0x99,
                0x68,
                0x8B,
                0x41,
                0x9D,
                0x56,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IWebAuthenticationCoreManagerStatics4
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xFE,
                0x33,
                0xE6,
                0x54,
                0xE0,
                0x96,
                0xE8,
                0x41,
                0x98,
                0x32,
                0x12,
                0x98,
                0x89,
                0x7C,
                0x2A,
                0xAF,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IWebProviderError
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB1,
                0x1B,
                0x19,
                0xDB,
                0xC5,
                0x50,
                0x09,
                0x48,
                0x8D,
                0xCA,
                0x09,
                0xC9,
                0x94,
                0x10,
                0x24,
                0x5C,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IWebProviderErrorFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x2D,
                0x0A,
                0xC4,
                0xE3,
                0xEF,
                0x89,
                0x37,
                0x4E,
                0x84,
                0x7F,
                0xA8,
                0xB9,
                0xD5,
                0xA3,
                0x29,
                0x10,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IWebTokenRequest
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x68,
                0x4D,
                0x7B,
                0xB7,
                0xCB,
                0xAD,
                0x73,
                0x46,
                0xB3,
                0x64,
                0x0C,
                0xF7,
                0xB3,
                0x5C,
                0xAF,
                0x97,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IWebTokenRequest2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x79,
                0xC0,
                0x00,
                0xD7,
                0xC8,
                0x30,
                0x97,
                0x43,
                0x96,
                0x54,
                0x96,
                0x1C,
                0x3B,
                0xE8,
                0xB8,
                0x55,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IWebTokenRequest3
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x51,
                0x5B,
                0x75,
                0x5A,
                0xB1,
                0x3B,
                0xA5,
                0x41,
                0xA6,
                0x3D,
                0x90,
                0xBC,
                0x32,
                0xC7,
                0xDB,
                0x9A,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IWebTokenRequestFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x1C,
                0x14,
                0xF2,
                0x6C,
                0xF0,
                0x0F,
                0x67,
                0x4C,
                0xB8,
                0x4F,
                0x99,
                0xDD,
                0xBE,
                0x4A,
                0x72,
                0xC9,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IWebTokenRequestResult
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x05,
                0x83,
                0x2A,
                0xC1,
                0xF8,
                0xD1,
                0x83,
                0x44,
                0x8D,
                0x54,
                0x38,
                0xFE,
                0x29,
                0x27,
                0x84,
                0xFF,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IWebTokenResponse
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xCA,
                0xC5,
                0xA7,
                0x67,
                0xF6,
                0x83,
                0xC6,
                0x44,
                0xA3,
                0xB1,
                0x0E,
                0xB6,
                0x9E,
                0x41,
                0xFA,
                0x8A,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IWebTokenResponseFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF8,
                0xF7,
                0x6B,
                0xAB,
                0x50,
                0x54,
                0xF6,
                0x4E,
                0x97,
                0xF7,
                0x05,
                0x2B,
                0x04,
                0x31,
                0xC0,
                0xF0,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
