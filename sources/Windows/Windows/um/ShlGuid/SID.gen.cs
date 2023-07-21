// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShlGuid.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.CLSID;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

public partial struct SID
{
    [NativeTypeName("const GUID")]
    public static ref readonly Guid SID_DefView
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x80, 0xFE, 0x12, 0x6D,
                0x11, 0x79,
                0xCF, 0x11,
                0x95,
                0x34,
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

    [NativeTypeName("const GUID")]
    public static ref readonly Guid SID_SInPlaceBrowser
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x2B, 0xE0, 0x2A, 0x1D,
                0x55, 0x36,
                0xCC, 0x46,
                0xB6,
                0x3A,
                0x28,
                0x59,
                0x88,
                0x15,
                0x3B,
                0xCA
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid SID_SSearchBoxInfo
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x61, 0xAA, 0x2D, 0x14,
                0x6B, 0x51,
                0x13, 0x47,
                0xB4,
                0x9C,
                0xFB,
                0x98,
                0x5E,
                0xF8,
                0x29,
                0x98
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid SID_CommandsPropertyBag
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x50, 0x32, 0x04, 0x6E,
                0x16, 0x44,
                0x5C, 0x48,
                0xB1,
                0x43,
                0xE6,
                0x2A,
                0x76,
                0x0D,
                0x9F,
                0xE5
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid SID_STopLevelBrowser
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x40, 0xBE, 0x96, 0x4C,
                0x5C, 0x91,
                0xCF, 0x11,
                0x99,
                0xD3,
                0x00,
                0xAA,
                0x00,
                0x4A,
                0xE8,
                0x37
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid SID_STopWindow
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x00, 0xB5, 0xE1, 0x49,
                0x36, 0x46,
                0xD3, 0x11,
                0x97,
                0xF7,
                0x00,
                0xC0,
                0x4F,
                0x45,
                0xD0,
                0xB3
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid SID_SGetViewFromViewDual
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x5D, 0x93, 0x9A, 0x88,
                0x1E, 0x97,
                0x12, 0x4B,
                0xB9,
                0x0C,
                0x24,
                0xDF,
                0xC9,
                0xE1,
                0xE5,
                0xE8
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid SID_CtxQueryAssociations
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x40, 0xFC, 0xAD, 0xFA,
                0x77, 0xB7,
                0x69, 0x4B,
                0xAA,
                0x81,
                0x77,
                0x03,
                0x5E,
                0xF0,
                0xE6,
                0xE8
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid SID_SMenuBandChild
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x20, 0xC0, 0x9C, 0xED,
                0xB9, 0x08,
                0xD1, 0x11,
                0x98,
                0x23,
                0x00,
                0xC0,
                0x4F,
                0xD9,
                0x19,
                0x72
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid SID_SMenuBandParent
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xEC, 0x8E, 0x27, 0x8C,
                0xAB, 0x3E,
                0xD1, 0x11,
                0x8C,
                0xB0,
                0x00,
                0xC0,
                0x4F,
                0xD9,
                0x18,
                0xD0
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid SID_SMenuPopup
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xEB, 0xAF, 0xE7, 0xD1,
                0x2E, 0x6A,
                0xD0, 0x11,
                0x8C,
                0x78,
                0x00,
                0xC0,
                0x4F,
                0xD9,
                0x18,
                0xB4
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid SID_SMenuBandBottomSelected
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xF4, 0xBA, 0x5E, 0x16,
                0x51, 0x6D,
                0xD2, 0x11,
                0x83,
                0xAD,
                0x00,
                0xC0,
                0x4F,
                0xD9,
                0x18,
                0xD0
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid SID_SMenuBandBottom
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x64, 0xA6, 0x3C, 0x74,
                0xEB, 0x0D,
                0xD1, 0x11,
                0x98,
                0x25,
                0x00,
                0xC0,
                0x4F,
                0xD9,
                0x19,
                0x72
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid SID_MenuShellFolder
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xB4, 0x7E, 0xC1, 0xA6,
                0x65, 0x2D,
                0xD2, 0x11,
                0x83,
                0x8F,
                0x00,
                0xC0,
                0x4F,
                0xD9,
                0x18,
                0xD0
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid SID_SMenuBandContextMenuModifier
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x74, 0x58, 0x54, 0x39,
                0x62, 0x71,
                0x5E, 0x46,
                0xB7,
                0x83,
                0x2A,
                0xA1,
                0x87,
                0x4F,
                0xEF,
                0x81
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid SID_SMenuBandBKContextMenu
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x86, 0xBD, 0x4B, 0x16,
                0x0D, 0x1D,
                0xE0, 0x4D,
                0x9A,
                0x3B,
                0xD9,
                0x72,
                0x96,
                0x47,
                0xC2,
                0xB8
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid SID_SMenuBandTop
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x10, 0xA8, 0x93, 0x94,
                0x38, 0xEC,
                0xD0, 0x11,
                0xBC,
                0x46,
                0x00,
                0xAA,
                0x00,
                0x6C,
                0xE2,
                0xF5
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid SID_SCommDlgBrowser
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x33, 0x02, 0xF3, 0x80,
                0xDF, 0xB7,
                0xD2, 0x11,
                0xA3,
                0x3B,
                0x00,
                0x60,
                0x97,
                0xDF,
                0x5B,
                0xD4
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("#define SID_LinkSite IID_IShellLinkW")]
    public static ref readonly Guid SID_LinkSite => ref IID_IShellLinkW;

    [NativeTypeName("#define SID_ShellFolderViewCB IID_IShellFolderViewCB")]
    public static ref readonly Guid SID_ShellFolderViewCB => ref IID_IShellFolderViewCB;

    [NativeTypeName("#define SID_SShellBrowser IID_IShellBrowser")]
    public static ref readonly Guid SID_SShellBrowser => ref IID_IShellBrowser;

    [NativeTypeName("#define SID_SUrlHistory CLSID_CUrlHistory")]
    public static ref readonly Guid SID_SUrlHistory => ref CLSID_CUrlHistory;

    [NativeTypeName("#define SID_SInternetExplorer IID_IWebBrowserApp")]
    public static ref readonly Guid SID_SInternetExplorer => ref IID_IWebBrowserApp;

    [NativeTypeName("#define SID_SWebBrowserApp IID_IWebBrowserApp")]
    public static ref readonly Guid SID_SWebBrowserApp => ref IID_IWebBrowserApp;

    [NativeTypeName("#define SID_SProgressUI CLSID_ProgressDialog")]
    public static ref readonly Guid SID_SProgressUI => ref CLSID_ProgressDialog;
}
