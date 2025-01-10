// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.ui.composition.interop.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class IID
{
    public static ref readonly Guid IID_ICompositionDrawingSurfaceInterop
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE3,
                0xE6,
                0x04,
                0xFD,
                0x0C,
                0xFE,
                0x3C,
                0x4C,
                0xAB,
                0x19,
                0xA0,
                0x76,
                0x01,
                0xA5,
                0x76,
                0xEE,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICompositionDrawingSurfaceInterop2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xAE,
                0x4A,
                0xE6,
                0x41,
                0xC0,
                0x98,
                0x39,
                0x42,
                0x8E,
                0x95,
                0xA3,
                0x30,
                0xDD,
                0x6A,
                0xA1,
                0x8B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICompositionGraphicsDeviceInterop
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x71,
                0xFF,
                0x16,
                0xA1,
                0xBF,
                0xF8,
                0x8A,
                0x4C,
                0x9C,
                0x98,
                0x70,
                0x77,
                0x9A,
                0x32,
                0xA9,
                0xC8,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICompositorInterop
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x5C,
                0x7D,
                0x29,
                0x25,
                0xD4,
                0x3A,
                0x9C,
                0x4C,
                0xB5,
                0xCF,
                0xE3,
                0x6A,
                0x38,
                0x51,
                0x23,
                0x30,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICompositorInterop2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x4C,
                0xF3,
                0xEE,
                0xD3,
                0x67,
                0x06,
                0xFC,
                0x4A,
                0x8D,
                0x13,
                0x86,
                0x76,
                0x07,
                0xB0,
                0xFE,
                0x91,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICompositionTextureInterop
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x65,
                0xA2,
                0x28,
                0xD5,
                0xA5,
                0xF0,
                0x2F,
                0x42,
                0xA3,
                0x9D,
                0xEF,
                0x62,
                0xD7,
                0xCD,
                0x1C,
                0xC4,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IVisualInteractionSourceInterop
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD1,
                0x2C,
                0xF6,
                0x11,
                0x9D,
                0x2F,
                0xD3,
                0x42,
                0xB0,
                0x5F,
                0xD6,
                0x79,
                0x0D,
                0x9E,
                0x9F,
                0x8E,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICompositionCapabilitiesInteropFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x56,
                0xB3,
                0x9D,
                0x2C,
                0x0D,
                0xE7,
                0x42,
                0x46,
                0x82,
                0x98,
                0xBC,
                0x4A,
                0xA5,
                0xB4,
                0x86,
                0x5C,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICompositorDesktopInterop
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xFA,
                0x91,
                0xE6,
                0x29,
                0x67,
                0x45,
                0xCA,
                0x4D,
                0xB3,
                0x19,
                0xD0,
                0xF2,
                0x07,
                0xEB,
                0x68,
                0x07,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDesktopWindowTargetInterop
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x9E,
                0xF5,
                0xDB,
                0x35,
                0xF9,
                0xE3,
                0xB0,
                0x45,
                0x81,
                0xE7,
                0xFE,
                0x75,
                0xF4,
                0x14,
                0x5D,
                0xC9,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
