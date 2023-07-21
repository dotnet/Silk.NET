// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/imapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;

public static partial class IID
{
    public static ref readonly Guid IID_IDiscRecorder
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x76, 0x97, 0xAC, 0x85,
                0x88, 0xCA,
                0xF2, 0x4C,
                0x89,
                0x4E,
                0x09,
                0x59,
                0x8C,
                0x07,
                0x8A,
                0x41
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IEnumDiscRecorders
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xE1, 0x21, 0x19, 0x9B,
                0xAC, 0x54,
                0xD3, 0x11,
                0x91,
                0x44,
                0x00,
                0x10,
                0x4B,
                0xA1,
                0x1C,
                0x5E
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IEnumDiscMasterFormats
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xE1, 0x45, 0xF4, 0xDD,
                0xBA, 0x54,
                0xD3, 0x11,
                0x91,
                0x44,
                0x00,
                0x10,
                0x4B,
                0xA1,
                0x1C,
                0x5E
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IRedbookDiscMaster
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xCD, 0x42, 0xBC, 0xE3,
                0x5C, 0x4E,
                0xD3, 0x11,
                0x91,
                0x44,
                0x00,
                0x10,
                0x4B,
                0xA1,
                0x1C,
                0x5E
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IJolietDiscMaster
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xCE, 0x42, 0xBC, 0xE3,
                0x5C, 0x4E,
                0xD3, 0x11,
                0x91,
                0x44,
                0x00,
                0x10,
                0x4B,
                0xA1,
                0x1C,
                0x5E
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IDiscMasterProgressEvents
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xC1, 0x51, 0x9E, 0xEC,
                0x5D, 0x4E,
                0xD3, 0x11,
                0x91,
                0x44,
                0x00,
                0x10,
                0x4B,
                0xA1,
                0x1C,
                0x5E
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IDiscMaster
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x62, 0xCA, 0x0C, 0x52,
                0xA5, 0x51,
                0xD3, 0x11,
                0x91,
                0x44,
                0x00,
                0x10,
                0x4B,
                0xA1,
                0x1C,
                0x5E
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
