// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.606.4
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
    public static ref readonly Guid IID_ID3D12VideoDecoderHeap
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [0xC9, 0xB7, 0x46, 0x09, 0xF6, 0xEB, 0x47, 0x40, 0xBB, 0x73, 0x86, 0x83, 0xE2, 0x7D, 0xBB, 0x1F];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D12VideoDevice
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [0x07, 0x28, 0x05, 0x1F, 0x46, 0x0B, 0xCC, 0x4A, 0x8A, 0x89, 0x36, 0x4F, 0x79, 0x37, 0x18, 0xA4];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D12VideoDecoder
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [0xDC, 0x6B, 0x9B, 0xC5, 0x20, 0x77, 0x74, 0x40, 0xA1, 0x36, 0x17, 0xA1, 0x56, 0x03, 0x74, 0x70];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D12VideoProcessor
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [0x32, 0xDB, 0x4F, 0x30, 0xDE, 0xBE, 0x0A, 0x41, 0x85, 0x45, 0x94, 0x3A, 0xC6, 0xA4, 0x61, 0x38];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D12VideoDecodeCommandList
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [0x6E, 0x53, 0x60, 0x3B, 0x29, 0xAD, 0x64, 0x4E, 0xA2, 0x69, 0xF8, 0x53, 0x83, 0x7E, 0x5E, 0x53];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D12VideoProcessCommandList
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [0x3A, 0x54, 0xB2, 0xAE, 0x7F, 0x16, 0x82, 0x46, 0xAC, 0xC8, 0xD1, 0x59, 0xED, 0x4A, 0x62, 0x09];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D12VideoDecodeCommandList1
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [0x1B, 0x01, 0x2F, 0xD5, 0x6E, 0xB5, 0x3C, 0x45, 0xA0, 0x5A, 0xA7, 0xF3, 0x11, 0xC8, 0xF4, 0x72];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D12VideoProcessCommandList1
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [0x4D, 0x5C, 0x2C, 0x54, 0x96, 0x75, 0x4F, 0x43, 0x8C, 0x93, 0x4E, 0xFA, 0x67, 0x66, 0xF2, 0x67];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D12VideoMotionEstimator
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [0x0E, 0xAE, 0xFD, 0x33, 0x8B, 0x09, 0x8F, 0x42, 0x87, 0xBB, 0x34, 0xB6, 0x95, 0xDE, 0x08, 0xF8];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D12VideoMotionVectorHeap
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [0x87, 0x79, 0xE1, 0x5B, 0x3A, 0x74, 0x61, 0x40, 0x83, 0x4B, 0x23, 0xD2, 0x2D, 0xAE, 0xA5, 0x05];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D12VideoDevice1
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [0xAD, 0x11, 0x16, 0x98, 0x44, 0xA1, 0x83, 0x4C, 0x98, 0x90, 0xF3, 0x0E, 0x26, 0xD6, 0x58, 0xAB];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D12VideoEncodeCommandList
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [0x3A, 0x29, 0x55, 0x84, 0xBD, 0x0C, 0x31, 0x48, 0x9B, 0x39, 0xFB, 0xDB, 0xAB, 0x72, 0x47, 0x23];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D12VideoDecoder1
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [0xFB, 0xE5, 0xA2, 0x79, 0xD2, 0xCC, 0x9A, 0x46, 0x9F, 0xDE, 0x19, 0x5D, 0x10, 0x95, 0x1F, 0x7E];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D12VideoDecoderHeap1
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [0xC5, 0x98, 0x1D, 0xDA, 0x9F, 0x53, 0xB2, 0x41, 0xBF, 0x6B, 0x11, 0x98, 0xA0, 0x3B, 0x6D, 0x26];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D12VideoProcessor1
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [0x15, 0xE6, 0xCF, 0xF3, 0x3F, 0x55, 0x5C, 0x42, 0x86, 0xD8, 0xEE, 0x8C, 0x1B, 0x1F, 0xB0, 0x1C];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D12VideoExtensionCommand
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [0xE8, 0x41, 0x4E, 0x55, 0x8E, 0xAE, 0x8C, 0x4A, 0xB7, 0xD2, 0x5B, 0x4F, 0x27, 0x4A, 0x30, 0xE4];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D12VideoDevice2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [0x49, 0xAC, 0x19, 0xF0, 0x38, 0xF8, 0x95, 0x4A, 0x9B, 0x17, 0x57, 0x94, 0x37, 0xC8, 0xF5, 0x13];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D12VideoDecodeCommandList2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [0x80, 0x08, 0x12, 0x6E, 0x14, 0xC1, 0x53, 0x41, 0x80, 0x36, 0xD2, 0x47, 0x05, 0x1E, 0x17, 0x29];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D12VideoDecodeCommandList3
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [0x37, 0x8C, 0xEE, 0x2A, 0x62, 0x95, 0xDA, 0x42, 0x8A, 0xBF, 0x61, 0xEF, 0xEB, 0x2E, 0x45, 0x13];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D12VideoProcessCommandList2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [0xE4, 0x5A, 0x52, 0xDB, 0xD6, 0x6A, 0x3C, 0x47, 0xBA, 0xA7, 0x59, 0xB2, 0xE3, 0x70, 0x82, 0xE4];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D12VideoProcessCommandList3
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [0xA4, 0x4C, 0x0A, 0x1A, 0x08, 0x9F, 0xCE, 0x40, 0x95, 0x58, 0xB4, 0x11, 0xFD, 0x26, 0x66, 0xFF];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D12VideoEncodeCommandList1
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [0xCA, 0x1E, 0x97, 0x94, 0xDB, 0x2B, 0x69, 0x47, 0x88, 0xCF, 0x36, 0x75, 0xEA, 0x75, 0x7E, 0xBC];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D12VideoEncoder
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [0x2D, 0x21, 0x0D, 0x2E, 0xF9, 0x8D, 0xA6, 0x44, 0xA7, 0x70, 0xBB, 0x28, 0x9B, 0x18, 0x27, 0x37];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D12VideoEncoderHeap
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [0x96, 0x5D, 0xB3, 0x22, 0x6A, 0x87, 0xC0, 0x44, 0xB2, 0x5E, 0xFB, 0x8C, 0x9C, 0x7F, 0x1C, 0x4A];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D12VideoDevice3
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [0xB4, 0xAD, 0x43, 0x42, 0x32, 0x3A, 0x66, 0x46, 0x97, 0x3C, 0x0C, 0xCC, 0x56, 0x25, 0xDC, 0x44];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D12VideoEncodeCommandList2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [0xE2, 0x91, 0x54, 0x89, 0x01, 0xE7, 0xA9, 0x46, 0x9A, 0x1F, 0x8D, 0x34, 0x80, 0xED, 0x86, 0x7A];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D12VideoEncodeCommandList3
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [0x22, 0x7B, 0x02, 0x7F, 0x15, 0x15, 0x85, 0x4E, 0xAA, 0x0D, 0x02, 0x64, 0x86, 0x58, 0x05, 0x76];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}