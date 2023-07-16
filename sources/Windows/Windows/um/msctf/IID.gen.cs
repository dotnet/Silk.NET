// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/msctf.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;
public static partial class IID
{
    public static ref readonly Guid IID_ITfThreadMgr
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x01,
                0xE8,
                0x80,
                0xAA,
                0x21,
                0x20,
                0xD2,
                0x11,
                0x93,
                0xE0,
                0x00,
                0x60,
                0xB0,
                0x67,
                0xB8,
                0x6E
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ITfThreadMgrEx
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xE3,
                0xAD,
                0x90,
                0x3E,
                0x94,
                0x75,
                0xB0,
                0x4C,
                0xBB,
                0x58,
                0x69,
                0x62,
                0x8F,
                0x5F,
                0x45,
                0x8C
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ITfThreadMgr2
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xEF,
                0x98,
                0xB1,
                0x0A,
                0x77,
                0x64,
                0xE8,
                0x4E,
                0x88,
                0x12,
                0x67,
                0x80,
                0xED,
                0xB8,
                0x2D,
                0x5E
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ITfThreadMgrEventSink
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x0E,
                0xE8,
                0x80,
                0xAA,
                0x21,
                0x20,
                0xD2,
                0x11,
                0x93,
                0xE0,
                0x00,
                0x60,
                0xB0,
                0x67,
                0xB8,
                0x6E
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ITfConfigureSystemKeystrokeFeed
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x9A,
                0x96,
                0x2C,
                0x0D,
                0x9C,
                0xBC,
                0x7C,
                0x43,
                0x84,
                0xEE,
                0x95,
                0x1C,
                0x49,
                0xB1,
                0xA7,
                0x64
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IEnumTfDocumentMgrs
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x08,
                0xE8,
                0x80,
                0xAA,
                0x21,
                0x20,
                0xD2,
                0x11,
                0x93,
                0xE0,
                0x00,
                0x60,
                0xB0,
                0x67,
                0xB8,
                0x6E
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ITfDocumentMgr
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xF4,
                0xE7,
                0x80,
                0xAA,
                0x21,
                0x20,
                0xD2,
                0x11,
                0x93,
                0xE0,
                0x00,
                0x60,
                0xB0,
                0x67,
                0xB8,
                0x6E
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IEnumTfContexts
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xA6,
                0x7E,
                0x1A,
                0x8F,
                0x54,
                0x16,
                0x02,
                0x45,
                0xA8,
                0x6E,
                0xB2,
                0x90,
                0x23,
                0x44,
                0xD5,
                0x07
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ITfCompositionView
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x41,
                0x02,
                0x54,
                0xD7,
                0xA1,
                0xF9,
                0x64,
                0x43,
                0xBE,
                0xFC,
                0xDB,
                0xCD,
                0x2C,
                0x43,
                0x95,
                0xB7
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IEnumITfCompositionView
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xBA,
                0x22,
                0xFD,
                0x5E,
                0x38,
                0x78,
                0xCB,
                0x46,
                0x88,
                0xE2,
                0xCA,
                0xDB,
                0x14,
                0x12,
                0x4F,
                0x8F
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ITfComposition
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x64,
                0x8D,
                0x16,
                0x20,
                0x8F,
                0x5A,
                0x5A,
                0x4A,
                0xB7,
                0xBD,
                0xCF,
                0xA2,
                0x9F,
                0x4D,
                0x0F,
                0xD9
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ITfCompositionSink
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x8C,
                0x71,
                0x81,
                0xA7,
                0x9A,
                0x57,
                0x15,
                0x4B,
                0xA2,
                0x80,
                0x32,
                0xB8,
                0x57,
                0x7A,
                0xCC,
                0x5E
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ITfContextComposition
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xAE,
                0x8A,
                0x0C,
                0xD4,
                0x92,
                0xAC,
                0xC7,
                0x4F,
                0x9A,
                0x11,
                0x0E,
                0xE0,
                0xE2,
                0x3A,
                0xA3,
                0x9B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ITfContextOwnerCompositionServices
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x10,
                0x28,
                0x46,
                0x86,
                0x3B,
                0x59,
                0x16,
                0x49,
                0x97,
                0x64,
                0x19,
                0xC0,
                0x8E,
                0x9C,
                0xE1,
                0x10
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ITfContextOwnerCompositionSink
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x40,
                0xAA,
                0x20,
                0x5F,
                0x7A,
                0xB5,
                0x34,
                0x4F,
                0x96,
                0xAB,
                0x35,
                0x76,
                0xF3,
                0x77,
                0xCC,
                0x79
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ITfContextView
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x8E,
                0xBF,
                0x33,
                0x24,
                0x9B,
                0x0F,
                0x5C,
                0x43,
                0xBA,
                0x2C,
                0x18,
                0x06,
                0x11,
                0x97,
                0x8C,
                0x30
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IEnumTfContextViews
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xDD,
                0xF8,
                0xC0,
                0xF0,
                0x38,
                0xCF,
                0xE1,
                0x44,
                0xBB,
                0x0F,
                0x68,
                0xCF,
                0x0D,
                0x55,
                0x1C,
                0x78
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ITfContext
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xFD,
                0xE7,
                0x80,
                0xAA,
                0x21,
                0x20,
                0xD2,
                0x11,
                0x93,
                0xE0,
                0x00,
                0x60,
                0xB0,
                0x67,
                0xB8,
                0x6E
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ITfQueryEmbedded
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xDB,
                0x9B,
                0xAB,
                0x0F,
                0x50,
                0xD2,
                0x69,
                0x41,
                0x84,
                0xE5,
                0x6B,
                0xE1,
                0x18,
                0xFD,
                0xD7,
                0xA8
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ITfInsertAtSelection
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xBA,
                0x16,
                0xCE,
                0x55,
                0x14,
                0x30,
                0xC1,
                0x41,
                0x9C,
                0xEB,
                0xFA,
                0xDE,
                0x14,
                0x46,
                0xAC,
                0x6C
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ITfCleanupContextSink
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x89,
                0x96,
                0x68,
                0x01,
                0xCB,
                0x7A,
                0x9B,
                0x4E,
                0xAB,
                0x7C,
                0x7E,
                0xA4,
                0x6B,
                0x12,
                0xB5,
                0x22
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ITfCleanupContextDurationSink
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x44,
                0x51,
                0xC3,
                0x45,
                0x4E,
                0x15,
                0x97,
                0x47,
                0xBE,
                0xD8,
                0xD3,
                0x3A,
                0xE7,
                0xBF,
                0x87,
                0x94
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ITfReadOnlyProperty
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x3D,
                0x9A,
                0xD4,
                0x17,
                0xB8,
                0xF8,
                0x2F,
                0x4B,
                0xB2,
                0x54,
                0x52,
                0x31,
                0x9D,
                0xD6,
                0x4C,
                0x53
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IEnumTfPropertyValue
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x1B,
                0x98,
                0xD8,
                0x8E,
                0x10,
                0x7C,
                0x7D,
                0x4D,
                0x9F,
                0xB3,
                0xAB,
                0x72,
                0xE9,
                0xC7,
                0x5F,
                0x72
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ITfMouseTracker
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xCD,
                0x46,
                0xD1,
                0x09,
                0x44,
                0xA5,
                0x32,
                0x41,
                0x92,
                0x5B,
                0x7A,
                0xFA,
                0x8E,
                0xF3,
                0x22,
                0xD0
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ITfMouseTrackerACP
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xE2,
                0x78,
                0xDD,
                0x3B,
                0x6E,
                0xC1,
                0xFD,
                0x47,
                0xB8,
                0x83,
                0xCE,
                0x6F,
                0xAC,
                0xC1,
                0xA2,
                0x08
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ITfMouseSink
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xA2,
                0xAA,
                0xAD,
                0xA1,
                0x24,
                0x3A,
                0x9D,
                0x44,
                0xAC,
                0x96,
                0x51,
                0x83,
                0xE7,
                0xF5,
                0xC2,
                0x17
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ITfEditRecord
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x99,
                0xD0,
                0xD4,
                0x42,
                0x1A,
                0x7C,
                0x89,
                0x4A,
                0xB8,
                0x36,
                0x6C,
                0x6F,
                0x22,
                0x16,
                0x0D,
                0xF0
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ITfTextEditSink
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x09,
                0xD4,
                0x27,
                0x81,
                0xD3,
                0xCC,
                0x83,
                0x46,
                0x96,
                0x7A,
                0xB4,
                0x3D,
                0x5B,
                0x48,
                0x2B,
                0xF7
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ITfTextLayoutSink
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x6A,
                0xD0,
                0xF2,
                0x2A,
                0x5B,
                0xDD,
                0x27,
                0x49,
                0xA0,
                0xB4,
                0x54,
                0xF1,
                0x9C,
                0x91,
                0xFA,
                0xDE
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ITfStatusSink
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x73,
                0x8D,
                0x7D,
                0x6B,
                0x67,
                0xB2,
                0x69,
                0x4F,
                0xB3,
                0x2E,
                0x1C,
                0xA3,
                0x21,
                0xCE,
                0x4F,
                0x45
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ITfEditTransactionSink
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x70,
                0xBF,
                0x8F,
                0x70,
                0x20,
                0xB5,
                0x6B,
                0x41,
                0xB0,
                0x6C,
                0x2C,
                0x41,
                0xAB,
                0x44,
                0xF8,
                0xBA
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ITfContextOwner
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x0C,
                0xE8,
                0x80,
                0xAA,
                0x21,
                0x20,
                0xD2,
                0x11,
                0x93,
                0xE0,
                0x00,
                0x60,
                0xB0,
                0x67,
                0xB8,
                0x6E
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ITfContextOwnerServices
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x30,
                0xB6,
                0x3E,
                0xB2,
                0x1C,
                0x3E,
                0xD3,
                0x11,
                0xA7,
                0x45,
                0x00,
                0x50,
                0x04,
                0x0A,
                0xB4,
                0x07
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ITfContextKeyEventSink
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x5D,
                0xBA,
                0x52,
                0x05,
                0x35,
                0xC8,
                0x34,
                0x49,
                0xBF,
                0x50,
                0x84,
                0x6A,
                0xAA,
                0x67,
                0x43,
                0x2F
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ITfEditSession
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x03,
                0xE8,
                0x80,
                0xAA,
                0x21,
                0x20,
                0xD2,
                0x11,
                0x93,
                0xE0,
                0x00,
                0x60,
                0xB0,
                0x67,
                0xB8,
                0x6E
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ITfRange
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xFF,
                0xE7,
                0x80,
                0xAA,
                0x21,
                0x20,
                0xD2,
                0x11,
                0x93,
                0xE0,
                0x00,
                0x60,
                0xB0,
                0x67,
                0xB8,
                0x6E
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ITfRangeACP
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x96,
                0x62,
                0x7A,
                0x05,
                0x9B,
                0x02,
                0x54,
                0x41,
                0xB7,
                0x9A,
                0x0D,
                0x46,
                0x1D,
                0x4E,
                0xA9,
                0x4C
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ITextStoreACPServices
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x01,
                0xE9,
                0x80,
                0xAA,
                0x21,
                0x20,
                0xD2,
                0x11,
                0x93,
                0xE0,
                0x00,
                0x60,
                0xB0,
                0x67,
                0xB8,
                0x6E
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ITfRangeBackup
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x6D,
                0x50,
                0x3A,
                0x46,
                0x92,
                0x69,
                0xD2,
                0x49,
                0x9B,
                0x88,
                0x93,
                0xD5,
                0x5E,
                0x70,
                0xBB,
                0x16
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ITfPropertyStore
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x20,
                0xB1,
                0x34,
                0x68,
                0xCB,
                0x88,
                0xD2,
                0x11,
                0xBF,
                0x45,
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

