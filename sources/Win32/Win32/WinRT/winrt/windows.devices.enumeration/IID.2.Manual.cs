// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Win32;

public static unsafe partial class IID
{
    public static ref readonly Guid IID_IDeviceAccessChangedEventArgs3
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x75,
                0x80,
                0xa8,
                0x78,
                0x7f,
                0xd9,
                0x5c,
                0xd7,
                0x85,
                0x60,
                0x3c,
                0x64,
                0x4b,
                0x9b,
                0x10,
                0xdb,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IDeviceAccessInformation2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xe2,
                0xb9,
                0xdf,
                0xf6,
                0xe8,
                0x8f,
                0x5d,
                0x0a,
                0x9c,
                0x1e,
                0xd7,
                0x88,
                0x80,
                0x8d,
                0xf4,
                0x7b,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IDeviceEnumerationSettings
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xf7,
                0x71,
                0x0f,
                0x66,
                0x9f,
                0xf3,
                0x41,
                0xc8,
                0x85,
                0xeb,
                0x87,
                0xf8,
                0x11,
                0x48,
                0xa3,
                0x0f,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IDeviceInformationCustomPairing2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x0e,
                0xbd,
                0xa6,
                0x62,
                0xe6,
                0x96,
                0x5f,
                0xa9,
                0x8f,
                0x72,
                0x80,
                0xcf,
                0xeb,
                0xcd,
                0x85,
                0x1d,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IDeviceInformationStatics3
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x25,
                0xf0,
                0x62,
                0x79,
                0x93,
                0x64,
                0x5a,
                0x6c,
                0x8a,
                0x54,
                0x5d,
                0x4a,
                0x6d,
                0x3d,
                0x92,
                0x2a,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IDevicePairingRequestedEventArgs3
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x19,
                0x5e,
                0x5a,
                0x38,
                0x43,
                0xdc,
                0x56,
                0x2f,
                0xba,
                0xbe,
                0xef,
                0xc8,
                0xb1,
                0x10,
                0x08,
                0x8b,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IDevicePairingSetMembersRequestedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x7f,
                0xb4,
                0x2c,
                0xff,
                0xec,
                0xac,
                0x50,
                0x12,
                0x8d,
                0x7d,
                0xa1,
                0x89,
                0x46,
                0x80,
                0xa3,
                0x49,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
