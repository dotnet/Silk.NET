// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/msxml.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;
public static partial class IID
{
    public static ref readonly Guid IID_IXMLDOMImplementation
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x8F,
                0xBF,
                0x33,
                0x29,
                0x36,
                0x7B,
                0xD2,
                0x11,
                0xB2,
                0x0E,
                0x00,
                0xC0,
                0x4F,
                0x98,
                0x3E,
                0x60
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IXMLDOMNode
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x80,
                0xBF,
                0x33,
                0x29,
                0x36,
                0x7B,
                0xD2,
                0x11,
                0xB2,
                0x0E,
                0x00,
                0xC0,
                0x4F,
                0x98,
                0x3E,
                0x60
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IXMLDOMDocumentFragment
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x13,
                0xA4,
                0xFA,
                0x3E,
                0x2F,
                0x27,
                0xD2,
                0x11,
                0x83,
                0x6F,
                0x00,
                0x00,
                0xF8,
                0x7A,
                0x77,
                0x82
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IXMLDOMDocument
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x81,
                0xBF,
                0x33,
                0x29,
                0x36,
                0x7B,
                0xD2,
                0x11,
                0xB2,
                0x0E,
                0x00,
                0xC0,
                0x4F,
                0x98,
                0x3E,
                0x60
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IXMLDOMNodeList
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x82,
                0xBF,
                0x33,
                0x29,
                0x36,
                0x7B,
                0xD2,
                0x11,
                0xB2,
                0x0E,
                0x00,
                0xC0,
                0x4F,
                0x98,
                0x3E,
                0x60
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IXMLDOMNamedNodeMap
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x83,
                0xBF,
                0x33,
                0x29,
                0x36,
                0x7B,
                0xD2,
                0x11,
                0xB2,
                0x0E,
                0x00,
                0xC0,
                0x4F,
                0x98,
                0x3E,
                0x60
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IXMLDOMCharacterData
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x84,
                0xBF,
                0x33,
                0x29,
                0x36,
                0x7B,
                0xD2,
                0x11,
                0xB2,
                0x0E,
                0x00,
                0xC0,
                0x4F,
                0x98,
                0x3E,
                0x60
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IXMLDOMAttribute
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x85,
                0xBF,
                0x33,
                0x29,
                0x36,
                0x7B,
                0xD2,
                0x11,
                0xB2,
                0x0E,
                0x00,
                0xC0,
                0x4F,
                0x98,
                0x3E,
                0x60
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IXMLDOMElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x86,
                0xBF,
                0x33,
                0x29,
                0x36,
                0x7B,
                0xD2,
                0x11,
                0xB2,
                0x0E,
                0x00,
                0xC0,
                0x4F,
                0x98,
                0x3E,
                0x60
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IXMLDOMText
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x87,
                0xBF,
                0x33,
                0x29,
                0x36,
                0x7B,
                0xD2,
                0x11,
                0xB2,
                0x0E,
                0x00,
                0xC0,
                0x4F,
                0x98,
                0x3E,
                0x60
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IXMLDOMComment
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x88,
                0xBF,
                0x33,
                0x29,
                0x36,
                0x7B,
                0xD2,
                0x11,
                0xB2,
                0x0E,
                0x00,
                0xC0,
                0x4F,
                0x98,
                0x3E,
                0x60
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IXMLDOMProcessingInstruction
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x89,
                0xBF,
                0x33,
                0x29,
                0x36,
                0x7B,
                0xD2,
                0x11,
                0xB2,
                0x0E,
                0x00,
                0xC0,
                0x4F,
                0x98,
                0x3E,
                0x60
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IXMLDOMCDATASection
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x8A,
                0xBF,
                0x33,
                0x29,
                0x36,
                0x7B,
                0xD2,
                0x11,
                0xB2,
                0x0E,
                0x00,
                0xC0,
                0x4F,
                0x98,
                0x3E,
                0x60
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IXMLDOMDocumentType
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x8B,
                0xBF,
                0x33,
                0x29,
                0x36,
                0x7B,
                0xD2,
                0x11,
                0xB2,
                0x0E,
                0x00,
                0xC0,
                0x4F,
                0x98,
                0x3E,
                0x60
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IXMLDOMNotation
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x8C,
                0xBF,
                0x33,
                0x29,
                0x36,
                0x7B,
                0xD2,
                0x11,
                0xB2,
                0x0E,
                0x00,
                0xC0,
                0x4F,
                0x98,
                0x3E,
                0x60
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IXMLDOMEntity
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x8D,
                0xBF,
                0x33,
                0x29,
                0x36,
                0x7B,
                0xD2,
                0x11,
                0xB2,
                0x0E,
                0x00,
                0xC0,
                0x4F,
                0x98,
                0x3E,
                0x60
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IXMLDOMEntityReference
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x8E,
                0xBF,
                0x33,
                0x29,
                0x36,
                0x7B,
                0xD2,
                0x11,
                0xB2,
                0x0E,
                0x00,
                0xC0,
                0x4F,
                0x98,
                0x3E,
                0x60
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IXMLDOMParseError
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x26,
                0xA4,
                0xFA,
                0x3E,
                0x2F,
                0x27,
                0xD2,
                0x11,
                0x83,
                0x6F,
                0x00,
                0x00,
                0xF8,
                0x7A,
                0x77,
                0x82
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IXTLRuntime
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x25,
                0xA4,
                0xFA,
                0x3E,
                0x2F,
                0x27,
                0xD2,
                0x11,
                0x83,
                0x6F,
                0x00,
                0x00,
                0xF8,
                0x7A,
                0x77,
                0x82
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IXMLHttpRequest
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x8D,
                0x10,
                0x8C,
                0xED,
                0x49,
                0x43,
                0xD2,
                0x11,
                0x91,
                0xA4,
                0x00,
                0xC0,
                0x4F,
                0x79,
                0x69,
                0xE8
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IXMLDSOControl
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x62,
                0xFA,
                0x0A,
                0x31,
                0x75,
                0x05,
                0xD2,
                0x11,
                0x9C,
                0xA9,
                0x00,
                0x60,
                0xB0,
                0xEC,
                0x3D,
                0x39
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IXMLElementCollection
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x80,
                0x55,
                0x72,
                0x65,
                0x5D,
                0x9B,
                0xD0,
                0x11,
                0x9B,
                0xFE,
                0x00,
                0xC0,
                0x4F,
                0xC9,
                0x9C,
                0x8E
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IXMLDocument
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x61,
                0x2B,
                0x2E,
                0xF5,
                0xA1,
                0x18,
                0xD1,
                0x11,
                0xB1,
                0x05,
                0x00,
                0x80,
                0x5F,
                0x49,
                0x91,
                0x6B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IXMLDocument2
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xFE,
                0xE2,
                0x8D,
                0x2B,
                0x2D,
                0x8D,
                0xD1,
                0x11,
                0xB2,
                0xFC,
                0x00,
                0xC0,
                0x4F,
                0xD9,
                0x15,
                0xA9
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IXMLElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xAC,
                0x31,
                0x7F,
                0x3F,
                0x5F,
                0xE1,
                0xD0,
                0x11,
                0x9C,
                0x25,
                0x00,
                0xC0,
                0x4F,
                0xC9,
                0x9C,
                0x8E
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IXMLElement2
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xFF,
                0xE2,
                0x8D,
                0x2B,
                0x2D,
                0x8D,
                0xD1,
                0x11,
                0xB2,
                0xFC,
                0x00,
                0xC0,
                0x4F,
                0xD9,
                0x15,
                0xA9
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IXMLAttribute
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xFC,
                0xA0,
                0xD4,
                0xD4,
                0x73,
                0x3B,
                0xD1,
                0x11,
                0xB2,
                0xB4,
                0x00,
                0xC0,
                0x4F,
                0xB9,
                0x25,
                0x96
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IXMLError
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xD3,
                0x5A,
                0x8C,
                0x94,
                0x8D,
                0xC5,
                0xD0,
                0x11,
                0x9C,
                0x0B,
                0x00,
                0xC0,
                0x4F,
                0xC9,
                0x9C,
                0x8E
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}