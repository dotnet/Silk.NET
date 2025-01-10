// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShlDisp.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class IID
{
    public static ref readonly Guid IID_IFolderViewOC
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x70,
                0x59,
                0xA0,
                0x9B,
                0xA8,
                0xF6,
                0xCF,
                0x11,
                0xA4,
                0x42,
                0x00,
                0xA0,
                0xC9,
                0x0A,
                0x8F,
                0x39,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_DShellFolderViewEvents
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA2,
                0x2A,
                0x11,
                0x62,
                0xE4,
                0xEB,
                0xCF,
                0x11,
                0xA5,
                0xFB,
                0x00,
                0x20,
                0xAF,
                0xE7,
                0x29,
                0x2D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ShellFolderViewOC
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x71,
                0x59,
                0xA0,
                0x9B,
                0xA8,
                0xF6,
                0xCF,
                0x11,
                0xA4,
                0x42,
                0x00,
                0xA0,
                0xC9,
                0x0A,
                0x8F,
                0x39,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_DFConstraint
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x50,
                0xF0,
                0x3D,
                0x4A,
                0xBD,
                0x23,
                0xD2,
                0x11,
                0x93,
                0x9F,
                0x00,
                0xA0,
                0xC9,
                0x1E,
                0xED,
                0xBA,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_FolderItem
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x80,
                0x2C,
                0xC3,
                0xFA,
                0xE4,
                0xCB,
                0xCE,
                0x11,
                0x83,
                0x50,
                0x44,
                0x45,
                0x53,
                0x54,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_FolderItems
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE0,
                0x29,
                0x41,
                0x74,
                0xE5,
                0xCB,
                0xCE,
                0x11,
                0x83,
                0x50,
                0x44,
                0x45,
                0x53,
                0x54,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_FolderItemVerb
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x00,
                0x3E,
                0xEC,
                0x08,
                0xB0,
                0x50,
                0xCF,
                0x11,
                0x96,
                0x0C,
                0x00,
                0x80,
                0xC7,
                0xF4,
                0xEE,
                0x85,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_FolderItemVerbs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC0,
                0x52,
                0x83,
                0x1F,
                0xB0,
                0x50,
                0xCF,
                0x11,
                0x96,
                0x0C,
                0x00,
                0x80,
                0xC7,
                0xF4,
                0xEE,
                0x85,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_Folder
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x60,
                0xDE,
                0xCB,
                0xBB,
                0xFF,
                0xC3,
                0xCE,
                0x11,
                0x83,
                0x50,
                0x44,
                0x45,
                0x53,
                0x54,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_Folder2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xEF,
                0xD8,
                0xD2,
                0xF0,
                0x90,
                0x38,
                0xD2,
                0x11,
                0xBF,
                0x8B,
                0x00,
                0xC0,
                0x4F,
                0xB9,
                0x36,
                0x61,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_Folder3
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x64,
                0x5F,
                0xAE,
                0xA7,
                0xD7,
                0xC4,
                0x7F,
                0x4D,
                0x93,
                0x07,
                0x4D,
                0x24,
                0xEE,
                0x54,
                0xB8,
                0x41,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_FolderItem2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xAA,
                0x17,
                0xC8,
                0xED,
                0xB8,
                0x92,
                0xD1,
                0x11,
                0xB0,
                0x75,
                0x00,
                0xC0,
                0x4F,
                0xC3,
                0x3A,
                0xA5,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ShellFolderItem
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xEA,
                0x52,
                0xE3,
                0x2F,
                0x1F,
                0xFD,
                0xD2,
                0x11,
                0xB1,
                0xF4,
                0x00,
                0xC0,
                0x4F,
                0x8E,
                0xEB,
                0x3E,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_FolderItems2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD0,
                0x0A,
                0x4F,
                0xC9,
                0x63,
                0xF3,
                0xD2,
                0x11,
                0xA3,
                0x27,
                0x00,
                0xC0,
                0x4F,
                0x8E,
                0xEC,
                0x7F,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_FolderItems3
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x09,
                0xC3,
                0xA7,
                0xEA,
                0xEC,
                0xBB,
                0xD5,
                0x49,
                0x82,
                0x1D,
                0x64,
                0xD9,
                0x66,
                0xCB,
                0x66,
                0x7F,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IShellLinkDual
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x00,
                0x5C,
                0xA0,
                0x88,
                0x00,
                0xF0,
                0xCE,
                0x11,
                0x83,
                0x50,
                0x44,
                0x45,
                0x53,
                0x54,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IShellLinkDual2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x49,
                0xE2,
                0x7E,
                0x31,
                0x2E,
                0xF1,
                0xD2,
                0x11,
                0xB1,
                0xE4,
                0x00,
                0xC0,
                0x4F,
                0x8E,
                0xEB,
                0x3E,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ShellLinkObject
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x20,
                0x94,
                0x21,
                0x11,
                0x68,
                0x17,
                0xD1,
                0x11,
                0x95,
                0xBE,
                0x00,
                0x60,
                0x97,
                0x97,
                0xEA,
                0x4F,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IShellFolderViewDual
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x80,
                0xAF,
                0xA1,
                0xE7,
                0x96,
                0x4D,
                0xCF,
                0x11,
                0x96,
                0x0C,
                0x00,
                0x80,
                0xC7,
                0xF4,
                0xEE,
                0x85,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IShellFolderViewDual2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB6,
                0x47,
                0xC1,
                0x31,
                0xDE,
                0x0A,
                0x3C,
                0x4A,
                0xB5,
                0x14,
                0xDD,
                0xF9,
                0x32,
                0xEF,
                0x6D,
                0x17,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IShellFolderViewDual3
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x6C,
                0x8E,
                0xEC,
                0x29,
                0xD3,
                0x46,
                0x1F,
                0x41,
                0xBA,
                0xAA,
                0x61,
                0x1A,
                0x6C,
                0x9C,
                0xAC,
                0x66,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ShellFolderView
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA1,
                0x2A,
                0x11,
                0x62,
                0xE4,
                0xEB,
                0xCF,
                0x11,
                0xA5,
                0xFB,
                0x00,
                0x20,
                0xAF,
                0xE7,
                0x29,
                0x2D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IShellDispatch
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC0,
                0x15,
                0xF0,
                0xD8,
                0x78,
                0xC2,
                0xCE,
                0x11,
                0xA4,
                0x9E,
                0x44,
                0x45,
                0x53,
                0x54,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IShellDispatch2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x2C,
                0x89,
                0xC6,
                0xA4,
                0xA9,
                0x3B,
                0xD2,
                0x11,
                0x9D,
                0xEA,
                0x00,
                0xC0,
                0x4F,
                0xB1,
                0x61,
                0x62,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IShellDispatch3
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xCA,
                0x60,
                0x71,
                0x17,
                0x5A,
                0xBB,
                0x1C,
                0x41,
                0x84,
                0x1D,
                0xBD,
                0x38,
                0xFA,
                0xCD,
                0xEA,
                0xA0,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IShellDispatch4
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x2D,
                0x4B,
                0xD8,
                0xEF,
                0xCF,
                0x4B,
                0x98,
                0x42,
                0xBE,
                0x25,
                0xEB,
                0x54,
                0x2A,
                0x59,
                0xFB,
                0xDA,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IShellDispatch5
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB9,
                0x38,
                0x67,
                0x86,
                0xF2,
                0x6C,
                0xE8,
                0x4D,
                0x87,
                0x67,
                0xF7,
                0x94,
                0xEB,
                0xE7,
                0x4F,
                0x4E,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IShellDispatch6
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x1B,
                0x6F,
                0x6E,
                0x28,
                0x13,
                0x71,
                0x55,
                0x43,
                0x95,
                0x62,
                0x96,
                0xB7,
                0xE9,
                0xD6,
                0x4C,
                0x54,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_Shell
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x20,
                0x96,
                0x70,
                0x13,
                0x79,
                0xC2,
                0xCE,
                0x11,
                0xA4,
                0x9E,
                0x44,
                0x45,
                0x53,
                0x54,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ShellDispatchInproc
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x60,
                0xA8,
                0x89,
                0x0A,
                0xB1,
                0xD7,
                0xCE,
                0x11,
                0x83,
                0x50,
                0x44,
                0x45,
                0x53,
                0x54,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IFileSearchBand
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA1,
                0xEE,
                0x91,
                0x2D,
                0x32,
                0x99,
                0xD2,
                0x11,
                0xBE,
                0x86,
                0x00,
                0xA0,
                0xC9,
                0xA8,
                0x3D,
                0xA1,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_FileSearchBand
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF3,
                0x31,
                0xEE,
                0xC4,
                0x68,
                0x47,
                0xD2,
                0x11,
                0xBE,
                0x5C,
                0x00,
                0xA0,
                0xC9,
                0xA8,
                0x3D,
                0xA1,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IWebWizardHost
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x59,
                0xC3,
                0xBC,
                0x18,
                0x90,
                0x49,
                0xFB,
                0x4B,
                0xB9,
                0x51,
                0x3C,
                0x83,
                0x70,
                0x2B,
                0xE5,
                0xF9,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IWebWizardHost2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xDC,
                0x13,
                0xC0,
                0xF9,
                0x23,
                0x3C,
                0x41,
                0x40,
                0x8E,
                0x39,
                0xCF,
                0xB4,
                0x02,
                0xF7,
                0xEA,
                0x59,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_INewWDEvents
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x51,
                0xC5,
                0x51,
                0x07,
                0x68,
                0x75,
                0xC9,
                0x41,
                0x8E,
                0x5B,
                0xE2,
                0x2E,
                0x38,
                0x91,
                0x92,
                0x36,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAutoComplete
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x62,
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
    public static ref readonly Guid IID_IAutoComplete2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC0,
                0x4B,
                0xC0,
                0xEA,
                0x91,
                0x37,
                0xD2,
                0x11,
                0xBB,
                0x95,
                0x00,
                0x60,
                0x97,
                0x7B,
                0x46,
                0x4C,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IEnumACString
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x10,
                0xC2,
                0x74,
                0x8E,
                0x9D,
                0xCF,
                0xAF,
                0x4E,
                0xA4,
                0x03,
                0x73,
                0x56,
                0x42,
                0x8F,
                0x0A,
                0x5A,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDataObjectAsyncCapability
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x90,
                0x05,
                0x8B,
                0x3D,
                0x91,
                0xF6,
                0xD2,
                0x11,
                0x8E,
                0xA9,
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
}
