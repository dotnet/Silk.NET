// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/SyncMgr.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;
public static partial class IID
{
    public static ref readonly Guid IID_ISyncMgrHandlerCollection
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xA3,
                0x37,
                0xF3,
                0xA7,
                0x0B,
                0xD2,
                0xCB,
                0x45,
                0x9E,
                0xD7,
                0x87,
                0xD0,
                0x94,
                0xCA,
                0x50,
                0x45
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISyncMgrHandler
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x43,
                0x2E,
                0xEC,
                0x04,
                0x77,
                0xAC,
                0xF9,
                0x49,
                0x9B,
                0x98,
                0x03,
                0x07,
                0xEF,
                0x7A,
                0x72,
                0xA2
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISyncMgrHandlerInfo
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x98,
                0xD7,
                0xF1,
                0x4F,
                0xF7,
                0xEC,
                0x24,
                0x45,
                0xAA,
                0x81,
                0x1E,
                0x36,
                0x2A,
                0x0A,
                0xEF,
                0x3A
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISyncMgrSyncItemContainer
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x33,
                0x11,
                0x70,
                0x90,
                0x32,
                0xBE,
                0x29,
                0x41,
                0xA6,
                0x5C,
                0x99,
                0xE6,
                0x16,
                0xCA,
                0xFF,
                0xF4
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISyncMgrSyncItem
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xCE,
                0x24,
                0x0B,
                0xB2,
                0x93,
                0x25,
                0x04,
                0x4F,
                0xBD,
                0x8B,
                0x7A,
                0xD6,
                0xC4,
                0x50,
                0x51,
                0xCD
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISyncMgrSyncItemInfo
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x02,
                0x95,
                0xFD,
                0xE7,
                0x0C,
                0xBE,
                0x64,
                0x44,
                0x90,
                0xA1,
                0x2B,
                0x52,
                0x77,
                0x03,
                0x12,
                0x32
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IEnumSyncMgrSyncItems
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xF3,
                0xAB,
                0xB3,
                0x54,
                0x85,
                0xF0,
                0x81,
                0x41,
                0xB5,
                0x46,
                0xE2,
                0x9C,
                0x40,
                0x3C,
                0x72,
                0x6B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISyncMgrSessionCreator
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x17,
                0x85,
                0xF4,
                0x17,
                0x05,
                0xF3,
                0x21,
                0x43,
                0xA0,
                0x8D,
                0xB2,
                0x5A,
                0x83,
                0x49,
                0x18,
                0xFD
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISyncMgrSyncCallback
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x87,
                0xCD,
                0x4C,
                0x88,
                0x39,
                0xB1,
                0x37,
                0x49,
                0xA4,
                0xBA,
                0x4F,
                0x8E,
                0x19,
                0x51,
                0x3F,
                0xBE
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISyncMgrUIOperation
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x47,
                0xFA,
                0x7C,
                0xFC,
                0xE1,
                0xDF,
                0xB5,
                0x45,
                0xA0,
                0x49,
                0x8C,
                0xFD,
                0x82,
                0xBE,
                0xC2,
                0x71
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISyncMgrEventLinkUIOperation
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x52,
                0x2E,
                0x52,
                0x64,
                0x8B,
                0x84,
                0x15,
                0x40,
                0x89,
                0xCE,
                0x5A,
                0x36,
                0xF0,
                0x0B,
                0x94,
                0xFF
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISyncMgrScheduleWizardUIOperation
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x84,
                0x6C,
                0x9A,
                0x45,
                0xD2,
                0x21,
                0xDC,
                0x4D,
                0x8A,
                0x53,
                0xF0,
                0x23,
                0xA4,
                0x60,
                0x66,
                0xF2
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISyncMgrSyncResult
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x7E,
                0xF1,
                0x90,
                0x2B,
                0x3E,
                0x5A,
                0x33,
                0x4B,
                0xBB,
                0x7F,
                0x1B,
                0xC4,
                0x80,
                0x56,
                0xB9,
                0x4D
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISyncMgrControl
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x6C,
                0x61,
                0x63,
                0x9B,
                0xB2,
                0x36,
                0xBC,
                0x46,
                0x95,
                0x9F,
                0xC1,
                0x59,
                0x39,
                0x52,
                0xD1,
                0x9B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISyncMgrEventStore
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xF9,
                0x12,
                0xE4,
                0x37,
                0x6E,
                0x01,
                0xC2,
                0x44,
                0x81,
                0xFF,
                0xDB,
                0x3A,
                0xDD,
                0x77,
                0x42,
                0x66
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISyncMgrEvent
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x8B,
                0xEF,
                0xE0,
                0xFE,
                0xBD,
                0x46,
                0xB4,
                0x4D,
                0xB7,
                0xE6,
                0xFF,
                0x2C,
                0x68,
                0x73,
                0x13,
                0xBC
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IEnumSyncMgrEvents
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x4E,
                0x1D,
                0x1A,
                0xC8,
                0xF7,
                0x8C,
                0x83,
                0x46,
                0x80,
                0xE0,
                0xBC,
                0xAE,
                0x88,
                0xD6,
                0x77,
                0xB6
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISyncMgrConflictStore
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x79,
                0xC5,
                0x8F,
                0xCF,
                0x96,
                0xC3,
                0x74,
                0x47,
                0x85,
                0xF1,
                0xD9,
                0x08,
                0xA8,
                0x31,
                0x15,
                0x6E
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IEnumSyncMgrConflict
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x14,
                0x59,
                0x70,
                0x82,
                0xA3,
                0xDD,
                0x93,
                0x48,
                0xBA,
                0x99,
                0x49,
                0xDE,
                0x6C,
                0x8C,
                0x80,
                0x36
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISyncMgrConflict
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x49,
                0x42,
                0x20,
                0x9C,
                0x43,
                0xC4,
                0xA4,
                0x4B,
                0x85,
                0xED,
                0xC9,
                0x72,
                0x68,
                0x1D,
                0xB1,
                0x37
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISyncMgrResolutionHandler
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x52,
                0xD0,
                0xA3,
                0x40,
                0xFF,
                0x8B,
                0x4B,
                0x4C,
                0xA3,
                0x38,
                0xD4,
                0xA3,
                0x95,
                0x70,
                0x0D,
                0xE9
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISyncMgrConflictPresenter
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x53,
                0x53,
                0x4F,
                0x0B,
                0x2B,
                0xFD,
                0xCD,
                0x42,
                0x87,
                0x63,
                0x47,
                0x79,
                0xF2,
                0xD5,
                0x08,
                0xA3
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISyncMgrConflictResolveInfo
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x19,
                0xA2,
                0x05,
                0xC4,
                0xA2,
                0x25,
                0x2E,
                0x44,
                0x87,
                0x43,
                0xB8,
                0x45,
                0xA2,
                0xCE,
                0xE9,
                0x3F
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISyncMgrConflictFolder
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x5E,
                0x7F,
                0x28,
                0x59,
                0x81,
                0xBC,
                0xCA,
                0x4F,
                0xA7,
                0xF1,
                0xE5,
                0xA8,
                0xEC,
                0xDB,
                0x1D,
                0x69
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISyncMgrConflictItems
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x52,
                0xAD,
                0x7E,
                0x9C,
                0x23,
                0x80,
                0x36,
                0x49,
                0xA4,
                0xDB,
                0xD2,
                0xA9,
                0xA9,
                0x9E,
                0x43,
                0x6A
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISyncMgrConflictResolutionItems
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xB9,
                0x25,
                0x87,
                0x45,
                0x9D,
                0x12,
                0x35,
                0x41,
                0xA9,
                0x98,
                0x9C,
                0xEA,
                0xFE,
                0xC2,
                0x70,
                0x07
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_SyncMgrClient
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x60,
                0xDB,
                0x02,
                0x12,
                0xAC,
                0x1D,
                0xC5,
                0x42,
                0xAE,
                0xD5,
                0x1A,
                0xBD,
                0xD4,
                0x32,
                0x24,
                0x8E
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_SyncMgrControl
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x06,
                0x42,
                0x1F,
                0x1A,
                0x88,
                0x06,
                0x7F,
                0x4E,
                0xBE,
                0x03,
                0xD8,
                0x2E,
                0xC6,
                0x9D,
                0xF9,
                0xA5
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_SyncMgrScheduleWizard
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x30,
                0x8E,
                0x8B,
                0x8D,
                0x51,
                0xC4,
                0x1B,
                0x42,
                0x85,
                0x53,
                0xD2,
                0x97,
                0x6A,
                0xFA,
                0x64,
                0x8C
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_SyncMgrFolder
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xE5,
                0xF5,
                0x73,
                0x9C,
                0xE7,
                0x7A,
                0x32,
                0x4E,
                0xA8,
                0xE8,
                0x8D,
                0x23,
                0xB8,
                0x52,
                0x55,
                0xBF
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_SyncSetupFolder
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xC0,
                0x59,
                0x9E,
                0x2E,
                0x37,
                0xB4,
                0x81,
                0x49,
                0xA6,
                0x47,
                0x9C,
                0x34,
                0xB9,
                0xB9,
                0x08,
                0x91
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ConflictFolder
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xAC,
                0x78,
                0x99,
                0x28,
                0x01,
                0xA1,
                0x41,
                0x43,
                0xA8,
                0x17,
                0x21,
                0xEB,
                0xA7,
                0xFD,
                0x04,
                0x6D
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_SyncResultsFolder
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x64,
                0x94,
                0xD9,
                0x71,
                0x6B,
                0x3B,
                0x5C,
                0x47,
                0xB2,
                0x41,
                0xE1,
                0x58,
                0x83,
                0x20,
                0x75,
                0x29
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_SimpleConflictPresenter
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xB7,
                0x6A,
                0x0F,
                0x7A,
                0x84,
                0xED,
                0xB6,
                0x46,
                0xB4,
                0x7E,
                0x02,
                0xAA,
                0x15,
                0x9A,
                0x15,
                0x2B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}