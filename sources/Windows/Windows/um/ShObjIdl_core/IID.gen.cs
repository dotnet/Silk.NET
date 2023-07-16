// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;
public static partial class IID
{
    public static ref readonly Guid IID_IExecuteCommand
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xB0,
                0x85,
                0x91,
                0x7F,
                0x92,
                0xCB,
                0xC5,
                0x43,
                0x80,
                0xA9,
                0x92,
                0x27,
                0x7A,
                0x4F,
                0x7B,
                0x54
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IRunnableTask
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x00,
                0x8D,
                0x78,
                0x85,
                0x07,
                0x68,
                0xD0,
                0x11,
                0xB8,
                0x10,
                0x00,
                0xC0,
                0x4F,
                0xD7,
                0x06,
                0xEC
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IShellTaskScheduler
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xE0,
                0x7B,
                0xCB,
                0x6C,
                0x07,
                0x68,
                0xD0,
                0x11,
                0xB8,
                0x10,
                0x00,
                0xC0,
                0x4F,
                0xD7,
                0x06,
                0xEC
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IPersistFolder2
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xF0,
                0xD9,
                0xC3,
                0x1A,
                0x5C,
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
                0x4F
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IPersistFolder3
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xDF,
                0x4F,
                0xF0,
                0xCE,
                0x72,
                0xFE,
                0xD2,
                0x11,
                0x87,
                0xA5,
                0x00,
                0xC0,
                0x4F,
                0x68,
                0x37,
                0xCF
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IPersistIDList
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xFC,
                0xAC,
                0x79,
                0x10,
                0xBD,
                0x29,
                0xD3,
                0x11,
                0x8E,
                0x0D,
                0x00,
                0xC0,
                0x4F,
                0x68,
                0x37,
                0xD5
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IEnumFullIDList
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x42,
                0x15,
                0x19,
                0xD0,
                0x54,
                0x79,
                0x08,
                0x49,
                0xBC,
                0x06,
                0xB2,
                0x36,
                0x0B,
                0xBE,
                0x45,
                0xBA
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IFileSyncMergeHandler
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xAC,
                0x5A,
                0x7B,
                0xD9,
                0x92,
                0xC7,
                0x3C,
                0x43,
                0x97,
                0x5D,
                0x35,
                0xC4,
                0xEA,
                0xDC,
                0x7A,
                0x9D
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IObjectWithFolderEnumMode
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x26,
                0x90,
                0x9D,
                0x6A,
                0x6E,
                0x0E,
                0x4C,
                0x46,
                0xB0,
                0x00,
                0x42,
                0xEC,
                0xC0,
                0x7D,
                0xE6,
                0x73
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IParseAndCreateItem
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x0E,
                0xED,
                0xEF,
                0x67,
                0x27,
                0xE8,
                0x08,
                0x44,
                0xB4,
                0x93,
                0x78,
                0xF3,
                0x98,
                0x2B,
                0x68,
                0x5C
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IFolderView
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xB0,
                0x25,
                0xE7,
                0xCD,
                0xC9,
                0xCC,
                0x19,
                0x45,
                0x91,
                0x7E,
                0x32,
                0x5D,
                0x72,
                0xFA,
                0xB4,
                0xCE
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IFolderView2
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x67,
                0xA4,
                0xF3,
                0x1A,
                0x4F,
                0x21,
                0x98,
                0x42,
                0x90,
                0x8E,
                0x06,
                0xB0,
                0x3E,
                0x0B,
                0x39,
                0xF9
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IFolderViewSettings
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x7D,
                0x98,
                0x8C,
                0xAE,
                0x97,
                0x87,
                0xD3,
                0x4E,
                0xBE,
                0x72,
                0x2A,
                0x47,
                0xDD,
                0x93,
                0x8D,
                0xB0
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IInitializeNetworkFolder
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x81,
                0x98,
                0x0F,
                0x6E,
                0xA8,
                0x42,
                0x2A,
                0x4F,
                0x97,
                0xF8,
                0x8A,
                0xF4,
                0xE0,
                0x26,
                0xD9,
                0x2D
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_INetworkFolderInternal
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x18,
                0x82,
                0xB3,
                0xCE,
                0x71,
                0xC9,
                0xBB,
                0x47,
                0xA7,
                0x03,
                0xF0,
                0xBC,
                0x99,
                0xCC,
                0xDB,
                0x81
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IPreviewHandlerVisuals
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xA5,
                0xF9,
                0x6B,
                0x19,
                0x46,
                0xB3,
                0xF0,
                0x4E,
                0xAA,
                0x1E,
                0x5D,
                0xCD,
                0xB7,
                0x67,
                0x68,
                0xB1
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IColumnManager
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xBB,
                0x27,
                0xEC,
                0xD8,
                0x3B,
                0x3F,
                0x42,
                0x40,
                0xB1,
                0x0A,
                0x4A,
                0xCF,
                0xD9,
                0x24,
                0xD4,
                0x53
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IFolderFilterSite
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xF5,
                0x51,
                0xA6,
                0xC0,
                0x8B,
                0xB4,
                0xD2,
                0x11,
                0xB5,
                0xED,
                0x00,
                0x60,
                0x97,
                0xC6,
                0x86,
                0xF6
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IFolderFilter
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x86,
                0x28,
                0xC2,
                0x9C,
                0x8E,
                0xDC,
                0xD2,
                0x11,
                0xB1,
                0xD0,
                0x00,
                0xC0,
                0x4F,
                0x8E,
                0xEB,
                0x3E
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IInputObjectSite
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x92,
                0x83,
                0xDB,
                0xF1,
                0x31,
                0x73,
                0xD0,
                0x11,
                0x8C,
                0x99,
                0x00,
                0xA0,
                0xC9,
                0x2D,
                0xBF,
                0xE8
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IInputObject
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xAA,
                0x4F,
                0x28,
                0x68,
                0x48,
                0x6A,
                0xD0,
                0x11,
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

