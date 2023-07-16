// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/imapi2fs.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;
public static partial class CLSID
{
    public static ref readonly Guid CLSID_BootOptions
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xCE,
                0x1F,
                0x94,
                0x2C,
                0x5B,
                0x97,
                0xBE,
                0x59,
                0xA9,
                0x60,
                0x9A,
                0x2A,
                0x26,
                0x28,
                0x53,
                0xA5
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_FsiStream
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xCD,
                0x1F,
                0x94,
                0x2C,
                0x5B,
                0x97,
                0xBE,
                0x59,
                0xA9,
                0x60,
                0x9A,
                0x2A,
                0x26,
                0x28,
                0x53,
                0xA5
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_FileSystemImageResult
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xCC,
                0x1F,
                0x94,
                0x2C,
                0x5B,
                0x97,
                0xBE,
                0x59,
                0xA9,
                0x60,
                0x9A,
                0x2A,
                0x26,
                0x28,
                0x53,
                0xA5
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_ProgressItem
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xCB,
                0x1F,
                0x94,
                0x2C,
                0x5B,
                0x97,
                0xBE,
                0x59,
                0xA9,
                0x60,
                0x9A,
                0x2A,
                0x26,
                0x28,
                0x53,
                0xA5
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_EnumProgressItems
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xCA,
                0x1F,
                0x94,
                0x2C,
                0x5B,
                0x97,
                0xBE,
                0x59,
                0xA9,
                0x60,
                0x9A,
                0x2A,
                0x26,
                0x28,
                0x53,
                0xA5
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_ProgressItems
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xC9,
                0x1F,
                0x94,
                0x2C,
                0x5B,
                0x97,
                0xBE,
                0x59,
                0xA9,
                0x60,
                0x9A,
                0x2A,
                0x26,
                0x28,
                0x53,
                0xA5
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_FsiDirectoryItem
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xC8,
                0x1F,
                0x94,
                0x2C,
                0x5B,
                0x97,
                0xBE,
                0x59,
                0xA9,
                0x60,
                0x9A,
                0x2A,
                0x26,
                0x28,
                0x53,
                0xA5
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_FsiFileItem
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xC7,
                0x1F,
                0x94,
                0x2C,
                0x5B,
                0x97,
                0xBE,
                0x59,
                0xA9,
                0x60,
                0x9A,
                0x2A,
                0x26,
                0x28,
                0x53,
                0xA5
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_EnumFsiItems
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xC6,
                0x1F,
                0x94,
                0x2C,
                0x5B,
                0x97,
                0xBE,
                0x59,
                0xA9,
                0x60,
                0x9A,
                0x2A,
                0x26,
                0x28,
                0x53,
                0xA5
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_FsiNamedStreams
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xED,
                0xF8,
                0xB6,
                0xC6,
                0x19,
                0x6D,
                0xB4,
                0x44,
                0xB5,
                0x39,
                0xB1,
                0x59,
                0xB7,
                0x93,
                0xA3,
                0x2D
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_MsftFileSystemImage
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xC5,
                0x1F,
                0x94,
                0x2C,
                0x5B,
                0x97,
                0xBE,
                0x59,
                0xA9,
                0x60,
                0x9A,
                0x2A,
                0x26,
                0x28,
                0x53,
                0xA5
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_MsftIsoImageManager
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x62,
                0x3B,
                0xEE,
                0xCE,
                0x56,
                0x8F,
                0x56,
                0x40,
                0x86,
                0x9B,
                0xEF,
                0x16,
                0x91,
                0x7E,
                0x3E,
                0xFC
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_BlockRange
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x27,
                0xCA,
                0x07,
                0xB5,
                0x04,
                0x22,
                0xDD,
                0x11,
                0x96,
                0x6A,
                0x00,
                0x1A,
                0xA0,
                0x1B,
                0xBC,
                0x58
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_BlockRangeList
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x28,
                0xCA,
                0x07,
                0xB5,
                0x04,
                0x22,
                0xDD,
                0x11,
                0x96,
                0x6A,
                0x00,
                0x1A,
                0xA0,
                0x1B,
                0xBC,
                0x58
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}