    public static ref readonly Guid IID_IEnumTfRanges
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x40,
                0x3F,
                0x9D,
                0xF9,
                0x32,
                0x8E,
                0xD2,
                0x11,
                0xBF,
                0x46,
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

    public static ref readonly Guid IID_ITfCreatePropertyStore
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xF0,
                0xFB,
                0x63,
                0x24,
                0xAF,
                0xB0,
                0xD2,
                0x11,
                0xAF,
                0xC5,
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

    public static ref readonly Guid IID_ITfPersistentPropertyLoaderACP
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x50,
                0x91,
                0xF8,
                0x4E,
                0x07,
                0x08,
                0xD3,
                0x11,
                0x8D,
                0xF0,
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

    public static ref readonly Guid IID_ITfProperty
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x60,
                0x96,
                0x44,
                0xE2,
                0x42,
                0x95,
                0xD2,
                0x11,
                0xBF,
                0x46,
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

    public static ref readonly Guid IID_IEnumTfProperties
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xB0,
                0x8C,
                0x18,
                0x19,
                0xA9,
                0xAC,
                0xD2,
                0x11,
                0xAF,
                0xC5,
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

    public static ref readonly Guid IID_ITfCompartment
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xA9,
                0xF7,
                0x08,
                0xBB,
                0x7A,
                0x60,
                0x84,
                0x43,
                0x86,
                0x23,
                0x05,
                0x68,
                0x92,
                0xB6,
                0x43,
                0x71
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ITfCompartmentEventSink
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x5F,
                0xBD,
                0x3A,
                0x74,
                0x6D,
                0xF2,
                0xDF,
                0x48,
                0x8C,
                0xC5,
                0x23,
                0x84,
                0x92,
                0x41,
                0x9B,
                0x64
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ITfCompartmentMgr
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xAC,
                0x57,
                0xCF,
                0x7D,
                0xAD,
                0x18,
                0x8B,
                0x43,
                0x82,
                0x4D,
                0x97,
                0x9B,
                0xFF,
                0xB7,
                0x4B,
                0x7C
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ITfFunction
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x90,
                0x34,
                0x59,
                0xDB,
                0x8F,
                0x09,
                0xD3,
                0x11,
                0x8D,
                0xF0,
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

