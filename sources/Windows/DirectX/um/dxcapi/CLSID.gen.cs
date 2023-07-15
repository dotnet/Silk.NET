// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dxcapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the University of Illinois Open Source License.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.DirectX;

namespace TerraFX.Interop.Windows;
public static partial class CLSID
{
    [NativeTypeName("const CLSID")]
    public static ref readonly Guid CLSID_DxcCompiler
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x93,
                0x2D,
                0xE2,
                0x73,
                0xCE,
                0xE6,
                0xF3,
                0x47,
                0xB5,
                0xBF,
                0xF0,
                0x66,
                0x4F,
                0x39,
                0xC1,
                0xB0
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_DxcLinker
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x87,
                0x80,
                0x6A,
                0xEF,
                0xEA,
                0xB0,
                0x56,
                0x4D,
                0x9E,
                0x45,
                0xD0,
                0x7E,
                0x1A,
                0x8B,
                0x78,
                0x06
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const CLSID")]
    public static ref readonly Guid CLSID_DxcDiaDataSource
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x73,
                0x6B,
                0x1F,
                0xCD,
                0xB0,
                0x2A,
                0x4D,
                0x48,
                0x8E,
                0xDC,
                0xEB,
                0xE7,
                0xA4,
                0x3C,
                0xA0,
                0x9F
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const CLSID")]
    public static ref readonly Guid CLSID_DxcCompilerArgs
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x82,
                0xAE,
                0x56,
                0x3E,
                0x4D,
                0x22,
                0x0F,
                0x47,
                0xA1,
                0xA1,
                0xFE,
                0x30,
                0x16,
                0xEE,
                0x9F,
                0x9D
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_DxcLibrary
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xAF,
                0xD6,
                0x45,
                0x62,
                0xE0,
                0x66,
                0xFD,
                0x48,
                0x80,
                0xB4,
                0x4D,
                0x27,
                0x17,
                0x96,
                0x74,
                0x8C
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_DxcUtils => ref CLSID_DxcLibrary;

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_DxcValidator
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x15,
                0xE2,
                0xA3,
                0x8C,
                0x28,
                0xF7,
                0xF3,
                0x4C,
                0x8C,
                0xDD,
                0x88,
                0xAF,
                0x91,
                0x75,
                0x87,
                0xA1
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_DxcAssembler
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x68,
                0xDB,
                0x28,
                0xD7,
                0x03,
                0xF9,
                0x80,
                0x4F,
                0x94,
                0xCD,
                0xDC,
                0xCF,
                0x76,
                0xEC,
                0x71,
                0x51
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_DxcContainerReflection
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x89,
                0x44,
                0xF5,
                0xB9,
                0xB8,
                0x55,
                0x0C,
                0x40,
                0xBA,
                0x3A,
                0x16,
                0x75,
                0xE4,
                0x72,
                0x8B,
                0x91
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_DxcOptimizer
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x9F,
                0xD7,
                0x2C,
                0xAE,
                0x22,
                0xCC,
                0x3F,
                0x45,
                0x9B,
                0x6B,
                0xB1,
                0x24,
                0xE7,
                0xA5,
                0x20,
                0x4C
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_DxcContainerBuilder
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x94,
                0x42,
                0x13,
                0x94,
                0x1F,
                0x41,
                0x74,
                0x45,
                0xB4,
                0xD0,
                0x87,
                0x41,
                0xE2,
                0x52,
                0x40,
                0xD2
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_DxcPdbUtils
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xFB,
                0x1D,
                0x62,
                0x54,
                0xCE,
                0xF2,
                0x7E,
                0x45,
                0xAE,
                0x8C,
                0xEC,
                0x35,
                0x5F,
                0xAE,
                0xEC,
                0x7C
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}