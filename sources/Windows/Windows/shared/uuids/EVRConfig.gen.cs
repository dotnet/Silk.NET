// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/uuids.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;
public static partial class EVRConfig
{
    [NativeTypeName("const GUID")]
    public static ref readonly Guid EVRConfig_ForceBob
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x01,
                0xDF,
                0x47,
                0xE4,
                0xCA,
                0x10,
                0x17,
                0x4D,
                0xB1,
                0x7E,
                0x6A,
                0x84,
                0x0F,
                0x8A,
                0x3A,
                0x4C
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid EVRConfig_AllowDropToBob
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x02,
                0xDF,
                0x47,
                0xE4,
                0xCA,
                0x10,
                0x17,
                0x4D,
                0xB1,
                0x7E,
                0x6A,
                0x84,
                0x0F,
                0x8A,
                0x3A,
                0x4C
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid EVRConfig_ForceThrottle
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x03,
                0xDF,
                0x47,
                0xE4,
                0xCA,
                0x10,
                0x17,
                0x4D,
                0xB1,
                0x7E,
                0x6A,
                0x84,
                0x0F,
                0x8A,
                0x3A,
                0x4C
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid EVRConfig_AllowDropToThrottle
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x04,
                0xDF,
                0x47,
                0xE4,
                0xCA,
                0x10,
                0x17,
                0x4D,
                0xB1,
                0x7E,
                0x6A,
                0x84,
                0x0F,
                0x8A,
                0x3A,
                0x4C
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid EVRConfig_ForceHalfInterlace
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x05,
                0xDF,
                0x47,
                0xE4,
                0xCA,
                0x10,
                0x17,
                0x4D,
                0xB1,
                0x7E,
                0x6A,
                0x84,
                0x0F,
                0x8A,
                0x3A,
                0x4C
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid EVRConfig_AllowDropToHalfInterlace
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x06,
                0xDF,
                0x47,
                0xE4,
                0xCA,
                0x10,
                0x17,
                0x4D,
                0xB1,
                0x7E,
                0x6A,
                0x84,
                0x0F,
                0x8A,
                0x3A,
                0x4C
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid EVRConfig_ForceScaling
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x07,
                0xDF,
                0x47,
                0xE4,
                0xCA,
                0x10,
                0x17,
                0x4D,
                0xB1,
                0x7E,
                0x6A,
                0x84,
                0x0F,
                0x8A,
                0x3A,
                0x4C
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid EVRConfig_AllowScaling
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x08,
                0xDF,
                0x47,
                0xE4,
                0xCA,
                0x10,
                0x17,
                0x4D,
                0xB1,
                0x7E,
                0x6A,
                0x84,
                0x0F,
                0x8A,
                0x3A,
                0x4C
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid EVRConfig_ForceBatching
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x09,
                0xDF,
                0x47,
                0xE4,
                0xCA,
                0x10,
                0x17,
                0x4D,
                0xB1,
                0x7E,
                0x6A,
                0x84,
                0x0F,
                0x8A,
                0x3A,
                0x4C
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid EVRConfig_AllowBatching
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x0A,
                0xDF,
                0x47,
                0xE4,
                0xCA,
                0x10,
                0x17,
                0x4D,
                0xB1,
                0x7E,
                0x6A,
                0x84,
                0x0F,
                0x8A,
                0x3A,
                0x4C
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}