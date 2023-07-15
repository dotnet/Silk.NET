// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/windows.ui.xaml.media.dxinterop.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;
public static partial class IID
{
    public static ref readonly Guid IID_ISurfaceImageSourceNative
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xC1,
                0xED,
                0xE9,
                0xF2,
                0x07,
                0xD3,
                0x25,
                0x45,
                0x98,
                0x86,
                0x0F,
                0xAF,
                0xAA,
                0x44,
                0x16,
                0x3C
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IVirtualSurfaceUpdatesCallbackNative
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x47,
                0xE9,
                0xF2,
                0xDB,
                0x6C,
                0x8E,
                0x54,
                0x42,
                0x9E,
                0xEE,
                0x77,
                0x38,
                0xF7,
                0x13,
                0x86,
                0xC9
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IVirtualSurfaceImageSourceNative
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x83,
                0x09,
                0x55,
                0xE9,
                0x0B,
                0x36,
                0x53,
                0x4F,
                0xB3,
                0x91,
                0xAF,
                0xD6,
                0x95,
                0x07,
                0x86,
                0x91
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISwapChainBackgroundPanelNative
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x4E,
                0xBD,
                0xBE,
                0x43,
                0xD5,
                0xAD,
                0x35,
                0x40,
                0x8F,
                0x85,
                0x56,
                0x08,
                0xD0,
                0x8E,
                0x9D,
                0xC9
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISurfaceImageSourceManagerNative
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xB7,
                0x98,
                0x87,
                0x4C,
                0x88,
                0x1D,
                0x0F,
                0x4A,
                0xB5,
                0x9B,
                0xB9,
                0x3F,
                0x60,
                0x0D,
                0xE8,
                0xC8
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISurfaceImageSourceNativeWithD2D
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x23,
                0x82,
                0x29,
                0x54,
                0xE1,
                0x41,
                0x41,
                0x4A,
                0x9C,
                0x08,
                0x02,
                0xE8,
                0x25,
                0x68,
                0x64,
                0xA1
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISwapChainPanelNative
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xD2,
                0x19,
                0x2F,
                0xF9,
                0xDE,
                0x3A,
                0xA6,
                0x45,
                0xA2,
                0x0C,
                0xF6,
                0xF1,
                0xEA,
                0x90,
                0x55,
                0x4B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISwapChainPanelNative2
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x0C,
                0xF6,
                0xA2,
                0xD5,
                0xB2,
                0x37,
                0xA2,
                0x44,
                0x93,
                0x7B,
                0x8D,
                0x8E,
                0xB9,
                0x72,
                0x68,
                0x21
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}