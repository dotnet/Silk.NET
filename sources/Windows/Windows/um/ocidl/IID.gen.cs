// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ocidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;
public static partial class IID
{
    public static ref readonly Guid IID_IEnumConnections
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x87,
                0xB2,
                0x96,
                0xB1,
                0xB4,
                0xBA,
                0x1A,
                0x10,
                0xB6,
                0x9C,
                0x00,
                0xAA,
                0x00,
                0x34,
                0x1D,
                0x07
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IConnectionPoint
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x86,
                0xB2,
                0x96,
                0xB1,
                0xB4,
                0xBA,
                0x1A,
                0x10,
                0xB6,
                0x9C,
                0x00,
                0xAA,
                0x00,
                0x34,
                0x1D,
                0x07
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IEnumConnectionPoints
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x85,
                0xB2,
                0x96,
                0xB1,
                0xB4,
                0xBA,
                0x1A,
                0x10,
                0xB6,
                0x9C,
                0x00,
                0xAA,
                0x00,
                0x34,
                0x1D,
                0x07
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IConnectionPointContainer
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x84,
                0xB2,
                0x96,
                0xB1,
                0xB4,
                0xBA,
                0x1A,
                0x10,
                0xB6,
                0x9C,
                0x00,
                0xAA,
                0x00,
                0x34,
                0x1D,
                0x07
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IClassFactory2
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x8F,
                0xB2,
                0x96,
                0xB1,
                0xB4,
                0xBA,
                0x1A,
                0x10,
                0xB6,
                0x9C,
                0x00,
                0xAA,
                0x00,
                0x34,
                0x1D,
                0x07
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IProvideClassInfo
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x83,
                0xB2,
                0x96,
                0xB1,
                0xB4,
                0xBA,
                0x1A,
                0x10,
                0xB6,
                0x9C,
                0x00,
                0xAA,
                0x00,
                0x34,
                0x1D,
                0x07
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IProvideClassInfo2
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xC0,
                0x3A,
                0xBC,
                0xA6,
                0xAA,
                0xDB,
                0xCE,
                0x11,
                0x9D,
                0xE3,
                0x00,
                0xAA,
                0x00,
                0x4B,
                0xB8,
                0x51
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IProvideMultipleClassInfo
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xC1,
                0xA9,
                0xAB,
                0xA7,
                0x83,
                0x89,
                0xCF,
                0x11,
                0x8F,
                0x20,
                0x00,
                0x80,
                0x5F,
                0x2C,
                0xD0,
                0x64
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IOleControl
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x88,
                0xB2,
                0x96,
                0xB1,
                0xB4,
                0xBA,
                0x1A,
                0x10,
                0xB6,
                0x9C,
                0x00,
                0xAA,
                0x00,
                0x34,
                0x1D,
                0x07
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IOleControlSite
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x89,
                0xB2,
                0x96,
                0xB1,
                0xB4,
                0xBA,
                0x1A,
                0x10,
                0xB6,
                0x9C,
                0x00,
                0xAA,
                0x00,
                0x34,
                0x1D,
                0x07
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IPropertyPage
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x8D,
                0xB2,
                0x96,
                0xB1,
                0xB4,
                0xBA,
                0x1A,
                0x10,
                0xB6,
                0x9C,
                0x00,
                0xAA,
                0x00,
                0x34,
                0x1D,
                0x07
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IPropertyPage2
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x65,
                0x46,
                0xE4,
                0x01,
                0xAC,
                0x24,
                0x1B,
                0x10,
                0x84,
                0xED,
                0x08,
                0x00,
                0x2B,
                0x2E,
                0xC7,
                0x13
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IPropertyPageSite
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x8C,
                0xB2,
                0x96,
                0xB1,
                0xB4,
                0xBA,
                0x1A,
                0x10,
                0xB6,
                0x9C,
                0x00,
                0xAA,
                0x00,
                0x34,
                0x1D,
                0x07
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IPropertyNotifySink
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x02,
                0xBC,
                0xFB,
                0x9B,
                0xF1,
                0xEF,
                0x1A,
                0x10,
                0x84,
                0xED,
                0x00,
                0xAA,
                0x00,
                0x34,
                0x1D,
                0x07
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISpecifyPropertyPages
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x8B,
                0xB2,
                0x96,
                0xB1,
                0xB4,
                0xBA,
                0x1A,
                0x10,
                0xB6,
                0x9C,
                0x00,
                0xAA,
                0x00,
                0x34,
                0x1D,
                0x07
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IPersistMemory
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xE0,
                0xE5,
                0x1A,
                0xBD,
                0xAE,
                0xA6,
                0xCE,
                0x11,
                0xBD,
                0x37,
                0x50,
                0x42,
                0x00,
                0xC1,
                0x00,
                0x00
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IPersistStreamInit
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x80,
                0x23,
                0xD5,
                0x7F,
                0x07,
                0x4E,
                0x1B,
                0x10,
                0xAE,
                0x2D,
                0x08,
                0x00,
                0x2B,
                0x2E,
                0xC7,
                0x13
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IPersistPropertyBag
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x60,
                0x4F,
                0xD8,
                0x37,
                0xCB,
                0x42,
                0xCE,
                0x11,
                0x81,
                0x35,
                0x00,
                0xAA,
                0x00,
                0x4B,
                0xB8,
                0x51
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISimpleFrameSite
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x01,
                0x0E,
                0x2B,
                0x74,
                0xE6,
                0x14,
                0x1B,
                0x10,
                0x91,
                0x4E,
                0x00,
                0xAA,
                0x00,
                0x30,
                0x0C,
                0xAB
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IFont
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x02,
                0xE0,
                0xF6,
                0xBE,
                0x74,
                0xA8,
                0x1A,
                0x10,
                0x8B,
                0xBA,
                0x00,
                0xAA,
                0x00,
                0x30,
                0x0C,
                0xAB
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IPicture
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x80,
                0x09,
                0xF8,
                0x7B,
                0x32,
                0xBF,
                0x1A,
                0x10,
                0x8B,
                0xBB,
                0x00,
                0xAA,
                0x00,
                0x30,
                0x0C,
                0xAB
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IPicture2
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xD8,
                0x5D,
                0x18,
                0xF5,
                0x12,
                0x20,
                0x0B,
                0x4B,
                0xAA,
                0xD9,
                0xF0,
                0x52,
                0xC6,
                0xBD,
                0x48,
                0x2B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IFontEventsDisp
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x0A,
                0x10,
                0xF6,
                0x4E,
                0x88,
                0xAF,
                0xD0,
                0x11,
                0x98,
                0x46,
                0x00,
                0xC0,
                0x4F,
                0xC2,
                0x99,
                0x93
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IFontDisp
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x03,
                0xE0,
                0xF6,
                0xBE,
                0x74,
                0xA8,
                0x1A,
                0x10,
                0x8B,
                0xBA,
                0x00,
                0xAA,
                0x00,
                0x30,
                0x0C,
                0xAB
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IPictureDisp
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x81,
                0x09,
                0xF8,
                0x7B,
                0x32,
                0xBF,
                0x1A,
                0x10,
                0x8B,
                0xBB,
                0x00,
                0xAA,
                0x00,
                0x30,
                0x0C,
                0xAB
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IOleInPlaceObjectWindowless
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xCC,
                0x56,
                0x20,
                0x1C,
                0xF4,
                0x5E,
                0x1B,
                0x10,
                0x8B,
                0xC8,
                0x00,
                0xAA,
                0x00,
                0x3E,
                0x3B,
                0x29
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IOleInPlaceSiteEx
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x80,
                0xAD,
                0x2C,
                0x9C,
                0x24,
                0x34,
                0xCF,
                0x11,
                0xB6,
                0x70,
                0x00,
                0xAA,
                0x00,
                0x4C,
                0xD6,
                0xD8
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IOleInPlaceSiteWindowless
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xA0,
                0xAD,
                0x2E,
                0x92,
                0x24,
                0x34,
                0xCF,
                0x11,
                0xB6,
                0x70,
                0x00,
                0xAA,
                0x00,
                0x4C,
                0xD6,
                0xD8
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IViewObjectEx
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x92,
                0x42,
                0xF2,
                0x3A,
                0x96,
                0x0C,
                0xCE,
                0x11,
                0xA0,
                0xCF,
                0x00,
                0xAA,
                0x00,
                0x60,
                0x0A,
                0xB8
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IOleUndoUnit
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xB0,
                0xD3,
                0x4A,
                0x89,
                0x97,
                0xEF,
                0xCE,
                0x11,
                0x9B,
                0xC9,
                0x00,
                0xAA,
                0x00,
                0x60,
                0x8E,
                0x01
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IOleParentUndoUnit
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x30,
                0xF3,
                0xFA,
                0xA1,
                0x97,
                0xEF,
                0xCE,
                0x11,
                0x9B,
                0xC9,
                0x00,
                0xAA,
                0x00,
                0x60,
                0x8E,
                0x01
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IEnumOleUndoUnits
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x40,
                0xC3,
                0xE7,
                0xB3,
                0x97,
                0xEF,
                0xCE,
                0x11,
                0x9B,
                0xC9,
                0x00,
                0xAA,
                0x00,
                0x60,
                0x8E,
                0x01
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IOleUndoManager
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x00,
                0xF2,
                0x01,
                0xD0,
                0x97,
                0xEF,
                0xCE,
                0x11,
                0x9B,
                0xC9,
                0x00,
                0xAA,
                0x00,
                0x60,
                0x8E,
                0x01
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IPointerInactive
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xA0,
                0x0B,
                0x98,
                0x55,
                0xAA,
                0x35,
                0xCF,
                0x11,
                0xB6,
                0x71,
                0x00,
                0xAA,
                0x00,
                0x4C,
                0xD6,
                0xD8
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IObjectWithSite
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xA3,
                0x01,
                0x48,
                0xFC,
                0xA9,
                0x2B,
                0xCF,
                0x11,
                0xA2,
                0x29,
                0x00,
                0xAA,
                0x00,
                0x3D,
                0x73,
                0x52
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IPerPropertyBrowsing
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xAA,
                0xD3,
                0x6B,
                0x37,
                0x45,
                0x38,
                0x1B,
                0x10,
                0x84,
                0xED,
                0x08,
                0x00,
                0x2B,
                0x2E,
                0xC7,
                0x13
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IPropertyBag2
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x82,
                0x58,
                0xF5,
                0x22,
                0x0B,
                0x28,
                0xD0,
                0x11,
                0xA8,
                0xA9,
                0x00,
                0xA0,
                0xC9,
                0x0C,
                0x20,
                0x04
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IPersistPropertyBag2
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x81,
                0x58,
                0xF5,
                0x22,
                0x0B,
                0x28,
                0xD0,
                0x11,
                0xA8,
                0xA9,
                0x00,
                0xA0,
                0xC9,
                0x0C,
                0x20,
                0x04
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IAdviseSinkEx
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x90,
                0x42,
                0xF2,
                0x3A,
                0x96,
                0x0C,
                0xCE,
                0x11,
                0xA0,
                0xCF,
                0x00,
                0xAA,
                0x00,
                0x60,
                0x0A,
                0xB8
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IQuickActivate
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x10,
                0xED,
                0x51,
                0xCF,
                0xFE,
                0x62,
                0xCF,
                0x11,
                0xBF,
                0x86,
                0x00,
                0xA0,
                0xC9,
                0x03,
                0x48,
                0x36
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}