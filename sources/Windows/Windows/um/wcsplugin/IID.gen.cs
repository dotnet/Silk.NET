// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wcsplugin.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;
public static partial class IID
{
    public static ref readonly Guid IID_IDeviceModelPlugIn
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x75,
                0x34,
                0xD6,
                0x1C,
                0xC4,
                0x07,
                0xFE,
                0x46,
                0xA9,
                0x03,
                0xD6,
                0x55,
                0x31,
                0x6D,
                0x11,
                0xFD
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IGamutMapModelPlugIn
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x15,
                0x01,
                0xD8,
                0x2D,
                0x1E,
                0xAD,
                0xF6,
                0x41,
                0xA2,
                0x19,
                0xA4,
                0xF4,
                0xB5,
                0x83,
                0xD1,
                0xF9
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}