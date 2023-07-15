// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfcontentdecryptionmodule.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;
public static partial class IID
{
    public static ref readonly Guid IID_IMFContentDecryptionModuleSession
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xFD,
                0x3E,
                0x23,
                0x4E,
                0xD2,
                0x1D,
                0xE8,
                0x49,
                0xB5,
                0x77,
                0xD6,
                0x3E,
                0xEE,
                0x4C,
                0x0D,
                0x33
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFContentDecryptionModuleSessionCallbacks
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x40,
                0xEE,
                0x96,
                0x3F,
                0x81,
                0xAD,
                0x96,
                0x40,
                0x84,
                0x70,
                0x59,
                0xA4,
                0xB7,
                0x70,
                0xF8,
                0x9A
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFContentDecryptionModule
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x6C,
                0x98,
                0xBE,
                0x87,
                0xBE,
                0x10,
                0x43,
                0x49,
                0xBF,
                0x48,
                0x4B,
                0x54,
                0xCE,
                0x19,
                0x83,
                0xA2
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFContentDecryptionModuleAccess
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xF4,
                0xD1,
                0x53,
                0xA8,
                0xA0,
                0xE2,
                0x03,
                0x43,
                0x9E,
                0xDC,
                0xF1,
                0xA6,
                0x8E,
                0xE4,
                0x31,
                0x36
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFContentDecryptionModuleFactory
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x16,
                0xBF,
                0x5A,
                0x7D,
                0xBB,
                0x4C,
                0x08,
                0x4E,
                0xB9,
                0x77,
                0x9B,
                0xA5,
                0x90,
                0x49,
                0x94,
                0x3E
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}