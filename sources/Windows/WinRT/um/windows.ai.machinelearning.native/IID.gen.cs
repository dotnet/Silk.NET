// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/windows.ai.machinelearning.native.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;
public static partial class IID
{
    public static ref readonly Guid IID_ILearningModelOperatorProviderNative
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x3A,
                0xA2,
                0xDA,
                0x1A,
                0x67,
                0xEB,
                0xF3,
                0x41,
                0xAA,
                0xD8,
                0x5D,
                0x98,
                0x4E,
                0x9B,
                0xAC,
                0xD4
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ITensorNative
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xEF,
                0x47,
                0xF5,
                0x52,
                0x03,
                0x5B,
                0xB5,
                0x49,
                0x82,
                0xD6,
                0x56,
                0x5F,
                0x1E,
                0xE0,
                0xDD,
                0x49
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ITensorStaticsNative
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xA4,
                0x55,
                0xD0,
                0x39,
                0xF6,
                0x66,
                0xBC,
                0x4E,
                0x95,
                0xD9,
                0x7A,
                0x29,
                0xEB,
                0xE7,
                0x69,
                0x0A
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ILearningModelDeviceFactoryNative
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xA1,
                0x31,
                0x9B,
                0x1E,
                0x2E,
                0x66,
                0xE0,
                0x4A,
                0xAF,
                0x67,
                0xF6,
                0x3B,
                0xB3,
                0x37,
                0xE6,
                0x34
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ILearningModelSessionOptionsNative
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x3F,
                0x95,
                0x1E,
                0xC7,
                0xB4,
                0x37,
                0x64,
                0x45,
                0x86,
                0x58,
                0xD8,
                0x39,
                0x68,
                0x66,
                0xDB,
                0x0D
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ILearningModelSessionOptionsNative1
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x26,
                0x7A,
                0xA3,
                0x5D,
                0x26,
                0x05,
                0x4B,
                0x41,
                0x91,
                0xE4,
                0x2A,
                0x0F,
                0xA3,
                0xDD,
                0xBA,
                0x40
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}