    public static ref readonly Guid IID_IInputObject2
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x85,
                0xC0,
                0x15,
                0x69,
                0x0B,
                0x51,
                0xCD,
                0x44,
                0x94,
                0xAF,
                0x28,
                0xDF,
                0xA5,
                0x6C,
                0xF9,
                0x2B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IProfferService
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x20,
                0x8B,
                0x72,
                0xCB,
                0x86,
                0xF7,
                0xCE,
                0x11,
                0x92,
                0xAD,
                0x00,
                0xAA,
                0x00,
                0xA7,
                0x4C,
                0xD0
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IGetServiceIds
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x26,
                0x35,
                0x07,
                0x4A,
                0x03,
                0x61,
                0x21,
                0x4E,
                0xB7,
                0xBC,
                0xF5,
                0x19,
                0xD1,
                0x52,
                0x4E,
                0x5D
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IShellItem
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x1E,
                0x6D,
                0x82,
                0x43,
                0x18,
                0xE7,
                0xEE,
                0x42,
                0xBC,
                0x55,
                0xA1,
                0xE2,
                0x61,
                0xC3,
                0x7B,
                0xFE
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IShellItem2
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xD3,
                0xB0,
                0x9F,
                0x7E,
                0x9F,
                0x91,
                0x07,
                0x43,
                0xAB,
                0x2E,
                0x9B,
                0x18,
                0x60,
                0x31,
                0x0C,
                0x93
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IShellItemImageFactory
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x79,
                0x8B,
                0xC1,
                0xBC,
                0x16,
                0xBA,
                0x2F,
                0x44,
                0x80,
                0xC4,
                0x8A,
                0x59,
                0xC3,
                0x0C,
                0x46,
                0x3B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IEnumShellItems
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x33,
                0x90,
                0x62,
                0x70,
                0x63,
                0xE3,
                0x28,
                0x4A,
                0xA5,
                0x67,
                0x0D,
                0xB7,
                0x80,
                0x06,
                0xE6,
                0xD7
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ITransferAdviseSink
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xD8,
                0xD0,
                0x94,
                0xD5,
                0xA7,
                0x8D,
                0x7B,
                0x45,
                0xB3,
                0xB4,
                0xCE,
                0x5D,
                0xBA,
                0xAC,
                0x0B,
                0x88
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ITransferSource
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x03,
                0xB0,
                0xAD,
                0x00,
                0xE9,
                0xBD,
                0xC6,
                0x45,
                0x8E,
                0x29,
                0xD0,
                0x9F,
                0x93,
                0x53,
                0xE1,
                0x08
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IEnumResources
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xE3,
                0x1F,
                0xD8,
                0x2D,
                0x3C,
                0xA8,
                0xA9,
                0x4D,
                0xA3,
                0x30,
                0x47,
                0x24,
                0x9D,
                0x34,
                0x5B,
                0xA1
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IShellItemResources
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xBE,
                0x93,
                0x56,
                0xFF,
                0xE0,
                0x2C,
                0x48,
                0x4D,
                0xB5,
                0xC5,
                0x40,
                0x81,
                0x7D,
                0x1A,
                0xCD,
                0xB9
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ITransferDestination
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x32,
                0xDD,
                0xAD,
                0x48,
                0xA5,
                0x3C,
                0x24,
                0x41,
                0xAB,
                0xE3,
                0xB5,
                0xA7,
                0x25,
                0x31,
                0xB2,
                0x07
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IFileOperationProgressSink
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xA7,
                0xF1,
                0xB0,
                0x04,
                0x90,
                0x94,
                0xBC,
                0x44,
                0x96,
                0xE1,
                0x42,
                0x96,
                0xA3,
                0x12,
                0x52,
                0xE2
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IShellItemArray
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x6D,
                0xA7,
                0x3E,
                0xB6,
                0x85,
                0x1F,
                0x6F,
                0x45,
                0xA1,
                0x9C,
                0x48,
                0x15,
                0x9E,
                0xFA,
                0x85,
                0x8B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IInitializeWithItem
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x3F,
                0xBE,
                0x73,
                0x7F,
                0x79,
                0xFB,
                0x3C,
                0x49,
                0xA6,
                0xC7,
                0x7E,
                0xE1,
                0x4E,
                0x24,
                0x58,
                0x41
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IObjectWithSelection
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xBB,
                0xD5,
                0x9C,
                0x1C,
                0xE9,
                0x98,
                0x91,
                0x44,
                0xA6,
                0x0F,
                0x31,
                0xAA,
                0xCC,
                0x72,
                0xB8,
                0x3C
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IObjectWithBackReferences
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x6A,
                0x6A,
                0x1A,
                0x32,
                0x1F,
                0xD6,
                0xF3,
                0x4B,
                0x97,
                0xAE,
                0x14,
                0xBE,
                0x29,
                0x86,
                0xBB,
                0x36
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IPropertyUI
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x9F,
                0x7D,
                0x7A,
                0x75,
                0x9A,
                0x91,
                0x18,
                0x41,
                0x99,
                0xD7,
                0xDB,
                0xB2,
                0x08,
                0xC8,
                0xCC,
                0x66
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ICategoryProvider
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x09,
                0x48,
                0xF6,
                0x9A,
                0x64,
                0x58,
                0x26,
                0x4C,
                0xA7,
                0x20,
                0xC1,
                0xF7,
                0x8C,
                0x08,
                0x6E,
                0xE3
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ICategorizer
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x89,
                0x45,
                0xB1,
                0xA3,
                0x74,
                0x91,
                0xA8,
                0x49,
                0x89,
                0xA3,
                0x06,
                0xA1,
                0xAE,
                0x2B,
                0x9B,
                0xA7
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IDropTargetHelper
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x8B,
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
                0xD0
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IDragSourceHelper
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x86,
                0xF7,
                0x5B,
                0xDE,
                0x7A,
                0x47,
                0xD2,
                0x11,
                0x83,
                0x9D,
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

