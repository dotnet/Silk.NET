// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/directmanipulation.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.DirectX;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class CLSID
{
    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_VerticalIndicatorContent
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x17,
                0x5F,
                0x0B,
                0xA1,
                0xE0,
                0xAF,
                0xA2,
                0x4A,
                0x91,
                0xE9,
                0x3E,
                0x70,
                0x01,
                0xD2,
                0xE6,
                0xB4,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_HorizontalIndicatorContent
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF5,
                0x8C,
                0xD1,
                0xE7,
                0xC7,
                0x3E,
                0xD5,
                0x44,
                0xA7,
                0x6B,
                0x37,
                0x70,
                0xF3,
                0xCF,
                0x90,
                0x3D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_VirtualViewportContent
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x9A,
                0xA1,
                0x06,
                0x32,
                0xF0,
                0x86,
                0xB4,
                0x4C,
                0xA7,
                0xF3,
                0x16,
                0xE3,
                0xB7,
                0xE2,
                0xD8,
                0x52,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_DragDropConfigurationBehavior
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x3E,
                0x1B,
                0xB0,
                0x09,
                0x6C,
                0xBA,
                0x4D,
                0x45,
                0x82,
                0xE8,
                0x95,
                0xE3,
                0x52,
                0x32,
                0x9F,
                0x23,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_AutoScrollBehavior
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x51,
                0x6A,
                0x12,
                0x26,
                0x70,
                0x3C,
                0x9A,
                0x4C,
                0xAE,
                0xC2,
                0x94,
                0x88,
                0x49,
                0xEE,
                0xB0,
                0x93,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_DeferContactService
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF4,
                0x7C,
                0xB6,
                0xD7,
                0xBB,
                0x84,
                0x4E,
                0x43,
                0x86,
                0xAE,
                0x65,
                0x92,
                0xBB,
                0xC9,
                0xAB,
                0xD9,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid CLSID_DirectManipulationViewport
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB6,
                0x11,
                0xE2,
                0x34,
                0x50,
                0x36,
                0x75,
                0x4F,
                0x83,
                0x34,
                0xFA,
                0x35,
                0x95,
                0x98,
                0xE1,
                0xC5,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid CLSID_DirectManipulationUpdateManager
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD5,
                0xBF,
                0xC1,
                0x9F,
                0x35,
                0x18,
                0x1A,
                0x44,
                0xB3,
                0xB1,
                0xB6,
                0xCC,
                0x74,
                0xB7,
                0x27,
                0xD0,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid CLSID_DirectManipulationPrimaryContent
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x61,
                0x26,
                0xA0,
                0xCA,
                0x9E,
                0xD5,
                0xC7,
                0x41,
                0x83,
                0x93,
                0x3B,
                0xA3,
                0xBA,
                0xCB,
                0x6B,
                0x57,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid CLSID_DirectManipulationManager
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB6,
                0x11,
                0xE2,
                0x54,
                0x50,
                0x36,
                0x75,
                0x4F,
                0x83,
                0x34,
                0xFA,
                0x35,
                0x95,
                0x98,
                0xE1,
                0xC5,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid CLSID_DirectManipulationSharedManager
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x86,
                0x32,
                0x79,
                0x99,
                0xCC,
                0x77,
                0x57,
                0x4B,
                0x96,
                0xDB,
                0x3B,
                0x35,
                0x4F,
                0x6F,
                0x9F,
                0xB5,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid CLSID_DCompManipulationCompositor
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x27,
                0xA6,
                0xDE,
                0x79,
                0x8A,
                0xA0,
                0xAC,
                0x43,
                0x8E,
                0xF5,
                0x69,
                0x00,
                0xB9,
                0x29,
                0x91,
                0x26,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
