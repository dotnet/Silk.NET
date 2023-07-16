// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;
public static partial class IID
{
    public static ref readonly Guid IID_IHTMLFiltersCollection
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xEE,
                0xF3,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IIE70DispatchEx
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x6B,
                0x04,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IIE80DispatchEx
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x6C,
                0x04,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLEventObj
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x2D,
                0xF3,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IElementBehaviorSite
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x27,
                0xF4,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IElementBehavior
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x25,
                0xF4,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IElementBehaviorFactory
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x29,
                0xF4,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IElementBehaviorSiteOM
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x89,
                0xF4,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IElementBehaviorRender
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xAA,
                0xF4,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IElementBehaviorSiteRender
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xA7,
                0xF4,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IDOMEvent
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xBA,
                0x04,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLDOMConstructor
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x9B,
                0x04,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLStyleSheetRule
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x57,
                0xF3,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLCSSStyleDeclaration
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x40,
                0x07,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLCSSStyleDeclaration2
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xD1,
                0x07,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLCSSStyleDeclaration3
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x5C,
                0x08,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLCSSStyleDeclaration4
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x3B,
                0x0F,
                0x10,
                0xD6,
                0xC8,
                0x27,
                0x32,
                0x41,
                0xAF,
                0xEA,
                0xF0,
                0xE4,
                0xB1,
                0xE0,
                0x00,
                0x60
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLStyleEnabled
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xC2,
                0x04,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispHTMLCSSStyleDeclaration
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x9A,
                0x00,
                0x59,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLCSSStyleDeclaration
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x41,
                0x07,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLStyle
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x5E,
                0xF2,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLStyle2
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xA2,
                0xF4,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLStyle3
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x56,
                0xF6,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLStyle4
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x16,
                0xF8,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLStyle5
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x3A,
                0xF3,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLStyle6
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x80,
                0x04,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLRuleStyle
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xCF,
                0xF3,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLRuleStyle2
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xAC,
                0xF4,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLRuleStyle3
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x57,
                0xF6,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLRuleStyle4
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x17,
                0xF8,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLRuleStyle5
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x35,
                0xF3,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLRuleStyle6
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x71,
                0x04,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispHTMLStyle
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x5A,
                0xF5,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLStyle
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x85,
                0xF2,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispHTMLRuleStyle
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x5C,
                0xF5,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLRuleStyle
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xD0,
                0xF3,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLStyleSheetRulesCollection
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xE5,
                0xF2,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLStyleSheet
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xE3,
                0xF2,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLCSSRule
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xE9,
                0x06,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLCSSImportRule
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xEA,
                0x06,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLCSSMediaRule
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xEB,
                0x06,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLCSSMediaList
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x31,
                0x07,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLCSSNamespaceRule
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xEE,
                0x06,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLMSCSSKeyframeRule
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x0C,
                0x08,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLMSCSSKeyframesRule
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x0D,
                0x08,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispHTMLCSSRule
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x7D,
                0x00,
                0x59,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLCSSRule
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xEF,
                0x06,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispHTMLCSSImportRule
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x7E,
                0x00,
                0x59,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLCSSImportRule
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xF0,
                0x06,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispHTMLCSSMediaRule
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x7F,
                0x00,
                0x59,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLCSSMediaRule
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xF1,
                0x06,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispHTMLCSSMediaList
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x97,
                0x00,
                0x59,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLCSSMediaList
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x32,
                0x07,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispHTMLCSSNamespaceRule
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x80,
                0x00,
                0x59,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLCSSNamespaceRule
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xF2,
                0x06,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispHTMLMSCSSKeyframeRule
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xDE,
                0x00,
                0x59,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLMSCSSKeyframeRule
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x0E,
                0x08,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispHTMLMSCSSKeyframesRule
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xDF,
                0x00,
                0x59,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLMSCSSKeyframesRule
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x0F,
                0x08,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLRenderStyle
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xAE,
                0xF6,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispHTMLRenderStyle
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x8B,
                0xF5,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLRenderStyle
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xAA,
                0xF6,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLCurrentStyle
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xDB,
                0xF3,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLCurrentStyle2
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x58,
                0xF6,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLCurrentStyle3
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x18,
                0xF8,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLCurrentStyle4
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x3B,
                0xF3,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLCurrentStyle5
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x81,
                0x04,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispHTMLCurrentStyle
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x57,
                0xF5,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLCurrentStyle
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xDC,
                0xF3,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xFF,
                0xF1,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLRect
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xA3,
                0xF4,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLRect2
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x6C,
                0x07,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLRectCollection
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xA4,
                0xF4,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLElementCollection
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x1F,
                0xF2,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLElement2
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x34,
                0xF4,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLAttributeCollection3
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x69,
                0x04,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IDOMDocumentType
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x38,
                0x07,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLDocument7
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xB8,
                0x04,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLDOMNode
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xDA,
                0xF5,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLDOMNode2
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x0B,
                0xF8,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLDOMNode3
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xE0,
                0x06,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLDOMAttribute
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xB0,
                0xF4,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLDOMAttribute2
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x10,
                0xF8,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLDOMAttribute3
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x68,
                0x04,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLDOMAttribute4
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xF9,
                0x06,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLDOMTextNode
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xB1,
                0xF4,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLDOMTextNode2
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x09,
                0xF8,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLDOMTextNode3
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x3E,
                0x07,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLDOMImplementation
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x0D,
                0xF8,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLDOMImplementation2
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x3C,
                0x07,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispHTMLDOMAttribute
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x64,
                0xF5,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLDOMAttribute
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xB2,
                0xF4,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispHTMLDOMTextNode
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x65,
                0xF5,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLDOMTextNode
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xBA,
                0xF4,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispHTMLDOMImplementation
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x8F,
                0xF5,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLDOMImplementation
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x0E,
                0xF8,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLAttributeCollection
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xC3,
                0xF4,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLAttributeCollection2
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x0A,
                0xF8,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLAttributeCollection4
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xFA,
                0x06,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLDOMChildrenCollection
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xAB,
                0xF5,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLDOMChildrenCollection2
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x91,
                0x07,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispHTMLAttributeCollection
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x6C,
                0xF5,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLAttributeCollection
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xCC,
                0xF4,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispStaticNodeList
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x9B,
                0xF5,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_StaticNodeList
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x67,
                0x04,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispDOMChildrenCollection
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x77,
                0xF5,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DOMChildrenCollection
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xAA,
                0xF5,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLElementEvents4
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x5E,
                0x07,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLElementEvents3
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x9F,
                0xF5,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLElementEvents2
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x0F,
                0xF6,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLElementEvents
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x3C,
                0xF3,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IRulesAppliedCollection
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xBE,
                0x04,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLElement3
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x73,
                0xF6,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLElement4
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x0F,
                0xF8,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IElementSelector
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x63,
                0x04,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLElementRender
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x69,
                0xF6,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLUniqueName
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xD0,
                0xF4,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLElement5
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x5D,
                0x04,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLElement6
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xF8,
                0x06,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLElement7
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xAA,
                0x07,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLElementAppliedStyles
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xBD,
                0x04,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IElementTraversal
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x36,
                0x07,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLDatabinding
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xF2,
                0xF3,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLDocument
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x20,
                0xC5,
                0x6F,
                0x62,
                0x1E,
                0xA4,
                0xCF,
                0x11,
                0xA7,
                0x31,
                0x00,
                0xA0,
                0xC9,
                0x08,
                0x26,
                0x37
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLElementDefaults
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xC9,
                0xF6,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispHTMLDefaults
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x8C,
                0xF5,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLDefaults
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xC8,
                0xF6,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTCDefaultDispatch
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xFD,
                0xF4,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTCPropertyBehavior
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xDF,
                0xF5,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTCMethodBehavior
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x31,
                0xF6,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTCEventBehavior
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xFF,
                0xF4,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTCAttachBehavior
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xF4,
                0xF5,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTCAttachBehavior2
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xEB,
                0xF7,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTCDescBehavior
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xDC,
                0xF5,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispHTCDefaultDispatch
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x73,
                0xF5,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTCDefaultDispatch
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xFC,
                0xF4,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispHTCPropertyBehavior
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x7F,
                0xF5,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTCPropertyBehavior
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xDE,
                0xF5,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispHTCMethodBehavior
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x87,
                0xF5,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTCMethodBehavior
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x30,
                0xF6,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispHTCEventBehavior
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x74,
                0xF5,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTCEventBehavior
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xFE,
                0xF4,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispHTCAttachBehavior
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x83,
                0xF5,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTCAttachBehavior
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xF5,
                0xF5,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispHTCDescBehavior
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x7E,
                0xF5,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTCDescBehavior
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xDD,
                0xF5,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLUrnCollection
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xE2,
                0xF5,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispHTMLUrnCollection
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x51,
                0xF5,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLUrnCollection
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x80,
                0xF5,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLGenericElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xB7,
                0xF4,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispHTMLGenericElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x63,
                0xF5,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLGenericElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xB8,
                0xF4,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLStyleSheetRuleApplied
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xC1,
                0x04,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLStyleSheetRule2
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xFD,
                0x06,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLStyleSheetRulesCollection2
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xE8,
                0x06,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispHTMLStyleSheetRule
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x0E,
                0xF5,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLStyleSheetRule
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xCE,
                0xF3,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispHTMLStyleSheetRulesCollection
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x2F,
                0xF5,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLStyleSheetRulesCollection
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xCD,
                0xF3,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLStyleSheetPage
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xEE,
                0xF7,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLStyleSheetPage2
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xED,
                0x06,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLStyleSheetPagesCollection
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xF0,
                0xF7,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispHTMLStyleSheetPage
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x40,
                0xF5,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLStyleSheetPage
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xEF,
                0xF7,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispHTMLStyleSheetPagesCollection
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x43,
                0xF5,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLStyleSheetPagesCollection
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xF1,
                0xF7,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLStyleSheetsCollection
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x7E,
                0xF3,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLStyleSheet2
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xD1,
                0xF3,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLStyleSheet3
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x96,
                0x04,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLStyleSheet4
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xF4,
                0x06,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispHTMLStyleSheet
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x8D,
                0xF5,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLStyleSheet
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xE4,
                0xF2,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLStyleSheetsCollection2
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xE7,
                0x06,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispHTMLStyleSheetsCollection
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x47,
                0xF5,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLStyleSheetsCollection
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x7F,
                0xF3,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLLinkElementEvents2
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x1D,
                0xF6,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLLinkElementEvents
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xCC,
                0xF3,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLLinkElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x05,
                0xF2,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLLinkElement2
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xE5,
                0xF4,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLLinkElement3
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x1E,
                0xF8,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLLinkElement4
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x3A,
                0x04,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLLinkElement5
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x26,
                0x07,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispHTMLLinkElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x24,
                0xF5,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLLinkElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x77,
                0xF2,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLTxtRange
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x20,
                0xF2,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLTextRangeMetrics
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x0B,
                0xF4,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLTextRangeMetrics2
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xA6,
                0xF4,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLTxtRangeCollection
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xED,
                0xF7,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLDOMRange
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xAE,
                0x04,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispHTMLDOMRange
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xA3,
                0xF5,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLDOMRange
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xC3,
                0x06,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLFormElementEvents2
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x14,
                0xF6,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLFormElementEvents
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x64,
                0xF3,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLFormElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xF7,
                0xF1,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLFormElement2
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xF6,
                0xF4,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLFormElement3
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x36,
                0xF8,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLSubmitData
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x45,
                0xF6,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLFormElement4
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x2C,
                0x04,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispHTMLFormElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x10,
                0xF5,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLFormElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x51,
                0xF2,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLControlElementEvents2
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x12,
                0xF6,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLControlElementEvents
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xEA,
                0xF4,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLControlElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xE9,
                0xF4,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLTextElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x18,
                0xF2,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispHTMLTextElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x37,
                0xF5,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLTextElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x6A,
                0xF2,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLTextContainerEvents2
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x24,
                0xF6,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLTextContainerEvents
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x72,
                0xAA,
                0xF6,
                0x1F,
                0x42,
                0x58,
                0xCF,
                0x11,
                0xA7,
                0x07,
                0x00,
                0xAA,
                0x00,
                0xC0,
                0x09,
                0x8D
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLTextContainer
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x30,
                0xF2,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLControlRange
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x9C,
                0xF2,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLControlRange2
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x5E,
                0xF6,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLImgEvents2
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x16,
                0xF6,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLImgEvents
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x5B,
                0xF2,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLImgElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x40,
                0xF2,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLImgElement2
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x26,
                0xF8,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLImgElement3
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x34,
                0x04,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLImgElement4
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xF6,
                0x07,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLMSImgElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x93,
                0x07,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLImageElementFactory
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x8E,
                0xF3,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispHTMLImg
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x1C,
                0xF5,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLImg
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x41,
                0xF2,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLImageElementFactory
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x8F,
                0xF3,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLBodyElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xD8,
                0xF1,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLBodyElement2
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xC5,
                0xF5,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLBodyElement3
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x22,
                0x04,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLBodyElement4
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x95,
                0x07,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLBodyElement5
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x22,
                0x08,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispHTMLBody
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x07,
                0xF5,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLBody
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x4A,
                0xF2,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLFontElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xD9,
                0xF1,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispHTMLFontElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x12,
                0xF5,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLFontElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x7B,
                0xF2,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLAnchorEvents2
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x10,
                0xF6,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLAnchorEvents
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x9D,
                0xF2,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLAnchorElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xDA,
                0xF1,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLAnchorElement2
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x25,
                0xF8,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLAnchorElement3
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x1D,
                0x04,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispHTMLAnchorElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x02,
                0xF5,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLAnchorElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x48,
                0xF2,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLLabelEvents2
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x1C,
                0xF6,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLLabelEvents
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x29,
                0xF3,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLLabelElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x2A,
                0xF3,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLLabelElement2
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x32,
                0xF8,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispHTMLLabelElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x22,
                0xF5,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLLabelElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x2B,
                0xF3,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLListElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x0E,
                0xF2,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLListElement2
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x22,
                0xF8,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispHTMLListElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x25,
                0xF5,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLListElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x72,
                0xF2,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLUListElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xDD,
                0xF1,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispHTMLUListElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x38,
                0xF5,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLUListElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x69,
                0xF2,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLOListElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xDE,
                0xF1,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispHTMLOListElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x2A,
                0xF5,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLOListElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x70,
                0xF2,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLLIElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xE0,
                0xF1,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispHTMLLIElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x23,
                0xF5,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLLIElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x73,
                0xF2,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLBlockElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x08,
                0xF2,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLBlockElement2
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x23,
                0xF8,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLBlockElement3
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x94,
                0x04,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispHTMLBlockElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x06,
                0xF5,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLBlockElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x81,
                0xF2,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLDivElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x00,
                0xF2,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispHTMLDivElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x0C,
                0xF5,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLDivElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x7E,
                0xF2,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLDDElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xF2,
                0xF1,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispHTMLDDElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x0B,
                0xF5,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLDDElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x7F,
                0xF2,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLDTElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xF3,
                0xF1,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispHTMLDTElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x0D,
                0xF5,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLDTElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x7C,
                0xF2,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLBRElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xF0,
                0xF1,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispHTMLBRElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x3A,
                0xF5,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLBRElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x80,
                0xF2,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLDListElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xF1,
                0xF1,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispHTMLDListElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x3B,
                0xF5,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLDListElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x7D,
                0xF2,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLHRElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xF4,
                0xF1,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispHTMLHRElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x3D,
                0xF5,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLHRElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x52,
                0xF2,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLParaElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xF5,
                0xF1,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispHTMLParaElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x2C,
                0xF5,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLParaElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x6F,
                0xF2,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLElementCollection2
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xEE,
                0xF5,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLElementCollection3
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x35,
                0xF8,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLElementCollection4
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x25,
                0x04,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispHTMLElementCollection
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x6B,
                0xF5,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLElementCollection
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xCB,
                0xF4,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLHeaderElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xF6,
                0xF1,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispHTMLHeaderElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x15,
                0xF5,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLHeaderElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x7A,
                0xF2,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLSelectElementEvents2
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x22,
                0xF6,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLSelectElementEvents
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x02,
                0xF3,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLOptionElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x11,
                0xF2,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLSelectElementEx
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xD1,
                0xF2,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLSelectElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x44,
                0xF2,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLSelectElement2
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xED,
                0xF5,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLSelectElement4
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x38,
                0xF8,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLSelectElement5
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x9D,
                0x04,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLSelectElement6
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x60,
                0x07,
                0x51,
                0x30,
                0xB6,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispHTMLSelectElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x31,
                0xF5,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLSelectElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x45,
                0xF2,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispHTMLWndSelectElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x97,
                0xF5,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLWndSelectElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xCF,
                0xF2,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLSelectionObject
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x5A,
                0xF2,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLSelectionObject2
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xEC,
                0xF7,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLSelection
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xB6,
                0x04,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLOptionElement3
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x20,
                0xF8,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLOptionElement4
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xB4,
                0x07,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLOptionElementFactory
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x8C,
                0xF3,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispHTMLOptionElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x2B,
                0xF5,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLOptionElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x4D,
                0xF2,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLOptionElementFactory
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x8D,
                0xF3,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispHTMLWndOptionElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x98,
                0xF5,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLWndOptionElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xD0,
                0xF2,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLButtonElementEvents2
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x17,
                0xF6,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLButtonElementEvents
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xB3,
                0xF2,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLInputTextElementEvents2
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x18,
                0xF6,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLOptionButtonElementEvents2
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x19,
                0xF6,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLInputFileElementEvents2
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x1A,
                0xF6,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLInputImageEvents2
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x1B,
                0xF6,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLInputTextElementEvents
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xA7,
                0xF2,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLOptionButtonElementEvents
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xBD,
                0xF2,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLInputFileElementEvents
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xAF,
                0xF2,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLInputImageEvents
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xC3,
                0xF2,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLInputElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xD2,
                0xF5,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLInputElement2
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x21,
                0xF8,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLInputElement3
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x35,
                0x04,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLInputButtonElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xB2,
                0xF2,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLInputHiddenElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xA4,
                0xF2,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLInputTextElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xA6,
                0xF2,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLInputTextElement2
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xD2,
                0xF2,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLInputFileElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xAD,
                0xF2,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLOptionButtonElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xBC,
                0xF2,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLInputImage
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xC2,
                0xF2,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLInputRangeElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xD4,
                0xF2,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispHTMLInputElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x7D,
                0xF5,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLInputElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xD8,
                0xF5,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLTextAreaElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xAA,
                0xF2,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLTextAreaElement2
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xD3,
                0xF2,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispHTMLTextAreaElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x21,
                0xF5,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLTextAreaElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xAC,
                0xF2,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispHTMLRichtextElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x4D,
                0xF5,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLRichtextElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xDF,
                0xF2,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLButtonElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xBB,
                0xF2,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLButtonElement2
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xF3,
                0x06,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispHTMLButtonElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x1F,
                0xF5,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLButtonElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xC6,
                0xF2,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLMarqueeElementEvents2
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x1F,
                0xF6,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLMarqueeElementEvents
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xB8,
                0xF2,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLMarqueeElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xB5,
                0xF2,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispHTMLMarqueeElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x27,
                0xF5,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLMarqueeElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xB9,
                0xF2,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLHtmlElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x1C,
                0xF8,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLHeadElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x1D,
                0xF8,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLHeadElement2
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x2F,
                0x04,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLTitleElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x22,
                0xF3,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLMetaElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x03,
                0xF2,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLMetaElement2
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x1F,
                0xF8,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLMetaElement3
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x95,
                0x04,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLBaseElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x04,
                0xF2,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLBaseElement2
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x20,
                0x04,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispHTMLHtmlElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x60,
                0xF5,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLHtmlElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x91,
                0xF4,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispHTMLHeadElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x61,
                0xF5,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLHeadElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x93,
                0xF4,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispHTMLTitleElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x16,
                0xF5,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLTitleElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x84,
                0xF2,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispHTMLMetaElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x17,
                0xF5,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLMetaElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x75,
                0xF2,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispHTMLBaseElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x18,
                0xF5,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLBaseElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x76,
                0xF2,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLIsIndexElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x06,
                0xF2,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLIsIndexElement2
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x2F,
                0xF8,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLNextIdElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x07,
                0xF2,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispHTMLIsIndexElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x19,
                0xF5,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLIsIndexElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x78,
                0xF2,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispHTMLNextIdElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x1A,
                0xF5,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLNextIdElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x79,
                0xF2,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLBaseFontElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x02,
                0xF2,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispHTMLBaseFontElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x04,
                0xF5,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLBaseFontElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x82,
                0xF2,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLUnknownElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x09,
                0xF2,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispHTMLUnknownElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x39,
                0xF5,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLUnknownElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x68,
                0xF2,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IWebGeolocation
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xC5,
                0x07,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLMimeTypesCollection
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xFC,
                0xF3,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLPluginsCollection
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xFD,
                0xF3,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IOmHistory
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xA2,
                0xAA,
                0xCE,
                0xFE,
                0x05,
                0x84,
                0xCF,
                0x11,
                0x8B,
                0xA1,
                0x00,
                0xAA,
                0x00,
                0x47,
                0x6D,
                0xA6
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLOpsProfile
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x01,
                0xF4,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IOmNavigator
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xA5,
                0xAA,
                0xCE,
                0xFE,
                0x05,
                0x84,
                0xCF,
                0x11,
                0x8B,
                0xA1,
                0x00,
                0xAA,
                0x00,
                0x47,
                0x6D,
                0xA6
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_INavigatorGeolocation
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xCF,
                0x07,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_INavigatorDoNotTrack
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x04,
                0x08,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLLocation
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xE0,
                0xB1,
                0x3B,
                0x16,
                0x00,
                0x6E,
                0xCF,
                0x11,
                0x83,
                0x7A,
                0x48,
                0xDC,
                0x04,
                0xC1,
                0x00,
                0x00
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispHTMLHistory
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x49,
                0xF5,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLHistory
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xA3,
                0xAA,
                0xCE,
                0xFE,
                0x05,
                0x84,
                0xCF,
                0x11,
                0x8B,
                0xA1,
                0x00,
                0xAA,
                0x00,
                0x47,
                0x6D,
                0xA6
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_COpsProfile
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x02,
                0xF4,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispHTMLNavigator
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x4C,
                0xF5,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLNavigator
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xA6,
                0xAA,
                0xCE,
                0xFE,
                0x05,
                0x84,
                0xCF,
                0x11,
                0x8B,
                0xA1,
                0x00,
                0xAA,
                0x00,
                0x47,
                0x6D,
                0xA6
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispHTMLLocation
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x4E,
                0xF5,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLLocation
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xE1,
                0xB1,
                0x3B,
                0x16,
                0x00,
                0x6E,
                0xCF,
                0x11,
                0x83,
                0x7A,
                0x48,
                0xDC,
                0x04,
                0xC1,
                0x00,
                0x00
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CMimeTypes
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xFE,
                0xF3,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispCPlugins
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x4A,
                0xF5,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CPlugins
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xFF,
                0xF3,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLBookmarkCollection
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xCE,
                0xF4,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLDataTransfer
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xB3,
                0xF4,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLEventObj2
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x8B,
                0xF4,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLEventObj3
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x80,
                0xF6,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLEventObj4
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x14,
                0xF8,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLEventObj5
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x78,
                0x04,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLEventObj6
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x34,
                0x07,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispCEventObj
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x58,
                0xF5,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CEventObj
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x8A,
                0xF4,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLStyleMedia
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x4B,
                0x07,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispHTMLStyleMedia
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x9E,
                0x00,
                0x59,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLStyleMedia
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x4C,
                0x07,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLFramesCollection2
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x26,
                0x44,
                0x2C,
                0x33,
                0xCB,
                0x26,
                0xD0,
                0x11,
                0xB4,
                0x83,
                0x00,
                0xC0,
                0x4F,
                0xD9,
                0x01,
                0x19
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_FramesCollection
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xF6,
                0xF7,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLWindowEvents3
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xA1,
                0xF5,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLWindowEvents2
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x25,
                0xF6,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLWindowEvents
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xE0,
                0xA4,
                0xA0,
                0x96,
                0x62,
                0xD0,
                0xCF,
                0x11,
                0x94,
                0xB6,
                0x00,
                0xAA,
                0x00,
                0x60,
                0x27,
                0x5C
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLDocument2
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x25,
                0x44,
                0x2C,
                0x33,
                0xCB,
                0x26,
                0xD0,
                0x11,
                0xB4,
                0x83,
                0x00,
                0xC0,
                0x4F,
                0xD9,
                0x01,
                0x19
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLWindow2
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x27,
                0x44,
                0x2C,
                0x33,
                0xCB,
                0x26,
                0xD0,
                0x11,
                0xB4,
                0x83,
                0x00,
                0xC0,
                0x4F,
                0xD9,
                0x01,
                0x19
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLWindow3
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xAE,
                0xF4,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLFrameBase
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x11,
                0xF3,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLStorage
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x74,
                0x04,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLPerformance
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x4E,
                0x07,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLApplicationCache
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x28,
                0x08,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLScreen
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x5C,
                0xF3,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLScreen2
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x4A,
                0xF8,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLScreen3
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xA1,
                0x04,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLScreen4
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x6B,
                0x07,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLWindow4
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xCF,
                0xF6,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLWindow5
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x0E,
                0x04,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLWindow6
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x53,
                0x04,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLWindow7
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xB7,
                0x04,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLWindow8
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xAB,
                0x07,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispHTMLScreen
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x91,
                0xF5,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLScreen
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x5D,
                0xF3,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispHTMLWindow2
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x5D,
                0xF5,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLWindow2
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xC6,
                0x6E,
                0x8A,
                0xD4,
                0x4A,
                0x6A,
                0xCF,
                0x11,
                0x94,
                0xA7,
                0x44,
                0x45,
                0x53,
                0x54,
                0x00,
                0x00
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispHTMLWindowProxy
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x5E,
                0xF5,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLWindowProxy
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x91,
                0xF3,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLDocumentCompatibleInfo
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x1A,
                0x04,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLDocumentCompatibleInfoCollection
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x18,
                0x04,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispHTMLDocumentCompatibleInfo
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x3E,
                0xF5,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLDocumentCompatibleInfo
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x1B,
                0x04,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispHTMLDocumentCompatibleInfoCollection
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x3F,
                0xF5,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLDocumentCompatibleInfoCollection
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x19,
                0x04,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLDocumentEvents4
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x37,
                0x07,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLDocumentEvents3
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xA0,
                0xF5,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLDocumentEvents2
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x13,
                0xF6,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLDocumentEvents
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x60,
                0xF2,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISVGSVGElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xE7,
                0x04,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IDOMNodeIterator
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x46,
                0x07,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IDOMTreeWalker
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x48,
                0x07,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IDOMProcessingInstruction
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x42,
                0x07,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLDocument3
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x85,
                0xF4,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLDocument4
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x9A,
                0xF6,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLDocument5
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x0C,
                0xF8,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLDocument6
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x17,
                0x04,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLDocument8
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xD0,
                0x07,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IDocumentEvent
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xBC,
                0x04,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IDocumentRange
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xAF,
                0x04,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IDocumentSelector
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x62,
                0x04,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IDocumentTraversal
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x44,
                0x07,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispHTMLDocument
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x5F,
                0xF5,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLDocument
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x20,
                0x69,
                0x33,
                0x25,
                0xF9,
                0x03,
                0xCF,
                0x11,
                0x8F,
                0xD0,
                0x00,
                0xAA,
                0x00,
                0x68,
                0x6F,
                0x13
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DWebBridgeEvents
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xFF,
                0x97,
                0xD8,
                0xA6,
                0x95,
                0x0A,
                0xD1,
                0x11,
                0xB0,
                0xBA,
                0x00,
                0x60,
                0x08,
                0x16,
                0x6E,
                0x11
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IWebBridge
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xAD,
                0xFD,
                0x24,
                0xAE,
                0xC6,
                0x03,
                0xD1,
                0x11,
                0x8B,
                0x76,
                0x00,
                0x80,
                0xC7,
                0x44,
                0xF3,
                0x89
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IWBScriptControl
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x70,
                0x08,
                0x17,
                0xA5,
                0xF8,
                0x0C,
                0xD1,
                0x11,
                0x8B,
                0x91,
                0x00,
                0x80,
                0xC7,
                0x44,
                0xF3,
                0x89
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_Scriptlet
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xAE,
                0xFD,
                0x24,
                0xAE,
                0xC6,
                0x03,
                0xD1,
                0x11,
                0x8B,
                0x76,
                0x00,
                0x80,
                0xC7,
                0x44,
                0xF3,
                0x89
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLEmbedElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x5F,
                0xF2,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLEmbedElement2
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x93,
                0x04,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispHTMLEmbed
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x2E,
                0xF5,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLEmbed
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x5D,
                0xF2,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLMapEvents2
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x1E,
                0xF6,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLMapEvents
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xBA,
                0xF3,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLAreasCollection
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x83,
                0xF3,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLAreasCollection2
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xEC,
                0xF5,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLAreasCollection3
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x37,
                0xF8,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLAreasCollection4
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x92,
                0x04,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLMapElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x66,
                0xF2,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispHTMLAreasCollection
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x6A,
                0xF5,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLAreasCollection
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xCA,
                0xF4,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispHTMLMapElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x26,
                0xF5,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLMapElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x71,
                0xF2,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLAreaEvents2
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x11,
                0xF6,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLAreaEvents
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x66,
                0xF3,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLAreaElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x65,
                0xF2,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLAreaElement2
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x1F,
                0x04,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispHTMLAreaElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x03,
                0xF5,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLAreaElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x83,
                0xF2,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLTableCaption
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xEB,
                0xF2,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispHTMLTableCaption
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x08,
                0xF5,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLTableCaption
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xEC,
                0xF2,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLCommentElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x0C,
                0xF2,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLCommentElement2
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x13,
                0xF8,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLCommentElement3
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x3F,
                0x07,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispHTMLCommentElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x0A,
                0xF5,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLCommentElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x17,
                0xF3,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLPhraseElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x0A,
                0xF2,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLPhraseElement2
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x24,
                0xF8,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLPhraseElement3
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x3D,
                0x04,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLSpanElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xF3,
                0xF3,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispHTMLPhraseElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x2D,
                0xF5,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLPhraseElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x6E,
                0xF2,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispHTMLSpanElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x48,
                0xF5,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLSpanElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xF5,
                0xF3,
                0x50,
                0x30,
                0xB4,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLTableEvents2
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x23,
                0xF6,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLTableEvents
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x07,
                0xF4,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLTableSection
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x3B,
                0xF2,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLTable
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x1E,
                0xF2,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLTable2
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xAD,
                0xF4,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLTable3
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x29,
                0xF8,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLTable4
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xC2,
                0x06,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLTableCol
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x3A,
                0xF2,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLTableCol2
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x2A,
                0xF8,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLTableCol3
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xC4,
                0x06,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLTableSection2
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xC7,
                0xF5,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLTableSection3
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x2B,
                0xF8,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLTableSection4
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xC5,
                0x06,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLTableRow
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x3C,
                0xF2,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLTableRow2
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xA1,
                0xF4,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLTableRow3
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x2C,
                0xF8,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLTableRow4
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xC6,
                0x06,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLTableRowMetrics
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x13,
                0xF4,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLTableCell
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x3D,
                0xF2,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLTableCell2
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x2D,
                0xF8,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLTableCell3
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xC7,
                0x06,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispHTMLTable
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x32,
                0xF5,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLTable
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x6B,
                0xF2,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispHTMLTableCol
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x33,
                0xF5,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLTableCol
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x6C,
                0xF2,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispHTMLTableSection
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x34,
                0xF5,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLTableSection
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xE9,
                0xF2,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispHTMLTableRow
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x35,
                0xF5,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLTableRow
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x6D,
                0xF2,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispHTMLTableCell
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x36,
                0xF5,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLTableCell
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x46,
                0xF2,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLScriptEvents2
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x21,
                0xF6,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLScriptEvents
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xE2,
                0xF3,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLScriptElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x8B,
                0xF2,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLScriptElement2
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x28,
                0xF8,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLScriptElement3
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x47,
                0x04,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLScriptElement4
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x01,
                0x08,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispHTMLScriptElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x30,
                0xF5,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLScriptElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x8C,
                0xF2,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLNoShowElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x8A,
                0xF3,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispHTMLNoShowElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x28,
                0xF5,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLNoShowElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x8B,
                0xF3,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLObjectElementEvents2
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x20,
                0xF6,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLObjectElementEvents
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xC4,
                0xF3,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLObjectElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x4F,
                0xF2,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLObjectElement2
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xCD,
                0xF4,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLObjectElement3
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x27,
                0xF8,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLObjectElement4
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x3E,
                0x04,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLObjectElement5
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xB5,
                0x04,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLParamElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x3D,
                0xF8,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLParamElement2
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x44,
                0x04,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispHTMLObjectElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x29,
                0xF5,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLObjectElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x4E,
                0xF2,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispHTMLParamElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x90,
                0xF5,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLParamElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x3E,
                0xF8,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLFrameSiteEvents2
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xFF,
                0xF7,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLFrameSiteEvents
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x00,
                0xF8,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLFrameBase2
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xDB,
                0xF6,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLFrameBase3
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x2E,
                0xF8,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispHTMLFrameBase
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x41,
                0xF5,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLFrameBase
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x12,
                0xF3,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLFrameElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x13,
                0xF3,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLFrameElement2
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xF5,
                0xF7,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLFrameElement3
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x2D,
                0x04,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispHTMLFrameElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x13,
                0xF5,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLFrameElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x14,
                0xF3,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLIFrameElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x15,
                0xF3,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLIFrameElement2
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xE6,
                0xF4,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLIFrameElement3
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x33,
                0x04,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispHTMLIFrame
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x1B,
                0xF5,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLIFrame
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x16,
                0xF3,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLDivPosition
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x12,
                0xF2,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLFieldSetElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xE7,
                0xF3,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLFieldSetElement2
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x33,
                0xF8,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLLegendElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xEA,
                0xF3,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLLegendElement2
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x34,
                0xF8,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispHTMLDivPosition
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x0F,
                0xF5,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLDivPosition
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x49,
                0xF2,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispHTMLFieldSetElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x45,
                0xF5,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLFieldSetElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xE8,
                0xF3,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispHTMLLegendElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x46,
                0xF5,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLLegendElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xE9,
                0xF3,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLSpanFlow
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xE5,
                0xF3,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispHTMLSpanFlow
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x44,
                0xF5,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLSpanFlow
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xE6,
                0xF3,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLFrameSetElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x19,
                0xF3,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLFrameSetElement2
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xC6,
                0xF5,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLFrameSetElement3
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x96,
                0x07,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispHTMLFrameSetSite
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x14,
                0xF5,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLFrameSetSite
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x1A,
                0xF3,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLBGsound
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x69,
                0xF3,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispHTMLBGsound
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x3C,
                0xF5,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLBGsound
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x70,
                0xF3,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLFontNamesCollection
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x76,
                0xF3,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLFontSizesCollection
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x77,
                0xF3,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLOptionsHolder
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x78,
                0xF3,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLStyleElementEvents2
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x15,
                0xF6,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLStyleElementEvents
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xCB,
                0xF3,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLStyleElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x75,
                0xF3,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLStyleElement2
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x2A,
                0x07,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispHTMLStyleElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x11,
                0xF5,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLStyleElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x7D,
                0xF3,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLStyleFontFace
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xD5,
                0xF3,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLStyleFontFace2
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xEC,
                0x06,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispHTMLStyleFontFace
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x81,
                0x00,
                0x59,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLStyleFontFace
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xD4,
                0xF3,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLXDomainRequest
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x54,
                0x04,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLXDomainRequestFactory
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x56,
                0x04,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispXDomainRequest
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x99,
                0xF5,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_XDomainRequest
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x55,
                0x04,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_XDomainRequestFactory
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x57,
                0x04,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLStorage2
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x99,
                0x07,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispHTMLStorage
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x9D,
                0xF5,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLStorage
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x75,
                0x04,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IEventTarget
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xB9,
                0x04,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispDOMEvent
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xA2,
                0xF5,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DOMEvent
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xBB,
                0x04,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IDOMUIEvent
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xCA,
                0x06,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispDOMUIEvent
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x72,
                0x00,
                0x59,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DOMUIEvent
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xCB,
                0x06,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IDOMMouseEvent
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xCE,
                0x06,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispDOMMouseEvent
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x73,
                0x00,
                0x59,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DOMMouseEvent
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xCF,
                0x06,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IDOMDragEvent
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x61,
                0x07,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispDOMDragEvent
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xA7,
                0x00,
                0x59,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DOMDragEvent
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x62,
                0x07,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IDOMMouseWheelEvent
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xD0,
                0x06,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispDOMMouseWheelEvent
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x74,
                0x00,
                0x59,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DOMMouseWheelEvent
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xD1,
                0x06,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IDOMWheelEvent
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xD2,
                0x06,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispDOMWheelEvent
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x75,
                0x00,
                0x59,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DOMWheelEvent
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xD3,
                0x06,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IDOMTextEvent
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xD4,
                0x06,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispDOMTextEvent
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x76,
                0x00,
                0x59,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DOMTextEvent
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xD5,
                0x06,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IDOMKeyboardEvent
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xD6,
                0x06,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispDOMKeyboardEvent
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x77,
                0x00,
                0x59,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DOMKeyboardEvent
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xD7,
                0x06,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IDOMCompositionEvent
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xD8,
                0x06,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispDOMCompositionEvent
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x78,
                0x00,
                0x59,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DOMCompositionEvent
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xD9,
                0x06,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IDOMMutationEvent
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xDA,
                0x06,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispDOMMutationEvent
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x79,
                0x00,
                0x59,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DOMMutationEvent
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xDB,
                0x06,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IDOMBeforeUnloadEvent
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x63,
                0x07,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispDOMBeforeUnloadEvent
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xA8,
                0x00,
                0x59,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DOMBeforeUnloadEvent
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x64,
                0x07,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IDOMFocusEvent
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xCC,
                0x06,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispDOMFocusEvent
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x71,
                0x00,
                0x59,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DOMFocusEvent
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xCD,
                0x06,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IDOMCustomEvent
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xDE,
                0x06,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispDOMCustomEvent
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x7C,
                0x00,
                0x59,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DOMCustomEvent
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xDF,
                0x06,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ICanvasGradient
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x14,
                0x07,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ICanvasPattern
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x16,
                0x07,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ICanvasTextMetrics
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x18,
                0x07,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ICanvasImageData
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x1A,
                0x07,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ICanvasPixelArray
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x1C,
                0x07,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLCanvasElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xE4,
                0x06,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ICanvasRenderingContext2D
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xFF,
                0x06,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispCanvasGradient
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x8C,
                0x00,
                0x59,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CanvasGradient
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x15,
                0x07,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispCanvasPattern
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x8D,
                0x00,
                0x59,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CanvasPattern
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x17,
                0x07,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispCanvasTextMetrics
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x8E,
                0x00,
                0x59,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CanvasTextMetrics
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x19,
                0x07,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispCanvasImageData
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x8F,
                0x00,
                0x59,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CanvasImageData
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x1B,
                0x07,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispCanvasRenderingContext2D
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x82,
                0x00,
                0x59,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CanvasRenderingContext2D
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x00,
                0x07,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispHTMLCanvasElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x7B,
                0x00,
                0x59,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLCanvasElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xE5,
                0x06,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IDOMProgressEvent
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x1E,
                0x07,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispDOMProgressEvent
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x91,
                0x00,
                0x59,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DOMProgressEvent
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x1F,
                0x07,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IDOMMessageEvent
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x20,
                0x07,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispDOMMessageEvent
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x92,
                0x00,
                0x59,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DOMMessageEvent
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x21,
                0x07,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IDOMSiteModeEvent
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x65,
                0x07,
                0x51,
                0x30,
                0xB6,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispDOMSiteModeEvent
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xA9,
                0x00,
                0x59,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DOMSiteModeEvent
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x66,
                0x07,
                0x51,
                0x30,
                0xB6,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IDOMStorageEvent
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x22,
                0x07,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispDOMStorageEvent
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x93,
                0x00,
                0x59,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DOMStorageEvent
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x23,
                0x07,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IXMLHttpRequestEventTarget
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x30,
                0x08,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispXMLHttpRequestEventTarget
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xE7,
                0x00,
                0x59,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_XMLHttpRequestEventTarget
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x31,
                0x08,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLXMLHttpRequestEvents
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x98,
                0x04,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLXMLHttpRequest
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x0A,
                0x04,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLXMLHttpRequest2
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x82,
                0x04,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLXMLHttpRequestFactory
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x0C,
                0x04,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispHTMLXMLHttpRequest
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x96,
                0xF5,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLXMLHttpRequest
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x0B,
                0x04,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLXMLHttpRequestFactory
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x0D,
                0x04,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISVGAngle
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xD3,
                0x04,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_SVGAngle
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x84,
                0x05,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISVGElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xC5,
                0x04,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISVGRect
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xD7,
                0x04,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISVGMatrix
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xF6,
                0x04,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISVGStringList
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xC8,
                0x04,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISVGAnimatedRect
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xD8,
                0x04,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISVGAnimatedString
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xC7,
                0x04,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISVGAnimatedBoolean
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xC6,
                0x04,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISVGAnimatedTransformList
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xF9,
                0x04,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISVGAnimatedPreserveAspectRatio
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xFB,
                0x04,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISVGStylable
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xDA,
                0x04,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISVGLocatable
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xDB,
                0x04,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISVGTransformable
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xDC,
                0x04,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISVGTests
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xDD,
                0x04,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISVGLangSpace
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xDE,
                0x04,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISVGExternalResourcesRequired
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xDF,
                0x04,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISVGFitToViewBox
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xE0,
                0x04,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISVGZoomAndPan
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xE1,
                0x04,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISVGURIReference
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xE3,
                0x04,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISVGAnimatedAngle
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xD4,
                0x04,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_SVGAnimatedAngle
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xE4,
                0x05,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISVGTransformList
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xF8,
                0x04,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_SVGAnimatedTransformList
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xB1,
                0x05,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_SVGAnimatedBoolean
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x8B,
                0x05,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISVGAnimatedEnumeration
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xC9,
                0x04,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_SVGAnimatedEnumeration
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x8E,
                0x05,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISVGAnimatedInteger
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xCA,
                0x04,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_SVGAnimatedInteger
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x8F,
                0x05,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISVGLength
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xCF,
                0x04,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISVGAnimatedLength
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xD0,
                0x04,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_SVGAnimatedLength
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x81,
                0x05,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISVGLengthList
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xD1,
                0x04,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISVGAnimatedLengthList
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xD2,
                0x04,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_SVGAnimatedLengthList
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x82,
                0x05,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISVGNumber
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xCB,
                0x04,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISVGAnimatedNumber
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xCC,
                0x04,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_SVGAnimatedNumber
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x88,
                0x05,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISVGNumberList
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xCD,
                0x04,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISVGAnimatedNumberList
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xCE,
                0x04,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_SVGAnimatedNumberList
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x8A,
                0x05,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_SVGAnimatedRect
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x86,
                0x05,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_SVGAnimatedString
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x8C,
                0x05,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISVGClipPathElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x2D,
                0x05,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispSVGClipPathElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x3B,
                0x00,
                0x59,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_SVGClipPathElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xE6,
                0x05,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISVGDocument
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xE6,
                0x04,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IGetSVGDocument
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xAB,
                0x05,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispSVGElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x00,
                0x00,
                0x59,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_SVGElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x64,
                0x05,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IICCSVGColor
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xD6,
                0x04,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_SVGLength
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x7E,
                0x05,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_SVGLengthList
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x80,
                0x05,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_SVGMatrix
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xAE,
                0x05,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_SVGNumber
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x87,
                0x05,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_SVGNumberList
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x89,
                0x05,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISVGPaint
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x24,
                0x05,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISVGPatternElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x2C,
                0x05,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispSVGPatternElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x2C,
                0x00,
                0x59,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_SVGPatternElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xD4,
                0x05,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISVGPathSeg
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xFC,
                0x04,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISVGPathSegArcAbs
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x06,
                0x05,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISVGPathSegArcRel
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x07,
                0x05,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISVGPathSegClosePath
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xFD,
                0x04,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISVGPathSegMovetoAbs
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xFE,
                0x04,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISVGPathSegMovetoRel
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xFF,
                0x04,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISVGPathSegLinetoAbs
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x00,
                0x05,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISVGPathSegLinetoRel
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x01,
                0x05,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISVGPathSegCurvetoCubicAbs
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x02,
                0x05,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISVGPathSegCurvetoCubicRel
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x03,
                0x05,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISVGPathSegCurvetoCubicSmoothAbs
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x0C,
                0x05,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISVGPathSegCurvetoCubicSmoothRel
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x0D,
                0x05,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISVGPathSegCurvetoQuadraticAbs
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x04,
                0x05,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISVGPathSegCurvetoQuadraticRel
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x05,
                0x05,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISVGPathSegCurvetoQuadraticSmoothAbs
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x0E,
                0x05,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISVGPathSegCurvetoQuadraticSmoothRel
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x0F,
                0x05,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISVGPathSegLinetoHorizontalAbs
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x08,
                0x05,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISVGPathSegLinetoHorizontalRel
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x09,
                0x05,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISVGPathSegLinetoVerticalAbs
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x0A,
                0x05,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISVGPathSegLinetoVerticalRel
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x0B,
                0x05,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_SVGPathSeg
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xB3,
                0x05,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispSVGPathSegArcAbs
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x13,
                0x00,
                0x59,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_SVGPathSegArcAbs
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xBB,
                0x05,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispSVGPathSegArcRel
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x14,
                0x00,
                0x59,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_SVGPathSegArcRel
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xBC,
                0x05,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispSVGPathSegClosePath
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x15,
                0x00,
                0x59,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_SVGPathSegClosePath
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xBD,
                0x05,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispSVGPathSegMovetoAbs
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x24,
                0x00,
                0x59,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_SVGPathSegMovetoAbs
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xCC,
                0x05,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispSVGPathSegMovetoRel
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x25,
                0x00,
                0x59,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_SVGPathSegMovetoRel
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xCD,
                0x05,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispSVGPathSegLinetoAbs
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x1E,
                0x00,
                0x59,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_SVGPathSegLinetoAbs
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xC6,
                0x05,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispSVGPathSegLinetoRel
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x21,
                0x00,
                0x59,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_SVGPathSegLinetoRel
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xC9,
                0x05,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispSVGPathSegCurvetoCubicAbs
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x16,
                0x00,
                0x59,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_SVGPathSegCurvetoCubicAbs
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xBE,
                0x05,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispSVGPathSegCurvetoCubicRel
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x17,
                0x00,
                0x59,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_SVGPathSegCurvetoCubicRel
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xBF,
                0x05,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispSVGPathSegCurvetoCubicSmoothAbs
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x18,
                0x00,
                0x59,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_SVGPathSegCurvetoCubicSmoothAbs
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xC0,
                0x05,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispSVGPathSegCurvetoCubicSmoothRel
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x19,
                0x00,
                0x59,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_SVGPathSegCurvetoCubicSmoothRel
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xC1,
                0x05,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispSVGPathSegCurvetoQuadraticAbs
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x1A,
                0x00,
                0x59,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_SVGPathSegCurvetoQuadraticAbs
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xC2,
                0x05,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispSVGPathSegCurvetoQuadraticRel
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x1B,
                0x00,
                0x59,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_SVGPathSegCurvetoQuadraticRel
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xC3,
                0x05,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispSVGPathSegCurvetoQuadraticSmoothAbs
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x1C,
                0x00,
                0x59,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_SVGPathSegCurvetoQuadraticSmoothAbs
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xC4,
                0x05,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispSVGPathSegCurvetoQuadraticSmoothRel
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x1D,
                0x00,
                0x59,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_SVGPathSegCurvetoQuadraticSmoothRel
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xC5,
                0x05,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispSVGPathSegLinetoHorizontalAbs
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x1F,
                0x00,
                0x59,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_SVGPathSegLinetoHorizontalAbs
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xC7,
                0x05,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispSVGPathSegLinetoHorizontalRel
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x20,
                0x00,
                0x59,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_SVGPathSegLinetoHorizontalRel
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xC8,
                0x05,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispSVGPathSegLinetoVerticalAbs
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x22,
                0x00,
                0x59,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_SVGPathSegLinetoVerticalAbs
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xCA,
                0x05,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispSVGPathSegLinetoVerticalRel
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x23,
                0x00,
                0x59,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_SVGPathSegLinetoVerticalRel
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xCB,
                0x05,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISVGPathSegList
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x10,
                0x05,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_SVGPathSegList
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xB4,
                0x05,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISVGPoint
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xF4,
                0x04,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_SVGPoint
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xBA,
                0x05,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISVGPointList
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xF5,
                0x04,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_SVGPointList
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xB9,
                0x05,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_SVGRect
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x83,
                0x05,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_SVGStringList
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x8D,
                0x05,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISVGViewSpec
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xE2,
                0x04,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISVGTransform
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xF7,
                0x04,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_SVGTransform
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xAF,
                0x05,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispSVGSVGElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x01,
                0x00,
                0x59,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_SVGSVGElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x74,
                0x05,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISVGElementInstance
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xEE,
                0x04,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISVGUseElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xED,
                0x04,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispSVGUseElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x10,
                0x00,
                0x59,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_SVGUseElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x90,
                0x05,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLStyleSheetRulesAppliedCollection
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xC0,
                0x04,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IRulesApplied
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xBF,
                0x04,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispHTMLStyleSheetRulesAppliedCollection
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xA6,
                0xF5,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLStyleSheetRulesAppliedCollection
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x45,
                0xF8,
                0x36,
                0xEB,
                0x95,
                0x23,
                0x19,
                0x47,
                0xB8,
                0x5C,
                0xD0,
                0xD8,
                0x0E,
                0x18,
                0x4B,
                0xD9
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispRulesApplied
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xA5,
                0xF5,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_RulesApplied
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x20,
                0x39,
                0x80,
                0x7C,
                0x53,
                0x7A,
                0x26,
                0x4D,
                0x98,
                0xAC,
                0xFD,
                0xD2,
                0x3E,
                0x6B,
                0x9E,
                0x01
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispRulesAppliedCollection
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xA4,
                0xF5,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_RulesAppliedCollection
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xEE,
                0x26,
                0x19,
                0x67,
                0xCF,
                0xC3,
                0xAF,
                0x40,
                0xBE,
                0x8F,
                0x1C,
                0xBA,
                0xEE,
                0x64,
                0x86,
                0xE8
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispHTMLW3CComputedStyle
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x70,
                0x00,
                0x59,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLW3CComputedStyle
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xC8,
                0x06,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_SVGTransformList
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xB0,
                0x05,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISVGAnimatedPoints
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x17,
                0x05,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISVGCircleElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x14,
                0x05,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISVGEllipseElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x15,
                0x05,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISVGLineElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x16,
                0x05,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISVGRectElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x13,
                0x05,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISVGPolygonElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x19,
                0x05,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISVGPolylineElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x18,
                0x05,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispSVGCircleElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x0A,
                0x00,
                0x59,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_SVGCircleElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x78,
                0x05,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispSVGEllipseElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x0B,
                0x00,
                0x59,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_SVGEllipseElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x79,
                0x05,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispSVGLineElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x0C,
                0x00,
                0x59,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_SVGLineElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x7A,
                0x05,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispSVGRectElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x09,
                0x00,
                0x59,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_SVGRectElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x77,
                0x05,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispSVGPolygonElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x0D,
                0x00,
                0x59,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_SVGPolygonElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x7B,
                0x05,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispSVGPolylineElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x0E,
                0x00,
                0x59,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_SVGPolylineElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x7C,
                0x05,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISVGGElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xE8,
                0x04,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispSVGGElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x02,
                0x00,
                0x59,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_SVGGElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x6F,
                0x05,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISVGSymbolElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xEC,
                0x04,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispSVGSymbolElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x04,
                0x00,
                0x59,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_SVGSymbolElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x71,
                0x05,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISVGDefsElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xE9,
                0x04,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispSVGDefsElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x03,
                0x00,
                0x59,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_SVGDefsElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x70,
                0x05,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISVGAnimatedPathData
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x11,
                0x05,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISVGPathElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x12,
                0x05,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispSVGPathElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x11,
                0x00,
                0x59,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_SVGPathElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xB2,
                0x05,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISVGPreserveAspectRatio
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xFA,
                0x04,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_SVGPreserveAspectRatio
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xD0,
                0x05,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISVGTextElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x1C,
                0x05,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispSVGTextElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x37,
                0x00,
                0x59,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_SVGTextElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xDF,
                0x05,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_SVGAnimatedPreserveAspectRatio
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xCE,
                0x05,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISVGImageElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xF0,
                0x04,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispSVGImageElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x27,
                0x00,
                0x59,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_SVGImageElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xCF,
                0x05,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISVGStopElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x2B,
                0x05,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispSVGStopElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x2D,
                0x00,
                0x59,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_SVGStopElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xD5,
                0x05,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISVGGradientElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x28,
                0x05,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispSVGGradientElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x2E,
                0x00,
                0x59,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_SVGGradientElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xD6,
                0x05,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISVGLinearGradientElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x29,
                0x05,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispSVGLinearGradientElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x2A,
                0x00,
                0x59,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_SVGLinearGradientElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xD2,
                0x05,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISVGRadialGradientElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x2A,
                0x05,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispSVGRadialGradientElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x2B,
                0x00,
                0x59,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_SVGRadialGradientElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xD3,
                0x05,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISVGMaskElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x2E,
                0x05,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispSVGMaskElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x3C,
                0x00,
                0x59,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_SVGMaskElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xE7,
                0x05,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISVGMarkerElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x25,
                0x05,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispSVGMarkerElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x36,
                0x00,
                0x59,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_SVGMarkerElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xDE,
                0x05,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISVGZoomEvent
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x4E,
                0x05,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispSVGZoomEvent
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x31,
                0x00,
                0x59,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_SVGZoomEvent
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xD9,
                0x05,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISVGAElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x4B,
                0x05,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispSVGAElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x33,
                0x00,
                0x59,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_SVGAElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xDB,
                0x05,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISVGViewElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x4C,
                0x05,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispSVGViewElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x34,
                0x00,
                0x59,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_SVGViewElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xDC,
                0x05,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLMediaError
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x04,
                0x07,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLTimeRanges
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x05,
                0x07,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLTimeRanges2
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x0B,
                0x08,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLMediaElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x06,
                0x07,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLMediaElement2
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x09,
                0x08,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLMSMediaElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x92,
                0x07,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLSourceElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x07,
                0x07,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLAudioElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x08,
                0x07,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLVideoElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x09,
                0x07,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLAudioElementFactory
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xEB,
                0x07,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispHTMLMediaError
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x86,
                0x00,
                0x59,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLMediaError
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x0A,
                0x07,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispHTMLTimeRanges
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x87,
                0x00,
                0x59,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLTimeRanges
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x0B,
                0x07,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispHTMLMediaElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x88,
                0x00,
                0x59,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLMediaElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x0C,
                0x07,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispHTMLSourceElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x89,
                0x00,
                0x59,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLSourceElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x0D,
                0x07,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispHTMLAudioElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x8A,
                0x00,
                0x59,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLAudioElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x0E,
                0x07,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLAudioElementFactory
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xEC,
                0x07,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispHTMLVideoElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x8B,
                0x00,
                0x59,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLVideoElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x0F,
                0x07,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISVGSwitchElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xF1,
                0x04,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispSVGSwitchElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x30,
                0x00,
                0x59,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_SVGSwitchElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xD8,
                0x05,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISVGDescElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xEA,
                0x04,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispSVGDescElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x05,
                0x00,
                0x59,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_SVGDescElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x72,
                0x05,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISVGTitleElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xEB,
                0x04,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispSVGTitleElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x06,
                0x00,
                0x59,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_SVGTitleElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x73,
                0x05,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISVGMetadataElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x60,
                0x05,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispSVGMetadataElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x2F,
                0x00,
                0x59,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_SVGMetadataElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xD7,
                0x05,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISVGElementInstanceList
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xEF,
                0x04,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispSVGElementInstance
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x07,
                0x00,
                0x59,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_SVGElementInstance
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x75,
                0x05,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispSVGElementInstanceList
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x08,
                0x00,
                0x59,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_SVGElementInstanceList
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x76,
                0x05,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IDOMException
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x2B,
                0x07,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispDOMException
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x94,
                0x00,
                0x59,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DOMException
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x2C,
                0x07,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IRangeException
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x2D,
                0x07,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispRangeException
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x95,
                0x00,
                0x59,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_RangeException
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x2E,
                0x07,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISVGException
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x2F,
                0x07,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispSVGException
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x96,
                0x00,
                0x59,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_SVGException
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x30,
                0x07,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IEventException
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x3A,
                0x07,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispEventException
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x99,
                0x00,
                0x59,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_EventException
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x3B,
                0x07,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISVGScriptElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x4D,
                0x05,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispSVGScriptElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x39,
                0x00,
                0x59,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_SVGScriptElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xE1,
                0x05,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISVGStyleElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xF3,
                0x04,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispSVGStyleElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x29,
                0x00,
                0x59,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_SVGStyleElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xD1,
                0x05,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISVGTextContentElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x1A,
                0x05,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispSVGTextContentElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x35,
                0x00,
                0x59,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_SVGTextContentElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xDD,
                0x05,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISVGTextPositioningElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x1B,
                0x05,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispSVGTextPositioningElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x38,
                0x00,
                0x59,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_SVGTextPositioningElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xE0,
                0x05,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispDOMDocumentType
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x98,
                0x00,
                0x59,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DOMDocumentType
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x39,
                0x07,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispNodeIterator
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x9C,
                0x00,
                0x59,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_NodeIterator
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x45,
                0x07,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispTreeWalker
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x9D,
                0x00,
                0x59,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_TreeWalker
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x47,
                0x07,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispDOMProcessingInstruction
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x9B,
                0x00,
                0x59,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DOMProcessingInstruction
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x43,
                0x07,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLPerformanceNavigation
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x50,
                0x07,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLPerformanceTiming
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x52,
                0x07,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispHTMLPerformance
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x9F,
                0x00,
                0x59,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLPerformance
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x4F,
                0x07,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispHTMLPerformanceNavigation
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xA0,
                0x00,
                0x59,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLPerformanceNavigation
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x51,
                0x07,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispHTMLPerformanceTiming
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xA1,
                0x00,
                0x59,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLPerformanceTiming
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x53,
                0x07,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISVGTSpanElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x1D,
                0x05,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispSVGTSpanElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x3A,
                0x00,
                0x59,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_SVGTSpanElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xE2,
                0x05,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ITemplatePrinter
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xB4,
                0xF6,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ITemplatePrinter2
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x3F,
                0xF8,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ITemplatePrinter3
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xA3,
                0x04,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IPrintManagerTemplatePrinter
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x14,
                0xBE,
                0x33,
                0xF6,
                0xFF,
                0x9E,
                0x4D,
                0x4C,
                0x92,
                0x9E,
                0x05,
                0x71,
                0x7B,
                0x21,
                0xB3,
                0xE6
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IPrintManagerTemplatePrinter2
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x97,
                0x34,
                0x40,
                0xC6,
                0x93,
                0x74,
                0x09,
                0x4F,
                0x80,
                0x16,
                0x54,
                0xB0,
                0x3E,
                0x9B,
                0xDA,
                0x69
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CTemplatePrinter
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xB3,
                0xF6,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispCPrintManagerTemplatePrinter
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xE9,
                0x00,
                0x59,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CPrintManagerTemplatePrinter
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x54,
                0x9F,
                0x61,
                0x63,
                0x71,
                0x9D,
                0x23,
                0x4C,
                0xA0,
                0x8D,
                0x50,
                0xD7,
                0xF1,
                0x8D,
                0xB2,
                0xE9
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISVGTextPathElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x1F,
                0x05,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispSVGTextPathElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x3D,
                0x00,
                0x59,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_SVGTextPathElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xEB,
                0x05,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IDOMXmlSerializer
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x7D,
                0x07,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IDOMParser
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x81,
                0x07,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispXMLSerializer
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xAD,
                0x00,
                0x59,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_XMLSerializer
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x7E,
                0x07,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispDOMParser
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xAE,
                0x00,
                0x59,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DOMParser
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x82,
                0x07,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IDOMXmlSerializerFactory
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x7F,
                0x07,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IDOMParserFactory
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x83,
                0x07,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLDOMXmlSerializerFactory
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x80,
                0x07,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DOMParserFactory
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x84,
                0x07,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispHTMLSemanticElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xBA,
                0x00,
                0x59,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLSemanticElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xB0,
                0x07,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLProgressElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xD6,
                0xF2,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispHTMLProgressElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xAF,
                0x00,
                0x59,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLProgressElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xD5,
                0xF2,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IDOMMSTransitionEvent
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xB5,
                0x07,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispDOMMSTransitionEvent
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xBB,
                0x00,
                0x59,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DOMMSTransitionEvent
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xB6,
                0x07,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IDOMMSAnimationEvent
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xB7,
                0x07,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispDOMMSAnimationEvent
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xBC,
                0x00,
                0x59,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DOMMSAnimationEvent
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xB8,
                0x07,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IWebGeocoordinates
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xC7,
                0x07,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IWebGeopositionError
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xC9,
                0x07,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IWebGeoposition
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xCD,
                0x07,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispWebGeolocation
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xBD,
                0x00,
                0x59,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_WebGeolocation
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xC6,
                0x07,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispWebGeocoordinates
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xBE,
                0x00,
                0x59,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_WebGeocoordinates
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xC8,
                0x07,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispWebGeopositionError
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xBF,
                0x00,
                0x59,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_WebGeopositionError
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xCA,
                0x07,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispWebGeoposition
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xC1,
                0x00,
                0x59,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_WebGeoposition
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xCE,
                0x07,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IClientCaps
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x4D,
                0xC4,
                0x8B,
                0x7E,
                0xFF,
                0xAE,
                0xD1,
                0x11,
                0x89,
                0xC2,
                0x00,
                0xC0,
                0x4F,
                0xB6,
                0xBF,
                0xC4
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CClientCaps
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x4E,
                0xC4,
                0x8B,
                0x7E,
                0xFF,
                0xAE,
                0xD1,
                0x11,
                0x89,
                0xC2,
                0x00,
                0xC0,
                0x4F,
                0xB6,
                0xBF,
                0xC4
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IDOMMSManipulationEvent
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x16,
                0x08,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispDOMMSManipulationEvent
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xE1,
                0x00,
                0x59,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DOMMSManipulationEvent
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x17,
                0x08,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IDOMCloseEvent
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xFF,
                0x07,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispDOMCloseEvent
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xDC,
                0x00,
                0x59,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DOMCloseEvent
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x00,
                0x08,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispApplicationCache
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xE4,
                0x00,
                0x59,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ApplicationCache
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x29,
                0x08,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ICSSFilterSite
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xED,
                0xF3,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMarkupPointer
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x9F,
                0xF4,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMarkupContainer
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xF9,
                0xF5,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMarkupContainer2
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x48,
                0xF6,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLChangeLog
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x49,
                0xF6,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLChangeSink
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x4A,
                0xF6,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISegmentList
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x05,
                0xF6,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISegmentListIterator
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x92,
                0xF6,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLCaret
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x04,
                0xF6,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISegment
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x83,
                0xF6,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IElementSegment
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x8F,
                0xF6,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHighlightSegment
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x90,
                0xF6,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHighlightRenderingServices
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x06,
                0xF6,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ILineInfo
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xE2,
                0xF7,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IDisplayPointer
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x9E,
                0xF6,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IDisplayServices
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x9D,
                0xF6,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHtmlDlgSafeHelper
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x1A,
                0xF8,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IBlockFormats
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x30,
                0xF8,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IFontNames
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x39,
                0xF8,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ICSSFilter
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xEC,
                0xF3,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISecureUrlHost
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xC4,
                0x84,
                0x19,
                0xC8,
                0xC8,
                0x74,
                0xD2,
                0x11,
                0xBA,
                0xA9,
                0x00,
                0xC0,
                0x4F,
                0xC2,
                0x04,
                0x0E
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMarkupServices
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xA0,
                0xF4,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMarkupServices2
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x82,
                0xF6,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLChangePlayback
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xE0,
                0xF6,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMarkupPointer2
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x75,
                0xF6,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMarkupTextFrags
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xFA,
                0xF5,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IXMLGenericParse
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x71,
                0x30,
                0xE2,
                0xE4,
                0x07,
                0x4D,
                0xD2,
                0x11,
                0xAE,
                0x76,
                0x00,
                0x80,
                0xC7,
                0x3B,
                0xC1,
                0x99
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLEditHost
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xA0,
                0xF6,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLEditHost2
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x48,
                0xF8,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0D
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISequenceNumber
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xC1,
                0xF6,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IIMEServices
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xCA,
                0xF6,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISelectionServicesListener
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x99,
                0xF6,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISelectionServices
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x84,
                0xF6,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLEditDesigner
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x62,
                0xF6,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLEditServices
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x63,
                0xF6,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLEditServices2
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x12,
                0xF8,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLComputedStyle
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xC3,
                0xF6,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HtmlDlgSafeHelper
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x19,
                0xF8,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_BlockFormats
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x31,
                0xF8,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_FontNames
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x3A,
                0xF8,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IDeveloperConsoleMessageReceiver
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x08,
                0x08,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IScriptEventHandler
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x3A,
                0x08,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IDebugCallbackNotificationHandler
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x42,
                0x08,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IScriptEventHandlerSourceInfo
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x41,
                0x08,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IDOMEventRegistrationCallback
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x3B,
                0x08,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IEventTarget2
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x39,
                0x08,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLNamespaceEvents
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xBD,
                0xF6,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLNamespace
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xBB,
                0xF6,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLNamespaceCollection
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xB8,
                0xF6,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispHTMLNamespace
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x4F,
                0xF5,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLNamespace
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xBC,
                0xF6,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispHTMLNamespaceCollection
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x50,
                0xF5,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLNamespaceCollection
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xB9,
                0xF6,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLPainter
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xA6,
                0xF6,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLPaintSite
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xA7,
                0xF6,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLPainterEventInfo
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xDF,
                0xF6,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLPainterOverlay
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xE3,
                0xF7,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLIPrintCollection
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xB5,
                0xF6,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IEnumPrivacyRecords
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x44,
                0xF8,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IWPCBlockedUrls
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x13,
                0x04,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLDOMConstructorCollection
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x9C,
                0x04,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLDialog
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x16,
                0xF2,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLDialog2
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xE0,
                0xF5,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLDialog3
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x88,
                0xF3,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLModelessInit
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xE4,
                0xF5,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ThreadDialogProcParam
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xEB,
                0xF5,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLDialog
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x8A,
                0xF2,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLPopup
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x66,
                0xF6,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispHTMLPopup
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x89,
                0xF5,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLPopup
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x67,
                0xF6,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLAppBehavior
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xCA,
                0xF5,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLAppBehavior2
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xC9,
                0xF5,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHTMLAppBehavior3
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xCD,
                0xF5,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispHTMLAppBehavior
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x7C,
                0xF5,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLAppBehavior
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xCB,
                0xF5,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_OldHTMLDocument
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xC9,
                0x6E,
                0x8A,
                0xD4,
                0x4A,
                0x6A,
                0xCF,
                0x11,
                0x94,
                0xA7,
                0x44,
                0x45,
                0x53,
                0x54,
                0x00,
                0x00
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_OldHTMLFormElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x85,
                0xD2,
                0x04,
                0x0D,
                0xEC,
                0x6B,
                0xCF,
                0x11,
                0x8B,
                0x97,
                0x00,
                0xAA,
                0x00,
                0x47,
                0x6D,
                0xA6
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispIHTMLInputButtonElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x1E,
                0xF5,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLInputButtonElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xB4,
                0xF2,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispIHTMLInputTextElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x20,
                0xF5,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLInputTextElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xAB,
                0xF2,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispIHTMLInputFileElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x42,
                0xF5,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLInputFileElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xAE,
                0xF2,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispIHTMLOptionButtonElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x09,
                0xF5,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLOptionButtonElement
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xBE,
                0xF2,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DispIHTMLInputImage
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x1D,
                0xF5,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HTMLInputImage
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xC4,
                0xF2,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IElementNamespace
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x71,
                0xF6,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IElementNamespaceTable
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x70,
                0xF6,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IElementNamespaceFactory
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x72,
                0xF6,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IElementNamespaceFactory2
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x05,
                0xF8,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IElementNamespaceFactoryCallback
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xFD,
                0xF7,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IElementBehaviorSiteOM2
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x59,
                0xF6,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IElementBehaviorCategory
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xED,
                0xF4,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IElementBehaviorSiteCategory
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xEE,
                0xF4,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IElementBehaviorSubmit
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x46,
                0xF6,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IElementBehaviorFocus
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xB6,
                0xF6,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IElementBehaviorLayout
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xBA,
                0xF6,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IElementBehaviorLayout2
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x46,
                0xF8,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IElementBehaviorSiteLayout
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xB7,
                0xF6,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IElementBehaviorSiteLayout2
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x47,
                0xF8,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHostBehaviorInit
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x42,
                0xF8,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISurfacePresenter
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xE2,
                0x06,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IViewObjectPresentSite
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xE1,
                0x06,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ICanvasPixelArrayData
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xF9,
                0x07,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IViewObjectPrint
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xE3,
                0x06,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IViewObjectPresentNotifySite
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xFA,
                0x07,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IViewObjectPresentNotify
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xF8,
                0x07,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ITrackingProtection
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x03,
                0x08,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IBFCacheable
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x61,
                0x08,
                0x51,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}