    public static ref readonly Guid IID_IShellLinkDataList
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xAE,
                0xB4,
                0xE2,
                0x45,
                0xC3,
                0xB1,
                0xD0,
                0x11,
                0xB9,
                0x2F,
                0x00,
                0xA0,
                0xC9,
                0x03,
                0x12,
                0xE1
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IResolveShellLink
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x83,
                0x29,
                0xD5,
                0x5C,
                0x49,
                0x94,
                0xD2,
                0x11,
                0x96,
                0x3A,
                0x00,
                0xC0,
                0x4F,
                0x79,
                0xAD,
                0xF0
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IActionProgressDialog
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x72,
                0x11,
                0xFF,
                0x49,
                0xDC,
                0xEA,
                0x6D,
                0x44,
                0x92,
                0x85,
                0x15,
                0x64,
                0x53,
                0xA6,
                0x43,
                0x1C
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IActionProgress
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x73,
                0x11,
                0xFF,
                0x49,
                0xDC,
                0xEA,
                0x6D,
                0x44,
                0x92,
                0x85,
                0x15,
                0x64,
                0x53,
                0xA6,
                0x43,
                0x1C
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IQueryContinue
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x5C,
                0x05,
                0x07,
                0x73,
                0x4A,
                0xB2,
                0x6B,
                0x48,
                0x9F,
                0x25,
                0x16,
                0x3E,
                0x59,
                0x7A,
                0x28,
                0xA9
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IObjectWithCancelEvent
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x85,
                0xB8,
                0x79,
                0xF2,
                0xE9,
                0x0A,
                0x85,
                0x4B,
                0xAC,
                0x06,
                0xDD,
                0xEC,
                0xF9,
                0x40,
                0x89,
                0x41
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IUserNotification
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xBA,
                0x11,
                0x97,
                0xBA,
                0x93,
                0x58,
                0x87,
                0x47,
                0xA7,
                0xE1,
                0x41,
                0x27,
                0x71,
                0x51,
                0x55,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IItemNameLimits
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xF1,
                0xD7,
                0xF0,
                0x1D,
                0x67,
                0xB2,
                0x28,
                0x4D,
                0x8B,
                0x10,
                0x12,
                0xE2,
                0x32,
                0x02,
                0xA5,
                0xC4
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISearchFolderItemFactory
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x28,
                0xBC,
                0xFF,
                0xA0,
                0x82,
                0x54,
                0x66,
                0x43,
                0xBE,
                0x27,
                0x3E,
                0x81,
                0xE7,
                0x8E,
                0x06,
                0xC2
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IExtractImage
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x7C,
                0x61,
                0x2E,
                0xBB,
                0x20,
                0x09,
                0xD1,
                0x11,
                0x9A,
                0x0B,
                0x00,
                0xC0,
                0x4F,
                0xC2,
                0xD6,
                0xC1
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IExtractImage2
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xEE,
                0xB1,
                0x3B,
                0x95,
                0xB4,
                0x93,
                0xD1,
                0x11,
                0x98,
                0xA3,
                0x00,
                0xC0,
                0x4F,
                0xB6,
                0x87,
                0xDA
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IThumbnailHandlerFactory
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x2E,
                0x4B,
                0x5B,
                0xE3,
                0xDA,
                0x00,
                0xC1,
                0x4B,
                0x9F,
                0x13,
                0x38,
                0xBC,
                0x11,
                0xF5,
                0xD4,
                0x17
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IParentAndItem
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x85,
                0xB6,
                0xA4,
                0xB3,
                0x85,
                0xB6,
                0x05,
                0x48,
                0x99,
                0xD9,
                0x5D,
                0xEA,
                0xD2,
                0x87,
                0x32,
                0x36
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IDockingWindow
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x20,
                0xD9,
                0x2D,
                0x01,
                0x26,
                0x7B,
                0xD0,
                0x11,
                0x8C,
                0xA9,
                0x00,
                0xA0,
                0xC9,
                0x2D,
                0xBF,
                0xE8
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IDeskBand
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x72,
                0xE1,
                0x0F,
                0xEB,
                0x3A,
                0x1A,
                0xD0,
                0x11,
                0x89,
                0xB3,
                0x00,
                0xA0,
                0xC9,
                0x0A,
                0x90,
                0xAC
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IDeskBandInfo
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xFC,
                0x25,
                0xE4,
                0x77,
                0xF9,
                0xCB,
                0x07,
                0x43,
                0xBA,
                0x6A,
                0xBB,
                0x57,
                0x27,
                0x74,
                0x56,
                0x61
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ITaskbarList
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x42,
                0xF3,
                0xFD,
                0x56,
                0x6D,
                0xFD,
                0xD0,
                0x11,
                0x95,
                0x8A,
                0x00,
                0x60,
                0x97,
                0xC9,
                0xA0,
                0x90
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ITaskbarList2
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x95,
                0x49,
                0x2D,
                0x60,
                0x3A,
                0xB1,
                0x9B,
                0x42,
                0xA6,
                0x6E,
                0x19,
                0x35,
                0xE4,
                0x4F,
                0x43,
                0x17
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ITaskbarList3
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x91,
                0xFB,
                0x1A,
                0xEA,
                0x28,
                0x9E,
                0x86,
                0x4B,
                0x90,
                0xE9,
                0x9E,
                0x9F,
                0x8A,
                0x5E,
                0xEF,
                0xAF
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ITaskbarList4
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x98,
                0xC7,
                0x3D,
                0xC4,
                0xD1,
                0x95,
                0xEA,
                0x4B,
                0x90,
                0x30,
                0xBB,
                0x99,
                0xE2,
                0x98,
                0x3A,
                0x1A
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IExplorerBrowserEvents
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xC7,
                0xBD,
                0x1B,
                0x36,
                0xEE,
                0xE6,
                0x13,
                0x4E,
                0xBE,
                0x58,
                0x58,
                0xE2,
                0x24,
                0x0C,
                0x81,
                0x0F
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IExplorerBrowser
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xB5,
                0xB6,
                0xD3,
                0xDF,
                0x0C,
                0xC1,
                0xE9,
                0x4B,
                0x85,
                0xF6,
                0xA6,
                0x69,
                0x69,
                0xF4,
                0x02,
                0xF6
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IEnumObjects
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x2E,
                0x7E,
                0x1C,
                0x2C,
                0x0E,
                0x2D,
                0x59,
                0x40,
                0x83,
                0x1E,
                0x1E,
                0x6F,
                0x82,
                0x33,
                0x5C,
                0x2E
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IOperationsProgressDialog
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x51,
                0xB8,
                0x9F,
                0x0C,
                0xC9,
                0xE5,
                0xEB,
                0x43,
                0xA3,
                0x70,
                0xF0,
                0x67,
                0x7B,
                0x13,
                0x87,
                0x4C
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IIOCancelInformation
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x81,
                0xBF,
                0xB0,
                0xF5,
                0xB5,
                0x8C,
                0x1B,
                0x4B,
                0x94,
                0x49,
                0x1A,
                0x15,
                0x9E,
                0x0C,
                0x73,
                0x3C
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IFileOperation
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x5F,
                0xAB,
                0x7A,
                0x94,
                0x5C,
                0x0A,
                0x13,
                0x4C,
                0xB4,
                0xD6,
                0x4B,
                0xF7,
                0x83,
                0x6F,
                0xC9,
                0xF8
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IFileOperation2
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xC1,
                0x23,
                0x8F,
                0xCD,
                0x61,
                0x8F,
                0x16,
                0x49,
                0x90,
                0x9D,
                0x55,
                0xBD,
                0xD0,
                0x91,
                0x87,
                0x53
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IObjectProvider
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x28,
                0x74,
                0x08,
                0xA6,
                0xE3,
                0x3B,
                0x73,
                0x4D,
                0xB3,
                0x08,
                0x7C,
                0x04,
                0xA5,
                0x40,
                0xBF,
                0x1A
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_INamespaceWalkCB
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xF8,
                0x95,
                0x29,
                0xD9,
                0x5E,
                0xCF,
                0x76,
                0x4A,
                0xBF,
                0x59,
                0xEA,
                0xD3,
                0x9E,
                0xA2,
                0xB9,
                0x7E
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_INamespaceWalkCB2
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x2B,
                0x49,
                0xC7,
                0x7A,
                0x8E,
                0xC3,
                0x8A,
                0x43,
                0x87,
                0xDB,
                0x68,
                0x73,
                0x78,
                0x44,
                0xFF,
                0x70
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_INamespaceWalk
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xA7,
                0xD8,
                0xCE,
                0x57,
                0x4A,
                0x3F,
                0x2C,
                0x43,
                0x93,
                0x50,
                0x30,
                0xF2,
                0x44,
                0x83,
                0xF7,
                0x4F
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IBandSite
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xB0,
                0x04,
                0xF5,
                0x4C,
                0x96,
                0xDE,
                0xD0,
                0x11,
                0x8B,
                0x3F,
                0x00,
                0xA0,
                0xC9,
                0x11,
                0xE8,
                0xE5
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IModalWindow
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x57,
                0x16,
                0xDB,
                0xB4,
                0xD7,
                0x70,
                0x5E,
                0x48,
                0x8E,
                0x3E,
                0x6F,
                0xCB,
                0x5A,
                0x5C,
                0x18,
                0x02
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IContextMenuSite
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xBE,
                0xAE,
                0x11,
                0x08,
                0x87,
                0x0B,
                0x54,
                0x4C,
                0x9E,
                0x72,
                0x54,
                0x8C,
                0xF6,
                0x49,
                0x01,
                0x6B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMenuBand
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xCD,
                0x04,
                0x88,
                0x56,
                0xD7,
                0xCB,
                0xD0,
                0x11,
                0x98,
                0x16,
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

    public static ref readonly Guid IID_IRegTreeItem
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x22,
                0x19,
                0x52,
                0xA9,
                0x12,
                0x08,
                0x44,
                0x4D,
                0x9E,
                0xC3,
                0x7F,
                0xD3,
                0x8C,
                0x72,
                0x6F,
                0x3D
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IDeskBar
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x73,
                0xE1,
                0x0F,
                0xEB,
                0x3A,
                0x1A,
                0xD0,
                0x11,
                0x89,
                0xB3,
                0x00,
                0xA0,
                0xC9,
                0x0A,
                0x90,
                0xAC
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMenuPopup
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xEB,
                0xAF,
                0xE7,
                0xD1,
                0x2E,
                0x6A,
                0xD0,
                0x11,
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

