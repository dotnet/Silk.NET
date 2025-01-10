// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/RestrictedErrorInfo.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class IID
{
    public static ref readonly Guid IID_IRestrictedErrorInfo
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x92,
                0x70,
                0xBA,
                0x82,
                0x88,
                0x4C,
                0x7D,
                0x42,
                0xA7,
                0xBC,
                0x16,
                0xDD,
                0x93,
                0xFE,
                0xB6,
                0x7E,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ILanguageExceptionErrorInfo
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF3,
                0xDB,
                0xA2,
                0x04,
                0x83,
                0xDF,
                0x6C,
                0x11,
                0x09,
                0x46,
                0x08,
                0x12,
                0xAB,
                0xF6,
                0xE0,
                0x7D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ILanguageExceptionTransform
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x71,
                0xA2,
                0xB5,
                0xFE,
                0xCD,
                0xA6,
                0xCE,
                0x45,
                0x88,
                0x0A,
                0x69,
                0x67,
                0x06,
                0xBA,
                0xDC,
                0x65,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ILanguageExceptionStackBackTrace
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB5,
                0x3F,
                0xE5,
                0xCB,
                0x67,
                0xF9,
                0x58,
                0x42,
                0x8D,
                0x34,
                0x42,
                0xF5,
                0xE2,
                0x58,
                0x33,
                0xDE,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ILanguageExceptionErrorInfo2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC4,
                0xE5,
                0x46,
                0x57,
                0x97,
                0x5B,
                0x4C,
                0x42,
                0xB6,
                0x20,
                0x28,
                0x22,
                0x91,
                0x57,
                0x34,
                0xDD,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
