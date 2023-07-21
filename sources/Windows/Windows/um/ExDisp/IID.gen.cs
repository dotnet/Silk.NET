// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ExDisp.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;

public static partial class IID
{
    public static ref readonly Guid IID_IWebBrowser
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xC1, 0x2A, 0xB2, 0xEA,
                0xC1, 0x30,
                0xCF, 0x11,
                0xA7,
                0xEB,
                0x00,
                0x00,
                0xC0,
                0x5B,
                0xAE,
                0x0B
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DWebBrowserEvents
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xC2, 0x2A, 0xB2, 0xEA,
                0xC1, 0x30,
                0xCF, 0x11,
                0xA7,
                0xEB,
                0x00,
                0x00,
                0xC0,
                0x5B,
                0xAE,
                0x0B
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IWebBrowserApp
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x05, 0xDF, 0x02, 0x00,
                0x00, 0x00,
                0x00, 0x00,
                0xC0,
                0x00,
                0x00,
                0x00,
                0x00,
                0x00,
                0x00,
                0x46
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IWebBrowser2
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x61, 0x16, 0x0C, 0xD3,
                0xAF, 0xCD,
                0xD0, 0x11,
                0x8A,
                0x3E,
                0x00,
                0xC0,
                0x4F,
                0xC9,
                0xE2,
                0x6E
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DWebBrowserEvents2
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xA0, 0x15, 0xA7, 0x34,
                0x87, 0x65,
                0xD0, 0x11,
                0x92,
                0x4A,
                0x00,
                0x20,
                0xAF,
                0xC7,
                0xAC,
                0x4D
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_WebBrowser_V1
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xC3, 0x2A, 0xB2, 0xEA,
                0xC1, 0x30,
                0xCF, 0x11,
                0xA7,
                0xEB,
                0x00,
                0x00,
                0xC0,
                0x5B,
                0xAE,
                0x0B
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_WebBrowser
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x61, 0xF9, 0x56, 0x88,
                0x0A, 0x34,
                0xD0, 0x11,
                0xA9,
                0x6B,
                0x00,
                0xC0,
                0x4F,
                0xD7,
                0x05,
                0xA2
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_InternetExplorer
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x01, 0xDF, 0x02, 0x00,
                0x00, 0x00,
                0x00, 0x00,
                0xC0,
                0x00,
                0x00,
                0x00,
                0x00,
                0x00,
                0x00,
                0x46
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_InternetExplorerMedium
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x1D, 0x04, 0xE8, 0xD5,
                0x0F, 0x92,
                0xE9, 0x45,
                0xB8,
                0xFB,
                0xB1,
                0xDE,
                0xB8,
                0x2C,
                0x6E,
                0x5E
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ShellBrowserWindow
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x90, 0xFD, 0x8A, 0xC0,
                0xA1, 0xF2,
                0xD1, 0x11,
                0x84,
                0x55,
                0x00,
                0xA0,
                0xC9,
                0x1F,
                0x38,
                0x80
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DShellWindowsEvents
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xE0, 0x06, 0x41, 0xFE,
                0x9A, 0x39,
                0xD0, 0x11,
                0xA4,
                0x8C,
                0x00,
                0xA0,
                0xC9,
                0x0A,
                0x8F,
                0x39
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IShellWindows
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x00, 0x69, 0xCB, 0x85,
                0x95, 0x4D,
                0xCF, 0x11,
                0x96,
                0x0C,
                0x00,
                0x80,
                0xC7,
                0xF4,
                0xEE,
                0x85
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ShellWindows
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x72, 0x59, 0xA0, 0x9B,
                0xA8, 0xF6,
                0xCF, 0x11,
                0xA4,
                0x42,
                0x00,
                0xA0,
                0xC9,
                0x0A,
                0x8F,
                0x39
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IShellUIHelper
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xF8, 0xE2, 0x9F, 0x72,
                0xA8, 0x1E,
                0xD1, 0x11,
                0x8F,
                0x85,
                0x00,
                0xC0,
                0x4F,
                0xC2,
                0xFB,
                0xE1
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IShellUIHelper2
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xDA, 0x6E, 0xFE, 0xA7,
                0x32, 0x19,
                0x81, 0x42,
                0xB8,
                0x81,
                0x87,
                0xB3,
                0x1B,
                0x8B,
                0xC5,
                0x2C
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IShellUIHelper3
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xEC, 0xF2, 0x8D, 0x52,
                0x19, 0xD4,
                0xBC, 0x40,
                0x9B,
                0x6D,
                0xDC,
                0xDB,
                0xF9,
                0xC1,
                0xB2,
                0x5D
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IShellUIHelper4
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x53, 0x6A, 0x6E, 0xB3,
                0x73, 0x80,
                0x9E, 0x49,
                0x82,
                0x4C,
                0xD7,
                0x76,
                0x33,
                0x0A,
                0x33,
                0x3E
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IShellUIHelper5
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x09, 0x8B, 0xA0, 0xA2,
                0x3D, 0x10,
                0x3F, 0x4D,
                0xB9,
                0x1C,
                0xEA,
                0x45,
                0x5C,
                0xA8,
                0x2E,
                0xFA
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IShellUIHelper6
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x3E, 0x57, 0x7A, 0x98,
                0xEE, 0x46,
                0x89, 0x4E,
                0x96,
                0xAB,
                0xDD,
                0xF7,
                0xF8,
                0xFD,
                0xC9,
                0x8C
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IShellUIHelper7
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xC8, 0x67, 0xE5, 0x60,
                0x73, 0x95,
                0xB2, 0x4A,
                0xA2,
                0x64,
                0x63,
                0x7C,
                0x6C,
                0x16,
                0x1C,
                0xB1
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IShellUIHelper8
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xF2, 0xBC, 0xDE, 0x66,
                0xB0, 0x05,
                0x07, 0x4F,
                0xB4,
                0x9B,
                0xB9,
                0x62,
                0x41,
                0xA6,
                0x5D,
                0xB2
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IShellUIHelper9
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xB0, 0x73, 0xDF, 0x6C,
                0x2F, 0x7F,
                0x1F, 0x45,
                0xBC,
                0x0F,
                0x63,
                0xE0,
                0xF3,
                0x28,
                0x4E,
                0x54
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ShellUIHelper
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xB7, 0x4B, 0xAB, 0x64,
                0x1E, 0x11,
                0xD1, 0x11,
                0x8F,
                0x79,
                0x00,
                0xC0,
                0x4F,
                0xC2,
                0xFB,
                0xE1
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DShellNameSpaceEvents
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x06, 0x68, 0x13, 0x55,
                0xDE, 0xB2,
                0xD1, 0x11,
                0xB9,
                0xF2,
                0x00,
                0xA0,
                0xC9,
                0x8B,
                0xC5,
                0x47
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IShellFavoritesNameSpace
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x04, 0x68, 0x13, 0x55,
                0xDE, 0xB2,
                0xD1, 0x11,
                0xB9,
                0xF2,
                0x00,
                0xA0,
                0xC9,
                0x8B,
                0xC5,
                0x47
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IShellNameSpace
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xC9, 0xD3, 0x72, 0xE5,
                0xBE, 0x37,
                0xE2, 0x4A,
                0x82,
                0x5D,
                0xD5,
                0x21,
                0x76,
                0x3E,
                0x31,
                0x08
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ShellNameSpace
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x05, 0x68, 0x13, 0x55,
                0xDE, 0xB2,
                0xD1, 0x11,
                0xB9,
                0xF2,
                0x00,
                0xA0,
                0xC9,
                0x8B,
                0xC5,
                0x47
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IScriptErrorList
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x24, 0x0F, 0x47, 0xF3,
                0xFD, 0x15,
                0xD2, 0x11,
                0xBB,
                0x2E,
                0x00,
                0x80,
                0x5F,
                0xF7,
                0xEF,
                0xCA
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CScriptErrorList
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x00, 0x13, 0xD0, 0xEF,
                0x0F, 0x16,
                0xD2, 0x11,
                0xBB,
                0x2E,
                0x00,
                0x80,
                0x5F,
                0xF7,
                0xEF,
                0xCA
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
