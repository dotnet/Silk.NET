// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfcaptureengine.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;

public static partial class CLSID
{
    [NativeTypeName("const IID")]
    public static ref readonly Guid CLSID_MFCaptureEngine
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xD3, 0x38, 0xCE, 0xEF,
                0x14, 0x89,
                0x74, 0x46,
                0xA7,
                0xDF,
                0xAE,
                0x1B,
                0x3D,
                0x65,
                0x4B,
                0x8A
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid CLSID_MFCaptureEngineClassFactory
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xD3, 0x38, 0xCE, 0xEF,
                0x14, 0x89,
                0x74, 0x46,
                0xA7,
                0xDF,
                0xAE,
                0x1B,
                0x3D,
                0x65,
                0x4B,
                0x8A
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
