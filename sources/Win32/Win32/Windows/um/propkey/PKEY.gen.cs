// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/propkey.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class PKEY
{
    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Address_Country
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x99,
                0x41,
                0x7B,
                0xC0,
                0xDF,
                0xE1,
                0x93,
                0x44,
                0xB1,
                0xE1,
                0xDE,
                0x59,
                0x46,
                0xFB,
                0x58,
                0xF8,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Address_CountryCode
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x99,
                0x41,
                0x7B,
                0xC0,
                0xDF,
                0xE1,
                0x93,
                0x44,
                0xB1,
                0xE1,
                0xDE,
                0x59,
                0x46,
                0xFB,
                0x58,
                0xF8,
                0x65,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Address_Region
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x99,
                0x41,
                0x7B,
                0xC0,
                0xDF,
                0xE1,
                0x93,
                0x44,
                0xB1,
                0xE1,
                0xDE,
                0x59,
                0x46,
                0xFB,
                0x58,
                0xF8,
                0x66,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Address_RegionCode
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x99,
                0x41,
                0x7B,
                0xC0,
                0xDF,
                0xE1,
                0x93,
                0x44,
                0xB1,
                0xE1,
                0xDE,
                0x59,
                0x46,
                0xFB,
                0x58,
                0xF8,
                0x67,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Address_Town
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x99,
                0x41,
                0x7B,
                0xC0,
                0xDF,
                0xE1,
                0x93,
                0x44,
                0xB1,
                0xE1,
                0xDE,
                0x59,
                0x46,
                0xFB,
                0x58,
                0xF8,
                0x68,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Audio_ChannelCount
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x90,
                0x04,
                0x44,
                0x64,
                0x8B,
                0x4C,
                0xD1,
                0x11,
                0x8B,
                0x70,
                0x08,
                0x00,
                0x36,
                0xB1,
                0x1A,
                0x03,
                0x07,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Audio_Compression
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x90,
                0x04,
                0x44,
                0x64,
                0x8B,
                0x4C,
                0xD1,
                0x11,
                0x8B,
                0x70,
                0x08,
                0x00,
                0x36,
                0xB1,
                0x1A,
                0x03,
                0x0A,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Audio_EncodingBitrate
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x90,
                0x04,
                0x44,
                0x64,
                0x8B,
                0x4C,
                0xD1,
                0x11,
                0x8B,
                0x70,
                0x08,
                0x00,
                0x36,
                0xB1,
                0x1A,
                0x03,
                0x04,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Audio_Format
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x90,
                0x04,
                0x44,
                0x64,
                0x8B,
                0x4C,
                0xD1,
                0x11,
                0x8B,
                0x70,
                0x08,
                0x00,
                0x36,
                0xB1,
                0x1A,
                0x03,
                0x02,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Audio_IsVariableBitRate
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xEE,
                0x2F,
                0x82,
                0xE6,
                0x17,
                0x8C,
                0x62,
                0x4D,
                0x82,
                0x3C,
                0x8E,
                0x9C,
                0xFC,
                0xBD,
                0x1D,
                0x5C,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Audio_PeakValue
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD0,
                0xE5,
                0x79,
                0x25,
                0x16,
                0x11,
                0x84,
                0x40,
                0xBD,
                0x9A,
                0x9B,
                0x4F,
                0x7C,
                0xB4,
                0xDF,
                0x5E,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Audio_SampleRate
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x90,
                0x04,
                0x44,
                0x64,
                0x8B,
                0x4C,
                0xD1,
                0x11,
                0x8B,
                0x70,
                0x08,
                0x00,
                0x36,
                0xB1,
                0x1A,
                0x03,
                0x05,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Audio_SampleSize
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x90,
                0x04,
                0x44,
                0x64,
                0x8B,
                0x4C,
                0xD1,
                0x11,
                0x8B,
                0x70,
                0x08,
                0x00,
                0x36,
                0xB1,
                0x1A,
                0x03,
                0x06,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Audio_StreamName
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x90,
                0x04,
                0x44,
                0x64,
                0x8B,
                0x4C,
                0xD1,
                0x11,
                0x8B,
                0x70,
                0x08,
                0x00,
                0x36,
                0xB1,
                0x1A,
                0x03,
                0x09,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Audio_StreamNumber
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x90,
                0x04,
                0x44,
                0x64,
                0x8B,
                0x4C,
                0xD1,
                0x11,
                0x8B,
                0x70,
                0x08,
                0x00,
                0x36,
                0xB1,
                0x1A,
                0x03,
                0x08,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Calendar_Duration
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x5A,
                0xA3,
                0x3C,
                0x29,
                0xAA,
                0x09,
                0xD2,
                0x4D,
                0xB1,
                0x80,
                0x1F,
                0xE2,
                0x45,
                0x72,
                0x8A,
                0x52,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Calendar_IsOnline
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x49,
                0x91,
                0xEE,
                0xBF,
                0xE2,
                0xE3,
                0xA7,
                0x49,
                0xA8,
                0x62,
                0xC0,
                0x59,
                0x88,
                0x14,
                0x5C,
                0xEC,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Calendar_IsRecurring
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x8D,
                0x9C,
                0x5B,
                0x31,
                0xA9,
                0x80,
                0xF9,
                0x4E,
                0xAE,
                0x16,
                0x8E,
                0x74,
                0x6D,
                0xA5,
                0x1D,
                0x70,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Calendar_Location
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x18,
                0x2D,
                0x27,
                0xF6,
                0xCC,
                0xCE,
                0xB1,
                0x40,
                0xB2,
                0x6A,
                0x39,
                0x11,
                0x71,
                0x7A,
                0xA7,
                0xBD,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Calendar_OptionalAttendeeAddresses
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x5A,
                0xAE,
                0x5B,
                0xD5,
                0x92,
                0x38,
                0x7A,
                0x41,
                0xA6,
                0x49,
                0xC6,
                0xAC,
                0x5A,
                0xAA,
                0xEA,
                0xB3,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Calendar_OptionalAttendeeNames
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x07,
                0x96,
                0x42,
                0x09,
                0x2D,
                0x58,
                0x7F,
                0x43,
                0x84,
                0xC3,
                0xDE,
                0x93,
                0xA2,
                0xB2,
                0x4C,
                0x3C,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Calendar_OrganizerAddress
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x42,
                0x82,
                0x4C,
                0x74,
                0xF5,
                0x4D,
                0x6C,
                0x45,
                0xAB,
                0x9E,
                0x01,
                0x4E,
                0xFB,
                0x90,
                0x21,
                0xE3,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Calendar_OrganizerName
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF9,
                0x60,
                0xA6,
                0xAA,
                0x65,
                0x98,
                0x8E,
                0x45,
                0xB4,
                0x84,
                0x01,
                0xBC,
                0x7F,
                0xE3,
                0x97,
                0x3E,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Calendar_ReminderTime
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA4,
                0x5B,
                0xFC,
                0x72,
                0xF9,
                0x24,
                0x11,
                0x40,
                0x9F,
                0x3F,
                0xAD,
                0xD2,
                0x7A,
                0xFA,
                0xD8,
                0x18,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Calendar_RequiredAttendeeAddresses
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC3,
                0xD6,
                0xA7,
                0x0B,
                0x8D,
                0x56,
                0x59,
                0x41,
                0xAB,
                0x91,
                0x78,
                0x1A,
                0x91,
                0xFB,
                0x71,
                0xE5,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Calendar_RequiredAttendeeNames
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x0B,
                0xF3,
                0x3A,
                0xB3,
                0x52,
                0xF5,
                0x84,
                0x45,
                0x93,
                0x6C,
                0xCB,
                0x93,
                0xE5,
                0xCD,
                0xA2,
                0x9F,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Calendar_Resources
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x38,
                0x8A,
                0xF5,
                0x00,
                0x4B,
                0xC5,
                0x40,
                0x4C,
                0x86,
                0x96,
                0x97,
                0x23,
                0x59,
                0x80,
                0xEA,
                0xE1,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Calendar_ResponseStatus
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x91,
                0x1F,
                0x8C,
                0x18,
                0x40,
                0x3C,
                0x32,
                0x41,
                0x9E,
                0xC5,
                0xD8,
                0xB0,
                0x3B,
                0x72,
                0xA8,
                0xA2,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Calendar_ShowTimeAs
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD4,
                0x96,
                0xF3,
                0x5B,
                0xB2,
                0x5E,
                0x6F,
                0x46,
                0xBD,
                0xE9,
                0x2F,
                0xB3,
                0xF2,
                0x36,
                0x1D,
                0x6E,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Calendar_ShowTimeAsText
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xCF,
                0x57,
                0xDA,
                0x53,
                0xC0,
                0x62,
                0xC4,
                0x45,
                0x81,
                0xDE,
                0x76,
                0x10,
                0xBC,
                0xEF,
                0xD7,
                0xF5,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Communication_AccountName
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x4C,
                0x58,
                0xE0,
                0xE3,
                0x88,
                0xB7,
                0x5A,
                0x4A,
                0xBB,
                0x20,
                0x7F,
                0x5A,
                0x44,
                0xC9,
                0xAC,
                0xDD,
                0x09,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Communication_DateItemExpires
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xAC,
                0x40,
                0x80,
                0x42,
                0x77,
                0xA1,
                0x8A,
                0x4C,
                0x97,
                0x60,
                0xF6,
                0xF7,
                0x61,
                0x22,
                0x7F,
                0x9A,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Communication_Direction
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x30,
                0x10,
                0x53,
                0x8E,
                0x60,
                0xB9,
                0x46,
                0x43,
                0xAE,
                0x0D,
                0x66,
                0xBC,
                0x9A,
                0x86,
                0xFB,
                0x94,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Communication_FollowupIconIndex
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x7E,
                0x34,
                0xA6,
                0x83,
                0xE4,
                0x6F,
                0x40,
                0x4F,
                0xBA,
                0x9C,
                0xC4,
                0x86,
                0x52,
                0x40,
                0xD1,
                0xF4,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Communication_HeaderItem
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x84,
                0x4F,
                0xC3,
                0xC9,
                0x41,
                0x22,
                0x01,
                0x44,
                0xB6,
                0x07,
                0xBD,
                0x20,
                0xED,
                0x75,
                0xAE,
                0x7F,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Communication_PolicyTag
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x91,
                0x41,
                0x0B,
                0xEC,
                0x0B,
                0xAB,
                0x66,
                0x4C,
                0x90,
                0xB6,
                0xC6,
                0x63,
                0x7C,
                0xDE,
                0xBB,
                0xAB,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Communication_SecurityFlags
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB6,
                0xA4,
                0x19,
                0x86,
                0x4D,
                0x9F,
                0x29,
                0x44,
                0x8C,
                0x0F,
                0xB9,
                0x96,
                0xCA,
                0x59,
                0xE3,
                0x35,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Communication_Suffix
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x3A,
                0x65,
                0x7B,
                0x80,
                0x91,
                0x9E,
                0xEF,
                0x43,
                0x8F,
                0x97,
                0x11,
                0xCE,
                0x04,
                0xEE,
                0x20,
                0xC5,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Communication_TaskStatus
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC6,
                0x72,
                0x1A,
                0xBE,
                0x1D,
                0x9A,
                0xB7,
                0x46,
                0xAF,
                0xE7,
                0xAF,
                0xAF,
                0x8C,
                0xEF,
                0x49,
                0x99,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Communication_TaskStatusText
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x77,
                0x44,
                0x74,
                0xA6,
                0x37,
                0xC2,
                0x5B,
                0x47,
                0xA0,
                0x75,
                0x54,
                0xF3,
                0x44,
                0x98,
                0x29,
                0x2A,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Computer_DecoratedFreeSpace
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x35,
                0x4B,
                0x17,
                0x9B,
                0xFF,
                0x40,
                0xD2,
                0x11,
                0xA2,
                0x7E,
                0x00,
                0xC0,
                0x4F,
                0xC3,
                0x08,
                0x71,
                0x07,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Contact_AccountPictureDynamicVideo
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x18,
                0xB0,
                0x8B,
                0x0B,
                0x25,
                0x27,
                0x44,
                0x4B,
                0x92,
                0xBA,
                0x79,
                0x33,
                0xAE,
                0xB2,
                0xDD,
                0xE7,
                0x02,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Contact_AccountPictureLarge
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x18,
                0xB0,
                0x8B,
                0x0B,
                0x25,
                0x27,
                0x44,
                0x4B,
                0x92,
                0xBA,
                0x79,
                0x33,
                0xAE,
                0xB2,
                0xDD,
                0xE7,
                0x03,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Contact_AccountPictureSmall
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x18,
                0xB0,
                0x8B,
                0x0B,
                0x25,
                0x27,
                0x44,
                0x4B,
                0x92,
                0xBA,
                0x79,
                0x33,
                0xAE,
                0xB2,
                0xDD,
                0xE7,
                0x04,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Contact_Anniversary
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xDB,
                0xBA,
                0xD5,
                0x9A,
                0xA7,
                0xCE,
                0x70,
                0x44,
                0xA0,
                0x3D,
                0xB8,
                0x4E,
                0x51,
                0xB9,
                0x94,
                0x9E,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Contact_AssistantName
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x9C,
                0x2C,
                0x10,
                0xCD,
                0x40,
                0x55,
                0x88,
                0x4A,
                0xA6,
                0xF6,
                0x64,
                0xE4,
                0x98,
                0x1C,
                0x8C,
                0xD1,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Contact_AssistantTelephone
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x4D,
                0x24,
                0x93,
                0x9A,
                0xAD,
                0xA7,
                0xF8,
                0x4F,
                0x9B,
                0x99,
                0x45,
                0xEE,
                0x4C,
                0xC0,
                0x9A,
                0xF6,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Contact_Birthday
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x3C,
                0xC6,
                0x6D,
                0x17,
                0x88,
                0x26,
                0x89,
                0x4E,
                0x81,
                0x43,
                0xA3,
                0x47,
                0x80,
                0x0F,
                0x25,
                0xE9,
                0x2F,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Contact_BusinessAddress
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xDD,
                0xB6,
                0x0F,
                0x73,
                0x7C,
                0xCF,
                0x6B,
                0x42,
                0xA0,
                0x3F,
                0xBD,
                0x16,
                0x6C,
                0xC9,
                0xEE,
                0x24,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Contact_BusinessAddress1Country
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x96,
                0xF5,
                0xB6,
                0xA7,
                0x78,
                0xD6,
                0xC1,
                0x4B,
                0xB0,
                0x5F,
                0x02,
                0x03,
                0xD2,
                0x7E,
                0x8A,
                0xA1,
                0x77,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Contact_BusinessAddress1Locality
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x96,
                0xF5,
                0xB6,
                0xA7,
                0x78,
                0xD6,
                0xC1,
                0x4B,
                0xB0,
                0x5F,
                0x02,
                0x03,
                0xD2,
                0x7E,
                0x8A,
                0xA1,
                0x75,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Contact_BusinessAddress1PostalCode
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x96,
                0xF5,
                0xB6,
                0xA7,
                0x78,
                0xD6,
                0xC1,
                0x4B,
                0xB0,
                0x5F,
                0x02,
                0x03,
                0xD2,
                0x7E,
                0x8A,
                0xA1,
                0x78,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Contact_BusinessAddress1Region
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x96,
                0xF5,
                0xB6,
                0xA7,
                0x78,
                0xD6,
                0xC1,
                0x4B,
                0xB0,
                0x5F,
                0x02,
                0x03,
                0xD2,
                0x7E,
                0x8A,
                0xA1,
                0x76,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Contact_BusinessAddress1Street
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x96,
                0xF5,
                0xB6,
                0xA7,
                0x78,
                0xD6,
                0xC1,
                0x4B,
                0xB0,
                0x5F,
                0x02,
                0x03,
                0xD2,
                0x7E,
                0x8A,
                0xA1,
                0x74,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Contact_BusinessAddress2Country
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x96,
                0xF5,
                0xB6,
                0xA7,
                0x78,
                0xD6,
                0xC1,
                0x4B,
                0xB0,
                0x5F,
                0x02,
                0x03,
                0xD2,
                0x7E,
                0x8A,
                0xA1,
                0x7C,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Contact_BusinessAddress2Locality
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x96,
                0xF5,
                0xB6,
                0xA7,
                0x78,
                0xD6,
                0xC1,
                0x4B,
                0xB0,
                0x5F,
                0x02,
                0x03,
                0xD2,
                0x7E,
                0x8A,
                0xA1,
                0x7A,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Contact_BusinessAddress2PostalCode
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x96,
                0xF5,
                0xB6,
                0xA7,
                0x78,
                0xD6,
                0xC1,
                0x4B,
                0xB0,
                0x5F,
                0x02,
                0x03,
                0xD2,
                0x7E,
                0x8A,
                0xA1,
                0x7D,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Contact_BusinessAddress2Region
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x96,
                0xF5,
                0xB6,
                0xA7,
                0x78,
                0xD6,
                0xC1,
                0x4B,
                0xB0,
                0x5F,
                0x02,
                0x03,
                0xD2,
                0x7E,
                0x8A,
                0xA1,
                0x7B,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Contact_BusinessAddress2Street
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x96,
                0xF5,
                0xB6,
                0xA7,
                0x78,
                0xD6,
                0xC1,
                0x4B,
                0xB0,
                0x5F,
                0x02,
                0x03,
                0xD2,
                0x7E,
                0x8A,
                0xA1,
                0x79,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Contact_BusinessAddress3Country
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x96,
                0xF5,
                0xB6,
                0xA7,
                0x78,
                0xD6,
                0xC1,
                0x4B,
                0xB0,
                0x5F,
                0x02,
                0x03,
                0xD2,
                0x7E,
                0x8A,
                0xA1,
                0x81,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Contact_BusinessAddress3Locality
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x96,
                0xF5,
                0xB6,
                0xA7,
                0x78,
                0xD6,
                0xC1,
                0x4B,
                0xB0,
                0x5F,
                0x02,
                0x03,
                0xD2,
                0x7E,
                0x8A,
                0xA1,
                0x7F,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Contact_BusinessAddress3PostalCode
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x96,
                0xF5,
                0xB6,
                0xA7,
                0x78,
                0xD6,
                0xC1,
                0x4B,
                0xB0,
                0x5F,
                0x02,
                0x03,
                0xD2,
                0x7E,
                0x8A,
                0xA1,
                0x82,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Contact_BusinessAddress3Region
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x96,
                0xF5,
                0xB6,
                0xA7,
                0x78,
                0xD6,
                0xC1,
                0x4B,
                0xB0,
                0x5F,
                0x02,
                0x03,
                0xD2,
                0x7E,
                0x8A,
                0xA1,
                0x80,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Contact_BusinessAddress3Street
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x96,
                0xF5,
                0xB6,
                0xA7,
                0x78,
                0xD6,
                0xC1,
                0x4B,
                0xB0,
                0x5F,
                0x02,
                0x03,
                0xD2,
                0x7E,
                0x8A,
                0xA1,
                0x7E,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Contact_BusinessAddressCity
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x34,
                0x59,
                0x2B,
                0x40,
                0x5A,
                0xEC,
                0xC3,
                0x48,
                0x93,
                0xE6,
                0x85,
                0xE8,
                0x6A,
                0x2D,
                0x93,
                0x4E,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Contact_BusinessAddressCountry
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x14,
                0x73,
                0xB8,
                0xB0,
                0xF6,
                0xFC,
                0xEB,
                0x4F,
                0x8D,
                0xFF,
                0xA5,
                0x0D,
                0xA6,
                0xAF,
                0x56,
                0x1C,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Contact_BusinessAddressPostalCode
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x9E,
                0xA0,
                0xD4,
                0xE1,
                0x58,
                0xD7,
                0xD1,
                0x4C,
                0xB6,
                0xEC,
                0x34,
                0xA8,
                0xB5,
                0xA7,
                0x3F,
                0x80,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Contact_BusinessAddressPostOfficeBox
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xCE,
                0x71,
                0x4E,
                0xBC,
                0xF9,
                0x17,
                0xD5,
                0x48,
                0xBE,
                0xE9,
                0x02,
                0x1D,
                0xF0,
                0xEA,
                0x54,
                0x09,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Contact_BusinessAddressState
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x7F,
                0x78,
                0x6F,
                0x44,
                0xC4,
                0x10,
                0xCB,
                0x41,
                0xA6,
                0xC4,
                0x4D,
                0x03,
                0x43,
                0x55,
                0x15,
                0x97,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Contact_BusinessAddressStreet
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x0F,
                0x46,
                0xD1,
                0xDD,
                0xBF,
                0xC0,
                0x53,
                0x45,
                0x8C,
                0xE4,
                0x10,
                0x43,
                0x3C,
                0x90,
                0x8F,
                0xB0,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Contact_BusinessEmailAddresses
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x59,
                0xC6,
                0x71,
                0xF2,
                0x5E,
                0x7E,
                0x1F,
                0x47,
                0xBA,
                0x25,
                0x7F,
                0x77,
                0xB2,
                0x86,
                0xF8,
                0x36,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Contact_BusinessFaxNumber
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF3,
                0xF6,
                0xEF,
                0x91,
                0x27,
                0x2E,
                0xCA,
                0x42,
                0x93,
                0x3E,
                0x7C,
                0x99,
                0x9F,
                0xBE,
                0x31,
                0x0B,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Contact_BusinessHomePage
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x20,
                0x09,
                0x31,
                0x56,
                0x91,
                0x24,
                0x19,
                0x49,
                0x99,
                0xCE,
                0xEA,
                0xDB,
                0x06,
                0xFA,
                0xFD,
                0xB2,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Contact_BusinessTelephone
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA0,
                0xE5,
                0x15,
                0x6A,
                0x1E,
                0x0A,
                0xD7,
                0x4C,
                0xBB,
                0x8C,
                0xD2,
                0xF1,
                0xB0,
                0xC9,
                0x29,
                0xBC,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Contact_CallbackTelephone
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC3,
                0xD1,
                0x53,
                0xBF,
                0xE0,
                0x49,
                0x7F,
                0x4F,
                0x85,
                0x67,
                0x5A,
                0x82,
                0x1D,
                0x8A,
                0xC5,
                0x42,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Contact_CarTelephone
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xEA,
                0x6D,
                0xDC,
                0x8F,
                0x29,
                0xB9,
                0x2B,
                0x41,
                0xBA,
                0x90,
                0x39,
                0x7A,
                0x25,
                0x74,
                0x65,
                0xFE,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Contact_Children
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x04,
                0x97,
                0x72,
                0xD4,
                0xF1,
                0x8E,
                0xEF,
                0x43,
                0x90,
                0x24,
                0x2B,
                0xD3,
                0x81,
                0x18,
                0x7F,
                0xD5,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Contact_CompanyMainTelephone
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x81,
                0xE4,
                0x89,
                0x85,
                0x40,
                0x60,
                0x3D,
                0x47,
                0xB1,
                0x71,
                0x7F,
                0xA8,
                0x9C,
                0x27,
                0x08,
                0xED,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Contact_ConnectedServiceDisplayName
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x4F,
                0x7F,
                0xB7,
                0x39,
                0x04,
                0xA1,
                0x63,
                0x48,
                0xB3,
                0x95,
                0x2D,
                0xB2,
                0xAD,
                0x8F,
                0x7B,
                0xC1,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Contact_ConnectedServiceIdentities
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB8,
                0x1E,
                0xF4,
                0x80,
                0xC4,
                0xAF,
                0x08,
                0x42,
                0xAA,
                0x5F,
                0xCC,
                0xE2,
                0x1A,
                0x62,
                0x72,
                0x81,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Contact_ConnectedServiceName
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x9E,
                0x4C,
                0xC8,
                0xB5,
                0x27,
                0x59,
                0xB5,
                0x46,
                0xA3,
                0xCC,
                0x93,
                0x3C,
                0x21,
                0xB7,
                0x84,
                0x69,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Contact_ConnectedServiceSupportedActions
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA9,
                0xB7,
                0x9F,
                0xA1,
                0x4B,
                0x02,
                0x71,
                0x43,
                0xA8,
                0xBF,
                0x4D,
                0x29,
                0xC3,
                0xE4,
                0xE9,
                0xC9,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Contact_DataSuppliers
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x83,
                0xC2,
                0x60,
                0x96,
                0x3A,
                0xFC,
                0x08,
                0x4A,
                0xA0,
                0x96,
                0xEE,
                0xD3,
                0xAA,
                0xC4,
                0x6D,
                0xA2,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Contact_Department
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x06,
                0x73,
                0x9F,
                0xFC,
                0x8F,
                0xFF,
                0x49,
                0x4D,
                0x9F,
                0xB6,
                0x3F,
                0xFE,
                0x5C,
                0x09,
                0x51,
                0xEC,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Contact_DisplayBusinessPhoneNumbers
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xDA,
                0x28,
                0x40,
                0x36,
                0x95,
                0xD8,
                0xFE,
                0x41,
                0xA5,
                0x84,
                0x30,
                0x2B,
                0x1B,
                0xB7,
                0x0A,
                0x76,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Contact_DisplayHomePhoneNumbers
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xDF,
                0xBC,
                0x68,
                0x50,
                0x97,
                0xD6,
                0x85,
                0x4D,
                0x8C,
                0x53,
                0x1F,
                0x1C,
                0xDA,
                0xB0,
                0x17,
                0x63,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Contact_DisplayMobilePhoneNumbers
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x58,
                0xC3,
                0xB0,
                0x9C,
                0x7A,
                0x9D,
                0xB1,
                0x46,
                0xB4,
                0x66,
                0xDC,
                0xC6,
                0xF1,
                0xA3,
                0xD9,
                0x3D,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Contact_DisplayOtherPhoneNumbers
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x73,
                0x98,
                0x08,
                0x03,
                0xE8,
                0x8E,
                0x91,
                0x41,
                0xBD,
                0x60,
                0xD3,
                0x1F,
                0x72,
                0xB7,
                0x90,
                0x0B,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Contact_EmailAddress
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA3,
                0x7F,
                0xFA,
                0xF8,
                0x2B,
                0xD1,
                0x85,
                0x47,
                0x8A,
                0x4E,
                0x69,
                0x1A,
                0x94,
                0xF7,
                0xA3,
                0xE7,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Contact_EmailAddress2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x63,
                0x50,
                0x96,
                0x38,
                0xC8,
                0xED,
                0x68,
                0x42,
                0x84,
                0x91,
                0xB7,
                0x72,
                0x31,
                0x72,
                0xCF,
                0x29,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Contact_EmailAddress3
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB4,
                0x37,
                0x4D,
                0x64,
                0xB3,
                0xE1,
                0xAD,
                0x4B,
                0xB0,
                0x99,
                0x7E,
                0x7C,
                0x04,
                0x96,
                0x6A,
                0xCA,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Contact_EmailAddresses
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x37,
                0xF3,
                0xD8,
                0x84,
                0x1D,
                0x98,
                0xB3,
                0x44,
                0x96,
                0x15,
                0xC7,
                0x59,
                0x6D,
                0xBA,
                0x17,
                0xE3,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Contact_EmailName
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x24,
                0x4F,
                0x6F,
                0xCC,
                0x83,
                0x60,
                0xD4,
                0x4B,
                0x87,
                0x54,
                0x67,
                0x4D,
                0x0D,
                0xE8,
                0x7A,
                0xB8,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Contact_FileAsName
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA7,
                0x4A,
                0xA2,
                0xF1,
                0xA7,
                0x9C,
                0xF6,
                0x40,
                0x89,
                0xEC,
                0x97,
                0xDE,
                0xF9,
                0xFF,
                0xE8,
                0xDB,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Contact_FirstName
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x44,
                0x78,
                0x97,
                0x14,
                0x49,
                0x6B,
                0xAD,
                0x4A,
                0xA7,
                0x14,
                0xA4,
                0x51,
                0x3B,
                0xF6,
                0x04,
                0x60,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Contact_FullName
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x51,
                0x90,
                0x5E,
                0x63,
                0xA5,
                0x50,
                0xA2,
                0x4B,
                0xB9,
                0xDB,
                0x4E,
                0xD0,
                0x56,
                0xC7,
                0x72,
                0x96,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Contact_Gender
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x58,
                0xEE,
                0x8C,
                0x3C,
                0xF0,
                0xD4,
                0xF9,
                0x4C,
                0xB7,
                0x56,
                0x4E,
                0x5D,
                0x24,
                0x44,
                0x7B,
                0xCD,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Contact_GenderValue
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x58,
                0xEE,
                0x8C,
                0x3C,
                0xF0,
                0xD4,
                0xF9,
                0x4C,
                0xB7,
                0x56,
                0x4E,
                0x5D,
                0x24,
                0x44,
                0x7B,
                0xCD,
                0x65,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Contact_Hobbies
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x3F,
                0x25,
                0xC2,
                0x5D,
                0x11,
                0x5E,
                0xDF,
                0x4A,
                0x9C,
                0xFE,
                0x91,
                0x0D,
                0xD0,
                0x1E,
                0x3E,
                0x70,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Contact_HomeAddress
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x54,
                0x83,
                0xF9,
                0x98,
                0x7A,
                0x61,
                0xB8,
                0x46,
                0x85,
                0x60,
                0x5B,
                0x1B,
                0x64,
                0xBF,
                0x1F,
                0x89,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Contact_HomeAddress1Country
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x96,
                0xF5,
                0xB6,
                0xA7,
                0x78,
                0xD6,
                0xC1,
                0x4B,
                0xB0,
                0x5F,
                0x02,
                0x03,
                0xD2,
                0x7E,
                0x8A,
                0xA1,
                0x68,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Contact_HomeAddress1Locality
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x96,
                0xF5,
                0xB6,
                0xA7,
                0x78,
                0xD6,
                0xC1,
                0x4B,
                0xB0,
                0x5F,
                0x02,
                0x03,
                0xD2,
                0x7E,
                0x8A,
                0xA1,
                0x66,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Contact_HomeAddress1PostalCode
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x96,
                0xF5,
                0xB6,
                0xA7,
                0x78,
                0xD6,
                0xC1,
                0x4B,
                0xB0,
                0x5F,
                0x02,
                0x03,
                0xD2,
                0x7E,
                0x8A,
                0xA1,
                0x69,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Contact_HomeAddress1Region
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x96,
                0xF5,
                0xB6,
                0xA7,
                0x78,
                0xD6,
                0xC1,
                0x4B,
                0xB0,
                0x5F,
                0x02,
                0x03,
                0xD2,
                0x7E,
                0x8A,
                0xA1,
                0x67,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Contact_HomeAddress1Street
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x96,
                0xF5,
                0xB6,
                0xA7,
                0x78,
                0xD6,
                0xC1,
                0x4B,
                0xB0,
                0x5F,
                0x02,
                0x03,
                0xD2,
                0x7E,
                0x8A,
                0xA1,
                0x65,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Contact_HomeAddress2Country
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x96,
                0xF5,
                0xB6,
                0xA7,
                0x78,
                0xD6,
                0xC1,
                0x4B,
                0xB0,
                0x5F,
                0x02,
                0x03,
                0xD2,
                0x7E,
                0x8A,
                0xA1,
                0x6D,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Contact_HomeAddress2Locality
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x96,
                0xF5,
                0xB6,
                0xA7,
                0x78,
                0xD6,
                0xC1,
                0x4B,
                0xB0,
                0x5F,
                0x02,
                0x03,
                0xD2,
                0x7E,
                0x8A,
                0xA1,
                0x6B,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Contact_HomeAddress2PostalCode
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x96,
                0xF5,
                0xB6,
                0xA7,
                0x78,
                0xD6,
                0xC1,
                0x4B,
                0xB0,
                0x5F,
                0x02,
                0x03,
                0xD2,
                0x7E,
                0x8A,
                0xA1,
                0x6E,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Contact_HomeAddress2Region
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x96,
                0xF5,
                0xB6,
                0xA7,
                0x78,
                0xD6,
                0xC1,
                0x4B,
                0xB0,
                0x5F,
                0x02,
                0x03,
                0xD2,
                0x7E,
                0x8A,
                0xA1,
                0x6C,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Contact_HomeAddress2Street
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x96,
                0xF5,
                0xB6,
                0xA7,
                0x78,
                0xD6,
                0xC1,
                0x4B,
                0xB0,
                0x5F,
                0x02,
                0x03,
                0xD2,
                0x7E,
                0x8A,
                0xA1,
                0x6A,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Contact_HomeAddress3Country
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x96,
                0xF5,
                0xB6,
                0xA7,
                0x78,
                0xD6,
                0xC1,
                0x4B,
                0xB0,
                0x5F,
                0x02,
                0x03,
                0xD2,
                0x7E,
                0x8A,
                0xA1,
                0x72,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Contact_HomeAddress3Locality
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x96,
                0xF5,
                0xB6,
                0xA7,
                0x78,
                0xD6,
                0xC1,
                0x4B,
                0xB0,
                0x5F,
                0x02,
                0x03,
                0xD2,
                0x7E,
                0x8A,
                0xA1,
                0x70,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Contact_HomeAddress3PostalCode
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x96,
                0xF5,
                0xB6,
                0xA7,
                0x78,
                0xD6,
                0xC1,
                0x4B,
                0xB0,
                0x5F,
                0x02,
                0x03,
                0xD2,
                0x7E,
                0x8A,
                0xA1,
                0x73,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Contact_HomeAddress3Region
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x96,
                0xF5,
                0xB6,
                0xA7,
                0x78,
                0xD6,
                0xC1,
                0x4B,
                0xB0,
                0x5F,
                0x02,
                0x03,
                0xD2,
                0x7E,
                0x8A,
                0xA1,
                0x71,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Contact_HomeAddress3Street
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x96,
                0xF5,
                0xB6,
                0xA7,
                0x78,
                0xD6,
                0xC1,
                0x4B,
                0xB0,
                0x5F,
                0x02,
                0x03,
                0xD2,
                0x7E,
                0x8A,
                0xA1,
                0x6F,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Contact_HomeAddressCity
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x3C,
                0xC6,
                0x6D,
                0x17,
                0x88,
                0x26,
                0x89,
                0x4E,
                0x81,
                0x43,
                0xA3,
                0x47,
                0x80,
                0x0F,
                0x25,
                0xE9,
                0x41,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Contact_HomeAddressCountry
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA1,
                0x5A,
                0xA6,
                0x08,
                0xC9,
                0xF4,
                0xDD,
                0x43,
                0x9D,
                0xDF,
                0xA3,
                0x3D,
                0x8E,
                0x7E,
                0xAD,
                0x85,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Contact_HomeAddressPostalCode
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x70,
                0xC1,
                0xFC,
                0x8A,
                0x46,
                0x8A,
                0x53,
                0x4B,
                0x9E,
                0xEE,
                0x90,
                0xBA,
                0xE7,
                0x15,
                0x1E,
                0x62,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Contact_HomeAddressPostOfficeBox
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x99,
                0x63,
                0x9F,
                0x7B,
                0x3F,
                0x0A,
                0x12,
                0x4B,
                0x89,
                0xBD,
                0x4A,
                0xDC,
                0x51,
                0xC9,
                0x18,
                0xAF,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Contact_HomeAddressState
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD0,
                0x23,
                0x9A,
                0xC8,
                0x6D,
                0x7D,
                0xB8,
                0x4E,
                0x87,
                0xD4,
                0x77,
                0x6A,
                0x82,
                0xD4,
                0x93,
                0xE5,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Contact_HomeAddressStreet
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x60,
                0xF1,
                0xDE,
                0x0A,
                0x3F,
                0xDB,
                0x08,
                0x43,
                0x9A,
                0x21,
                0x06,
                0x23,
                0x7B,
                0x16,
                0xFA,
                0x2A,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Contact_HomeEmailAddresses
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x9D,
                0x0E,
                0xC9,
                0x56,
                0x46,
                0x9D,
                0x63,
                0x49,
                0x88,
                0x6F,
                0x2E,
                0x1C,
                0xD9,
                0xA6,
                0x94,
                0xEF,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Contact_HomeFaxNumber
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD6,
                0x04,
                0x0E,
                0x66,
                0xAB,
                0x81,
                0x77,
                0x49,
                0xA0,
                0x9F,
                0x82,
                0x31,
                0x31,
                0x13,
                0xAB,
                0x26,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Contact_HomeTelephone
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x3C,
                0xC6,
                0x6D,
                0x17,
                0x88,
                0x26,
                0x89,
                0x4E,
                0x81,
                0x43,
                0xA3,
                0x47,
                0x80,
                0x0F,
                0x25,
                0xE9,
                0x14,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Contact_IMAddress
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x8A,
                0xBD,
                0x8D,
                0xD6,
                0x74,
                0x33,
                0x81,
                0x4B,
                0x99,
                0x72,
                0x3E,
                0xC3,
                0x06,
                0x82,
                0xDB,
                0x3D,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Contact_Initials
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x0D,
                0xF4,
                0xD8,
                0xF3,
                0xCB,
                0x50,
                0xA2,
                0x44,
                0x97,
                0x18,
                0x40,
                0xCB,
                0x91,
                0x19,
                0x49,
                0x5D,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Contact_JA_CompanyNamePhonetic
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x94,
                0x36,
                0x7B,
                0x89,
                0x9E,
                0xFE,
                0xE6,
                0x43,
                0x80,
                0x66,
                0x26,
                0x0F,
                0x59,
                0x0C,
                0x01,
                0x00,
                0x02,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Contact_JA_FirstNamePhonetic
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x94,
                0x36,
                0x7B,
                0x89,
                0x9E,
                0xFE,
                0xE6,
                0x43,
                0x80,
                0x66,
                0x26,
                0x0F,
                0x59,
                0x0C,
                0x01,
                0x00,
                0x03,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Contact_JA_LastNamePhonetic
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x94,
                0x36,
                0x7B,
                0x89,
                0x9E,
                0xFE,
                0xE6,
                0x43,
                0x80,
                0x66,
                0x26,
                0x0F,
                0x59,
                0x0C,
                0x01,
                0x00,
                0x04,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Contact_JobInfo1CompanyAddress
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD8,
                0x3D,
                0xF6,
                0x00,
                0xBD,
                0x22,
                0x5D,
                0x4A,
                0xBA,
                0x34,
                0x5C,
                0xB0,
                0xB9,
                0xBD,
                0xCB,
                0x03,
                0x78,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Contact_JobInfo1CompanyName
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD8,
                0x3D,
                0xF6,
                0x00,
                0xBD,
                0x22,
                0x5D,
                0x4A,
                0xBA,
                0x34,
                0x5C,
                0xB0,
                0xB9,
                0xBD,
                0xCB,
                0x03,
                0x66,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Contact_JobInfo1Department
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD8,
                0x3D,
                0xF6,
                0x00,
                0xBD,
                0x22,
                0x5D,
                0x4A,
                0xBA,
                0x34,
                0x5C,
                0xB0,
                0xB9,
                0xBD,
                0xCB,
                0x03,
                0x6A,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Contact_JobInfo1Manager
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD8,
                0x3D,
                0xF6,
                0x00,
                0xBD,
                0x22,
                0x5D,
                0x4A,
                0xBA,
                0x34,
                0x5C,
                0xB0,
                0xB9,
                0xBD,
                0xCB,
                0x03,
                0x69,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Contact_JobInfo1OfficeLocation
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD8,
                0x3D,
                0xF6,
                0x00,
                0xBD,
                0x22,
                0x5D,
                0x4A,
                0xBA,
                0x34,
                0x5C,
                0xB0,
                0xB9,
                0xBD,
                0xCB,
                0x03,
                0x68,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Contact_JobInfo1Title
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD8,
                0x3D,
                0xF6,
                0x00,
                0xBD,
                0x22,
                0x5D,
                0x4A,
                0xBA,
                0x34,
                0x5C,
                0xB0,
                0xB9,
                0xBD,
                0xCB,
                0x03,
                0x67,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Contact_JobInfo1YomiCompanyName
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD8,
                0x3D,
                0xF6,
                0x00,
                0xBD,
                0x22,
                0x5D,
                0x4A,
                0xBA,
                0x34,
                0x5C,
                0xB0,
                0xB9,
                0xBD,
                0xCB,
                0x03,
                0x65,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Contact_JobInfo2CompanyAddress
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD8,
                0x3D,
                0xF6,
                0x00,
                0xBD,
                0x22,
                0x5D,
                0x4A,
                0xBA,
                0x34,
                0x5C,
                0xB0,
                0xB9,
                0xBD,
                0xCB,
                0x03,
                0x79,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Contact_JobInfo2CompanyName
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD8,
                0x3D,
                0xF6,
                0x00,
                0xBD,
                0x22,
                0x5D,
                0x4A,
                0xBA,
                0x34,
                0x5C,
                0xB0,
                0xB9,
                0xBD,
                0xCB,
                0x03,
                0x6C,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Contact_JobInfo2Department
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD8,
                0x3D,
                0xF6,
                0x00,
                0xBD,
                0x22,
                0x5D,
                0x4A,
                0xBA,
                0x34,
                0x5C,
                0xB0,
                0xB9,
                0xBD,
                0xCB,
                0x03,
                0x71,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Contact_JobInfo2Manager
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD8,
                0x3D,
                0xF6,
                0x00,
                0xBD,
                0x22,
                0x5D,
                0x4A,
                0xBA,
                0x34,
                0x5C,
                0xB0,
                0xB9,
                0xBD,
                0xCB,
                0x03,
                0x70,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Contact_JobInfo2OfficeLocation
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD8,
                0x3D,
                0xF6,
                0x00,
                0xBD,
                0x22,
                0x5D,
                0x4A,
                0xBA,
                0x34,
                0x5C,
                0xB0,
                0xB9,
                0xBD,
                0xCB,
                0x03,
                0x6E,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Contact_JobInfo2Title
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD8,
                0x3D,
                0xF6,
                0x00,
                0xBD,
                0x22,
                0x5D,
                0x4A,
                0xBA,
                0x34,
                0x5C,
                0xB0,
                0xB9,
                0xBD,
                0xCB,
                0x03,
                0x6D,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Contact_JobInfo2YomiCompanyName
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD8,
                0x3D,
                0xF6,
                0x00,
                0xBD,
                0x22,
                0x5D,
                0x4A,
                0xBA,
                0x34,
                0x5C,
                0xB0,
                0xB9,
                0xBD,
                0xCB,
                0x03,
                0x6B,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Contact_JobInfo3CompanyAddress
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD8,
                0x3D,
                0xF6,
                0x00,
                0xBD,
                0x22,
                0x5D,
                0x4A,
                0xBA,
                0x34,
                0x5C,
                0xB0,
                0xB9,
                0xBD,
                0xCB,
                0x03,
                0x7B,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Contact_JobInfo3CompanyName
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD8,
                0x3D,
                0xF6,
                0x00,
                0xBD,
                0x22,
                0x5D,
                0x4A,
                0xBA,
                0x34,
                0x5C,
                0xB0,
                0xB9,
                0xBD,
                0xCB,
                0x03,
                0x73,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Contact_JobInfo3Department
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD8,
                0x3D,
                0xF6,
                0x00,
                0xBD,
                0x22,
                0x5D,
                0x4A,
                0xBA,
                0x34,
                0x5C,
                0xB0,
                0xB9,
                0xBD,
                0xCB,
                0x03,
                0x77,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Contact_JobInfo3Manager
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD8,
                0x3D,
                0xF6,
                0x00,
                0xBD,
                0x22,
                0x5D,
                0x4A,
                0xBA,
                0x34,
                0x5C,
                0xB0,
                0xB9,
                0xBD,
                0xCB,
                0x03,
                0x76,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Contact_JobInfo3OfficeLocation
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD8,
                0x3D,
                0xF6,
                0x00,
                0xBD,
                0x22,
                0x5D,
                0x4A,
                0xBA,
                0x34,
                0x5C,
                0xB0,
                0xB9,
                0xBD,
                0xCB,
                0x03,
                0x75,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Contact_JobInfo3Title
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD8,
                0x3D,
                0xF6,
                0x00,
                0xBD,
                0x22,
                0x5D,
                0x4A,
                0xBA,
                0x34,
                0x5C,
                0xB0,
                0xB9,
                0xBD,
                0xCB,
                0x03,
                0x74,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Contact_JobInfo3YomiCompanyName
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD8,
                0x3D,
                0xF6,
                0x00,
                0xBD,
                0x22,
                0x5D,
                0x4A,
                0xBA,
                0x34,
                0x5C,
                0xB0,
                0xB9,
                0xBD,
                0xCB,
                0x03,
                0x72,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Contact_JobTitle
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x3C,
                0xC6,
                0x6D,
                0x17,
                0x88,
                0x26,
                0x89,
                0x4E,
                0x81,
                0x43,
                0xA3,
                0x47,
                0x80,
                0x0F,
                0x25,
                0xE9,
                0x06,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Contact_Label
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x89,
                0xAD,
                0xB0,
                0x97,
                0x49,
                0xDF,
                0xCC,
                0x49,
                0x83,
                0x4E,
                0x66,
                0x09,
                0x74,
                0xFD,
                0x75,
                0x5B,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Contact_LastName
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x00,
                0x72,
                0x36,
                0x8F,
                0x70,
                0xC2,
                0x7C,
                0x45,
                0xB1,
                0xD4,
                0xE0,
                0x7C,
                0x5B,
                0xCD,
                0x90,
                0xC7,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Contact_MailingAddress
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x6A,
                0x20,
                0xAC,
                0xC0,
                0x7E,
                0x82,
                0x50,
                0x46,
                0x95,
                0xAE,
                0x77,
                0xE2,
                0xBB,
                0x74,
                0xFC,
                0xC9,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Contact_MiddleName
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x3C,
                0xC6,
                0x6D,
                0x17,
                0x88,
                0x26,
                0x89,
                0x4E,
                0x81,
                0x43,
                0xA3,
                0x47,
                0x80,
                0x0F,
                0x25,
                0xE9,
                0x47,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Contact_MobileTelephone
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x3C,
                0xC6,
                0x6D,
                0x17,
                0x88,
                0x26,
                0x89,
                0x4E,
                0x81,
                0x43,
                0xA3,
                0x47,
                0x80,
                0x0F,
                0x25,
                0xE9,
                0x23,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Contact_NickName
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x3C,
                0xC6,
                0x6D,
                0x17,
                0x88,
                0x26,
                0x89,
                0x4E,
                0x81,
                0x43,
                0xA3,
                0x47,
                0x80,
                0x0F,
                0x25,
                0xE9,
                0x4A,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Contact_OfficeLocation
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x3C,
                0xC6,
                0x6D,
                0x17,
                0x88,
                0x26,
                0x89,
                0x4E,
                0x81,
                0x43,
                0xA3,
                0x47,
                0x80,
                0x0F,
                0x25,
                0xE9,
                0x07,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Contact_OtherAddress
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xFA,
                0x61,
                0x81,
                0x50,
                0x3B,
                0x31,
                0xD5,
                0x43,
                0x83,
                0xA1,
                0xC1,
                0xAC,
                0xCF,
                0x68,
                0x62,
                0x2C,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Contact_OtherAddress1Country
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x96,
                0xF5,
                0xB6,
                0xA7,
                0x78,
                0xD6,
                0xC1,
                0x4B,
                0xB0,
                0x5F,
                0x02,
                0x03,
                0xD2,
                0x7E,
                0x8A,
                0xA1,
                0x86,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Contact_OtherAddress1Locality
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x96,
                0xF5,
                0xB6,
                0xA7,
                0x78,
                0xD6,
                0xC1,
                0x4B,
                0xB0,
                0x5F,
                0x02,
                0x03,
                0xD2,
                0x7E,
                0x8A,
                0xA1,
                0x84,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Contact_OtherAddress1PostalCode
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x96,
                0xF5,
                0xB6,
                0xA7,
                0x78,
                0xD6,
                0xC1,
                0x4B,
                0xB0,
                0x5F,
                0x02,
                0x03,
                0xD2,
                0x7E,
                0x8A,
                0xA1,
                0x87,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Contact_OtherAddress1Region
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x96,
                0xF5,
                0xB6,
                0xA7,
                0x78,
                0xD6,
                0xC1,
                0x4B,
                0xB0,
                0x5F,
                0x02,
                0x03,
                0xD2,
                0x7E,
                0x8A,
                0xA1,
                0x85,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Contact_OtherAddress1Street
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x96,
                0xF5,
                0xB6,
                0xA7,
                0x78,
                0xD6,
                0xC1,
                0x4B,
                0xB0,
                0x5F,
                0x02,
                0x03,
                0xD2,
                0x7E,
                0x8A,
                0xA1,
                0x83,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Contact_OtherAddress2Country
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x96,
                0xF5,
                0xB6,
                0xA7,
                0x78,
                0xD6,
                0xC1,
                0x4B,
                0xB0,
                0x5F,
                0x02,
                0x03,
                0xD2,
                0x7E,
                0x8A,
                0xA1,
                0x8B,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Contact_OtherAddress2Locality
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x96,
                0xF5,
                0xB6,
                0xA7,
                0x78,
                0xD6,
                0xC1,
                0x4B,
                0xB0,
                0x5F,
                0x02,
                0x03,
                0xD2,
                0x7E,
                0x8A,
                0xA1,
                0x89,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Contact_OtherAddress2PostalCode
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x96,
                0xF5,
                0xB6,
                0xA7,
                0x78,
                0xD6,
                0xC1,
                0x4B,
                0xB0,
                0x5F,
                0x02,
                0x03,
                0xD2,
                0x7E,
                0x8A,
                0xA1,
                0x8C,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Contact_OtherAddress2Region
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x96,
                0xF5,
                0xB6,
                0xA7,
                0x78,
                0xD6,
                0xC1,
                0x4B,
                0xB0,
                0x5F,
                0x02,
                0x03,
                0xD2,
                0x7E,
                0x8A,
                0xA1,
                0x8A,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Contact_OtherAddress2Street
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x96,
                0xF5,
                0xB6,
                0xA7,
                0x78,
                0xD6,
                0xC1,
                0x4B,
                0xB0,
                0x5F,
                0x02,
                0x03,
                0xD2,
                0x7E,
                0x8A,
                0xA1,
                0x88,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Contact_OtherAddress3Country
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x96,
                0xF5,
                0xB6,
                0xA7,
                0x78,
                0xD6,
                0xC1,
                0x4B,
                0xB0,
                0x5F,
                0x02,
                0x03,
                0xD2,
                0x7E,
                0x8A,
                0xA1,
                0x90,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Contact_OtherAddress3Locality
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x96,
                0xF5,
                0xB6,
                0xA7,
                0x78,
                0xD6,
                0xC1,
                0x4B,
                0xB0,
                0x5F,
                0x02,
                0x03,
                0xD2,
                0x7E,
                0x8A,
                0xA1,
                0x8E,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Contact_OtherAddress3PostalCode
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x96,
                0xF5,
                0xB6,
                0xA7,
                0x78,
                0xD6,
                0xC1,
                0x4B,
                0xB0,
                0x5F,
                0x02,
                0x03,
                0xD2,
                0x7E,
                0x8A,
                0xA1,
                0x91,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Contact_OtherAddress3Region
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x96,
                0xF5,
                0xB6,
                0xA7,
                0x78,
                0xD6,
                0xC1,
                0x4B,
                0xB0,
                0x5F,
                0x02,
                0x03,
                0xD2,
                0x7E,
                0x8A,
                0xA1,
                0x8F,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Contact_OtherAddress3Street
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x96,
                0xF5,
                0xB6,
                0xA7,
                0x78,
                0xD6,
                0xC1,
                0x4B,
                0xB0,
                0x5F,
                0x02,
                0x03,
                0xD2,
                0x7E,
                0x8A,
                0xA1,
                0x8D,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Contact_OtherAddressCity
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x23,
                0x29,
                0x68,
                0x6E,
                0x7B,
                0x7F,
                0x0C,
                0x4F,
                0xA3,
                0x37,
                0xCF,
                0xCA,
                0x29,
                0x66,
                0x87,
                0xBF,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Contact_OtherAddressCountry
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x68,
                0x75,
                0x16,
                0x8F,
                0xAE,
                0x0A,
                0x22,
                0x43,
                0x8E,
                0xD9,
                0x60,
                0x55,
                0xB7,
                0xB0,
                0xE3,
                0x98,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Contact_OtherAddressPostalCode
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC1,
                0x56,
                0xC6,
                0x95,
                0xBF,
                0x2A,
                0x48,
                0x41,
                0x9E,
                0xD3,
                0x9E,
                0xC6,
                0x02,
                0xE3,
                0xB7,
                0xCD,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Contact_OtherAddressPostOfficeBox
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x41,
                0xEA,
                0x26,
                0x8B,
                0x8F,
                0x05,
                0xF6,
                0x43,
                0xAE,
                0xCC,
                0x40,
                0x35,
                0x68,
                0x1C,
                0xE9,
                0x77,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Contact_OtherAddressState
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD6,
                0x77,
                0xB3,
                0x71,
                0x70,
                0xE5,
                0x5F,
                0x42,
                0xA1,
                0x70,
                0x80,
                0x9F,
                0xAE,
                0x73,
                0xE5,
                0x4E,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Contact_OtherAddressStreet
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x09,
                0x26,
                0x96,
                0xFF,
                0xD6,
                0xB7,
                0x99,
                0x49,
                0x86,
                0x2D,
                0x95,
                0x18,
                0x0D,
                0x52,
                0x9A,
                0xEA,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Contact_OtherEmailAddresses
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x6B,
                0x33,
                0xD6,
                0x11,
                0xC4,
                0x38,
                0xC9,
                0x4E,
                0x84,
                0xD6,
                0xEB,
                0x38,
                0xD0,
                0xB1,
                0x50,
                0xAF,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Contact_PagerTelephone
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x01,
                0x4E,
                0x30,
                0xD6,
                0xF5,
                0xF8,
                0x45,
                0x4F,
                0x8B,
                0x15,
                0xD0,
                0x24,
                0xA6,
                0x29,
                0x67,
                0x89,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Contact_PersonalTitle
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x3C,
                0xC6,
                0x6D,
                0x17,
                0x88,
                0x26,
                0x89,
                0x4E,
                0x81,
                0x43,
                0xA3,
                0x47,
                0x80,
                0x0F,
                0x25,
                0xE9,
                0x45,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Contact_PhoneNumbersCanonical
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA1,
                0xD2,
                0x42,
                0xD0,
                0x7E,
                0x92,
                0xB5,
                0x40,
                0xA5,
                0x03,
                0x6E,
                0xDB,
                0xD4,
                0x2A,
                0x51,
                0x7E,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Contact_Prefix
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x3C,
                0xC6,
                0x6D,
                0x17,
                0x88,
                0x26,
                0x89,
                0x4E,
                0x81,
                0x43,
                0xA3,
                0x47,
                0x80,
                0x0F,
                0x25,
                0xE9,
                0x4B,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Contact_PrimaryAddressCity
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF0,
                0x94,
                0xEA,
                0xC8,
                0xE3,
                0xA9,
                0x69,
                0x49,
                0xA9,
                0x4B,
                0x9C,
                0x62,
                0xA9,
                0x53,
                0x24,
                0xE0,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Contact_PrimaryAddressCountry
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x9D,
                0x79,
                0x3D,
                0xE5,
                0x3F,
                0x0F,
                0x6E,
                0x46,
                0xB2,
                0xFF,
                0x74,
                0x63,
                0x4A,
                0x3C,
                0xB7,
                0xA4,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Contact_PrimaryAddressPostalCode
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x25,
                0xD4,
                0xBB,
                0x18,
                0xFD,
                0xEC,
                0xEF,
                0x46,
                0xB6,
                0x12,
                0x7B,
                0x4A,
                0x60,
                0x34,
                0xED,
                0xA0,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Contact_PrimaryAddressPostOfficeBox
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC7,
                0xF3,
                0x5E,
                0xDE,
                0xE1,
                0x46,
                0x4E,
                0x48,
                0x99,
                0x99,
                0x62,
                0xC5,
                0x30,
                0x83,
                0x94,
                0xC1,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Contact_PrimaryAddressState
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xFE,
                0x6D,
                0x17,
                0xF1,
                0x38,
                0x71,
                0x40,
                0x46,
                0x8B,
                0x4C,
                0xAE,
                0x37,
                0x5D,
                0xC7,
                0x0A,
                0x6D,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Contact_PrimaryAddressStreet
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x20,
                0x5B,
                0xC2,
                0x63,
                0xBE,
                0x96,
                0x8F,
                0x48,
                0x87,
                0x88,
                0xC0,
                0x9C,
                0x40,
                0x7A,
                0xD8,
                0x12,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Contact_PrimaryEmailAddress
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x3C,
                0xC6,
                0x6D,
                0x17,
                0x88,
                0x26,
                0x89,
                0x4E,
                0x81,
                0x43,
                0xA3,
                0x47,
                0x80,
                0x0F,
                0x25,
                0xE9,
                0x30,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Contact_PrimaryTelephone
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x3C,
                0xC6,
                0x6D,
                0x17,
                0x88,
                0x26,
                0x89,
                0x4E,
                0x81,
                0x43,
                0xA3,
                0x47,
                0x80,
                0x0F,
                0x25,
                0xE9,
                0x19,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Contact_Profession
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x55,
                0xAF,
                0x68,
                0x72,
                0xE4,
                0x1C,
                0x6E,
                0x4F,
                0xA4,
                0x1F,
                0xB6,
                0xE4,
                0xEF,
                0x10,
                0xE4,
                0xA9,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Contact_SpouseName
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB6,
                0x08,
                0x24,
                0x9D,
                0x67,
                0x31,
                0x2B,
                0x42,
                0x82,
                0xB0,
                0xF5,
                0x83,
                0xB7,
                0xA7,
                0xCF,
                0xE3,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Contact_Suffix
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x3C,
                0xC6,
                0x6D,
                0x17,
                0x88,
                0x26,
                0x89,
                0x4E,
                0x81,
                0x43,
                0xA3,
                0x47,
                0x80,
                0x0F,
                0x25,
                0xE9,
                0x49,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Contact_TelexNumber
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x3C,
                0x49,
                0x54,
                0xC5,
                0xF7,
                0xC1,
                0xC1,
                0x40,
                0xA7,
                0x6C,
                0xEF,
                0x8C,
                0x06,
                0x14,
                0x00,
                0x3E,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Contact_TTYTDDTelephone
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xAC,
                0x6B,
                0xF1,
                0xAA,
                0x55,
                0x2B,
                0xE6,
                0x45,
                0x9F,
                0x6D,
                0x41,
                0x5E,
                0xB9,
                0x49,
                0x10,
                0xDF,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Contact_WebPage
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x4C,
                0x58,
                0xE0,
                0xE3,
                0x88,
                0xB7,
                0x5A,
                0x4A,
                0xBB,
                0x20,
                0x7F,
                0x5A,
                0x44,
                0xC9,
                0xAC,
                0xDD,
                0x12,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Contact_Webpage2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD8,
                0x3D,
                0xF6,
                0x00,
                0xBD,
                0x22,
                0x5D,
                0x4A,
                0xBA,
                0x34,
                0x5C,
                0xB0,
                0xB9,
                0xBD,
                0xCB,
                0x03,
                0x7C,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Contact_Webpage3
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD8,
                0x3D,
                0xF6,
                0x00,
                0xBD,
                0x22,
                0x5D,
                0x4A,
                0xBA,
                0x34,
                0x5C,
                0xB0,
                0xB9,
                0xBD,
                0xCB,
                0x03,
                0x7D,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_AcquisitionID
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x75,
                0x88,
                0xA9,
                0x65,
                0x80,
                0x3C,
                0xAB,
                0x40,
                0xAB,
                0xBC,
                0xEF,
                0xDA,
                0xF7,
                0x7D,
                0xBE,
                0xE2,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_ApplicationDefinedProperties
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x67,
                0xC1,
                0xBF,
                0xCD,
                0x7E,
                0x33,
                0xD8,
                0x41,
                0xAF,
                0x7C,
                0x8C,
                0x09,
                0x20,
                0x54,
                0x29,
                0xC7,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_ApplicationName
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE0,
                0x85,
                0x9F,
                0xF2,
                0xF9,
                0x4F,
                0x68,
                0x10,
                0xAB,
                0x91,
                0x08,
                0x00,
                0x2B,
                0x27,
                0xB3,
                0xD9,
                0x12,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_AppZoneIdentifier
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xAB,
                0xFE,
                0x2C,
                0x50,
                0xEB,
                0x47,
                0x9C,
                0x45,
                0xB9,
                0x60,
                0xE6,
                0xD8,
                0x72,
                0x8F,
                0x77,
                0x01,
                0x66,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Author
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE0,
                0x85,
                0x9F,
                0xF2,
                0xF9,
                0x4F,
                0x68,
                0x10,
                0xAB,
                0x91,
                0x08,
                0x00,
                0x2B,
                0x27,
                0xB3,
                0xD9,
                0x04,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_CachedFileUpdaterContentIdForConflictResolution
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x53,
                0xF1,
                0xEF,
                0xFC,
                0x39,
                0xE8,
                0xF3,
                0x4C,
                0xA9,
                0xE7,
                0xEA,
                0x22,
                0x83,
                0x20,
                0x94,
                0xB8,
                0x72,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_CachedFileUpdaterContentIdForStream
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x53,
                0xF1,
                0xEF,
                0xFC,
                0x39,
                0xE8,
                0xF3,
                0x4C,
                0xA9,
                0xE7,
                0xEA,
                0x22,
                0x83,
                0x20,
                0x94,
                0xB8,
                0x71,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Capacity
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x35,
                0x4B,
                0x17,
                0x9B,
                0xFF,
                0x40,
                0xD2,
                0x11,
                0xA2,
                0x7E,
                0x00,
                0xC0,
                0x4F,
                0xC3,
                0x08,
                0x71,
                0x03,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Category
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x02,
                0xD5,
                0xCD,
                0xD5,
                0x9C,
                0x2E,
                0x1B,
                0x10,
                0x93,
                0x97,
                0x08,
                0x00,
                0x2B,
                0x2C,
                0xF9,
                0xAE,
                0x02,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Comment
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE0,
                0x85,
                0x9F,
                0xF2,
                0xF9,
                0x4F,
                0x68,
                0x10,
                0xAB,
                0x91,
                0x08,
                0x00,
                0x2B,
                0x27,
                0xB3,
                0xD9,
                0x06,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Company
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x02,
                0xD5,
                0xCD,
                0xD5,
                0x9C,
                0x2E,
                0x1B,
                0x10,
                0x93,
                0x97,
                0x08,
                0x00,
                0x2B,
                0x2C,
                0xF9,
                0xAE,
                0x0F,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_ComputerName
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA6,
                0x6A,
                0x63,
                0x28,
                0x3D,
                0x95,
                0xD2,
                0x11,
                0xB5,
                0xD6,
                0x00,
                0xC0,
                0x4F,
                0xD9,
                0x18,
                0xD0,
                0x05,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_ContainedItems
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA6,
                0x6A,
                0x63,
                0x28,
                0x3D,
                0x95,
                0xD2,
                0x11,
                0xB5,
                0xD6,
                0x00,
                0xC0,
                0x4F,
                0xD9,
                0x18,
                0xD0,
                0x1D,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_ContentId
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x53,
                0xF1,
                0xEF,
                0xFC,
                0x39,
                0xE8,
                0xF3,
                0x4C,
                0xA9,
                0xE7,
                0xEA,
                0x22,
                0x83,
                0x20,
                0x94,
                0xB8,
                0x84,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_ContentStatus
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x02,
                0xD5,
                0xCD,
                0xD5,
                0x9C,
                0x2E,
                0x1B,
                0x10,
                0x93,
                0x97,
                0x08,
                0x00,
                0x2B,
                0x2C,
                0xF9,
                0xAE,
                0x1B,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_ContentType
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x02,
                0xD5,
                0xCD,
                0xD5,
                0x9C,
                0x2E,
                0x1B,
                0x10,
                0x93,
                0x97,
                0x08,
                0x00,
                0x2B,
                0x2C,
                0xF9,
                0xAE,
                0x1A,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_ContentUri
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x53,
                0xF1,
                0xEF,
                0xFC,
                0x39,
                0xE8,
                0xF3,
                0x4C,
                0xA9,
                0xE7,
                0xEA,
                0x22,
                0x83,
                0x20,
                0x94,
                0xB8,
                0x83,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Copyright
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x92,
                0x04,
                0x44,
                0x64,
                0x8B,
                0x4C,
                0xD1,
                0x11,
                0x8B,
                0x70,
                0x08,
                0x00,
                0x36,
                0xB1,
                0x1A,
                0x03,
                0x0B,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_CreatorAppId
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x6E,
                0x04,
                0xEA,
                0xC2,
                0x3C,
                0x03,
                0x91,
                0x4E,
                0xBD,
                0x5B,
                0xD4,
                0x94,
                0x2F,
                0x6B,
                0xBE,
                0x49,
                0x02,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_CreatorOpenWithUIOptions
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x6E,
                0x04,
                0xEA,
                0xC2,
                0x3C,
                0x03,
                0x91,
                0x4E,
                0xBD,
                0x5B,
                0xD4,
                0x94,
                0x2F,
                0x6B,
                0xBE,
                0x49,
                0x03,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_DataObjectFormat
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF8,
                0xA3,
                0x81,
                0x1E,
                0x0F,
                0xA3,
                0x47,
                0x42,
                0xB9,
                0xEE,
                0x1D,
                0x03,
                0x68,
                0xA9,
                0x42,
                0x5C,
                0x02,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_DateAccessed
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x30,
                0xF1,
                0x25,
                0xB7,
                0xEF,
                0x47,
                0x1A,
                0x10,
                0xA5,
                0xF1,
                0x02,
                0x60,
                0x8C,
                0x9E,
                0xEB,
                0xAC,
                0x10,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_DateAcquired
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF5,
                0xA8,
                0xBA,
                0x2C,
                0x1F,
                0xD8,
                0xCA,
                0x47,
                0xB1,
                0x7A,
                0xF8,
                0xD8,
                0x22,
                0x30,
                0x01,
                0x31,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_DateArchived
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB7,
                0xD7,
                0xF8,
                0x43,
                0x44,
                0xA4,
                0x87,
                0x4F,
                0x93,
                0x83,
                0x52,
                0x27,
                0x1C,
                0x9B,
                0x91,
                0x5C,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_DateCompleted
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x81,
                0xB7,
                0xFA,
                0x72,
                0xDA,
                0xAC,
                0xE5,
                0x43,
                0xB1,
                0x55,
                0xB2,
                0x43,
                0x4F,
                0x85,
                0xE6,
                0x78,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_DateCreated
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x30,
                0xF1,
                0x25,
                0xB7,
                0xEF,
                0x47,
                0x1A,
                0x10,
                0xA5,
                0xF1,
                0x02,
                0x60,
                0x8C,
                0x9E,
                0xEB,
                0xAC,
                0x0F,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_DateImported
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA1,
                0x1D,
                0xB8,
                0x14,
                0x35,
                0x01,
                0x31,
                0x4D,
                0x96,
                0xD9,
                0x6C,
                0xBF,
                0xC9,
                0x67,
                0x1A,
                0x99,
                0x52,
                0x47,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_DateModified
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x30,
                0xF1,
                0x25,
                0xB7,
                0xEF,
                0x47,
                0x1A,
                0x10,
                0xA5,
                0xF1,
                0x02,
                0x60,
                0x8C,
                0x9E,
                0xEB,
                0xAC,
                0x0E,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_DefaultSaveLocationDisplay
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x7F,
                0xB6,
                0x76,
                0x5D,
                0x3D,
                0x9B,
                0xBB,
                0x44,
                0xB6,
                0xAE,
                0x25,
                0xDA,
                0x4F,
                0x63,
                0x8A,
                0x67,
                0x0A,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_DueDate
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB5,
                0x72,
                0x84,
                0x3F,
                0xAF,
                0xE0,
                0xB2,
                0x4D,
                0x80,
                0x71,
                0xC5,
                0x3F,
                0xE7,
                0x6A,
                0xE7,
                0xCE,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_EndDate
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x05,
                0xAA,
                0x5F,
                0xC7,
                0xFD,
                0x96,
                0xE7,
                0x49,
                0x9C,
                0xB4,
                0x9F,
                0x60,
                0x10,
                0x82,
                0xD5,
                0x53,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_ExpandoProperties
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE6,
                0x0D,
                0xA2,
                0x6F,
                0x1C,
                0xD1,
                0x9D,
                0x4D,
                0xA1,
                0x54,
                0x64,
                0x31,
                0x76,
                0x28,
                0xC1,
                0x2D,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_FileAllocationSize
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x30,
                0xF1,
                0x25,
                0xB7,
                0xEF,
                0x47,
                0x1A,
                0x10,
                0xA5,
                0xF1,
                0x02,
                0x60,
                0x8C,
                0x9E,
                0xEB,
                0xAC,
                0x12,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_FileAttributes
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x30,
                0xF1,
                0x25,
                0xB7,
                0xEF,
                0x47,
                0x1A,
                0x10,
                0xA5,
                0xF1,
                0x02,
                0x60,
                0x8C,
                0x9E,
                0xEB,
                0xAC,
                0x0D,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_FileCount
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA6,
                0x6A,
                0x63,
                0x28,
                0x3D,
                0x95,
                0xD2,
                0x11,
                0xB5,
                0xD6,
                0x00,
                0xC0,
                0x4F,
                0xD9,
                0x18,
                0xD0,
                0x0C,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_FileDescription
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x53,
                0x7D,
                0xEF,
                0x0C,
                0x64,
                0xFA,
                0xD1,
                0x11,
                0xA2,
                0x03,
                0x00,
                0x00,
                0xF8,
                0x1F,
                0xED,
                0xEE,
                0x03,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_FileExtension
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x3C,
                0x0A,
                0xF1,
                0xE4,
                0xE6,
                0x49,
                0x5D,
                0x40,
                0x82,
                0x88,
                0xA2,
                0x3B,
                0xD4,
                0xEE,
                0xAA,
                0x6C,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_FileFRN
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x30,
                0xF1,
                0x25,
                0xB7,
                0xEF,
                0x47,
                0x1A,
                0x10,
                0xA5,
                0xF1,
                0x02,
                0x60,
                0x8C,
                0x9E,
                0xEB,
                0xAC,
                0x15,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_FileName
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE0,
                0x5A,
                0xCF,
                0x41,
                0x5A,
                0xF7,
                0x06,
                0x48,
                0xBD,
                0x87,
                0x59,
                0xC7,
                0xD9,
                0x24,
                0x8E,
                0xB9,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_FileOfflineAvailabilityStatus
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x53,
                0xF1,
                0xEF,
                0xFC,
                0x39,
                0xE8,
                0xF3,
                0x4C,
                0xA9,
                0xE7,
                0xEA,
                0x22,
                0x83,
                0x20,
                0x94,
                0xB8,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_FileOwner
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x34,
                0x4B,
                0x17,
                0x9B,
                0xFF,
                0x40,
                0xD2,
                0x11,
                0xA2,
                0x7E,
                0x00,
                0xC0,
                0x4F,
                0xC3,
                0x08,
                0x71,
                0x04,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_FilePlaceholderStatus
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD6,
                0xB9,
                0xF9,
                0xB2,
                0xC4,
                0xFE,
                0xD5,
                0x4D,
                0x94,
                0xD7,
                0x89,
                0x57,
                0x48,
                0x8C,
                0x80,
                0x7B,
                0x02,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_FileVersion
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x53,
                0x7D,
                0xEF,
                0x0C,
                0x64,
                0xFA,
                0xD1,
                0x11,
                0xA2,
                0x03,
                0x00,
                0x00,
                0xF8,
                0x1F,
                0xED,
                0xEE,
                0x04,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_FindData
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA6,
                0x6A,
                0x63,
                0x28,
                0x3D,
                0x95,
                0xD2,
                0x11,
                0xB5,
                0xD6,
                0x00,
                0xC0,
                0x4F,
                0xD9,
                0x18,
                0xD0,
                0x00,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_FlagColor
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xDE,
                0x94,
                0xDF,
                0x67,
                0xA7,
                0x0C,
                0x6F,
                0x4D,
                0xB7,
                0x92,
                0x05,
                0x3A,
                0x3E,
                0x4F,
                0x03,
                0xCF,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_FlagColorText
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x47,
                0xE7,
                0xEA,
                0x45,
                0x2A,
                0x8E,
                0xAE,
                0x40,
                0x8C,
                0xBF,
                0xCA,
                0x52,
                0xAB,
                0xA6,
                0x15,
                0x2A,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_FlagStatus
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x4C,
                0x58,
                0xE0,
                0xE3,
                0x88,
                0xB7,
                0x5A,
                0x4A,
                0xBB,
                0x20,
                0x7F,
                0x5A,
                0x44,
                0xC9,
                0xAC,
                0xDD,
                0x0C,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_FlagStatusText
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x2E,
                0xFD,
                0x54,
                0xDC,
                0x9D,
                0x18,
                0x71,
                0x48,
                0xAA,
                0x01,
                0x08,
                0xC2,
                0xF5,
                0x7A,
                0x4A,
                0xBC,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_FolderKind
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x53,
                0xF1,
                0xEF,
                0xFC,
                0x39,
                0xE8,
                0xF3,
                0x4C,
                0xA9,
                0xE7,
                0xEA,
                0x22,
                0x83,
                0x20,
                0x94,
                0xB8,
                0x65,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_FolderNameDisplay
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x30,
                0xF1,
                0x25,
                0xB7,
                0xEF,
                0x47,
                0x1A,
                0x10,
                0xA5,
                0xF1,
                0x02,
                0x60,
                0x8C,
                0x9E,
                0xEB,
                0xAC,
                0x19,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_FreeSpace
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x35,
                0x4B,
                0x17,
                0x9B,
                0xFF,
                0x40,
                0xD2,
                0x11,
                0xA2,
                0x7E,
                0x00,
                0xC0,
                0x4F,
                0xC3,
                0x08,
                0x71,
                0x02,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_FullText
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x40,
                0xE8,
                0x3E,
                0x1E,
                0x2B,
                0xBC,
                0x6C,
                0x47,
                0x82,
                0x37,
                0x2A,
                0xCD,
                0x1A,
                0x83,
                0x9B,
                0x22,
                0x06,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_HighKeywords
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE0,
                0x85,
                0x9F,
                0xF2,
                0xF9,
                0x4F,
                0x68,
                0x10,
                0xAB,
                0x91,
                0x08,
                0x00,
                0x2B,
                0x27,
                0xB3,
                0xD9,
                0x18,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Identity
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xFC,
                0x4A,
                0x6F,
                0xA2,
                0x46,
                0x73,
                0x99,
                0x42,
                0xBE,
                0x47,
                0xEB,
                0x1A,
                0xE6,
                0x13,
                0x13,
                0x9F,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Identity_Blob
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA4,
                0x93,
                0x3B,
                0x8C,
                0xED,
                0xBA,
                0x83,
                0x1A,
                0x9A,
                0x32,
                0x10,
                0x2E,
                0xE3,
                0x13,
                0xF6,
                0xEB,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Identity_DisplayName
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC9,
                0x3F,
                0x68,
                0x7D,
                0x55,
                0xD1,
                0xA8,
                0x45,
                0xBB,
                0x1F,
                0x89,
                0xD1,
                0x9B,
                0xCB,
                0x79,
                0x2F,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Identity_InternetSid
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x49,
                0x5D,
                0x6D,
                0x6D,
                0x5D,
                0x26,
                0x88,
                0x46,
                0x9F,
                0x4E,
                0x1F,
                0xDD,
                0x33,
                0xE7,
                0xCC,
                0x83,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Identity_IsMeIdentity
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x08,
                0x87,
                0x10,
                0xA4,
                0xDF,
                0x09,
                0x77,
                0x43,
                0x9D,
                0xFC,
                0x6D,
                0x99,
                0x98,
                0x6D,
                0x5A,
                0x67,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Identity_KeyProviderContext
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xFC,
                0x4A,
                0x6F,
                0xA2,
                0x46,
                0x73,
                0x99,
                0x42,
                0xBE,
                0x47,
                0xEB,
                0x1A,
                0xE6,
                0x13,
                0x13,
                0x9F,
                0x11,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Identity_KeyProviderName
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xFC,
                0x4A,
                0x6F,
                0xA2,
                0x46,
                0x73,
                0x99,
                0x42,
                0xBE,
                0x47,
                0xEB,
                0x1A,
                0xE6,
                0x13,
                0x13,
                0x9F,
                0x10,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Identity_LogonStatusString
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF3,
                0xED,
                0x8D,
                0xF1,
                0x7F,
                0x33,
                0xC0,
                0x42,
                0x9E,
                0x03,
                0xCE,
                0xE0,
                0x87,
                0x08,
                0xA8,
                0xC3,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Identity_PrimaryEmailAddress
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x23,
                0x68,
                0xC1,
                0xFC,
                0xED,
                0xBA,
                0x24,
                0x4F,
                0x9B,
                0x32,
                0xA0,
                0x98,
                0x21,
                0x17,
                0xF7,
                0xFA,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Identity_PrimarySid
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x1E,
                0x80,
                0x1B,
                0x2B,
                0xC1,
                0xC0,
                0x87,
                0x49,
                0x9E,
                0xC5,
                0x72,
                0xFA,
                0x89,
                0x81,
                0x47,
                0x87,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Identity_ProviderData
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x92,
                0x4B,
                0xA7,
                0xA8,
                0x1B,
                0x36,
                0x9A,
                0x4E,
                0xB7,
                0x22,
                0x7C,
                0x4A,
                0x73,
                0x30,
                0xA3,
                0x12,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Identity_ProviderID
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x49,
                0xDE,
                0xA7,
                0x74,
                0x11,
                0xFA,
                0x3D,
                0x4D,
                0xA0,
                0x06,
                0xDB,
                0x7E,
                0x08,
                0x67,
                0x59,
                0x16,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Identity_QualifiedUserName
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x51,
                0x0E,
                0x52,
                0xDA,
                0xE9,
                0xF4,
                0x39,
                0x47,
                0xAC,
                0x82,
                0x02,
                0xE0,
                0xA9,
                0x5C,
                0x90,
                0x30,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Identity_UniqueID
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB0,
                0xC3,
                0x5F,
                0xE5,
                0x60,
                0x2B,
                0x20,
                0x42,
                0x91,
                0x8E,
                0xB2,
                0x1E,
                0x8B,
                0xF1,
                0x60,
                0x16,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Identity_UserName
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x03,
                0x25,
                0x32,
                0xC4,
                0xCA,
                0x78,
                0xC6,
                0x49,
                0x9A,
                0xCC,
                0xA6,
                0x8E,
                0x2A,
                0xFD,
                0x7B,
                0x6B,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_IdentityProvider_Name
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x7B,
                0xFF,
                0x6E,
                0xB9,
                0xCA,
                0x35,
                0x35,
                0x4A,
                0x86,
                0x07,
                0x29,
                0xE3,
                0xA5,
                0x4C,
                0x46,
                0xEA,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_IdentityProvider_Picture
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x6F,
                0x16,
                0x25,
                0x24,
                0x42,
                0x56,
                0x64,
                0x48,
                0x99,
                0x2F,
                0x98,
                0xFD,
                0x98,
                0xF2,
                0x94,
                0xC3,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_ImageParsingName
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE0,
                0x0E,
                0x75,
                0xD7,
                0xA4,
                0xC6,
                0xEC,
                0x48,
                0xB5,
                0x3E,
                0xB8,
                0x7B,
                0x52,
                0xE6,
                0xD0,
                0x73,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Importance
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x4C,
                0x58,
                0xE0,
                0xE3,
                0x88,
                0xB7,
                0x5A,
                0x4A,
                0xBB,
                0x20,
                0x7F,
                0x5A,
                0x44,
                0xC9,
                0xAC,
                0xDD,
                0x0B,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_ImportanceText
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x91,
                0x97,
                0xB2,
                0xA3,
                0x13,
                0x77,
                0x1D,
                0x4E,
                0xBB,
                0x40,
                0x17,
                0xDB,
                0x85,
                0xF0,
                0x18,
                0x31,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_IsAttachment
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x5C,
                0x42,
                0x3F,
                0xF2,
                0xA1,
                0x71,
                0xA8,
                0x4F,
                0x92,
                0x2F,
                0x67,
                0x8E,
                0xA4,
                0xA6,
                0x04,
                0x08,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_IsDefaultNonOwnerSaveLocation
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x7F,
                0xB6,
                0x76,
                0x5D,
                0x3D,
                0x9B,
                0xBB,
                0x44,
                0xB6,
                0xAE,
                0x25,
                0xDA,
                0x4F,
                0x63,
                0x8A,
                0x67,
                0x05,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_IsDefaultSaveLocation
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x7F,
                0xB6,
                0x76,
                0x5D,
                0x3D,
                0x9B,
                0xBB,
                0x44,
                0xB6,
                0xAE,
                0x25,
                0xDA,
                0x4F,
                0x63,
                0x8A,
                0x67,
                0x03,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_IsDeleted
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC8,
                0x5F,
                0xDA,
                0x5C,
                0xEE,
                0x33,
                0xF3,
                0x4F,
                0x90,
                0x94,
                0xAE,
                0x7B,
                0xD8,
                0x86,
                0x8C,
                0x4D,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_IsEncrypted
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x4E,
                0xE1,
                0xE5,
                0x90,
                0x8B,
                0x64,
                0x26,
                0x48,
                0xB2,
                0xAA,
                0xAC,
                0xAF,
                0x79,
                0x0E,
                0x35,
                0x13,
                0x0A,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_IsFlagged
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x65,
                0x47,
                0xA8,
                0x5D,
                0xFF,
                0xE3,
                0x78,
                0x42,
                0x86,
                0xB0,
                0xA2,
                0x79,
                0x67,
                0xFB,
                0xDD,
                0x03,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_IsFlaggedComplete
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD2,
                0x60,
                0xF3,
                0xA6,
                0xF9,
                0x55,
                0xDE,
                0x48,
                0xB9,
                0x09,
                0x62,
                0x0E,
                0x09,
                0x0A,
                0x64,
                0x7C,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_IsIncomplete
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD1,
                0x8B,
                0x6C,
                0x34,
                0x6A,
                0x2E,
                0x45,
                0x4C,
                0x89,
                0xA4,
                0x61,
                0xB7,
                0x8E,
                0x8E,
                0x70,
                0x0F,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_IsLocationSupported
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x7F,
                0xB6,
                0x76,
                0x5D,
                0x3D,
                0x9B,
                0xBB,
                0x44,
                0xB6,
                0xAE,
                0x25,
                0xDA,
                0x4F,
                0x63,
                0x8A,
                0x67,
                0x08,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_IsPinnedToNameSpaceTree
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x7F,
                0xB6,
                0x76,
                0x5D,
                0x3D,
                0x9B,
                0xBB,
                0x44,
                0xB6,
                0xAE,
                0x25,
                0xDA,
                0x4F,
                0x63,
                0x8A,
                0x67,
                0x02,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_IsRead
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x4C,
                0x58,
                0xE0,
                0xE3,
                0x88,
                0xB7,
                0x5A,
                0x4A,
                0xBB,
                0x20,
                0x7F,
                0x5A,
                0x44,
                0xC9,
                0xAC,
                0xDD,
                0x0A,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_IsSearchOnlyItem
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x7F,
                0xB6,
                0x76,
                0x5D,
                0x3D,
                0x9B,
                0xBB,
                0x44,
                0xB6,
                0xAE,
                0x25,
                0xDA,
                0x4F,
                0x63,
                0x8A,
                0x67,
                0x04,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_IsSendToTarget
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA6,
                0x6A,
                0x63,
                0x28,
                0x3D,
                0x95,
                0xD2,
                0x11,
                0xB5,
                0xD6,
                0x00,
                0xC0,
                0x4F,
                0xD9,
                0x18,
                0xD0,
                0x21,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_IsShared
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x5B,
                0x4C,
                0x88,
                0xEF,
                0xFE,
                0x2B,
                0xBB,
                0x41,
                0xAA,
                0xE5,
                0x76,
                0xEE,
                0xDF,
                0x4F,
                0x99,
                0x02,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_ItemAuthors
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x0A,
                0x4F,
                0xA0,
                0xD0,
                0x2A,
                0x46,
                0xA4,
                0x48,
                0xBB,
                0x2F,
                0x37,
                0x06,
                0xE8,
                0x8D,
                0xBD,
                0x7D,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_ItemClassType
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xAD,
                0x58,
                0x86,
                0x04,
                0xB8,
                0x2D,
                0xA4,
                0x41,
                0xBB,
                0xB6,
                0xAC,
                0x1E,
                0xF1,
                0x20,
                0x7E,
                0xB1,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_ItemDate
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB4,
                0x74,
                0xDB,
                0xF7,
                0x87,
                0x42,
                0x03,
                0x41,
                0xAF,
                0xBA,
                0xF1,
                0xB1,
                0x3D,
                0xCD,
                0x75,
                0xCF,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_ItemFolderNameDisplay
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x30,
                0xF1,
                0x25,
                0xB7,
                0xEF,
                0x47,
                0x1A,
                0x10,
                0xA5,
                0xF1,
                0x02,
                0x60,
                0x8C,
                0x9E,
                0xEB,
                0xAC,
                0x02,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_ItemFolderPathDisplay
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x4C,
                0x58,
                0xE0,
                0xE3,
                0x88,
                0xB7,
                0x5A,
                0x4A,
                0xBB,
                0x20,
                0x7F,
                0x5A,
                0x44,
                0xC9,
                0xAC,
                0xDD,
                0x06,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_ItemFolderPathDisplayNarrow
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xED,
                0x30,
                0xBD,
                0xDA,
                0x43,
                0x00,
                0x89,
                0x47,
                0xA7,
                0xF8,
                0xD0,
                0x13,
                0xA4,
                0x73,
                0x66,
                0x22,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_ItemName
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x74,
                0xA0,
                0x8D,
                0x6B,
                0x5C,
                0x3B,
                0xBC,
                0x43,
                0x88,
                0x6F,
                0x0A,
                0x2C,
                0xDC,
                0xE0,
                0x0B,
                0x6F,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_ItemNameDisplay
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x30,
                0xF1,
                0x25,
                0xB7,
                0xEF,
                0x47,
                0x1A,
                0x10,
                0xA5,
                0xF1,
                0x02,
                0x60,
                0x8C,
                0x9E,
                0xEB,
                0xAC,
                0x0A,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_ItemNameDisplayWithoutExtension
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x30,
                0xF1,
                0x25,
                0xB7,
                0xEF,
                0x47,
                0x1A,
                0x10,
                0xA5,
                0xF1,
                0x02,
                0x60,
                0x8C,
                0x9E,
                0xEB,
                0xAC,
                0x18,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_ItemNamePrefix
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF1,
                0x3F,
                0x31,
                0xD7,
                0x7A,
                0xA7,
                0x1C,
                0x40,
                0x8C,
                0x99,
                0x3D,
                0xBD,
                0xD6,
                0x8A,
                0xDD,
                0x36,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_ItemNameSortOverride
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x30,
                0xF1,
                0x25,
                0xB7,
                0xEF,
                0x47,
                0x1A,
                0x10,
                0xA5,
                0xF1,
                0x02,
                0x60,
                0x8C,
                0x9E,
                0xEB,
                0xAC,
                0x17,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_ItemParticipants
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x16,
                0xAA,
                0xD0,
                0xD4,
                0x48,
                0x99,
                0xA4,
                0x41,
                0xAA,
                0x85,
                0xD9,
                0x7F,
                0xF9,
                0x64,
                0x69,
                0x93,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_ItemPathDisplay
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x4C,
                0x58,
                0xE0,
                0xE3,
                0x88,
                0xB7,
                0x5A,
                0x4A,
                0xBB,
                0x20,
                0x7F,
                0x5A,
                0x44,
                0xC9,
                0xAC,
                0xDD,
                0x07,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_ItemPathDisplayNarrow
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA6,
                0x6A,
                0x63,
                0x28,
                0x3D,
                0x95,
                0xD2,
                0x11,
                0xB5,
                0xD6,
                0x00,
                0xC0,
                0x4F,
                0xD9,
                0x18,
                0xD0,
                0x08,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_ItemSubType
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA6,
                0x6A,
                0x63,
                0x28,
                0x3D,
                0x95,
                0xD2,
                0x11,
                0xB5,
                0xD6,
                0x00,
                0xC0,
                0x4F,
                0xD9,
                0x18,
                0xD0,
                0x25,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_ItemType
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA6,
                0x6A,
                0x63,
                0x28,
                0x3D,
                0x95,
                0xD2,
                0x11,
                0xB5,
                0xD6,
                0x00,
                0xC0,
                0x4F,
                0xD9,
                0x18,
                0xD0,
                0x0B,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_ItemTypeText
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x30,
                0xF1,
                0x25,
                0xB7,
                0xEF,
                0x47,
                0x1A,
                0x10,
                0xA5,
                0xF1,
                0x02,
                0x60,
                0x8C,
                0x9E,
                0xEB,
                0xAC,
                0x04,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_ItemUrl
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x90,
                0x1C,
                0x69,
                0x49,
                0x17,
                0x7E,
                0x1A,
                0x10,
                0xA9,
                0x1C,
                0x08,
                0x00,
                0x2B,
                0x2E,
                0xCD,
                0xA9,
                0x09,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Keywords
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE0,
                0x85,
                0x9F,
                0xF2,
                0xF9,
                0x4F,
                0x68,
                0x10,
                0xAB,
                0x91,
                0x08,
                0x00,
                0x2B,
                0x27,
                0xB3,
                0xD9,
                0x05,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Kind
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x40,
                0xE8,
                0x3E,
                0x1E,
                0x2B,
                0xBC,
                0x6C,
                0x47,
                0x82,
                0x37,
                0x2A,
                0xCD,
                0x1A,
                0x83,
                0x9B,
                0x22,
                0x03,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_KindText
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x95,
                0xEF,
                0x4B,
                0xF0,
                0x85,
                0xC5,
                0x97,
                0x41,
                0xA2,
                0xB7,
                0xDF,
                0x46,
                0xFD,
                0xC9,
                0xEE,
                0x6D,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Language
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x02,
                0xD5,
                0xCD,
                0xD5,
                0x9C,
                0x2E,
                0x1B,
                0x10,
                0x93,
                0x97,
                0x08,
                0x00,
                0x2B,
                0x2C,
                0xF9,
                0xAE,
                0x1C,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_LastSyncError
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x53,
                0xF1,
                0xEF,
                0xFC,
                0x39,
                0xE8,
                0xF3,
                0x4C,
                0xA9,
                0xE7,
                0xEA,
                0x22,
                0x83,
                0x20,
                0x94,
                0xB8,
                0x6B,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_LastSyncWarning
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x53,
                0xF1,
                0xEF,
                0xFC,
                0x39,
                0xE8,
                0xF3,
                0x4C,
                0xA9,
                0xE7,
                0xEA,
                0x22,
                0x83,
                0x20,
                0x94,
                0xB8,
                0x80,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_LastWriterPackageFamilyName
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xAB,
                0xFE,
                0x2C,
                0x50,
                0xEB,
                0x47,
                0x9C,
                0x45,
                0xB9,
                0x60,
                0xE6,
                0xD8,
                0x72,
                0x8F,
                0x77,
                0x01,
                0x65,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_LowKeywords
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE0,
                0x85,
                0x9F,
                0xF2,
                0xF9,
                0x4F,
                0x68,
                0x10,
                0xAB,
                0x91,
                0x08,
                0x00,
                0x2B,
                0x27,
                0xB3,
                0xD9,
                0x19,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_MediumKeywords
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE0,
                0x85,
                0x9F,
                0xF2,
                0xF9,
                0x4F,
                0x68,
                0x10,
                0xAB,
                0x91,
                0x08,
                0x00,
                0x2B,
                0x27,
                0xB3,
                0xD9,
                0x1A,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_MileageInformation
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x70,
                0x43,
                0xF8,
                0xFD,
                0x1A,
                0x03,
                0xDD,
                0x4A,
                0x9E,
                0x91,
                0x0D,
                0x77,
                0x5F,
                0x1C,
                0x66,
                0x05,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_MIMEType
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x50,
                0xE3,
                0x63,
                0x0B,
                0xCC,
                0x9C,
                0xD0,
                0x11,
                0xBC,
                0xDB,
                0x00,
                0x80,
                0x5F,
                0xCC,
                0xCE,
                0x04,
                0x05,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Null
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x00,
                0x00,
                0x00,
                0x00,
                0x00,
                0x00,
                0x00,
                0x00,
                0x00,
                0x00,
                0x00,
                0x00,
                0x00,
                0x00,
                0x00,
                0x00,
                0x00,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_OfflineAvailability
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB6,
                0x88,
                0x46,
                0xA9,
                0x9F,
                0x7D,
                0x70,
                0x45,
                0xA6,
                0x48,
                0xE3,
                0xDF,
                0xC0,
                0xAB,
                0x2B,
                0x3F,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_OfflineStatus
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x8F,
                0x88,
                0x24,
                0x6D,
                0x18,
                0x47,
                0xDA,
                0x4B,
                0xAF,
                0xED,
                0xEA,
                0x0F,
                0xB4,
                0x38,
                0x6C,
                0xD8,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_OriginalFileName
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x53,
                0x7D,
                0xEF,
                0x0C,
                0x64,
                0xFA,
                0xD1,
                0x11,
                0xA2,
                0x03,
                0x00,
                0x00,
                0xF8,
                0x1F,
                0xED,
                0xEE,
                0x06,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_OwnerSID
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x7F,
                0xB6,
                0x76,
                0x5D,
                0x3D,
                0x9B,
                0xBB,
                0x44,
                0xB6,
                0xAE,
                0x25,
                0xDA,
                0x4F,
                0x63,
                0x8A,
                0x67,
                0x06,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_ParentalRating
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x92,
                0x04,
                0x44,
                0x64,
                0x8B,
                0x4C,
                0xD1,
                0x11,
                0x8B,
                0x70,
                0x08,
                0x00,
                0x36,
                0xB1,
                0x1A,
                0x03,
                0x15,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_ParentalRatingReason
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x0A,
                0x4E,
                0x98,
                0x10,
                0xF2,
                0xF9,
                0x21,
                0x43,
                0xB7,
                0xEF,
                0xBA,
                0xF1,
                0x95,
                0xAF,
                0x43,
                0x19,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_ParentalRatingsOrganization
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x40,
                0x08,
                0xFE,
                0xA7,
                0x44,
                0x13,
                0xF0,
                0x46,
                0x8D,
                0x37,
                0x52,
                0xED,
                0x71,
                0x2A,
                0x4B,
                0xF9,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_ParsingBindContext
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x4D,
                0xA0,
                0xB9,
                0xDF,
                0x2F,
                0x36,
                0xA3,
                0x4C,
                0xB3,
                0x0B,
                0x02,
                0x54,
                0xB1,
                0x7B,
                0x5B,
                0x84,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_ParsingName
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA6,
                0x6A,
                0x63,
                0x28,
                0x3D,
                0x95,
                0xD2,
                0x11,
                0xB5,
                0xD6,
                0x00,
                0xC0,
                0x4F,
                0xD9,
                0x18,
                0xD0,
                0x18,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_ParsingPath
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA6,
                0x6A,
                0x63,
                0x28,
                0x3D,
                0x95,
                0xD2,
                0x11,
                0xB5,
                0xD6,
                0x00,
                0xC0,
                0x4F,
                0xD9,
                0x18,
                0xD0,
                0x1E,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_PerceivedType
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA6,
                0x6A,
                0x63,
                0x28,
                0x3D,
                0x95,
                0xD2,
                0x11,
                0xB5,
                0xD6,
                0x00,
                0xC0,
                0x4F,
                0xD9,
                0x18,
                0xD0,
                0x09,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_PercentFull
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x35,
                0x4B,
                0x17,
                0x9B,
                0xFF,
                0x40,
                0xD2,
                0x11,
                0xA2,
                0x7E,
                0x00,
                0xC0,
                0x4F,
                0xC3,
                0x08,
                0x71,
                0x05,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Priority
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x74,
                0xCF,
                0x1F,
                0x9C,
                0x97,
                0x2D,
                0xBA,
                0x41,
                0xB4,
                0xAE,
                0xCB,
                0x2E,
                0x36,
                0x61,
                0xA6,
                0xE4,
                0x05,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_PriorityText
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x8B,
                0xE9,
                0x8B,
                0xD9,
                0x6B,
                0xB8,
                0x95,
                0x40,
                0xBF,
                0x52,
                0x9D,
                0x23,
                0xB2,
                0xE0,
                0xA7,
                0x52,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Project
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x22,
                0xF9,
                0xA7,
                0x39,
                0x7C,
                0x47,
                0xDE,
                0x48,
                0x8B,
                0xC8,
                0xB2,
                0x84,
                0x41,
                0xE3,
                0x42,
                0xE3,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_ProviderItemID
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x41,
                0x99,
                0x1D,
                0xF2,
                0xF0,
                0x81,
                0x1A,
                0x47,
                0xAD,
                0xEE,
                0x4E,
                0x74,
                0xB4,
                0x92,
                0x17,
                0xED,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Rating
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x92,
                0x04,
                0x44,
                0x64,
                0x8B,
                0x4C,
                0xD1,
                0x11,
                0x8B,
                0x70,
                0x08,
                0x00,
                0x36,
                0xB1,
                0x1A,
                0x03,
                0x09,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_RatingText
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA7,
                0x7C,
                0x19,
                0x90,
                0x8F,
                0xFD,
                0x8C,
                0x4E,
                0x9D,
                0xA3,
                0xB5,
                0x7E,
                0x1E,
                0x60,
                0x92,
                0x95,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_RemoteConflictingFile
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x53,
                0xF1,
                0xEF,
                0xFC,
                0x39,
                0xE8,
                0xF3,
                0x4C,
                0xA9,
                0xE7,
                0xEA,
                0x22,
                0x83,
                0x20,
                0x94,
                0xB8,
                0x73,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Security_AllowedEnterpriseDataProtectionIdentities
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x80,
                0x33,
                0xD4,
                0x38,
                0x18,
                0xD4,
                0x30,
                0x48,
                0x84,
                0xD5,
                0x46,
                0x93,
                0x5A,
                0x81,
                0xC5,
                0xC6,
                0x20,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Security_EncryptionOwners
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x6A,
                0xFF,
                0x5A,
                0x5F,
                0xE5,
                0x37,
                0x80,
                0x47,
                0x97,
                0xEA,
                0x80,
                0xC7,
                0x56,
                0x5C,
                0xF5,
                0x35,
                0x22,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Security_EncryptionOwnersDisplay
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x8F,
                0x1B,
                0x62,
                0xDE,
                0x25,
                0xE1,
                0xA3,
                0x43,
                0xA3,
                0x2D,
                0x56,
                0x65,
                0x44,
                0x6D,
                0x63,
                0x2A,
                0x19,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Sensitivity
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xAC,
                0xF6,
                0xD3,
                0xF8,
                0x74,
                0x48,
                0xCB,
                0x42,
                0xBE,
                0x59,
                0xAB,
                0x45,
                0x4B,
                0x30,
                0x71,
                0x6A,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_SensitivityText
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x54,
                0xF0,
                0xC7,
                0xD0,
                0x72,
                0x3F,
                0x25,
                0x47,
                0x85,
                0x27,
                0x12,
                0x9A,
                0x57,
                0x7C,
                0xB2,
                0x69,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_SFGAOFlags
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA6,
                0x6A,
                0x63,
                0x28,
                0x3D,
                0x95,
                0xD2,
                0x11,
                0xB5,
                0xD6,
                0x00,
                0xC0,
                0x4F,
                0xD9,
                0x18,
                0xD0,
                0x19,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_SharedWith
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x5B,
                0x4C,
                0x88,
                0xEF,
                0xFE,
                0x2B,
                0xBB,
                0x41,
                0xAA,
                0xE5,
                0x76,
                0xEE,
                0xDF,
                0x4F,
                0x99,
                0x02,
                0xC8,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_ShareUserRating
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x92,
                0x04,
                0x44,
                0x64,
                0x8B,
                0x4C,
                0xD1,
                0x11,
                0x8B,
                0x70,
                0x08,
                0x00,
                0x36,
                0xB1,
                0x1A,
                0x03,
                0x0C,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_SharingStatus
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x5B,
                0x4C,
                0x88,
                0xEF,
                0xFE,
                0x2B,
                0xBB,
                0x41,
                0xAA,
                0xE5,
                0x76,
                0xEE,
                0xDF,
                0x4F,
                0x99,
                0x02,
                0x2C,
                0x01,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Shell_OmitFromView
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x8C,
                0x25,
                0x35,
                0xDE,
                0x95,
                0xC6,
                0xBC,
                0x4C,
                0xB9,
                0x82,
                0x38,
                0xB0,
                0xAD,
                0x24,
                0xCE,
                0xD0,
                0x02,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_SimpleRating
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x4E,
                0x08,
                0x9F,
                0xA0,
                0x41,
                0xAD,
                0x9F,
                0x48,
                0x80,
                0x76,
                0xAA,
                0x5B,
                0xE3,
                0x08,
                0x2B,
                0xCA,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Size
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x30,
                0xF1,
                0x25,
                0xB7,
                0xEF,
                0x47,
                0x1A,
                0x10,
                0xA5,
                0xF1,
                0x02,
                0x60,
                0x8C,
                0x9E,
                0xEB,
                0xAC,
                0x0C,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_SoftwareUsed
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA1,
                0x1D,
                0xB8,
                0x14,
                0x35,
                0x01,
                0x31,
                0x4D,
                0x96,
                0xD9,
                0x6C,
                0xBF,
                0xC9,
                0x67,
                0x1A,
                0x99,
                0x31,
                0x01,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_SourceItem
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA5,
                0xDF,
                0x8C,
                0x66,
                0x1B,
                0x7A,
                0x23,
                0x43,
                0xAE,
                0x4B,
                0xE5,
                0x27,
                0x39,
                0x3A,
                0x1D,
                0x81,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_SourcePackageFamilyName
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB7,
                0x9D,
                0xAE,
                0xFF,
                0x8D,
                0x1C,
                0xFF,
                0x43,
                0x81,
                0x8C,
                0x84,
                0x40,
                0x3A,
                0xA3,
                0x73,
                0x2D,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_StartDate
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC8,
                0x6E,
                0xFD,
                0x48,
                0x12,
                0x8A,
                0xDF,
                0x4C,
                0xA0,
                0x3E,
                0x4E,
                0xC5,
                0xA5,
                0x11,
                0xED,
                0xDE,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Status
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA1,
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
                0x46,
                0x09,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_StorageProviderCallerVersionInformation
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD6,
                0xB9,
                0xF9,
                0xB2,
                0xC4,
                0xFE,
                0xD5,
                0x4D,
                0x94,
                0xD7,
                0x89,
                0x57,
                0x48,
                0x8C,
                0x80,
                0x7B,
                0x07,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_StorageProviderCustomPrimaryIcon
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD6,
                0xB9,
                0xF9,
                0xB2,
                0xC4,
                0xFE,
                0xD5,
                0x4D,
                0x94,
                0xD7,
                0x89,
                0x57,
                0x48,
                0x8C,
                0x80,
                0x7B,
                0x0C,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_StorageProviderError
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x53,
                0xF1,
                0xEF,
                0xFC,
                0x39,
                0xE8,
                0xF3,
                0x4C,
                0xA9,
                0xE7,
                0xEA,
                0x22,
                0x83,
                0x20,
                0x94,
                0xB8,
                0x6D,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_StorageProviderFileChecksum
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD6,
                0xB9,
                0xF9,
                0xB2,
                0xC4,
                0xFE,
                0xD5,
                0x4D,
                0x94,
                0xD7,
                0x89,
                0x57,
                0x48,
                0x8C,
                0x80,
                0x7B,
                0x05,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_StorageProviderFileCreatedBy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD6,
                0xB9,
                0xF9,
                0xB2,
                0xC4,
                0xFE,
                0xD5,
                0x4D,
                0x94,
                0xD7,
                0x89,
                0x57,
                0x48,
                0x8C,
                0x80,
                0x7B,
                0x0A,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_StorageProviderFileFlags
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD6,
                0xB9,
                0xF9,
                0xB2,
                0xC4,
                0xFE,
                0xD5,
                0x4D,
                0x94,
                0xD7,
                0x89,
                0x57,
                0x48,
                0x8C,
                0x80,
                0x7B,
                0x08,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_StorageProviderFileHasConflict
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD6,
                0xB9,
                0xF9,
                0xB2,
                0xC4,
                0xFE,
                0xD5,
                0x4D,
                0x94,
                0xD7,
                0x89,
                0x57,
                0x48,
                0x8C,
                0x80,
                0x7B,
                0x09,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_StorageProviderFileIdentifier
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD6,
                0xB9,
                0xF9,
                0xB2,
                0xC4,
                0xFE,
                0xD5,
                0x4D,
                0x94,
                0xD7,
                0x89,
                0x57,
                0x48,
                0x8C,
                0x80,
                0x7B,
                0x03,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_StorageProviderFileModifiedBy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD6,
                0xB9,
                0xF9,
                0xB2,
                0xC4,
                0xFE,
                0xD5,
                0x4D,
                0x94,
                0xD7,
                0x89,
                0x57,
                0x48,
                0x8C,
                0x80,
                0x7B,
                0x0B,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_StorageProviderFileRemoteUri
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x53,
                0xF1,
                0xEF,
                0xFC,
                0x39,
                0xE8,
                0xF3,
                0x4C,
                0xA9,
                0xE7,
                0xEA,
                0x22,
                0x83,
                0x20,
                0x94,
                0xB8,
                0x70,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_StorageProviderFileVersion
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD6,
                0xB9,
                0xF9,
                0xB2,
                0xC4,
                0xFE,
                0xD5,
                0x4D,
                0x94,
                0xD7,
                0x89,
                0x57,
                0x48,
                0x8C,
                0x80,
                0x7B,
                0x04,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_StorageProviderFileVersionWaterline
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD6,
                0xB9,
                0xF9,
                0xB2,
                0xC4,
                0xFE,
                0xD5,
                0x4D,
                0x94,
                0xD7,
                0x89,
                0x57,
                0x48,
                0x8C,
                0x80,
                0x7B,
                0x06,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_StorageProviderId
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x53,
                0xF1,
                0xEF,
                0xFC,
                0x39,
                0xE8,
                0xF3,
                0x4C,
                0xA9,
                0xE7,
                0xEA,
                0x22,
                0x83,
                0x20,
                0x94,
                0xB8,
                0x6C,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_StorageProviderShareStatuses
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x53,
                0xF1,
                0xEF,
                0xFC,
                0x39,
                0xE8,
                0xF3,
                0x4C,
                0xA9,
                0xE7,
                0xEA,
                0x22,
                0x83,
                0x20,
                0x94,
                0xB8,
                0x6F,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_StorageProviderSharingStatus
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x53,
                0xF1,
                0xEF,
                0xFC,
                0x39,
                0xE8,
                0xF3,
                0x4C,
                0xA9,
                0xE7,
                0xEA,
                0x22,
                0x83,
                0x20,
                0x94,
                0xB8,
                0x75,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_StorageProviderStatus
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x53,
                0xF1,
                0xEF,
                0xFC,
                0x39,
                0xE8,
                0xF3,
                0x4C,
                0xA9,
                0xE7,
                0xEA,
                0x22,
                0x83,
                0x20,
                0x94,
                0xB8,
                0x6E,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Subject
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE0,
                0x85,
                0x9F,
                0xF2,
                0xF9,
                0x4F,
                0x68,
                0x10,
                0xAB,
                0x91,
                0x08,
                0x00,
                0x2B,
                0x27,
                0xB3,
                0xD9,
                0x03,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_SyncTransferStatus
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x53,
                0xF1,
                0xEF,
                0xFC,
                0x39,
                0xE8,
                0xF3,
                0x4C,
                0xA9,
                0xE7,
                0xEA,
                0x22,
                0x83,
                0x20,
                0x94,
                0xB8,
                0x67,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Thumbnail
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE0,
                0x85,
                0x9F,
                0xF2,
                0xF9,
                0x4F,
                0x68,
                0x10,
                0xAB,
                0x91,
                0x08,
                0x00,
                0x2B,
                0x27,
                0xB3,
                0xD9,
                0x11,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_ThumbnailCacheId
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB1,
                0x16,
                0x6D,
                0x44,
                0xAD,
                0x8D,
                0x70,
                0x48,
                0xA7,
                0x48,
                0x40,
                0x2E,
                0xA4,
                0x3D,
                0x78,
                0x8C,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_ThumbnailStream
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE0,
                0x85,
                0x9F,
                0xF2,
                0xF9,
                0x4F,
                0x68,
                0x10,
                0xAB,
                0x91,
                0x08,
                0x00,
                0x2B,
                0x27,
                0xB3,
                0xD9,
                0x1B,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Title
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE0,
                0x85,
                0x9F,
                0xF2,
                0xF9,
                0x4F,
                0x68,
                0x10,
                0xAB,
                0x91,
                0x08,
                0x00,
                0x2B,
                0x27,
                0xB3,
                0xD9,
                0x02,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_TitleSortOverride
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x4D,
                0x98,
                0xF7,
                0xF0,
                0x2E,
                0x22,
                0xD2,
                0x4A,
                0x82,
                0xAB,
                0x1D,
                0xD8,
                0xEA,
                0x40,
                0xE5,
                0x7E,
                0x2C,
                0x01,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_TotalFileSize
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA6,
                0x6A,
                0x63,
                0x28,
                0x3D,
                0x95,
                0xD2,
                0x11,
                0xB5,
                0xD6,
                0x00,
                0xC0,
                0x4F,
                0xD9,
                0x18,
                0xD0,
                0x0E,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Trademarks
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x53,
                0x7D,
                0xEF,
                0x0C,
                0x64,
                0xFA,
                0xD1,
                0x11,
                0xA2,
                0x03,
                0x00,
                0x00,
                0xF8,
                0x1F,
                0xED,
                0xEE,
                0x09,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_TransferOrder
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x53,
                0xF1,
                0xEF,
                0xFC,
                0x39,
                0xE8,
                0xF3,
                0x4C,
                0xA9,
                0xE7,
                0xEA,
                0x22,
                0x83,
                0x20,
                0x94,
                0xB8,
                0x6A,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_TransferPosition
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x53,
                0xF1,
                0xEF,
                0xFC,
                0x39,
                0xE8,
                0xF3,
                0x4C,
                0xA9,
                0xE7,
                0xEA,
                0x22,
                0x83,
                0x20,
                0x94,
                0xB8,
                0x68,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_TransferSize
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x53,
                0xF1,
                0xEF,
                0xFC,
                0x39,
                0xE8,
                0xF3,
                0x4C,
                0xA9,
                0xE7,
                0xEA,
                0x22,
                0x83,
                0x20,
                0x94,
                0xB8,
                0x69,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_VolumeId
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB1,
                0x16,
                0x6D,
                0x44,
                0xAD,
                0x8D,
                0x70,
                0x48,
                0xA7,
                0x48,
                0x40,
                0x2E,
                0xA4,
                0x3D,
                0x78,
                0x8C,
                0x68,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_ZoneIdentifier
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xAB,
                0xFE,
                0x2C,
                0x50,
                0xEB,
                0x47,
                0x9C,
                0x45,
                0xB9,
                0x60,
                0xE6,
                0xD8,
                0x72,
                0x8F,
                0x77,
                0x01,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Device_PrinterURL
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x5A,
                0xF3,
                0x48,
                0x0B,
                0x6E,
                0xBE,
                0x17,
                0x4F,
                0xB1,
                0x08,
                0x3C,
                0x40,
                0x73,
                0xD1,
                0x66,
                0x9A,
                0x0F,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_DeviceInterface_Bluetooth_DeviceAddress
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x8B,
                0x7D,
                0xD6,
                0x2B,
                0xEB,
                0x8B,
                0xD5,
                0x48,
                0x87,
                0xE0,
                0x6C,
                0xDA,
                0x34,
                0x28,
                0x04,
                0x0A,
                0x01,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_DeviceInterface_Bluetooth_Flags
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x8B,
                0x7D,
                0xD6,
                0x2B,
                0xEB,
                0x8B,
                0xD5,
                0x48,
                0x87,
                0xE0,
                0x6C,
                0xDA,
                0x34,
                0x28,
                0x04,
                0x0A,
                0x03,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_DeviceInterface_Bluetooth_LastConnectedTime
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x8B,
                0x7D,
                0xD6,
                0x2B,
                0xEB,
                0x8B,
                0xD5,
                0x48,
                0x87,
                0xE0,
                0x6C,
                0xDA,
                0x34,
                0x28,
                0x04,
                0x0A,
                0x0B,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_DeviceInterface_Bluetooth_Manufacturer
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x8B,
                0x7D,
                0xD6,
                0x2B,
                0xEB,
                0x8B,
                0xD5,
                0x48,
                0x87,
                0xE0,
                0x6C,
                0xDA,
                0x34,
                0x28,
                0x04,
                0x0A,
                0x04,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_DeviceInterface_Bluetooth_ModelNumber
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x8B,
                0x7D,
                0xD6,
                0x2B,
                0xEB,
                0x8B,
                0xD5,
                0x48,
                0x87,
                0xE0,
                0x6C,
                0xDA,
                0x34,
                0x28,
                0x04,
                0x0A,
                0x05,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_DeviceInterface_Bluetooth_ProductId
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x8B,
                0x7D,
                0xD6,
                0x2B,
                0xEB,
                0x8B,
                0xD5,
                0x48,
                0x87,
                0xE0,
                0x6C,
                0xDA,
                0x34,
                0x28,
                0x04,
                0x0A,
                0x08,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_DeviceInterface_Bluetooth_ProductVersion
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x8B,
                0x7D,
                0xD6,
                0x2B,
                0xEB,
                0x8B,
                0xD5,
                0x48,
                0x87,
                0xE0,
                0x6C,
                0xDA,
                0x34,
                0x28,
                0x04,
                0x0A,
                0x09,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_DeviceInterface_Bluetooth_ServiceGuid
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x8B,
                0x7D,
                0xD6,
                0x2B,
                0xEB,
                0x8B,
                0xD5,
                0x48,
                0x87,
                0xE0,
                0x6C,
                0xDA,
                0x34,
                0x28,
                0x04,
                0x0A,
                0x02,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_DeviceInterface_Bluetooth_VendorId
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x8B,
                0x7D,
                0xD6,
                0x2B,
                0xEB,
                0x8B,
                0xD5,
                0x48,
                0x87,
                0xE0,
                0x6C,
                0xDA,
                0x34,
                0x28,
                0x04,
                0x0A,
                0x07,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_DeviceInterface_Bluetooth_VendorIdSource
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x8B,
                0x7D,
                0xD6,
                0x2B,
                0xEB,
                0x8B,
                0xD5,
                0x48,
                0x87,
                0xE0,
                0x6C,
                0xDA,
                0x34,
                0x28,
                0x04,
                0x0A,
                0x06,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_DeviceInterface_Hid_IsReadOnly
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x10,
                0x83,
                0xF3,
                0xCB,
                0x17,
                0x4A,
                0x10,
                0x43,
                0xA1,
                0xEB,
                0x24,
                0x7F,
                0x0B,
                0x67,
                0x59,
                0x3B,
                0x04,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_DeviceInterface_Hid_ProductId
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x10,
                0x83,
                0xF3,
                0xCB,
                0x17,
                0x4A,
                0x10,
                0x43,
                0xA1,
                0xEB,
                0x24,
                0x7F,
                0x0B,
                0x67,
                0x59,
                0x3B,
                0x06,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_DeviceInterface_Hid_UsageId
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x10,
                0x83,
                0xF3,
                0xCB,
                0x17,
                0x4A,
                0x10,
                0x43,
                0xA1,
                0xEB,
                0x24,
                0x7F,
                0x0B,
                0x67,
                0x59,
                0x3B,
                0x03,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_DeviceInterface_Hid_UsagePage
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x10,
                0x83,
                0xF3,
                0xCB,
                0x17,
                0x4A,
                0x10,
                0x43,
                0xA1,
                0xEB,
                0x24,
                0x7F,
                0x0B,
                0x67,
                0x59,
                0x3B,
                0x02,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_DeviceInterface_Hid_VendorId
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x10,
                0x83,
                0xF3,
                0xCB,
                0x17,
                0x4A,
                0x10,
                0x43,
                0xA1,
                0xEB,
                0x24,
                0x7F,
                0x0B,
                0x67,
                0x59,
                0x3B,
                0x05,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_DeviceInterface_Hid_VersionNumber
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x10,
                0x83,
                0xF3,
                0xCB,
                0x17,
                0x4A,
                0x10,
                0x43,
                0xA1,
                0xEB,
                0x24,
                0x7F,
                0x0B,
                0x67,
                0x59,
                0x3B,
                0x07,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_DeviceInterface_PrinterDriverDirectory
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xDE,
                0x66,
                0x7C,
                0x84,
                0xD6,
                0xB8,
                0xF9,
                0x4A,
                0xAB,
                0xC3,
                0x6F,
                0x4F,
                0x92,
                0x6B,
                0xC0,
                0x39,
                0x0E,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_DeviceInterface_PrinterDriverName
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x70,
                0x71,
                0xC4,
                0xAF,
                0xF5,
                0x14,
                0x8C,
                0x49,
                0x8F,
                0x30,
                0xB0,
                0xD1,
                0x9B,
                0xE4,
                0x49,
                0xC6,
                0x0B,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_DeviceInterface_PrinterEnumerationFlag
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA1,
                0x42,
                0x07,
                0xA0,
                0x8C,
                0xCD,
                0x37,
                0x4B,
                0x95,
                0xAB,
                0x70,
                0x75,
                0x55,
                0x87,
                0x76,
                0x7A,
                0x03,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_DeviceInterface_PrinterName
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xEF,
                0x84,
                0x7B,
                0x0A,
                0x27,
                0x0C,
                0x3F,
                0x46,
                0x84,
                0xEF,
                0x06,
                0xC5,
                0x07,
                0x00,
                0x01,
                0xBE,
                0x0A,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_DeviceInterface_PrinterPortName
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x61,
                0xB7,
                0xC7,
                0xEE,
                0x94,
                0x6F,
                0xB1,
                0x41,
                0x94,
                0x9F,
                0xC7,
                0x29,
                0x72,
                0x0D,
                0xD1,
                0x3C,
                0x0C,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_DeviceInterface_Proximity_SupportsNfc
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xCD,
                0x42,
                0x38,
                0xFB,
                0x2A,
                0x9E,
                0x83,
                0x4F,
                0x8F,
                0xCC,
                0x4B,
                0x07,
                0x61,
                0x13,
                0x9A,
                0xE9,
                0x02,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_DeviceInterface_Serial_PortName
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x5C,
                0xF1,
                0x6B,
                0x4C,
                0x03,
                0x4C,
                0xAC,
                0x4A,
                0x91,
                0xF5,
                0x64,
                0xC0,
                0xF8,
                0x52,
                0xBC,
                0xF4,
                0x04,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_DeviceInterface_Serial_UsbProductId
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x5C,
                0xF1,
                0x6B,
                0x4C,
                0x03,
                0x4C,
                0xAC,
                0x4A,
                0x91,
                0xF5,
                0x64,
                0xC0,
                0xF8,
                0x52,
                0xBC,
                0xF4,
                0x03,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_DeviceInterface_Serial_UsbVendorId
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x5C,
                0xF1,
                0x6B,
                0x4C,
                0x03,
                0x4C,
                0xAC,
                0x4A,
                0x91,
                0xF5,
                0x64,
                0xC0,
                0xF8,
                0x52,
                0xBC,
                0xF4,
                0x02,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_DeviceInterface_WinUsb_DeviceInterfaceClasses
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB5,
                0x27,
                0xE1,
                0x95,
                0xCC,
                0x79,
                0x83,
                0x4E,
                0x9C,
                0x9E,
                0x84,
                0x22,
                0x18,
                0x7B,
                0x3E,
                0x0E,
                0x07,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_DeviceInterface_WinUsb_UsbClass
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB5,
                0x27,
                0xE1,
                0x95,
                0xCC,
                0x79,
                0x83,
                0x4E,
                0x9C,
                0x9E,
                0x84,
                0x22,
                0x18,
                0x7B,
                0x3E,
                0x0E,
                0x04,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_DeviceInterface_WinUsb_UsbProductId
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB5,
                0x27,
                0xE1,
                0x95,
                0xCC,
                0x79,
                0x83,
                0x4E,
                0x9C,
                0x9E,
                0x84,
                0x22,
                0x18,
                0x7B,
                0x3E,
                0x0E,
                0x03,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_DeviceInterface_WinUsb_UsbProtocol
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB5,
                0x27,
                0xE1,
                0x95,
                0xCC,
                0x79,
                0x83,
                0x4E,
                0x9C,
                0x9E,
                0x84,
                0x22,
                0x18,
                0x7B,
                0x3E,
                0x0E,
                0x06,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_DeviceInterface_WinUsb_UsbSubClass
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB5,
                0x27,
                0xE1,
                0x95,
                0xCC,
                0x79,
                0x83,
                0x4E,
                0x9C,
                0x9E,
                0x84,
                0x22,
                0x18,
                0x7B,
                0x3E,
                0x0E,
                0x05,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_DeviceInterface_WinUsb_UsbVendorId
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB5,
                0x27,
                0xE1,
                0x95,
                0xCC,
                0x79,
                0x83,
                0x4E,
                0x9C,
                0x9E,
                0x84,
                0x22,
                0x18,
                0x7B,
                0x3E,
                0x0E,
                0x02,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Devices_Aep_AepId
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x06,
                0xE0,
                0x2C,
                0x3B,
                0x61,
                0x5E,
                0xDE,
                0x4F,
                0xBA,
                0xB8,
                0x9B,
                0x8A,
                0xAC,
                0x9B,
                0x26,
                0xDF,
                0x08,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Devices_Aep_Bluetooth_Cod_Major
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xCD,
                0x34,
                0xBD,
                0x5F,
                0x1A,
                0x56,
                0x2E,
                0x41,
                0xBA,
                0x98,
                0x47,
                0x8A,
                0x6B,
                0x0F,
                0xEF,
                0x1D,
                0x02,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Devices_Aep_Bluetooth_Cod_Minor
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xCD,
                0x34,
                0xBD,
                0x5F,
                0x1A,
                0x56,
                0x2E,
                0x41,
                0xBA,
                0x98,
                0x47,
                0x8A,
                0x6B,
                0x0F,
                0xEF,
                0x1D,
                0x03,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Devices_Aep_Bluetooth_Cod_Services_Audio
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xCD,
                0x34,
                0xBD,
                0x5F,
                0x1A,
                0x56,
                0x2E,
                0x41,
                0xBA,
                0x98,
                0x47,
                0x8A,
                0x6B,
                0x0F,
                0xEF,
                0x1D,
                0x0A,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Devices_Aep_Bluetooth_Cod_Services_Capturing
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xCD,
                0x34,
                0xBD,
                0x5F,
                0x1A,
                0x56,
                0x2E,
                0x41,
                0xBA,
                0x98,
                0x47,
                0x8A,
                0x6B,
                0x0F,
                0xEF,
                0x1D,
                0x08,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Devices_Aep_Bluetooth_Cod_Services_Information
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xCD,
                0x34,
                0xBD,
                0x5F,
                0x1A,
                0x56,
                0x2E,
                0x41,
                0xBA,
                0x98,
                0x47,
                0x8A,
                0x6B,
                0x0F,
                0xEF,
                0x1D,
                0x0C,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Devices_Aep_Bluetooth_Cod_Services_LimitedDiscovery
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xCD,
                0x34,
                0xBD,
                0x5F,
                0x1A,
                0x56,
                0x2E,
                0x41,
                0xBA,
                0x98,
                0x47,
                0x8A,
                0x6B,
                0x0F,
                0xEF,
                0x1D,
                0x04,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Devices_Aep_Bluetooth_Cod_Services_Networking
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xCD,
                0x34,
                0xBD,
                0x5F,
                0x1A,
                0x56,
                0x2E,
                0x41,
                0xBA,
                0x98,
                0x47,
                0x8A,
                0x6B,
                0x0F,
                0xEF,
                0x1D,
                0x06,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Devices_Aep_Bluetooth_Cod_Services_ObjectXfer
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xCD,
                0x34,
                0xBD,
                0x5F,
                0x1A,
                0x56,
                0x2E,
                0x41,
                0xBA,
                0x98,
                0x47,
                0x8A,
                0x6B,
                0x0F,
                0xEF,
                0x1D,
                0x09,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Devices_Aep_Bluetooth_Cod_Services_Positioning
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xCD,
                0x34,
                0xBD,
                0x5F,
                0x1A,
                0x56,
                0x2E,
                0x41,
                0xBA,
                0x98,
                0x47,
                0x8A,
                0x6B,
                0x0F,
                0xEF,
                0x1D,
                0x05,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Devices_Aep_Bluetooth_Cod_Services_Rendering
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xCD,
                0x34,
                0xBD,
                0x5F,
                0x1A,
                0x56,
                0x2E,
                0x41,
                0xBA,
                0x98,
                0x47,
                0x8A,
                0x6B,
                0x0F,
                0xEF,
                0x1D,
                0x07,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Devices_Aep_Bluetooth_Cod_Services_Telephony
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xCD,
                0x34,
                0xBD,
                0x5F,
                0x1A,
                0x56,
                0x2E,
                0x41,
                0xBA,
                0x98,
                0x47,
                0x8A,
                0x6B,
                0x0F,
                0xEF,
                0x1D,
                0x0B,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Devices_Aep_Bluetooth_LastSeenTime
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x8B,
                0x7D,
                0xD6,
                0x2B,
                0xEB,
                0x8B,
                0xD5,
                0x48,
                0x87,
                0xE0,
                0x6C,
                0xDA,
                0x34,
                0x28,
                0x04,
                0x0A,
                0x0C,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Devices_Aep_Bluetooth_Le_AddressType
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB0,
                0xF0,
                0x5E,
                0x99,
                0xB3,
                0x7E,
                0x8B,
                0x4A,
                0xB9,
                0xCE,
                0x06,
                0x8B,
                0xB3,
                0xF4,
                0xAF,
                0x69,
                0x04,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Devices_Aep_Bluetooth_Le_Appearance
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB0,
                0xF0,
                0x5E,
                0x99,
                0xB3,
                0x7E,
                0x8B,
                0x4A,
                0xB9,
                0xCE,
                0x06,
                0x8B,
                0xB3,
                0xF4,
                0xAF,
                0x69,
                0x01,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Devices_Aep_Bluetooth_Le_Appearance_Category
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB0,
                0xF0,
                0x5E,
                0x99,
                0xB3,
                0x7E,
                0x8B,
                0x4A,
                0xB9,
                0xCE,
                0x06,
                0x8B,
                0xB3,
                0xF4,
                0xAF,
                0x69,
                0x05,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Devices_Aep_Bluetooth_Le_Appearance_Subcategory
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB0,
                0xF0,
                0x5E,
                0x99,
                0xB3,
                0x7E,
                0x8B,
                0x4A,
                0xB9,
                0xCE,
                0x06,
                0x8B,
                0xB3,
                0xF4,
                0xAF,
                0x69,
                0x06,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Devices_Aep_Bluetooth_Le_IsCallControlClient
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB0,
                0xF0,
                0x5E,
                0x99,
                0xB3,
                0x7E,
                0x8B,
                0x4A,
                0xB9,
                0xCE,
                0x06,
                0x8B,
                0xB3,
                0xF4,
                0xAF,
                0x69,
                0x0C,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Devices_Aep_Bluetooth_Le_IsConnectable
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB0,
                0xF0,
                0x5E,
                0x99,
                0xB3,
                0x7E,
                0x8B,
                0x4A,
                0xB9,
                0xCE,
                0x06,
                0x8B,
                0xB3,
                0xF4,
                0xAF,
                0x69,
                0x08,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Devices_Aep_CanPair
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x29,
                0xFB,
                0xC3,
                0xE7,
                0xA7,
                0xCA,
                0x47,
                0x4F,
                0x8C,
                0x8B,
                0xBE,
                0x59,
                0xB3,
                0x30,
                0xD4,
                0xC5,
                0x03,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Devices_Aep_Category
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xAB,
                0x96,
                0x59,
                0xA3,
                0xCF,
                0x11,
                0x35,
                0x49,
                0x8B,
                0x61,
                0xA6,
                0x76,
                0x10,
                0x81,
                0xEC,
                0xDF,
                0x11,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Devices_Aep_ContainerId
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x29,
                0xFB,
                0xC3,
                0xE7,
                0xA7,
                0xCA,
                0x47,
                0x4F,
                0x8C,
                0x8B,
                0xBE,
                0x59,
                0xB3,
                0x30,
                0xD4,
                0xC5,
                0x02,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Devices_Aep_DeviceAddress
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xAB,
                0x96,
                0x59,
                0xA3,
                0xCF,
                0x11,
                0x35,
                0x49,
                0x8B,
                0x61,
                0xA6,
                0x76,
                0x10,
                0x81,
                0xEC,
                0xDF,
                0x0C,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Devices_Aep_IsConnected
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xAB,
                0x96,
                0x59,
                0xA3,
                0xCF,
                0x11,
                0x35,
                0x49,
                0x8B,
                0x61,
                0xA6,
                0x76,
                0x10,
                0x81,
                0xEC,
                0xDF,
                0x07,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Devices_Aep_IsPaired
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xAB,
                0x96,
                0x59,
                0xA3,
                0xCF,
                0x11,
                0x35,
                0x49,
                0x8B,
                0x61,
                0xA6,
                0x76,
                0x10,
                0x81,
                0xEC,
                0xDF,
                0x10,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Devices_Aep_IsPresent
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xAB,
                0x96,
                0x59,
                0xA3,
                0xCF,
                0x11,
                0x35,
                0x49,
                0x8B,
                0x61,
                0xA6,
                0x76,
                0x10,
                0x81,
                0xEC,
                0xDF,
                0x09,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Devices_Aep_Manufacturer
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xAB,
                0x96,
                0x59,
                0xA3,
                0xCF,
                0x11,
                0x35,
                0x49,
                0x8B,
                0x61,
                0xA6,
                0x76,
                0x10,
                0x81,
                0xEC,
                0xDF,
                0x05,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Devices_Aep_ModelId
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xAB,
                0x96,
                0x59,
                0xA3,
                0xCF,
                0x11,
                0x35,
                0x49,
                0x8B,
                0x61,
                0xA6,
                0x76,
                0x10,
                0x81,
                0xEC,
                0xDF,
                0x04,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Devices_Aep_ModelName
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xAB,
                0x96,
                0x59,
                0xA3,
                0xCF,
                0x11,
                0x35,
                0x49,
                0x8B,
                0x61,
                0xA6,
                0x76,
                0x10,
                0x81,
                0xEC,
                0xDF,
                0x03,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Devices_Aep_PointOfService_ConnectionTypes
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB3,
                0x61,
                0xBF,
                0xD4,
                0x2E,
                0x44,
                0xDA,
                0x4A,
                0x88,
                0x2D,
                0xFA,
                0x7B,
                0x70,
                0xC8,
                0x32,
                0xD9,
                0x06,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Devices_Aep_ProtocolId
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x06,
                0xE0,
                0x2C,
                0x3B,
                0x61,
                0x5E,
                0xDE,
                0x4F,
                0xBA,
                0xB8,
                0x9B,
                0x8A,
                0xAC,
                0x9B,
                0x26,
                0xDF,
                0x05,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Devices_Aep_SignalStrength
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xAB,
                0x96,
                0x59,
                0xA3,
                0xCF,
                0x11,
                0x35,
                0x49,
                0x8B,
                0x61,
                0xA6,
                0x76,
                0x10,
                0x81,
                0xEC,
                0xDF,
                0x06,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Devices_AepContainer_CanPair
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xDE,
                0x1E,
                0xBA,
                0x0B,
                0x66,
                0x75,
                0x47,
                0x4F,
                0x90,
                0xEC,
                0x25,
                0xFC,
                0x56,
                0x7C,
                0xED,
                0x2A,
                0x03,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Devices_AepContainer_Categories
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xDE,
                0x1E,
                0xBA,
                0x0B,
                0x66,
                0x75,
                0x47,
                0x4F,
                0x90,
                0xEC,
                0x25,
                0xFC,
                0x56,
                0x7C,
                0xED,
                0x2A,
                0x09,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Devices_AepContainer_Children
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xDE,
                0x1E,
                0xBA,
                0x0B,
                0x66,
                0x75,
                0x47,
                0x4F,
                0x90,
                0xEC,
                0x25,
                0xFC,
                0x56,
                0x7C,
                0xED,
                0x2A,
                0x02,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Devices_AepContainer_ContainerId
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xDE,
                0x1E,
                0xBA,
                0x0B,
                0x66,
                0x75,
                0x47,
                0x4F,
                0x90,
                0xEC,
                0x25,
                0xFC,
                0x56,
                0x7C,
                0xED,
                0x2A,
                0x0C,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Devices_AepContainer_DialProtocol_InstalledApplications
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x45,
                0x5D,
                0xF5,
                0x6A,
                0xDB,
                0x38,
                0x95,
                0x44,
                0xAC,
                0xB0,
                0xD4,
                0x72,
                0x8A,
                0x3B,
                0x83,
                0x14,
                0x06,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Devices_AepContainer_IsPaired
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xDE,
                0x1E,
                0xBA,
                0x0B,
                0x66,
                0x75,
                0x47,
                0x4F,
                0x90,
                0xEC,
                0x25,
                0xFC,
                0x56,
                0x7C,
                0xED,
                0x2A,
                0x04,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Devices_AepContainer_IsPresent
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xDE,
                0x1E,
                0xBA,
                0x0B,
                0x66,
                0x75,
                0x47,
                0x4F,
                0x90,
                0xEC,
                0x25,
                0xFC,
                0x56,
                0x7C,
                0xED,
                0x2A,
                0x0B,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Devices_AepContainer_Manufacturer
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xDE,
                0x1E,
                0xBA,
                0x0B,
                0x66,
                0x75,
                0x47,
                0x4F,
                0x90,
                0xEC,
                0x25,
                0xFC,
                0x56,
                0x7C,
                0xED,
                0x2A,
                0x06,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Devices_AepContainer_ModelIds
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xDE,
                0x1E,
                0xBA,
                0x0B,
                0x66,
                0x75,
                0x47,
                0x4F,
                0x90,
                0xEC,
                0x25,
                0xFC,
                0x56,
                0x7C,
                0xED,
                0x2A,
                0x08,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Devices_AepContainer_ModelName
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xDE,
                0x1E,
                0xBA,
                0x0B,
                0x66,
                0x75,
                0x47,
                0x4F,
                0x90,
                0xEC,
                0x25,
                0xFC,
                0x56,
                0x7C,
                0xED,
                0x2A,
                0x07,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Devices_AepContainer_ProtocolIds
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xDE,
                0x1E,
                0xBA,
                0x0B,
                0x66,
                0x75,
                0x47,
                0x4F,
                0x90,
                0xEC,
                0x25,
                0xFC,
                0x56,
                0x7C,
                0xED,
                0x2A,
                0x0D,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Devices_AepContainer_SupportedUriSchemes
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x45,
                0x5D,
                0xF5,
                0x6A,
                0xDB,
                0x38,
                0x95,
                0x44,
                0xAC,
                0xB0,
                0xD4,
                0x72,
                0x8A,
                0x3B,
                0x83,
                0x14,
                0x05,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Devices_AepContainer_SupportsAudio
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x45,
                0x5D,
                0xF5,
                0x6A,
                0xDB,
                0x38,
                0x95,
                0x44,
                0xAC,
                0xB0,
                0xD4,
                0x72,
                0x8A,
                0x3B,
                0x83,
                0x14,
                0x02,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Devices_AepContainer_SupportsCapturing
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x45,
                0x5D,
                0xF5,
                0x6A,
                0xDB,
                0x38,
                0x95,
                0x44,
                0xAC,
                0xB0,
                0xD4,
                0x72,
                0x8A,
                0x3B,
                0x83,
                0x14,
                0x0B,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Devices_AepContainer_SupportsImages
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x45,
                0x5D,
                0xF5,
                0x6A,
                0xDB,
                0x38,
                0x95,
                0x44,
                0xAC,
                0xB0,
                0xD4,
                0x72,
                0x8A,
                0x3B,
                0x83,
                0x14,
                0x04,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Devices_AepContainer_SupportsInformation
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x45,
                0x5D,
                0xF5,
                0x6A,
                0xDB,
                0x38,
                0x95,
                0x44,
                0xAC,
                0xB0,
                0xD4,
                0x72,
                0x8A,
                0x3B,
                0x83,
                0x14,
                0x0E,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Devices_AepContainer_SupportsLimitedDiscovery
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x45,
                0x5D,
                0xF5,
                0x6A,
                0xDB,
                0x38,
                0x95,
                0x44,
                0xAC,
                0xB0,
                0xD4,
                0x72,
                0x8A,
                0x3B,
                0x83,
                0x14,
                0x07,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Devices_AepContainer_SupportsNetworking
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x45,
                0x5D,
                0xF5,
                0x6A,
                0xDB,
                0x38,
                0x95,
                0x44,
                0xAC,
                0xB0,
                0xD4,
                0x72,
                0x8A,
                0x3B,
                0x83,
                0x14,
                0x09,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Devices_AepContainer_SupportsObjectTransfer
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x45,
                0x5D,
                0xF5,
                0x6A,
                0xDB,
                0x38,
                0x95,
                0x44,
                0xAC,
                0xB0,
                0xD4,
                0x72,
                0x8A,
                0x3B,
                0x83,
                0x14,
                0x0C,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Devices_AepContainer_SupportsPositioning
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x45,
                0x5D,
                0xF5,
                0x6A,
                0xDB,
                0x38,
                0x95,
                0x44,
                0xAC,
                0xB0,
                0xD4,
                0x72,
                0x8A,
                0x3B,
                0x83,
                0x14,
                0x08,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Devices_AepContainer_SupportsRendering
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x45,
                0x5D,
                0xF5,
                0x6A,
                0xDB,
                0x38,
                0x95,
                0x44,
                0xAC,
                0xB0,
                0xD4,
                0x72,
                0x8A,
                0x3B,
                0x83,
                0x14,
                0x0A,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Devices_AepContainer_SupportsTelephony
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x45,
                0x5D,
                0xF5,
                0x6A,
                0xDB,
                0x38,
                0x95,
                0x44,
                0xAC,
                0xB0,
                0xD4,
                0x72,
                0x8A,
                0x3B,
                0x83,
                0x14,
                0x0D,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Devices_AepContainer_SupportsVideo
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x45,
                0x5D,
                0xF5,
                0x6A,
                0xDB,
                0x38,
                0x95,
                0x44,
                0xAC,
                0xB0,
                0xD4,
                0x72,
                0x8A,
                0x3B,
                0x83,
                0x14,
                0x03,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Devices_AepService_AepId
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA9,
                0x41,
                0xC1,
                0xC9,
                0x4C,
                0x1B,
                0x17,
                0x4F,
                0xA9,
                0xD1,
                0xF2,
                0x98,
                0x53,
                0x8C,
                0xAD,
                0xB8,
                0x06,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Devices_AepService_Bluetooth_CacheMode
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x1E,
                0x31,
                0x44,
                0x97,
                0x51,
                0x79,
                0x2E,
                0x4B,
                0xB6,
                0xF0,
                0xEC,
                0xB2,
                0x93,
                0xCA,
                0xC1,
                0x19,
                0x05,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Devices_AepService_Bluetooth_ServiceGuid
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC7,
                0xAA,
                0x99,
                0xA3,
                0x65,
                0xC2,
                0x4E,
                0x47,
                0xB0,
                0x73,
                0xFF,
                0xCE,
                0x57,
                0x72,
                0x17,
                0x16,
                0x02,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Devices_AepService_Bluetooth_TargetDevice
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x1E,
                0x31,
                0x44,
                0x97,
                0x51,
                0x79,
                0x2E,
                0x4B,
                0xB6,
                0xF0,
                0xEC,
                0xB2,
                0x93,
                0xCA,
                0xC1,
                0x19,
                0x06,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Devices_AepService_ContainerId
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x56,
                0x47,
                0x72,
                0x71,
                0x74,
                0x3E,
                0x32,
                0x44,
                0x9B,
                0x59,
                0xE7,
                0xB2,
                0xF6,
                0x68,
                0xA5,
                0x93,
                0x04,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Devices_AepService_FriendlyName
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x56,
                0x47,
                0x72,
                0x71,
                0x74,
                0x3E,
                0x32,
                0x44,
                0x9B,
                0x59,
                0xE7,
                0xB2,
                0xF6,
                0x68,
                0xA5,
                0x93,
                0x02,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Devices_AepService_IoT_ServiceInterfaces
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x82,
                0x4E,
                0xD9,
                0x79,
                0x79,
                0x4D,
                0xAA,
                0x45,
                0x82,
                0x1A,
                0x74,
                0x85,
                0x8B,
                0x4E,
                0x4C,
                0xA6,
                0x02,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Devices_AepService_ParentAepIsPaired
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA9,
                0x41,
                0xC1,
                0xC9,
                0x4C,
                0x1B,
                0x17,
                0x4F,
                0xA9,
                0xD1,
                0xF2,
                0x98,
                0x53,
                0x8C,
                0xAD,
                0xB8,
                0x07,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Devices_AepService_ProtocolId
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA9,
                0x41,
                0xC1,
                0xC9,
                0x4C,
                0x1B,
                0x17,
                0x4F,
                0xA9,
                0xD1,
                0xF2,
                0x98,
                0x53,
                0x8C,
                0xAD,
                0xB8,
                0x05,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Devices_AepService_ServiceClassId
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x56,
                0x47,
                0x72,
                0x71,
                0x74,
                0x3E,
                0x32,
                0x44,
                0x9B,
                0x59,
                0xE7,
                0xB2,
                0xF6,
                0x68,
                0xA5,
                0x93,
                0x03,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Devices_AepService_ServiceId
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA9,
                0x41,
                0xC1,
                0xC9,
                0x4C,
                0x1B,
                0x17,
                0x4F,
                0xA9,
                0xD1,
                0xF2,
                0x98,
                0x53,
                0x8C,
                0xAD,
                0xB8,
                0x02,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Devices_AppPackageFamilyName
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x83,
                0x65,
                0x23,
                0x51,
                0x4A,
                0x0C,
                0xE8,
                0x4F,
                0xB8,
                0x1F,
                0x16,
                0x6A,
                0xEC,
                0x13,
                0xF5,
                0x10,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Devices_AudioDevice_Microphone_EqCoefficientsDb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x73,
                0xB3,
                0x43,
                0x89,
                0x8C,
                0x38,
                0x95,
                0x43,
                0xB5,
                0x57,
                0xBC,
                0x6D,
                0xBA,
                0xFF,
                0xAF,
                0xDB,
                0x07,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Devices_AudioDevice_Microphone_IsFarField
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x73,
                0xB3,
                0x43,
                0x89,
                0x8C,
                0x38,
                0x95,
                0x43,
                0xB5,
                0x57,
                0xBC,
                0x6D,
                0xBA,
                0xFF,
                0xAF,
                0xDB,
                0x06,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Devices_AudioDevice_Microphone_SensitivityInDbfs
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x73,
                0xB3,
                0x43,
                0x89,
                0x8C,
                0x38,
                0x95,
                0x43,
                0xB5,
                0x57,
                0xBC,
                0x6D,
                0xBA,
                0xFF,
                0xAF,
                0xDB,
                0x03,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Devices_AudioDevice_Microphone_SensitivityInDbfs2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x73,
                0xB3,
                0x43,
                0x89,
                0x8C,
                0x38,
                0x95,
                0x43,
                0xB5,
                0x57,
                0xBC,
                0x6D,
                0xBA,
                0xFF,
                0xAF,
                0xDB,
                0x05,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Devices_AudioDevice_Microphone_SignalToNoiseRatioInDb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x73,
                0xB3,
                0x43,
                0x89,
                0x8C,
                0x38,
                0x95,
                0x43,
                0xB5,
                0x57,
                0xBC,
                0x6D,
                0xBA,
                0xFF,
                0xAF,
                0xDB,
                0x04,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Devices_AudioDevice_RawProcessingSupported
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x73,
                0xB3,
                0x43,
                0x89,
                0x8C,
                0x38,
                0x95,
                0x43,
                0xB5,
                0x57,
                0xBC,
                0x6D,
                0xBA,
                0xFF,
                0xAF,
                0xDB,
                0x02,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Devices_AudioDevice_SpeechProcessingSupported
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x64,
                0xE8,
                0x1D,
                0xFB,
                0x6D,
                0xE0,
                0xF4,
                0x47,
                0x82,
                0xA6,
                0x8A,
                0x0A,
                0xEF,
                0x44,
                0x49,
                0x3C,
                0x02,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Devices_BatteryLife
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x76,
                0x1F,
                0xCD,
                0x49,
                0x26,
                0x56,
                0x17,
                0x4B,
                0xA4,
                0xE8,
                0x18,
                0xB4,
                0xAA,
                0x1A,
                0x22,
                0x13,
                0x0A,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Devices_BatteryPlusCharging
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x76,
                0x1F,
                0xCD,
                0x49,
                0x26,
                0x56,
                0x17,
                0x4B,
                0xA4,
                0xE8,
                0x18,
                0xB4,
                0xAA,
                0x1A,
                0x22,
                0x13,
                0x16,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Devices_BatteryPlusChargingText
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x76,
                0x1F,
                0xCD,
                0x49,
                0x26,
                0x56,
                0x17,
                0x4B,
                0xA4,
                0xE8,
                0x18,
                0xB4,
                0xAA,
                0x1A,
                0x22,
                0x13,
                0x17,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Devices_Category
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC8,
                0x4F,
                0xC3,
                0x78,
                0x4A,
                0x10,
                0xCA,
                0x4A,
                0x9E,
                0xA4,
                0x52,
                0x4D,
                0x52,
                0x99,
                0x6E,
                0x57,
                0x5B,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Devices_CategoryGroup
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC8,
                0x4F,
                0xC3,
                0x78,
                0x4A,
                0x10,
                0xCA,
                0x4A,
                0x9E,
                0xA4,
                0x52,
                0x4D,
                0x52,
                0x99,
                0x6E,
                0x57,
                0x5E,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Devices_CategoryIds
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC8,
                0x4F,
                0xC3,
                0x78,
                0x4A,
                0x10,
                0xCA,
                0x4A,
                0x9E,
                0xA4,
                0x52,
                0x4D,
                0x52,
                0x99,
                0x6E,
                0x57,
                0x5A,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Devices_CategoryPlural
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC8,
                0x4F,
                0xC3,
                0x78,
                0x4A,
                0x10,
                0xCA,
                0x4A,
                0x9E,
                0xA4,
                0x52,
                0x4D,
                0x52,
                0x99,
                0x6E,
                0x57,
                0x5C,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Devices_ChallengeAep
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x5E,
                0x31,
                0x74,
                0x07,
                0x14,
                0xB7,
                0xEC,
                0x48,
                0x8D,
                0xE8,
                0x81,
                0x25,
                0xC0,
                0x77,
                0xAC,
                0x11,
                0x02,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Devices_ChargingState
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x76,
                0x1F,
                0xCD,
                0x49,
                0x26,
                0x56,
                0x17,
                0x4B,
                0xA4,
                0xE8,
                0x18,
                0xB4,
                0xAA,
                0x1A,
                0x22,
                0x13,
                0x0B,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Devices_Children
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC5,
                0xA6,
                0x40,
                0x43,
                0xFA,
                0x93,
                0x06,
                0x47,
                0x97,
                0x2C,
                0x7B,
                0x64,
                0x80,
                0x08,
                0xA5,
                0xA7,
                0x09,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Devices_ClassGuid
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x4E,
                0x25,
                0x5C,
                0xA4,
                0x1C,
                0xDF,
                0xFD,
                0x4E,
                0x80,
                0x20,
                0x67,
                0xD1,
                0x46,
                0xA8,
                0x50,
                0xE0,
                0x0A,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Devices_CompatibleIds
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x4E,
                0x25,
                0x5C,
                0xA4,
                0x1C,
                0xDF,
                0xFD,
                0x4E,
                0x80,
                0x20,
                0x67,
                0xD1,
                0x46,
                0xA8,
                0x50,
                0xE0,
                0x04,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Devices_Connected
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC8,
                0x4F,
                0xC3,
                0x78,
                0x4A,
                0x10,
                0xCA,
                0x4A,
                0x9E,
                0xA4,
                0x52,
                0x4D,
                0x52,
                0x99,
                0x6E,
                0x57,
                0x37,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Devices_ContainerId
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x06,
                0xD2,
                0x7E,
                0x8C,
                0x8A,
                0x3F,
                0x27,
                0x48,
                0xB3,
                0xAB,
                0xAE,
                0x9E,
                0x1F,
                0xAE,
                0xFC,
                0x6C,
                0x02,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Devices_DefaultTooltip
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA2,
                0x70,
                0x0F,
                0x88,
                0x82,
                0x60,
                0xAC,
                0x47,
                0x8A,
                0xAB,
                0xA7,
                0x39,
                0xD1,
                0xA3,
                0x00,
                0xC3,
                0x99,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Devices_DeviceCapabilities
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x4E,
                0x25,
                0x5C,
                0xA4,
                0x1C,
                0xDF,
                0xFD,
                0x4E,
                0x80,
                0x20,
                0x67,
                0xD1,
                0x46,
                0xA8,
                0x50,
                0xE0,
                0x11,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Devices_DeviceCharacteristics
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x4E,
                0x25,
                0x5C,
                0xA4,
                0x1C,
                0xDF,
                0xFD,
                0x4E,
                0x80,
                0x20,
                0x67,
                0xD1,
                0x46,
                0xA8,
                0x50,
                0xE0,
                0x1D,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Devices_DeviceDescription1
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC8,
                0x4F,
                0xC3,
                0x78,
                0x4A,
                0x10,
                0xCA,
                0x4A,
                0x9E,
                0xA4,
                0x52,
                0x4D,
                0x52,
                0x99,
                0x6E,
                0x57,
                0x51,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Devices_DeviceDescription2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC8,
                0x4F,
                0xC3,
                0x78,
                0x4A,
                0x10,
                0xCA,
                0x4A,
                0x9E,
                0xA4,
                0x52,
                0x4D,
                0x52,
                0x99,
                0x6E,
                0x57,
                0x52,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Devices_DeviceHasProblem
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x7E,
                0x94,
                0x0B,
                0x54,
                0x40,
                0x8B,
                0xBC,
                0x45,
                0xA8,
                0xA2,
                0x6A,
                0x0B,
                0x89,
                0x4C,
                0xBD,
                0xA2,
                0x06,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Devices_DeviceInstanceId
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC8,
                0x4F,
                0xC3,
                0x78,
                0x4A,
                0x10,
                0xCA,
                0x4A,
                0x9E,
                0xA4,
                0x52,
                0x4D,
                0x52,
                0x99,
                0x6E,
                0x57,
                0x00,
                0x01,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Devices_DeviceManufacturer
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x4E,
                0x25,
                0x5C,
                0xA4,
                0x1C,
                0xDF,
                0xFD,
                0x4E,
                0x80,
                0x20,
                0x67,
                0xD1,
                0x46,
                0xA8,
                0x50,
                0xE0,
                0x0D,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Devices_DevObjectType
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x42,
                0x3F,
                0x67,
                0x13,
                0xD6,
                0xA3,
                0xF6,
                0x49,
                0xB4,
                0xDA,
                0xAE,
                0x46,
                0xE0,
                0xC5,
                0x23,
                0x7C,
                0x02,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Devices_DialProtocol_InstalledApplications
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x72,
                0xCC,
                0x45,
                0x68,
                0x71,
                0x1B,
                0xC3,
                0x48,
                0xAF,
                0x86,
                0xB0,
                0x91,
                0x71,
                0xA1,
                0x9B,
                0x14,
                0x03,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Devices_DiscoveryMethod
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC8,
                0x4F,
                0xC3,
                0x78,
                0x4A,
                0x10,
                0xCA,
                0x4A,
                0x9E,
                0xA4,
                0x52,
                0x4D,
                0x52,
                0x99,
                0x6E,
                0x57,
                0x34,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Devices_Dnssd_Domain
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xAB,
                0xC0,
                0x79,
                0xBF,
                0x74,
                0xBB,
                0xEE,
                0x4C,
                0xB0,
                0x70,
                0x47,
                0x0B,
                0x5A,
                0xE2,
                0x02,
                0xEA,
                0x03,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Devices_Dnssd_FullName
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xAB,
                0xC0,
                0x79,
                0xBF,
                0x74,
                0xBB,
                0xEE,
                0x4C,
                0xB0,
                0x70,
                0x47,
                0x0B,
                0x5A,
                0xE2,
                0x02,
                0xEA,
                0x05,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Devices_Dnssd_HostName
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xAB,
                0xC0,
                0x79,
                0xBF,
                0x74,
                0xBB,
                0xEE,
                0x4C,
                0xB0,
                0x70,
                0x47,
                0x0B,
                0x5A,
                0xE2,
                0x02,
                0xEA,
                0x07,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Devices_Dnssd_InstanceName
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xAB,
                0xC0,
                0x79,
                0xBF,
                0x74,
                0xBB,
                0xEE,
                0x4C,
                0xB0,
                0x70,
                0x47,
                0x0B,
                0x5A,
                0xE2,
                0x02,
                0xEA,
                0x04,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Devices_Dnssd_NetworkAdapterId
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xAB,
                0xC0,
                0x79,
                0xBF,
                0x74,
                0xBB,
                0xEE,
                0x4C,
                0xB0,
                0x70,
                0x47,
                0x0B,
                0x5A,
                0xE2,
                0x02,
                0xEA,
                0x0B,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Devices_Dnssd_PortNumber
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xAB,
                0xC0,
                0x79,
                0xBF,
                0x74,
                0xBB,
                0xEE,
                0x4C,
                0xB0,
                0x70,
                0x47,
                0x0B,
                0x5A,
                0xE2,
                0x02,
                0xEA,
                0x0C,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Devices_Dnssd_Priority
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xAB,
                0xC0,
                0x79,
                0xBF,
                0x74,
                0xBB,
                0xEE,
                0x4C,
                0xB0,
                0x70,
                0x47,
                0x0B,
                0x5A,
                0xE2,
                0x02,
                0xEA,
                0x09,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Devices_Dnssd_ServiceName
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xAB,
                0xC0,
                0x79,
                0xBF,
                0x74,
                0xBB,
                0xEE,
                0x4C,
                0xB0,
                0x70,
                0x47,
                0x0B,
                0x5A,
                0xE2,
                0x02,
                0xEA,
                0x02,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Devices_Dnssd_TextAttributes
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xAB,
                0xC0,
                0x79,
                0xBF,
                0x74,
                0xBB,
                0xEE,
                0x4C,
                0xB0,
                0x70,
                0x47,
                0x0B,
                0x5A,
                0xE2,
                0x02,
                0xEA,
                0x06,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Devices_Dnssd_Ttl
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xAB,
                0xC0,
                0x79,
                0xBF,
                0x74,
                0xBB,
                0xEE,
                0x4C,
                0xB0,
                0x70,
                0x47,
                0x0B,
                0x5A,
                0xE2,
                0x02,
                0xEA,
                0x0A,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Devices_Dnssd_Weight
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xAB,
                0xC0,
                0x79,
                0xBF,
                0x74,
                0xBB,
                0xEE,
                0x4C,
                0xB0,
                0x70,
                0x47,
                0x0B,
                0x5A,
                0xE2,
                0x02,
                0xEA,
                0x08,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Devices_FriendlyName
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB3,
                0x3B,
                0x6A,
                0x65,
                0xC0,
                0xEC,
                0xFD,
                0x43,
                0x84,
                0x77,
                0x4A,
                0xE0,
                0x40,
                0x4A,
                0x96,
                0xCD,
                0x00,
                0x30,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Devices_FunctionPaths
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC0,
                0xD4,
                0x8D,
                0xD0,
                0x9E,
                0x3A,
                0x2E,
                0x46,
                0x82,
                0x90,
                0x7B,
                0x63,
                0x6B,
                0x25,
                0x76,
                0xB9,
                0x03,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Devices_GlyphIcon
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x83,
                0x65,
                0x23,
                0x51,
                0x4A,
                0x0C,
                0xE8,
                0x4F,
                0xB8,
                0x1F,
                0x16,
                0x6A,
                0xEC,
                0x13,
                0xF5,
                0x10,
                0x7B,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Devices_HardwareIds
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x4E,
                0x25,
                0x5C,
                0xA4,
                0x1C,
                0xDF,
                0xFD,
                0x4E,
                0x80,
                0x20,
                0x67,
                0xD1,
                0x46,
                0xA8,
                0x50,
                0xE0,
                0x03,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Devices_Icon
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC8,
                0x4F,
                0xC3,
                0x78,
                0x4A,
                0x10,
                0xCA,
                0x4A,
                0x9E,
                0xA4,
                0x52,
                0x4D,
                0x52,
                0x99,
                0x6E,
                0x57,
                0x39,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Devices_InLocalMachineContainer
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x06,
                0xD2,
                0x7E,
                0x8C,
                0x8A,
                0x3F,
                0x27,
                0x48,
                0xB3,
                0xAB,
                0xAE,
                0x9E,
                0x1F,
                0xAE,
                0xFC,
                0x6C,
                0x04,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Devices_InterfaceClassGuid
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x6E,
                0x51,
                0x6E,
                0x02,
                0x14,
                0xB8,
                0x4B,
                0x41,
                0x83,
                0xCD,
                0x85,
                0x6D,
                0x6F,
                0xEF,
                0x48,
                0x22,
                0x04,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Devices_InterfaceEnabled
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x6E,
                0x51,
                0x6E,
                0x02,
                0x14,
                0xB8,
                0x4B,
                0x41,
                0x83,
                0xCD,
                0x85,
                0x6D,
                0x6F,
                0xEF,
                0x48,
                0x22,
                0x03,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Devices_InterfacePaths
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC0,
                0xD4,
                0x8D,
                0xD0,
                0x9E,
                0x3A,
                0x2E,
                0x46,
                0x82,
                0x90,
                0x7B,
                0x63,
                0x6B,
                0x25,
                0x76,
                0xB9,
                0x02,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Devices_IpAddress
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB3,
                0x3B,
                0x6A,
                0x65,
                0xC0,
                0xEC,
                0xFD,
                0x43,
                0x84,
                0x77,
                0x4A,
                0xE0,
                0x40,
                0x4A,
                0x96,
                0xCD,
                0x09,
                0x30,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Devices_IsDefault
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC8,
                0x4F,
                0xC3,
                0x78,
                0x4A,
                0x10,
                0xCA,
                0x4A,
                0x9E,
                0xA4,
                0x52,
                0x4D,
                0x52,
                0x99,
                0x6E,
                0x57,
                0x56,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Devices_IsNetworkConnected
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC8,
                0x4F,
                0xC3,
                0x78,
                0x4A,
                0x10,
                0xCA,
                0x4A,
                0x9E,
                0xA4,
                0x52,
                0x4D,
                0x52,
                0x99,
                0x6E,
                0x57,
                0x55,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Devices_IsShared
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC8,
                0x4F,
                0xC3,
                0x78,
                0x4A,
                0x10,
                0xCA,
                0x4A,
                0x9E,
                0xA4,
                0x52,
                0x4D,
                0x52,
                0x99,
                0x6E,
                0x57,
                0x54,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Devices_IsSoftwareInstalling
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x26,
                0x63,
                0xDA,
                0x83,
                0xA6,
                0x97,
                0x88,
                0x40,
                0x94,
                0x53,
                0xA1,
                0x92,
                0x3F,
                0x57,
                0x3B,
                0x29,
                0x09,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Devices_LaunchDeviceStageFromExplorer
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC8,
                0x4F,
                0xC3,
                0x78,
                0x4A,
                0x10,
                0xCA,
                0x4A,
                0x9E,
                0xA4,
                0x52,
                0x4D,
                0x52,
                0x99,
                0x6E,
                0x57,
                0x4D,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Devices_LocalMachine
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC8,
                0x4F,
                0xC3,
                0x78,
                0x4A,
                0x10,
                0xCA,
                0x4A,
                0x9E,
                0xA4,
                0x52,
                0x4D,
                0x52,
                0x99,
                0x6E,
                0x57,
                0x46,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Devices_LocationPaths
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x4E,
                0x25,
                0x5C,
                0xA4,
                0x1C,
                0xDF,
                0xFD,
                0x4E,
                0x80,
                0x20,
                0x67,
                0xD1,
                0x46,
                0xA8,
                0x50,
                0xE0,
                0x25,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Devices_Manufacturer
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB3,
                0x3B,
                0x6A,
                0x65,
                0xC0,
                0xEC,
                0xFD,
                0x43,
                0x84,
                0x77,
                0x4A,
                0xE0,
                0x40,
                0x4A,
                0x96,
                0xCD,
                0x00,
                0x20,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Devices_MetadataPath
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC8,
                0x4F,
                0xC3,
                0x78,
                0x4A,
                0x10,
                0xCA,
                0x4A,
                0x9E,
                0xA4,
                0x52,
                0x4D,
                0x52,
                0x99,
                0x6E,
                0x57,
                0x47,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Devices_MicrophoneArray_Geometry
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA2,
                0x9E,
                0x82,
                0xA1,
                0xEB,
                0x27,
                0x9E,
                0x45,
                0x93,
                0x5D,
                0xB2,
                0xFA,
                0xD7,
                0xB0,
                0x77,
                0x62,
                0x02,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Devices_MissedCalls
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x76,
                0x1F,
                0xCD,
                0x49,
                0x26,
                0x56,
                0x17,
                0x4B,
                0xA4,
                0xE8,
                0x18,
                0xB4,
                0xAA,
                0x1A,
                0x22,
                0x13,
                0x05,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Devices_ModelId
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA6,
                0x1E,
                0xD8,
                0x80,
                0x73,
                0x74,
                0x0C,
                0x4B,
                0x82,
                0x16,
                0xEF,
                0xC1,
                0x1A,
                0x2C,
                0x4C,
                0x8B,
                0x02,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Devices_ModelName
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB3,
                0x3B,
                0x6A,
                0x65,
                0xC0,
                0xEC,
                0xFD,
                0x43,
                0x84,
                0x77,
                0x4A,
                0xE0,
                0x40,
                0x4A,
                0x96,
                0xCD,
                0x02,
                0x20,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Devices_ModelNumber
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB3,
                0x3B,
                0x6A,
                0x65,
                0xC0,
                0xEC,
                0xFD,
                0x43,
                0x84,
                0x77,
                0x4A,
                0xE0,
                0x40,
                0x4A,
                0x96,
                0xCD,
                0x03,
                0x20,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Devices_NetworkedTooltip
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA2,
                0x70,
                0x0F,
                0x88,
                0x82,
                0x60,
                0xAC,
                0x47,
                0x8A,
                0xAB,
                0xA7,
                0x39,
                0xD1,
                0xA3,
                0x00,
                0xC3,
                0x98,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Devices_NetworkName
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x76,
                0x1F,
                0xCD,
                0x49,
                0x26,
                0x56,
                0x17,
                0x4B,
                0xA4,
                0xE8,
                0x18,
                0xB4,
                0xAA,
                0x1A,
                0x22,
                0x13,
                0x07,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Devices_NetworkType
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x76,
                0x1F,
                0xCD,
                0x49,
                0x26,
                0x56,
                0x17,
                0x4B,
                0xA4,
                0xE8,
                0x18,
                0xB4,
                0xAA,
                0x1A,
                0x22,
                0x13,
                0x08,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Devices_NewPictures
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x76,
                0x1F,
                0xCD,
                0x49,
                0x26,
                0x56,
                0x17,
                0x4B,
                0xA4,
                0xE8,
                0x18,
                0xB4,
                0xAA,
                0x1A,
                0x22,
                0x13,
                0x04,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Devices_Notification
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x0C,
                0x4B,
                0x70,
                0x06,
                0x30,
                0xE8,
                0x81,
                0x4C,
                0x91,
                0x78,
                0x91,
                0xE4,
                0xE9,
                0x5A,
                0x80,
                0xA0,
                0x03,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Devices_Notifications_LowBattery
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x2B,
                0x7F,
                0xC0,
                0xC4,
                0x24,
                0x85,
                0x66,
                0x4E,
                0xAE,
                0x3A,
                0xA6,
                0x23,
                0x5F,
                0x10,
                0x3B,
                0xEB,
                0x02,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Devices_Notifications_MissedCall
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x48,
                0xEF,
                0x14,
                0x66,
                0xFE,
                0x4E,
                0x24,
                0x44,
                0x9E,
                0xDA,
                0xC7,
                0x9F,
                0x40,
                0x4E,
                0xDF,
                0x3E,
                0x02,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Devices_Notifications_NewMessage
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x0A,
                0x26,
                0xE9,
                0x2B,
                0x12,
                0x20,
                0x42,
                0x47,
                0xA5,
                0x55,
                0xF4,
                0x1B,
                0x63,
                0x8B,
                0x7D,
                0xCB,
                0x02,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Devices_Notifications_NewVoicemail
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x56,
                0x95,
                0x56,
                0x59,
                0x08,
                0x0A,
                0x12,
                0x42,
                0x95,
                0xB9,
                0xFA,
                0xE2,
                0xAD,
                0x64,
                0x13,
                0xDB,
                0x02,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Devices_Notifications_StorageFull
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE1,
                0x0E,
                0xE0,
                0xA0,
                0xC7,
                0xF0,
                0x41,
                0x4D,
                0xB8,
                0xE7,
                0x26,
                0xA7,
                0xBD,
                0x8D,
                0x38,
                0xB0,
                0x02,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Devices_Notifications_StorageFullLinkText
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE1,
                0x0E,
                0xE0,
                0xA0,
                0xC7,
                0xF0,
                0x41,
                0x4D,
                0xB8,
                0xE7,
                0x26,
                0xA7,
                0xBD,
                0x8D,
                0x38,
                0xB0,
                0x03,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Devices_NotificationStore
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x0C,
                0x4B,
                0x70,
                0x06,
                0x30,
                0xE8,
                0x81,
                0x4C,
                0x91,
                0x78,
                0x91,
                0xE4,
                0xE9,
                0x5A,
                0x80,
                0xA0,
                0x02,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Devices_NotWorkingProperly
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC8,
                0x4F,
                0xC3,
                0x78,
                0x4A,
                0x10,
                0xCA,
                0x4A,
                0x9E,
                0xA4,
                0x52,
                0x4D,
                0x52,
                0x99,
                0x6E,
                0x57,
                0x53,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Devices_Paired
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC8,
                0x4F,
                0xC3,
                0x78,
                0x4A,
                0x10,
                0xCA,
                0x4A,
                0x9E,
                0xA4,
                0x52,
                0x4D,
                0x52,
                0x99,
                0x6E,
                0x57,
                0x38,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Devices_Panel_PanelGroup
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x86,
                0x9C,
                0xBC,
                0x8D,
                0xA9,
                0x97,
                0xFF,
                0x4B,
                0x9B,
                0xC6,
                0xBF,
                0xE9,
                0x5D,
                0x3E,
                0x6D,
                0xAD,
                0x03,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Devices_Panel_PanelId
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x86,
                0x9C,
                0xBC,
                0x8D,
                0xA9,
                0x97,
                0xFF,
                0x4B,
                0x9B,
                0xC6,
                0xBF,
                0xE9,
                0x5D,
                0x3E,
                0x6D,
                0xAD,
                0x02,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Devices_Parent
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC5,
                0xA6,
                0x40,
                0x43,
                0xFA,
                0x93,
                0x06,
                0x47,
                0x97,
                0x2C,
                0x7B,
                0x64,
                0x80,
                0x08,
                0xA5,
                0xA7,
                0x08,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Devices_PhoneLineTransportDevice_Connected
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE8,
                0x2F,
                0xCF,
                0xAE,
                0x00,
                0x1D,
                0xEE,
                0x4F,
                0x8A,
                0x6D,
                0xA7,
                0x0D,
                0x71,
                0x9B,
                0x77,
                0x2B,
                0x02,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Devices_PhysicalDeviceLocation
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x7E,
                0x94,
                0x0B,
                0x54,
                0x40,
                0x8B,
                0xBC,
                0x45,
                0xA8,
                0xA2,
                0x6A,
                0x0B,
                0x89,
                0x4C,
                0xBD,
                0xA2,
                0x09,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Devices_PlaybackPositionPercent
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x59,
                0xDE,
                0x33,
                0x36,
                0x25,
                0x68,
                0x81,
                0x43,
                0xA4,
                0x9B,
                0x9F,
                0x6B,
                0xA1,
                0x3A,
                0x14,
                0x71,
                0x05,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Devices_PlaybackState
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x59,
                0xDE,
                0x33,
                0x36,
                0x25,
                0x68,
                0x81,
                0x43,
                0xA4,
                0x9B,
                0x9F,
                0x6B,
                0xA1,
                0x3A,
                0x14,
                0x71,
                0x02,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Devices_PlaybackTitle
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x59,
                0xDE,
                0x33,
                0x36,
                0x25,
                0x68,
                0x81,
                0x43,
                0xA4,
                0x9B,
                0x9F,
                0x6B,
                0xA1,
                0x3A,
                0x14,
                0x71,
                0x03,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Devices_Present
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x7E,
                0x94,
                0x0B,
                0x54,
                0x40,
                0x8B,
                0xBC,
                0x45,
                0xA8,
                0xA2,
                0x6A,
                0x0B,
                0x89,
                0x4C,
                0xBD,
                0xA2,
                0x05,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Devices_PresentationUrl
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB3,
                0x3B,
                0x6A,
                0x65,
                0xC0,
                0xEC,
                0xFD,
                0x43,
                0x84,
                0x77,
                0x4A,
                0xE0,
                0x40,
                0x4A,
                0x96,
                0xCD,
                0x06,
                0x20,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Devices_PrimaryCategory
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC0,
                0xD4,
                0x8D,
                0xD0,
                0x9E,
                0x3A,
                0x2E,
                0x46,
                0x82,
                0x90,
                0x7B,
                0x63,
                0x6B,
                0x25,
                0x76,
                0xB9,
                0x0A,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Devices_RemainingDuration
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x59,
                0xDE,
                0x33,
                0x36,
                0x25,
                0x68,
                0x81,
                0x43,
                0xA4,
                0x9B,
                0x9F,
                0x6B,
                0xA1,
                0x3A,
                0x14,
                0x71,
                0x04,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Devices_RestrictedInterface
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x6E,
                0x51,
                0x6E,
                0x02,
                0x14,
                0xB8,
                0x4B,
                0x41,
                0x83,
                0xCD,
                0x85,
                0x6D,
                0x6F,
                0xEF,
                0x48,
                0x22,
                0x06,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Devices_Roaming
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x76,
                0x1F,
                0xCD,
                0x49,
                0x26,
                0x56,
                0x17,
                0x4B,
                0xA4,
                0xE8,
                0x18,
                0xB4,
                0xAA,
                0x1A,
                0x22,
                0x13,
                0x09,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Devices_SafeRemovalRequired
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x40,
                0x76,
                0xD9,
                0xAF,
                0xA3,
                0x86,
                0x10,
                0x42,
                0xB6,
                0x7C,
                0x28,
                0x9C,
                0x41,
                0xAA,
                0xBE,
                0x55,
                0x02,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Devices_SchematicName
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x6E,
                0x51,
                0x6E,
                0x02,
                0x14,
                0xB8,
                0x4B,
                0x41,
                0x83,
                0xCD,
                0x85,
                0x6D,
                0x6F,
                0xEF,
                0x48,
                0x22,
                0x09,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Devices_ServiceAddress
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB3,
                0x3B,
                0x6A,
                0x65,
                0xC0,
                0xEC,
                0xFD,
                0x43,
                0x84,
                0x77,
                0x4A,
                0xE0,
                0x40,
                0x4A,
                0x96,
                0xCD,
                0x00,
                0x40,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Devices_ServiceId
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB3,
                0x3B,
                0x6A,
                0x65,
                0xC0,
                0xEC,
                0xFD,
                0x43,
                0x84,
                0x77,
                0x4A,
                0xE0,
                0x40,
                0x4A,
                0x96,
                0xCD,
                0x01,
                0x40,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Devices_SharedTooltip
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA2,
                0x70,
                0x0F,
                0x88,
                0x82,
                0x60,
                0xAC,
                0x47,
                0x8A,
                0xAB,
                0xA7,
                0x39,
                0xD1,
                0xA3,
                0x00,
                0xC3,
                0x97,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Devices_SignalStrength
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x76,
                0x1F,
                0xCD,
                0x49,
                0x26,
                0x56,
                0x17,
                0x4B,
                0xA4,
                0xE8,
                0x18,
                0xB4,
                0xAA,
                0x1A,
                0x22,
                0x13,
                0x02,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Devices_SmartCards_ReaderKind
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x83,
                0xB8,
                0xB5,
                0xD6,
                0xBD,
                0x18,
                0x4D,
                0x4B,
                0xB2,
                0xEC,
                0x9E,
                0x38,
                0xAF,
                0xFE,
                0xDA,
                0x82,
                0x02,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Devices_Status
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC0,
                0xD4,
                0x8D,
                0xD0,
                0x9E,
                0x3A,
                0x2E,
                0x46,
                0x82,
                0x90,
                0x7B,
                0x63,
                0x6B,
                0x25,
                0x76,
                0xB9,
                0x03,
                0x01,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Devices_Status1
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC0,
                0xD4,
                0x8D,
                0xD0,
                0x9E,
                0x3A,
                0x2E,
                0x46,
                0x82,
                0x90,
                0x7B,
                0x63,
                0x6B,
                0x25,
                0x76,
                0xB9,
                0x01,
                0x01,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Devices_Status2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC0,
                0xD4,
                0x8D,
                0xD0,
                0x9E,
                0x3A,
                0x2E,
                0x46,
                0x82,
                0x90,
                0x7B,
                0x63,
                0x6B,
                0x25,
                0x76,
                0xB9,
                0x02,
                0x01,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Devices_StorageCapacity
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x76,
                0x1F,
                0xCD,
                0x49,
                0x26,
                0x56,
                0x17,
                0x4B,
                0xA4,
                0xE8,
                0x18,
                0xB4,
                0xAA,
                0x1A,
                0x22,
                0x13,
                0x0C,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Devices_StorageFreeSpace
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x76,
                0x1F,
                0xCD,
                0x49,
                0x26,
                0x56,
                0x17,
                0x4B,
                0xA4,
                0xE8,
                0x18,
                0xB4,
                0xAA,
                0x1A,
                0x22,
                0x13,
                0x0D,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Devices_StorageFreeSpacePercent
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x76,
                0x1F,
                0xCD,
                0x49,
                0x26,
                0x56,
                0x17,
                0x4B,
                0xA4,
                0xE8,
                0x18,
                0xB4,
                0xAA,
                0x1A,
                0x22,
                0x13,
                0x0E,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Devices_TextMessages
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x76,
                0x1F,
                0xCD,
                0x49,
                0x26,
                0x56,
                0x17,
                0x4B,
                0xA4,
                0xE8,
                0x18,
                0xB4,
                0xAA,
                0x1A,
                0x22,
                0x13,
                0x03,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Devices_Voicemail
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x76,
                0x1F,
                0xCD,
                0x49,
                0x26,
                0x56,
                0x17,
                0x4B,
                0xA4,
                0xE8,
                0x18,
                0xB4,
                0xAA,
                0x1A,
                0x22,
                0x13,
                0x06,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Devices_WiaDeviceType
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC6,
                0x1F,
                0xDD,
                0x6B,
                0x0F,
                0x81,
                0xD0,
                0x11,
                0xBE,
                0xC7,
                0x08,
                0x00,
                0x2B,
                0xE2,
                0x09,
                0x2F,
                0x02,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Devices_WiFi_InterfaceGuid
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xEB,
                0x67,
                0x11,
                0xEF,
                0xFC,
                0xCB,
                0x41,
                0x43,
                0xA5,
                0x68,
                0xA7,
                0xC9,
                0x1A,
                0x68,
                0x98,
                0x2C,
                0x02,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Devices_WiFiDirect_DeviceAddress
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x5D,
                0x93,
                0x06,
                0x15,
                0xE7,
                0xE3,
                0x0F,
                0x45,
                0x86,
                0x37,
                0x82,
                0x23,
                0x3E,
                0xBE,
                0x5F,
                0x6E,
                0x0D,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Devices_WiFiDirect_GroupId
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x5D,
                0x93,
                0x06,
                0x15,
                0xE7,
                0xE3,
                0x0F,
                0x45,
                0x86,
                0x37,
                0x82,
                0x23,
                0x3E,
                0xBE,
                0x5F,
                0x6E,
                0x04,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Devices_WiFiDirect_InformationElements
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x5D,
                0x93,
                0x06,
                0x15,
                0xE7,
                0xE3,
                0x0F,
                0x45,
                0x86,
                0x37,
                0x82,
                0x23,
                0x3E,
                0xBE,
                0x5F,
                0x6E,
                0x0C,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Devices_WiFiDirect_InterfaceAddress
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x5D,
                0x93,
                0x06,
                0x15,
                0xE7,
                0xE3,
                0x0F,
                0x45,
                0x86,
                0x37,
                0x82,
                0x23,
                0x3E,
                0xBE,
                0x5F,
                0x6E,
                0x02,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Devices_WiFiDirect_InterfaceGuid
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x5D,
                0x93,
                0x06,
                0x15,
                0xE7,
                0xE3,
                0x0F,
                0x45,
                0x86,
                0x37,
                0x82,
                0x23,
                0x3E,
                0xBE,
                0x5F,
                0x6E,
                0x03,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Devices_WiFiDirect_IsConnected
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x5D,
                0x93,
                0x06,
                0x15,
                0xE7,
                0xE3,
                0x0F,
                0x45,
                0x86,
                0x37,
                0x82,
                0x23,
                0x3E,
                0xBE,
                0x5F,
                0x6E,
                0x05,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Devices_WiFiDirect_IsLegacyDevice
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x5D,
                0x93,
                0x06,
                0x15,
                0xE7,
                0xE3,
                0x0F,
                0x45,
                0x86,
                0x37,
                0x82,
                0x23,
                0x3E,
                0xBE,
                0x5F,
                0x6E,
                0x07,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Devices_WiFiDirect_IsMiracastLcpSupported
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x5D,
                0x93,
                0x06,
                0x15,
                0xE7,
                0xE3,
                0x0F,
                0x45,
                0x86,
                0x37,
                0x82,
                0x23,
                0x3E,
                0xBE,
                0x5F,
                0x6E,
                0x09,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Devices_WiFiDirect_IsVisible
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x5D,
                0x93,
                0x06,
                0x15,
                0xE7,
                0xE3,
                0x0F,
                0x45,
                0x86,
                0x37,
                0x82,
                0x23,
                0x3E,
                0xBE,
                0x5F,
                0x6E,
                0x06,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Devices_WiFiDirect_MiracastVersion
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x5D,
                0x93,
                0x06,
                0x15,
                0xE7,
                0xE3,
                0x0F,
                0x45,
                0x86,
                0x37,
                0x82,
                0x23,
                0x3E,
                0xBE,
                0x5F,
                0x6E,
                0x08,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Devices_WiFiDirect_Services
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x5D,
                0x93,
                0x06,
                0x15,
                0xE7,
                0xE3,
                0x0F,
                0x45,
                0x86,
                0x37,
                0x82,
                0x23,
                0x3E,
                0xBE,
                0x5F,
                0x6E,
                0x0A,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Devices_WiFiDirect_SupportedChannelList
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x5D,
                0x93,
                0x06,
                0x15,
                0xE7,
                0xE3,
                0x0F,
                0x45,
                0x86,
                0x37,
                0x82,
                0x23,
                0x3E,
                0xBE,
                0x5F,
                0x6E,
                0x0B,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Devices_WiFiDirectServices_AdvertisementId
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x43,
                0x77,
                0xB3,
                0x31,
                0x5E,
                0x7C,
                0x05,
                0x40,
                0x93,
                0xE6,
                0xE9,
                0x53,
                0xF9,
                0x2B,
                0x82,
                0xE9,
                0x05,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Devices_WiFiDirectServices_RequestServiceInformation
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x43,
                0x77,
                0xB3,
                0x31,
                0x5E,
                0x7C,
                0x05,
                0x40,
                0x93,
                0xE6,
                0xE9,
                0x53,
                0xF9,
                0x2B,
                0x82,
                0xE9,
                0x07,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Devices_WiFiDirectServices_ServiceAddress
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x43,
                0x77,
                0xB3,
                0x31,
                0x5E,
                0x7C,
                0x05,
                0x40,
                0x93,
                0xE6,
                0xE9,
                0x53,
                0xF9,
                0x2B,
                0x82,
                0xE9,
                0x02,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Devices_WiFiDirectServices_ServiceConfigMethods
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x43,
                0x77,
                0xB3,
                0x31,
                0x5E,
                0x7C,
                0x05,
                0x40,
                0x93,
                0xE6,
                0xE9,
                0x53,
                0xF9,
                0x2B,
                0x82,
                0xE9,
                0x06,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Devices_WiFiDirectServices_ServiceInformation
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x43,
                0x77,
                0xB3,
                0x31,
                0x5E,
                0x7C,
                0x05,
                0x40,
                0x93,
                0xE6,
                0xE9,
                0x53,
                0xF9,
                0x2B,
                0x82,
                0xE9,
                0x04,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Devices_WiFiDirectServices_ServiceName
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x43,
                0x77,
                0xB3,
                0x31,
                0x5E,
                0x7C,
                0x05,
                0x40,
                0x93,
                0xE6,
                0xE9,
                0x53,
                0xF9,
                0x2B,
                0x82,
                0xE9,
                0x03,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Devices_WinPhone8CameraFlags
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x1C,
                0xD6,
                0xB4,
                0xB7,
                0x64,
                0x5A,
                0x87,
                0x41,
                0xA5,
                0x2E,
                0xB1,
                0x53,
                0x9F,
                0x35,
                0x90,
                0x99,
                0x02,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Devices_Wwan_InterfaceGuid
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xEB,
                0x67,
                0x11,
                0xFF,
                0xFC,
                0xCB,
                0x41,
                0x43,
                0xA5,
                0x68,
                0xA7,
                0xC9,
                0x1A,
                0x68,
                0x98,
                0x2C,
                0x02,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Storage_Portable
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE8,
                0xBE,
                0x1E,
                0x4D,
                0x03,
                0x08,
                0x74,
                0x47,
                0x98,
                0x42,
                0xB7,
                0x7D,
                0xB5,
                0x02,
                0x65,
                0xE9,
                0x02,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Storage_RemovableMedia
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE8,
                0xBE,
                0x1E,
                0x4D,
                0x03,
                0x08,
                0x74,
                0x47,
                0x98,
                0x42,
                0xB7,
                0x7D,
                0xB5,
                0x02,
                0x65,
                0xE9,
                0x03,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Storage_SystemCritical
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE8,
                0xBE,
                0x1E,
                0x4D,
                0x03,
                0x08,
                0x74,
                0x47,
                0x98,
                0x42,
                0xB7,
                0x7D,
                0xB5,
                0x02,
                0x65,
                0xE9,
                0x04,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Document_ByteCount
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x02,
                0xD5,
                0xCD,
                0xD5,
                0x9C,
                0x2E,
                0x1B,
                0x10,
                0x93,
                0x97,
                0x08,
                0x00,
                0x2B,
                0x2C,
                0xF9,
                0xAE,
                0x04,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Document_CharacterCount
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE0,
                0x85,
                0x9F,
                0xF2,
                0xF9,
                0x4F,
                0x68,
                0x10,
                0xAB,
                0x91,
                0x08,
                0x00,
                0x2B,
                0x27,
                0xB3,
                0xD9,
                0x10,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Document_ClientID
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB0,
                0x7B,
                0x6D,
                0x27,
                0x34,
                0x5B,
                0xB0,
                0x4F,
                0xAA,
                0x4B,
                0x15,
                0x8E,
                0xD1,
                0x2A,
                0x18,
                0x09,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Document_Contributor
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x5E,
                0x11,
                0x34,
                0xF3,
                0x1B,
                0xDA,
                0x09,
                0x45,
                0x9B,
                0x3D,
                0x11,
                0x95,
                0x04,
                0xDC,
                0x7A,
                0xBB,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Document_DateCreated
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE0,
                0x85,
                0x9F,
                0xF2,
                0xF9,
                0x4F,
                0x68,
                0x10,
                0xAB,
                0x91,
                0x08,
                0x00,
                0x2B,
                0x27,
                0xB3,
                0xD9,
                0x0C,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Document_DatePrinted
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE0,
                0x85,
                0x9F,
                0xF2,
                0xF9,
                0x4F,
                0x68,
                0x10,
                0xAB,
                0x91,
                0x08,
                0x00,
                0x2B,
                0x27,
                0xB3,
                0xD9,
                0x0B,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Document_DateSaved
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE0,
                0x85,
                0x9F,
                0xF2,
                0xF9,
                0x4F,
                0x68,
                0x10,
                0xAB,
                0x91,
                0x08,
                0x00,
                0x2B,
                0x27,
                0xB3,
                0xD9,
                0x0D,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Document_Division
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE6,
                0x5E,
                0x00,
                0x1E,
                0x27,
                0xBF,
                0x8B,
                0x42,
                0xB0,
                0x1C,
                0x79,
                0x67,
                0x6A,
                0xCD,
                0x28,
                0x70,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Document_DocumentID
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC8,
                0x05,
                0x88,
                0xE0,
                0x95,
                0xE3,
                0xDF,
                0x40,
                0x80,
                0xD2,
                0x54,
                0xF0,
                0xD6,
                0xC4,
                0x31,
                0x54,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Document_HiddenSlideCount
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x02,
                0xD5,
                0xCD,
                0xD5,
                0x9C,
                0x2E,
                0x1B,
                0x10,
                0x93,
                0x97,
                0x08,
                0x00,
                0x2B,
                0x2C,
                0xF9,
                0xAE,
                0x09,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Document_LastAuthor
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE0,
                0x85,
                0x9F,
                0xF2,
                0xF9,
                0x4F,
                0x68,
                0x10,
                0xAB,
                0x91,
                0x08,
                0x00,
                0x2B,
                0x27,
                0xB3,
                0xD9,
                0x08,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Document_LineCount
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x02,
                0xD5,
                0xCD,
                0xD5,
                0x9C,
                0x2E,
                0x1B,
                0x10,
                0x93,
                0x97,
                0x08,
                0x00,
                0x2B,
                0x2C,
                0xF9,
                0xAE,
                0x05,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Document_Manager
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x02,
                0xD5,
                0xCD,
                0xD5,
                0x9C,
                0x2E,
                0x1B,
                0x10,
                0x93,
                0x97,
                0x08,
                0x00,
                0x2B,
                0x2C,
                0xF9,
                0xAE,
                0x0E,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Document_MultimediaClipCount
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x02,
                0xD5,
                0xCD,
                0xD5,
                0x9C,
                0x2E,
                0x1B,
                0x10,
                0x93,
                0x97,
                0x08,
                0x00,
                0x2B,
                0x2C,
                0xF9,
                0xAE,
                0x0A,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Document_NoteCount
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x02,
                0xD5,
                0xCD,
                0xD5,
                0x9C,
                0x2E,
                0x1B,
                0x10,
                0x93,
                0x97,
                0x08,
                0x00,
                0x2B,
                0x2C,
                0xF9,
                0xAE,
                0x08,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Document_PageCount
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE0,
                0x85,
                0x9F,
                0xF2,
                0xF9,
                0x4F,
                0x68,
                0x10,
                0xAB,
                0x91,
                0x08,
                0x00,
                0x2B,
                0x27,
                0xB3,
                0xD9,
                0x0E,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Document_ParagraphCount
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x02,
                0xD5,
                0xCD,
                0xD5,
                0x9C,
                0x2E,
                0x1B,
                0x10,
                0x93,
                0x97,
                0x08,
                0x00,
                0x2B,
                0x2C,
                0xF9,
                0xAE,
                0x06,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Document_PresentationFormat
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x02,
                0xD5,
                0xCD,
                0xD5,
                0x9C,
                0x2E,
                0x1B,
                0x10,
                0x93,
                0x97,
                0x08,
                0x00,
                0x2B,
                0x2C,
                0xF9,
                0xAE,
                0x03,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Document_RevisionNumber
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE0,
                0x85,
                0x9F,
                0xF2,
                0xF9,
                0x4F,
                0x68,
                0x10,
                0xAB,
                0x91,
                0x08,
                0x00,
                0x2B,
                0x27,
                0xB3,
                0xD9,
                0x09,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Document_Security
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE0,
                0x85,
                0x9F,
                0xF2,
                0xF9,
                0x4F,
                0x68,
                0x10,
                0xAB,
                0x91,
                0x08,
                0x00,
                0x2B,
                0x27,
                0xB3,
                0xD9,
                0x13,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Document_SlideCount
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x02,
                0xD5,
                0xCD,
                0xD5,
                0x9C,
                0x2E,
                0x1B,
                0x10,
                0x93,
                0x97,
                0x08,
                0x00,
                0x2B,
                0x2C,
                0xF9,
                0xAE,
                0x07,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Document_Template
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE0,
                0x85,
                0x9F,
                0xF2,
                0xF9,
                0x4F,
                0x68,
                0x10,
                0xAB,
                0x91,
                0x08,
                0x00,
                0x2B,
                0x27,
                0xB3,
                0xD9,
                0x07,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Document_TotalEditingTime
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE0,
                0x85,
                0x9F,
                0xF2,
                0xF9,
                0x4F,
                0x68,
                0x10,
                0xAB,
                0x91,
                0x08,
                0x00,
                0x2B,
                0x27,
                0xB3,
                0xD9,
                0x0A,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Document_Version
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x02,
                0xD5,
                0xCD,
                0xD5,
                0x9C,
                0x2E,
                0x1B,
                0x10,
                0x93,
                0x97,
                0x08,
                0x00,
                0x2B,
                0x2C,
                0xF9,
                0xAE,
                0x1D,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Document_WordCount
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE0,
                0x85,
                0x9F,
                0xF2,
                0xF9,
                0x4F,
                0x68,
                0x10,
                0xAB,
                0x91,
                0x08,
                0x00,
                0x2B,
                0x27,
                0xB3,
                0xD9,
                0x0F,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_DRM_DatePlayExpires
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE4,
                0x19,
                0xAC,
                0xAE,
                0xAE,
                0x89,
                0x08,
                0x45,
                0xB9,
                0xB7,
                0xBB,
                0x86,
                0x7A,
                0xBE,
                0xE2,
                0xED,
                0x06,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_DRM_DatePlayStarts
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE4,
                0x19,
                0xAC,
                0xAE,
                0xAE,
                0x89,
                0x08,
                0x45,
                0xB9,
                0xB7,
                0xBB,
                0x86,
                0x7A,
                0xBE,
                0xE2,
                0xED,
                0x05,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_DRM_Description
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE4,
                0x19,
                0xAC,
                0xAE,
                0xAE,
                0x89,
                0x08,
                0x45,
                0xB9,
                0xB7,
                0xBB,
                0x86,
                0x7A,
                0xBE,
                0xE2,
                0xED,
                0x03,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_DRM_IsDisabled
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE4,
                0x19,
                0xAC,
                0xAE,
                0xAE,
                0x89,
                0x08,
                0x45,
                0xB9,
                0xB7,
                0xBB,
                0x86,
                0x7A,
                0xBE,
                0xE2,
                0xED,
                0x07,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_DRM_IsProtected
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE4,
                0x19,
                0xAC,
                0xAE,
                0xAE,
                0x89,
                0x08,
                0x45,
                0xB9,
                0xB7,
                0xBB,
                0x86,
                0x7A,
                0xBE,
                0xE2,
                0xED,
                0x02,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_DRM_PlayCount
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE4,
                0x19,
                0xAC,
                0xAE,
                0xAE,
                0x89,
                0x08,
                0x45,
                0xB9,
                0xB7,
                0xBB,
                0x86,
                0x7A,
                0xBE,
                0xE2,
                0xED,
                0x04,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_GPS_Altitude
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x4F,
                0xDB,
                0x7E,
                0x82,
                0x73,
                0x5B,
                0xA7,
                0x44,
                0x89,
                0x1D,
                0xFD,
                0xFF,
                0xAB,
                0xEA,
                0x35,
                0xCA,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_GPS_AltitudeDenominator
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xCB,
                0x2D,
                0x34,
                0x78,
                0x58,
                0xE3,
                0x45,
                0x41,
                0xAE,
                0x9A,
                0x6B,
                0xFE,
                0x4E,
                0x0F,
                0x9F,
                0x51,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_GPS_AltitudeNumerator
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB7,
                0x1E,
                0xAD,
                0x2D,
                0x6D,
                0x81,
                0xD3,
                0x40,
                0x9E,
                0xC3,
                0xC9,
                0x77,
                0x3B,
                0xE2,
                0xAA,
                0xDE,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_GPS_AltitudeRef
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x9D,
                0x62,
                0xAC,
                0x46,
                0xEA,
                0x75,
                0x15,
                0x45,
                0x86,
                0x7F,
                0x6D,
                0xC4,
                0x32,
                0x1C,
                0x58,
                0x44,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_GPS_AreaInformation
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x3E,
                0x33,
                0x2E,
                0x97,
                0x7E,
                0xAC,
                0xF1,
                0x49,
                0x8A,
                0xDF,
                0xA7,
                0x0D,
                0x07,
                0xA9,
                0xBC,
                0xAB,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_GPS_Date
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x12,
                0xC8,
                0x02,
                0x36,
                0x3B,
                0x0F,
                0xF0,
                0x45,
                0x85,
                0xAD,
                0x60,
                0x34,
                0x68,
                0xD6,
                0x94,
                0x23,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_GPS_DestBearing
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x3C,
                0x4B,
                0x6D,
                0xC6,
                0x88,
                0xE8,
                0xCC,
                0x47,
                0xB9,
                0x9F,
                0x9D,
                0xCA,
                0x3E,
                0xE3,
                0x4D,
                0xEA,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_GPS_DestBearingDenominator
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF8,
                0xF4,
                0xBC,
                0x7A,
                0x3F,
                0x7C,
                0x88,
                0x49,
                0xAC,
                0x91,
                0x8D,
                0x2C,
                0x2E,
                0x97,
                0xEC,
                0xA5,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_GPS_DestBearingNumerator
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA9,
                0x1D,
                0x3B,
                0xBA,
                0xEE,
                0x86,
                0x5D,
                0x4B,
                0xA2,
                0xA4,
                0xA2,
                0x71,
                0xA4,
                0x29,
                0xF0,
                0xCF,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_GPS_DestBearingRef
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x93,
                0x43,
                0xB8,
                0x9A,
                0x0F,
                0x2A,
                0x75,
                0x4B,
                0xBB,
                0x22,
                0x72,
                0x79,
                0x78,
                0x69,
                0x77,
                0xCB,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_GPS_DestDistance
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x04,
                0xAE,
                0x3E,
                0xA9,
                0x04,
                0x68,
                0x24,
                0x4F,
                0xAC,
                0x81,
                0x09,
                0xB2,
                0x66,
                0x45,
                0x21,
                0x18,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_GPS_DestDistanceDenominator
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x9B,
                0xC9,
                0xC2,
                0x9B,
                0x71,
                0xAC,
                0x27,
                0x41,
                0x9D,
                0x1C,
                0x25,
                0x96,
                0xD0,
                0xD7,
                0xDC,
                0xB7,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_GPS_DestDistanceNumerator
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xDA,
                0x47,
                0xDA,
                0x2B,
                0xC6,
                0x08,
                0xE1,
                0x4F,
                0x80,
                0xBC,
                0xA7,
                0x2F,
                0xC5,
                0x17,
                0xC5,
                0xD0,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_GPS_DestDistanceRef
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD3,
                0xF2,
                0x4D,
                0xED,
                0x95,
                0x86,
                0x0B,
                0x45,
                0x85,
                0x6F,
                0xF5,
                0xC1,
                0xC5,
                0x3A,
                0xCB,
                0x66,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_GPS_DestLatitude
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC5,
                0x7C,
                0x1D,
                0x9D,
                0x39,
                0x5C,
                0x1C,
                0x45,
                0x86,
                0xB3,
                0x92,
                0x8E,
                0x2D,
                0x18,
                0xCC,
                0x47,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_GPS_DestLatitudeDenominator
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x92,
                0x22,
                0x37,
                0x3A,
                0xCA,
                0x7F,
                0xA7,
                0x49,
                0x99,
                0xD5,
                0xE4,
                0x7B,
                0xB2,
                0xD4,
                0xE7,
                0xAB,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_GPS_DestLatitudeNumerator
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF6,
                0xB6,
                0xF4,
                0xEC,
                0xA6,
                0xD5,
                0x3C,
                0x43,
                0xBB,
                0x92,
                0x40,
                0x76,
                0x65,
                0x0F,
                0xC8,
                0x90,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_GPS_DestLatitudeRef
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB9,
                0x20,
                0xA8,
                0xCE,
                0x61,
                0xCE,
                0x85,
                0x48,
                0xA1,
                0x28,
                0x00,
                0x5D,
                0x90,
                0x87,
                0xC1,
                0x92,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_GPS_DestLongitude
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x61,
                0x62,
                0xA9,
                0x47,
                0x4C,
                0xCB,
                0x07,
                0x48,
                0x8A,
                0xD3,
                0x40,
                0xB9,
                0xD9,
                0xDB,
                0xC6,
                0xBC,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_GPS_DestLongitudeDenominator
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE5,
                0x69,
                0x5D,
                0x42,
                0xAD,
                0x48,
                0x00,
                0x49,
                0x8D,
                0x80,
                0x6E,
                0xB6,
                0xB8,
                0xD0,
                0xAC,
                0x86,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_GPS_DestLongitudeNumerator
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x82,
                0x02,
                0x25,
                0xA3,
                0x6D,
                0xFB,
                0xD5,
                0x48,
                0x9A,
                0x89,
                0xDB,
                0xCA,
                0xCE,
                0x75,
                0xCC,
                0xCF,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_GPS_DestLongitudeRef
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA6,
                0x1E,
                0x2C,
                0x18,
                0x1C,
                0x7C,
                0x83,
                0x40,
                0xAB,
                0x4B,
                0xAC,
                0x6C,
                0x9F,
                0x4E,
                0xD1,
                0x28,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_GPS_Differential
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x25,
                0xEE,
                0xF4,
                0xAA,
                0x3B,
                0xBD,
                0xD7,
                0x4D,
                0xBF,
                0xC4,
                0x47,
                0xF7,
                0x7B,
                0xB0,
                0x0F,
                0x6D,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_GPS_DOP
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x02,
                0xFB,
                0xF8,
                0x0C,
                0x37,
                0x18,
                0xF1,
                0x42,
                0xA6,
                0x97,
                0xA7,
                0x01,
                0x7A,
                0xA2,
                0x89,
                0xB9,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_GPS_DOPDenominator
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC5,
                0x94,
                0xBE,
                0xA0,
                0xBA,
                0x50,
                0x7B,
                0x48,
                0xBD,
                0x35,
                0x06,
                0x54,
                0xBE,
                0x88,
                0x81,
                0xED,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_GPS_DOPNumerator
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x16,
                0x6B,
                0x16,
                0x47,
                0x4F,
                0x36,
                0xA0,
                0x4A,
                0x9F,
                0x31,
                0xE2,
                0xAB,
                0x3D,
                0xF4,
                0x49,
                0xC3,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_GPS_ImgDirection
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x91,
                0x3C,
                0x47,
                0x16,
                0x17,
                0xD0,
                0xD9,
                0x4E,
                0xBA,
                0x4D,
                0xB6,
                0xBA,
                0xA5,
                0x5D,
                0xBC,
                0xF8,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_GPS_ImgDirectionDenominator
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x95,
                0x45,
                0xB2,
                0x10,
                0xA2,
                0x41,
                0x20,
                0x4E,
                0x93,
                0xC2,
                0x57,
                0x61,
                0xC1,
                0x39,
                0x5F,
                0x32,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_GPS_ImgDirectionNumerator
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC7,
                0x77,
                0x58,
                0xDC,
                0x5F,
                0x22,
                0xF7,
                0x45,
                0xBA,
                0xC7,
                0xE8,
                0x13,
                0x34,
                0xB6,
                0x13,
                0x0A,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_GPS_ImgDirectionRef
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB7,
                0xA5,
                0xAA,
                0xA4,
                0xD0,
                0x1A,
                0x5F,
                0x44,
                0x81,
                0x1A,
                0x0F,
                0x8F,
                0x6E,
                0x67,
                0xF6,
                0xB5,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_GPS_Latitude
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xFF,
                0xCF,
                0x27,
                0x87,
                0x68,
                0x48,
                0xC6,
                0x4E,
                0xAD,
                0x5B,
                0x81,
                0xB9,
                0x85,
                0x21,
                0xD1,
                0xAB,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_GPS_LatitudeDecimal
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE2,
                0xCD,
                0x55,
                0x0F,
                0x49,
                0x4F,
                0x0D,
                0x45,
                0x92,
                0xC1,
                0xDC,
                0xD1,
                0x63,
                0x01,
                0xB1,
                0xB7,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_GPS_LatitudeDenominator
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xEE,
                0x34,
                0xE6,
                0x16,
                0xFF,
                0x2B,
                0x7B,
                0x49,
                0xBD,
                0x8A,
                0x43,
                0x41,
                0xAD,
                0x39,
                0xEE,
                0xB9,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_GPS_LatitudeNumerator
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD1,
                0xAA,
                0xDA,
                0x7D,
                0xC8,
                0xCC,
                0xAE,
                0x41,
                0xB7,
                0x50,
                0xB2,
                0xCB,
                0x80,
                0x31,
                0xAE,
                0xA2,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_GPS_LatitudeRef
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x52,
                0x02,
                0x9C,
                0x02,
                0x86,
                0x5B,
                0xC7,
                0x46,
                0xAC,
                0xA0,
                0x27,
                0x69,
                0xFF,
                0xC8,
                0xE3,
                0xD4,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_GPS_Longitude
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB2,
                0xDB,
                0xC4,
                0xC4,
                0x93,
                0xB5,
                0x6B,
                0x46,
                0xBB,
                0xDA,
                0xD0,
                0x3D,
                0x27,
                0xD5,
                0xE4,
                0x3A,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_GPS_LongitudeDecimal
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB5,
                0xC1,
                0x79,
                0x46,
                0x4D,
                0x84,
                0x90,
                0x45,
                0xBA,
                0xF5,
                0xF3,
                0x22,
                0x23,
                0x1F,
                0x1B,
                0x81,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_GPS_LongitudeDenominator
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x6C,
                0x17,
                0x6E,
                0xBE,
                0x34,
                0x45,
                0x2C,
                0x4D,
                0xAC,
                0xE5,
                0x31,
                0xDE,
                0xDA,
                0xC1,
                0x60,
                0x6B,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_GPS_LongitudeNumerator
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x89,
                0xF6,
                0xB0,
                0x02,
                0x14,
                0xA9,
                0x45,
                0x4E,
                0x82,
                0x1D,
                0x1D,
                0xDA,
                0x45,
                0x2E,
                0xD2,
                0xC4,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_GPS_LongitudeRef
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x2B,
                0xF2,
                0xDC,
                0x33,
                0xD5,
                0x28,
                0x4C,
                0x46,
                0x80,
                0x35,
                0x1E,
                0xE9,
                0xEF,
                0xD2,
                0x52,
                0x78,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_GPS_MapDatum
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE6,
                0xDA,
                0xA2,
                0x2C,
                0xDC,
                0xED,
                0x7D,
                0x40,
                0xBE,
                0xF1,
                0x77,
                0x39,
                0x42,
                0xAB,
                0xFA,
                0x95,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_GPS_MeasureMode
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x5D,
                0xED,
                0x15,
                0xA0,
                0xEA,
                0xAA,
                0x58,
                0x4D,
                0x8A,
                0x86,
                0x3C,
                0x58,
                0x69,
                0x20,
                0xEA,
                0x0B,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_GPS_ProcessingMethod
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x61,
                0x9E,
                0xD4,
                0x59,
                0x0F,
                0x84,
                0xA9,
                0x4A,
                0xA9,
                0x39,
                0xE2,
                0x09,
                0x9B,
                0x7F,
                0x63,
                0x99,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_GPS_Satellites
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x75,
                0xE5,
                0x7E,
                0x46,
                0x25,
                0x1F,
                0x57,
                0x45,
                0xAD,
                0x4E,
                0xB8,
                0xB5,
                0x8B,
                0x0D,
                0x9C,
                0x15,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_GPS_Speed
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x62,
                0x08,
                0x5D,
                0xDA,
                0x76,
                0x6E,
                0x1B,
                0x4E,
                0xBA,
                0xBD,
                0x70,
                0x02,
                0x1B,
                0xD2,
                0x54,
                0x94,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_GPS_SpeedDenominator
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x5A,
                0x2D,
                0x12,
                0x7D,
                0x5E,
                0xAE,
                0x35,
                0x43,
                0x88,
                0x41,
                0xD7,
                0x1E,
                0x7C,
                0xE7,
                0x2F,
                0x53,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_GPS_SpeedNumerator
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x3D,
                0xCE,
                0xC9,
                0xAC,
                0x13,
                0xC2,
                0x42,
                0x49,
                0x8B,
                0x48,
                0x6D,
                0x08,
                0x20,
                0xF2,
                0x1C,
                0x6D,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_GPS_SpeedRef
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC9,
                0xF4,
                0xF7,
                0xEC,
                0x4F,
                0x54,
                0x6D,
                0x4D,
                0x9D,
                0x98,
                0x8A,
                0xD7,
                0x9A,
                0xDA,
                0xF4,
                0x53,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_GPS_Status
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF4,
                0x91,
                0x54,
                0x12,
                0x8F,
                0x81,
                0xB2,
                0x46,
                0x91,
                0xB5,
                0xD5,
                0x37,
                0x75,
                0x36,
                0x17,
                0xB2,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_GPS_Track
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x43,
                0x99,
                0xC0,
                0x76,
                0x33,
                0x7C,
                0xE3,
                0x49,
                0x9E,
                0x7E,
                0xCD,
                0xBA,
                0x87,
                0x2C,
                0xFA,
                0xDA,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_GPS_TrackDenominator
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x0C,
                0x92,
                0xD1,
                0xC8,
                0xF6,
                0x01,
                0xC0,
                0x40,
                0xAC,
                0x86,
                0x2F,
                0x3A,
                0x4A,
                0xD0,
                0x07,
                0x70,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_GPS_TrackNumerator
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF4,
                0x26,
                0x29,
                0x70,
                0xA6,
                0x44,
                0xE1,
                0x43,
                0xAE,
                0x71,
                0x45,
                0x62,
                0x71,
                0x16,
                0x89,
                0x3B,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_GPS_TrackRef
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xFE,
                0xE6,
                0xDB,
                0x35,
                0xC3,
                0x44,
                0x00,
                0x44,
                0xAA,
                0xAE,
                0xD2,
                0xC7,
                0x99,
                0xC4,
                0x07,
                0xE8,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_GPS_VersionID
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA4,
                0x4D,
                0x70,
                0x22,
                0xB2,
                0xC6,
                0x99,
                0x4A,
                0x8E,
                0x56,
                0xF1,
                0x6D,
                0xF8,
                0xC9,
                0x25,
                0x99,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_History_VisitCount
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x87,
                0x27,
                0xBF,
                0x5C,
                0xCF,
                0x48,
                0x08,
                0x42,
                0xB9,
                0x0E,
                0xEE,
                0x5E,
                0x5D,
                0x42,
                0x02,
                0x94,
                0x07,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Image_BitDepth
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x8F,
                0x04,
                0x44,
                0x64,
                0x8B,
                0x4C,
                0xD1,
                0x11,
                0x8B,
                0x70,
                0x08,
                0x00,
                0x36,
                0xB1,
                0x1A,
                0x03,
                0x07,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Image_ColorSpace
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA1,
                0x1D,
                0xB8,
                0x14,
                0x35,
                0x01,
                0x31,
                0x4D,
                0x96,
                0xD9,
                0x6C,
                0xBF,
                0xC9,
                0x67,
                0x1A,
                0x99,
                0x01,
                0xA0,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Image_CompressedBitsPerPixel
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA9,
                0x6F,
                0x4B,
                0x36,
                0xAB,
                0x37,
                0x2A,
                0x48,
                0xBE,
                0x2B,
                0xAE,
                0x02,
                0xF6,
                0x0D,
                0x43,
                0x18,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Image_CompressedBitsPerPixelDenominator
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE1,
                0x44,
                0x88,
                0x1F,
                0xAD,
                0x24,
                0x08,
                0x45,
                0x9D,
                0xFD,
                0x53,
                0x26,
                0xA4,
                0x15,
                0xCE,
                0x02,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Image_CompressedBitsPerPixelNumerator
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x48,
                0x71,
                0x1A,
                0xD2,
                0x2C,
                0xD3,
                0x24,
                0x46,
                0x89,
                0x00,
                0x27,
                0x72,
                0x10,
                0xF7,
                0x9C,
                0x0F,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Image_Compression
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA1,
                0x1D,
                0xB8,
                0x14,
                0x35,
                0x01,
                0x31,
                0x4D,
                0x96,
                0xD9,
                0x6C,
                0xBF,
                0xC9,
                0x67,
                0x1A,
                0x99,
                0x03,
                0x01,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Image_CompressionText
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x6F,
                0xE6,
                0x08,
                0x3F,
                0x44,
                0x2F,
                0xB9,
                0x4B,
                0xA6,
                0x82,
                0xAC,
                0x35,
                0xD2,
                0x56,
                0x23,
                0x22,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Image_Dimensions
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x8F,
                0x04,
                0x44,
                0x64,
                0x8B,
                0x4C,
                0xD1,
                0x11,
                0x8B,
                0x70,
                0x08,
                0x00,
                0x36,
                0xB1,
                0x1A,
                0x03,
                0x0D,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Image_HorizontalResolution
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x8F,
                0x04,
                0x44,
                0x64,
                0x8B,
                0x4C,
                0xD1,
                0x11,
                0x8B,
                0x70,
                0x08,
                0x00,
                0x36,
                0xB1,
                0x1A,
                0x03,
                0x05,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Image_HorizontalSize
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x8F,
                0x04,
                0x44,
                0x64,
                0x8B,
                0x4C,
                0xD1,
                0x11,
                0x8B,
                0x70,
                0x08,
                0x00,
                0x36,
                0xB1,
                0x1A,
                0x03,
                0x03,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Image_ImageID
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x05,
                0xBE,
                0xDA,
                0x10,
                0xAA,
                0x32,
                0x29,
                0x4C,
                0xBF,
                0x1A,
                0x63,
                0xE2,
                0xD2,
                0x20,
                0x58,
                0x7F,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Image_ResolutionUnit
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA6,
                0x1F,
                0xB5,
                0x19,
                0x92,
                0x1F,
                0x5C,
                0x4A,
                0xAB,
                0x48,
                0x7D,
                0xF0,
                0xAB,
                0xD6,
                0x74,
                0x44,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Image_VerticalResolution
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x8F,
                0x04,
                0x44,
                0x64,
                0x8B,
                0x4C,
                0xD1,
                0x11,
                0x8B,
                0x70,
                0x08,
                0x00,
                0x36,
                0xB1,
                0x1A,
                0x03,
                0x06,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Image_VerticalSize
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x8F,
                0x04,
                0x44,
                0x64,
                0x8B,
                0x4C,
                0xD1,
                0x11,
                0x8B,
                0x70,
                0x08,
                0x00,
                0x36,
                0xB1,
                0x1A,
                0x03,
                0x04,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Journal_Contacts
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x2C,
                0xC8,
                0xA7,
                0xDE,
                0x89,
                0x1D,
                0x66,
                0x4A,
                0x94,
                0x27,
                0xA4,
                0xE3,
                0xDE,
                0xBA,
                0xBC,
                0xB1,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Journal_EntryType
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xFC,
                0xB1,
                0xBE,
                0x95,
                0x6D,
                0x32,
                0x44,
                0x46,
                0xB3,
                0x96,
                0xCD,
                0x3E,
                0xD9,
                0x0E,
                0x6D,
                0xDF,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_LayoutPattern_ContentViewModeForBrowse
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x21,
                0x4A,
                0x94,
                0xC9,
                0x06,
                0xA4,
                0xFE,
                0x48,
                0x82,
                0x25,
                0xAE,
                0xC7,
                0xE2,
                0x4C,
                0x21,
                0x1B,
                0xF4,
                0x01,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_LayoutPattern_ContentViewModeForSearch
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x21,
                0x4A,
                0x94,
                0xC9,
                0x06,
                0xA4,
                0xFE,
                0x48,
                0x82,
                0x25,
                0xAE,
                0xC7,
                0xE2,
                0x4C,
                0x21,
                0x1B,
                0xF5,
                0x01,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_History_SelectionCount
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xBC,
                0xD6,
                0xE0,
                0x1C,
                0x6C,
                0x53,
                0x00,
                0x46,
                0xB0,
                0xDD,
                0x7E,
                0x0C,
                0x66,
                0xB3,
                0x50,
                0xD5,
                0x08,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_History_TargetUrlHostName
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xBC,
                0xD6,
                0xE0,
                0x1C,
                0x6C,
                0x53,
                0x00,
                0x46,
                0xB0,
                0xDD,
                0x7E,
                0x0C,
                0x66,
                0xB3,
                0x50,
                0xD5,
                0x09,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Link_Arguments
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x67,
                0x26,
                0x6F,
                0x43,
                0xE2,
                0x14,
                0xEB,
                0x4F,
                0xB3,
                0x0A,
                0x14,
                0x6C,
                0x53,
                0xB5,
                0xB6,
                0x74,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Link_Comment
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xFC,
                0xB3,
                0xB4,
                0xB9,
                0x51,
                0x2B,
                0x42,
                0x4A,
                0xB5,
                0xD8,
                0x32,
                0x41,
                0x46,
                0xAF,
                0xCF,
                0x25,
                0x05,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Link_DateVisited
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x87,
                0x27,
                0xBF,
                0x5C,
                0xCF,
                0x48,
                0x08,
                0x42,
                0xB9,
                0x0E,
                0xEE,
                0x5E,
                0x5D,
                0x42,
                0x02,
                0x94,
                0x17,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Link_Description
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x87,
                0x27,
                0xBF,
                0x5C,
                0xCF,
                0x48,
                0x08,
                0x42,
                0xB9,
                0x0E,
                0xEE,
                0x5E,
                0x5D,
                0x42,
                0x02,
                0x94,
                0x15,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Link_FeedItemLocalId
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF9,
                0x99,
                0x2F,
                0x8A,
                0x37,
                0x3C,
                0x5D,
                0x46,
                0xA8,
                0xD7,
                0x69,
                0x77,
                0x7A,
                0x24,
                0x6D,
                0x0C,
                0x02,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Link_Status
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xFC,
                0xB3,
                0xB4,
                0xB9,
                0x51,
                0x2B,
                0x42,
                0x4A,
                0xB5,
                0xD8,
                0x32,
                0x41,
                0x46,
                0xAF,
                0xCF,
                0x25,
                0x03,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Link_TargetExtension
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF4,
                0x76,
                0x7D,
                0x7A,
                0x30,
                0xB6,
                0xD7,
                0x4B,
                0x95,
                0xFF,
                0x37,
                0xCC,
                0x51,
                0xA9,
                0x75,
                0xC9,
                0x02,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Link_TargetParsingPath
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xFC,
                0xB3,
                0xB4,
                0xB9,
                0x51,
                0x2B,
                0x42,
                0x4A,
                0xB5,
                0xD8,
                0x32,
                0x41,
                0x46,
                0xAF,
                0xCF,
                0x25,
                0x02,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Link_TargetSFGAOFlags
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xFC,
                0xB3,
                0xB4,
                0xB9,
                0x51,
                0x2B,
                0x42,
                0x4A,
                0xB5,
                0xD8,
                0x32,
                0x41,
                0x46,
                0xAF,
                0xCF,
                0x25,
                0x08,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Link_TargetUrlHostName
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF9,
                0x99,
                0x2F,
                0x8A,
                0x37,
                0x3C,
                0x5D,
                0x46,
                0xA8,
                0xD7,
                0x69,
                0x77,
                0x7A,
                0x24,
                0x6D,
                0x0C,
                0x05,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Link_TargetUrlPath
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF9,
                0x99,
                0x2F,
                0x8A,
                0x37,
                0x3C,
                0x5D,
                0x46,
                0xA8,
                0xD7,
                0x69,
                0x77,
                0x7A,
                0x24,
                0x6D,
                0x0C,
                0x06,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Media_AuthorUrl
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x92,
                0x04,
                0x44,
                0x64,
                0x8B,
                0x4C,
                0xD1,
                0x11,
                0x8B,
                0x70,
                0x08,
                0x00,
                0x36,
                0xB1,
                0x1A,
                0x03,
                0x20,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Media_AverageLevel
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB6,
                0xD5,
                0xED,
                0x09,
                0x01,
                0xB3,
                0xC5,
                0x43,
                0x99,
                0x90,
                0xD0,
                0x03,
                0x02,
                0xEF,
                0xFD,
                0x46,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Media_ClassPrimaryID
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x92,
                0x04,
                0x44,
                0x64,
                0x8B,
                0x4C,
                0xD1,
                0x11,
                0x8B,
                0x70,
                0x08,
                0x00,
                0x36,
                0xB1,
                0x1A,
                0x03,
                0x0D,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Media_ClassSecondaryID
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x92,
                0x04,
                0x44,
                0x64,
                0x8B,
                0x4C,
                0xD1,
                0x11,
                0x8B,
                0x70,
                0x08,
                0x00,
                0x36,
                0xB1,
                0x1A,
                0x03,
                0x0E,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Media_CollectionGroupID
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x92,
                0x04,
                0x44,
                0x64,
                0x8B,
                0x4C,
                0xD1,
                0x11,
                0x8B,
                0x70,
                0x08,
                0x00,
                0x36,
                0xB1,
                0x1A,
                0x03,
                0x18,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Media_CollectionID
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x92,
                0x04,
                0x44,
                0x64,
                0x8B,
                0x4C,
                0xD1,
                0x11,
                0x8B,
                0x70,
                0x08,
                0x00,
                0x36,
                0xB1,
                0x1A,
                0x03,
                0x19,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Media_ContentDistributor
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x92,
                0x04,
                0x44,
                0x64,
                0x8B,
                0x4C,
                0xD1,
                0x11,
                0x8B,
                0x70,
                0x08,
                0x00,
                0x36,
                0xB1,
                0x1A,
                0x03,
                0x12,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Media_ContentID
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x92,
                0x04,
                0x44,
                0x64,
                0x8B,
                0x4C,
                0xD1,
                0x11,
                0x8B,
                0x70,
                0x08,
                0x00,
                0x36,
                0xB1,
                0x1A,
                0x03,
                0x1A,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Media_CreatorApplication
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x92,
                0x04,
                0x44,
                0x64,
                0x8B,
                0x4C,
                0xD1,
                0x11,
                0x8B,
                0x70,
                0x08,
                0x00,
                0x36,
                0xB1,
                0x1A,
                0x03,
                0x1B,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Media_CreatorApplicationVersion
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x92,
                0x04,
                0x44,
                0x64,
                0x8B,
                0x4C,
                0xD1,
                0x11,
                0x8B,
                0x70,
                0x08,
                0x00,
                0x36,
                0xB1,
                0x1A,
                0x03,
                0x1C,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Media_DateEncoded
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x0D,
                0x64,
                0x4B,
                0x2E,
                0x19,
                0x50,
                0xD8,
                0x46,
                0x88,
                0x81,
                0x55,
                0x41,
                0x4C,
                0xC5,
                0xCA,
                0xA0,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Media_DateReleased
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x29,
                0xCC,
                0x41,
                0xDE,
                0x71,
                0x69,
                0x90,
                0x42,
                0xB4,
                0x72,
                0xF5,
                0x9F,
                0x2E,
                0x2F,
                0x31,
                0xE2,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Media_DlnaProfileID
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
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
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Media_Duration
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x90,
                0x04,
                0x44,
                0x64,
                0x8B,
                0x4C,
                0xD1,
                0x11,
                0x8B,
                0x70,
                0x08,
                0x00,
                0x36,
                0xB1,
                0x1A,
                0x03,
                0x03,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Media_DVDID
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x92,
                0x04,
                0x44,
                0x64,
                0x8B,
                0x4C,
                0xD1,
                0x11,
                0x8B,
                0x70,
                0x08,
                0x00,
                0x36,
                0xB1,
                0x1A,
                0x03,
                0x0F,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Media_EncodedBy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x92,
                0x04,
                0x44,
                0x64,
                0x8B,
                0x4C,
                0xD1,
                0x11,
                0x8B,
                0x70,
                0x08,
                0x00,
                0x36,
                0xB1,
                0x1A,
                0x03,
                0x24,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Media_EncodingSettings
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x92,
                0x04,
                0x44,
                0x64,
                0x8B,
                0x4C,
                0xD1,
                0x11,
                0x8B,
                0x70,
                0x08,
                0x00,
                0x36,
                0xB1,
                0x1A,
                0x03,
                0x25,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Media_EpisodeNumber
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x92,
                0x04,
                0x44,
                0x64,
                0x8B,
                0x4C,
                0xD1,
                0x11,
                0x8B,
                0x70,
                0x08,
                0x00,
                0x36,
                0xB1,
                0x1A,
                0x03,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Media_FrameCount
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x8F,
                0x04,
                0x44,
                0x64,
                0x8B,
                0x4C,
                0xD1,
                0x11,
                0x8B,
                0x70,
                0x08,
                0x00,
                0x36,
                0xB1,
                0x1A,
                0x03,
                0x0C,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Media_MCDI
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x92,
                0x04,
                0x44,
                0x64,
                0x8B,
                0x4C,
                0xD1,
                0x11,
                0x8B,
                0x70,
                0x08,
                0x00,
                0x36,
                0xB1,
                0x1A,
                0x03,
                0x10,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Media_MetadataContentProvider
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x92,
                0x04,
                0x44,
                0x64,
                0x8B,
                0x4C,
                0xD1,
                0x11,
                0x8B,
                0x70,
                0x08,
                0x00,
                0x36,
                0xB1,
                0x1A,
                0x03,
                0x11,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Media_Producer
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x92,
                0x04,
                0x44,
                0x64,
                0x8B,
                0x4C,
                0xD1,
                0x11,
                0x8B,
                0x70,
                0x08,
                0x00,
                0x36,
                0xB1,
                0x1A,
                0x03,
                0x16,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Media_PromotionUrl
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x92,
                0x04,
                0x44,
                0x64,
                0x8B,
                0x4C,
                0xD1,
                0x11,
                0x8B,
                0x70,
                0x08,
                0x00,
                0x36,
                0xB1,
                0x1A,
                0x03,
                0x21,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Media_ProtectionType
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x92,
                0x04,
                0x44,
                0x64,
                0x8B,
                0x4C,
                0xD1,
                0x11,
                0x8B,
                0x70,
                0x08,
                0x00,
                0x36,
                0xB1,
                0x1A,
                0x03,
                0x26,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Media_ProviderRating
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x92,
                0x04,
                0x44,
                0x64,
                0x8B,
                0x4C,
                0xD1,
                0x11,
                0x8B,
                0x70,
                0x08,
                0x00,
                0x36,
                0xB1,
                0x1A,
                0x03,
                0x27,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Media_ProviderStyle
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x92,
                0x04,
                0x44,
                0x64,
                0x8B,
                0x4C,
                0xD1,
                0x11,
                0x8B,
                0x70,
                0x08,
                0x00,
                0x36,
                0xB1,
                0x1A,
                0x03,
                0x28,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Media_Publisher
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x92,
                0x04,
                0x44,
                0x64,
                0x8B,
                0x4C,
                0xD1,
                0x11,
                0x8B,
                0x70,
                0x08,
                0x00,
                0x36,
                0xB1,
                0x1A,
                0x03,
                0x1E,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Media_SeasonNumber
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x92,
                0x04,
                0x44,
                0x64,
                0x8B,
                0x4C,
                0xD1,
                0x11,
                0x8B,
                0x70,
                0x08,
                0x00,
                0x36,
                0xB1,
                0x1A,
                0x03,
                0x65,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Media_SeriesName
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x92,
                0x04,
                0x44,
                0x64,
                0x8B,
                0x4C,
                0xD1,
                0x11,
                0x8B,
                0x70,
                0x08,
                0x00,
                0x36,
                0xB1,
                0x1A,
                0x03,
                0x2A,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Media_SubscriptionContentId
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x7A,
                0xAE,
                0xEB,
                0x9A,
                0x44,
                0x96,
                0x7D,
                0x48,
                0xA9,
                0x2C,
                0x65,
                0x75,
                0x85,
                0xED,
                0x75,
                0x1A,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Media_SubTitle
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x2E,
                0x37,
                0xA3,
                0x56,
                0x9C,
                0xCE,
                0xD2,
                0x11,
                0x9F,
                0x0E,
                0x00,
                0x60,
                0x97,
                0xC6,
                0x86,
                0xF6,
                0x26,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Media_ThumbnailLargePath
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x92,
                0x04,
                0x44,
                0x64,
                0x8B,
                0x4C,
                0xD1,
                0x11,
                0x8B,
                0x70,
                0x08,
                0x00,
                0x36,
                0xB1,
                0x1A,
                0x03,
                0x2F,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Media_ThumbnailLargeUri
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x92,
                0x04,
                0x44,
                0x64,
                0x8B,
                0x4C,
                0xD1,
                0x11,
                0x8B,
                0x70,
                0x08,
                0x00,
                0x36,
                0xB1,
                0x1A,
                0x03,
                0x30,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Media_ThumbnailSmallPath
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x92,
                0x04,
                0x44,
                0x64,
                0x8B,
                0x4C,
                0xD1,
                0x11,
                0x8B,
                0x70,
                0x08,
                0x00,
                0x36,
                0xB1,
                0x1A,
                0x03,
                0x31,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Media_ThumbnailSmallUri
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x92,
                0x04,
                0x44,
                0x64,
                0x8B,
                0x4C,
                0xD1,
                0x11,
                0x8B,
                0x70,
                0x08,
                0x00,
                0x36,
                0xB1,
                0x1A,
                0x03,
                0x32,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Media_UniqueFileIdentifier
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x92,
                0x04,
                0x44,
                0x64,
                0x8B,
                0x4C,
                0xD1,
                0x11,
                0x8B,
                0x70,
                0x08,
                0x00,
                0x36,
                0xB1,
                0x1A,
                0x03,
                0x23,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Media_UserNoAutoInfo
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x92,
                0x04,
                0x44,
                0x64,
                0x8B,
                0x4C,
                0xD1,
                0x11,
                0x8B,
                0x70,
                0x08,
                0x00,
                0x36,
                0xB1,
                0x1A,
                0x03,
                0x29,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Media_UserWebUrl
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x92,
                0x04,
                0x44,
                0x64,
                0x8B,
                0x4C,
                0xD1,
                0x11,
                0x8B,
                0x70,
                0x08,
                0x00,
                0x36,
                0xB1,
                0x1A,
                0x03,
                0x22,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Media_Writer
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x92,
                0x04,
                0x44,
                0x64,
                0x8B,
                0x4C,
                0xD1,
                0x11,
                0x8B,
                0x70,
                0x08,
                0x00,
                0x36,
                0xB1,
                0x1A,
                0x03,
                0x17,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Media_Year
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x2E,
                0x37,
                0xA3,
                0x56,
                0x9C,
                0xCE,
                0xD2,
                0x11,
                0x9F,
                0x0E,
                0x00,
                0x60,
                0x97,
                0xC6,
                0x86,
                0xF6,
                0x05,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Message_AttachmentContents
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x7C,
                0xBF,
                0x43,
                0x31,
                0xA8,
                0x80,
                0x54,
                0x48,
                0x88,
                0x80,
                0xE2,
                0xE4,
                0x01,
                0x89,
                0xBD,
                0xD0,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Message_AttachmentNames
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x4C,
                0x58,
                0xE0,
                0xE3,
                0x88,
                0xB7,
                0x5A,
                0x4A,
                0xBB,
                0x20,
                0x7F,
                0x5A,
                0x44,
                0xC9,
                0xAC,
                0xDD,
                0x15,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Message_BccAddress
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x4C,
                0x58,
                0xE0,
                0xE3,
                0x88,
                0xB7,
                0x5A,
                0x4A,
                0xBB,
                0x20,
                0x7F,
                0x5A,
                0x44,
                0xC9,
                0xAC,
                0xDD,
                0x02,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Message_BccName
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x4C,
                0x58,
                0xE0,
                0xE3,
                0x88,
                0xB7,
                0x5A,
                0x4A,
                0xBB,
                0x20,
                0x7F,
                0x5A,
                0x44,
                0xC9,
                0xAC,
                0xDD,
                0x03,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Message_CcAddress
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x4C,
                0x58,
                0xE0,
                0xE3,
                0x88,
                0xB7,
                0x5A,
                0x4A,
                0xBB,
                0x20,
                0x7F,
                0x5A,
                0x44,
                0xC9,
                0xAC,
                0xDD,
                0x04,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Message_CcName
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x4C,
                0x58,
                0xE0,
                0xE3,
                0x88,
                0xB7,
                0x5A,
                0x4A,
                0xBB,
                0x20,
                0x7F,
                0x5A,
                0x44,
                0xC9,
                0xAC,
                0xDD,
                0x05,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Message_ConversationID
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xBD,
                0x80,
                0x8F,
                0xDC,
                0x1E,
                0xAF,
                0x89,
                0x42,
                0x85,
                0xB6,
                0x3D,
                0xFC,
                0x1B,
                0x49,
                0x39,
                0x92,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Message_ConversationIndex
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xBD,
                0x80,
                0x8F,
                0xDC,
                0x1E,
                0xAF,
                0x89,
                0x42,
                0x85,
                0xB6,
                0x3D,
                0xFC,
                0x1B,
                0x49,
                0x39,
                0x92,
                0x65,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Message_DateReceived
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x4C,
                0x58,
                0xE0,
                0xE3,
                0x88,
                0xB7,
                0x5A,
                0x4A,
                0xBB,
                0x20,
                0x7F,
                0x5A,
                0x44,
                0xC9,
                0xAC,
                0xDD,
                0x14,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Message_DateSent
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x4C,
                0x58,
                0xE0,
                0xE3,
                0x88,
                0xB7,
                0x5A,
                0x4A,
                0xBB,
                0x20,
                0x7F,
                0x5A,
                0x44,
                0xC9,
                0xAC,
                0xDD,
                0x13,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Message_Flags
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE7,
                0x9E,
                0x2D,
                0xA8,
                0x67,
                0xCA,
                0x12,
                0x43,
                0x96,
                0x5E,
                0x22,
                0x6B,
                0xCE,
                0xA8,
                0x50,
                0x23,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Message_FromAddress
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x4C,
                0x58,
                0xE0,
                0xE3,
                0x88,
                0xB7,
                0x5A,
                0x4A,
                0xBB,
                0x20,
                0x7F,
                0x5A,
                0x44,
                0xC9,
                0xAC,
                0xDD,
                0x0D,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Message_FromName
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x4C,
                0x58,
                0xE0,
                0xE3,
                0x88,
                0xB7,
                0x5A,
                0x4A,
                0xBB,
                0x20,
                0x7F,
                0x5A,
                0x44,
                0xC9,
                0xAC,
                0xDD,
                0x0E,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Message_HasAttachments
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x74,
                0xCF,
                0x1F,
                0x9C,
                0x97,
                0x2D,
                0xBA,
                0x41,
                0xB4,
                0xAE,
                0xCB,
                0x2E,
                0x36,
                0x61,
                0xA6,
                0xE4,
                0x08,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Message_IsFwdOrReply
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x88,
                0xC0,
                0x9B,
                0x9A,
                0x6D,
                0x4F,
                0x9E,
                0x46,
                0x99,
                0x19,
                0xE7,
                0x05,
                0x41,
                0x20,
                0x40,
                0xF9,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Message_MessageClass
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x58,
                0xD4,
                0x9E,
                0xCD,
                0xCE,
                0x08,
                0x8F,
                0x41,
                0xA7,
                0x0E,
                0xF9,
                0x12,
                0xC7,
                0xBB,
                0x9C,
                0x5C,
                0x67,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Message_Participants
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x05,
                0xA6,
                0x9B,
                0x1A,
                0x7C,
                0x8E,
                0x11,
                0x4D,
                0xAD,
                0x7D,
                0xA5,
                0x0A,
                0xDA,
                0x18,
                0xBA,
                0x1B,
                0x02,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Message_ProofInProgress
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x3C,
                0xF3,
                0x98,
                0x90,
                0x7D,
                0x9A,
                0xA8,
                0x48,
                0x8D,
                0xE5,
                0x2E,
                0x12,
                0x27,
                0xA6,
                0x4E,
                0x91,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Message_SenderAddress
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE7,
                0xC8,
                0xE1,
                0x0B,
                0x81,
                0x19,
                0x76,
                0x46,
                0xAE,
                0x14,
                0xFD,
                0xD7,
                0x8F,
                0x05,
                0xA6,
                0xE7,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Message_SenderName
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xFA,
                0x1C,
                0xA4,
                0x0D,
                0x24,
                0xD2,
                0x18,
                0x4A,
                0xAE,
                0x2F,
                0x59,
                0x61,
                0x58,
                0xDB,
                0x4B,
                0x3A,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Message_Store
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x4C,
                0x58,
                0xE0,
                0xE3,
                0x88,
                0xB7,
                0x5A,
                0x4A,
                0xBB,
                0x20,
                0x7F,
                0x5A,
                0x44,
                0xC9,
                0xAC,
                0xDD,
                0x0F,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Message_ToAddress
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x4C,
                0x58,
                0xE0,
                0xE3,
                0x88,
                0xB7,
                0x5A,
                0x4A,
                0xBB,
                0x20,
                0x7F,
                0x5A,
                0x44,
                0xC9,
                0xAC,
                0xDD,
                0x10,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Message_ToDoFlags
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x9F,
                0x6A,
                0x85,
                0x1F,
                0x00,
                0x69,
                0xBA,
                0x4A,
                0x95,
                0x05,
                0x2D,
                0x5F,
                0x1B,
                0x4D,
                0x66,
                0xCB,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Message_ToDoTitle
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x3C,
                0x8A,
                0xCC,
                0xBC,
                0xEF,
                0x8C,
                0xE5,
                0x42,
                0x9B,
                0x1C,
                0xC6,
                0x90,
                0x79,
                0x39,
                0x8B,
                0xC7,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Message_ToName
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x4C,
                0x58,
                0xE0,
                0xE3,
                0x88,
                0xB7,
                0x5A,
                0x4A,
                0xBB,
                0x20,
                0x7F,
                0x5A,
                0x44,
                0xC9,
                0xAC,
                0xDD,
                0x11,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_MsGraph_ActivityType
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x7E,
                0x56,
                0x85,
                0x4F,
                0xF0,
                0xFF,
                0xF5,
                0x4D,
                0xB1,
                0xD9,
                0x98,
                0xB3,
                0x14,
                0xFF,
                0x07,
                0x29,
                0x0E,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_MsGraph_CompositeId
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x7E,
                0x56,
                0x85,
                0x4F,
                0xF0,
                0xFF,
                0xF5,
                0x4D,
                0xB1,
                0xD9,
                0x98,
                0xB3,
                0x14,
                0xFF,
                0x07,
                0x29,
                0x02,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_MsGraph_DateLastShared
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x7E,
                0x56,
                0x85,
                0x4F,
                0xF0,
                0xFF,
                0xF5,
                0x4D,
                0xB1,
                0xD9,
                0x98,
                0xB3,
                0x14,
                0xFF,
                0x07,
                0x29,
                0x09,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_MsGraph_DriveId
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x7E,
                0x56,
                0x85,
                0x4F,
                0xF0,
                0xFF,
                0xF5,
                0x4D,
                0xB1,
                0xD9,
                0x98,
                0xB3,
                0x14,
                0xFF,
                0x07,
                0x29,
                0x03,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_MsGraph_IconUrl
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x7E,
                0x56,
                0x85,
                0x4F,
                0xF0,
                0xFF,
                0xF5,
                0x4D,
                0xB1,
                0xD9,
                0x98,
                0xB3,
                0x14,
                0xFF,
                0x07,
                0x29,
                0x0F,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_MsGraph_ItemId
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x7E,
                0x56,
                0x85,
                0x4F,
                0xF0,
                0xFF,
                0xF5,
                0x4D,
                0xB1,
                0xD9,
                0x98,
                0xB3,
                0x14,
                0xFF,
                0x07,
                0x29,
                0x04,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_MsGraph_PrimaryActivityActorDisplayName
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x7E,
                0x56,
                0x85,
                0x4F,
                0xF0,
                0xFF,
                0xF5,
                0x4D,
                0xB1,
                0xD9,
                0x98,
                0xB3,
                0x14,
                0xFF,
                0x07,
                0x29,
                0x0D,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_MsGraph_PrimaryActivityActorUpn
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x7E,
                0x56,
                0x85,
                0x4F,
                0xF0,
                0xFF,
                0xF5,
                0x4D,
                0xB1,
                0xD9,
                0x98,
                0xB3,
                0x14,
                0xFF,
                0x07,
                0x29,
                0x0C,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_MsGraph_RecommendationReason
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x7E,
                0x56,
                0x85,
                0x4F,
                0xF0,
                0xFF,
                0xF5,
                0x4D,
                0xB1,
                0xD9,
                0x98,
                0xB3,
                0x14,
                0xFF,
                0x07,
                0x29,
                0x08,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_MsGraph_RecommendationReferenceId
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x7E,
                0x56,
                0x85,
                0x4F,
                0xF0,
                0xFF,
                0xF5,
                0x4D,
                0xB1,
                0xD9,
                0x98,
                0xB3,
                0x14,
                0xFF,
                0x07,
                0x29,
                0x05,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_MsGraph_RecommendationResultSourceId
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x7E,
                0x56,
                0x85,
                0x4F,
                0xF0,
                0xFF,
                0xF5,
                0x4D,
                0xB1,
                0xD9,
                0x98,
                0xB3,
                0x14,
                0xFF,
                0x07,
                0x29,
                0x07,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_MsGraph_SharedByEmail
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x7E,
                0x56,
                0x85,
                0x4F,
                0xF0,
                0xFF,
                0xF5,
                0x4D,
                0xB1,
                0xD9,
                0x98,
                0xB3,
                0x14,
                0xFF,
                0x07,
                0x29,
                0x0B,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_MsGraph_SharedByName
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x7E,
                0x56,
                0x85,
                0x4F,
                0xF0,
                0xFF,
                0xF5,
                0x4D,
                0xB1,
                0xD9,
                0x98,
                0xB3,
                0x14,
                0xFF,
                0x07,
                0x29,
                0x0A,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_MsGraph_WebAccountId
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x7E,
                0x56,
                0x85,
                0x4F,
                0xF0,
                0xFF,
                0xF5,
                0x4D,
                0xB1,
                0xD9,
                0x98,
                0xB3,
                0x14,
                0xFF,
                0x07,
                0x29,
                0x06,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Music_AlbumArtist
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x2E,
                0x37,
                0xA3,
                0x56,
                0x9C,
                0xCE,
                0xD2,
                0x11,
                0x9F,
                0x0E,
                0x00,
                0x60,
                0x97,
                0xC6,
                0x86,
                0xF6,
                0x0D,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Music_AlbumArtistSortOverride
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xAF,
                0xB4,
                0xFD,
                0xF1,
                0x8C,
                0xF7,
                0x6C,
                0x46,
                0xBB,
                0x05,
                0x56,
                0xE9,
                0x2D,
                0xB0,
                0xB8,
                0xEC,
                0x67,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Music_AlbumID
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x2E,
                0x37,
                0xA3,
                0x56,
                0x9C,
                0xCE,
                0xD2,
                0x11,
                0x9F,
                0x0E,
                0x00,
                0x60,
                0x97,
                0xC6,
                0x86,
                0xF6,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Music_AlbumTitle
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x2E,
                0x37,
                0xA3,
                0x56,
                0x9C,
                0xCE,
                0xD2,
                0x11,
                0x9F,
                0x0E,
                0x00,
                0x60,
                0x97,
                0xC6,
                0x86,
                0xF6,
                0x04,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Music_AlbumTitleSortOverride
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xFC,
                0x7F,
                0xEB,
                0x13,
                0x89,
                0xEC,
                0x46,
                0x43,
                0xB1,
                0x9D,
                0xCC,
                0xC6,
                0xF1,
                0x78,
                0x42,
                0x23,
                0x65,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Music_Artist
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x2E,
                0x37,
                0xA3,
                0x56,
                0x9C,
                0xCE,
                0xD2,
                0x11,
                0x9F,
                0x0E,
                0x00,
                0x60,
                0x97,
                0xC6,
                0x86,
                0xF6,
                0x02,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Music_ArtistSortOverride
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB5,
                0x2D,
                0xEB,
                0xDE,
                0x96,
                0x06,
                0xE0,
                0x4C,
                0x94,
                0xFE,
                0xA0,
                0x1F,
                0x77,
                0xA4,
                0x5F,
                0xB5,
                0x66,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Music_BeatsPerMinute
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x2E,
                0x37,
                0xA3,
                0x56,
                0x9C,
                0xCE,
                0xD2,
                0x11,
                0x9F,
                0x0E,
                0x00,
                0x60,
                0x97,
                0xC6,
                0x86,
                0xF6,
                0x23,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Music_Composer
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x92,
                0x04,
                0x44,
                0x64,
                0x8B,
                0x4C,
                0xD1,
                0x11,
                0x8B,
                0x70,
                0x08,
                0x00,
                0x36,
                0xB1,
                0x1A,
                0x03,
                0x13,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Music_ComposerSortOverride
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA3,
                0x20,
                0xBC,
                0x00,
                0x48,
                0xBD,
                0x85,
                0x40,
                0x87,
                0x2C,
                0xA8,
                0x8D,
                0x77,
                0xF5,
                0x09,
                0x7E,
                0x69,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Music_Conductor
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x2E,
                0x37,
                0xA3,
                0x56,
                0x9C,
                0xCE,
                0xD2,
                0x11,
                0x9F,
                0x0E,
                0x00,
                0x60,
                0x97,
                0xC6,
                0x86,
                0xF6,
                0x24,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Music_ContentGroupDescription
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x2E,
                0x37,
                0xA3,
                0x56,
                0x9C,
                0xCE,
                0xD2,
                0x11,
                0x9F,
                0x0E,
                0x00,
                0x60,
                0x97,
                0xC6,
                0x86,
                0xF6,
                0x21,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Music_DiscNumber
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x37,
                0x74,
                0xFE,
                0x6A,
                0xCD,
                0x9B,
                0xC7,
                0x49,
                0x80,
                0xFE,
                0x4A,
                0x5C,
                0x65,
                0xFA,
                0x58,
                0x74,
                0x68,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Music_DisplayArtist
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x53,
                0x29,
                0x12,
                0xFD,
                0x93,
                0xFA,
                0xF7,
                0x4E,
                0x92,
                0xC3,
                0x04,
                0xC9,
                0x46,
                0xB2,
                0xF7,
                0xC8,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Music_Genre
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x2E,
                0x37,
                0xA3,
                0x56,
                0x9C,
                0xCE,
                0xD2,
                0x11,
                0x9F,
                0x0E,
                0x00,
                0x60,
                0x97,
                0xC6,
                0x86,
                0xF6,
                0x0B,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Music_InitialKey
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x2E,
                0x37,
                0xA3,
                0x56,
                0x9C,
                0xCE,
                0xD2,
                0x11,
                0x9F,
                0x0E,
                0x00,
                0x60,
                0x97,
                0xC6,
                0x86,
                0xF6,
                0x22,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Music_IsCompilation
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xCB,
                0xD5,
                0x49,
                0xC4,
                0xA4,
                0x9E,
                0x09,
                0x48,
                0x82,
                0xE8,
                0xAF,
                0x9D,
                0x59,
                0xDE,
                0xD6,
                0xD1,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Music_Lyrics
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x2E,
                0x37,
                0xA3,
                0x56,
                0x9C,
                0xCE,
                0xD2,
                0x11,
                0x9F,
                0x0E,
                0x00,
                0x60,
                0x97,
                0xC6,
                0x86,
                0xF6,
                0x0C,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Music_Mood
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x2E,
                0x37,
                0xA3,
                0x56,
                0x9C,
                0xCE,
                0xD2,
                0x11,
                0x9F,
                0x0E,
                0x00,
                0x60,
                0x97,
                0xC6,
                0x86,
                0xF6,
                0x27,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Music_PartOfSet
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x2E,
                0x37,
                0xA3,
                0x56,
                0x9C,
                0xCE,
                0xD2,
                0x11,
                0x9F,
                0x0E,
                0x00,
                0x60,
                0x97,
                0xC6,
                0x86,
                0xF6,
                0x25,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Music_Period
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x92,
                0x04,
                0x44,
                0x64,
                0x8B,
                0x4C,
                0xD1,
                0x11,
                0x8B,
                0x70,
                0x08,
                0x00,
                0x36,
                0xB1,
                0x1A,
                0x03,
                0x1F,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Music_SynchronizedLyrics
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x6A,
                0x3B,
                0x22,
                0x6B,
                0x2E,
                0x16,
                0xA9,
                0x4A,
                0xB3,
                0x9F,
                0x05,
                0xD6,
                0x78,
                0xFC,
                0x6D,
                0x77,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Music_TrackNumber
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x2E,
                0x37,
                0xA3,
                0x56,
                0x9C,
                0xCE,
                0xD2,
                0x11,
                0x9F,
                0x0E,
                0x00,
                0x60,
                0x97,
                0xC6,
                0x86,
                0xF6,
                0x07,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Note_Color
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xFA,
                0xCA,
                0x76,
                0x47,
                0xE4,
                0xBC,
                0xB1,
                0x4C,
                0xA2,
                0x3E,
                0x26,
                0x5E,
                0x76,
                0xD8,
                0xEB,
                0x11,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Note_ColorText
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xDE,
                0xE8,
                0xB4,
                0x46,
                0xB2,
                0xCD,
                0x0D,
                0x44,
                0x88,
                0x5C,
                0x16,
                0x58,
                0xEB,
                0x65,
                0xB9,
                0x14,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Photo_Aperture
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA1,
                0x1D,
                0xB8,
                0x14,
                0x35,
                0x01,
                0x31,
                0x4D,
                0x96,
                0xD9,
                0x6C,
                0xBF,
                0xC9,
                0x67,
                0x1A,
                0x99,
                0x02,
                0x92,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Photo_ApertureDenominator
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x8B,
                0xA3,
                0xA9,
                0xE1,
                0x85,
                0x66,
                0xBD,
                0x46,
                0x87,
                0x5E,
                0x57,
                0x0D,
                0xC7,
                0xAD,
                0x73,
                0x20,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Photo_ApertureNumerator
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xEC,
                0xEC,
                0x37,
                0x03,
                0xFB,
                0x39,
                0x81,
                0x45,
                0xA0,
                0xBD,
                0x4C,
                0x4C,
                0xC5,
                0x1E,
                0x99,
                0x14,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Photo_Brightness
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF6,
                0x1B,
                0x70,
                0x1A,
                0x8C,
                0x47,
                0x61,
                0x43,
                0x83,
                0xAB,
                0x37,
                0x01,
                0xBB,
                0x05,
                0x3C,
                0x58,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Photo_BrightnessDenominator
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x46,
                0x69,
                0xBE,
                0x6E,
                0x21,
                0x23,
                0x0A,
                0x44,
                0x90,
                0xF0,
                0xC0,
                0x43,
                0xEF,
                0xD3,
                0x24,
                0x76,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Photo_BrightnessNumerator
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x8F,
                0x11,
                0x7D,
                0x9E,
                0x14,
                0xB3,
                0xA0,
                0x45,
                0x8C,
                0xFB,
                0xD6,
                0x54,
                0xB9,
                0x17,
                0xC9,
                0xE9,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Photo_CameraManufacturer
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA1,
                0x1D,
                0xB8,
                0x14,
                0x35,
                0x01,
                0x31,
                0x4D,
                0x96,
                0xD9,
                0x6C,
                0xBF,
                0xC9,
                0x67,
                0x1A,
                0x99,
                0x0F,
                0x01,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Photo_CameraModel
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA1,
                0x1D,
                0xB8,
                0x14,
                0x35,
                0x01,
                0x31,
                0x4D,
                0x96,
                0xD9,
                0x6C,
                0xBF,
                0xC9,
                0x67,
                0x1A,
                0x99,
                0x10,
                0x01,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Photo_CameraSerialNumber
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA1,
                0x1D,
                0xB8,
                0x14,
                0x35,
                0x01,
                0x31,
                0x4D,
                0x96,
                0xD9,
                0x6C,
                0xBF,
                0xC9,
                0x67,
                0x1A,
                0x99,
                0x11,
                0x01,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Photo_Contrast
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA9,
                0x5B,
                0x78,
                0x2A,
                0x23,
                0x8D,
                0xED,
                0x4D,
                0x82,
                0xE6,
                0x60,
                0xA3,
                0x50,
                0xC8,
                0x6A,
                0x10,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Photo_ContrastText
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF2,
                0xE9,
                0xDD,
                0x59,
                0x53,
                0x52,
                0xEA,
                0x40,
                0x9A,
                0x8B,
                0x47,
                0x9E,
                0x96,
                0xC6,
                0x24,
                0x9A,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Photo_DateTaken
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA1,
                0x1D,
                0xB8,
                0x14,
                0x35,
                0x01,
                0x31,
                0x4D,
                0x96,
                0xD9,
                0x6C,
                0xBF,
                0xC9,
                0x67,
                0x1A,
                0x99,
                0x03,
                0x90,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Photo_DigitalZoom
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x40,
                0xF8,
                0x5B,
                0xF8,
                0x25,
                0xA9,
                0xC2,
                0x4B,
                0xB0,
                0xC4,
                0x8E,
                0x36,
                0xB5,
                0x98,
                0x67,
                0x9E,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Photo_DigitalZoomDenominator
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x0E,
                0xAF,
                0x5B,
                0x74,
                0xC1,
                0xE5,
                0xFB,
                0x4C,
                0x8A,
                0x1B,
                0xD0,
                0x31,
                0xA0,
                0xA5,
                0x23,
                0x93,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Photo_DigitalZoomNumerator
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x24,
                0xB9,
                0xCB,
                0x16,
                0x00,
                0x65,
                0x3B,
                0x47,
                0xA5,
                0xBE,
                0xF1,
                0x59,
                0x9B,
                0xCB,
                0xE4,
                0x13,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Photo_Event
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA1,
                0x1D,
                0xB8,
                0x14,
                0x35,
                0x01,
                0x31,
                0x4D,
                0x96,
                0xD9,
                0x6C,
                0xBF,
                0xC9,
                0x67,
                0x1A,
                0x99,
                0x48,
                0x47,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Photo_EXIFVersion
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x3A,
                0x74,
                0x5F,
                0xD3,
                0x2E,
                0xEB,
                0xF2,
                0x47,
                0xA2,
                0x86,
                0x84,
                0x41,
                0x32,
                0xCB,
                0x14,
                0x27,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Photo_ExposureBias
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA1,
                0x1D,
                0xB8,
                0x14,
                0x35,
                0x01,
                0x31,
                0x4D,
                0x96,
                0xD9,
                0x6C,
                0xBF,
                0xC9,
                0x67,
                0x1A,
                0x99,
                0x04,
                0x92,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Photo_ExposureBiasDenominator
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x50,
                0x5E,
                0x20,
                0xAB,
                0xB7,
                0x04,
                0x1C,
                0x46,
                0xA1,
                0x8C,
                0x2F,
                0x23,
                0x38,
                0x36,
                0xE6,
                0x27,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Photo_ExposureBiasNumerator
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x84,
                0xF2,
                0x8B,
                0x73,
                0x87,
                0x1D,
                0x0B,
                0x42,
                0x92,
                0xCF,
                0x58,
                0x34,
                0xBF,
                0x6E,
                0xF9,
                0xED,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Photo_ExposureIndex
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF8,
                0x5A,
                0x7B,
                0x96,
                0x5A,
                0x99,
                0xED,
                0x46,
                0x9E,
                0x11,
                0x35,
                0xB3,
                0xC5,
                0xB9,
                0x78,
                0x2D,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Photo_ExposureIndexDenominator
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x89,
                0x2F,
                0x11,
                0x93,
                0x8B,
                0xC2,
                0x2F,
                0x49,
                0x8A,
                0x9D,
                0x4B,
                0xE2,
                0x06,
                0x2C,
                0xEE,
                0x8A,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Photo_ExposureIndexNumerator
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x30,
                0xCF,
                0xED,
                0xCD,
                0x19,
                0x89,
                0xDF,
                0x44,
                0x8F,
                0x4C,
                0x4E,
                0xB2,
                0xFF,
                0xDB,
                0x8D,
                0x89,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Photo_ExposureProgram
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA1,
                0x1D,
                0xB8,
                0x14,
                0x35,
                0x01,
                0x31,
                0x4D,
                0x96,
                0xD9,
                0x6C,
                0xBF,
                0xC9,
                0x67,
                0x1A,
                0x99,
                0x22,
                0x88,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Photo_ExposureProgramText
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB7,
                0x90,
                0xC6,
                0xFE,
                0x30,
                0x5F,
                0x46,
                0x46,
                0xAE,
                0x47,
                0x4C,
                0xAA,
                0xFB,
                0xA8,
                0x84,
                0xA3,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Photo_ExposureTime
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA1,
                0x1D,
                0xB8,
                0x14,
                0x35,
                0x01,
                0x31,
                0x4D,
                0x96,
                0xD9,
                0x6C,
                0xBF,
                0xC9,
                0x67,
                0x1A,
                0x99,
                0x9A,
                0x82,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Photo_ExposureTimeDenominator
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x97,
                0x85,
                0xE9,
                0x55,
                0x16,
                0xAD,
                0xE0,
                0x42,
                0xB6,
                0x24,
                0x21,
                0x59,
                0x9A,
                0x19,
                0x98,
                0x38,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Photo_ExposureTimeNumerator
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE2,
                0x44,
                0x7E,
                0x25,
                0x31,
                0x90,
                0x23,
                0x43,
                0xAC,
                0x38,
                0x85,
                0xC5,
                0x52,
                0x87,
                0x1B,
                0x2E,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Photo_Flash
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA1,
                0x1D,
                0xB8,
                0x14,
                0x35,
                0x01,
                0x31,
                0x4D,
                0x96,
                0xD9,
                0x6C,
                0xBF,
                0xC9,
                0x67,
                0x1A,
                0x99,
                0x09,
                0x92,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Photo_FlashEnergy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA1,
                0x1D,
                0xB8,
                0x14,
                0x35,
                0x01,
                0x31,
                0x4D,
                0x96,
                0xD9,
                0x6C,
                0xBF,
                0xC9,
                0x67,
                0x1A,
                0x99,
                0x0B,
                0xA2,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Photo_FlashEnergyDenominator
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x70,
                0x1C,
                0xB6,
                0xD7,
                0x23,
                0x63,
                0xCD,
                0x49,
                0xA5,
                0xFC,
                0xC8,
                0x42,
                0x77,
                0x16,
                0x2C,
                0x97,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Photo_FlashEnergyNumerator
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x3D,
                0x3D,
                0xAD,
                0xFC,
                0x58,
                0x08,
                0x0F,
                0x40,
                0xAA,
                0xA3,
                0x2F,
                0x66,
                0xCC,
                0xE2,
                0xA6,
                0xBC,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Photo_FlashManufacturer
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC9,
                0xF6,
                0xBA,
                0xAA,
                0xC5,
                0xE0,
                0x19,
                0x47,
                0x85,
                0x85,
                0x57,
                0xB1,
                0x03,
                0xE5,
                0x84,
                0xFE,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Photo_FlashModel
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x35,
                0xBB,
                0x83,
                0xFE,
                0x1A,
                0x4D,
                0xE2,
                0x42,
                0x91,
                0x6B,
                0x06,
                0xF3,
                0xE1,
                0xAF,
                0x71,
                0x9E,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Photo_FlashText
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF6,
                0x68,
                0x8B,
                0x6B,
                0x0B,
                0x20,
                0xEA,
                0x47,
                0x8D,
                0x25,
                0xD8,
                0x05,
                0x0F,
                0x57,
                0x33,
                0x9F,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Photo_FNumber
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA1,
                0x1D,
                0xB8,
                0x14,
                0x35,
                0x01,
                0x31,
                0x4D,
                0x96,
                0xD9,
                0x6C,
                0xBF,
                0xC9,
                0x67,
                0x1A,
                0x99,
                0x9D,
                0x82,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Photo_FNumberDenominator
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x96,
                0x24,
                0x2A,
                0xE9,
                0x3B,
                0x22,
                0x63,
                0x44,
                0xA4,
                0xE3,
                0x30,
                0xEA,
                0xBB,
                0xA7,
                0x9D,
                0x80,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Photo_FNumberNumerator
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x8A,
                0x73,
                0x97,
                0x1B,
                0xFC,
                0xFD,
                0x2F,
                0x46,
                0x9D,
                0x93,
                0x19,
                0x57,
                0xE0,
                0x8B,
                0xE9,
                0x0C,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Photo_FocalLength
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA1,
                0x1D,
                0xB8,
                0x14,
                0x35,
                0x01,
                0x31,
                0x4D,
                0x96,
                0xD9,
                0x6C,
                0xBF,
                0xC9,
                0x67,
                0x1A,
                0x99,
                0x0A,
                0x92,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Photo_FocalLengthDenominator
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x15,
                0xC6,
                0x5B,
                0x30,
                0xA1,
                0xDC,
                0xA5,
                0x44,
                0x9F,
                0xD4,
                0x10,
                0xC0,
                0xBA,
                0x79,
                0x41,
                0x2E,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Photo_FocalLengthInFilm
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x09,
                0x46,
                0xE7,
                0xA0,
                0x4D,
                0xB8,
                0x49,
                0x4F,
                0xB8,
                0x60,
                0x46,
                0x2B,
                0xD9,
                0x97,
                0x1F,
                0x98,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Photo_FocalLengthNumerator
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x3B,
                0x6B,
                0x6B,
                0x77,
                0x3D,
                0x1E,
                0x0C,
                0x4B,
                0x9A,
                0x0E,
                0x8F,
                0xBA,
                0xF2,
                0xA8,
                0x49,
                0x2A,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Photo_FocalPlaneXResolution
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x97,
                0x8D,
                0xC0,
                0xCF,
                0xF7,
                0xC6,
                0x84,
                0x44,
                0x89,
                0xDD,
                0xEB,
                0xEF,
                0x43,
                0x56,
                0xFE,
                0x76,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Photo_FocalPlaneXResolutionDenominator
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF5,
                0xF3,
                0x33,
                0x09,
                0x86,
                0x47,
                0x46,
                0x4F,
                0xA8,
                0xE8,
                0xD6,
                0x4D,
                0xD3,
                0x7F,
                0xA5,
                0x21,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Photo_FocalPlaneXResolutionNumerator
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xAF,
                0x10,
                0xCB,
                0xDC,
                0xE2,
                0xB4,
                0x88,
                0x4B,
                0x95,
                0xF9,
                0x03,
                0x1B,
                0x4D,
                0x5A,
                0xB4,
                0x90,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Photo_FocalPlaneYResolution
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD0,
                0xE4,
                0xFF,
                0x4F,
                0x4F,
                0x91,
                0xC4,
                0x4A,
                0x8D,
                0x6F,
                0xC9,
                0xC6,
                0x1D,
                0xE1,
                0x69,
                0xB1,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Photo_FocalPlaneYResolutionDenominator
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA6,
                0x79,
                0x61,
                0x1D,
                0x76,
                0xA8,
                0x31,
                0x40,
                0xB0,
                0x13,
                0x33,
                0x47,
                0xB2,
                0xB6,
                0x4D,
                0xC8,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Photo_FocalPlaneYResolutionNumerator
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC5,
                0x41,
                0xE5,
                0xA2,
                0x40,
                0x44,
                0xA8,
                0x4B,
                0x86,
                0x7E,
                0x75,
                0xCF,
                0xC0,
                0x68,
                0x28,
                0xCD,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Photo_GainControl
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x89,
                0x47,
                0x30,
                0xFA,
                0xC7,
                0x00,
                0x80,
                0x4D,
                0x90,
                0x4A,
                0x1E,
                0x4D,
                0xCC,
                0x72,
                0x65,
                0xAA,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Photo_GainControlDenominator
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xFD,
                0x4D,
                0x86,
                0x42,
                0xA4,
                0x9D,
                0x77,
                0x4F,
                0xBD,
                0xED,
                0x4A,
                0xAD,
                0x7B,
                0x25,
                0x67,
                0x35,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Photo_GainControlNumerator
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x7C,
                0xCF,
                0x8E,
                0x8E,
                0xB8,
                0xB7,
                0xB8,
                0x4E,
                0xA6,
                0x3F,
                0x0E,
                0xE7,
                0x15,
                0xC9,
                0x6F,
                0x9E,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Photo_GainControlText
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB2,
                0x38,
                0x62,
                0xC0,
                0xF9,
                0x0B,
                0x79,
                0x42,
                0xA7,
                0x23,
                0x25,
                0x85,
                0x67,
                0x15,
                0xCB,
                0x9D,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Photo_ISOSpeed
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA1,
                0x1D,
                0xB8,
                0x14,
                0x35,
                0x01,
                0x31,
                0x4D,
                0x96,
                0xD9,
                0x6C,
                0xBF,
                0xC9,
                0x67,
                0x1A,
                0x99,
                0x27,
                0x88,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Photo_LensManufacturer
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF7,
                0xCA,
                0xDD,
                0xE6,
                0xC5,
                0x29,
                0x0A,
                0x4F,
                0x9A,
                0x68,
                0xD1,
                0x94,
                0x12,
                0xEC,
                0x70,
                0x90,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Photo_LensModel
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x16,
                0x75,
                0x27,
                0xE1,
                0x5F,
                0x2B,
                0x69,
                0x48,
                0x89,
                0xB1,
                0x2E,
                0x58,
                0x5B,
                0xD3,
                0x8B,
                0x7A,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Photo_LightSource
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA1,
                0x1D,
                0xB8,
                0x14,
                0x35,
                0x01,
                0x31,
                0x4D,
                0x96,
                0xD9,
                0x6C,
                0xBF,
                0xC9,
                0x67,
                0x1A,
                0x99,
                0x08,
                0x92,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Photo_MakerNote
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x53,
                0x33,
                0x30,
                0xFA,
                0x59,
                0xB6,
                0x52,
                0x40,
                0x85,
                0xE9,
                0xBC,
                0xAC,
                0x79,
                0x54,
                0x9B,
                0x84,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Photo_MakerNoteOffset
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x24,
                0x41,
                0x3F,
                0x81,
                0xE6,
                0x34,
                0x17,
                0x4D,
                0xAB,
                0x3E,
                0x6B,
                0x1F,
                0x3C,
                0x22,
                0x47,
                0xA1,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Photo_MaxAperture
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC2,
                0xD7,
                0xF6,
                0x08,
                0xF2,
                0xE3,
                0xFC,
                0x44,
                0xAF,
                0x1E,
                0x5A,
                0xA5,
                0xC8,
                0x1A,
                0x2D,
                0x3E,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Photo_MaxApertureDenominator
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD4,
                0x24,
                0x77,
                0xC7,
                0x1F,
                0x60,
                0xC5,
                0x46,
                0x9B,
                0x89,
                0xC5,
                0x3F,
                0x93,
                0xBC,
                0xEB,
                0x77,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Photo_MaxApertureNumerator
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x91,
                0xE1,
                0x07,
                0xC1,
                0x59,
                0xA4,
                0xC5,
                0x44,
                0x9A,
                0xE6,
                0xB9,
                0x52,
                0xAD,
                0x4B,
                0x90,
                0x6D,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Photo_MeteringMode
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA1,
                0x1D,
                0xB8,
                0x14,
                0x35,
                0x01,
                0x31,
                0x4D,
                0x96,
                0xD9,
                0x6C,
                0xBF,
                0xC9,
                0x67,
                0x1A,
                0x99,
                0x07,
                0x92,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Photo_MeteringModeText
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x8C,
                0xFD,
                0x28,
                0xF6,
                0xA8,
                0x7B,
                0x5A,
                0x46,
                0xA6,
                0x5B,
                0xC5,
                0xAA,
                0x79,
                0x26,
                0x3A,
                0x9E,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Photo_Orientation
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA1,
                0x1D,
                0xB8,
                0x14,
                0x35,
                0x01,
                0x31,
                0x4D,
                0x96,
                0xD9,
                0x6C,
                0xBF,
                0xC9,
                0x67,
                0x1A,
                0x99,
                0x12,
                0x01,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Photo_OrientationText
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x3C,
                0x19,
                0xEA,
                0xA9,
                0x11,
                0xC5,
                0x8A,
                0x49,
                0xA0,
                0x6B,
                0x58,
                0xE2,
                0x77,
                0x6D,
                0xCC,
                0x28,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Photo_PeopleNames
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x6E,
                0x9B,
                0x30,
                0xE8,
                0x4C,
                0x08,
                0xB4,
                0x49,
                0xB1,
                0xFC,
                0x90,
                0xA8,
                0x03,
                0x31,
                0xB6,
                0x38,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Photo_PhotometricInterpretation
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF1,
                0x96,
                0x17,
                0x34,
                0xF9,
                0x1D,
                0x1C,
                0x4B,
                0xA5,
                0x64,
                0x91,
                0xBD,
                0xEF,
                0xA4,
                0x38,
                0x77,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Photo_PhotometricInterpretationText
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD6,
                0x37,
                0x14,
                0x82,
                0xAB,
                0x9E,
                0x65,
                0x47,
                0xA5,
                0x89,
                0x3B,
                0x1C,
                0xBB,
                0xD2,
                0x2A,
                0x61,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Photo_ProgramMode
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x6D,
                0x7F,
                0x21,
                0x6D,
                0x6A,
                0x3F,
                0x25,
                0x48,
                0xB4,
                0x70,
                0x5F,
                0x03,
                0xCA,
                0x2F,
                0xBE,
                0x9B,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Photo_ProgramModeText
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x27,
                0xAA,
                0xE3,
                0x7F,
                0x48,
                0x26,
                0xF3,
                0x42,
                0x89,
                0xB0,
                0x45,
                0x4E,
                0x5C,
                0xB1,
                0x50,
                0xC3,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Photo_RelatedSoundFile
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x45,
                0x6B,
                0x8A,
                0x31,
                0x7F,
                0x08,
                0xC2,
                0x4D,
                0xB8,
                0xCC,
                0x05,
                0x35,
                0x95,
                0x51,
                0xFC,
                0x9E,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Photo_Saturation
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x25,
                0x73,
                0x23,
                0x49,
                0x5A,
                0xA9,
                0x67,
                0x4F,
                0xB2,
                0x11,
                0x81,
                0x6B,
                0x2D,
                0x45,
                0xD2,
                0xE0,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Photo_SaturationText
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x08,
                0x8C,
                0x47,
                0x61,
                0x00,
                0xB6,
                0x84,
                0x4A,
                0xBB,
                0xE4,
                0xE9,
                0x9C,
                0x45,
                0xF0,
                0xA0,
                0x72,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Photo_Sharpness
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xDB,
                0x76,
                0x69,
                0xFC,
                0x49,
                0x83,
                0x70,
                0x49,
                0xAE,
                0x97,
                0xB3,
                0xC5,
                0x31,
                0x6A,
                0x08,
                0xF0,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Photo_SharpnessText
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x47,
                0x3F,
                0xEC,
                0x51,
                0x50,
                0xDD,
                0x1D,
                0x42,
                0x87,
                0x69,
                0x33,
                0x4F,
                0x50,
                0x42,
                0x4B,
                0x1E,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Photo_ShutterSpeed
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA1,
                0x1D,
                0xB8,
                0x14,
                0x35,
                0x01,
                0x31,
                0x4D,
                0x96,
                0xD9,
                0x6C,
                0xBF,
                0xC9,
                0x67,
                0x1A,
                0x99,
                0x01,
                0x92,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Photo_ShutterSpeedDenominator
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x75,
                0x89,
                0x3D,
                0xE1,
                0xC7,
                0x81,
                0x48,
                0x49,
                0xAE,
                0x3F,
                0x37,
                0xCA,
                0xE1,
                0x1E,
                0x8F,
                0xF7,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Photo_ShutterSpeedNumerator
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x42,
                0x40,
                0xEA,
                0x16,
                0xF4,
                0xD6,
                0xCA,
                0x4B,
                0x83,
                0x49,
                0x7C,
                0x78,
                0xD3,
                0x0F,
                0xB3,
                0x33,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Photo_SubjectDistance
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA1,
                0x1D,
                0xB8,
                0x14,
                0x35,
                0x01,
                0x31,
                0x4D,
                0x96,
                0xD9,
                0x6C,
                0xBF,
                0xC9,
                0x67,
                0x1A,
                0x99,
                0x06,
                0x92,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Photo_SubjectDistanceDenominator
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x88,
                0x0A,
                0x84,
                0x0C,
                0x43,
                0xB0,
                0x6D,
                0x46,
                0x97,
                0x66,
                0xD4,
                0xB2,
                0x6D,
                0xA3,
                0xFA,
                0x77,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Photo_SubjectDistanceNumerator
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x1C,
                0x96,
                0xF4,
                0x8A,
                0x26,
                0xF5,
                0xE5,
                0x43,
                0xAA,
                0x81,
                0xDB,
                0x76,
                0x82,
                0x19,
                0x17,
                0x8D,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Photo_TagViewAggregate
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x5D,
                0xF1,
                0x12,
                0xB8,
                0xD8,
                0xC2,
                0xBF,
                0x4B,
                0xBA,
                0xCD,
                0x79,
                0x74,
                0x43,
                0x46,
                0x11,
                0x3F,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Photo_TranscodedForSync
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x75,
                0xBB,
                0x8E,
                0x9A,
                0x58,
                0x64,
                0x82,
                0x4E,
                0xBA,
                0xCB,
                0x35,
                0xC0,
                0x09,
                0x5B,
                0x03,
                0xBB,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Photo_WhiteBalance
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x8A,
                0x3D,
                0x3D,
                0xEE,
                0x81,
                0x53,
                0xFA,
                0x4C,
                0xB1,
                0x3B,
                0xAA,
                0xF6,
                0x6B,
                0x5F,
                0x4E,
                0xC9,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Photo_WhiteBalanceText
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x5E,
                0xB9,
                0x36,
                0x63,
                0xA7,
                0xC7,
                0x6D,
                0x42,
                0x86,
                0xFD,
                0x7A,
                0xE3,
                0xD3,
                0x9C,
                0x84,
                0xB4,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_PropGroup_Advanced
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x3B,
                0x40,
                0x0A,
                0x90,
                0x7B,
                0x09,
                0x95,
                0x4B,
                0x8A,
                0xE2,
                0x07,
                0x1F,
                0xDA,
                0xEE,
                0xB1,
                0x18,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_PropGroup_Audio
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x69,
                0xD4,
                0x04,
                0x28,
                0x8F,
                0x78,
                0xAA,
                0x48,
                0x85,
                0x70,
                0x71,
                0xB9,
                0xC1,
                0x87,
                0xE1,
                0x38,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_PropGroup_Calendar
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB5,
                0xD2,
                0x73,
                0x99,
                0xD8,
                0xBF,
                0x8A,
                0x43,
                0xBA,
                0x94,
                0x53,
                0x49,
                0xB2,
                0x93,
                0x18,
                0x1A,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_PropGroup_Camera
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x32,
                0xDE,
                0x00,
                0xDE,
                0x7E,
                0x54,
                0x81,
                0x49,
                0xAD,
                0x4B,
                0x54,
                0x2F,
                0x2E,
                0x90,
                0x07,
                0xD8,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_PropGroup_Contact
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD3,
                0x5F,
                0x97,
                0xDF,
                0x0A,
                0x25,
                0x04,
                0x40,
                0x85,
                0x8F,
                0x34,
                0xE2,
                0x9A,
                0x3E,
                0x37,
                0xAA,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_PropGroup_Content
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xBA,
                0xB0,
                0xDA,
                0xD0,
                0x8A,
                0x36,
                0x50,
                0x40,
                0xA8,
                0x82,
                0x6C,
                0x01,
                0x0F,
                0xD1,
                0x9A,
                0x4F,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_PropGroup_Description
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x75,
                0xB2,
                0x69,
                0x89,
                0x75,
                0x94,
                0x00,
                0x4E,
                0xA8,
                0x87,
                0xFF,
                0x93,
                0xB8,
                0xB4,
                0x1E,
                0x44,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_PropGroup_FileSystem
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC1,
                0xD2,
                0xA7,
                0xE3,
                0xFC,
                0x80,
                0x40,
                0x4B,
                0x8F,
                0x34,
                0x30,
                0xEA,
                0x11,
                0x1B,
                0xDC,
                0x2E,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_PropGroup_General
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x30,
                0x16,
                0x30,
                0xCC,
                0x92,
                0xB1,
                0x22,
                0x4C,
                0xB3,
                0x72,
                0x9F,
                0x4C,
                0x6D,
                0x33,
                0x8E,
                0x07,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_PropGroup_GPS
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xDA,
                0x3A,
                0x71,
                0xF3,
                0xE3,
                0x90,
                0x11,
                0x4E,
                0xAA,
                0xE5,
                0xFD,
                0xC1,
                0x76,
                0x85,
                0xB9,
                0xBE,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_PropGroup_Image
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x87,
                0x0A,
                0x69,
                0xE3,
                0xA8,
                0x0F,
                0x2A,
                0x4A,
                0x9A,
                0x9F,
                0xFC,
                0xE8,
                0x82,
                0x70,
                0x55,
                0xAC,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_PropGroup_Media
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF7,
                0x2C,
                0x87,
                0x61,
                0x5E,
                0x6B,
                0x4B,
                0x4B,
                0xAC,
                0x2D,
                0x59,
                0xDA,
                0x84,
                0x45,
                0x92,
                0x48,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_PropGroup_MediaAdvanced
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x84,
                0xA2,
                0x59,
                0x88,
                0x7E,
                0xDE,
                0x42,
                0x46,
                0x99,
                0xBA,
                0xD4,
                0x31,
                0xD0,
                0x44,
                0xB1,
                0xEC,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_PropGroup_Message
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x9D,
                0x25,
                0xD7,
                0x7F,
                0xB4,
                0x16,
                0x35,
                0x41,
                0x9F,
                0x97,
                0x7C,
                0x96,
                0xEC,
                0xD2,
                0xFA,
                0x9E,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_PropGroup_Music
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x94,
                0x60,
                0xDD,
                0x68,
                0x16,
                0x72,
                0xF1,
                0x40,
                0xA0,
                0x29,
                0x43,
                0xFE,
                0x71,
                0x27,
                0x04,
                0x3F,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_PropGroup_Origin
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xFB,
                0xD2,
                0x98,
                0x25,
                0x69,
                0x55,
                0x67,
                0x43,
                0x95,
                0xDF,
                0x5C,
                0xD3,
                0xA1,
                0x77,
                0xE1,
                0xA5,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_PropGroup_PhotoAdvanced
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x5A,
                0xBF,
                0xB2,
                0x0C,
                0xE7,
                0x9E,
                0x86,
                0x4A,
                0x82,
                0x22,
                0xF0,
                0x1E,
                0x07,
                0xFD,
                0xAD,
                0xAF,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_PropGroup_RecordedTV
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x38,
                0x32,
                0xB3,
                0xE7,
                0x84,
                0x65,
                0x70,
                0x41,
                0xA5,
                0xC0,
                0xAC,
                0x25,
                0xEF,
                0xD9,
                0xDA,
                0x56,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_PropGroup_Video
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x20,
                0x09,
                0xBE,
                0xBE,
                0x71,
                0x76,
                0x54,
                0x4C,
                0xA3,
                0xEB,
                0x49,
                0xFD,
                0xDF,
                0xC1,
                0x91,
                0xEE,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_InfoTipText
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x21,
                0x4A,
                0x94,
                0xC9,
                0x06,
                0xA4,
                0xFE,
                0x48,
                0x82,
                0x25,
                0xAE,
                0xC7,
                0xE2,
                0x4C,
                0x21,
                0x1B,
                0x11,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_PropList_ConflictPrompt
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x21,
                0x4A,
                0x94,
                0xC9,
                0x06,
                0xA4,
                0xFE,
                0x48,
                0x82,
                0x25,
                0xAE,
                0xC7,
                0xE2,
                0x4C,
                0x21,
                0x1B,
                0x0B,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_PropList_ContentViewModeForBrowse
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x21,
                0x4A,
                0x94,
                0xC9,
                0x06,
                0xA4,
                0xFE,
                0x48,
                0x82,
                0x25,
                0xAE,
                0xC7,
                0xE2,
                0x4C,
                0x21,
                0x1B,
                0x0D,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_PropList_ContentViewModeForSearch
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x21,
                0x4A,
                0x94,
                0xC9,
                0x06,
                0xA4,
                0xFE,
                0x48,
                0x82,
                0x25,
                0xAE,
                0xC7,
                0xE2,
                0x4C,
                0x21,
                0x1B,
                0x0E,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_PropList_ExtendedTileInfo
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x21,
                0x4A,
                0x94,
                0xC9,
                0x06,
                0xA4,
                0xFE,
                0x48,
                0x82,
                0x25,
                0xAE,
                0xC7,
                0xE2,
                0x4C,
                0x21,
                0x1B,
                0x09,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_PropList_FileOperationPrompt
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x21,
                0x4A,
                0x94,
                0xC9,
                0x06,
                0xA4,
                0xFE,
                0x48,
                0x82,
                0x25,
                0xAE,
                0xC7,
                0xE2,
                0x4C,
                0x21,
                0x1B,
                0x0A,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_PropList_FullDetails
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x21,
                0x4A,
                0x94,
                0xC9,
                0x06,
                0xA4,
                0xFE,
                0x48,
                0x82,
                0x25,
                0xAE,
                0xC7,
                0xE2,
                0x4C,
                0x21,
                0x1B,
                0x02,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_PropList_InfoTip
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x21,
                0x4A,
                0x94,
                0xC9,
                0x06,
                0xA4,
                0xFE,
                0x48,
                0x82,
                0x25,
                0xAE,
                0xC7,
                0xE2,
                0x4C,
                0x21,
                0x1B,
                0x04,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_PropList_NonPersonal
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x1F,
                0x09,
                0xD1,
                0x49,
                0x2E,
                0x08,
                0x3F,
                0x49,
                0xB2,
                0x3F,
                0xD2,
                0x30,
                0x8A,
                0xA9,
                0x66,
                0x8C,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_PropList_PreviewDetails
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x21,
                0x4A,
                0x94,
                0xC9,
                0x06,
                0xA4,
                0xFE,
                0x48,
                0x82,
                0x25,
                0xAE,
                0xC7,
                0xE2,
                0x4C,
                0x21,
                0x1B,
                0x08,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_PropList_PreviewTitle
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x21,
                0x4A,
                0x94,
                0xC9,
                0x06,
                0xA4,
                0xFE,
                0x48,
                0x82,
                0x25,
                0xAE,
                0xC7,
                0xE2,
                0x4C,
                0x21,
                0x1B,
                0x06,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_PropList_QuickTip
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x21,
                0x4A,
                0x94,
                0xC9,
                0x06,
                0xA4,
                0xFE,
                0x48,
                0x82,
                0x25,
                0xAE,
                0xC7,
                0xE2,
                0x4C,
                0x21,
                0x1B,
                0x05,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_PropList_TileInfo
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x21,
                0x4A,
                0x94,
                0xC9,
                0x06,
                0xA4,
                0xFE,
                0x48,
                0x82,
                0x25,
                0xAE,
                0xC7,
                0xE2,
                0x4C,
                0x21,
                0x1B,
                0x03,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_PropList_XPDetailsPanel
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x80,
                0x54,
                0x27,
                0xF2,
                0x82,
                0xF7,
                0x91,
                0x42,
                0xBD,
                0x94,
                0xF1,
                0x36,
                0x93,
                0x51,
                0x3A,
                0xEC,
                0x00,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_RecordedTV_ChannelNumber
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE2,
                0x8D,
                0x74,
                0x6D,
                0x38,
                0x8D,
                0xC3,
                0x4C,
                0xAC,
                0x60,
                0xF0,
                0x09,
                0xB0,
                0x57,
                0xC5,
                0x57,
                0x07,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_RecordedTV_Credits
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE2,
                0x8D,
                0x74,
                0x6D,
                0x38,
                0x8D,
                0xC3,
                0x4C,
                0xAC,
                0x60,
                0xF0,
                0x09,
                0xB0,
                0x57,
                0xC5,
                0x57,
                0x04,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_RecordedTV_DateContentExpires
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE2,
                0x8D,
                0x74,
                0x6D,
                0x38,
                0x8D,
                0xC3,
                0x4C,
                0xAC,
                0x60,
                0xF0,
                0x09,
                0xB0,
                0x57,
                0xC5,
                0x57,
                0x0F,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_RecordedTV_EpisodeName
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE2,
                0x8D,
                0x74,
                0x6D,
                0x38,
                0x8D,
                0xC3,
                0x4C,
                0xAC,
                0x60,
                0xF0,
                0x09,
                0xB0,
                0x57,
                0xC5,
                0x57,
                0x02,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_RecordedTV_IsATSCContent
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE2,
                0x8D,
                0x74,
                0x6D,
                0x38,
                0x8D,
                0xC3,
                0x4C,
                0xAC,
                0x60,
                0xF0,
                0x09,
                0xB0,
                0x57,
                0xC5,
                0x57,
                0x10,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_RecordedTV_IsClosedCaptioningAvailable
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE2,
                0x8D,
                0x74,
                0x6D,
                0x38,
                0x8D,
                0xC3,
                0x4C,
                0xAC,
                0x60,
                0xF0,
                0x09,
                0xB0,
                0x57,
                0xC5,
                0x57,
                0x0C,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_RecordedTV_IsDTVContent
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE2,
                0x8D,
                0x74,
                0x6D,
                0x38,
                0x8D,
                0xC3,
                0x4C,
                0xAC,
                0x60,
                0xF0,
                0x09,
                0xB0,
                0x57,
                0xC5,
                0x57,
                0x11,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_RecordedTV_IsHDContent
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE2,
                0x8D,
                0x74,
                0x6D,
                0x38,
                0x8D,
                0xC3,
                0x4C,
                0xAC,
                0x60,
                0xF0,
                0x09,
                0xB0,
                0x57,
                0xC5,
                0x57,
                0x12,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_RecordedTV_IsRepeatBroadcast
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE2,
                0x8D,
                0x74,
                0x6D,
                0x38,
                0x8D,
                0xC3,
                0x4C,
                0xAC,
                0x60,
                0xF0,
                0x09,
                0xB0,
                0x57,
                0xC5,
                0x57,
                0x0D,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_RecordedTV_IsSAP
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE2,
                0x8D,
                0x74,
                0x6D,
                0x38,
                0x8D,
                0xC3,
                0x4C,
                0xAC,
                0x60,
                0xF0,
                0x09,
                0xB0,
                0x57,
                0xC5,
                0x57,
                0x0E,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_RecordedTV_NetworkAffiliation
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x13,
                0xC8,
                0x53,
                0x2C,
                0x63,
                0xFB,
                0x22,
                0x4E,
                0xA1,
                0xAB,
                0x0B,
                0x33,
                0x1C,
                0xA1,
                0xE2,
                0x73,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_RecordedTV_OriginalBroadcastDate
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x97,
                0xFE,
                0x84,
                0x46,
                0x65,
                0x87,
                0x42,
                0x48,
                0x9C,
                0x13,
                0xF0,
                0x06,
                0x44,
                0x7B,
                0x17,
                0x8C,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_RecordedTV_ProgramDescription
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE2,
                0x8D,
                0x74,
                0x6D,
                0x38,
                0x8D,
                0xC3,
                0x4C,
                0xAC,
                0x60,
                0xF0,
                0x09,
                0xB0,
                0x57,
                0xC5,
                0x57,
                0x03,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_RecordedTV_RecordingTime
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x61,
                0x7F,
                0x47,
                0xA5,
                0x82,
                0x7A,
                0xCA,
                0x4E,
                0x9D,
                0xDE,
                0x98,
                0xB6,
                0x9B,
                0x24,
                0x79,
                0xB3,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_RecordedTV_StationCallSign
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE2,
                0x8D,
                0x74,
                0x6D,
                0x38,
                0x8D,
                0xC3,
                0x4C,
                0xAC,
                0x60,
                0xF0,
                0x09,
                0xB0,
                0x57,
                0xC5,
                0x57,
                0x05,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_RecordedTV_StationName
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE7,
                0x39,
                0x54,
                0x1B,
                0xA1,
                0xEB,
                0xF8,
                0x4A,
                0xBD,
                0xD7,
                0x7A,
                0xF1,
                0xD4,
                0x54,
                0x94,
                0x93,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_LocationEmptyString
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xAB,
                0xD9,
                0xD2,
                0x62,
                0x64,
                0x8B,
                0x8D,
                0x49,
                0xB8,
                0x65,
                0x40,
                0x2D,
                0x47,
                0x96,
                0xF8,
                0x65,
                0x03,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Search_AutoSummary
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC0,
                0x36,
                0x0C,
                0x56,
                0x3A,
                0x50,
                0xCF,
                0x11,
                0xBA,
                0xA1,
                0x00,
                0x00,
                0x4C,
                0x75,
                0x2A,
                0x9A,
                0x02,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Search_ContainerHash
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x83,
                0xE2,
                0xEE,
                0xBC,
                0xDF,
                0x35,
                0x53,
                0x4D,
                0x82,
                0x6A,
                0xF3,
                0x6A,
                0x3E,
                0xEF,
                0xC6,
                0xBE,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Search_Contents
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x30,
                0xF1,
                0x25,
                0xB7,
                0xEF,
                0x47,
                0x1A,
                0x10,
                0xA5,
                0xF1,
                0x02,
                0x60,
                0x8C,
                0x9E,
                0xEB,
                0xAC,
                0x13,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Search_EntryID
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x90,
                0x1C,
                0x69,
                0x49,
                0x17,
                0x7E,
                0x1A,
                0x10,
                0xA9,
                0x1C,
                0x08,
                0x00,
                0x2B,
                0x2E,
                0xCD,
                0xA9,
                0x05,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Search_ExtendedProperties
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x46,
                0xB5,
                0x03,
                0x7B,
                0x4F,
                0xFA,
                0x52,
                0x4A,
                0xA2,
                0xFE,
                0x03,
                0xD5,
                0x31,
                0x1E,
                0x58,
                0x65,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Search_GatherTime
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x50,
                0xE3,
                0x63,
                0x0B,
                0xCC,
                0x9C,
                0xD0,
                0x11,
                0xBC,
                0xDB,
                0x00,
                0x80,
                0x5F,
                0xCC,
                0xCE,
                0x04,
                0x08,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Search_HitCount
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x90,
                0x1C,
                0x69,
                0x49,
                0x17,
                0x7E,
                0x1A,
                0x10,
                0xA9,
                0x1C,
                0x08,
                0x00,
                0x2B,
                0x2E,
                0xCD,
                0xA9,
                0x04,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Search_IsClosedDirectory
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x43,
                0xE3,
                0x63,
                0x0B,
                0xCC,
                0x9C,
                0xD0,
                0x11,
                0xBC,
                0xDB,
                0x00,
                0x80,
                0x5F,
                0xCC,
                0xCE,
                0x04,
                0x17,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Search_IsFullyContained
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x43,
                0xE3,
                0x63,
                0x0B,
                0xCC,
                0x9C,
                0xD0,
                0x11,
                0xBC,
                0xDB,
                0x00,
                0x80,
                0x5F,
                0xCC,
                0xCE,
                0x04,
                0x18,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Search_MatchKind
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x90,
                0x1C,
                0x69,
                0x49,
                0x17,
                0x7E,
                0x1A,
                0x10,
                0xA9,
                0x1C,
                0x08,
                0x00,
                0x2B,
                0x2E,
                0xCD,
                0xA9,
                0x1D,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Search_QueryFocusedSummary
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC0,
                0x36,
                0x0C,
                0x56,
                0x3A,
                0x50,
                0xCF,
                0x11,
                0xBA,
                0xA1,
                0x00,
                0x00,
                0x4C,
                0x75,
                0x2A,
                0x9A,
                0x03,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Search_QueryFocusedSummaryWithFallback
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC0,
                0x36,
                0x0C,
                0x56,
                0x3A,
                0x50,
                0xCF,
                0x11,
                0xBA,
                0xA1,
                0x00,
                0x00,
                0x4C,
                0x75,
                0x2A,
                0x9A,
                0x04,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Search_QueryPropertyHits
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x90,
                0x1C,
                0x69,
                0x49,
                0x17,
                0x7E,
                0x1A,
                0x10,
                0xA9,
                0x1C,
                0x08,
                0x00,
                0x2B,
                0x2E,
                0xCD,
                0xA9,
                0x15,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Search_Rank
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x90,
                0x1C,
                0x69,
                0x49,
                0x17,
                0x7E,
                0x1A,
                0x10,
                0xA9,
                0x1C,
                0x08,
                0x00,
                0x2B,
                0x2E,
                0xCD,
                0xA9,
                0x03,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Search_Store
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB3,
                0x92,
                0x69,
                0xA0,
                0xAF,
                0x8C,
                0xD7,
                0x4E,
                0xA5,
                0x47,
                0xB2,
                0x59,
                0xE3,
                0x2A,
                0xC9,
                0xFC,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Search_UrlToIndex
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x43,
                0xE3,
                0x63,
                0x0B,
                0xCC,
                0x9C,
                0xD0,
                0x11,
                0xBC,
                0xDB,
                0x00,
                0x80,
                0x5F,
                0xCC,
                0xCE,
                0x04,
                0x02,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Search_UrlToIndexWithModificationTime
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x43,
                0xE3,
                0x63,
                0x0B,
                0xCC,
                0x9C,
                0xD0,
                0x11,
                0xBC,
                0xDB,
                0x00,
                0x80,
                0x5F,
                0xCC,
                0xCE,
                0x04,
                0x0C,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Supplemental_Album
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x41,
                0xB1,
                0x73,
                0x0C,
                0xD6,
                0x39,
                0x53,
                0x46,
                0xA6,
                0x83,
                0xCA,
                0xB2,
                0x91,
                0xEA,
                0xF9,
                0x5B,
                0x06,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Supplemental_AlbumID
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x41,
                0xB1,
                0x73,
                0x0C,
                0xD6,
                0x39,
                0x53,
                0x46,
                0xA6,
                0x83,
                0xCA,
                0xB2,
                0x91,
                0xEA,
                0xF9,
                0x5B,
                0x02,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Supplemental_Location
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x41,
                0xB1,
                0x73,
                0x0C,
                0xD6,
                0x39,
                0x53,
                0x46,
                0xA6,
                0x83,
                0xCA,
                0xB2,
                0x91,
                0xEA,
                0xF9,
                0x5B,
                0x05,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Supplemental_Person
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x41,
                0xB1,
                0x73,
                0x0C,
                0xD6,
                0x39,
                0x53,
                0x46,
                0xA6,
                0x83,
                0xCA,
                0xB2,
                0x91,
                0xEA,
                0xF9,
                0x5B,
                0x07,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Supplemental_ResourceId
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x41,
                0xB1,
                0x73,
                0x0C,
                0xD6,
                0x39,
                0x53,
                0x46,
                0xA6,
                0x83,
                0xCA,
                0xB2,
                0x91,
                0xEA,
                0xF9,
                0x5B,
                0x03,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Supplemental_Tag
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x41,
                0xB1,
                0x73,
                0x0C,
                0xD6,
                0x39,
                0x53,
                0x46,
                0xA6,
                0x83,
                0xCA,
                0xB2,
                0x91,
                0xEA,
                0xF9,
                0x5B,
                0x04,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_ActivityInfo
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF4,
                0xEE,
                0xC8,
                0x30,
                0x32,
                0xA8,
                0xE2,
                0x41,
                0xAB,
                0x32,
                0xE3,
                0xC3,
                0xCA,
                0x28,
                0xFD,
                0x29,
                0x11,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_DescriptionID
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA6,
                0x6A,
                0x63,
                0x28,
                0x3D,
                0x95,
                0xD2,
                0x11,
                0xB5,
                0xD6,
                0x00,
                0xC0,
                0x4F,
                0xD9,
                0x18,
                0xD0,
                0x02,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Home_Grouping
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF4,
                0xEE,
                0xC8,
                0x30,
                0x32,
                0xA8,
                0xE2,
                0x41,
                0xAB,
                0x32,
                0xE3,
                0xC3,
                0xCA,
                0x28,
                0xFD,
                0x29,
                0x02,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Home_IsPinned
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF4,
                0xEE,
                0xC8,
                0x30,
                0x32,
                0xA8,
                0xE2,
                0x41,
                0xAB,
                0x32,
                0xE3,
                0xC3,
                0xCA,
                0x28,
                0xFD,
                0x29,
                0x04,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Home_ItemFolderPathDisplay
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF4,
                0xEE,
                0xC8,
                0x30,
                0x32,
                0xA8,
                0xE2,
                0x41,
                0xAB,
                0x32,
                0xE3,
                0xC3,
                0xCA,
                0x28,
                0xFD,
                0x29,
                0x06,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Home_Recommended
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF4,
                0xEE,
                0xC8,
                0x30,
                0x32,
                0xA8,
                0xE2,
                0x41,
                0xAB,
                0x32,
                0xE3,
                0xC3,
                0xCA,
                0x28,
                0xFD,
                0x29,
                0x14,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_InternalName
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x53,
                0x7D,
                0xEF,
                0x0C,
                0x64,
                0xFA,
                0xD1,
                0x11,
                0xA2,
                0x03,
                0x00,
                0x00,
                0xF8,
                0x1F,
                0xED,
                0xEE,
                0x05,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_LibraryLocationsCount
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC7,
                0x96,
                0x86,
                0x90,
                0x87,
                0x8F,
                0xF2,
                0x44,
                0x80,
                0xED,
                0xA8,
                0xC1,
                0xC6,
                0x89,
                0x45,
                0x75,
                0x02,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Link_TargetSFGAOFlagsStrings
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x81,
                0x20,
                0x94,
                0xD6,
                0x3B,
                0xD5,
                0x3D,
                0x44,
                0xAD,
                0x47,
                0x5E,
                0x05,
                0x9D,
                0x9C,
                0xD2,
                0x7A,
                0x03,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Link_TargetUrl
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x87,
                0x27,
                0xBF,
                0x5C,
                0xCF,
                0x48,
                0x08,
                0x42,
                0xB9,
                0x0E,
                0xEE,
                0x5E,
                0x5D,
                0x42,
                0x02,
                0x94,
                0x02,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_NamespaceCLSID
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA6,
                0x6A,
                0x63,
                0x28,
                0x3D,
                0x95,
                0xD2,
                0x11,
                0xB5,
                0xD6,
                0x00,
                0xC0,
                0x4F,
                0xD9,
                0x18,
                0xD0,
                0x06,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Shell_SFGAOFlagsStrings
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x81,
                0x20,
                0x94,
                0xD6,
                0x3B,
                0xD5,
                0x3D,
                0x44,
                0xAD,
                0x47,
                0x5E,
                0x05,
                0x9D,
                0x9C,
                0xD2,
                0x7A,
                0x02,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_StatusBarSelectedItemCount
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x7C,
                0x28,
                0xDC,
                0x26,
                0x3D,
                0x6E,
                0xD3,
                0x4B,
                0xB2,
                0xB0,
                0x6A,
                0x26,
                0xBA,
                0x2E,
                0x34,
                0x6D,
                0x03,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_StatusBarViewItemCount
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x7C,
                0x28,
                0xDC,
                0x26,
                0x3D,
                0x6E,
                0xD3,
                0x4B,
                0xB2,
                0xB0,
                0x6A,
                0x26,
                0xBA,
                0x2E,
                0x34,
                0x6D,
                0x02,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_StorageProviderState
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xDF,
                0x90,
                0x7E,
                0xE7,
                0x71,
                0x62,
                0x5B,
                0x4F,
                0x83,
                0x4F,
                0x2D,
                0xD1,
                0xF2,
                0x45,
                0xDD,
                0xA4,
                0x03,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_StorageProviderTransferProgress
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xDF,
                0x90,
                0x7E,
                0xE7,
                0x71,
                0x62,
                0x5B,
                0x4F,
                0x83,
                0x4F,
                0x2D,
                0xD1,
                0xF2,
                0x45,
                0xDD,
                0xA4,
                0x04,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_WebAccountID
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF4,
                0xEE,
                0xC8,
                0x30,
                0x32,
                0xA8,
                0xE2,
                0x41,
                0xAB,
                0x32,
                0xE3,
                0xC3,
                0xCA,
                0x28,
                0xFD,
                0x29,
                0x07,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_AppUserModel_ExcludeFromShowInNewInstall
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x55,
                0x28,
                0x4C,
                0x9F,
                0x79,
                0x9F,
                0x39,
                0x4B,
                0xA8,
                0xD0,
                0xE1,
                0xD4,
                0x2D,
                0xE1,
                0xD5,
                0xF3,
                0x08,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_AppUserModel_ID
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x55,
                0x28,
                0x4C,
                0x9F,
                0x79,
                0x9F,
                0x39,
                0x4B,
                0xA8,
                0xD0,
                0xE1,
                0xD4,
                0x2D,
                0xE1,
                0xD5,
                0xF3,
                0x05,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_AppUserModel_IsDestListSeparator
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x55,
                0x28,
                0x4C,
                0x9F,
                0x79,
                0x9F,
                0x39,
                0x4B,
                0xA8,
                0xD0,
                0xE1,
                0xD4,
                0x2D,
                0xE1,
                0xD5,
                0xF3,
                0x06,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_AppUserModel_IsDualMode
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x55,
                0x28,
                0x4C,
                0x9F,
                0x79,
                0x9F,
                0x39,
                0x4B,
                0xA8,
                0xD0,
                0xE1,
                0xD4,
                0x2D,
                0xE1,
                0xD5,
                0xF3,
                0x0B,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_AppUserModel_PreventPinning
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x55,
                0x28,
                0x4C,
                0x9F,
                0x79,
                0x9F,
                0x39,
                0x4B,
                0xA8,
                0xD0,
                0xE1,
                0xD4,
                0x2D,
                0xE1,
                0xD5,
                0xF3,
                0x09,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_AppUserModel_RelaunchCommand
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x55,
                0x28,
                0x4C,
                0x9F,
                0x79,
                0x9F,
                0x39,
                0x4B,
                0xA8,
                0xD0,
                0xE1,
                0xD4,
                0x2D,
                0xE1,
                0xD5,
                0xF3,
                0x02,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_AppUserModel_RelaunchDisplayNameResource
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x55,
                0x28,
                0x4C,
                0x9F,
                0x79,
                0x9F,
                0x39,
                0x4B,
                0xA8,
                0xD0,
                0xE1,
                0xD4,
                0x2D,
                0xE1,
                0xD5,
                0xF3,
                0x04,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_AppUserModel_RelaunchIconResource
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x55,
                0x28,
                0x4C,
                0x9F,
                0x79,
                0x9F,
                0x39,
                0x4B,
                0xA8,
                0xD0,
                0xE1,
                0xD4,
                0x2D,
                0xE1,
                0xD5,
                0xF3,
                0x03,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_AppUserModel_SettingsCommand
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x55,
                0x28,
                0x4C,
                0x9F,
                0x79,
                0x9F,
                0x39,
                0x4B,
                0xA8,
                0xD0,
                0xE1,
                0xD4,
                0x2D,
                0xE1,
                0xD5,
                0xF3,
                0x26,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_AppUserModel_StartPinOption
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x55,
                0x28,
                0x4C,
                0x9F,
                0x79,
                0x9F,
                0x39,
                0x4B,
                0xA8,
                0xD0,
                0xE1,
                0xD4,
                0x2D,
                0xE1,
                0xD5,
                0xF3,
                0x0C,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_AppUserModel_ToastActivatorCLSID
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x55,
                0x28,
                0x4C,
                0x9F,
                0x79,
                0x9F,
                0x39,
                0x4B,
                0xA8,
                0xD0,
                0xE1,
                0xD4,
                0x2D,
                0xE1,
                0xD5,
                0xF3,
                0x1A,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_AppUserModel_UninstallCommand
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x55,
                0x28,
                0x4C,
                0x9F,
                0x79,
                0x9F,
                0x39,
                0x4B,
                0xA8,
                0xD0,
                0xE1,
                0xD4,
                0x2D,
                0xE1,
                0xD5,
                0xF3,
                0x25,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_AppUserModel_VisualElementsManifestHintPath
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x55,
                0x28,
                0x4C,
                0x9F,
                0x79,
                0x9F,
                0x39,
                0x4B,
                0xA8,
                0xD0,
                0xE1,
                0xD4,
                0x2D,
                0xE1,
                0xD5,
                0xF3,
                0x1F,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_EdgeGesture_DisableTouchWhenFullscreen
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB2,
                0x38,
                0xCE,
                0x32,
                0x9A,
                0x2C,
                0xB1,
                0x41,
                0x9B,
                0xC5,
                0xB3,
                0x78,
                0x43,
                0x94,
                0xAA,
                0x44,
                0x02,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Software_DateLastUsed
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x90,
                0x4F,
                0x1E,
                0x84,
                0x59,
                0xFF,
                0x16,
                0x4D,
                0x89,
                0x47,
                0xE8,
                0x1B,
                0xBF,
                0xFA,
                0xB3,
                0x6D,
                0x10,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Software_ProductName
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x53,
                0x7D,
                0xEF,
                0x0C,
                0x64,
                0xFA,
                0xD1,
                0x11,
                0xA2,
                0x03,
                0x00,
                0x00,
                0xF8,
                0x1F,
                0xED,
                0xEE,
                0x07,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Sync_Comments
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x3E,
                0x53,
                0xD5,
                0x7B,
                0x15,
                0xAF,
                0xDB,
                0x44,
                0xB8,
                0xC8,
                0xBD,
                0x66,
                0x24,
                0xE1,
                0xD0,
                0x32,
                0x0D,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Sync_ConflictDescription
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x59,
                0xC1,
                0x50,
                0xCE,
                0xB8,
                0x2F,
                0xFD,
                0x41,
                0xBE,
                0x68,
                0xD3,
                0xE0,
                0x42,
                0xE2,
                0x74,
                0xBC,
                0x04,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Sync_ConflictFirstLocation
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x59,
                0xC1,
                0x50,
                0xCE,
                0xB8,
                0x2F,
                0xFD,
                0x41,
                0xBE,
                0x68,
                0xD3,
                0xE0,
                0x42,
                0xE2,
                0x74,
                0xBC,
                0x06,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Sync_ConflictSecondLocation
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x59,
                0xC1,
                0x50,
                0xCE,
                0xB8,
                0x2F,
                0xFD,
                0x41,
                0xBE,
                0x68,
                0xD3,
                0xE0,
                0x42,
                0xE2,
                0x74,
                0xBC,
                0x07,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Sync_HandlerCollectionID
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x3E,
                0x53,
                0xD5,
                0x7B,
                0x15,
                0xAF,
                0xDB,
                0x44,
                0xB8,
                0xC8,
                0xBD,
                0x66,
                0x24,
                0xE1,
                0xD0,
                0x32,
                0x02,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Sync_HandlerID
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x3E,
                0x53,
                0xD5,
                0x7B,
                0x15,
                0xAF,
                0xDB,
                0x44,
                0xB8,
                0xC8,
                0xBD,
                0x66,
                0x24,
                0xE1,
                0xD0,
                0x32,
                0x03,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Sync_HandlerName
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x59,
                0xC1,
                0x50,
                0xCE,
                0xB8,
                0x2F,
                0xFD,
                0x41,
                0xBE,
                0x68,
                0xD3,
                0xE0,
                0x42,
                0xE2,
                0x74,
                0xBC,
                0x02,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Sync_HandlerType
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x3E,
                0x53,
                0xD5,
                0x7B,
                0x15,
                0xAF,
                0xDB,
                0x44,
                0xB8,
                0xC8,
                0xBD,
                0x66,
                0x24,
                0xE1,
                0xD0,
                0x32,
                0x08,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Sync_HandlerTypeLabel
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x3E,
                0x53,
                0xD5,
                0x7B,
                0x15,
                0xAF,
                0xDB,
                0x44,
                0xB8,
                0xC8,
                0xBD,
                0x66,
                0x24,
                0xE1,
                0xD0,
                0x32,
                0x09,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Sync_ItemID
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x3E,
                0x53,
                0xD5,
                0x7B,
                0x15,
                0xAF,
                0xDB,
                0x44,
                0xB8,
                0xC8,
                0xBD,
                0x66,
                0x24,
                0xE1,
                0xD0,
                0x32,
                0x06,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Sync_ItemName
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x59,
                0xC1,
                0x50,
                0xCE,
                0xB8,
                0x2F,
                0xFD,
                0x41,
                0xBE,
                0x68,
                0xD3,
                0xE0,
                0x42,
                0xE2,
                0x74,
                0xBC,
                0x03,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Sync_ProgressPercentage
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x3E,
                0x53,
                0xD5,
                0x7B,
                0x15,
                0xAF,
                0xDB,
                0x44,
                0xB8,
                0xC8,
                0xBD,
                0x66,
                0x24,
                0xE1,
                0xD0,
                0x32,
                0x17,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Sync_State
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x3E,
                0x53,
                0xD5,
                0x7B,
                0x15,
                0xAF,
                0xDB,
                0x44,
                0xB8,
                0xC8,
                0xBD,
                0x66,
                0x24,
                0xE1,
                0xD0,
                0x32,
                0x18,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Sync_Status
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x3E,
                0x53,
                0xD5,
                0x7B,
                0x15,
                0xAF,
                0xDB,
                0x44,
                0xB8,
                0xC8,
                0xBD,
                0x66,
                0x24,
                0xE1,
                0xD0,
                0x32,
                0x0A,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Task_BillingInformation
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC6,
                0x52,
                0x7D,
                0xD3,
                0x1C,
                0x26,
                0x03,
                0x43,
                0x82,
                0xB3,
                0x08,
                0xB9,
                0x26,
                0xAC,
                0x6F,
                0x12,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Task_CompletionStatus
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x0A,
                0x8A,
                0x4D,
                0x08,
                0xD5,
                0xE6,
                0xDE,
                0x40,
                0xBF,
                0x1F,
                0xC8,
                0x82,
                0x0E,
                0x7C,
                0x87,
                0x7C,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Task_Owner
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x5F,
                0xCC,
                0xC7,
                0x08,
                0xF2,
                0x60,
                0x94,
                0x44,
                0xAD,
                0x75,
                0x55,
                0xE3,
                0xE0,
                0xB5,
                0xAD,
                0xD0,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Video_Compression
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x91,
                0x04,
                0x44,
                0x64,
                0x8B,
                0x4C,
                0xD1,
                0x11,
                0x8B,
                0x70,
                0x08,
                0x00,
                0x36,
                0xB1,
                0x1A,
                0x03,
                0x0A,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Video_Director
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x92,
                0x04,
                0x44,
                0x64,
                0x8B,
                0x4C,
                0xD1,
                0x11,
                0x8B,
                0x70,
                0x08,
                0x00,
                0x36,
                0xB1,
                0x1A,
                0x03,
                0x14,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Video_EncodingBitrate
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x91,
                0x04,
                0x44,
                0x64,
                0x8B,
                0x4C,
                0xD1,
                0x11,
                0x8B,
                0x70,
                0x08,
                0x00,
                0x36,
                0xB1,
                0x1A,
                0x03,
                0x08,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Video_FourCC
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x91,
                0x04,
                0x44,
                0x64,
                0x8B,
                0x4C,
                0xD1,
                0x11,
                0x8B,
                0x70,
                0x08,
                0x00,
                0x36,
                0xB1,
                0x1A,
                0x03,
                0x2C,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Video_FrameHeight
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x91,
                0x04,
                0x44,
                0x64,
                0x8B,
                0x4C,
                0xD1,
                0x11,
                0x8B,
                0x70,
                0x08,
                0x00,
                0x36,
                0xB1,
                0x1A,
                0x03,
                0x04,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Video_FrameRate
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x91,
                0x04,
                0x44,
                0x64,
                0x8B,
                0x4C,
                0xD1,
                0x11,
                0x8B,
                0x70,
                0x08,
                0x00,
                0x36,
                0xB1,
                0x1A,
                0x03,
                0x06,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Video_FrameWidth
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x91,
                0x04,
                0x44,
                0x64,
                0x8B,
                0x4C,
                0xD1,
                0x11,
                0x8B,
                0x70,
                0x08,
                0x00,
                0x36,
                0xB1,
                0x1A,
                0x03,
                0x03,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Video_HorizontalAspectRatio
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x91,
                0x04,
                0x44,
                0x64,
                0x8B,
                0x4C,
                0xD1,
                0x11,
                0x8B,
                0x70,
                0x08,
                0x00,
                0x36,
                0xB1,
                0x1A,
                0x03,
                0x2A,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Video_IsSpherical
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x91,
                0x04,
                0x44,
                0x64,
                0x8B,
                0x4C,
                0xD1,
                0x11,
                0x8B,
                0x70,
                0x08,
                0x00,
                0x36,
                0xB1,
                0x1A,
                0x03,
                0x64,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Video_IsStereo
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x91,
                0x04,
                0x44,
                0x64,
                0x8B,
                0x4C,
                0xD1,
                0x11,
                0x8B,
                0x70,
                0x08,
                0x00,
                0x36,
                0xB1,
                0x1A,
                0x03,
                0x62,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Video_Orientation
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x91,
                0x04,
                0x44,
                0x64,
                0x8B,
                0x4C,
                0xD1,
                0x11,
                0x8B,
                0x70,
                0x08,
                0x00,
                0x36,
                0xB1,
                0x1A,
                0x03,
                0x63,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Video_SampleSize
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x91,
                0x04,
                0x44,
                0x64,
                0x8B,
                0x4C,
                0xD1,
                0x11,
                0x8B,
                0x70,
                0x08,
                0x00,
                0x36,
                0xB1,
                0x1A,
                0x03,
                0x09,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Video_StreamName
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x91,
                0x04,
                0x44,
                0x64,
                0x8B,
                0x4C,
                0xD1,
                0x11,
                0x8B,
                0x70,
                0x08,
                0x00,
                0x36,
                0xB1,
                0x1A,
                0x03,
                0x02,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Video_StreamNumber
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x91,
                0x04,
                0x44,
                0x64,
                0x8B,
                0x4C,
                0xD1,
                0x11,
                0x8B,
                0x70,
                0x08,
                0x00,
                0x36,
                0xB1,
                0x1A,
                0x03,
                0x0B,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Video_TotalBitrate
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x91,
                0x04,
                0x44,
                0x64,
                0x8B,
                0x4C,
                0xD1,
                0x11,
                0x8B,
                0x70,
                0x08,
                0x00,
                0x36,
                0xB1,
                0x1A,
                0x03,
                0x2B,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Video_TranscodedForSync
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x91,
                0x04,
                0x44,
                0x64,
                0x8B,
                0x4C,
                0xD1,
                0x11,
                0x8B,
                0x70,
                0x08,
                0x00,
                0x36,
                0xB1,
                0x1A,
                0x03,
                0x2E,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Video_VerticalAspectRatio
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x91,
                0x04,
                0x44,
                0x64,
                0x8B,
                0x4C,
                0xD1,
                0x11,
                0x8B,
                0x70,
                0x08,
                0x00,
                0x36,
                0xB1,
                0x1A,
                0x03,
                0x2D,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Volume_FileSystem
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x35,
                0x4B,
                0x17,
                0x9B,
                0xFF,
                0x40,
                0xD2,
                0x11,
                0xA2,
                0x7E,
                0x00,
                0xC0,
                0x4F,
                0xC3,
                0x08,
                0x71,
                0x04,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Volume_IsMappedDrive
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x69,
                0x0B,
                0x9C,
                0x14,
                0x2D,
                0x2C,
                0xFC,
                0x48,
                0x80,
                0x8F,
                0xD3,
                0x18,
                0xD7,
                0x8C,
                0x46,
                0x36,
                0x02,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_Volume_IsRoot
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x35,
                0x4B,
                0x17,
                0x9B,
                0xFF,
                0x40,
                0xD2,
                0x11,
                0xA2,
                0x7E,
                0x00,
                0xC0,
                0x4F,
                0xC3,
                0x08,
                0x71,
                0x0A,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("#define PKEY_Devices_Category_Desc_Singular PKEY_Devices_Category")]
    public static ref readonly PROPERTYKEY PKEY_Devices_Category_Desc_Singular =>
        ref PKEY_Devices_Category;

    [NativeTypeName("#define PKEY_Devices_CategoryGroup_Desc PKEY_Devices_CategoryGroup")]
    public static ref readonly PROPERTYKEY PKEY_Devices_CategoryGroup_Desc =>
        ref PKEY_Devices_CategoryGroup;

    [NativeTypeName("#define PKEY_Devices_Category_Desc_Plural PKEY_Devices_CategoryPlural")]
    public static ref readonly PROPERTYKEY PKEY_Devices_Category_Desc_Plural =>
        ref PKEY_Devices_CategoryPlural;

    [NativeTypeName("#define PKEY_Devices_IsConnected PKEY_Devices_Connected")]
    public static ref readonly PROPERTYKEY PKEY_Devices_IsConnected => ref PKEY_Devices_Connected;

    [NativeTypeName("#define PKEY_Devices_IsDefaultDevice PKEY_Devices_IsDefault")]
    public static ref readonly PROPERTYKEY PKEY_Devices_IsDefaultDevice =>
        ref PKEY_Devices_IsDefault;

    [NativeTypeName("#define PKEY_Devices_IsNetworkDevice PKEY_Devices_IsNetworkConnected")]
    public static ref readonly PROPERTYKEY PKEY_Devices_IsNetworkDevice =>
        ref PKEY_Devices_IsNetworkConnected;

    [NativeTypeName("#define PKEY_Devices_IsSharedDevice PKEY_Devices_IsShared")]
    public static ref readonly PROPERTYKEY PKEY_Devices_IsSharedDevice => ref PKEY_Devices_IsShared;

    [NativeTypeName("#define PKEY_Devices_IsLocalMachine PKEY_Devices_LocalMachine")]
    public static ref readonly PROPERTYKEY PKEY_Devices_IsLocalMachine =>
        ref PKEY_Devices_LocalMachine;

    [NativeTypeName(
        "#define PKEY_Devices_Notification_LowBattery PKEY_Devices_Notifications_LowBattery"
    )]
    public static ref readonly PROPERTYKEY PKEY_Devices_Notification_LowBattery =>
        ref PKEY_Devices_Notifications_LowBattery;

    [NativeTypeName(
        "#define PKEY_Devices_Notification_MissedCall PKEY_Devices_Notifications_MissedCall"
    )]
    public static ref readonly PROPERTYKEY PKEY_Devices_Notification_MissedCall =>
        ref PKEY_Devices_Notifications_MissedCall;

    [NativeTypeName(
        "#define PKEY_Devices_Notification_NewMessage PKEY_Devices_Notifications_NewMessage"
    )]
    public static ref readonly PROPERTYKEY PKEY_Devices_Notification_NewMessage =>
        ref PKEY_Devices_Notifications_NewMessage;

    [NativeTypeName(
        "#define PKEY_Devices_Notification_NewVoicemail PKEY_Devices_Notifications_NewVoicemail"
    )]
    public static ref readonly PROPERTYKEY PKEY_Devices_Notification_NewVoicemail =>
        ref PKEY_Devices_Notifications_NewVoicemail;

    [NativeTypeName(
        "#define PKEY_Devices_Notification_StorageFull PKEY_Devices_Notifications_StorageFull"
    )]
    public static ref readonly PROPERTYKEY PKEY_Devices_Notification_StorageFull =>
        ref PKEY_Devices_Notifications_StorageFull;

    [NativeTypeName(
        "#define PKEY_Devices_Notification_StorageFullLinkText PKEY_Devices_Notifications_StorageFullLinkText"
    )]
    public static ref readonly PROPERTYKEY PKEY_Devices_Notification_StorageFullLinkText =>
        ref PKEY_Devices_Notifications_StorageFullLinkText;

    [NativeTypeName("#define PKEY_Devices_IsNotWorkingProperly PKEY_Devices_NotWorkingProperly")]
    public static ref readonly PROPERTYKEY PKEY_Devices_IsNotWorkingProperly =>
        ref PKEY_Devices_NotWorkingProperly;

    [NativeTypeName("#define PKEY_Devices_IsPaired PKEY_Devices_Paired")]
    public static ref readonly PROPERTYKEY PKEY_Devices_IsPaired => ref PKEY_Devices_Paired;
}
