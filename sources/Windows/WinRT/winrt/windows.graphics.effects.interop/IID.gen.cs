// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.graphics.effects.interop.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;
public static partial class IID
{
    public static ref readonly Guid IID_IGraphicsEffectD2D1Interop
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x84,
                0x73,
                0xC5,
                0x2F,
                0x68,
                0xA0,
                0xD7,
                0x44,
                0xA3,
                0x31,
                0x30,
                0x98,
                0x2F,
                0xCF,
                0x71,
                0x77
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}