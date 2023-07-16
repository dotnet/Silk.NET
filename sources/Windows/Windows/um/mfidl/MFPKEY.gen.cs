// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;
public static partial class MFPKEY
{
    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY MFPKEY_SourceOpenMonitor
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x37,
                0x46,
                0x4D,
                0x07,
                0xAE,
                0xB5,
                0x5D,
                0x46,
                0xAF,
                0x17,
                0x1A,
                0x53,
                0x8D,
                0x28,
                0x59,
                0xDD,
                0x02,
                0x00,
                0x00,
                0x00
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY MFPKEY_ASFMediaSource_ApproxSeek
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x0F,
                0x27,
                0xCD,
                0xB4,
                0x4D,
                0x24,
                0x69,
                0x49,
                0xBB,
                0x92,
                0x3F,
                0x0F,
                0xB8,
                0x31,
                0x6F,
                0x10,
                0x01,
                0x00,
                0x00,
                0x00
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY MFPKEY_ASFMediaSource_IterativeSeekIfNoIndex
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xDC,
                0x65,
                0x0B,
                0x17,
                0x4E,
                0x4A,
                0x7A,
                0x40,
                0xAC,
                0x22,
                0x57,
                0x7F,
                0x50,
                0xE4,
                0xA3,
                0x7C,
                0x01,
                0x00,
                0x00,
                0x00
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY MFPKEY_ASFMediaSource_IterativeSeek_Max_Count
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xDC,
                0x65,
                0x0B,
                0x17,
                0x4E,
                0x4A,
                0x7A,
                0x40,
                0xAC,
                0x22,
                0x57,
                0x7F,
                0x50,
                0xE4,
                0xA3,
                0x7C,
                0x02,
                0x00,
                0x00,
                0x00
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY MFPKEY_ASFMediaSource_IterativeSeek_Tolerance_In_MilliSecond
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xDC,
                0x65,
                0x0B,
                0x17,
                0x4E,
                0x4A,
                0x7A,
                0x40,
                0xAC,
                0x22,
                0x57,
                0x7F,
                0x50,
                0xE4,
                0xA3,
                0x7C,
                0x03,
                0x00,
                0x00,
                0x00
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY MFPKEY_Content_DLNA_Profile_ID
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x45,
                0x1B,
                0xA3,
                0xCF,
                0x5D,
                0x52,
                0x98,
                0x49,
                0xBB,
                0x44,
                0x3F,
                0x7D,
                0x81,
                0x54,
                0x2F,
                0xA4,
                0x01,
                0x00,
                0x00,
                0x00
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY MFPKEY_MediaSource_DisableReadAhead
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x14,
                0x6C,
                0x36,
                0x26,
                0xBF,
                0xC5,
                0x76,
                0x4C,
                0x88,
                0x7B,
                0x9F,
                0x17,
                0x54,
                0xDB,
                0x5F,
                0x09,
                0x01,
                0x00,
                0x00,
                0x00
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY MFPKEY_SBESourceMode
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xBB,
                0x10,
                0xAE,
                0x3F,
                0x59,
                0xF8,
                0x92,
                0x41,
                0xB5,
                0x62,
                0x18,
                0x68,
                0xD3,
                0xDA,
                0x3A,
                0x02,
                0x01,
                0x00,
                0x00,
                0x00
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY MFPKEY_PMP_Creation_Callback
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xE2,
                0x4D,
                0xBB,
                0x28,
                0xA2,
                0x26,
                0x70,
                0x48,
                0xB7,
                0x20,
                0xD2,
                0x6B,
                0xBE,
                0xB1,
                0x49,
                0x42,
                0x01,
                0x00,
                0x00,
                0x00
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY MFPKEY_HTTP_ByteStream_Enable_Urlmon
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xDF,
                0xAF,
                0xA8,
                0xED,
                0x71,
                0xC1,
                0x7F,
                0x41,
                0x8D,
                0x17,
                0x2E,
                0x09,
                0x18,
                0x30,
                0x32,
                0x92,
                0x01,
                0x00,
                0x00,
                0x00
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY MFPKEY_HTTP_ByteStream_Urlmon_Bind_Flags
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xDF,
                0xAF,
                0xA8,
                0xED,
                0x71,
                0xC1,
                0x7F,
                0x41,
                0x8D,
                0x17,
                0x2E,
                0x09,
                0x18,
                0x30,
                0x32,
                0x92,
                0x02,
                0x00,
                0x00,
                0x00
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY MFPKEY_HTTP_ByteStream_Urlmon_Security_Id
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xDF,
                0xAF,
                0xA8,
                0xED,
                0x71,
                0xC1,
                0x7F,
                0x41,
                0x8D,
                0x17,
                0x2E,
                0x09,
                0x18,
                0x30,
                0x32,
                0x92,
                0x03,
                0x00,
                0x00,
                0x00
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY MFPKEY_HTTP_ByteStream_Urlmon_Window
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xDF,
                0xAF,
                0xA8,
                0xED,
                0x71,
                0xC1,
                0x7F,
                0x41,
                0x8D,
                0x17,
                0x2E,
                0x09,
                0x18,
                0x30,
                0x32,
                0x92,
                0x04,
                0x00,
                0x00,
                0x00
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY MFPKEY_HTTP_ByteStream_Urlmon_Callback_QueryService
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xDF,
                0xAF,
                0xA8,
                0xED,
                0x71,
                0xC1,
                0x7F,
                0x41,
                0x8D,
                0x17,
                0x2E,
                0x09,
                0x18,
                0x30,
                0x32,
                0x92,
                0x05,
                0x00,
                0x00,
                0x00
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY MFPKEY_MediaProtectionSystemId
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x1D,
                0x27,
                0x6B,
                0x63,
                0xC7,
                0xDD,
                0xE9,
                0x49,
                0xA6,
                0xC6,
                0x47,
                0x38,
                0x59,
                0x62,
                0xE5,
                0xBD,
                0x01,
                0x00,
                0x00,
                0x00
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY MFPKEY_MediaProtectionSystemContext
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x1D,
                0x27,
                0x6B,
                0x63,
                0xC7,
                0xDD,
                0xE9,
                0x49,
                0xA6,
                0xC6,
                0x47,
                0x38,
                0x59,
                0x62,
                0xE5,
                0xBD,
                0x02,
                0x00,
                0x00,
                0x00
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY MFPKEY_MediaProtectionSystemIdMapping
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x1D,
                0x27,
                0x6B,
                0x63,
                0xC7,
                0xDD,
                0xE9,
                0x49,
                0xA6,
                0xC6,
                0x47,
                0x38,
                0x59,
                0x62,
                0xE5,
                0xBD,
                0x03,
                0x00,
                0x00,
                0x00
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY MFPKEY_MediaProtectionContainerGuid
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x7C,
                0x3D,
                0xAF,
                0x42,
                0xCF,
                0x00,
                0x0F,
                0x4A,
                0x81,
                0xF0,
                0xAD,
                0xF5,
                0x24,
                0xA5,
                0xA5,
                0xB5,
                0x01,
                0x00,
                0x00,
                0x00
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY MFPKEY_MediaProtectionSystemContextsPerTrack
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x92,
                0xB0,
                0x54,
                0x44,
                0xDA,
                0xD3,
                0xB0,
                0x49,
                0x84,
                0x52,
                0x68,
                0x50,
                0xC7,
                0xDB,
                0x76,
                0x4D,
                0x03,
                0x00,
                0x00,
                0x00
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY MFPKEY_HTTP_ByteStream_Download_Mode
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xB7,
                0x11,
                0x7F,
                0x81,
                0x82,
                0xA9,
                0xEC,
                0x46,
                0xA4,
                0x49,
                0xEF,
                0x58,
                0xAE,
                0xD5,
                0x3C,
                0xA8,
                0x01,
                0x00,
                0x00,
                0x00
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY MFPKEY_HTTP_ByteStream_Caching_Mode
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x3E,
                0x40,
                0xA2,
                0x86,
                0x8B,
                0xC7,
                0xD7,
                0x44,
                0x8B,
                0xC8,
                0xFF,
                0x72,
                0x58,
                0x11,
                0x75,
                0x08,
                0x01,
                0x00,
                0x00,
                0x00
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY MFPKEY_HTTP_ByteStream_Cache_Limit
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x3E,
                0x40,
                0xA2,
                0x86,
                0x8B,
                0xC7,
                0xD7,
                0x44,
                0x8B,
                0xC8,
                0xFF,
                0x72,
                0x58,
                0x11,
                0x75,
                0x08,
                0x02,
                0x00,
                0x00,
                0x00
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }
}