// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/StorageProvider.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;
public static partial class IID
{
    public static ref readonly Guid IID_IStorageProviderPropertyHandler
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xE5,
                0xFB,
                0x1D,
                0x30,
                0x4C,
                0x52,
                0x0F,
                0x4B,
                0x8B,
                0x2D,
                0x21,
                0xC4,
                0x0B,
                0x3A,
                0x29,
                0x88
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IStorageProviderHandler
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xB5,
                0x6F,
                0x2C,
                0x16,
                0xD3,
                0x44,
                0x5B,
                0x43,
                0x90,
                0x3D,
                0xE6,
                0x13,
                0xFA,
                0x09,
                0x3F,
                0xB5
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}