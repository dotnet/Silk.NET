// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShlGuid.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;
public static partial class Windows
{
    [NativeTypeName("const GUID")]
    public static ref readonly Guid CGID_Explorer
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xD0,
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

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CGID_ShellDocView
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xD1,
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

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CGID_ShellServiceObject
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xD2,
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

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CGID_ExplorerBarDoc
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xD3,
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

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CGID_DefView
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x10,
                0x7F,
                0xF0,
                0x4A,
                0x31,
                0xD2,
                0xD0,
                0x11,
                0xB9,
                0x42,
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

    [NativeTypeName("const GUID")]
    public static ref readonly Guid VID_LargeIcons
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xE0,
                0xD0,
                0x57,
                0x00,
                0x73,
                0x35,
                0xCF,
                0x11,
                0xAE,
                0x69,
                0x08,
                0x00,
                0x2B,
                0x2E,
                0x12,
                0x62
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid VID_SmallIcons
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xC0,
                0x00,
                0x90,
                0x08,
                0x73,
                0x35,
                0xCF,
                0x11,
                0xAE,
                0x69,
                0x08,
                0x00,
                0x2B,
                0x2E,
                0x12,
                0x62
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid VID_List
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xE0,
                0xA5,
                0x1F,
                0x0E,
                0x73,
                0x35,
                0xCF,
                0x11,
                0xAE,
                0x69,
                0x08,
                0x00,
                0x2B,
                0x2E,
                0x12,
                0x62
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid VID_Details
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x00,
                0x77,
                0x7E,
                0x13,
                0x73,
                0x35,
                0xCF,
                0x11,
                0xAE,
                0x69,
                0x08,
                0x00,
                0x2B,
                0x2E,
                0x12,
                0x62
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid VID_Tile
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xE5,
                0x25,
                0xF1,
                0x65,
                0xE1,
                0x7B,
                0x10,
                0x48,
                0xBA,
                0x9D,
                0xD2,
                0x71,
                0xC8,
                0x43,
                0x2C,
                0xE3
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid VID_Content
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x34,
                0xC4,
                0xC2,
                0x30,
                0x89,
                0x08,
                0x8D,
                0x4C,
                0x98,
                0x5D,
                0xA9,
                0xF7,
                0x18,
                0x30,
                0xB0,
                0xA9
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid VID_Thumbnails
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x90,
                0xB2,
                0xEB,
                0x8B,
                0xD0,
                0x52,
                0xD0,
                0x11,
                0xB7,
                0xF4,
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

