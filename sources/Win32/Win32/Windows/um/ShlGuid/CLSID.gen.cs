// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShlGuid.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class CLSID
{
    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_NetworkDomain
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x80,
                0x66,
                0xE0,
                0x46,
                0xF0,
                0x4B,
                0xD1,
                0x11,
                0x83,
                0xEE,
                0x00,
                0xA0,
                0xC9,
                0x0D,
                0xC8,
                0x49,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_NetworkServer
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x90,
                0x2A,
                0x54,
                0xC0,
                0xF0,
                0x4B,
                0xD1,
                0x11,
                0x83,
                0xEE,
                0x00,
                0xA0,
                0xC9,
                0x0D,
                0xC8,
                0x49,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_NetworkShare
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC0,
                0x54,
                0xA7,
                0x54,
                0xF0,
                0x4B,
                0xD1,
                0x11,
                0x83,
                0xEE,
                0x00,
                0xA0,
                0xC9,
                0x0D,
                0xC8,
                0x49,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_MyComputer
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE0,
                0x4F,
                0xD0,
                0x20,
                0xEA,
                0x3A,
                0x69,
                0x10,
                0xA2,
                0xD8,
                0x08,
                0x00,
                0x2B,
                0x30,
                0x30,
                0x9D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_Internet
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x80,
                0x53,
                0x1C,
                0x87,
                0xA0,
                0x42,
                0x69,
                0x10,
                0xA2,
                0xEA,
                0x08,
                0x00,
                0x2B,
                0x30,
                0x30,
                0x9D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_RecycleBin
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x40,
                0xF0,
                0x5F,
                0x64,
                0x81,
                0x50,
                0x1B,
                0x10,
                0x9F,
                0x08,
                0x00,
                0xAA,
                0x00,
                0x2F,
                0x95,
                0x4E,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_ControlPanel
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x20,
                0x20,
                0xEC,
                0x21,
                0xEA,
                0x3A,
                0x69,
                0x10,
                0xA2,
                0xDD,
                0x08,
                0x00,
                0x2B,
                0x30,
                0x30,
                0x9D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_Printers
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x80,
                0xA2,
                0x27,
                0x22,
                0xEA,
                0x3A,
                0x69,
                0x10,
                0xA2,
                0xDE,
                0x08,
                0x00,
                0x2B,
                0x30,
                0x30,
                0x9D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_MyDocuments
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xBA,
                0x8F,
                0x0D,
                0x45,
                0x25,
                0xAD,
                0xD0,
                0x11,
                0x98,
                0xA8,
                0x08,
                0x00,
                0x36,
                0x1B,
                0x11,
                0x03,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_FolderShortcut
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD1,
                0xCE,
                0xFA,
                0x0A,
                0x28,
                0xE8,
                0xD1,
                0x11,
                0x91,
                0x87,
                0xB5,
                0x32,
                0xF1,
                0xE9,
                0x57,
                0x5D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_CFSIconOverlayManager
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x81,
                0x1F,
                0xB5,
                0x63,
                0x68,
                0xC8,
                0xD0,
                0x11,
                0x99,
                0x9C,
                0x00,
                0xC0,
                0x4F,
                0xD6,
                0x55,
                0xE1,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_MenuBand
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x26,
                0xAE,
                0x4D,
                0x5B,
                0x07,
                0xB8,
                0xD0,
                0x11,
                0x98,
                0x15,
                0x00,
                0xC0,
                0x4F,
                0xD9,
                0x19,
                0x72,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_CUrlHistory
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x40,
                0x4A,
                0x37,
                0x3C,
                0xE4,
                0xBA,
                0xCF,
                0x11,
                0xBF,
                0x7D,
                0x00,
                0xAA,
                0x00,
                0x69,
                0x46,
                0xEE,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_CUrlHistoryBoth
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x3C,
                0x98,
                0x59,
                0x66,
                0x76,
                0x84,
                0xB4,
                0x4E,
                0xB7,
                0x8C,
                0xE5,
                0x96,
                0x8F,
                0x32,
                0x6B,
                0xA0,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_CURLSearchHook
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x00,
                0xAE,
                0xBF,
                0xCF,
                0xA6,
                0x17,
                0xD0,
                0x11,
                0x99,
                0xCB,
                0x00,
                0xC0,
                0x4F,
                0xD6,
                0x44,
                0x97,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_AutoComplete
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x63,
                0x27,
                0xBB,
                0x00,
                0x77,
                0x6A,
                0xD0,
                0x11,
                0xA5,
                0x35,
                0x00,
                0xC0,
                0x4F,
                0xD7,
                0xD0,
                0x62,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_ACLHistory
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x64,
                0x27,
                0xBB,
                0x00,
                0x77,
                0x6A,
                0xD0,
                0x11,
                0xA5,
                0x35,
                0x00,
                0xC0,
                0x4F,
                0xD7,
                0xD0,
                0x62,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_ACListISF
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF1,
                0x36,
                0xC0,
                0x03,
                0x86,
                0xA1,
                0xD0,
                0x11,
                0x82,
                0x4A,
                0x00,
                0xAA,
                0x00,
                0x5B,
                0x43,
                0x83,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_ACLMRU
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x41,
                0xA6,
                0x56,
                0x67,
                0x71,
                0xDE,
                0xD0,
                0x11,
                0x83,
                0x1B,
                0x00,
                0xAA,
                0x00,
                0x5B,
                0x43,
                0x83,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_ACLMulti
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x65,
                0x27,
                0xBB,
                0x00,
                0x77,
                0x6A,
                0xD0,
                0x11,
                0xA5,
                0x35,
                0x00,
                0xC0,
                0x4F,
                0xD7,
                0xD0,
                0x62,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_ACLCustomMRU
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x93,
                0xDB,
                0x35,
                0x69,
                0xE8,
                0x21,
                0xCC,
                0x4C,
                0xBE,
                0xB9,
                0x9F,
                0xE3,
                0xC7,
                0x7A,
                0x29,
                0x7A,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_ProgressDialog
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x52,
                0x38,
                0x38,
                0xF8,
                0xD3,
                0xFC,
                0xD1,
                0x11,
                0xA6,
                0xB9,
                0x00,
                0x60,
                0x97,
                0xDF,
                0x5B,
                0xD4,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_FileTypes
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x40,
                0xE5,
                0x91,
                0xB0,
                0xE3,
                0x83,
                0xCF,
                0x11,
                0xA7,
                0x13,
                0x00,
                0x20,
                0xAF,
                0xD7,
                0x97,
                0x62,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_ActiveDesktop
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x00,
                0x87,
                0x04,
                0x75,
                0x1F,
                0xEF,
                0xD0,
                0x11,
                0x98,
                0x88,
                0x00,
                0x60,
                0x97,
                0xDE,
                0xAC,
                0xF9,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_QueryAssociations
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xFD,
                0x34,
                0x70,
                0xA0,
                0xAA,
                0x6C,
                0x54,
                0x49,
                0xAC,
                0x3F,
                0x97,
                0xA2,
                0x72,
                0x16,
                0xF9,
                0x8A,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_LinkColumnProvider
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x02,
                0x4F,
                0xF1,
                0x24,
                0x1C,
                0x7B,
                0xD1,
                0x11,
                0x83,
                0x8F,
                0x00,
                0x00,
                0xF8,
                0x04,
                0x61,
                0xCF,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_InternetButtons
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x80,
                0x69,
                0x79,
                0x1E,
                0xC5,
                0x9C,
                0xD1,
                0x11,
                0xA8,
                0x3F,
                0x00,
                0xC0,
                0x4F,
                0xC9,
                0x9D,
                0x61,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_MSOButtons
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB8,
                0x34,
                0x8F,
                0x17,
                0x82,
                0xA2,
                0xD2,
                0x11,
                0x86,
                0xC5,
                0x00,
                0xC0,
                0x4F,
                0x8E,
                0xEA,
                0x99,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_ToolbarExtButtons
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD8,
                0xB5,
                0xE4,
                0x2C,
                0x8F,
                0xA2,
                0xD2,
                0x11,
                0x86,
                0xC5,
                0x00,
                0xC0,
                0x4F,
                0x8E,
                0xEA,
                0x99,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_DarwinAppPublisher
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA0,
                0xC7,
                0xCC,
                0xCF,
                0x82,
                0xA2,
                0xD1,
                0x11,
                0x90,
                0x82,
                0x00,
                0x60,
                0x08,
                0x05,
                0x93,
                0x82,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_DocHostUIHandler
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x52,
                0xE9,
                0x57,
                0x70,
                0x1B,
                0xBD,
                0xD1,
                0x11,
                0x89,
                0x19,
                0x00,
                0xC0,
                0x4F,
                0xC2,
                0xC8,
                0x36,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_HWShellExecute
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x5F,
                0x65,
                0xB8,
                0xFF,
                0xB9,
                0x81,
                0xCE,
                0x4F,
                0xB8,
                0x9C,
                0x9A,
                0x6B,
                0xA7,
                0x6D,
                0x13,
                0xE7,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_DragDropHelper
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x8A,
                0x27,
                0x57,
                0x46,
                0x1B,
                0x41,
                0xD2,
                0x11,
                0x83,
                0x9A,
                0x00,
                0xC0,
                0x4F,
                0xD9,
                0x18,
                0xD0,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_CAnchorBrowsePropertyPage
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xBB,
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
                0x0B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_CImageBrowsePropertyPage
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB3,
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
                0x0B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_CDocBrowsePropertyPage
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB4,
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
                0x0B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_FolderItem
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA2,
                0x0F,
                0xF1,
                0xFE,
                0x5E,
                0x35,
                0x06,
                0x4E,
                0x93,
                0x81,
                0x9B,
                0x24,
                0xD7,
                0xF7,
                0xCC,
                0x88,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_FolderItemsMultiLevel
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x26,
                0x48,
                0xC7,
                0x53,
                0x99,
                0xAB,
                0x33,
                0x4D,
                0xAC,
                0xA4,
                0x31,
                0x17,
                0xF5,
                0x1D,
                0x37,
                0x88,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_NewMenu
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x00,
                0xA3,
                0x69,
                0xD9,
                0xFF,
                0xE7,
                0xD0,
                0x11,
                0xA9,
                0x3B,
                0x00,
                0xA0,
                0xC9,
                0x0F,
                0x27,
                0x19,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_QuickLinks
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x21,
                0xBF,
                0x5C,
                0x0E,
                0x5F,
                0xD1,
                0xD0,
                0x11,
                0x83,
                0x01,
                0x00,
                0xAA,
                0x00,
                0x5B,
                0x43,
                0x83,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_ISFBand
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB0,
                0xE2,
                0x2B,
                0xD8,
                0x64,
                0x57,
                0xD0,
                0x11,
                0xA9,
                0x6E,
                0x00,
                0xC0,
                0x4F,
                0xD7,
                0x05,
                0xA2,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_ShellFldSetExt
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC0,
                0x13,
                0x53,
                0x6D,
                0x62,
                0x8C,
                0xD1,
                0x11,
                0xB2,
                0xCD,
                0x00,
                0x60,
                0x97,
                0xDF,
                0x8C,
                0x11,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_MenuToolbarBase
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x10,
                0x66,
                0xB9,
                0x40,
                0x22,
                0xB5,
                0xD1,
                0x11,
                0xB3,
                0xB4,
                0x00,
                0xAA,
                0x00,
                0x6E,
                0xFD,
                0xE7,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_MenuBandSite
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE4,
                0xF4,
                0x3E,
                0xE1,
                0xF2,
                0xD2,
                0xD0,
                0x11,
                0x98,
                0x16,
                0x00,
                0xC0,
                0x4F,
                0xD9,
                0x19,
                0x72,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
