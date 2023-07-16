// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mmdeviceapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;
public static partial class PKEY
{
    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_AudioEndpoint_FormFactor
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x03,
                0xD8,
                0xA5,
                0x1D,
                0x92,
                0xD4,
                0xDD,
                0x4E,
                0x8C,
                0x23,
                0xE0,
                0xC0,
                0xFF,
                0xEE,
                0x7F,
                0x0E,
                0x00,
                0x00,
                0x00,
                0x00
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_AudioEndpoint_ControlPanelPageProvider
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x03,
                0xD8,
                0xA5,
                0x1D,
                0x92,
                0xD4,
                0xDD,
                0x4E,
                0x8C,
                0x23,
                0xE0,
                0xC0,
                0xFF,
                0xEE,
                0x7F,
                0x0E,
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
    public static ref readonly PROPERTYKEY PKEY_AudioEndpoint_Association
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x03,
                0xD8,
                0xA5,
                0x1D,
                0x92,
                0xD4,
                0xDD,
                0x4E,
                0x8C,
                0x23,
                0xE0,
                0xC0,
                0xFF,
                0xEE,
                0x7F,
                0x0E,
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
    public static ref readonly PROPERTYKEY PKEY_AudioEndpoint_PhysicalSpeakers
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x03,
                0xD8,
                0xA5,
                0x1D,
                0x92,
                0xD4,
                0xDD,
                0x4E,
                0x8C,
                0x23,
                0xE0,
                0xC0,
                0xFF,
                0xEE,
                0x7F,
                0x0E,
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
    public static ref readonly PROPERTYKEY PKEY_AudioEndpoint_GUID
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x03,
                0xD8,
                0xA5,
                0x1D,
                0x92,
                0xD4,
                0xDD,
                0x4E,
                0x8C,
                0x23,
                0xE0,
                0xC0,
                0xFF,
                0xEE,
                0x7F,
                0x0E,
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
    public static ref readonly PROPERTYKEY PKEY_AudioEndpoint_Disable_SysFx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x03,
                0xD8,
                0xA5,
                0x1D,
                0x92,
                0xD4,
                0xDD,
                0x4E,
                0x8C,
                0x23,
                0xE0,
                0xC0,
                0xFF,
                0xEE,
                0x7F,
                0x0E,
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
    public static ref readonly PROPERTYKEY PKEY_AudioEndpoint_FullRangeSpeakers
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x03,
                0xD8,
                0xA5,
                0x1D,
                0x92,
                0xD4,
                0xDD,
                0x4E,
                0x8C,
                0x23,
                0xE0,
                0xC0,
                0xFF,
                0xEE,
                0x7F,
                0x0E,
                0x06,
                0x00,
                0x00,
                0x00
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_AudioEndpoint_Supports_EventDriven_Mode
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x03,
                0xD8,
                0xA5,
                0x1D,
                0x92,
                0xD4,
                0xDD,
                0x4E,
                0x8C,
                0x23,
                0xE0,
                0xC0,
                0xFF,
                0xEE,
                0x7F,
                0x0E,
                0x07,
                0x00,
                0x00,
                0x00
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_AudioEndpoint_JackSubType
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x03,
                0xD8,
                0xA5,
                0x1D,
                0x92,
                0xD4,
                0xDD,
                0x4E,
                0x8C,
                0x23,
                0xE0,
                0xC0,
                0xFF,
                0xEE,
                0x7F,
                0x0E,
                0x08,
                0x00,
                0x00,
                0x00
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_AudioEndpoint_Default_VolumeInDb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x03,
                0xD8,
                0xA5,
                0x1D,
                0x92,
                0xD4,
                0xDD,
                0x4E,
                0x8C,
                0x23,
                0xE0,
                0xC0,
                0xFF,
                0xEE,
                0x7F,
                0x0E,
                0x09,
                0x00,
                0x00,
                0x00
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_AudioEngine_DeviceFormat
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x4D,
                0x06,
                0x9F,
                0xF1,
                0x2C,
                0x08,
                0x27,
                0x4E,
                0xBC,
                0x73,
                0x68,
                0x82,
                0xA1,
                0xBB,
                0x8E,
                0x4C,
                0x00,
                0x00,
                0x00,
                0x00
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_AudioEngine_OEMFormat
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x26,
                0x0E,
                0x87,
                0xE4,
                0xC5,
                0x3C,
                0xD2,
                0x4C,
                0xBA,
                0x46,
                0xCA,
                0x0A,
                0x9A,
                0x70,
                0xED,
                0x04,
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
    public static ref readonly PROPERTYKEY PKEY_AudioEndpointLogo_IconEffects
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x0D,
                0x78,
                0xAB,
                0xF1,
                0x10,
                0x20,
                0xD3,
                0x4E,
                0xA3,
                0xA6,
                0x8B,
                0x87,
                0xF0,
                0xF0,
                0xC4,
                0x76,
                0x00,
                0x00,
                0x00,
                0x00
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_AudioEndpointLogo_IconPath
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x0D,
                0x78,
                0xAB,
                0xF1,
                0x10,
                0x20,
                0xD3,
                0x4E,
                0xA3,
                0xA6,
                0x8B,
                0x87,
                0xF0,
                0xF0,
                0xC4,
                0x76,
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
    public static ref readonly PROPERTYKEY PKEY_AudioEndpointSettings_MenuText
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x02,
                0x20,
                0x24,
                0x14,
                0x20,
                0x03,
                0xE4,
                0x4D,
                0x95,
                0x55,
                0xA7,
                0xD8,
                0x2B,
                0x73,
                0xC2,
                0x86,
                0x00,
                0x00,
                0x00,
                0x00
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY PKEY_AudioEndpointSettings_LaunchContract
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x02,
                0x20,
                0x24,
                0x14,
                0x20,
                0x03,
                0xE4,
                0x4D,
                0x95,
                0x55,
                0xA7,
                0xD8,
                0x2B,
                0x73,
                0xC2,
                0x86,
                0x01,
                0x00,
                0x00,
                0x00
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }
}