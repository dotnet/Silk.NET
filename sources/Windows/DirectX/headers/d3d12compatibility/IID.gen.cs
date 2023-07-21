// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12compatibility.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license

using Silk.NET.DirectX;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;

public static partial class IID
{
    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D12CompatibilityDevice
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x3C, 0x0E, 0x1C, 0x8F,
                0xE3, 0xFA,
                0x82, 0x4A,
                0xB0,
                0x98,
                0xBF,
                0xE1,
                0x70,
                0x82,
                0x07,
                0xFF
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_D3D11On12CreatorID
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x78, 0x56, 0xBF, 0xED,
                0x60, 0x29,
                0x81, 0x4E,
                0x84,
                0x29,
                0x99,
                0xD4,
                0xB2,
                0x63,
                0x0C,
                0x4E
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_D3D9On12CreatorID
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x7F, 0xBB, 0xFC, 0xFF,
                0xD3, 0x15,
                0xA2, 0x42,
                0x84,
                0x1E,
                0x9D,
                0x8D,
                0x32,
                0xF3,
                0x7D,
                0xDD
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_OpenGLOn12CreatorID
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x34, 0xCD, 0xB3, 0x6B,
                0x19, 0x0D,
                0xAB, 0x45,
                0x97,
                0xED,
                0xD7,
                0x20,
                0xBA,
                0x3D,
                0xFC,
                0x80
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_OpenCLOn12CreatorID
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x74, 0xBB, 0x76, 0x3F,
                0xB5, 0x91,
                0x88, 0x4A,
                0xB1,
                0x26,
                0x20,
                0xCA,
                0x03,
                0x31,
                0xCD,
                0x60
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_DirectMLTensorFlowCreatorID
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xAC, 0x90, 0x74, 0xCB,
                0x0F, 0x8A,
                0xEC, 0x44,
                0x9B,
                0x7B,
                0x6F,
                0x4C,
                0xAF,
                0xE8,
                0xE9,
                0xAB
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_DirectMLPyTorchCreatorID
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x92, 0x91, 0x02, 0xAF,
                0xA1, 0xFB,
                0x05, 0x4B,
                0x91,
                0x16,
                0x23,
                0x5E,
                0x06,
                0x56,
                0x03,
                0x54
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
