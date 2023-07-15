// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/shappmgr.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;
public static partial class IID
{
    public static ref readonly Guid IID_IShellApp
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x60,
                0x49,
                0xE1,
                0xA3,
                0x5F,
                0x93,
                0xD1,
                0x11,
                0xB8,
                0xB8,
                0x00,
                0x60,
                0x08,
                0x05,
                0x93,
                0x82
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IPublishedApp
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xE0,
                0x52,
                0xC7,
                0x1B,
                0x46,
                0x90,
                0xD1,
                0x11,
                0xB8,
                0xB3,
                0x00,
                0x60,
                0x08,
                0x05,
                0x93,
                0x82
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IPublishedApp2
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x47,
                0x13,
                0xB8,
                0x12,
                0x3A,
                0x1B,
                0x04,
                0x4A,
                0xAA,
                0x61,
                0x3F,
                0x76,
                0x8B,
                0x67,
                0xFD,
                0x7E
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IEnumPublishedApps
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x8C,
                0x4F,
                0x12,
                0x0B,
                0xF0,
                0x91,
                0xD1,
                0x11,
                0xB8,
                0xB5,
                0x00,
                0x60,
                0x08,
                0x05,
                0x93,
                0x82
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IAppPublisher
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x10,
                0x0A,
                0x25,
                0x07,
                0xF9,
                0x9C,
                0xD1,
                0x11,
                0x90,
                0x76,
                0x00,
                0x60,
                0x08,
                0x05,
                0x93,
                0x82
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}