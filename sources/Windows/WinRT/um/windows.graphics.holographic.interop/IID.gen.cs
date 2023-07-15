// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/windows.graphics.holographic.interop.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;
public static partial class IID
{
    public static ref readonly Guid IID_IHolographicCameraInterop
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xC5,
                0xF9,
                0xC1,
                0x7C,
                0x02,
                0x6D,
                0xFA,
                0x41,
                0x95,
                0x00,
                0xE1,
                0x80,
                0x9E,
                0xB4,
                0x8E,
                0xEC
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHolographicCameraRenderingParametersInterop
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xD6,
                0x68,
                0x5B,
                0xF7,
                0xFD,
                0xD1,
                0x07,
                0x47,
                0xAA,
                0xFD,
                0xFA,
                0x6F,
                0x4C,
                0x0E,
                0x3B,
                0xF4
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHolographicQuadLayerInterop
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xF0,
                0x88,
                0xA6,
                0xCF,
                0x9E,
                0x63,
                0x47,
                0x4A,
                0x83,
                0xD7,
                0x6B,
                0x7F,
                0x5E,
                0xBF,
                0x7F,
                0xED
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHolographicQuadLayerUpdateParametersInterop
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xCD,
                0x49,
                0xF5,
                0xE5,
                0x09,
                0xC9,
                0x4F,
                0x44,
                0x88,
                0x09,
                0x7C,
                0xC1,
                0x8A,
                0x9C,
                0x89,
                0x20
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}