// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/UIAnimation.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class IID
{
    public static ref readonly Guid IID_IUIAnimationManager
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x6C,
                0x89,
                0x69,
                0x91,
                0x8D,
                0xAC,
                0x7D,
                0x4E,
                0x94,
                0xE5,
                0x67,
                0xFA,
                0x4D,
                0xC2,
                0xF2,
                0xE8,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IUIAnimationVariable
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x55,
                0xB1,
                0xEE,
                0x8C,
                0x49,
                0x28,
                0xE5,
                0x4C,
                0x94,
                0x48,
                0x91,
                0xFF,
                0x70,
                0xE1,
                0xE4,
                0xD9,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IUIAnimationStoryboard
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x8F,
                0x12,
                0xFF,
                0xA8,
                0xF9,
                0x9B,
                0xF1,
                0x4A,
                0x9E,
                0x67,
                0xE5,
                0xE4,
                0x10,
                0xDE,
                0xFB,
                0x84,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IUIAnimationTransition
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x52,
                0xE2,
                0x6C,
                0xDC,
                0x31,
                0xF7,
                0xCF,
                0x41,
                0xB6,
                0x10,
                0x61,
                0x4B,
                0x6C,
                0xA0,
                0x49,
                0xAD,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IUIAnimationManagerEventHandler
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xED,
                0x21,
                0x33,
                0x78,
                0xA3,
                0x78,
                0x66,
                0x43,
                0xB5,
                0x74,
                0x6A,
                0xF6,
                0x07,
                0xA6,
                0x47,
                0x88,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IUIAnimationVariableChangeHandler
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xBA,
                0xB7,
                0x58,
                0x63,
                0xD2,
                0x87,
                0xD5,
                0x42,
                0xBF,
                0x71,
                0x82,
                0xE9,
                0x19,
                0xDD,
                0x58,
                0x62,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IUIAnimationVariableIntegerChangeHandler
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x50,
                0x15,
                0x3E,
                0xBB,
                0x6E,
                0x35,
                0xB0,
                0x44,
                0x99,
                0xDA,
                0x85,
                0xAC,
                0x60,
                0x17,
                0x86,
                0x5E,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IUIAnimationStoryboardEventHandler
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x08,
                0x90,
                0x5C,
                0x3D,
                0x7C,
                0xEC,
                0x64,
                0x43,
                0x9F,
                0x8A,
                0x9A,
                0xF3,
                0xC5,
                0x8C,
                0xBA,
                0xE6,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IUIAnimationPriorityComparison
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x74,
                0x9B,
                0xFA,
                0x83,
                0x86,
                0x5F,
                0x18,
                0x46,
                0xBC,
                0x6A,
                0xA2,
                0xFA,
                0xC1,
                0x9B,
                0x3F,
                0x44,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IUIAnimationTransitionLibrary
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB1,
                0x14,
                0x5A,
                0xCA,
                0x4F,
                0xD2,
                0xB8,
                0x48,
                0x8F,
                0xE4,
                0xC7,
                0x81,
                0x69,
                0xBA,
                0x95,
                0x4E,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IUIAnimationInterpolator
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xBA,
                0xCB,
                0x15,
                0x78,
                0xF7,
                0xDD,
                0x8C,
                0x47,
                0xA4,
                0x6C,
                0x7B,
                0x6C,
                0x73,
                0x8B,
                0x79,
                0x78,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IUIAnimationTransitionFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x03,
                0x1E,
                0xD9,
                0xFC,
                0x3B,
                0x3E,
                0xAD,
                0x45,
                0xBB,
                0xB1,
                0x6D,
                0xFC,
                0x81,
                0x53,
                0x74,
                0x3D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IUIAnimationTimer
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD1,
                0xFA,
                0x0E,
                0x6B,
                0x53,
                0xA0,
                0xD6,
                0x41,
                0x90,
                0x85,
                0x33,
                0xA6,
                0x89,
                0x14,
                0x46,
                0x65,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IUIAnimationTimerUpdateHandler
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB7,
                0x09,
                0x55,
                0x19,
                0x5E,
                0x5D,
                0x3E,
                0x4E,
                0xB2,
                0x78,
                0xEE,
                0x37,
                0x59,
                0xB3,
                0x67,
                0xAD,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IUIAnimationTimerClientEventHandler
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB6,
                0x4D,
                0xDB,
                0xBE,
                0xFA,
                0x94,
                0xFB,
                0x4B,
                0xA4,
                0x7F,
                0xEF,
                0x2D,
                0x9E,
                0x40,
                0x8C,
                0x25,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IUIAnimationTimerEventHandler
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xEA,
                0x7D,
                0x4A,
                0x27,
                0x71,
                0xD7,
                0x95,
                0x40,
                0xAB,
                0xBD,
                0x8D,
                0xF7,
                0xAB,
                0xD2,
                0x3C,
                0xE3,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IUIAnimationManager2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD4,
                0xF7,
                0xB6,
                0xD8,
                0x09,
                0x41,
                0x3F,
                0x4D,
                0xAC,
                0xEE,
                0x87,
                0x99,
                0x26,
                0x96,
                0x8C,
                0xB1,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IUIAnimationVariable2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x04,
                0xB3,
                0x14,
                0x49,
                0xAB,
                0x96,
                0xD9,
                0x44,
                0x9E,
                0x77,
                0xD5,
                0x10,
                0x9B,
                0x7E,
                0x74,
                0x66,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IUIAnimationTransition2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x23,
                0x91,
                0xFF,
                0x62,
                0x5A,
                0xA8,
                0x9B,
                0x4E,
                0xA2,
                0x18,
                0x43,
                0x5A,
                0x93,
                0xE2,
                0x68,
                0xFD,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IUIAnimationManagerEventHandler2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xBA,
                0x22,
                0xE0,
                0xF6,
                0xF3,
                0xBF,
                0xEC,
                0x42,
                0x90,
                0x33,
                0xE0,
                0x73,
                0xF3,
                0x3E,
                0x83,
                0xC3,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IUIAnimationVariableChangeHandler2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD2,
                0xC8,
                0xAC,
                0x63,
                0xAE,
                0x6E,
                0xB0,
                0x4B,
                0xB8,
                0x79,
                0x58,
                0x6D,
                0xD8,
                0xCF,
                0xBE,
                0x42,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IUIAnimationVariableIntegerChangeHandler2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF1,
                0x6C,
                0x9B,
                0x82,
                0x3A,
                0x4F,
                0x12,
                0x44,
                0xAE,
                0x09,
                0xB2,
                0x43,
                0xEB,
                0x4C,
                0x6B,
                0x58,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IUIAnimationVariableCurveChangeHandler2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x91,
                0x5E,
                0x89,
                0x72,
                0x45,
                0x01,
                0x21,
                0x4C,
                0x91,
                0x92,
                0x5A,
                0xAB,
                0x40,
                0xED,
                0xDF,
                0x80,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IUIAnimationStoryboardEventHandler2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x5A,
                0xF5,
                0xC5,
                0xBA,
                0x7C,
                0xBA,
                0x4C,
                0x41,
                0xB5,
                0x99,
                0xFB,
                0xF8,
                0x50,
                0xF5,
                0x53,
                0xC6,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IUIAnimationLoopIterationChangeHandler2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA4,
                0x15,
                0x3B,
                0x2D,
                0x62,
                0x47,
                0xAB,
                0x47,
                0xA0,
                0x30,
                0xB2,
                0x32,
                0x21,
                0xDF,
                0x3A,
                0xE0,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IUIAnimationPriorityComparison2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x37,
                0x7A,
                0x6D,
                0x5B,
                0x21,
                0x46,
                0x7C,
                0x46,
                0x8B,
                0x05,
                0x70,
                0x13,
                0x1D,
                0xE6,
                0x2D,
                0xDB,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IUIAnimationTransitionLibrary2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x53,
                0xAE,
                0xCF,
                0x03,
                0x80,
                0x95,
                0xE3,
                0x4E,
                0xB3,
                0x63,
                0x2E,
                0xCE,
                0x51,
                0xB4,
                0xAF,
                0x6A,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IUIAnimationPrimitiveInterpolation
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x63,
                0x0D,
                0xB2,
                0xBA,
                0x61,
                0x43,
                0xDA,
                0x45,
                0xA2,
                0x4F,
                0xAB,
                0x85,
                0x08,
                0x84,
                0x6B,
                0x5B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IUIAnimationInterpolator2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF8,
                0xAF,
                0x76,
                0xEA,
                0x22,
                0xEA,
                0x23,
                0x4A,
                0xA0,
                0xEF,
                0xA6,
                0xA9,
                0x66,
                0x70,
                0x35,
                0x18,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IUIAnimationTransitionFactory2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x16,
                0x49,
                0x7D,
                0x93,
                0xA6,
                0xC1,
                0xD5,
                0x42,
                0x88,
                0xD8,
                0x30,
                0x34,
                0x4D,
                0x6E,
                0xFE,
                0x31,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IUIAnimationStoryboard2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD2,
                0x9C,
                0x28,
                0xAE,
                0xD4,
                0x12,
                0x45,
                0x49,
                0x94,
                0x19,
                0x9E,
                0x41,
                0xBE,
                0x03,
                0x4D,
                0xF2,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
