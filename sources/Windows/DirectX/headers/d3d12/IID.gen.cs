// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.DirectX;

namespace TerraFX.Interop.Windows;
public static partial class IID
{
    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D12Object
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x8F,
                0xC2,
                0xFE,
                0xC4,
                0x66,
                0x79,
                0x95,
                0x4E,
                0x9F,
                0x94,
                0xF4,
                0x31,
                0xCB,
                0x56,
                0xC3,
                0xB8
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D12DeviceChild
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x4B,
                0xB9,
                0x5D,
                0x90,
                0x0C,
                0xA0,
                0x40,
                0x41,
                0x9D,
                0xF5,
                0x2B,
                0x64,
                0xCA,
                0x9E,
                0xA3,
                0x57
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D12RootSignature
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x66,
                0x6B,
                0x4A,
                0xC5,
                0xDF,
                0x72,
                0xE8,
                0x4E,
                0x8B,
                0xE5,
                0xA9,
                0x46,
                0xA1,
                0x42,
                0x92,
                0x14
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D12RootSignatureDeserializer
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x7B,
                0x64,
                0xAB,
                0x34,
                0xC8,
                0x3C,
                0xAC,
                0x46,
                0x84,
                0x1B,
                0xC0,
                0x96,
                0x56,
                0x45,
                0xC0,
                0x46
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D12VersionedRootSignatureDeserializer
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x67,
                0xCE,
                0x91,
                0x7F,
                0x0C,
                0x09,
                0xB7,
                0x4B,
                0xB7,
                0x8E,
                0xED,
                0x8F,
                0xF2,
                0xE3,
                0x1D,
                0xA0
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D12Pageable
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xFB,
                0x58,
                0xEE,
                0x63,
                0x68,
                0x12,
                0x35,
                0x48,
                0x86,
                0xDA,
                0xF0,
                0x08,
                0xCE,
                0x62,
                0xF0,
                0xD6
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D12Heap
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x02,
                0x25,
                0x3B,
                0x6B,
                0x51,
                0x6E,
                0xB3,
                0x45,
                0x90,
                0xEE,
                0x98,
                0x84,
                0x26,
                0x5E,
                0x8D,
                0xF3
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D12Resource
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xBE,
                0x42,
                0x64,
                0x69,
                0x2E,
                0xA7,
                0x59,
                0x40,
                0xBC,
                0x79,
                0x5B,
                0x5C,
                0x98,
                0x04,
                0x0F,
                0xAD
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D12CommandAllocator
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xE4,
                0xDE,
                0x02,
                0x61,
                0x59,
                0xAF,
                0x09,
                0x4B,
                0xB9,
                0x99,
                0xB4,
                0x4D,
                0x73,
                0xF0,
                0x9B,
                0x24
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D12Fence
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xCF,
                0x3D,
                0x75,
                0x0A,
                0xD8,
                0xC4,
                0x91,
                0x4B,
                0xAD,
                0xF6,
                0xBE,
                0x5A,
                0x60,
                0xD9,
                0x5A,
                0x76
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D12Fence1
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xFE,
                0x85,
                0x36,
                0x43,
                0x2B,
                0xE2,
                0xA0,
                0x4C,
                0xA8,
                0xDB,
                0xB5,
                0xB4,
                0xF4,
                0xDD,
                0x0E,
                0x4A
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D12PipelineState
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xF3,
                0x30,
                0x5A,
                0x76,
                0x24,
                0xF6,
                0x6F,
                0x4C,
                0xA8,
                0x28,
                0xAC,
                0xE9,
                0x48,
                0x62,
                0x24,
                0x45
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D12DescriptorHeap
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x1D,
                0x47,
                0xFB,
                0x8E,
                0x6C,
                0x61,
                0x49,
                0x4F,
                0x90,
                0xF7,
                0x12,
                0x7B,
                0xB7,
                0x63,
                0xFA,
                0x51
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D12QueryHeap
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xAE,
                0x58,
                0x96,
                0x0D,
                0x45,
                0xED,
                0x9E,
                0x46,
                0xA6,
                0x1D,
                0x97,
                0x0E,
                0xC5,
                0x83,
                0xCA,
                0xB4
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D12CommandSignature
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x7C,
                0x79,
                0x6A,
                0xC3,
                0x80,
                0xEC,
                0x0A,
                0x4F,
                0x89,
                0x85,
                0xA7,
                0xB2,
                0x47,
                0x50,
                0x82,
                0xD1
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D12CommandList
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x1C,
                0xD9,
                0x16,
                0x71,
                0xE4,
                0xE7,
                0xCE,
                0x47,
                0xB8,
                0xC6,
                0xEC,
                0x81,
                0x68,
                0xF4,
                0x37,
                0xE5
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D12GraphicsCommandList
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x0F,
                0x0D,
                0x16,
                0x5B,
                0x1B,
                0xAC,
                0x85,
                0x41,
                0x8B,
                0xA8,
                0xB3,
                0xAE,
                0x42,
                0xA5,
                0xA4,
                0x55
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D12GraphicsCommandList1
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xFB,
                0x03,
                0x31,
                0x55,
                0xE7,
                0x1F,
                0x57,
                0x45,
                0xBB,
                0x38,
                0x94,
                0x6D,
                0x7D,
                0x0E,
                0x7C,
                0xA7
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D12GraphicsCommandList2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x85,
                0xE5,
                0xC3,
                0x38,
                0x17,
                0xFF,
                0x2C,
                0x41,
                0x91,
                0x50,
                0x4F,
                0xC6,
                0xF9,
                0xD7,
                0x2A,
                0x28
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D12CommandQueue
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xA6,
                0x70,
                0xC8,
                0x0E,
                0x7E,
                0x5D,
                0x22,
                0x4C,
                0x8C,
                0xFC,
                0x5B,
                0xAA,
                0xE0,
                0x76,
                0x16,
                0xED
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D12Device
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xF1,
                0x19,
                0x98,
                0x18,
                0xB6,
                0x1D,
                0x57,
                0x4B,
                0xBE,
                0x54,
                0x18,
                0x21,
                0x33,
                0x9B,
                0x85,
                0xF7
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D12PipelineLibrary
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xA8,
                0x26,
                0x42,
                0xC6,
                0x01,
                0x92,
                0xAF,
                0x46,
                0xB4,
                0xCC,
                0x53,
                0xFB,
                0x9F,
                0xF7,
                0x41,
                0x4F
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D12PipelineLibrary1
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x42,
                0xBF,
                0xEA,
                0x80,
                0x68,
                0x25,
                0x5E,
                0x4E,
                0xBD,
                0x82,
                0xC3,
                0x7F,
                0x86,
                0x96,
                0x1D,
                0xC3
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D12Device1
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x80,
                0xCE,
                0xAC,
                0x77,
                0x8E,
                0x63,
                0x65,
                0x4E,
                0x88,
                0x95,
                0xC1,
                0xF2,
                0x33,
                0x86,
                0x86,
                0x3E
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D12Device2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x1E,
                0xA4,
                0xBA,
                0x30,
                0x5B,
                0xB1,
                0x5C,
                0x47,
                0xA0,
                0xBB,
                0x1A,
                0xF5,
                0xC5,
                0xB6,
                0x43,
                0x28
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D12Device3
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x15,
                0xDC,
                0xDA,
                0x81,
                0xAD,
                0x2B,
                0x92,
                0x43,
                0x93,
                0xC5,
                0x10,
                0x13,
                0x45,
                0xC4,
                0xAA,
                0x98
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D12ProtectedSession
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x18,
                0x3D,
                0x53,
                0xA1,
                0xC1,
                0x0A,
                0x84,
                0x40,
                0x85,
                0xB9,
                0x89,
                0xA9,
                0x61,
                0x16,
                0x80,
                0x6B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D12ProtectedResourceSession
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xF4,
                0x96,
                0xD6,
                0x6C,
                0x89,
                0xF2,
                0xCC,
                0x40,
                0x80,
                0x91,
                0x5A,
                0x6C,
                0x0A,
                0x09,
                0x9C,
                0x3D
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D12Device4
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x17,
                0xDF,
                0x65,
                0xE8,
                0xEE,
                0xA9,
                0xF9,
                0x46,
                0xA4,
                0x63,
                0x30,
                0x98,
                0x31,
                0x5A,
                0xA2,
                0xE5
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D12LifetimeOwner
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x9F,
                0xAF,
                0x67,
                0xE6,
                0x56,
                0xCD,
                0x46,
                0x4F,
                0x83,
                0xCE,
                0x03,
                0x2E,
                0x59,
                0x5D,
                0x70,
                0xA8
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D12SwapChainAssistant
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xB6,
                0x64,
                0xDF,
                0xF1,
                0xFD,
                0x57,
                0xCD,
                0x49,
                0x88,
                0x07,
                0xC0,
                0xEB,
                0x88,
                0xB4,
                0x5C,
                0x8F
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D12LifetimeTracker
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x36,
                0x3D,
                0xD0,
                0x3F,
                0xB1,
                0x4E,
                0x4A,
                0x42,
                0xA5,
                0x82,
                0x49,
                0x4E,
                0xCB,
                0x8B,
                0xA8,
                0x13
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D12StateObject
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x43,
                0x69,
                0x01,
                0x47,
                0xA8,
                0xFC,
                0x94,
                0x45,
                0x93,
                0xEA,
                0xAF,
                0x25,
                0x8B,
                0x55,
                0x34,
                0x6D
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D12StateObjectProperties
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x27,
                0xA8,
                0x5F,
                0xDE,
                0xF9,
                0x9B,
                0x26,
                0x4F,
                0x89,
                0xFF,
                0xD7,
                0xF5,
                0x6F,
                0xDE,
                0x38,
                0x60
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D12Device5
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x3B,
                0x17,
                0x4F,
                0x8B,
                0xEA,
                0x2F,
                0x80,
                0x4B,
                0x8F,
                0x58,
                0x43,
                0x07,
                0x19,
                0x1A,
                0xB9,
                0x5D
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D12DeviceRemovedExtendedDataSettings
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x1C,
                0x48,
                0xBC,
                0x82,
                0x9B,
                0x6B,
                0x30,
                0x40,
                0xAE,
                0xDB,
                0x7E,
                0xE3,
                0xD1,
                0xDF,
                0x1E,
                0x63
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D12DeviceRemovedExtendedDataSettings1
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x51,
                0xAE,
                0xD5,
                0xDB,
                0x17,
                0x33,
                0x0A,
                0x4F,
                0xAD,
                0xF9,
                0x1D,
                0x7C,
                0xED,
                0xCA,
                0xAE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D12DeviceRemovedExtendedDataSettings2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x88,
                0x23,
                0x55,
                0x61,
                0xAB,
                0x01,
                0x08,
                0x40,
                0xA4,
                0x36,
                0x83,
                0xDB,
                0x18,
                0x95,
                0x66,
                0xEA
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D12DeviceRemovedExtendedData
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x33,
                0x1D,
                0x93,
                0x98,
                0xE8,
                0x5A,
                0x91,
                0x47,
                0xAA,
                0x3C,
                0x1A,
                0x73,
                0xA2,
                0x93,
                0x4E,
                0x71
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D12DeviceRemovedExtendedData1
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x22,
                0xA0,
                0x27,
                0x97,
                0x1D,
                0xCF,
                0xDA,
                0x4D,
                0x9E,
                0xBA,
                0xEF,
                0xFA,
                0x65,
                0x3F,
                0xC5,
                0x06
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D12DeviceRemovedExtendedData2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x16,
                0x58,
                0xFC,
                0x67,
                0xCA,
                0xE4,
                0x15,
                0x49,
                0xBF,
                0x18,
                0x42,
                0x54,
                0x12,
                0x72,
                0xDA,
                0x54
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D12Device6
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x1B,
                0x22,
                0x0B,
                0xC7,
                0xE4,
                0x40,
                0x17,
                0x4A,
                0x89,
                0xAF,
                0x02,
                0x5A,
                0x07,
                0x27,
                0xA6,
                0xDC
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D12ProtectedResourceSession1
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xD6,
                0x2D,
                0xF1,
                0xD6,
                0xFB,
                0x76,
                0x6E,
                0x40,
                0x89,
                0x61,
                0x42,
                0x96,
                0xEE,
                0xFC,
                0x04,
                0x09
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D12Device7
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x53,
                0x4B,
                0x01,
                0x5C,
                0xA1,
                0x68,
                0x9B,
                0x4B,
                0x8B,
                0xD1,
                0xDD,
                0x60,
                0x46,
                0xB9,
                0x35,
                0x8B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D12Device8
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xBB,
                0xE6,
                0x18,
                0x92,
                0x44,
                0xF9,
                0x7E,
                0x4F,
                0xA7,
                0x5C,
                0xB1,
                0xB2,
                0xC7,
                0xB7,
                0x01,
                0xF3
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D12Resource1
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x7A,
                0x22,
                0x5E,
                0x9D,
                0x30,
                0x44,
                0x61,
                0x41,
                0x88,
                0xB3,
                0x3E,
                0xCA,
                0x6B,
                0xB1,
                0x6E,
                0x19
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D12Resource2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x3B,
                0xEC,
                0x36,
                0xBE,
                0x85,
                0xEA,
                0xEB,
                0x4A,
                0xA4,
                0x5A,
                0xE9,
                0xD7,
                0x64,
                0x04,
                0xA4,
                0x95
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D12Heap1
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x89,
                0x73,
                0x2F,
                0x57,
                0x68,
                0x21,
                0xE3,
                0x49,
                0x96,
                0x93,
                0xD6,
                0xDF,
                0x58,
                0x71,
                0xBF,
                0x6D
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D12GraphicsCommandList3
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xA7,
                0x83,
                0xDA,
                0x6F,
                0x4C,
                0xB8,
                0x38,
                0x4E,
                0x9A,
                0xC8,
                0xC7,
                0xBD,
                0x22,
                0x01,
                0x6B,
                0x3D
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D12MetaCommand
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x27,
                0x4C,
                0xB8,
                0xDB,
                0xCE,
                0x36,
                0xC9,
                0x4F,
                0xB8,
                0x01,
                0xF0,
                0x48,
                0xC4,
                0x6A,
                0xC5,
                0x70
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D12GraphicsCommandList4
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x8E,
                0x31,
                0x54,
                0x87,
                0xA9,
                0xD3,
                0x41,
                0x45,
                0x98,
                0xCF,
                0x64,
                0x5B,
                0x50,
                0xDC,
                0x48,
                0x74
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D12ShaderCacheSession
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x5D,
                0x49,
                0xE2,
                0x28,
                0x64,
                0x0F,
                0xE4,
                0x4A,
                0xA6,
                0xEC,
                0x12,
                0x92,
                0x55,
                0xDC,
                0x49,
                0xA8
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D12Device9
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x62,
                0xE9,
                0x80,
                0x4C,
                0x32,
                0xF0,
                0x60,
                0x4F,
                0xBC,
                0x9E,
                0xEB,
                0xC2,
                0xCF,
                0xA1,
                0xD8,
                0x3C
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D12Device10
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x18,
                0x87,
                0x7F,
                0x51,
                0x66,
                0xAA,
                0xF9,
                0x49,
                0xB0,
                0x2B,
                0xA7,
                0xAB,
                0x89,
                0xC0,
                0x60,
                0x31
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D12Device11
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x44,
                0xC3,
                0x05,
                0x54,
                0x57,
                0xD4,
                0x4E,
                0x44,
                0xB4,
                0xDD,
                0x23,
                0x66,
                0xE4,
                0x5A,
                0xEE,
                0x39
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D12VirtualizationGuestDevice
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x68,
                0xD3,
                0x66,
                0xBC,
                0x73,
                0x73,
                0x43,
                0x49,
                0x87,
                0x57,
                0xFC,
                0x87,
                0xDC,
                0x79,
                0xE4,
                0x76
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D12Tools
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xF0,
                0xE1,
                0x71,
                0x70,
                0x4B,
                0xE8,
                0x33,
                0x4B,
                0x97,
                0x4F,
                0x12,
                0xFA,
                0x49,
                0xDE,
                0x65,
                0xC5
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D12SDKConfiguration
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x14,
                0x53,
                0xEB,
                0xE9,
                0xAA,
                0x33,
                0xB2,
                0x42,
                0xA7,
                0x18,
                0xD7,
                0x7F,
                0x58,
                0xB1,
                0xF1,
                0xC7
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D12SDKConfiguration1
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x03,
                0x93,
                0xAF,
                0x8A,
                0x25,
                0xAD,
                0xB9,
                0x48,
                0x9A,
                0x57,
                0xD9,
                0xC3,
                0x7E,
                0x00,
                0x9D,
                0x9F
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D12DeviceFactory
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xD3,
                0x07,
                0xF3,
                0x61,
                0x4E,
                0xD3,
                0x7C,
                0x4E,
                0x83,
                0x74,
                0x3B,
                0xA4,
                0xDE,
                0x23,
                0xCC,
                0xCB
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D12DeviceConfiguration
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x7B,
                0xF8,
                0xDB,
                0x78,
                0x66,
                0xF7,
                0x2B,
                0x42,
                0xA6,
                0x1C,
                0xC8,
                0xC4,
                0x46,
                0xBD,
                0xB9,
                0xAD
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D12GraphicsCommandList5
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x59,
                0x08,
                0x05,
                0x55,
                0x24,
                0x40,
                0x4C,
                0x47,
                0x87,
                0xF5,
                0x64,
                0x72,
                0xEA,
                0xEE,
                0x44,
                0xEA
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D12GraphicsCommandList6
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x90,
                0x78,
                0x82,
                0xC3,
                0x48,
                0xE5,
                0xFA,
                0x4C,
                0x96,
                0xCF,
                0x56,
                0x89,
                0xA9,
                0x37,
                0x0F,
                0x80
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D12GraphicsCommandList7
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x23,
                0x12,
                0x17,
                0xDD,
                0x61,
                0x8B,
                0x69,
                0x47,
                0x90,
                0xE3,
                0x16,
                0x0C,
                0xCD,
                0xE4,
                0xE2,
                0xC1
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D12GraphicsCommandList8
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xF9,
                0x6E,
                0x93,
                0xEE,
                0x9D,
                0x59,
                0x28,
                0x4D,
                0x93,
                0x8E,
                0x23,
                0xC4,
                0xAD,
                0x05,
                0xCE,
                0x51
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}