    [NativeTypeName("const GUID")]
    public static ref readonly Guid VID_ThumbStrip
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x24,
                0xA6,
                0xEF,
                0x8E,
                0xE9,
                0xD1,
                0x5B,
                0x44,
                0x94,
                0xB7,
                0x74,
                0xFB,
                0xCE,
                0x2E,
                0xA1,
                0x1A
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CGID_ShortCut
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x50,
                0x87,
                0xA6,
                0x93,
                0x1A,
                0x95,
                0xD1,
                0x11,
                0x94,
                0x6F,
                0x00,
                0x00,
                0x00,
                0x00,
                0x00,
                0x00
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CGID_MENUDESKBAR
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x12,
                0x0A,
                0x9F,
                0x5C,
                0x9E,
                0x95,
                0xD0,
                0x11,
                0xA3,
                0xA4,
                0x00,
                0xA0,
                0xC9,
                0x08,
                0x26,
                0x36
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CPFG_LOGON_USERNAME
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xE8,
                0xBB,
                0x15,
                0xDA,
                0x4D,
                0x95,
                0xD3,
                0x4F,
                0xB0,
                0xF4,
                0x1F,
                0xB5,
                0xB9,
                0x0B,
                0x17,
                0x4B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CPFG_LOGON_PASSWORD
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xFA,
                0x4C,
                0x62,
                0x60,
                0x77,
                0xA4,
                0xB1,
                0x47,
                0x8A,
                0x8E,
                0x3A,
                0x4A,
                0x19,
                0x98,
                0x18,
                0x27
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CPFG_SMARTCARD_USERNAME
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x69,
                0xCF,
                0x1E,
                0x3E,
                0x8C,
                0x56,
                0x96,
                0x4D,
                0x9D,
                0x59,
                0x46,
                0x44,
                0x41,
                0x74,
                0xE2,
                0xD6
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CPFG_SMARTCARD_PIN
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x3B,
                0x26,
                0xE5,
                0x4F,
                0x81,
                0x91,
                0xC1,
                0x46,
                0xB0,
                0xA4,
                0x9D,
                0xED,
                0xD4,
                0xDB,
                0x7D,
                0xEA
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CPFG_CREDENTIAL_PROVIDER_LOGO
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x75,
                0x77,
                0x83,
                0x2D,
                0xCD,
                0xF6,
                0x4E,
                0x46,
                0xA7,
                0x45,
                0x48,
                0x2F,
                0xD0,
                0xB4,
                0x74,
                0x93
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CPFG_CREDENTIAL_PROVIDER_LABEL
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xF3,
                0xBF,
                0x6B,
                0x28,
                0xD4,
                0xBA,
                0x8F,
                0x43,
                0xB0,
                0x07,
                0x79,
                0xB7,
                0x26,
                0x7C,
                0x3D,
                0x48
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CPFG_STANDALONE_SUBMIT_BUTTON
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xD8,
                0x0A,
                0x7B,
                0x0B,
                0x36,
                0xCC,
                0x59,
                0x4D,
                0x80,
                0x2B,
                0x82,
                0xF7,
                0x14,
                0xFA,
                0x70,
                0x22
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CPFG_STYLE_LINK_AS_BUTTON
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x08,
                0xA5,
                0x8F,
                0x08,
                0xA6,
                0x94,
                0x30,
                0x44,
                0xA4,
                0xCB,
                0x6F,
                0xC6,
                0xE3,
                0xC0,
                0xB9,
                0xE2
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid ItemCount_Property_GUID
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x45,
                0x5C,
                0xBF,
                0xAB,
                0xCC,
                0x5C,
                0xB7,
                0x47,
                0xBB,
                0x4E,
                0x87,
                0xCB,
                0x87,
                0xBB,
                0xD1,
                0x62
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid SelectedItemCount_Property_GUID
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xD2,
                0x16,
                0xE3,
                0x8F,
                0x52,
                0x0E,
                0x0A,
                0x46,
                0x9C,
                0x1E,
                0x48,
                0xF2,
                0x73,
                0xD4,
                0x70,
                0xA3
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid ItemIndex_Property_GUID
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xDA,
                0x53,
                0xA0,
                0x92,
                0x69,
                0x29,
                0x21,
                0x40,
                0xBF,
                0x27,
                0x51,
                0x4C,
                0xFC,
                0x2E,
                0x4A,
                0x69
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("#define PIDSI_ARTIST 2")]
    public const int PIDSI_ARTIST = 2;
    [NativeTypeName("#define PIDSI_SONGTITLE 3")]
    public const int PIDSI_SONGTITLE = 3;
    [NativeTypeName("#define PIDSI_ALBUM 4")]
    public const int PIDSI_ALBUM = 4;
    [NativeTypeName("#define PIDSI_YEAR 5")]
    public const int PIDSI_YEAR = 5;
    [NativeTypeName("#define PIDSI_COMMENT 6")]
    public const int PIDSI_COMMENT = 6;
    [NativeTypeName("#define PIDSI_TRACK 7")]
    public const int PIDSI_TRACK = 7;
    [NativeTypeName("#define PIDSI_GENRE 11")]
    public const int PIDSI_GENRE = 11;
    [NativeTypeName("#define PIDSI_LYRICS 12")]
    public const int PIDSI_LYRICS = 12;
    [NativeTypeName("#define PIDDRSI_PROTECTED 2")]
    public const int PIDDRSI_PROTECTED = 2;
    [NativeTypeName("#define PIDDRSI_DESCRIPTION 3")]
    public const int PIDDRSI_DESCRIPTION = 3;
    [NativeTypeName("#define PIDDRSI_PLAYCOUNT 4")]
    public const int PIDDRSI_PLAYCOUNT = 4;
    [NativeTypeName("#define PIDDRSI_PLAYSTARTS 5")]
    public const int PIDDRSI_PLAYSTARTS = 5;
    [NativeTypeName("#define PIDDRSI_PLAYEXPIRES 6")]
    public const int PIDDRSI_PLAYEXPIRES = 6;
    [NativeTypeName("#define PIDASI_FORMAT 0x00000002")]
    public const int PIDASI_FORMAT = 0x00000002;
    [NativeTypeName("#define PIDASI_TIMELENGTH 0x00000003")]
    public const int PIDASI_TIMELENGTH = 0x00000003;
    [NativeTypeName("#define PIDASI_AVG_DATA_RATE 0x00000004")]
    public const int PIDASI_AVG_DATA_RATE = 0x00000004;
    [NativeTypeName("#define PIDASI_SAMPLE_RATE 0x00000005")]
    public const int PIDASI_SAMPLE_RATE = 0x00000005;
    [NativeTypeName("#define PIDASI_SAMPLE_SIZE 0x00000006")]
    public const int PIDASI_SAMPLE_SIZE = 0x00000006;
    [NativeTypeName("#define PIDASI_CHANNEL_COUNT 0x00000007")]
    public const int PIDASI_CHANNEL_COUNT = 0x00000007;
    [NativeTypeName("#define PIDASI_STREAM_NUMBER 0x00000008")]
    public const int PIDASI_STREAM_NUMBER = 0x00000008;
    [NativeTypeName("#define PIDASI_STREAM_NAME 0x00000009")]
    public const int PIDASI_STREAM_NAME = 0x00000009;
    [NativeTypeName("#define PIDASI_COMPRESSION 0x0000000A")]
    public const int PIDASI_COMPRESSION = 0x0000000A;
}