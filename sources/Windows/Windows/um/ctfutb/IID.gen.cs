// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ctfutb.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;
public static partial class IID
{
    public static ref readonly Guid IID_ITfLangBarMgr
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x90,
                0x56,
                0x95,
                0x87,
                0x27,
                0xE6,
                0xD2,
                0x11,
                0x8D,
                0xDB,
                0x00,
                0x10,
                0x5A,
                0x27,
                0x99,
                0xB5
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ITfLangBarEventSink
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x00,
                0xE9,
                0xA4,
                0x18,
                0xAE,
                0xE0,
                0xD2,
                0x11,
                0xAF,
                0xDD,
                0x00,
                0x10,
                0x5A,
                0x27,
                0x99,
                0xB5
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ITfLangBarItemSink
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xA0,
                0xE1,
                0xDB,
                0x57,
                0x25,
                0xDE,
                0xD2,
                0x11,
                0xAF,
                0xDD,
                0x00,
                0x10,
                0x5A,
                0x27,
                0x99,
                0xB5
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IEnumTfLangBarItems
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xD0,
                0x34,
                0x3F,
                0x58,
                0x25,
                0xDE,
                0xD2,
                0x11,
                0xAF,
                0xDD,
                0x00,
                0x10,
                0x5A,
                0x27,
                0x99,
                0xB5
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ITfLangBarItemMgr
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x55,
                0x8C,
                0x46,
                0xBA,
                0x56,
                0x99,
                0xB1,
                0x4F,
                0xA5,
                0x9D,
                0x52,
                0xA7,
                0xDD,
                0x7C,
                0xC6,
                0xAA
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ITfLangBarItem
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x69,
                0x0D,
                0x54,
                0x73,
                0xEB,
                0xED,
                0xE9,
                0x4E,
                0x96,
                0xC9,
                0x23,
                0xAA,
                0x30,
                0xB2,
                0x59,
                0x16
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ITfSystemLangBarItemSink
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xAB,
                0xD9,
                0x49,
                0x14,
                0xCF,
                0x13,
                0x87,
                0x46,
                0xAA,
                0x3E,
                0x8D,
                0x8B,
                0x18,
                0x57,
                0x43,
                0x96
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ITfSystemLangBarItem
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xEC,
                0xE9,
                0x13,
                0x1E,
                0x33,
                0x6B,
                0x4A,
                0x4D,
                0xB5,
                0xEB,
                0x8A,
                0x92,
                0xF0,
                0x29,
                0xF3,
                0x56
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ITfSystemLangBarItemText
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xE5,
                0xE0,
                0x4C,
                0x5C,
                0x49,
                0xBA,
                0x52,
                0x4B,
                0xAC,
                0x6B,
                0x3B,
                0x39,
                0x7B,
                0x4F,
                0x70,
                0x1F
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ITfSystemDeviceTypeLangBarItem
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xB9,
                0x2E,
                0x67,
                0x45,
                0x59,
                0x90,
                0xA2,
                0x46,
                0x83,
                0x8D,
                0x45,
                0x30,
                0x35,
                0x5F,
                0x6A,
                0x77
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ITfLangBarItemButton
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xD0,
                0xF1,
                0xC7,
                0x28,
                0x25,
                0xDE,
                0xD2,
                0x11,
                0xAF,
                0xDD,
                0x00,
                0x10,
                0x5A,
                0x27,
                0x99,
                0xB5
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ITfLangBarItemBitmapButton
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x25,
                0x05,
                0x6A,
                0xA2,
                0xAE,
                0x3F,
                0xA0,
                0x4F,
                0x89,
                0xEE,
                0x88,
                0xA9,
                0x64,
                0xF9,
                0xF1,
                0xB5
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ITfLangBarItemBitmap
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x52,
                0x03,
                0x83,
                0x73,
                0x22,
                0xD7,
                0x79,
                0x41,
                0xAD,
                0xA5,
                0xF0,
                0x45,
                0xC9,
                0x8D,
                0xF3,
                0x55
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ITfLangBarItemBalloon
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x85,
                0xD2,
                0xC2,
                0x01,
                0xC7,
                0xD3,
                0x7B,
                0x4B,
                0xB5,
                0xB5,
                0xD9,
                0x74,
                0x11,
                0xD0,
                0xC2,
                0x83
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ITfMenu
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xE4,
                0x98,
                0x8A,
                0x6F,
                0xA0,
                0xAA,
                0x15,
                0x4F,
                0x8C,
                0x5B,
                0x07,
                0xE0,
                0xDF,
                0x0A,
                0x3D,
                0xD8
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}