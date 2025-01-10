// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/IContact.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class IID
{
    public static ref readonly Guid IID_IContactManager
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x98,
                0x3D,
                0x55,
                0xAD,
                0xB1,
                0xDE,
                0x4A,
                0x47,
                0x8E,
                0x17,
                0xFC,
                0x0C,
                0x20,
                0x75,
                0xB7,
                0x38,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IContactCollection
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x38,
                0xA3,
                0xAF,
                0xB6,
                0x79,
                0xD7,
                0xD9,
                0x11,
                0x8B,
                0xDE,
                0xF6,
                0x6B,
                0xAD,
                0x1E,
                0x3F,
                0x3A,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IContactProperties
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xDD,
                0x27,
                0xDD,
                0x70,
                0xBD,
                0x5C,
                0xE8,
                0x46,
                0xBE,
                0xF0,
                0x23,
                0xB6,
                0xB3,
                0x46,
                0x28,
                0x8F,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IContact
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x71,
                0xB6,
                0x41,
                0xF9,
                0xA7,
                0xBD,
                0x77,
                0x4F,
                0x88,
                0x4A,
                0xF4,
                0x64,
                0x62,
                0xF2,
                0x26,
                0xA7,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IContactPropertyCollection
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF8,
                0xAD,
                0xD3,
                0xFF,
                0x64,
                0xFA,
                0x28,
                0x43,
                0xB1,
                0xB6,
                0x2E,
                0x0D,
                0xB5,
                0x09,
                0xCB,
                0x3C,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