    public static ref readonly Guid IID_IFileIsInUse
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xF0,
                0xCB,
                0xA1,
                0x64,
                0x1A,
                0x3A,
                0x61,
                0x44,
                0x91,
                0x58,
                0x37,
                0x69,
                0x69,
                0x69,
                0x39,
                0x50
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IFileDialogEvents
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xDB,
                0x10,
                0x35,
                0x97,
                0x7F,
                0x7D,
                0x2B,
                0x45,
                0x89,
                0x75,
                0x74,
                0xA8,
                0x58,
                0x28,
                0xD3,
                0x54
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IFileDialog
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x36,
                0x51,
                0xF8,
                0x42,
                0x7E,
                0xDB,
                0x9C,
                0x43,
                0x85,
                0xF1,
                0xE4,
                0x07,
                0x5D,
                0x13,
                0x5F,
                0xC8
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IFileSaveDialog
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x23,
                0xCD,
                0xBC,
                0x84,
                0xDE,
                0x5F,
                0xDB,
                0x4C,
                0xAE,
                0xA4,
                0xAF,
                0x64,
                0xB8,
                0x3D,
                0x78,
                0xAB
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IFileOpenDialog
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x88,
                0x72,
                0x7C,
                0xD5,
                0xAD,
                0xD4,
                0x68,
                0x47,
                0xBE,
                0x02,
                0x9D,
                0x96,
                0x95,
                0x32,
                0xD9,
                0x60
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IFileDialogCustomize
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x1A,
                0xD2,
                0xFD,
                0xE6,
                0x3F,
                0x16,
                0x75,
                0x49,
                0x9C,
                0x8C,
                0xA6,
                0x9F,
                0x1B,
                0xA3,
                0x70,
                0x34
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IApplicationAssociationRegistration
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x0A,
                0x0B,
                0x53,
                0x4E,
                0x11,
                0xE6,
                0x77,
                0x4C,
                0xA3,
                0xAC,
                0x90,
                0x31,
                0xD0,
                0x22,
                0x28,
                0x1B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IDelegateFolder
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x80,
                0xBA,
                0xD8,
                0xAD,
                0x2B,
                0x00,
                0xD0,
                0x11,
                0x8F,
                0x0F,
                0x00,
                0xC0,
                0x4F,
                0xD7,
                0xD0,
                0x62
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IBrowserFrameOptions
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xC8,
                0x43,
                0xDF,
                0x10,
                0xBE,
                0x1D,
                0xD3,
                0x11,
                0x8B,
                0x34,
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

    public static ref readonly Guid IID_INewWindowManager
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x84,
                0x4C,
                0xBC,
                0xD2,
                0x72,
                0x3F,
                0x52,
                0x4A,
                0xA6,
                0x04,
                0x7B,
                0xCB,
                0xF3,
                0x98,
                0x2C,
                0xBB
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IAttachmentExecute
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x41,
                0x12,
                0xDB,
                0x73,
                0x85,
                0x1E,
                0x81,
                0x45,
                0x8E,
                0x4F,
                0xA8,
                0x1E,
                0x1D,
                0x0F,
                0x8C,
                0x57
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IShellMenuCallback
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xA1,
                0x00,
                0xA3,
                0x4C,
                0x8D,
                0x9B,
                0xD1,
                0x11,
                0x8B,
                0x22,
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

    public static ref readonly Guid IID_IShellMenu
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x37,
                0x76,
                0x1F,
                0xEE,
                0x38,
                0xE1,
                0xD1,
                0x11,
                0x83,
                0x79,
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

