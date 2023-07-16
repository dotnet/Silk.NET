// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d11shadertracing.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;
public static partial class IID
{
    public static ref readonly Guid IID_ID3D11ShaderTrace
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xE6,
                0x13,
                0xB0,
                0x36,
                0x11,
                0x28,
                0x45,
                0x48,
                0xBA,
                0xA7,
                0xD6,
                0x23,
                0xFE,
                0x0D,
                0xF1,
                0x04
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ID3D11ShaderTraceFactory
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x29,
                0xD4,
                0xBA,
                0x1F,
                0xAB,
                0x66,
                0xCC,
                0x41,
                0x96,
                0x17,
                0x66,
                0x7A,
                0xC1,
                0x0E,
                0x44,
                0x59
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}