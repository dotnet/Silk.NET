// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.WinRT;

namespace Silk.NET.Windows;

public static unsafe partial class IID
{
    public static ref readonly Guid IID_IWebAuthenticationTransferTokenRequestFactory
    {
        get
        {
            ReadOnlySpan<byte> data = [
                0x5f, 0x16, 0xb6, 0x27,
                0x04, 0xc4,
                0x5f, 0x0b,
                0x86,
                0x83,
                0x8b,
                0xab,
                0x58,
                0x96,
                0x56,
                0x56
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IWebAuthenticationTransferTokenRequest
    {
        get
        {
            ReadOnlySpan<byte> data = [
                0x7a, 0xcf, 0xa5, 0xb6,
                0x52, 0x9d,
                0x5e, 0x76,
                0x98,
                0x46,
                0xf3,
                0xfd,
                0x99,
                0x93,
                0x04,
                0xd0
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IWebAuthenticationCoreManagerStatics5
    {
        get
        {
            ReadOnlySpan<byte> data = [
                0xd0, 0x7c, 0x1d, 0xed,
                0x27, 0x0f,
                0x45, 0x54,
                0x99,
                0x66,
                0x27,
                0xb7,
                0xdf,
                0x05,
                0xb9,
                0x65
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IWebAuthenticationAddAccountResult
    {
        get
        {
            ReadOnlySpan<byte> data = [
                0x88, 0xfa, 0xd0, 0x3c,
                0x90, 0x1d,
                0x5f, 0xfa,
                0x92,
                0x59,
                0x70,
                0x1d,
                0x3c,
                0xa0,
                0x8e,
                0xf2
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IWebAuthenticationAddAccountResponseFactory
    {
        get
        {
            ReadOnlySpan<byte> data = [
                0x32, 0x5f, 0x90, 0x3e,
                0x77, 0xbe,
                0x53, 0x65,
                0x81,
                0xd9,
                0x03,
                0x21,
                0xcd,
                0xd8,
                0x21,
                0x95
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IWebAuthenticationAddAccountResponse
    {
        get
        {
            ReadOnlySpan<byte> data = [
                0x7f, 0xb0, 0x13, 0xe8,
                0x0b, 0xd8,
                0x54, 0x2b,
                0xb4,
                0x86,
                0x83,
                0x23,
                0x16,
                0x3a,
                0x4b,
                0x85
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
