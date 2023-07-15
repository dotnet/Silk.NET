// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/UIAnimation.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;
public static partial class CLSID
{
    public static ref readonly Guid CLSID_UIAnimationManager
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x3A,
                0xC6,
                0x1F,
                0x4C,
                0x5C,
                0x69,
                0xE8,
                0x47,
                0xA3,
                0x39,
                0x1A,
                0x19,
                0x4B,
                0xE3,
                0xD0,
                0xB8
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_UIAnimationManager2
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x42,
                0x88,
                0x5D,
                0xD2,
                0x84,
                0x88,
                0x4A,
                0x4A,
                0xB3,
                0x21,
                0x09,
                0x13,
                0x14,
                0x37,
                0x9B,
                0xDD
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_UIAnimationTransitionLibrary
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xAD,
                0x22,
                0x63,
                0x1D,
                0x85,
                0xAA,
                0xF5,
                0x4E,
                0xA8,
                0x28,
                0x86,
                0xD7,
                0x10,
                0x67,
                0xD1,
                0x45
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_UIAnimationTransitionLibrary2
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x4A,
                0x94,
                0x2F,
                0x81,
                0xC8,
                0xC5,
                0xD9,
                0x4C,
                0xB0,
                0xA6,
                0xB3,
                0xDA,
                0x80,
                0x2F,
                0x22,
                0x8D
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_UIAnimationTransitionFactory
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xDD,
                0x1C,
                0x9B,
                0x8A,
                0xD7,
                0xFC,
                0x9C,
                0x41,
                0x8B,
                0x44,
                0x42,
                0xFD,
                0x17,
                0xDB,
                0x18,
                0x87
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_UIAnimationTransitionFactory2
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x97,
                0x2F,
                0x30,
                0x84,
                0x7B,
                0x7F,
                0x40,
                0x40,
                0xB1,
                0x90,
                0x72,
                0xAC,
                0x9D,
                0x18,
                0xE4,
                0x20
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_UIAnimationTimer
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x0C,
                0x4A,
                0xCD,
                0xBF,
                0xB6,
                0x06,
                0x84,
                0x43,
                0xB7,
                0x68,
                0x0D,
                0xAA,
                0x79,
                0x2C,
                0x38,
                0x0E
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}