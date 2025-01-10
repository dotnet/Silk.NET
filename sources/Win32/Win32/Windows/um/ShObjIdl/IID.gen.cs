// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class IID
{
    public static ref readonly Guid IID_IQueryCodePage
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xCE,
                0x36,
                0xB2,
                0xC7,
                0x80,
                0xEE,
                0xD0,
                0x11,
                0x98,
                0x5F,
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
    public static ref readonly Guid IID_IFolderViewOptions
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD2,
                0x74,
                0xC9,
                0x3C,
                0x02,
                0xB3,
                0x36,
                0x4D,
                0xAD,
                0x3E,
                0x06,
                0xD9,
                0x3F,
                0x69,
                0x5D,
                0x3F,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IShellView3
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x88,
                0xFA,
                0x39,
                0xEC,
                0xAF,
                0xF8,
                0xC5,
                0x41,
                0x84,
                0x21,
                0x38,
                0xBE,
                0xD2,
                0x8F,
                0x46,
                0x73,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISearchBoxInfo
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x3F,
                0xE0,
                0xF6,
                0x6A,
                0x64,
                0xD6,
                0xF4,
                0x4E,
                0x96,
                0x26,
                0xF7,
                0xE0,
                0xED,
                0x36,
                0x75,
                0x5E,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IVisualProperties
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x68,
                0xCF,
                0x93,
                0xE6,
                0x67,
                0xD9,
                0x12,
                0x41,
                0x87,
                0x63,
                0x99,
                0x17,
                0x2A,
                0xEE,
                0x5E,
                0x5A,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICommDlgBrowser3
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA1,
                0x25,
                0xAD,
                0xC8,
                0x94,
                0x32,
                0xEE,
                0x41,
                0x81,
                0x65,
                0x71,
                0x17,
                0x4B,
                0xD0,
                0x1C,
                0x57,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IUserAccountChangeCallback
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x9A,
                0xE6,
                0x61,
                0xA5,
                0xB8,
                0xB4,
                0x13,
                0x41,
                0x91,
                0xA5,
                0x64,
                0xC6,
                0xBC,
                0xCA,
                0x34,
                0x30,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IStreamAsync
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x65,
                0x66,
                0x0B,
                0xFE,
                0xCA,
                0xE0,
                0xB9,
                0x49,
                0xA1,
                0x78,
                0x2B,
                0x5C,
                0xB4,
                0x8D,
                0x92,
                0xA5,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IStreamUnbufferedInfo
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xDA,
                0xFD,
                0x68,
                0x8A,
                0xDC,
                0x1F,
                0x20,
                0x4C,
                0x8C,
                0xEB,
                0x41,
                0x66,
                0x43,
                0xB5,
                0xA6,
                0x25,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDragSourceHelper2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x0D,
                0x7D,
                0xE0,
                0x83,
                0x5F,
                0x0C,
                0x63,
                0x41,
                0xBF,
                0x1A,
                0x60,
                0xB2,
                0x74,
                0x05,
                0x1E,
                0x40,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IHWEventHandler
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD0,
                0x73,
                0xFB,
                0xC1,
                0x3A,
                0xEC,
                0xA2,
                0x4B,
                0xB5,
                0x12,
                0x8C,
                0xDB,
                0x91,
                0x87,
                0xB6,
                0xD1,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IHWEventHandler2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x9F,
                0x80,
                0xCC,
                0xCF,
                0x5D,
                0x29,
                0xE8,
                0x42,
                0x9F,
                0xFC,
                0x42,
                0x4B,
                0x33,
                0xC4,
                0x87,
                0xE6,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IQueryCancelAutoPlay
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x73,
                0xE8,
                0xEF,
                0xDD,
                0x97,
                0x69,
                0x68,
                0x4E,
                0xBE,
                0x26,
                0x39,
                0xB6,
                0x33,
                0xAD,
                0xBE,
                0x12,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDynamicHWHandler
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD7,
                0x01,
                0x26,
                0xDC,
                0x9E,
                0x05,
                0xFC,
                0x42,
                0xA0,
                0x9D,
                0x2A,
                0xFD,
                0x21,
                0xB6,
                0xD5,
                0xF7,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IUserNotificationCallback
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x94,
                0x82,
                0x10,
                0x19,
                0x41,
                0x04,
                0xFF,
                0x4A,
                0x80,
                0x13,
                0xFA,
                0x0A,
                0x73,
                0x0B,
                0x0B,
                0xEA,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IUserNotification2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xCC,
                0x13,
                0x59,
                0x21,
                0xEB,
                0x57,
                0xAB,
                0x4F,
                0xAB,
                0x5A,
                0xE5,
                0xFA,
                0x7B,
                0xEA,
                0x2A,
                0x6C,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDeskBand2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE4,
                0x6D,
                0xD1,
                0x79,
                0xEE,
                0xAB,
                0x21,
                0x40,
                0x8D,
                0x9D,
                0x91,
                0x69,
                0xB2,
                0x61,
                0xD6,
                0x57,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IStartMenuPinnedList
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xDA,
                0x9A,
                0xD1,
                0x4C,
                0xA5,
                0x25,
                0x32,
                0x4A,
                0xB3,
                0xB7,
                0x34,
                0x7B,
                0xEE,
                0x5B,
                0xE3,
                0x6B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICDBurn
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x59,
                0xA6,
                0x73,
                0x3D,
                0xD0,
                0xE5,
                0x42,
                0x4D,
                0xAF,
                0xC0,
                0x51,
                0x21,
                0xBA,
                0x42,
                0x5C,
                0x8D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IWizardSite
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x5B,
                0x0F,
                0x96,
                0x88,
                0x2F,
                0x42,
                0x7B,
                0x4E,
                0x80,
                0x13,
                0x73,
                0x41,
                0x53,
                0x81,
                0xC3,
                0xC3,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IWizardExtension
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x96,
                0xA6,
                0x2E,
                0xC0,
                0xCC,
                0x86,
                0x1E,
                0x49,
                0x9B,
                0x23,
                0x74,
                0x39,
                0x4A,
                0x04,
                0x44,
                0xA8,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IWebWizardExtension
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x66,
                0x3F,
                0x6B,
                0x0E,
                0xD1,
                0x98,
                0xC0,
                0x48,
                0xA2,
                0x22,
                0xFB,
                0xDE,
                0x74,
                0xE2,
                0xFB,
                0xC5,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPublishingWizard
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xBB,
                0x98,
                0x91,
                0xAA,
                0xEC,
                0xCC,
                0x2D,
                0x47,
                0xBE,
                0xED,
                0x19,
                0xA4,
                0xF6,
                0x73,
                0x3F,
                0x7A,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IFolderViewHost
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x02,
                0x8F,
                0xA5,
                0x1E,
                0x5A,
                0xD5,
                0x1D,
                0x41,
                0xB0,
                0x9E,
                0x9E,
                0x65,
                0xAC,
                0x21,
                0x60,
                0x5B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAccessibleObject
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC5,
                0x91,
                0xA3,
                0x95,
                0xD4,
                0x9E,
                0x28,
                0x4C,
                0x84,
                0x01,
                0xAB,
                0x9E,
                0x06,
                0x71,
                0x9E,
                0x11,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IResultsFolder
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x6D,
                0xAE,
                0xE5,
                0x96,
                0xE1,
                0x6A,
                0x1C,
                0x4B,
                0x90,
                0x0C,
                0xC6,
                0x48,
                0x0E,
                0xAA,
                0x88,
                0x28,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAutoCompleteDropDown
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF4,
                0x41,
                0xD1,
                0x3C,
                0x6A,
                0x3C,
                0xD2,
                0x11,
                0xBC,
                0xAA,
                0x00,
                0xC0,
                0x4F,
                0xD9,
                0x29,
                0xDB,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICDBurnExt
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xCA,
                0xDC,
                0x71,
                0x22,
                0xFC,
                0x74,
                0x14,
                0x44,
                0x8F,
                0xB7,
                0xC5,
                0x6B,
                0x05,
                0xAC,
                0xE2,
                0xD7,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IEnumReadyCallback
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x45,
                0x0D,
                0xE0,
                0x61,
                0xFF,
                0x8F,
                0x60,
                0x4E,
                0x92,
                0x4E,
                0x65,
                0x37,
                0xB6,
                0x16,
                0x12,
                0xDD,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IEnumerableView
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x36,
                0xF2,
                0x8B,
                0x8C,
                0xEC,
                0x1A,
                0x5F,
                0x49,
                0x98,
                0x94,
                0x91,
                0xD5,
                0x7C,
                0x3C,
                0x68,
                0x6F,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IInsertItem
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x27,
                0x72,
                0xB5,
                0xD2,
                0x23,
                0x3D,
                0x95,
                0x4B,
                0x93,
                0xC0,
                0x49,
                0x2B,
                0xD4,
                0x54,
                0xC3,
                0x56,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IFolderBandPriv
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x95,
                0x1F,
                0xC0,
                0x47,
                0x85,
                0xE1,
                0x2C,
                0x41,
                0xB5,
                0xC5,
                0x4F,
                0x27,
                0xDF,
                0x96,
                0x5A,
                0xEA,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IImageRecompress
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x13,
                0x15,
                0x5F,
                0x50,
                0x3E,
                0x6B,
                0x92,
                0x48,
                0xA2,
                0x72,
                0x59,
                0xF8,
                0x88,
                0x9A,
                0x4D,
                0x3E,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IFileDialogControlEvents
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x42,
                0x66,
                0x11,
                0x36,
                0x13,
                0xD7,
                0x97,
                0x4B,
                0x9B,
                0x83,
                0x74,
                0x84,
                0xA9,
                0xD0,
                0x04,
                0x33,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IFileDialog2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC7,
                0x4F,
                0x74,
                0x61,
                0xB5,
                0x85,
                0x91,
                0x47,
                0xA9,
                0xB0,
                0x27,
                0x22,
                0x76,
                0x30,
                0x9B,
                0x13,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IApplicationAssociationRegistrationUI
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x69,
                0xA1,
                0x76,
                0x1F,
                0x94,
                0xF9,
                0xAC,
                0x40,
                0x8F,
                0xC8,
                0x09,
                0x59,
                0xE8,
                0x87,
                0x47,
                0x10,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IShellRunDll
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE0,
                0xBD,
                0xE4,
                0xFC,
                0x68,
                0x4B,
                0x80,
                0x4B,
                0x8E,
                0x9C,
                0x74,
                0x26,
                0x31,
                0x5A,
                0x73,
                0x88,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPreviousVersionsInfo
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x80,
                0x47,
                0xE5,
                0x76,
                0x74,
                0xAD,
                0xE3,
                0x48,
                0xA6,
                0x95,
                0x3B,
                0xA9,
                0xA0,
                0xAF,
                0xF1,
                0x0D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IUseToBrowseItem
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x5C,
                0xDA,
                0xED,
                0x05,
                0xA3,
                0x98,
                0x17,
                0x47,
                0x8A,
                0xDB,
                0xC5,
                0xE7,
                0xDA,
                0x99,
                0x1E,
                0xB1,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_INameSpaceTreeControl2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD8,
                0xAE,
                0xC7,
                0x7C,
                0x0E,
                0x29,
                0xBC,
                0x49,
                0x89,
                0x45,
                0xC1,
                0x40,
                0x1C,
                0xC9,
                0x30,
                0x6C,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_INameSpaceTreeControlEvents
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x85,
                0x79,
                0xD7,
                0x93,
                0xD8,
                0xB3,
                0x84,
                0x44,
                0x83,
                0x18,
                0x67,
                0x2C,
                0xDD,
                0xA0,
                0x02,
                0xCE,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_INameSpaceTreeControlDropHandler
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD6,
                0x65,
                0xC6,
                0xF9,
                0xF2,
                0xC2,
                0x19,
                0x4C,
                0xBF,
                0x33,
                0x83,
                0x22,
                0xD7,
                0x35,
                0x2F,
                0x51,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_INameSpaceTreeAccessible
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xDE,
                0x12,
                0xF3,
                0x71,
                0xED,
                0x43,
                0x90,
                0x41,
                0x84,
                0x77,
                0xE9,
                0x53,
                0x6B,
                0x82,
                0x35,
                0x0B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_INameSpaceTreeControlCustomDraw
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x58,
                0xA7,
                0x3B,
                0x2D,
                0xEE,
                0x33,
                0xD5,
                0x42,
                0xBB,
                0x7B,
                0x5F,
                0x34,
                0x31,
                0xD8,
                0x6C,
                0x78,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ITrayDeskBand
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x46,
                0xE8,
                0x67,
                0x6D,
                0x9C,
                0x5B,
                0xB8,
                0x4D,
                0x9C,
                0xBC,
                0xDD,
                0xE1,
                0x2F,
                0x42,
                0x54,
                0xF1,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IBandHost
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x7C,
                0x5C,
                0x07,
                0xB9,
                0x8E,
                0xD4,
                0x3F,
                0x40,
                0xAB,
                0x99,
                0xD6,
                0xC7,
                0x7A,
                0x10,
                0x84,
                0xAC,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IComputerInfoChangeNotify
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x92,
                0x0D,
                0xF6,
                0x0D,
                0x18,
                0x68,
                0xD6,
                0x46,
                0xB3,
                0x58,
                0xD6,
                0x61,
                0x70,
                0xDD,
                0xE4,
                0x66,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDesktopGadget
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC4,
                0x6B,
                0x64,
                0xC1,
                0x98,
                0xF2,
                0x91,
                0x4F,
                0xA2,
                0x04,
                0xEB,
                0x2D,
                0xD1,
                0x70,
                0x9D,
                0x1A,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_QueryCancelAutoPlay
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x68,
                0x17,
                0x1F,
                0x33,
                0xA9,
                0x05,
                0xDD,
                0x4D,
                0xB8,
                0x6E,
                0xDA,
                0xE3,
                0x4D,
                0xDC,
                0x99,
                0x8A,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_TimeCategorizer
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x8F,
                0x11,
                0xB4,
                0x3B,
                0xFD,
                0xDD,
                0x30,
                0x4D,
                0xA3,
                0x48,
                0x9F,
                0xB5,
                0xD6,
                0xBF,
                0x1A,
                0xFE,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_AlphabeticalCategorizer
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC6,
                0x54,
                0x26,
                0x3C,
                0x72,
                0x73,
                0x6B,
                0x4F,
                0xB3,
                0x10,
                0x55,
                0xD6,
                0x12,
                0x8F,
                0x49,
                0xD2,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_MergedCategorizer
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x11,
                0x7C,
                0x82,
                0x8E,
                0xE7,
                0x33,
                0xC1,
                0x4B,
                0xB2,
                0x42,
                0x8C,
                0xD9,
                0xA1,
                0xC2,
                0xB3,
                0x04,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ImageProperties
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC7,
                0x70,
                0xB7,
                0x7A,
                0x23,
                0x0E,
                0x7A,
                0x4D,
                0x8A,
                0xA2,
                0x19,
                0xBF,
                0xAD,
                0x47,
                0x98,
                0x29,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_CDBurn
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x05,
                0x8A,
                0xEB,
                0xFB,
                0xEE,
                0xBE,
                0x42,
                0x44,
                0x80,
                0x4E,
                0x40,
                0x9D,
                0x6C,
                0x45,
                0x15,
                0xE9,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_StartMenuPin
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x5D,
                0x54,
                0xA9,
                0xA2,
                0xC2,
                0xA0,
                0xB4,
                0x42,
                0x97,
                0x08,
                0xA0,
                0xB2,
                0xBA,
                0xDD,
                0x77,
                0xC8,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_WebWizardHost
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x49,
                0xF1,
                0x27,
                0xC8,
                0xC1,
                0x55,
                0x28,
                0x4D,
                0x93,
                0x5E,
                0x57,
                0xE4,
                0x7C,
                0xAE,
                0xD9,
                0x73,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_PublishDropTarget
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xFB,
                0xEF,
                0x6E,
                0xCC,
                0xF6,
                0x43,
                0xC5,
                0x46,
                0x96,
                0x19,
                0x51,
                0xD5,
                0x71,
                0x96,
                0x7F,
                0x7D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_PublishingWizard
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x3C,
                0x16,
                0x33,
                0x6B,
                0xA5,
                0x76,
                0x6C,
                0x4B,
                0xBF,
                0x21,
                0x45,
                0xDE,
                0x9C,
                0xD5,
                0x03,
                0xA1,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_InternetPrintOrdering
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA8,
                0x6A,
                0xD3,
                0xAD,
                0x1A,
                0x75,
                0x79,
                0x45,
                0xA2,
                0x66,
                0xD6,
                0x6F,
                0x52,
                0x02,
                0xCC,
                0xBB,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_FolderViewHost
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x23,
                0xCB,
                0xB1,
                0x20,
                0x68,
                0x69,
                0xB9,
                0x4E,
                0xB7,
                0xD4,
                0xA6,
                0x6D,
                0x00,
                0xD0,
                0x7C,
                0xEE,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ExplorerBrowser
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x85,
                0x63,
                0xF9,
                0x71,
                0xD6,
                0xDD,
                0xD3,
                0x48,
                0xA0,
                0xC1,
                0xAE,
                0x06,
                0xE8,
                0xB0,
                0x55,
                0xFB,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ImageRecompress
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x1C,
                0x09,
                0x33,
                0x6E,
                0xF8,
                0xD2,
                0x40,
                0x47,
                0xB5,
                0x5E,
                0x2E,
                0x11,
                0xD1,
                0x47,
                0x7A,
                0x2C,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_TrayBandSiteService
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA0,
                0xD0,
                0x0A,
                0xF6,
                0xE1,
                0xE5,
                0xCB,
                0x45,
                0xB5,
                0x1A,
                0xE1,
                0x5B,
                0x9F,
                0x8B,
                0x29,
                0x34,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_TrayDeskBand
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x37,
                0x24,
                0x44,
                0xE6,
                0x68,
                0x6C,
                0x52,
                0x4F,
                0x94,
                0xDD,
                0x2C,
                0xFE,
                0xD2,
                0x67,
                0xEF,
                0xB9,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_AttachmentServices
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x96,
                0xDD,
                0x25,
                0x41,
                0x3A,
                0xE0,
                0x03,
                0x41,
                0x8F,
                0x70,
                0xE0,
                0x59,
                0x7D,
                0x80,
                0x3B,
                0x9C,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_DocPropShellExtension
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC3,
                0x73,
                0x33,
                0x88,
                0x89,
                0xBF,
                0xD1,
                0x11,
                0xBE,
                0x35,
                0x08,
                0x00,
                0x36,
                0xB1,
                0x1A,
                0x03,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_FSCopyHandler
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x0A,
                0x38,
                0x97,
                0xD1,
                0x79,
                0x0A,
                0xC8,
                0x4D,
                0xA0,
                0x33,
                0xED,
                0x88,
                0x2C,
                0x2F,
                0xA1,
                0x4B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_PreviousVersions
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x62,
                0xB0,
                0x6A,
                0x59,
                0xD2,
                0xB4,
                0x15,
                0x42,
                0x9F,
                0x74,
                0xE9,
                0x10,
                0x9B,
                0x0A,
                0x81,
                0x53,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_NamespaceTreeControl
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x12,
                0x42,
                0x05,
                0xAE,
                0x35,
                0x35,
                0x30,
                0x44,
                0x83,
                0xED,
                0xD5,
                0x01,
                0xAA,
                0x66,
                0x80,
                0xE6,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IENamespaceTreeControl
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x03,
                0x2D,
                0xE5,
                0xAC,
                0xCD,
                0xE5,
                0x20,
                0x4B,
                0x82,
                0xFF,
                0xE7,
                0x1B,
                0x11,
                0xBE,
                0xAE,
                0x1D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ApplicationAssociationRegistrationUI
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x6D,
                0x10,
                0x68,
                0x19,
                0xB5,
                0xF3,
                0xCF,
                0x44,
                0x89,
                0x0E,
                0x11,
                0x6F,
                0xCB,
                0x9E,
                0xCE,
                0xF1,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_DesktopGadget
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x1B,
                0xCC,
                0x4C,
                0x92,
                0x62,
                0x65,
                0x85,
                0x4C,
                0x86,
                0x57,
                0xD1,
                0x77,
                0x92,
                0x52,
                0x22,
                0xB6,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_AccessibilityDockingService
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x46,
                0x1D,
                0xCE,
                0x29,
                0x81,
                0xB4,
                0xA0,
                0x4A,
                0xA0,
                0x8A,
                0xD3,
                0xEB,
                0xC8,
                0xAC,
                0xA4,
                0x02,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ExecuteFolder
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x7C,
                0xB4,
                0xDB,
                0x11,
                0x25,
                0xA5,
                0x0B,
                0x40,
                0x9E,
                0x80,
                0xA5,
                0x46,
                0x15,
                0xA0,
                0x90,
                0xC0,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_VirtualDesktopManager
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x86,
                0x90,
                0x50,
                0xAA,
                0xA9,
                0x5C,
                0x25,
                0x4C,
                0x8F,
                0x95,
                0x58,
                0x9D,
                0x3C,
                0x07,
                0xB4,
                0x8A,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_StorageProviderBanners
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF4,
                0xF9,
                0xCD,
                0x7C,
                0x76,
                0xE5,
                0x5A,
                0x45,
                0x8B,
                0xC7,
                0xF6,
                0xEC,
                0x68,
                0xD6,
                0xF0,
                0x63,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAccessibilityDockingServiceCallback
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xFD,
                0x33,
                0x77,
                0x15,
                0x92,
                0xA5,
                0xE5,
                0x42,
                0xB5,
                0x94,
                0x24,
                0x84,
                0x68,
                0xC5,
                0xA8,
                0x1B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAccessibilityDockingService
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x22,
                0xDC,
                0x49,
                0x88,
                0xDF,
                0xCE,
                0x95,
                0x4C,
                0x99,
                0x8D,
                0x05,
                0x14,
                0x19,
                0xDD,
                0x3F,
                0x76,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IStorageProviderBanners
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD7,
                0x46,
                0xFB,
                0x5E,
                0xC0,
                0x47,
                0x68,
                0x4B,
                0xAC,
                0xDA,
                0xDE,
                0xD4,
                0x7C,
                0x90,
                0xEC,
                0x91,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IStorageProviderCopyHook
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA9,
                0x92,
                0xF9,
                0x7B,
                0x7A,
                0xAF,
                0xBA,
                0x4D,
                0xB2,
                0xE5,
                0x4D,
                0x08,
                0x0B,
                0x1E,
                0xCB,
                0xC6,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
