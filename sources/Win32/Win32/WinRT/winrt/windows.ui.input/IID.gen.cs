// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.ui.input.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static unsafe partial class IID
{
    public static ref readonly Guid IID_IAttachableInputObject
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x34,
                0x27,
                0x82,
                0x9B,
                0xC1,
                0xA3,
                0x2A,
                0x54,
                0xB2,
                0xF4,
                0x0E,
                0x32,
                0xB7,
                0x73,
                0xFB,
                0x07,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAttachableInputObjectFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x4E,
                0x4C,
                0xC5,
                0xA4,
                0xBC,
                0x42,
                0xFA,
                0x58,
                0xA6,
                0x40,
                0xEA,
                0x15,
                0x16,
                0xF4,
                0xC0,
                0x6B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICrossSlidingEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x38,
                0x47,
                0x37,
                0xE9,
                0x88,
                0x6F,
                0xD9,
                0x41,
                0x87,
                0x20,
                0x78,
                0xE0,
                0x8E,
                0x39,
                0x83,
                0x49,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICrossSlidingEventArgs2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x48,
                0x7D,
                0xFB,
                0xEE,
                0x70,
                0xC0,
                0xF3,
                0x59,
                0x8D,
                0xAB,
                0xBC,
                0xAF,
                0x62,
                0x1D,
                0x86,
                0x87,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDraggingEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x84,
                0x53,
                0x90,
                0x1C,
                0x3C,
                0x08,
                0xD3,
                0x4B,
                0xB5,
                0x59,
                0x17,
                0x9C,
                0xDD,
                0xEB,
                0x33,
                0xEC,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDraggingEventArgs2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF9,
                0xDB,
                0xEF,
                0x71,
                0x2A,
                0x38,
                0xCA,
                0x55,
                0xB4,
                0xB9,
                0x00,
                0x81,
                0x23,
                0xC1,
                0xBF,
                0x1A,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IEdgeGesture
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x92,
                0x52,
                0x0D,
                0x58,
                0xB1,
                0x2A,
                0xAA,
                0x49,
                0xA7,
                0xF0,
                0x33,
                0xBD,
                0x3F,
                0x8D,
                0xF9,
                0xF1,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IEdgeGestureEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x24,
                0x4A,
                0xFA,
                0x44,
                0x09,
                0x2D,
                0xE1,
                0x42,
                0x8B,
                0x5E,
                0x36,
                0x82,
                0x08,
                0x79,
                0x6A,
                0x4C,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IEdgeGestureStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x19,
                0x85,
                0x6A,
                0xBC,
                0xEE,
                0x18,
                0x43,
                0x40,
                0x98,
                0x39,
                0x4F,
                0xC5,
                0x84,
                0xD6,
                0x0A,
                0x14,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IGestureRecognizer
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xBF,
                0x37,
                0x7A,
                0xB4,
                0x6B,
                0x3D,
                0x88,
                0x4F,
                0x83,
                0xE8,
                0x6D,
                0xCB,
                0x40,
                0x12,
                0xFF,
                0xB0,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IGestureRecognizer2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x7F,
                0x09,
                0x46,
                0xD6,
                0xF7,
                0x6E,
                0x46,
                0x57,
                0x8B,
                0xA8,
                0x8F,
                0xF2,
                0x20,
                0x6E,
                0x6F,
                0x3B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IHoldingEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC5,
                0x55,
                0xF7,
                0x2B,
                0x99,
                0xE7,
                0xB4,
                0x41,
                0xBB,
                0x40,
                0x24,
                0x2F,
                0x40,
                0x95,
                0x9B,
                0x71,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IHoldingEventArgs2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xEA,
                0xA9,
                0x1D,
                0x14,
                0x79,
                0x4C,
                0x74,
                0x56,
                0xAF,
                0xEA,
                0x49,
                0x3F,
                0xDE,
                0xB9,
                0x1F,
                0x19,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IInputActivationListener
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD2,
                0x4E,
                0x6D,
                0x5D,
                0xC7,
                0x28,
                0xE3,
                0x5A,
                0xAA,
                0x74,
                0xC9,
                0x18,
                0xA9,
                0xF2,
                0x43,
                0xCA,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IInputActivationListenerActivationChangedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x65,
                0xB4,
                0x99,
                0x76,
                0xCF,
                0x1D,
                0x91,
                0x57,
                0xB4,
                0xB9,
                0x6C,
                0xAF,
                0xBE,
                0xED,
                0x20,
                0x56,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IKeyboardDeliveryInterceptor
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x68,
                0xF0,
                0xBA,
                0xB4,
                0x49,
                0x8F,
                0x6C,
                0x44,
                0x8D,
                0xB5,
                0x8C,
                0x0F,
                0xFE,
                0x85,
                0xCC,
                0x9E,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IKeyboardDeliveryInterceptorStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA2,
                0x3B,
                0xF6,
                0xF9,
                0xBA,
                0xCE,
                0x55,
                0x47,
                0x8A,
                0x7E,
                0x14,
                0xC0,
                0xFF,
                0xEC,
                0xD2,
                0x39,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IManipulationCompletedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x2B,
                0xB2,
                0x4A,
                0xB3,
                0x9B,
                0xD1,
                0xFF,
                0x46,
                0x9F,
                0x38,
                0xDE,
                0xC7,
                0x75,
                0x4B,
                0xB9,
                0xE7,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IManipulationCompletedEventArgs2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE7,
                0xDC,
                0xC0,
                0xF0,
                0xA9,
                0x30,
                0x96,
                0x5B,
                0x88,
                0x6F,
                0x65,
                0x60,
                0xA8,
                0x5E,
                0x47,
                0x57,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IManipulationInertiaStartingEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x98,
                0xA8,
                0x37,
                0xDD,
                0xBF,
                0x26,
                0x7A,
                0x46,
                0x9C,
                0xE5,
                0xCC,
                0xF3,
                0xFB,
                0x11,
                0x37,
                0x1E,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IManipulationInertiaStartingEventArgs2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB8,
                0x09,
                0x54,
                0xC2,
                0xFA,
                0xF9,
                0x45,
                0x5A,
                0xBD,
                0x97,
                0xDC,
                0xBB,
                0xB2,
                0x20,
                0x18,
                0x60,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IManipulationStartedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x3E,
                0x87,
                0xEC,
                0xDD,
                0xCE,
                0xCF,
                0x32,
                0x49,
                0x8C,
                0x1D,
                0x3C,
                0x3D,
                0x01,
                0x1A,
                0x34,
                0xC0,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IManipulationStartedEventArgs2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x4E,
                0xDB,
                0xA3,
                0x2D,
                0x83,
                0xE5,
                0x55,
                0x50,
                0xAF,
                0xAA,
                0x16,
                0xFD,
                0x98,
                0x65,
                0x31,
                0xA6,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IManipulationUpdatedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE5,
                0x4C,
                0x35,
                0xCB,
                0xB8,
                0xAB,
                0x9F,
                0x4F,
                0xB3,
                0xCE,
                0x81,
                0x81,
                0xAA,
                0x61,
                0xAD,
                0x82,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IManipulationUpdatedEventArgs2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x6A,
                0xB9,
                0xDF,
                0xF3,
                0x06,
                0x33,
                0x03,
                0x59,
                0xA1,
                0xC5,
                0xFF,
                0x97,
                0x57,
                0xA8,
                0x68,
                0x9E,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMouseWheelParameters
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x44,
                0xCA,
                0xD0,
                0xEA,
                0xED,
                0x9D,
                0x37,
                0x40,
                0x81,
                0x49,
                0x5E,
                0x4C,
                0xC2,
                0x56,
                0x44,
                0x68,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPointerPoint
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x7D,
                0x31,
                0x95,
                0xE9,
                0x96,
                0x72,
                0xD9,
                0x42,
                0x82,
                0x33,
                0xC5,
                0xBE,
                0x73,
                0xB7,
                0x4A,
                0x4A,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPointerPointProperties
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x4B,
                0x8A,
                0x9D,
                0xC7,
                0x63,
                0xC1,
                0xE7,
                0x4E,
                0x80,
                0x3F,
                0x67,
                0xCE,
                0x79,
                0xF9,
                0x97,
                0x2D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPointerPointProperties2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x3A,
                0x43,
                0xC3,
                0x22,
                0x3B,
                0xC8,
                0xC0,
                0x41,
                0xA2,
                0x96,
                0x5E,
                0x23,
                0x2D,
                0x64,
                0xD6,
                0xAF,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPointerPointStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x8D,
                0x63,
                0x06,
                0xA5,
                0x1A,
                0x2A,
                0x3E,
                0x41,
                0xBC,
                0x75,
                0x9F,
                0x38,
                0x38,
                0x1C,
                0xC0,
                0x69,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPointerPointTransform
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x4F,
                0xE1,
                0x5F,
                0x4D,
                0x7C,
                0xB8,
                0x28,
                0x40,
                0xBC,
                0x9C,
                0x59,
                0xE9,
                0x94,
                0x7F,
                0xB0,
                0x56,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPointerVisualizationSettings
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x61,
                0x64,
                0x1E,
                0x4D,
                0xF7,
                0x84,
                0x9D,
                0x49,
                0xBD,
                0x91,
                0x2A,
                0x36,
                0xE2,
                0xB7,
                0xAA,
                0xA2,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPointerVisualizationSettingsStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xDB,
                0x0E,
                0x87,
                0x68,
                0x5B,
                0x16,
                0x14,
                0x42,
                0xB4,
                0xF3,
                0x58,
                0x4E,
                0xCA,
                0x8C,
                0x8A,
                0x69,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IRadialController
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC8,
                0xD1,
                0x55,
                0x30,
                0x51,
                0xDF,
                0xD4,
                0x43,
                0xB2,
                0x3B,
                0x0E,
                0x10,
                0x37,
                0x46,
                0x7A,
                0x09,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IRadialController2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xFF,
                0x7E,
                0x57,
                0x3D,
                0xEE,
                0x4C,
                0xE6,
                0x11,
                0xB5,
                0x35,
                0x00,
                0x1B,
                0xDC,
                0x06,
                0xAB,
                0x3B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IRadialControllerButtonClickedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x38,
                0xA4,
                0x6A,
                0x20,
                0x51,
                0xE6,
                0xE5,
                0x11,
                0xBF,
                0x62,
                0x2C,
                0x27,
                0xD7,
                0x40,
                0x4E,
                0x85,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IRadialControllerButtonClickedEventArgs2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF3,
                0x7E,
                0x57,
                0x3D,
                0xEE,
                0x3C,
                0xE6,
                0x11,
                0xB5,
                0x35,
                0x00,
                0x1B,
                0xDC,
                0x06,
                0xAB,
                0x3B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IRadialControllerButtonHoldingEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xEE,
                0x7E,
                0x57,
                0x3D,
                0xEE,
                0x3C,
                0xE6,
                0x11,
                0xB5,
                0x35,
                0x00,
                0x1B,
                0xDC,
                0x06,
                0xAB,
                0x3B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IRadialControllerButtonPressedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xED,
                0x7E,
                0x57,
                0x3D,
                0xEE,
                0x4C,
                0xE6,
                0x11,
                0xB5,
                0x35,
                0x00,
                0x1B,
                0xDC,
                0x06,
                0xAB,
                0x3B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IRadialControllerButtonReleasedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xEF,
                0x7E,
                0x57,
                0x3D,
                0xEE,
                0x3C,
                0xE6,
                0x11,
                0xB5,
                0x35,
                0x00,
                0x1B,
                0xDC,
                0x06,
                0xAB,
                0x3B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IRadialControllerConfiguration
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xCB,
                0x9E,
                0xB7,
                0xA6,
                0x52,
                0x6A,
                0x30,
                0x44,
                0x91,
                0x0C,
                0x56,
                0x37,
                0x0A,
                0x9D,
                0x6B,
                0x42,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IRadialControllerConfiguration2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF7,
                0x7E,
                0x57,
                0x3D,
                0xEE,
                0x3C,
                0xE6,
                0x11,
                0xB5,
                0x35,
                0x00,
                0x1B,
                0xDC,
                0x06,
                0xAB,
                0x3B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IRadialControllerConfigurationStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE5,
                0xB0,
                0xB6,
                0x79,
                0x9A,
                0x06,
                0x86,
                0x44,
                0xA9,
                0x9D,
                0x8D,
                0xB7,
                0x72,
                0xB9,
                0x64,
                0x2F,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IRadialControllerConfigurationStatics2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x17,
                0x8B,
                0xE0,
                0x53,
                0x05,
                0xE2,
                0xD3,
                0x48,
                0x9C,
                0xAF,
                0x80,
                0xFF,
                0x47,
                0xC4,
                0xD7,
                0xC7,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IRadialControllerControlAcquiredEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x39,
                0xA4,
                0x6A,
                0x20,
                0x51,
                0xE6,
                0xE5,
                0x11,
                0xBF,
                0x62,
                0x2C,
                0x27,
                0xD7,
                0x40,
                0x4E,
                0x85,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IRadialControllerControlAcquiredEventArgs2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF4,
                0x7E,
                0x57,
                0x3D,
                0xEE,
                0x3C,
                0xE6,
                0x11,
                0xB5,
                0x35,
                0x00,
                0x1B,
                0xDC,
                0x06,
                0xAB,
                0x3B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IRadialControllerMenu
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x5D,
                0xB3,
                0x06,
                0x85,
                0x40,
                0xF6,
                0x12,
                0x44,
                0xAB,
                0xA0,
                0xBA,
                0xD0,
                0x77,
                0xE5,
                0xEA,
                0x8A,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IRadialControllerMenuItem
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x8D,
                0xC9,
                0x0F,
                0xC8,
                0x0B,
                0xAD,
                0x9C,
                0x4C,
                0x8F,
                0x2F,
                0x13,
                0x6A,
                0x23,
                0x73,
                0xA6,
                0xBA,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IRadialControllerMenuItemStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x87,
                0x08,
                0x9E,
                0x24,
                0x42,
                0xD8,
                0x24,
                0x45,
                0x9D,
                0xF8,
                0xE0,
                0xD6,
                0x47,
                0xED,
                0xC8,
                0x87,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IRadialControllerMenuItemStatics2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xBE,
                0x70,
                0xBB,
                0x0C,
                0x3E,
                0x7E,
                0xBD,
                0x48,
                0xBE,
                0x04,
                0x2C,
                0x7F,
                0xCA,
                0xA9,
                0xC1,
                0xFF,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IRadialControllerRotationChangedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x35,
                0xA4,
                0x6A,
                0x20,
                0x51,
                0xE6,
                0xE5,
                0x11,
                0xBF,
                0x62,
                0x2C,
                0x27,
                0xD7,
                0x40,
                0x4E,
                0x85,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IRadialControllerRotationChangedEventArgs2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xEC,
                0x7E,
                0x57,
                0x3D,
                0xEE,
                0x4C,
                0xE6,
                0x11,
                0xB5,
                0x35,
                0x00,
                0x1B,
                0xDC,
                0x06,
                0xAB,
                0x3B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IRadialControllerScreenContact
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x34,
                0xA4,
                0x6A,
                0x20,
                0x51,
                0xE6,
                0xE5,
                0x11,
                0xBF,
                0x62,
                0x2C,
                0x27,
                0xD7,
                0x40,
                0x4E,
                0x85,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IRadialControllerScreenContactContinuedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x37,
                0xA4,
                0x6A,
                0x20,
                0x51,
                0xE6,
                0xE5,
                0x11,
                0xBF,
                0x62,
                0x2C,
                0x27,
                0xD7,
                0x40,
                0x4E,
                0x85,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IRadialControllerScreenContactContinuedEventArgs2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF1,
                0x7E,
                0x57,
                0x3D,
                0xEE,
                0x3C,
                0xE6,
                0x11,
                0xB5,
                0x35,
                0x00,
                0x1B,
                0xDC,
                0x06,
                0xAB,
                0x3B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IRadialControllerScreenContactEndedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF2,
                0x7E,
                0x57,
                0x3D,
                0xEE,
                0x3C,
                0xE6,
                0x11,
                0xB5,
                0x35,
                0x00,
                0x1B,
                0xDC,
                0x06,
                0xAB,
                0x3B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IRadialControllerScreenContactStartedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x36,
                0xA4,
                0x6A,
                0x20,
                0x51,
                0xE6,
                0xE5,
                0x11,
                0xBF,
                0x62,
                0x2C,
                0x27,
                0xD7,
                0x40,
                0x4E,
                0x85,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IRadialControllerScreenContactStartedEventArgs2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF0,
                0x7E,
                0x57,
                0x3D,
                0xEE,
                0x3C,
                0xE6,
                0x11,
                0xB5,
                0x35,
                0x00,
                0x1B,
                0xDC,
                0x06,
                0xAB,
                0x3B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IRadialControllerStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB7,
                0xD0,
                0xDE,
                0xFA,
                0x4C,
                0xB8,
                0x94,
                0x48,
                0x87,
                0xAA,
                0x8F,
                0x25,
                0xAA,
                0x5F,
                0x28,
                0x8B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IRightTappedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xBD,
                0x40,
                0xBF,
                0x4C,
                0x7A,
                0xAF,
                0x36,
                0x4A,
                0x94,
                0x76,
                0xB1,
                0xDC,
                0xE1,
                0x41,
                0x70,
                0x9A,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IRightTappedEventArgs2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xBB,
                0xB7,
                0xC7,
                0x61,
                0x57,
                0x9F,
                0x57,
                0x58,
                0xA3,
                0x3C,
                0xC5,
                0x8C,
                0x3D,
                0xFA,
                0x95,
                0x9E,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISystemButtonEventController
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA9,
                0x93,
                0xB8,
                0x59,
                0xBC,
                0x73,
                0xB5,
                0x52,
                0xBA,
                0x41,
                0x82,
                0x51,
                0x1B,
                0x2C,
                0xB4,
                0x6C,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISystemButtonEventControllerStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x7B,
                0xB0,
                0x2F,
                0x63,
                0xBD,
                0x20,
                0x15,
                0x5E,
                0xAF,
                0x4A,
                0x00,
                0xDB,
                0xF2,
                0x06,
                0x4F,
                0xFA,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISystemFunctionButtonEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x6F,
                0x89,
                0x33,
                0x48,
                0xD1,
                0x80,
                0xD6,
                0x5D,
                0x92,
                0xA7,
                0x62,
                0xA5,
                0x08,
                0xFF,
                0xEF,
                0x5A,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISystemFunctionLockChangedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x08,
                0x06,
                0x04,
                0xCD,
                0xF9,
                0xFC,
                0x5C,
                0x58,
                0xBE,
                0xAB,
                0xF1,
                0xD2,
                0xEA,
                0xF3,
                0x64,
                0xAB,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISystemFunctionLockIndicatorChangedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x4E,
                0xB9,
                0x12,
                0xB2,
                0x6F,
                0x7A,
                0xAE,
                0x58,
                0xB3,
                0x04,
                0xBA,
                0xE6,
                0x1D,
                0x03,
                0x71,
                0xB9,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ITappedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE4,
                0x26,
                0xA1,
                0xCF,
                0x3A,
                0x25,
                0x3C,
                0x4C,
                0x95,
                0x3B,
                0x39,
                0x5C,
                0x37,
                0xAE,
                0xD3,
                0x09,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ITappedEventArgs2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF2,
                0x88,
                0x43,
                0x29,
                0x7E,
                0x17,
                0xD5,
                0x51,
                0xBE,
                0x56,
                0xEE,
                0x08,
                0x66,
                0xFA,
                0x96,
                0x8C,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
