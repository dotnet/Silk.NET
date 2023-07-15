// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/DocObj.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;
public static partial class IID
{
    [NativeTypeName("#define IID_IMsoDocument IID_IOleDocument")]
    public static ref readonly Guid IID_IMsoDocument => ref IID_IOleDocument;

    [NativeTypeName("#define IID_IMsoDocumentSite IID_IOleDocumentSite")]
    public static ref readonly Guid IID_IMsoDocumentSite => ref IID_IOleDocumentSite;

    [NativeTypeName("#define IID_IMsoView IID_IOleDocumentView")]
    public static ref readonly Guid IID_IMsoView => ref IID_IOleDocumentView;

    [NativeTypeName("#define IID_IEnumMsoView IID_IEnumOleDocumentViews")]
    public static ref readonly Guid IID_IEnumMsoView => ref IID_IEnumOleDocumentViews;

    [NativeTypeName("#define IID_IMsoCommandTarget IID_IOleCommandTarget")]
    public static ref readonly Guid IID_IMsoCommandTarget => ref IID_IOleCommandTarget;

    public static ref readonly Guid IID_IOleDocument
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xC5,
                0xBC,
                0x22,
                0xB7,
                0x68,
                0x4E,
                0x1B,
                0x10,
                0xA2,
                0xBC,
                0x00,
                0xAA,
                0x00,
                0x40,
                0x47,
                0x70
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IOleDocumentSite
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xC7,
                0xBC,
                0x22,
                0xB7,
                0x68,
                0x4E,
                0x1B,
                0x10,
                0xA2,
                0xBC,
                0x00,
                0xAA,
                0x00,
                0x40,
                0x47,
                0x70
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IOleDocumentView
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xC6,
                0xBC,
                0x22,
                0xB7,
                0x68,
                0x4E,
                0x1B,
                0x10,
                0xA2,
                0xBC,
                0x00,
                0xAA,
                0x00,
                0x40,
                0x47,
                0x70
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IEnumOleDocumentViews
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xC8,
                0xBC,
                0x22,
                0xB7,
                0x68,
                0x4E,
                0x1B,
                0x10,
                0xA2,
                0xBC,
                0x00,
                0xAA,
                0x00,
                0x40,
                0x47,
                0x70
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IContinueCallback
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xCA,
                0xBC,
                0x22,
                0xB7,
                0x68,
                0x4E,
                0x1B,
                0x10,
                0xA2,
                0xBC,
                0x00,
                0xAA,
                0x00,
                0x40,
                0x47,
                0x70
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IPrint
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xC9,
                0xBC,
                0x22,
                0xB7,
                0x68,
                0x4E,
                0x1B,
                0x10,
                0xA2,
                0xBC,
                0x00,
                0xAA,
                0x00,
                0x40,
                0x47,
                0x70
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IOleCommandTarget
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xCB,
                0xBC,
                0x22,
                0xB7,
                0x68,
                0x4E,
                0x1B,
                0x10,
                0xA2,
                0xBC,
                0x00,
                0xAA,
                0x00,
                0x40,
                0x47,
                0x70
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IZoomEvents
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x50,
                0x81,
                0xB6,
                0x41,
                0x4C,
                0x90,
                0x17,
                0x4E,
                0xA0,
                0xBA,
                0xA4,
                0x38,
                0x18,
                0x2E,
                0x35,
                0x9D
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IProtectFocus
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xA3,
                0x90,
                0x1F,
                0xD8,
                0x56,
                0x81,
                0xF7,
                0x44,
                0xAD,
                0x28,
                0x5A,
                0xBB,
                0x87,
                0x00,
                0x32,
                0x74
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IProtectedModeMenuServices
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xEE,
                0x05,
                0xC1,
                0x73,
                0xFF,
                0x9D,
                0x07,
                0x4A,
                0xB8,
                0x3C,
                0x7E,
                0xFF,
                0x29,
                0x0C,
                0x26,
                0x6E
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}