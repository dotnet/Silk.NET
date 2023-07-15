// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/inputpanelconfiguration.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;
public static partial class IID
{
    public static ref readonly Guid IID_IInputPanelConfiguration
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x92,
                0x15,
                0xC8,
                0x41,
                0x4C,
                0x51,
                0xBD,
                0x48,
                0xA2,
                0x2E,
                0xE6,
                0xAF,
                0x63,
                0x85,
                0x21,
                0xA6
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IInputPanelInvocationConfiguration
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x36,
                0xF1,
                0x13,
                0xA2,
                0x45,
                0x3B,
                0x62,
                0x43,
                0xA3,
                0x32,
                0xEF,
                0xB6,
                0x54,
                0x7C,
                0xD4,
                0x32
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_InputPanelConfiguration
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xD3,
                0xAD,
                0x53,
                0x28,
                0x96,
                0xF0,
                0x63,
                0x4C,
                0xA7,
                0x8F,
                0x7F,
                0xA3,
                0xEA,
                0x83,
                0x7F,
                0xB7
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}