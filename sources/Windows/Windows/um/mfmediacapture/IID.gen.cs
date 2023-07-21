// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfmediacapture.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;

public static partial class IID
{
    public static ref readonly Guid IID_IAdvancedMediaCaptureInitializationSettings
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x09, 0x12, 0xE2, 0x3D,
                0xA6, 0x8B,
                0x2A, 0x4F,
                0xA5,
                0x77,
                0x28,
                0x19,
                0xB5,
                0x6F,
                0xF1,
                0x4D
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IAdvancedMediaCaptureSettings
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x5F, 0x48, 0xE0, 0x24,
                0x3E, 0xA3,
                0xA1, 0x4A,
                0xB5,
                0x64,
                0x60,
                0x19,
                0xB1,
                0xD1,
                0x4F,
                0x65
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IAdvancedMediaCapture
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x85, 0x15, 0x75, 0xD0,
                0x16, 0xD2,
                0x44, 0x43,
                0xB5,
                0xBF,
                0x46,
                0x3B,
                0x68,
                0xF9,
                0x77,
                0xBB
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
