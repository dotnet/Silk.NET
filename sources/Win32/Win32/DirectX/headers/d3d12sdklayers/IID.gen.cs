// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12sdklayers.h in microsoft/DirectX-Headers tag v1.606.4
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
    public static ref readonly Guid IID_ID3D12Debug
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [0xB7, 0x88, 0x44, 0x34, 0x46, 0x68, 0x4B, 0x47, 0xB9, 0x89, 0xF0, 0x27, 0x44, 0x82, 0x45, 0xE0];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D12Debug1
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [0xCA, 0xA4, 0xFA, 0xAF, 0xFE, 0x63, 0x8E, 0x4D, 0xB8, 0xAD, 0x15, 0x90, 0x00, 0xAF, 0x43, 0x04];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D12Debug2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [0xC4, 0x65, 0xA6, 0x93, 0xB2, 0xA3, 0x5D, 0x4E, 0xB6, 0x92, 0xA2, 0x6A, 0xE1, 0x4E, 0x33, 0x74];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D12Debug3
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [0x8F, 0xE5, 0xF4, 0x5C, 0x71, 0xF6, 0xF1, 0x4F, 0xA5, 0x42, 0x36, 0x86, 0xE3, 0xD1, 0x53, 0xD1];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D12Debug4
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [0x6E, 0x81, 0x4B, 0x01, 0xC5, 0x9E, 0x2F, 0x4A, 0xA8, 0x45, 0xFF, 0xBE, 0x44, 0x1C, 0xE1, 0x3A];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D12Debug5
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [0x12, 0x6B, 0x8D, 0x54, 0xFA, 0x09, 0xE0, 0x40, 0x90, 0x69, 0x5D, 0xCD, 0x58, 0x9A, 0x52, 0xC9];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D12Debug6
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [0xD6, 0x16, 0xA8, 0x82, 0x01, 0x5D, 0x57, 0x41, 0x97, 0xD0, 0x49, 0x75, 0x46, 0x3F, 0xD1, 0xED];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D12DebugDevice1
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [0x70, 0x17, 0xB7, 0xA9, 0x99, 0xD0, 0x65, 0x4A, 0xA6, 0x98, 0x3D, 0xEE, 0x10, 0x02, 0x0F, 0x88];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D12DebugDevice
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [0xDD, 0xD6, 0xEB, 0x3F, 0x73, 0x49, 0x87, 0x47, 0x81, 0x94, 0xE4, 0x5F, 0x9E, 0x28, 0x92, 0x3E];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D12DebugDevice2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [0xC1, 0xCB, 0xEC, 0x60, 0x8D, 0x37, 0xF1, 0x4D, 0x89, 0x4C, 0xF8, 0xAC, 0x5C, 0xE4, 0xD7, 0xDD];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D12DebugCommandQueue
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [0x36, 0xBF, 0xE0, 0x09, 0xAC, 0x54, 0x4F, 0x48, 0x88, 0x47, 0x4B, 0xAE, 0xEA, 0xB6, 0x05, 0x3A];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D12DebugCommandQueue1
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [0xA2, 0x35, 0xBE, 0x16, 0xD6, 0xBF, 0xF2, 0x49, 0xBC, 0xAE, 0xEA, 0xAE, 0x4A, 0xFF, 0x86, 0x2D];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D12DebugCommandList1
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [0x51, 0xA9, 0x2C, 0x10, 0x1B, 0x31, 0x01, 0x4B, 0xB1, 0x1F, 0xEC, 0xB8, 0x3E, 0x06, 0x1B, 0x37];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D12DebugCommandList
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [0x36, 0xBF, 0xE0, 0x09, 0xAC, 0x54, 0x4F, 0x48, 0x88, 0x47, 0x4B, 0xAE, 0xEA, 0xB6, 0x05, 0x3F];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D12DebugCommandList2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [0xCF, 0x75, 0xB5, 0xAE, 0x06, 0x4E, 0xBE, 0x48, 0xBA, 0x3B, 0xC4, 0x50, 0xFC, 0x96, 0x65, 0x2E];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D12DebugCommandList3
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [0x15, 0x5E, 0x7D, 0x19, 0x37, 0x4D, 0x34, 0x4D, 0xAF, 0x78, 0x72, 0x4C, 0xD7, 0x0F, 0xDB, 0x1F];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D12SharingContract
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [0x52, 0x7D, 0xDF, 0x0A, 0x9C, 0x92, 0x61, 0x4E, 0xAD, 0xDB, 0xFF, 0xED, 0x30, 0xDE, 0x66, 0xEF];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D12InfoQueue
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [0x0B, 0xA9, 0x42, 0x07, 0x87, 0xC3, 0x3F, 0x48, 0xB9, 0x46, 0x30, 0xA7, 0xE4, 0xE6, 0x14, 0x58];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D12InfoQueue1
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [0x88, 0xDD, 0x52, 0x28, 0x84, 0xB4, 0x0C, 0x4C, 0xB6, 0xB1, 0x67, 0x16, 0x85, 0x00, 0xE6, 0x00];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}