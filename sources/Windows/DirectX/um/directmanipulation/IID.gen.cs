// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/directmanipulation.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;
public static partial class IID
{
    public static ref readonly Guid IID_IDirectManipulationManager
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xB4,
                0xD3,
                0xF5,
                0xFB,
                0xC7,
                0x70,
                0x63,
                0x41,
                0x93,
                0x22,
                0x5A,
                0x6F,
                0x66,
                0x0D,
                0x6F,
                0xBC
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IDirectManipulationManager2
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xE9,
                0x05,
                0x10,
                0xFA,
                0x16,
                0x3D,
                0x4C,
                0x48,
                0xBF,
                0xC9,
                0x62,
                0xB6,
                0x1E,
                0x56,
                0xEC,
                0x4E
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IDirectManipulationManager3
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x3D,
                0xB3,
                0xB6,
                0x2C,
                0xE8,
                0xFF,
                0x8C,
                0x48,
                0xB7,
                0x50,
                0xFB,
                0xDF,
                0xE8,
                0x8D,
                0xCA,
                0x8C
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IDirectManipulationViewport
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x3D,
                0x5A,
                0xB8,
                0x28,
                0xA0,
                0x60,
                0xBD,
                0x48,
                0x9B,
                0xA1,
                0x5C,
                0xE8,
                0xD9,
                0xEA,
                0x3A,
                0x6D
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IDirectManipulationViewport2
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xAC,
                0xCA,
                0x3C,
                0x92,
                0xE1,
                0x61,
                0x85,
                0x43,
                0xB7,
                0x26,
                0x01,
                0x7A,
                0xF1,
                0x89,
                0x88,
                0x2A
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IDirectManipulationViewportEventHandler
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xDA,
                0x21,
                0x21,
                0x95,
                0x9F,
                0xD6,
                0xF9,
                0x45,
                0xB0,
                0xF9,
                0xF2,
                0x39,
                0x44,
                0x32,
                0x1A,
                0x6D
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IDirectManipulationContent
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xCB,
                0x62,
                0x99,
                0xB8,
                0x89,
                0x3D,
                0x2B,
                0x44,
                0xBB,
                0x58,
                0x50,
                0x98,
                0xFA,
                0x0F,
                0x9F,
                0x16
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IDirectManipulationPrimaryContent
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xE4,
                0x51,
                0x28,
                0xC1,
                0x98,
                0x16,
                0x25,
                0x46,
                0xB9,
                0xB1,
                0x7C,
                0xA3,
                0xEC,
                0x18,
                0x63,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IDirectManipulationDragDropEventHandler
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x10,
                0x1B,
                0xA1,
                0x1F,
                0x1B,
                0x70,
                0xAE,
                0x41,
                0xB5,
                0xF2,
                0x49,
                0xE3,
                0x6B,
                0xD5,
                0x95,
                0xAA
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IDirectManipulationDragDropBehavior
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xF5,
                0x5A,
                0x4B,
                0x81,
                0xC8,
                0xC2,
                0x70,
                0x42,
                0xA9,
                0xB7,
                0xA1,
                0x98,
                0xCE,
                0x8D,
                0x02,
                0xFA
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IDirectManipulationInteractionEventHandler
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xB8,
                0x45,
                0x3F,
                0xE4,
                0xB4,
                0x42,
                0x3E,
                0x40,
                0xB1,
                0xF2,
                0x27,
                0x3B,
                0x8F,
                0x51,
                0x08,
                0x30
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IDirectManipulationFrameInfoProvider
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xBA,
                0x9D,
                0x75,
                0xFB,
                0x4C,
                0x6F,
                0x01,
                0x4C,
                0x87,
                0x4E,
                0x19,
                0xC8,
                0xA0,
                0x59,
                0x07,
                0xF9
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IDirectManipulationCompositor
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x25,
                0x08,
                0x7A,
                0x53,
                0x87,
                0x03,
                0xFA,
                0x4E,
                0xB6,
                0x2F,
                0x71,
                0xEB,
                0x1F,
                0x08,
                0x5A,
                0x7E
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IDirectManipulationCompositor2
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x22,
                0x78,
                0x8C,
                0xD3,
                0xCB,
                0xF1,
                0xCB,
                0x43,
                0xB4,
                0xB9,
                0xAC,
                0x0C,
                0x76,
                0x7A,
                0x41,
                0x2E
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IDirectManipulationUpdateHandler
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x37,
                0x63,
                0x0B,
                0x79,
                0xF8,
                0x64,
                0xF5,
                0x4F,
                0xA2,
                0x69,
                0xB3,
                0x2B,
                0xC2,
                0xAF,
                0x27,
                0xA7
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IDirectManipulationUpdateManager
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xFD,
                0x62,
                0xAE,
                0xB0,
                0x34,
                0xBE,
                0xE7,
                0x46,
                0x9C,
                0xAA,
                0xD3,
                0x61,
                0xFA,
                0xCB,
                0xB9,
                0xCC
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IDirectManipulationAutoScrollBehavior
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xD4,
                0x54,
                0x59,
                0x6D,
                0x03,
                0x20,
                0x56,
                0x43,
                0x9B,
                0x31,
                0xD0,
                0x51,
                0xC9,
                0xFF,
                0x0A,
                0xF7
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IDirectManipulationDeferContactService
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x71,
                0x5C,
                0x2D,
                0x65,
                0x60,
                0xFE,
                0x98,
                0x4A,
                0xBE,
                0x70,
                0xE5,
                0xF2,
                0x12,
                0x91,
                0xE7,
                0xF1
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}