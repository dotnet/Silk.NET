// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShlGuid.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class FOLDERTYPEID
{
    [NativeTypeName("const GUID")]
    public static ref readonly Guid FOLDERTYPEID_Invalid
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x98,
                0x78,
                0x80,
                0x57,
                0x4F,
                0x8C,
                0x62,
                0x44,
                0xBB,
                0x63,
                0x71,
                0x04,
                0x23,
                0x80,
                0xB1,
                0x09,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid FOLDERTYPEID_Generic
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB5,
                0x28,
                0x4F,
                0x5C,
                0x69,
                0xF8,
                0x84,
                0x4E,
                0x8E,
                0x60,
                0xF1,
                0x1D,
                0xB9,
                0x7C,
                0x5C,
                0xC7,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid FOLDERTYPEID_GenericSearchResults
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x1E,
                0x1A,
                0xDE,
                0x7F,
                0x31,
                0x8B,
                0xA5,
                0x49,
                0x93,
                0xB8,
                0x6B,
                0xE1,
                0x4C,
                0xFA,
                0x49,
                0x43,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid FOLDERTYPEID_GenericLibrary
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x9A,
                0xAB,
                0x4E,
                0x5F,
                0x33,
                0x68,
                0x61,
                0x4F,
                0x89,
                0x9D,
                0x31,
                0xCF,
                0x46,
                0x97,
                0x9D,
                0x49,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid FOLDERTYPEID_Documents
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x26,
                0xD7,
                0x49,
                0x7D,
                0x21,
                0x3C,
                0x05,
                0x4F,
                0x99,
                0xAA,
                0xFD,
                0xC2,
                0xC9,
                0x47,
                0x46,
                0x56,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid FOLDERTYPEID_Pictures
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x58,
                0x0E,
                0x69,
                0xB3,
                0x61,
                0xE9,
                0x3B,
                0x42,
                0xB6,
                0x87,
                0x38,
                0x6E,
                0xBF,
                0xD8,
                0x32,
                0x39,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid FOLDERTYPEID_Music
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xCC,
                0xDD,
                0xD6,
                0x94,
                0x68,
                0x4A,
                0x75,
                0x41,
                0xA3,
                0x74,
                0xBD,
                0x58,
                0x4A,
                0x51,
                0x0B,
                0x78,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid FOLDERTYPEID_Videos
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x07,
                0x64,
                0xA9,
                0x5F,
                0x77,
                0x7E,
                0x3C,
                0x48,
                0xAC,
                0x93,
                0x69,
                0x1D,
                0x05,
                0x85,
                0x0D,
                0xE8,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid FOLDERTYPEID_Downloads
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x6E,
                0x18,
                0x5A,
                0x88,
                0x40,
                0xA4,
                0xDA,
                0x4A,
                0x81,
                0x2B,
                0xDB,
                0x87,
                0x1B,
                0x94,
                0x22,
                0x59,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid FOLDERTYPEID_UserFiles
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x9B,
                0xC6,
                0x0F,
                0xCD,
                0xE2,
                0x71,
                0xE5,
                0x46,
                0x96,
                0x90,
                0x5B,
                0xCD,
                0x9F,
                0x57,
                0xAA,
                0xB3,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid FOLDERTYPEID_UsersLibraries
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x09,
                0x8F,
                0xD9,
                0xC4,
                0x24,
                0x61,
                0xE0,
                0x4F,
                0x99,
                0x42,
                0x82,
                0x64,
                0x16,
                0x08,
                0x2D,
                0xA9,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid FOLDERTYPEID_OtherUsers
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x00,
                0xFD,
                0x37,
                0xB3,
                0xD5,
                0x9D,
                0x35,
                0x46,
                0xA6,
                0xD4,
                0xDA,
                0x33,
                0xFD,
                0x10,
                0x2B,
                0x7A,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid FOLDERTYPEID_PublishedItems
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x96,
                0x5B,
                0x2F,
                0x7F,
                0x74,
                0xFF,
                0xDA,
                0x41,
                0xAF,
                0xD8,
                0x1C,
                0x78,
                0xA5,
                0xF3,
                0xAE,
                0xA2,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid FOLDERTYPEID_Communications
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE5,
                0x5F,
                0x47,
                0x91,
                0x6B,
                0x58,
                0xBA,
                0x4E,
                0x8D,
                0x75,
                0xD1,
                0x74,
                0x34,
                0xB8,
                0xCD,
                0xF6,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid FOLDERTYPEID_Contacts
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xEC,
                0x70,
                0x2B,
                0xDE,
                0xF7,
                0x9B,
                0x93,
                0x4A,
                0xBD,
                0x3D,
                0x24,
                0x3F,
                0x78,
                0x81,
                0xD4,
                0x92,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid FOLDERTYPEID_StartMenu
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xCB,
                0xB4,
                0x87,
                0xEF,
                0xCE,
                0xF2,
                0x85,
                0x47,
                0x86,
                0x58,
                0x4C,
                0xA6,
                0xC6,
                0x3E,
                0x38,
                0xC6,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid FOLDERTYPEID_RecordedTV
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x8F,
                0xA2,
                0x57,
                0x55,
                0xA6,
                0x5D,
                0x83,
                0x4F,
                0x88,
                0x09,
                0xC2,
                0xC9,
                0x8A,
                0x11,
                0xA6,
                0xFA,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid FOLDERTYPEID_SavedGames
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x07,
                0x33,
                0x36,
                0xD0,
                0xCB,
                0x28,
                0x06,
                0x41,
                0x9F,
                0x23,
                0x29,
                0x56,
                0xE3,
                0xE5,
                0xE0,
                0xE7,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid FOLDERTYPEID_OpenSearch
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x29,
                0x96,
                0xAF,
                0x8F,
                0x80,
                0x19,
                0xFF,
                0x46,
                0x80,
                0x23,
                0x9D,
                0xCE,
                0xAB,
                0x9C,
                0x3E,
                0xE3,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid FOLDERTYPEID_SearchConnector
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xEE,
                0x25,
                0x27,
                0x98,
                0x47,
                0x6F,
                0x9E,
                0x47,
                0xB4,
                0x47,
                0x81,
                0x2B,
                0xFA,
                0x7D,
                0x2E,
                0x8F,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid FOLDERTYPEID_AccountPictures
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x8F,
                0x5D,
                0x2A,
                0xDB,
                0xE6,
                0x06,
                0x07,
                0x40,
                0xAB,
                0xA6,
                0xAF,
                0x87,
                0x7D,
                0x52,
                0x6E,
                0xA6,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid FOLDERTYPEID_Games
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD0,
                0xB0,
                0x89,
                0xB6,
                0xD3,
                0x76,
                0xBB,
                0x4C,
                0x87,
                0xF7,
                0x58,
                0x5D,
                0x0E,
                0x0C,
                0xE0,
                0x70,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid FOLDERTYPEID_ControlPanelCategory
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x60,
                0x06,
                0x4F,
                0xDE,
                0x10,
                0xFA,
                0x8F,
                0x4B,
                0xA4,
                0x94,
                0x06,
                0x8B,
                0x20,
                0xB2,
                0x23,
                0x07,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid FOLDERTYPEID_ControlPanelClassic
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF3,
                0x94,
                0x37,
                0x0C,
                0x45,
                0xB5,
                0xAA,
                0x43,
                0xA3,
                0x29,
                0xC3,
                0x74,
                0x30,
                0xC5,
                0x8D,
                0x2A,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid FOLDERTYPEID_Printers
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC6,
                0xBE,
                0x7B,
                0x2C,
                0x44,
                0xC8,
                0x0A,
                0x4A,
                0x91,
                0xFA,
                0xCE,
                0xF6,
                0xF5,
                0x9C,
                0xFD,
                0xA1,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid FOLDERTYPEID_RecycleBin
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x04,
                0xE0,
                0xD9,
                0xD6,
                0x87,
                0xCD,
                0x2B,
                0x44,
                0x9D,
                0x57,
                0x5E,
                0x0A,
                0xEB,
                0x4F,
                0x6F,
                0x72,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid FOLDERTYPEID_SoftwareExplorer
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x1B,
                0x39,
                0x74,
                0xD6,
                0xD9,
                0x52,
                0x07,
                0x4E,
                0x83,
                0x4E,
                0x67,
                0xC9,
                0x86,
                0x10,
                0xF3,
                0x9D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid FOLDERTYPEID_CompressedFolder
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x82,
                0x3E,
                0x21,
                0x80,
                0xFD,
                0xBC,
                0x4F,
                0x4C,
                0x88,
                0x17,
                0xBB,
                0x27,
                0x60,
                0x12,
                0x67,
                0xA9,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid FOLDERTYPEID_NetworkExplorer
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x2B,
                0x24,
                0xCC,
                0x25,
                0x7C,
                0x9A,
                0x51,
                0x4F,
                0x80,
                0xE0,
                0x7A,
                0x29,
                0x28,
                0xFE,
                0xBE,
                0x42,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid FOLDERTYPEID_Searches
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE3,
                0xA2,
                0x0B,
                0x0B,
                0x5F,
                0x40,
                0x5E,
                0x41,
                0xA6,
                0xEE,
                0xCA,
                0xD6,
                0x25,
                0x20,
                0x78,
                0x53,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid FOLDERTYPEID_SearchHome
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x44,
                0x8A,
                0x4D,
                0x83,
                0x74,
                0x09,
                0xD6,
                0x4E,
                0x86,
                0x6E,
                0xF2,
                0x03,
                0xD8,
                0x0B,
                0x38,
                0x10,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid FOLDERTYPEID_StorageProviderGeneric
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC5,
                0xEB,
                0x01,
                0x4F,
                0x85,
                0x23,
                0xF2,
                0x41,
                0xA2,
                0x8E,
                0x2C,
                0x5C,
                0x91,
                0xFB,
                0x56,
                0xE0,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid FOLDERTYPEID_StorageProviderDocuments
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x66,
                0xBD,
                0x61,
                0xDD,
                0xE8,
                0x70,
                0xDD,
                0x48,
                0x96,
                0x55,
                0x65,
                0xC5,
                0xE1,
                0xAA,
                0xC2,
                0xD1,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid FOLDERTYPEID_StorageProviderPictures
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA9,
                0x42,
                0xD6,
                0x71,
                0xB1,
                0xF2,
                0xCD,
                0x42,
                0xAD,
                0x92,
                0xEB,
                0x93,
                0x00,
                0xC7,
                0xCC,
                0x0A,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid FOLDERTYPEID_StorageProviderMusic
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x7E,
                0xCD,
                0x2E,
                0x67,
                0x04,
                0xAF,
                0x99,
                0x43,
                0x87,
                0x5C,
                0x02,
                0x90,
                0x84,
                0x5B,
                0x62,
                0x47,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid FOLDERTYPEID_StorageProviderVideos
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA1,
                0x4D,
                0x29,
                0x51,
                0xB1,
                0xD7,
                0x5B,
                0x48,
                0x9E,
                0x9A,
                0x17,
                0xCF,
                0xFE,
                0x33,
                0xE1,
                0x87,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid FOLDERTYPEID_VersionControl
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x6B,
                0xE2,
                0xF1,
                0x69,
                0x64,
                0xEC,
                0x80,
                0x42,
                0xBC,
                0x83,
                0xF1,
                0xEB,
                0x88,
                0x7E,
                0xC3,
                0x5A,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