    public static ref readonly Guid IID_IKnownFolder
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x7E,
                0xAF,
                0xA7,
                0x3A,
                0x36,
                0x9B,
                0x0C,
                0x42,
                0xA8,
                0xE3,
                0xF7,
                0x7D,
                0x46,
                0x74,
                0xA4,
                0x88
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IKnownFolderManager
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x72,
                0xD8,
                0xE2,
                0x8B,
                0xAA,
                0x86,
                0x47,
                0x4D,
                0xB7,
                0x76,
                0x32,
                0xCC,
                0xA4,
                0x0C,
                0x70,
                0x18
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISharingConfigurationManager
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x8A,
                0x44,
                0xCD,
                0xB4,
                0x86,
                0x9C,
                0x66,
                0x44,
                0x92,
                0x01,
                0x2E,
                0x62,
                0x10,
                0x5B,
                0x87,
                0xAE
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IRelatedItem
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x7A,
                0xE6,
                0x3C,
                0xA7,
                0xB1,
                0x8A,
                0xF1,
                0x44,
                0x8D,
                0x43,
                0xD2,
                0xFC,
                0xBF,
                0x6B,
                0x1C,
                0xD0
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IIdentityName
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xCA,
                0x3F,
                0x90,
                0x7D,
                0xF9,
                0xD6,
                0x10,
                0x48,
                0x83,
                0x32,
                0x94,
                0x6C,
                0x01,
                0x77,
                0xE2,
                0x47
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IDelegateItem
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x94,
                0x1C,
                0x5A,
                0x3C,
                0x51,
                0xC9,
                0xB7,
                0x4C,
                0xBB,
                0x6D,
                0x3B,
                0x93,
                0xF3,
                0x0C,
                0xCE,
                0x93
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ICurrentItem
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x74,
                0x71,
                0x0A,
                0x24,
                0x53,
                0xD6,
                0x1D,
                0x4A,
                0xA6,
                0xD3,
                0xD4,
                0x94,
                0x3C,
                0xFB,
                0xFE,
                0x3D
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ITransferMediumItem
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xD5,
                0x95,
                0xF2,
                0x77,
                0x6F,
                0x2D,
                0x19,
                0x4E,
                0xB8,
                0xAE,
                0x32,
                0x2F,
                0x3E,
                0x72,
                0x1A,
                0xB5
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IDisplayItem
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x97,
                0x59,
                0xFD,
                0xC6,
                0x6B,
                0x9F,
                0x88,
                0x48,
                0x87,
                0x03,
                0x94,
                0xE8,
                0x0E,
                0x8C,
                0xDE,
                0x3F
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IViewStateIdentityItem
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x46,
                0x41,
                0x26,
                0x9D,
                0x4F,
                0xA9,
                0x95,
                0x41,
                0x9F,
                0x9F,
                0x3B,
                0xB1,
                0x2C,
                0xE0,
                0xC9,
                0x55
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IPreviewItem
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x69,
                0x99,
                0x14,
                0x36,
                0x8F,
                0x0A,
                0xC8,
                0x49,
                0x8B,
                0x00,
                0x4A,
                0xEC,
                0xB2,
                0x02,
                0x22,
                0xFB
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IDestinationStreamFactory
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x1B,
                0x78,
                0x87,
                0x8A,
                0xA7,
                0x39,
                0x1F,
                0x4A,
                0xAA,
                0xB3,
                0xA3,
                0x9B,
                0x9C,
                0x34,
                0xA7,
                0xD9
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ICreateProcessInputs
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x40,
                0x61,
                0xEF,
                0xF6,
                0x6F,
                0xE2,
                0x82,
                0x4D,
                0xBA,
                0xC4,
                0xE9,
                0xBA,
                0x5F,
                0xD2,
                0x39,
                0xA8
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ICreatingProcess
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xA9,
                0x37,
                0xB9,
                0xC2,
                0x10,
                0x31,
                0x98,
                0x43,
                0x8A,
                0x56,
                0xF3,
                0x4C,
                0x63,
                0x42,
                0xD2,
                0x44
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ILaunchUIContext
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xF6,
                0xE8,
                0x91,
                0x17,
                0xC7,
                0x21,
                0x40,
                0x43,
                0x88,
                0x2A,
                0xA6,
                0xA9,
                0x3E,
                0x3F,
                0xD7,
                0x3B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ILaunchUIContextProvider
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xC8,
                0xC4,
                0x12,
                0x0D,
                0xD9,
                0xA3,
                0x24,
                0x4E,
                0x94,
                0xC1,
                0x0E,
                0x20,
                0xC5,
                0xA9,
                0x56,
                0xC4
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_INewMenuClient
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xDC,
                0x7F,
                0xB0,
                0xDC,
                0xB5,
                0x3B,
                0x1C,
                0x45,
                0x90,
                0xBE,
                0x96,
                0x66,
                0x44,
                0xFE,
                0xD7,
                0xB0
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IInitializeWithBindCtx
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xBC,
                0xD2,
                0xC0,
                0x71,
                0x6D,
                0x72,
                0xCC,
                0x45,
                0xA6,
                0xC0,
                0x2E,
                0x31,
                0xC1,
                0xDB,
                0x21,
                0x59
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IShellItemFilter
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x75,
                0xB4,
                0x59,
                0x26,
                0xB8,
                0xEE,
                0xB7,
                0x48,
                0x8F,
                0x07,
                0xB3,
                0x78,
                0x81,
                0x0F,
                0x48,
                0xCF
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_INameSpaceTreeControl
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xA3,
                0x12,
                0x82,
                0x02,
                0x27,
                0xB6,
                0xE9,
                0x47,
                0x88,
                0x56,
                0xC1,
                0x42,
                0x65,
                0x55,
                0x4E,
                0x4F
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_INameSpaceTreeControlFolderCapabilities
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x83,
                0x11,
                0x70,
                0xE9,
                0xB3,
                0xE6,
                0xF2,
                0x4F,
                0x85,
                0x68,
                0x81,
                0x36,
                0x15,
                0xFE,
                0xC7,
                0xBE
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IPreviewHandler
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xC6,
                0xB1,
                0x95,
                0x88,
                0x1F,
                0xB4,
                0x1C,
                0x4C,
                0xA5,
                0x62,
                0x0D,
                0x56,
                0x42,
                0x50,
                0x83,
                0x6F
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IPreviewHandlerFrame
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xAF,
                0x7A,
                0xC8,
                0xFE,
                0xF9,
                0x35,
                0x7A,
                0x44,
                0xAD,
                0xB7,
                0x20,
                0x23,
                0x44,
                0x91,
                0x40,
                0x1A
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IExplorerPaneVisibility
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xEC,
                0x10,
                0x70,
                0xE0,
                0x17,
                0xBC,
                0xC0,
                0x44,
                0x97,
                0xB0,
                0x46,
                0xC7,
                0xC9,
                0x5B,
                0x9E,
                0xDC
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IContextMenuCB
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x30,
                0xE9,
                0x09,
                0x34,
                0x39,
                0x5A,
                0xD1,
                0x11,
                0x83,
                0xFA,
                0x00,
                0xA0,
                0xC9,
                0x0D,
                0xC8,
                0x49
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IDefaultExtractIconInit
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x7D,
                0xD1,
                0xDE,
                0x41,
                0xB3,
                0xD6,
                0x61,
                0x42,
                0x99,
                0x7D,
                0x88,
                0xC6,
                0x0E,
                0x4B,
                0x1D,
                0x58
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IExplorerCommand
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xD0,
                0xE4,
                0x8C,
                0xA0,
                0x25,
                0xFA,
                0xAB,
                0x44,
                0xB5,
                0x7C,
                0xC7,
                0xB1,
                0xC3,
                0x23,
                0xE0,
                0xB9
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IExplorerCommandState
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x60,
                0xCB,
                0xDA,
                0xBD,
                0x57,
                0x76,
                0xAE,
                0x47,
                0x84,
                0x45,
                0xD2,
                0x3E,
                0x1A,
                0xCF,
                0x82,
                0xAE
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IInitializeCommand
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xCF,
                0x5A,
                0x07,
                0x85,
                0x1F,
                0x23,
                0xEA,
                0x40,
                0x96,
                0x10,
                0xD2,
                0x6B,
                0x7B,
                0x58,
                0xF6,
                0x38
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IEnumExplorerCommand
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xF8,
                0x26,
                0x88,
                0xA8,
                0x6F,
                0x18,
                0x87,
                0x49,
                0xAA,
                0xDE,
                0xEA,
                0x0C,
                0xEF,
                0x8F,
                0xBF,
                0xE8
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IExplorerCommandProvider
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x51,
                0x17,
                0x96,
                0x64,
                0x35,
                0x08,
                0xC0,
                0x43,
                0x8F,
                0xFE,
                0xD5,
                0x76,
                0x86,
                0x53,
                0x0E,
                0x64
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IOpenControlPanel
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x62,
                0xD8,
                0x1A,
                0xD1,
                0xDE,
                0x66,
                0xF4,
                0x4D,
                0xBF,
                0x6C,
                0x1F,
                0x56,
                0x21,
                0x99,
                0x6A,
                0xF1
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IFileSystemBindData2
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x5F,
                0x07,
                0xCF,
                0x3A,
                0xDB,
                0x71,
                0xFA,
                0x4A,
                0x81,
                0xF0,
                0x3F,
                0xC4,
                0xFD,
                0xF2,
                0xA5,
                0xB8
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ICustomDestinationList
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xBF,
                0xDE,
                0x32,
                0x63,
                0xB5,
                0x87,
                0x70,
                0x46,
                0x90,
                0xC0,
                0x5E,
                0x57,
                0xB4,
                0x08,
                0xA4,
                0x9E
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IApplicationDestinations
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x35,
                0x7D,
                0x33,
                0x12,
                0xC6,
                0x94,
                0xA0,
                0x48,
                0xBC,
                0xE7,
                0x6A,
                0x9C,
                0x69,
                0xD4,
                0xD6,
                0x00
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IApplicationDocumentLists
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x9F,
                0x4F,
                0x59,
                0x3C,
                0x30,
                0x9F,
                0xA1,
                0x47,
                0x97,
                0x9A,
                0xC9,
                0xE8,
                0x3D,
                0x3D,
                0x0A,
                0x06
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IObjectWithAppUserModelID
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x96,
                0x01,
                0xDB,
                0x36,
                0x65,
                0x96,
                0xD1,
                0x46,
                0x9B,
                0xA7,
                0xD3,
                0x70,
                0x9E,
                0xEC,
                0xF9,
                0xED
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IObjectWithProgID
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xFB,
                0x06,
                0xE8,
                0x71,
                0xEE,
                0x8D,
                0xFC,
                0x46,
                0xBF,
                0x8C,
                0x77,
                0x48,
                0xA8,
                0xA1,
                0xAE,
                0x13
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IUpdateIDList
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xD2,
                0xB6,
                0x89,
                0x65,
                0x8D,
                0x5F,
                0x9E,
                0x4B,
                0xB7,
                0xE0,
                0x23,
                0xCD,
                0xD9,
                0x71,
                0x7D,
                0x8C
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IDesktopWallpaper
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xA9,
                0x56,
                0x2B,
                0xB9,
                0x55,
                0x8B,
                0x14,
                0x4E,
                0x9A,
                0x89,
                0x01,
                0x99,
                0xBB,
                0xB6,
                0xF9,
                0x3B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHomeGroup
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xD9,
                0xD1,
                0x3B,
                0x7A,
                0xA9,
                0x35,
                0xB3,
                0x4F,
                0xA4,
                0x67,
                0xF4,
                0x8C,
                0xAC,
                0x35,
                0xE2,
                0xD0
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IInitializeWithPropertyStore
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xB5,
                0x2E,
                0xE1,
                0xC3,
                0x8D,
                0x7D,
                0xF8,
                0x44,
                0xB6,
                0xDD,
                0x0E,
                0x77,
                0xB3,
                0x4D,
                0x6D,
                0xE4
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IOpenSearchSource
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x33,
                0x73,
                0xEE,
                0xF0,
                0xFC,
                0xE6,
                0x9B,
                0x47,
                0x9F,
                0x25,
                0xA8,
                0x60,
                0xC2,
                0x34,
                0xA3,
                0x8E
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IShellLibrary
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xFA,
                0x6E,
                0xA6,
                0x11,
                0x2E,
                0x38,
                0x1A,
                0x45,
                0x92,
                0x34,
                0x1E,
                0x0E,
                0x12,
                0xEF,
                0x30,
                0x85
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IDefaultFolderMenuInitialize
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x79,
                0xAA,
                0x90,
                0x76,
                0xFC,
                0xF8,
                0x15,
                0x46,
                0xA3,
                0x27,
                0x36,
                0xF7,
                0xD1,
                0x8F,
                0x5D,
                0x91
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IApplicationActivationManager
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x41,
                0x11,
                0x94,
                0x2E,
                0x97,
                0x7F,
                0x56,
                0x47,
                0xBA,
                0x1D,
                0x9D,
                0xEC,
                0xDE,
                0x89,
                0x4A,
                0x3D
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IVirtualDesktopManager
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xFF,
                0x92,
                0xCD,
                0xA5,
                0xBE,
                0x29,
                0x4C,
                0x45,
                0x8D,
                0x04,
                0xD8,
                0x28,
                0x79,
                0xFB,
                0x3F,
                0x1B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DesktopWallpaper
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x10,
                0x31,
                0xCF,
                0xC2,
                0x0E,
                0x46,
                0xC1,
                0x4F,
                0xB9,
                0xD0,
                0x8A,
                0x1C,
                0x0C,
                0x9C,
                0xC4,
                0xBD
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ShellDesktop
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x00,
                0x14,
                0x02,
                0x00,
                0x00,
                0x00,
                0x00,
                0x00,
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