    public static ref readonly Guid IID_ITfFunctionProvider
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x10,
                0x66,
                0x1D,
                0x10,
                0x90,
                0x09,
                0xD3,
                0x11,
                0x8D,
                0xF0,
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

    public static ref readonly Guid IID_IEnumTfFunctionProviders
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xB0,
                0x4D,
                0xB2,
                0xE4,
                0x90,
                0x09,
                0xD3,
                0x11,
                0x8D,
                0xF0,
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

    public static ref readonly Guid IID_ITfInputProcessorProfiles
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xC5,
                0xB6,
                0x02,
                0x1F,
                0x42,
                0x78,
                0xE6,
                0x4E,
                0x8A,
                0x0B,
                0x9A,
                0x24,
                0x18,
                0x3A,
                0x95,
                0xCA
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ITfInputProcessorProfilesEx
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x0F,
                0x23,
                0x2F,
                0x89,
                0x00,
                0xFE,
                0x41,
                0x4A,
                0xA9,
                0x8E,
                0xFC,
                0xD6,
                0xDE,
                0x0D,
                0x35,
                0xEF
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ITfInputProcessorProfileSubstituteLayout
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x94,
                0x71,
                0xD6,
                0x4F,
                0x02,
                0x10,
                0x13,
                0x45,
                0xBF,
                0xF2,
                0xC0,
                0xDD,
                0xF6,
                0x25,
                0x85,
                0x52
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ITfActiveLanguageProfileNotifySink
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x75,
                0xCB,
                0x46,
                0xB2,
                0x3E,
                0xA9,
                0x52,
                0x46,
                0xBF,
                0x8C,
                0xB3,
                0xFE,
                0x0C,
                0xFD,
                0x7E,
                0x57
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IEnumTfLanguageProfiles
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x11,
                0xBF,
                0x61,
                0x3D,
                0x5F,
                0xAC,
                0xC8,
                0x42,
                0xA4,
                0xCB,
                0x93,
                0x1B,
                0xCC,
                0x28,
                0xC7,
                0x44
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ITfLanguageProfileNotifySink
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x15,
                0xFE,
                0xC9,
                0x43,
                0x94,
                0xF4,
                0x17,
                0x4C,
                0x9D,
                0xE2,
                0xB8,
                0xA4,
                0xAC,
                0x35,
                0x0A,
                0xA8
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ITfInputProcessorProfileMgr
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x4C,
                0xE7,
                0xC6,
                0x71,
                0x28,
                0x0F,
                0xD8,
                0x11,
                0xA8,
                0x2A,
                0x00,
                0x06,
                0x5B,
                0x84,
                0x43,
                0x5C
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IEnumTfInputProcessorProfiles
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x4D,
                0xE7,
                0xC6,
                0x71,
                0x28,
                0x0F,
                0xD8,
                0x11,
                0xA8,
                0x2A,
                0x00,
                0x06,
                0x5B,
                0x84,
                0x43,
                0x5C
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ITfInputProcessorProfileActivationSink
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x4E,
                0xE7,
                0xC6,
                0x71,
                0x28,
                0x0F,
                0xD8,
                0x11,
                0xA8,
                0x2A,
                0x00,
                0x06,
                0x5B,
                0x84,
                0x43,
                0x5C
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ITfKeystrokeMgr
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xF0,
                0xE7,
                0x80,
                0xAA,
                0x21,
                0x20,
                0xD2,
                0x11,
                0x93,
                0xE0,
                0x00,
                0x60,
                0xB0,
                0x67,
                0xB8,
                0x6E
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ITfKeyEventSink
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xF5,
                0xE7,
                0x80,
                0xAA,
                0x21,
                0x20,
                0xD2,
                0x11,
                0x93,
                0xE0,
                0x00,
                0x60,
                0xB0,
                0x67,
                0xB8,
                0x6E
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ITfKeyTraceEventSink
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x3B,
                0xC1,
                0xD4,
                0x1C,
                0x36,
                0x1C,
                0x91,
                0x41,
                0xA7,
                0x0A,
                0x7F,
                0x3E,
                0x61,
                0x1F,
                0x36,
                0x7D
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ITfPreservedKeyNotifySink
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x93,
                0xC9,
                0x77,
                0x6F,
                0xB1,
                0xD2,
                0x6E,
                0x44,
                0x85,
                0x3E,
                0x59,
                0x12,
                0xEF,
                0xC8,
                0xA2,
                0x86
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ITfMessagePump
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xD8,
                0x8A,
                0x1B,
                0x8F,
                0x6B,
                0x0B,
                0x74,
                0x48,
                0x90,
                0xC5,
                0xBD,
                0x76,
                0x01,
                0x1E,
                0x8F,
                0x7C
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ITfThreadFocusSink
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x0C,
                0xDB,
                0xF1,
                0xC0,
                0x20,
                0x3A,
                0x5C,
                0x40,
                0xA3,
                0x03,
                0x96,
                0xB6,
                0x01,
                0x0A,
                0x88,
                0x5F
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ITfTextInputProcessor
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xF7,
                0xE7,
                0x80,
                0xAA,
                0x21,
                0x20,
                0xD2,
                0x11,
                0x93,
                0xE0,
                0x00,
                0x60,
                0xB0,
                0x67,
                0xB8,
                0x6E
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ITfTextInputProcessorEx
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x02,
                0x21,
                0x4E,
                0x6E,
                0xCD,
                0xF9,
                0x3D,
                0x43,
                0xB4,
                0x96,
                0x30,
                0x3C,
                0xE0,
                0x3A,
                0x65,
                0x07
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ITfClientId
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x49,
                0x7B,
                0x0A,
                0xD6,
                0x9F,
                0x1B,
                0xE2,
                0x4B,
                0xB7,
                0x02,
                0x47,
                0xE9,
                0xDC,
                0x05,
                0xDE,
                0xC3
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ITfDisplayAttributeInfo
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x52,
                0x88,
                0x52,
                0x70,
                0x26,
                0x2F,
                0xEA,
                0x4A,
                0x8C,
                0x96,
                0x21,
                0x51,
                0x50,
                0x57,
                0x89,
                0x32
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IEnumTfDisplayAttributeInfo
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xD7,
                0x04,
                0xEF,
                0x7C,
                0x75,
                0xCB,
                0x80,
                0x4E,
                0xA7,
                0xAB,
                0x5F,
                0x5B,
                0xC7,
                0xD3,
                0x32,
                0xDE
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ITfDisplayAttributeProvider
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x77,
                0x77,
                0xE4,
                0xFE,
                0x3C,
                0x16,
                0x69,
                0x47,
                0x99,
                0x6A,
                0x6E,
                0x9C,
                0x50,
                0xAD,
                0x8F,
                0x54
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ITfDisplayAttributeMgr
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x93,
                0x73,
                0xED,
                0x8D,
                0xB1,
                0x5D,
                0x5C,
                0x47,
                0x9E,
                0x71,
                0xA3,
                0x91,
                0x11,
                0xB0,
                0xFF,
                0x67
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ITfDisplayAttributeNotifySink
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x02,
                0xF4,
                0x56,
                0xAD,
                0x62,
                0xE1,
                0x25,
                0x4F,
                0x90,
                0x8F,
                0x7D,
                0x57,
                0x7C,
                0xF9,
                0xBD,
                0xA9
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ITfCategoryMgr
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xB5,
                0xEF,
                0xAC,
                0xC3,
                0x9D,
                0xF6,
                0x05,
                0x49,
                0x93,
                0x8F,
                0xFC,
                0xAD,
                0xCF,
                0x4B,
                0xE8,
                0x30
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ITfSource
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x35,
                0x8A,
                0xA4,
                0x4E,
                0xAE,
                0x60,
                0x6F,
                0x44,
                0x8F,
                0xD6,
                0xE6,
                0xA8,
                0xD8,
                0x24,
                0x59,
                0xF7
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ITfSourceSingle
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x9C,
                0x1F,
                0x13,
                0x73,
                0xA9,
                0x56,
                0xDD,
                0x49,
                0xB0,
                0xEE,
                0xD0,
                0x46,
                0x63,
                0x3F,
                0x75,
                0x28
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ITfUIElementMgr
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x35,
                0xA1,
                0x1E,
                0xEA,
                0xDF,
                0x19,
                0xD7,
                0x11,
                0xA6,
                0xD2,
                0x00,
                0x06,
                0x5B,
                0x84,
                0x43,
                0x5C
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IEnumTfUIElements
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x1E,
                0xA9,
                0x7A,
                0x88,
                0xBA,
                0xAC,
                0x31,
                0x49,
                0x84,
                0xDA,
                0x3C,
                0x52,
                0x08,
                0xCF,
                0x54,
                0x3F
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ITfUIElementSink
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x36,
                0xA1,
                0x1E,
                0xEA,
                0xDF,
                0x19,
                0xD7,
                0x11,
                0xA6,
                0xD2,
                0x00,
                0x06,
                0x5B,
                0x84,
                0x43,
                0x5C
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ITfUIElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x37,
                0xA1,
                0x1E,
                0xEA,
                0xDF,
                0x19,
                0xD7,
                0x11,
                0xA6,
                0xD2,
                0x00,
                0x06,
                0x5B,
                0x84,
                0x43,
                0x5C
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ITfCandidateListUIElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x38,
                0xA1,
                0x1E,
                0xEA,
                0xDF,
                0x19,
                0xD7,
                0x11,
                0xA6,
                0xD2,
                0x00,
                0x06,
                0x5B,
                0x84,
                0x43,
                0x5C
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ITfCandidateListUIElementBehavior
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x85,
                0xD1,
                0xFA,
                0x85,
                0xCE,
                0x58,
                0x7A,
                0x49,
                0x94,
                0x60,
                0x35,
                0x53,
                0x66,
                0xB6,
                0x4B,
                0x9A
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ITfReadingInformationUIElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x39,
                0xA1,
                0x1E,
                0xEA,
                0xDF,
                0x19,
                0xD7,
                0x11,
                0xA6,
                0xD2,
                0x00,
                0x06,
                0x5B,
                0x84,
                0x43,
                0x5C
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ITfTransitoryExtensionUIElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x6A,
                0x95,
                0x8F,
                0x85,
                0x2F,
                0x97,
                0xA2,
                0x42,
                0xA2,
                0xF2,
                0x03,
                0x21,
                0xE1,
                0xAB,
                0xE2,
                0x09
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ITfTransitoryExtensionSink
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x6F,
                0x09,
                0x15,
                0xA6,
                0x57,
                0x1C,
                0x13,
                0x48,
                0x8A,
                0x15,
                0x55,
                0xEE,
                0x6E,
                0x5A,
                0x83,
                0x9C
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ITfToolTipUIElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x5C,
                0x8B,
                0xB1,
                0x52,
                0x5D,
                0x55,
                0xB2,
                0x46,
                0xB0,
                0x0A,
                0xFA,
                0x68,
                0x01,
                0x44,
                0xFB,
                0xDB
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ITfReverseConversionList
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xF0,
                0x69,
                0x1D,
                0x15,
                0xF4,
                0x86,
                0x74,
                0x46,
                0xB7,
                0x21,
                0x56,
                0x91,
                0x1E,
                0x79,
                0x7F,
                0x47
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ITfReverseConversion
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x62,
                0xE1,
                0x15,
                0xA4,
                0x7D,
                0x15,
                0x7D,
                0x41,
                0x8A,
                0x8C,
                0x0A,
                0xB2,
                0x6C,
                0x7D,
                0x27,
                0x81
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ITfReverseConversionMgr
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x36,
                0xC2,
                0x43,
                0xB6,
                0x93,
                0xC4,
                0xB6,
                0x41,
                0xAB,
                0xB3,
                0x69,
                0x24,
                0x12,
                0x77,
                0x5C,
                0xC4
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}