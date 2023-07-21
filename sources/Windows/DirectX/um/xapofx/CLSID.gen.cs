// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/xapofx.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;

public static partial class CLSID
{
    public static ref readonly Guid CLSID_FXEQ
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x17, 0x11, 0xE0, 0xF5,
                0xC4, 0xD6,
                0x5A, 0x48,
                0xA3,
                0xF5,
                0x69,
                0x51,
                0x96,
                0xF3,
                0xDB,
                0xFA
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_FXMasteringLimiter
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x16, 0x79, 0x13, 0xC4,
                0xE1, 0x2B,
                0xFD, 0x46,
                0x85,
                0x99,
                0x44,
                0x15,
                0x36,
                0xF4,
                0x98,
                0x56
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_FXReverb
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x56, 0xCA, 0x9A, 0x7D,
                0x68, 0xCB,
                0x07, 0x48,
                0xB6,
                0x32,
                0xB1,
                0x37,
                0x35,
                0x2E,
                0x85,
                0x96
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_FXEcho
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x40, 0xD7, 0x39, 0x50,
                0x36, 0xF7,
                0x9A, 0x44,
                0x84,
                0xD3,
                0xA5,
                0x62,
                0x02,
                0x55,
                0x7B,
                0x87
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
