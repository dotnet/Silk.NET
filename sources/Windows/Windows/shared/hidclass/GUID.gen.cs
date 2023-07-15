// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/hidclass.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;
public static partial class GUID
{
    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_DEVINTERFACE_HID
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xB2,
                0x55,
                0x1E,
                0x4D,
                0x6F,
                0xF1,
                0xCF,
                0x11,
                0x88,
                0xCB,
                0x00,
                0x11,
                0x11,
                0x00,
                0x00,
                0x30
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_HID_INTERFACE_NOTIFY
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x88,
                0x2E,
                0x4E,
                0x2C,
                0xE6,
                0x25,
                0x33,
                0x4C,
                0x88,
                0x2F,
                0x3D,
                0x82,
                0xE6,
                0x07,
                0x36,
                0x81
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_HID_INTERFACE_HIDPARSE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xA5,
                0x15,
                0xC3,
                0xF5,
                0xAC,
                0x69,
                0xC2,
                0x4B,
                0x92,
                0x79,
                0xD0,
                0xB6,
                0x45,
                0x76,
                0xF4,
                0x4B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("#define GUID_CLASS_INPUT GUID_DEVINTERFACE_HID")]
    public static ref readonly Guid GUID_CLASS_INPUT => ref GUID_DEVINTERFACE_HID;
}