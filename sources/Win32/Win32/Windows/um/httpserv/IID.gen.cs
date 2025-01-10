// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/httpserv.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class IID
{
    public static ref readonly Guid IID_IHttpStoredContext
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x76,
                0x7F,
                0x92,
                0xF1,
                0x0E,
                0x79,
                0xCB,
                0x4C,
                0xA7,
                0x2E,
                0x39,
                0x6B,
                0xDF,
                0xDA,
                0xE0,
                0x5D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IHttpModuleContextContainer
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC9,
                0xD7,
                0xFA,
                0xD7,
                0x27,
                0xAA,
                0xB9,
                0x4A,
                0xBD,
                0x60,
                0xE5,
                0x5C,
                0xCB,
                0xA3,
                0xF5,
                0xDC,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_INamedContextContainer
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x7C,
                0x6F,
                0xDB,
                0x16,
                0x94,
                0x1A,
                0xCA,
                0x47,
                0xA8,
                0xE8,
                0xFE,
                0xA6,
                0x00,
                0x5F,
                0xF3,
                0xBA,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDispensedHttpModuleContextContainer
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x59,
                0x93,
                0xE4,
                0x2A,
                0xDD,
                0x95,
                0x48,
                0x4E,
                0xAE,
                0x20,
                0xC0,
                0xCB,
                0x9D,
                0x0B,
                0xC0,
                0x3A,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IHttpPerfCounterInfo
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x4A,
                0x4C,
                0xFC,
                0xBD,
                0xA4,
                0x12,
                0x44,
                0x47,
                0x87,
                0xD8,
                0x76,
                0x5E,
                0xB3,
                0x20,
                0xC5,
                0x9F,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IHttpApplication
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE6,
                0xD9,
                0x75,
                0x3F,
                0x75,
                0x10,
                0x2C,
                0x42,
                0xAD,
                0x89,
                0x93,
                0xA8,
                0x5F,
                0x2D,
                0x7B,
                0xDC,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IHttpApplication2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x7A,
                0x3B,
                0x1A,
                0x31,
                0x73,
                0xB6,
                0x1C,
                0x4A,
                0x83,
                0x49,
                0x2E,
                0x98,
                0xA2,
                0x3C,
                0xAD,
                0xCB,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IHttpUrlInfo
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x67,
                0x61,
                0x0E,
                0x7E,
                0x94,
                0x00,
                0xA1,
                0x49,
                0x82,
                0x87,
                0xEC,
                0xF6,
                0xDC,
                0x6E,
                0x73,
                0xA6,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IScriptMapInfo
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x77,
                0x3D,
                0xFE,
                0xD7,
                0xBC,
                0x68,
                0x4A,
                0x4D,
                0x85,
                0x1F,
                0xEE,
                0xC9,
                0xFB,
                0x68,
                0x01,
                0x7C,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMetadataInfo
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x33,
                0x06,
                0xB1,
                0x48,
                0x5D,
                0x82,
                0x5E,
                0x49,
                0x93,
                0xB0,
                0x22,
                0x53,
                0x80,
                0x05,
                0x3E,
                0x8E,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IReferencedMetadataInfo
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x36,
                0xC3,
                0xC5,
                0x3F,
                0xD7,
                0x9A,
                0xEA,
                0x45,
                0xAF,
                0x2F,
                0x31,
                0xB5,
                0x93,
                0x02,
                0xC9,
                0xFE,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IHttpRequest
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x7E,
                0x8F,
                0x69,
                0xE8,
                0x6E,
                0x57,
                0xAC,
                0x4C,
                0xA3,
                0x09,
                0x67,
                0x43,
                0x53,
                0x55,
                0xFA,
                0xEF,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IHttpRequest2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE1,
                0x4A,
                0x24,
                0xD9,
                0xF8,
                0x51,
                0xA1,
                0x4A,
                0xA6,
                0x6D,
                0x19,
                0x27,
                0x7C,
                0x33,
                0xE6,
                0x10,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IHttpRequest3
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x0F,
                0x4E,
                0x2E,
                0xB3,
                0x57,
                0x40,
                0xEB,
                0x4F,
                0xAE,
                0xAB,
                0x7B,
                0x69,
                0xC0,
                0x3C,
                0x63,
                0x14,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IHttpRequest4
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x17,
                0xF5,
                0x16,
                0x38,
                0x31,
                0xF6,
                0xF0,
                0x49,
                0x8B,
                0x51,
                0x16,
                0xD6,
                0xF0,
                0xC6,
                0xFF,
                0xB2,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IHttpCachePolicy
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xCA,
                0x40,
                0x1C,
                0xCB,
                0xF2,
                0x70,
                0xA0,
                0x41,
                0xAD,
                0xD2,
                0x88,
                0x1F,
                0x5E,
                0xF5,
                0x73,
                0x88,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IHttpCachePolicy2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x07,
                0xA8,
                0x4B,
                0x9F,
                0x0E,
                0x05,
                0x95,
                0x44,
                0xAE,
                0x55,
                0x88,
                0x70,
                0xF7,
                0xE9,
                0x19,
                0x4A,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IHttpResponse
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x38,
                0x6B,
                0x1C,
                0x7E,
                0x8F,
                0x62,
                0x6C,
                0x4E,
                0x95,
                0xDC,
                0x41,
                0x23,
                0x7E,
                0xB7,
                0xF9,
                0x5E,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IHttpResponse2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x71,
                0xC8,
                0x22,
                0x08,
                0x4E,
                0xF1,
                0x74,
                0x49,
                0xA1,
                0xE6,
                0x5B,
                0x3C,
                0x1F,
                0x09,
                0xB7,
                0x6A,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IHttpResponse3
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x49,
                0x8E,
                0x57,
                0x19,
                0x80,
                0xD0,
                0xDA,
                0x45,
                0xB6,
                0x73,
                0x96,
                0xCB,
                0x47,
                0x5D,
                0x3C,
                0x5D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IHttpResponse4
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x57,
                0xCC,
                0x2A,
                0x1A,
                0xE2,
                0xCA,
                0x28,
                0x4F,
                0xB4,
                0xAB,
                0x00,
                0xC8,
                0xF9,
                0x6B,
                0x12,
                0xEC,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IHttpUser
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF8,
                0xE6,
                0x59,
                0x80,
                0xCE,
                0x10,
                0x61,
                0x4D,
                0xB4,
                0x7E,
                0x5A,
                0x1D,
                0x8D,
                0x9A,
                0x8B,
                0x67,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IHttpConnectionStoredContext
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x71,
                0x9A,
                0x1D,
                0x84,
                0xF4,
                0x75,
                0x26,
                0x46,
                0x8B,
                0x97,
                0x66,
                0x04,
                0x6C,
                0xA7,
                0xE4,
                0x5B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IHttpConnectionModuleContextContainer
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB3,
                0x2F,
                0xDD,
                0xF3,
                0x11,
                0x4D,
                0x95,
                0x42,
                0xB8,
                0xAB,
                0x4C,
                0xB6,
                0x67,
                0xAD,
                0xD1,
                0xFE,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IHttpConnection
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x00,
                0xDE,
                0xA5,
                0xD9,
                0x46,
                0x33,
                0x99,
                0x45,
                0x98,
                0x26,
                0xFE,
                0x88,
                0x56,
                0x5E,
                0x12,
                0x26,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IHttpContext
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x8C,
                0x1B,
                0x4C,
                0x42,
                0xBA,
                0xA1,
                0xD7,
                0x44,
                0xAC,
                0x98,
                0x9F,
                0x8F,
                0x45,
                0x77,
                0x01,
                0xA5,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IHttpContext2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x2C,
                0x18,
                0x86,
                0xC9,
                0x4A,
                0xCF,
                0x82,
                0x44,
                0x82,
                0x05,
                0x0D,
                0xBB,
                0xC1,
                0xFD,
                0x6C,
                0xEE,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IHttpContext3
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x22,
                0xC0,
                0x53,
                0xBF,
                0x4B,
                0xCA,
                0x49,
                0x43,
                0xA3,
                0x8E,
                0xA4,
                0xB7,
                0x8A,
                0xD8,
                0x97,
                0xFB,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IHttpContext4
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD8,
                0x63,
                0x94,
                0x2C,
                0xC4,
                0x4E,
                0x22,
                0x46,
                0x89,
                0x17,
                0xD4,
                0x86,
                0x32,
                0x1A,
                0x94,
                0x43,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IHttpTraceContext
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD5,
                0x98,
                0x90,
                0x9F,
                0x5C,
                0x91,
                0x94,
                0x42,
                0xA5,
                0x2E,
                0x66,
                0x53,
                0x2A,
                0x23,
                0x2B,
                0xC9,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IHttpCacheKey
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xAD,
                0x2A,
                0xEF,
                0xCD,
                0xB3,
                0x20,
                0x12,
                0x45,
                0xB1,
                0xB1,
                0x09,
                0x4B,
                0x38,
                0x44,
                0xAE,
                0xB2,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IHttpCacheSpecificData
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xFF,
                0x6A,
                0x77,
                0x37,
                0x2E,
                0x85,
                0xEC,
                0x4E,
                0x93,
                0xA5,
                0xB8,
                0x5A,
                0x28,
                0x5A,
                0x95,
                0xB8,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IHttpSite
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xEC,
                0xA6,
                0x16,
                0xEB,
                0x5D,
                0xBA,
                0x6F,
                0x43,
                0xBF,
                0x24,
                0x3E,
                0xDE,
                0x13,
                0x90,
                0x64,
                0x50,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IHttpFileMonitor
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xDA,
                0x22,
                0x54,
                0x98,
                0xCF,
                0xB0,
                0x3B,
                0x47,
                0xBA,
                0x9E,
                0x81,
                0x48,
                0xCE,
                0xB3,
                0xE2,
                0x40,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IHttpFileInfo
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x95,
                0x55,
                0xE9,
                0x71,
                0x74,
                0x8C,
                0xD9,
                0x44,
                0x88,
                0xA9,
                0xF5,
                0x11,
                0x2D,
                0x5F,
                0x59,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IHttpTokenEntry
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xDE,
                0xE6,
                0x86,
                0xFD,
                0x0E,
                0xFB,
                0xDD,
                0x47,
                0x82,
                0x0A,
                0xE0,
                0xDA,
                0x12,
                0xBE,
                0x46,
                0xE9,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IHttpServer
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x0F,
                0xA4,
                0xA2,
                0xED,
                0x92,
                0xFB,
                0x6D,
                0x4D,
                0xB5,
                0x2B,
                0xC8,
                0xC2,
                0x07,
                0x38,
                0x0B,
                0x4E,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IHttpServer2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x7E,
                0x63,
                0xAF,
                0x34,
                0xE8,
                0xAF,
                0x56,
                0x45,
                0xBC,
                0xC1,
                0x76,
                0x7F,
                0x8E,
                0x0B,
                0x4A,
                0x4E,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IHttpServer3
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x59,
                0x6D,
                0xA6,
                0xF7,
                0xA2,
                0xC0,
                0xB5,
                0x48,
                0xA8,
                0x8F,
                0xBE,
                0x59,
                0x75,
                0xC9,
                0x60,
                0xFB,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IHttpEventProvider
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x7D,
                0x65,
                0x3F,
                0x6F,
                0xB8,
                0x2F,
                0xC6,
                0x43,
                0xA0,
                0x96,
                0x50,
                0x64,
                0xB4,
                0x1F,
                0x05,
                0x80,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IHttpCompletionInfo
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE3,
                0x20,
                0xDD,
                0x49,
                0xC0,
                0xD9,
                0x3C,
                0x46,
                0x88,
                0x21,
                0xF3,
                0x41,
                0x3B,
                0x55,
                0xCC,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IHttpCompletionInfo2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x70,
                0x9F,
                0x12,
                0x53,
                0x96,
                0x01,
                0xEC,
                0x47,
                0xB1,
                0x6C,
                0x12,
                0x79,
                0x06,
                0xE2,
                0xAF,
                0xEB,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICustomNotificationProvider
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x34,
                0x6D,
                0x1E,
                0x67,
                0x80,
                0x93,
                0xF4,
                0x4D,
                0xB4,
                0x53,
                0x91,
                0x12,
                0x9D,
                0xF0,
                0x2B,
                0x24,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAuthenticationProvider
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD0,
                0x51,
                0x4D,
                0x30,
                0x07,
                0x03,
                0xED,
                0x45,
                0x83,
                0xFD,
                0xDD,
                0x3F,
                0xC0,
                0x32,
                0xFD,
                0xFC,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMapHandlerProvider
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x6B,
                0xCE,
                0xA3,
                0xFE,
                0x46,
                0xE3,
                0xE7,
                0x47,
                0xB2,
                0xA6,
                0xAD,
                0x26,
                0x5B,
                0xAE,
                0xFF,
                0x2C,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMapPathProvider
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x57,
                0xF5,
                0xFD,
                0x8E,
                0xF1,
                0xA8,
                0xC9,
                0x4B,
                0xB4,
                0x62,
                0x6D,
                0xF3,
                0xB0,
                0x38,
                0xA5,
                0x9A,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISendResponseProvider
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xBC,
                0xE7,
                0xF2,
                0x57,
                0xCF,
                0x0B,
                0x9F,
                0x4A,
                0x94,
                0xA4,
                0x10,
                0xE5,
                0x5C,
                0x6E,
                0x5B,
                0x51,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IReadEntityProvider
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x5A,
                0x90,
                0x6D,
                0xFE,
                0xB8,
                0x99,
                0xFD,
                0x49,
                0xB3,
                0x89,
                0xCF,
                0xC8,
                0x09,
                0x56,
                0x2B,
                0x81,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPreBeginRequestProvider
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x26,
                0x5D,
                0x71,
                0xFB,
                0xF9,
                0xAF,
                0x6A,
                0x47,
                0x8F,
                0xC0,
                0x6B,
                0x1A,
                0xCB,
                0x3D,
                0x10,
                0x98,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IHttpApplicationProvider
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x1C,
                0xC7,
                0xE2,
                0x1D,
                0x26,
                0xC1,
                0x12,
                0x45,
                0xAE,
                0xD3,
                0xF4,
                0xF8,
                0x85,
                0xE1,
                0x49,
                0x97,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IHttpApplicationResolveModulesProvider
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB9,
                0xD9,
                0x17,
                0x06,
                0x0F,
                0xE2,
                0x9F,
                0x4A,
                0x94,
                0xF9,
                0x35,
                0x40,
                0x3B,
                0x3B,
                0xE0,
                0x1E,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IGlobalRSCAQueryProvider
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x3F,
                0xC4,
                0xFD,
                0x63,
                0x4A,
                0x93,
                0xE5,
                0x4E,
                0xBC,
                0xD8,
                0x7E,
                0x7B,
                0x50,
                0xB7,
                0x56,
                0x05,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IGlobalStopListeningProvider
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x01,
                0xA6,
                0xF9,
                0x41,
                0x5D,
                0xE2,
                0xC8,
                0x4A,
                0x8A,
                0x1F,
                0x63,
                0x56,
                0x98,
                0xA3,
                0x0A,
                0xB9,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICacheProvider
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB9,
                0x5F,
                0x92,
                0x58,
                0x5E,
                0x7C,
                0x84,
                0x46,
                0x83,
                0x3B,
                0x4A,
                0x04,
                0xE1,
                0x28,
                0x66,
                0x90,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IGlobalConfigurationChangeProvider
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB4,
                0xF3,
                0x05,
                0x34,
                0xD6,
                0xB3,
                0x73,
                0x4B,
                0xB5,
                0xF5,
                0x4D,
                0x8A,
                0x3C,
                0xC6,
                0x42,
                0xCE,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IGlobalFileChangeProvider
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE5,
                0x1E,
                0xE3,
                0xEC,
                0x86,
                0x04,
                0xB0,
                0x4F,
                0xA8,
                0x75,
                0x67,
                0x39,
                0xA2,
                0xD7,
                0xDA,
                0xF5,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IGlobalTraceEventProvider
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x50,
                0xB1,
                0x6B,
                0x7C,
                0x10,
                0x03,
                0x18,
                0x47,
                0xA0,
                0x1F,
                0x6F,
                0xAC,
                0xEB,
                0x62,
                0xDC,
                0x1D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IGlobalThreadCleanupProvider
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x49,
                0xA1,
                0x36,
                0x6B,
                0x20,
                0x86,
                0xA0,
                0x45,
                0x81,
                0x97,
                0x00,
                0x81,
                0x4A,
                0x70,
                0x6E,
                0x2E,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IGlobalApplicationPreloadProvider
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD6,
                0xF8,
                0x11,
                0x21,
                0x41,
                0x0C,
                0xF7,
                0x4F,
                0xBD,
                0x45,
                0x5C,
                0x04,
                0xC7,
                0xE9,
                0x1A,
                0x73,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IGlobalApplicationPreloadProvider2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xDD,
                0xB2,
                0x1D,
                0x25,
                0xE7,
                0x81,
                0xCE,
                0x44,
                0xAE,
                0x02,
                0x46,
                0x52,
                0x9F,
                0x2D,
                0x71,
                0xEA,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IGlobalSuspendProcessCallback
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x03,
                0xF3,
                0xD8,
                0x7F,
                0x31,
                0x10,
                0x50,
                0x4E,
                0x91,
                0x8A,
                0xB7,
                0xB9,
                0x16,
                0xFD,
                0x6C,
                0x54,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IModuleAllocator
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x9C,
                0x67,
                0xC1,
                0x85,
                0x21,
                0x0B,
                0x1C,
                0x49,
                0xAF,
                0xB5,
                0xC7,
                0xB5,
                0xC8,
                0x64,
                0x64,
                0xC4,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IHttpModuleFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x30,
                0xD3,
                0x32,
                0xBA,
                0xA8,
                0x9E,
                0x9E,
                0x4B,
                0x89,
                0xF1,
                0x8C,
                0x76,
                0xA3,
                0x23,
                0x27,
                0x7F,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IHttpModuleRegistrationInfo
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB3,
                0xBE,
                0xE5,
                0x07,
                0x98,
                0xB7,
                0x9D,
                0x45,
                0xA9,
                0x8A,
                0xE6,
                0xC4,
                0x85,
                0xB2,
                0xB3,
                0xBC,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IHttpModuleRegistrationInfo2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xBF,
                0x1C,
                0xD1,
                0x4F,
                0xC5,
                0x8C,
                0x8E,
                0x41,
                0x80,
                0x00,
                0xC9,
                0xE7,
                0x65,
                0xF8,
                0x85,
                0x33,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
