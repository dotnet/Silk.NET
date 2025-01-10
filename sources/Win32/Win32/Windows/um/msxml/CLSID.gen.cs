// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/msxml.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class CLSID
{
    public static ref readonly Guid CLSID_DOMDocument
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x90,
                0xBF,
                0x33,
                0x29,
                0x36,
                0x7B,
                0xD2,
                0x11,
                0xB2,
                0x0E,
                0x00,
                0xC0,
                0x4F,
                0x98,
                0x3E,
                0x60,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid CLSID_DOMFreeThreadedDocument
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x91,
                0xBF,
                0x33,
                0x29,
                0x36,
                0x7B,
                0xD2,
                0x11,
                0xB2,
                0x0E,
                0x00,
                0xC0,
                0x4F,
                0x98,
                0x3E,
                0x60,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid CLSID_XMLHTTPRequest
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x8E,
                0x10,
                0x8C,
                0xED,
                0x49,
                0x43,
                0xD2,
                0x11,
                0x91,
                0xA4,
                0x00,
                0xC0,
                0x4F,
                0x79,
                0x69,
                0xE8,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid CLSID_XMLDSOControl
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x30,
                0xDA,
                0x0D,
                0x55,
                0x41,
                0x05,
                0xD2,
                0x11,
                0x9C,
                0xA9,
                0x00,
                0x60,
                0xB0,
                0xEC,
                0x3D,
                0x39,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid CLSID_XMLDocument
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xAF,
                0x99,
                0xC3,
                0xCF,
                0x76,
                0xD8,
                0xD0,
                0x11,
                0x9C,
                0x10,
                0x00,
                0xC0,
                0x4F,
                0xC9,
                0x9C,
                0x8E,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
