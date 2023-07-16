// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WindowsStorageCOM.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;
public static partial class IID
{
    public static ref readonly Guid IID_IRandomAccessStreamFileAccessMode
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x48,
                0x58,
                0x2E,
                0x33,
                0x15,
                0x2E,
                0x8E,
                0x45,
                0x85,
                0xC4,
                0xC9,
                0x11,
                0xC0,
                0xC3,
                0xD6,
                0xF4
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IUnbufferedFileHandleOplockCallback
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x0E,
                0x9A,
                0x01,
                0xD1,
                0x43,
                0x62,
                0x29,
                0x43,
                0x84,
                0x97,
                0x2E,
                0x75,
                0x89,
                0x4D,
                0x77,
                0x10
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IUnbufferedFileHandleProvider
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x09,
                0x91,
                0x5C,
                0xA6,
                0xAB,
                0x42,
                0x94,
                0x4B,
                0xA7,
                0xB1,
                0xDD,
                0x2E,
                0x4E,
                0x68,
                0x51,
                0x5E
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IOplockBreakingHandler
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x3D,
                0xBE,
                0x6A,
                0x82,
                0xCD,
                0x3A,
                0xD3,
                0x47,
                0x84,
                0xF2,
                0x88,
                0xAA,
                0xED,
                0xCF,
                0x63,
                0x04
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IStorageItemHandleAccess
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xB2,
                0x96,
                0xA2,
                0x5C,
                0x25,
                0x2C,
                0x22,
                0x4D,
                0xB7,
                0x85,
                0xB8,
                0x85,
                0xC8,
                0x20,
                0x1E,
                0x6A
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IStorageFolderHandleAccess
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x8F,
                0x93,
                0x19,
                0xDF,
                0x62,
                0x54,
                0xA0,
                0x48,
                0xBE,
                0x65,
                0xD2,
                0xA3,
                0x27,
                0x1A,
                0x08,
                0xD6
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}