    public static ref readonly Guid IID_ShellFSFolder
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xA0,
                0x4B,
                0x36,
                0xF3,
                0xB9,
                0x65,
                0xCE,
                0x11,
                0xA9,
                0xBA,
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

    public static ref readonly Guid IID_NetworkPlaces
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x60,
                0x2C,
                0x8D,
                0x20,
                0xEA,
                0x3A,
                0x69,
                0x10,
                0xA2,
                0xD7,
                0x08,
                0x00,
                0x2B,
                0x30,
                0x30,
                0x9D
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ShellLink
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x01,
                0x14,
                0x02,
                0x00,
                0x00,
                0x00,
                0x00,
                0x00,
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

    public static ref readonly Guid IID_DriveSizeCategorizer
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x53,
                0x7B,
                0x35,
                0x94,
                0x29,
                0xCA,
                0x78,
                0x4B,
                0x83,
                0xAE,
                0xE8,
                0xFE,
                0x74,
                0x09,
                0x13,
                0x4F
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DriveTypeCategorizer
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xCF,
                0xF3,
                0xA8,
                0xB0,
                0x33,
                0x43,
                0xAB,
                0x4B,
                0x88,
                0x73,
                0x1C,
                0xCB,
                0x1C,
                0xAD,
                0xA4,
                0x8B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_FreeSpaceCategorizer
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x93,
                0x77,
                0x60,
                0xB5,
                0xAC,
                0x24,
                0xC7,
                0x44,
                0x82,
                0xE2,
                0x83,
                0x17,
                0x26,
                0xAA,
                0x6C,
                0xB7
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_SizeCategorizer
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x52,
                0xB8,
                0xD7,
                0x55,
                0xD1,
                0xF6,
                0xF2,
                0x42,
                0xAA,
                0x75,
                0x87,
                0x28,
                0xA1,
                0xB2,
                0xD2,
                0x64
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_PropertiesUI
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xCF,
                0xF8,
                0x12,
                0xD9,
                0x96,
                0x03,
                0x15,
                0x49,
                0x88,
                0x4E,
                0xFB,
                0x42,
                0x5D,
                0x32,
                0x94,
                0x3B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_UserNotification
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x0E,
                0x89,
                0x10,
                0x00,
                0x89,
                0x87,
                0x3C,
                0x41,
                0xAD,
                0xBC,
                0x48,
                0xF5,
                0xB5,
                0x11,
                0xB3,
                0xAF
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_TaskbarList
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x44,
                0xF3,
                0xFD,
                0x56,
                0x6D,
                0xFD,
                0xD0,
                0x11,
                0x95,
                0x8A,
                0x00,
                0x60,
                0x97,
                0xC9,
                0xA0,
                0x90
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ShellItem
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xE1,
                0xFB,
                0xC9,
                0x9A,
                0xA2,
                0xE0,
                0xD6,
                0x4A,
                0xB4,
                0xEE,
                0xE2,
                0x12,
                0x01,
                0x3E,
                0xA9,
                0x17
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_NamespaceWalker
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xE0,
                0x61,
                0xEB,
                0x72,
                0x72,
                0x86,
                0x03,
                0x43,
                0x91,
                0x75,
                0xF2,
                0xE4,
                0xC6,
                0x8B,
                0x2E,
                0x7C
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_FileOperation
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x75,
                0x55,
                0xD0,
                0x3A,
                0x57,
                0x88,
                0x50,
                0x48,
                0x92,
                0x77,
                0x11,
                0xB8,
                0x5B,
                0xDB,
                0x8E,
                0x09
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_FileOpenDialog
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x9C,
                0x5A,
                0x1C,
                0xDC,
                0x8A,
                0xE8,
                0xDE,
                0x4D,
                0xA5,
                0xA1,
                0x60,
                0xF8,
                0x2A,
                0x20,
                0xAE,
                0xF7
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_FileSaveDialog
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xF3,
                0xE2,
                0xB4,
                0xC0,
                0x21,
                0xBA,
                0x73,
                0x47,
                0x8D,
                0xBA,
                0x33,
                0x5E,
                0xC9,
                0x46,
                0xEB,
                0x8B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_KnownFolderManager
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x30,
                0xC7,
                0xF0,
                0x4D,
                0x9D,
                0xDF,
                0xE3,
                0x4A,
                0x91,
                0x53,
                0xAA,
                0x6B,
                0x82,
                0xE9,
                0x79,
                0x5A
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_SharingConfigurationManager
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xE1,
                0x71,
                0xF3,
                0x49,
                0x5C,
                0x8C,
                0x9C,
                0x4D,
                0x9A,
                0x3B,
                0x54,
                0xA6,
                0x82,
                0x7F,
                0x51,
                0x3C
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_NetworkConnections
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xC7,
                0xAC,
                0x07,
                0x70,
                0x02,
                0x32,
                0xD1,
                0x11,
                0xAA,
                0xD2,
                0x00,
                0x80,
                0x5F,
                0xC1,
                0x27,
                0x0E
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ScheduledTasks
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x90,
                0x79,
                0x27,
                0xD6,
                0x6A,
                0x4C,
                0xCF,
                0x11,
                0x8D,
                0x87,
                0x00,
                0xAA,
                0x00,
                0x60,
                0xF5,
                0xBF
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ApplicationAssociationRegistration
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xC7,
                0x09,
                0x12,
                0x59,
                0x7B,
                0x76,
                0xB2,
                0x42,
                0x9F,
                0xBA,
                0x44,
                0xEE,
                0x46,
                0x15,
                0xF2,
                0xC7
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_SearchFolderItemFactory
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x02,
                0x0E,
                0x01,
                0x14,
                0xBD,
                0xBB,
                0xF0,
                0x41,
                0x88,
                0xE3,
                0xED,
                0xA3,
                0x71,
                0x21,
                0x65,
                0x84
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_OpenControlPanel
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x85,
                0x2D,
                0x62,
                0x06,
                0x56,
                0x68,
                0x60,
                0x44,
                0x8D,
                0xE1,
                0xA8,
                0x19,
                0x21,
                0xB4,
                0x1C,
                0x4B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_MailRecipient
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x60,
                0xBE,
                0x56,
                0x9E,
                0x0F,
                0xC5,
                0xCF,
                0x11,
                0x9A,
                0x2C,
                0x00,
                0xA0,
                0xC9,
                0x0A,
                0x90,
                0xCE
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_NetworkExplorerFolder
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x0D,
                0x1A,
                0x2C,
                0xF0,
                0x21,
                0xBE,
                0x50,
                0x43,
                0x88,
                0xB0,
                0x73,
                0x67,
                0xFC,
                0x96,
                0xEF,
                0x3C
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DestinationList
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xF0,
                0x0C,
                0xF1,
                0x77,
                0xB5,
                0x3D,
                0x66,
                0x49,
                0xB5,
                0x20,
                0xB7,
                0xC5,
                0x4F,
                0xD3,
                0x5E,
                0xD6
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ApplicationDestinations
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x03,
                0x40,
                0xC1,
                0x86,
                0x6B,
                0x4D,
                0xF3,
                0x4E,
                0xA7,
                0xB4,
                0x05,
                0x06,
                0x66,
                0x3B,
                0x2E,
                0x68
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ApplicationDocumentLists
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x22,
                0xC2,
                0xBE,
                0x86,
                0xF2,
                0x30,
                0xE0,
                0x47,
                0x9F,
                0x25,
                0x60,
                0xD1,
                0x1C,
                0xD7,
                0x5C,
                0x28
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_HomeGroup
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x04,
                0xBA,
                0x77,
                0xDE,
                0x92,
                0x3C,
                0x11,
                0x4D,
                0xA1,
                0xA5,
                0x42,
                0x35,
                0x2A,
                0x53,
                0xE0,
                0xE3
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ShellLibrary
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x1D,
                0x21,
                0xB3,
                0xD9,
                0x7F,
                0xE5,
                0x26,
                0x44,
                0xAA,
                0xEF,
                0x30,
                0xA8,
                0x06,
                0xAD,
                0xD3,
                0x97
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_AppStartupLink
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xE7,
                0xB5,
                0x3E,
                0x27,
                0xB0,
                0x88,
                0x43,
                0x48,
                0xBF,
                0xEF,
                0xE2,
                0xC8,
                0x1D,
                0x43,
                0xAA,
                0xE5
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_EnumerableObjectCollection
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xC1,
                0x68,
                0x34,
                0x2D,
                0xA7,
                0x36,
                0xB6,
                0x43,
                0xAC,
                0x24,
                0xD3,
                0xF0,
                0x2F,
                0xD9,
                0x60,
                0x7A
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_FrameworkInputPane
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xA3,
                0x0A,
                0x12,
                0xD5,
                0xBA,
                0x46,
                0xC5,
                0x44,
                0x82,
                0x2D,
                0xCA,
                0x80,
                0x92,
                0xC1,
                0xFC,
                0x72
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DefFolderMenu
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xBE,
                0x82,
                0x33,
                0xC6,
                0x33,
                0x79,
                0xD0,
                0x48,
                0x9A,
                0xC8,
                0x85,
                0xFB,
                0x46,
                0xBE,
                0x2F,
                0xDD
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_AppVisibility
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xD9,
                0xE3,
                0x5F,
                0x7E,
                0x5F,
                0x98,
                0x08,
                0x49,
                0x91,
                0xF9,
                0xEE,
                0x19,
                0xF9,
                0xFD,
                0x15,
                0x14
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_AppShellVerbHandler
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x19,
                0xA7,
                0xD3,
                0x4E,
                0xA8,
                0xCE,
                0xD9,
                0x4B,
                0x91,
                0x0D,
                0xE2,
                0x52,
                0xF9,
                0x97,
                0xAF,
                0xC2
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ExecuteUnknown
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x28,
                0x94,
                0x4E,
                0xE4,
                0xBC,
                0xBD,
                0x87,
                0x49,
                0xA0,
                0x99,
                0x40,
                0xDC,
                0x8F,
                0xD2,
                0x55,
                0xE7
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_PackageDebugSettings
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x6F,
                0xC1,
                0xAE,
                0xB1,
                0x83,
                0x23,
                0x52,
                0x48,
                0xB0,
                0xE9,
                0x8F,
                0x0B,
                0x1D,
                0xC6,
                0x6B,
                0x4D
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_SuspensionDependencyManager
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xC5,
                0x3F,
                0x27,
                0x6B,
                0xFD,
                0x61,
                0x18,
                0x49,
                0x95,
                0xA2,
                0xC3,
                0xB5,
                0xE9,
                0xD7,
                0xF5,
                0x81
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ApplicationActivationManager
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x7D,
                0x12,
                0xBA,
                0x45,
                0xA8,
                0x10,
                0xEA,
                0x46,
                0x8A,
                0xB7,
                0x56,
                0xEA,
                0x90,
                0x78,
                0x94,
                0x3C
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ApplicationDesignModeSettings
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xB5,
                0x6F,
                0x8A,
                0x95,
                0xB2,
                0xDC,
                0xAF,
                0x4F,
                0xAA,
                0xFD,
                0x7F,
                0xB0,
                0x54,
                0xAD,
                0x1A,
                0x3B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IAssocHandlerInvoker
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xAB,
                0x8C,
                0x21,
                0x92,
                0xAA,
                0xEC,
                0x35,
                0x43,
                0x81,
                0x33,
                0x80,
                0x7F,
                0xD2,
                0x34,
                0xC2,
                0xEE
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IAssocHandler
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xAC,
                0x61,
                0x40,
                0xF0,
                0x59,
                0x16,
                0x3F,
                0x4A,
                0xA9,
                0x54,
                0x77,
                0x5A,
                0xA5,
                0x7F,
                0xC0,
                0x83
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IEnumAssocHandlers
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xAE,
                0x10,
                0x38,
                0x97,
                0x99,
                0x95,
                0x88,
                0x4B,
                0x9E,
                0x4D,
                0x6E,
                0xE9,
                0x8C,
                0x95,
                0x52,
                0xDA
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IDataObjectProvider
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xD6,
                0xF6,
                0x25,
                0x3D,
                0x2A,
                0x4B,
                0x3C,
                0x43,
                0x91,
                0x84,
                0x7C,
                0x33,
                0xAD,
                0x35,
                0xD0,
                0x01
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IDataTransferManagerInterop
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x6C,
                0xCD,
                0x3D,
                0x3A,
                0xAB,
                0x3E,
                0xDC,
                0x43,
                0xBC,
                0xDE,
                0x45,
                0x67,
                0x1C,
                0xE8,
                0x00,
                0xC8
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IFrameworkInputPaneHandler
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x7B,
                0x53,
                0x6C,
                0x22,
                0x76,
                0x1E,
                0x9E,
                0x4D,
                0xA7,
                0x60,
                0x33,
                0xDB,
                0x29,
                0x92,
                0x2F,
                0x18
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IFrameworkInputPane
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x8B,
                0x23,
                0x52,
                0x57,
                0xF0,
                0x24,
                0x5A,
                0x49,
                0x82,
                0xF1,
                0x2F,
                0xD5,
                0x93,
                0x05,
                0x67,
                0x96
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IAppVisibilityEvents
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x6B,
                0xCE,
                0x84,
                0x65,
                0x82,
                0x7D,
                0xC2,
                0x49,
                0x89,
                0xC9,
                0xC6,
                0xBC,
                0x02,
                0xBA,
                0x8C,
                0x38
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IAppVisibility
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x2D,
                0xEA,
                0x46,
                0x22,
                0xEA,
                0xCA,
                0x44,
                0x44,
                0xA3,
                0xC4,
                0x6D,
                0xE8,
                0x27,
                0xE4,
                0x43,
                0x13
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IPackageExecutionStateChangeNotification
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x62,
                0x2A,
                0xB1,
                0x1B,
                0xD8,
                0x2A,
                0x2B,
                0x43,
                0x8C,
                0xCF,
                0x0C,
                0x2C,
                0x52,
                0xAF,
                0xCD,
                0x5B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IPackageDebugSettings
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x30,
                0x39,
                0x7C,
                0xF2,
                0x29,
                0x80,
                0xD1,
                0x4A,
                0x94,
                0xE3,
                0x3D,
                0xBA,
                0x41,
                0x78,
                0x10,
                0xC1
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IPackageDebugSettings2
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xBB,
                0x94,
                0x31,
                0x6E,
                0x82,
                0xAB,
                0x22,
                0x4D,
                0x93,
                0xF5,
                0xFA,
                0xBD,
                0xA4,
                0x0E,
                0x7B,
                0x16
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISuspensionDependencyManager
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x42,
                0x3A,
                0xB8,
                0x52,
                0x43,
                0x25,
                0x6A,
                0x41,
                0x81,
                0xD9,
                0xC0,
                0xDE,
                0x79,
                0x69,
                0xC8,
                0xB3
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IExecuteCommandApplicationHostEnvironment
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xA9,
                0x1A,
                0xB2,
                0x18,
                0x84,
                0xE1,
                0xF0,
                0x4F,
                0x9F,
                0x5E,
                0xF8,
                0x82,
                0xD0,
                0x37,
                0x71,
                0xB3
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IExecuteCommandHost
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xA2,
                0x32,
                0x68,
                0x4B,
                0x04,
                0x5F,
                0x9D,
                0x4C,
                0xB8,
                0x9D,
                0x72,
                0x7A,
                0x15,
                0xD1,
                0x03,
                0xE7
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IApplicationDesignModeSettings
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x9A,
                0xEE,
                0x3D,
                0x2A,
                0x1D,
                0xE3,
                0xD6,
                0x46,
                0x85,
                0x08,
                0xBC,
                0xC5,
                0x97,
                0xDB,
                0x35,
                0x57
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IApplicationDesignModeSettings2
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xE1,
                0x14,
                0x05,
                0x49,
                0x5A,
                0x67,
                0x6E,
                0x4D,
                0xA5,
                0x8D,
                0xE5,
                0x49,
                0x01,
                0xB4,
                0xCA,
                0x2F
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ILaunchTargetMonitor
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x7E,
                0xBC,
                0x6F,
                0x26,
                0x0D,
                0x49,
                0xED,
                0x46,
                0xA9,
                0x6B,
                0x22,
                0x74,
                0xDB,
                0x25,
                0x20,
                0x03
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ILaunchSourceViewSizePreference
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xF7,
                0x01,
                0xAA,
                0xE5,
                0xB8,
                0x1F,
                0x30,
                0x48,
                0x87,
                0x20,
                0x4E,
                0x67,
                0x34,
                0xCB,
                0xD5,
                0xF3
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ILaunchTargetViewSizePreference
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xC6,
                0x66,
                0x06,
                0x2F,
                0xF7,
                0x12,
                0x60,
                0x43,
                0xB5,
                0x11,
                0xA3,
                0x94,
                0xA0,
                0x55,
                0x37,
                0x25
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ILaunchSourceAppUserModelId
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xAC,
                0x91,
                0x91,
                0x98,
                0xFF,
                0x28,
                0xF0,
                0x4C,
                0x95,
                0x84,
                0xE0,
                0xD0,
                0x78,
                0xBC,
                0x23,
                0x96
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IInitializeWithWindow
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xBD,
                0xD4,
                0x68,
                0x3E,
                0x35,
                0x71,
                0x10,
                0x4D,
                0x80,
                0x18,
                0x9F,
                0xB6,
                0xD9,
                0xF3,
                0x3F,
                0xA1
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHandlerInfo
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xEF,
                0x06,
                0x77,
                0x99,
                0x80,
                0xF8,
                0x3B,
                0x45,
                0x81,
                0x18,
                0x39,
                0xE1,
                0xA2,
                0xD2,
                0x65,
                0x5A
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHandlerInfo2
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x4C,
                0xA0,
                0xCC,
                0x31,
                0xD3,
                0x04,
                0xA9,
                0x4E,
                0x90,
                0xDE,
                0x97,
                0xB1,
                0x5E,
                0x87,
                0xA5,
                0x32
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHandlerActivationHost
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x87,
                0x4A,
                0x09,
                0x35,
                0xB1,
                0x8B,
                0x37,
                0x42,
                0x96,
                0xC6,
                0xC4,
                0x17,
                0xEE,
                0xBD,
                0xB0,
                0x78
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IAppActivationUIInfo
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x9D,
                0x18,
                0xAD,
                0xAB,
                0xA3,
                0x9F,
                0x78,
                0x42,
                0xB3,
                0xCA,
                0x8C,
                0xA4,
                0x48,
                0xA8,
                0x8D,
                0xCB
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IContactManagerInterop
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xA7,
                0xCB,
                0xEA,
                0x99,
                0x73,
                0xE0,
                0xB6,
                0x43,
                0xA8,
                0x96,
                0x55,
                0xAF,
                0xE4,
                0x8A,
                0x08,
                0x33
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IBannerNotificationHandler
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xA7,
                0x2B,
                0x7B,
                0x8D,
                0x05,
                0xDB,
                0xA8,
                0x46,
                0x82,
                0x3C,
                0xD2,
                0xB6,
                0xDE,
                0x08,
                0xEE,
                0x91
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISortColumnArray
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xFB,
                0x60,
                0xFC,
                0x6D,
                0xE9,
                0xF2,
                0x9B,
                0x45,
                0xBE,
                0xB5,
                0x28,
                0x8F,
                0x1A,
                0x7C,
                0x7D,
                0x54
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IPropertyKeyStore
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xAA,
                0x59,
                0xBD,
                0x75,
                0x3B,
                0xF2,
                0x63,
                0x49,
                0xAB,
                0xA4,
                0x0B,
                0x35,
                0x57,
                0x52,
                0xA9,
                0x1B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}