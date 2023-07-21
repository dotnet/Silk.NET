// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SpatialAudioMetadata.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;

public static partial class IID
{
    public static ref readonly Guid IID_ISpatialAudioMetadataItems
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x8F, 0xC7, 0xD7, 0xBC,
                0x98, 0x30,
                0x22, 0x4F,
                0xB5,
                0x47,
                0xA2,
                0xF2,
                0x5A,
                0x38,
                0x12,
                0x69
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISpatialAudioMetadataWriter
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x01, 0xCA, 0x17, 0x1B,
                0x55, 0x29,
                0x4D, 0x44,
                0xA4,
                0x30,
                0x53,
                0x7D,
                0xC5,
                0x89,
                0xA8,
                0x44
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISpatialAudioMetadataReader
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xA2, 0x86, 0x8E, 0xB7,
                0xD9, 0x31,
                0x32, 0x4C,
                0x94,
                0xD2,
                0x7D,
                0xF4,
                0x0F,
                0xC7,
                0xEB,
                0xEC
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISpatialAudioMetadataCopier
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x33, 0xB2, 0x24, 0xD2,
                0x51, 0xE2,
                0xD0, 0x4F,
                0x9C,
                0xA2,
                0xD5,
                0xEC,
                0xF9,
                0xA6,
                0x84,
                0x04
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISpatialAudioMetadataItemsBuffer
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x16, 0x0A, 0x64, 0x42,
                0xBD, 0xE1,
                0xD9, 0x42,
                0x9F,
                0xF6,
                0x03,
                0x1A,
                0xB7,
                0x1A,
                0x2D,
                0xBA
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISpatialAudioMetadataClient
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x3B, 0x4A, 0x7D, 0x77,
                0xFF, 0xF6,
                0x26, 0x4A,
                0x85,
                0xDC,
                0x68,
                0xD7,
                0xCD,
                0xED,
                0xA1,
                0xD4
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISpatialAudioObjectForMetadataCommands
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x4B, 0xC9, 0xF2, 0x0D,
                0xF9, 0xF5,
                0x2D, 0x47,
                0xAF,
                0x6B,
                0xC4,
                0x6E,
                0x0A,
                0xC9,
                0xCD,
                0x05
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISpatialAudioObjectForMetadataItems
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xFF, 0x49, 0xEA, 0xDD,
                0xC0, 0x3B,
                0x77, 0x43,
                0x8A,
                0xAD,
                0x9F,
                0xBC,
                0xFD,
                0x80,
                0x85,
                0x66
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISpatialAudioObjectRenderStreamForMetadata
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x07, 0xC9, 0xC9, 0xBB,
                0xD5, 0x48,
                0x2E, 0x4A,
                0xA0,
                0xC7,
                0xF7,
                0xF0,
                0xD6,
                0x7C,
                0x1F,
                0xB1
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
