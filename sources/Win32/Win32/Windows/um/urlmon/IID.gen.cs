// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class IID
{
    [NativeTypeName("#define IID_IOInet IID_IInternet")]
    public static ref readonly Guid IID_IOInet => ref IID_IInternet;

    [NativeTypeName("#define IID_IOInetBindInfo IID_IInternetBindInfo")]
    public static ref readonly Guid IID_IOInetBindInfo => ref IID_IInternetBindInfo;

    [NativeTypeName("#define IID_IOInetBindInfoEx IID_IInternetBindInfoEx")]
    public static ref readonly Guid IID_IOInetBindInfoEx => ref IID_IInternetBindInfoEx;

    [NativeTypeName("#define IID_IOInetProtocolRoot IID_IInternetProtocolRoot")]
    public static ref readonly Guid IID_IOInetProtocolRoot => ref IID_IInternetProtocolRoot;

    [NativeTypeName("#define IID_IOInetProtocol IID_IInternetProtocol")]
    public static ref readonly Guid IID_IOInetProtocol => ref IID_IInternetProtocol;

    [NativeTypeName("#define IID_IOInetProtocolEx IID_IInternetProtocolEx")]
    public static ref readonly Guid IID_IOInetProtocolEx => ref IID_IInternetProtocolEx;

    [NativeTypeName("#define IID_IOInetProtocolSink IID_IInternetProtocolSink")]
    public static ref readonly Guid IID_IOInetProtocolSink => ref IID_IInternetProtocolSink;

    [NativeTypeName("#define IID_IOInetProtocolInfo IID_IInternetProtocolInfo")]
    public static ref readonly Guid IID_IOInetProtocolInfo => ref IID_IInternetProtocolInfo;

    [NativeTypeName("#define IID_IOInetSession IID_IInternetSession")]
    public static ref readonly Guid IID_IOInetSession => ref IID_IInternetSession;

    [NativeTypeName("#define IID_IOInetPriority IID_IInternetPriority")]
    public static ref readonly Guid IID_IOInetPriority => ref IID_IInternetPriority;

    [NativeTypeName("#define IID_IOInetThreadSwitch IID_IInternetThreadSwitch")]
    public static ref readonly Guid IID_IOInetThreadSwitch => ref IID_IInternetThreadSwitch;

    [NativeTypeName("#define IID_IOInetProtocolSinkStackable IID_IInternetProtocolSinkStackable")]
    public static ref readonly Guid IID_IOInetProtocolSinkStackable =>
        ref IID_IInternetProtocolSinkStackable;
    public static ref readonly Guid IID_IPersistMoniker
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC9,
                0xC9,
                0xEA,
                0x79,
                0xF9,
                0xBA,
                0xCE,
                0x11,
                0x8C,
                0x82,
                0x00,
                0xAA,
                0x00,
                0x4B,
                0xA9,
                0x0B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMonikerProp
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x7F,
                0x5F,
                0xCA,
                0xA5,
                0x47,
                0x18,
                0x87,
                0x4D,
                0x9C,
                0x5B,
                0x91,
                0x85,
                0x09,
                0xF7,
                0x51,
                0x1D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IBindProtocol
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xCD,
                0xC9,
                0xEA,
                0x79,
                0xF9,
                0xBA,
                0xCE,
                0x11,
                0x8C,
                0x82,
                0x00,
                0xAA,
                0x00,
                0x4B,
                0xA9,
                0x0B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IBinding
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC0,
                0xC9,
                0xEA,
                0x79,
                0xF9,
                0xBA,
                0xCE,
                0x11,
                0x8C,
                0x82,
                0x00,
                0xAA,
                0x00,
                0x4B,
                0xA9,
                0x0B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IBindStatusCallback
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC1,
                0xC9,
                0xEA,
                0x79,
                0xF9,
                0xBA,
                0xCE,
                0x11,
                0x8C,
                0x82,
                0x00,
                0xAA,
                0x00,
                0x4B,
                0xA9,
                0x0B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IBindStatusCallbackEx
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF9,
                0x4E,
                0xA7,
                0xAA,
                0xE7,
                0x8E,
                0x59,
                0x46,
                0x88,
                0xD9,
                0xF8,
                0xC5,
                0x04,
                0xDA,
                0x73,
                0xCC,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAuthenticate
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD0,
                0xC9,
                0xEA,
                0x79,
                0xF9,
                0xBA,
                0xCE,
                0x11,
                0x8C,
                0x82,
                0x00,
                0xAA,
                0x00,
                0x4B,
                0xA9,
                0x0B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAuthenticateEx
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xAF,
                0xED,
                0xD1,
                0x2A,
                0x3D,
                0xD8,
                0xB5,
                0x48,
                0x9A,
                0xDF,
                0x03,
                0xDB,
                0xE1,
                0x9F,
                0x53,
                0xBD,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IHttpNegotiate
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD2,
                0xC9,
                0xEA,
                0x79,
                0xF9,
                0xBA,
                0xCE,
                0x11,
                0x8C,
                0x82,
                0x00,
                0xAA,
                0x00,
                0x4B,
                0xA9,
                0x0B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IHttpNegotiate2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xCB,
                0x9F,
                0x9F,
                0x4F,
                0xF4,
                0xE0,
                0xEB,
                0x48,
                0xB7,
                0xAB,
                0xFA,
                0x2E,
                0xA9,
                0x36,
                0x5C,
                0xB4,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IHttpNegotiate3
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x0A,
                0xC8,
                0xB6,
                0x57,
                0xC2,
                0x34,
                0x02,
                0x46,
                0xBC,
                0x26,
                0x66,
                0xA0,
                0x2F,
                0xC5,
                0x71,
                0x53,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IWinInetFileStream
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB7,
                0xC4,
                0x34,
                0xF1,
                0xF8,
                0xB1,
                0x75,
                0x4E,
                0xB8,
                0x86,
                0x74,
                0xB9,
                0x09,
                0x43,
                0xBE,
                0xCB,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IWindowForBindingUI
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD5,
                0xC9,
                0xEA,
                0x79,
                0xFA,
                0xBA,
                0xCE,
                0x11,
                0x8C,
                0x82,
                0x00,
                0xAA,
                0x00,
                0x4B,
                0xA9,
                0x0B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICodeInstall
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD1,
                0xC9,
                0xEA,
                0x79,
                0xF9,
                0xBA,
                0xCE,
                0x11,
                0x8C,
                0x82,
                0x00,
                0xAA,
                0x00,
                0x4B,
                0xA9,
                0x0B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IUri
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x48,
                0xE7,
                0x9E,
                0xA3,
                0x27,
                0x6A,
                0x17,
                0x48,
                0xA6,
                0xF2,
                0x13,
                0x91,
                0x4B,
                0xEF,
                0x58,
                0x90,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IUriContainer
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x30,
                0xA6,
                0x58,
                0xA1,
                0x6F,
                0xED,
                0xFB,
                0x45,
                0xB9,
                0x87,
                0xF6,
                0x86,
                0x76,
                0xF5,
                0x77,
                0x52,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IUriBuilder
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE1,
                0xB2,
                0x21,
                0x42,
                0x55,
                0x89,
                0xC0,
                0x46,
                0xBD,
                0x5B,
                0xDE,
                0x98,
                0x97,
                0x56,
                0x5D,
                0xE7,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IUriBuilderFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x48,
                0xCE,
                0x82,
                0xE9,
                0x96,
                0x0B,
                0x0C,
                0x44,
                0xBC,
                0x37,
                0x0C,
                0x86,
                0x9B,
                0x27,
                0xA2,
                0x9E,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IWinInetInfo
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD6,
                0xC9,
                0xEA,
                0x79,
                0xFA,
                0xBA,
                0xCE,
                0x11,
                0x8C,
                0x82,
                0x00,
                0xAA,
                0x00,
                0x4B,
                0xA9,
                0x0B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IHttpSecurity
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD7,
                0xC9,
                0xEA,
                0x79,
                0xFA,
                0xBA,
                0xCE,
                0x11,
                0x8C,
                0x82,
                0x00,
                0xAA,
                0x00,
                0x4B,
                0xA9,
                0x0B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IWinInetHttpInfo
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD8,
                0xC9,
                0xEA,
                0x79,
                0xFA,
                0xBA,
                0xCE,
                0x11,
                0x8C,
                0x82,
                0x00,
                0xAA,
                0x00,
                0x4B,
                0xA9,
                0x0B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IWinInetHttpTimeouts
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x56,
                0xFA,
                0x86,
                0xF2,
                0xFD,
                0xC1,
                0x70,
                0x42,
                0x8E,
                0x67,
                0xB3,
                0xEB,
                0x79,
                0x0A,
                0x81,
                0xE8,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IWinInetCacheHints
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB3,
                0xC3,
                0x1E,
                0xDD,
                0x91,
                0x83,
                0xDB,
                0x4F,
                0xA9,
                0xE6,
                0x34,
                0x7C,
                0x3C,
                0xAA,
                0xA7,
                0xDD,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IWinInetCacheHints2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xAC,
                0xAE,
                0x57,
                0x78,
                0x1F,
                0xD3,
                0xBF,
                0x49,
                0x88,
                0x4E,
                0xDD,
                0x46,
                0xDF,
                0x36,
                0x78,
                0x0A,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IBindHost
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA1,
                0x01,
                0x48,
                0xFC,
                0xA9,
                0x2B,
                0xCF,
                0x11,
                0xA2,
                0x29,
                0x00,
                0xAA,
                0x00,
                0x3D,
                0x73,
                0x52,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IInternet
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE0,
                0xC9,
                0xEA,
                0x79,
                0xF9,
                0xBA,
                0xCE,
                0x11,
                0x8C,
                0x82,
                0x00,
                0xAA,
                0x00,
                0x4B,
                0xA9,
                0x0B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IInternetBindInfo
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE1,
                0xC9,
                0xEA,
                0x79,
                0xF9,
                0xBA,
                0xCE,
                0x11,
                0x8C,
                0x82,
                0x00,
                0xAA,
                0x00,
                0x4B,
                0xA9,
                0x0B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IInternetBindInfoEx
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB7,
                0x15,
                0xE0,
                0xA3,
                0x2C,
                0xA8,
                0xCD,
                0x4D,
                0xA1,
                0x50,
                0x56,
                0x9A,
                0xEE,
                0xED,
                0x36,
                0xAB,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IInternetProtocolRoot
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE3,
                0xC9,
                0xEA,
                0x79,
                0xF9,
                0xBA,
                0xCE,
                0x11,
                0x8C,
                0x82,
                0x00,
                0xAA,
                0x00,
                0x4B,
                0xA9,
                0x0B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IInternetProtocol
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE4,
                0xC9,
                0xEA,
                0x79,
                0xF9,
                0xBA,
                0xCE,
                0x11,
                0x8C,
                0x82,
                0x00,
                0xAA,
                0x00,
                0x4B,
                0xA9,
                0x0B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IInternetProtocolEx
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x66,
                0x8E,
                0xA9,
                0xC7,
                0x10,
                0x10,
                0x2C,
                0x49,
                0xA1,
                0xC8,
                0xC8,
                0x09,
                0xE1,
                0xF7,
                0x59,
                0x05,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IInternetProtocolSink
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE5,
                0xC9,
                0xEA,
                0x79,
                0xF9,
                0xBA,
                0xCE,
                0x11,
                0x8C,
                0x82,
                0x00,
                0xAA,
                0x00,
                0x4B,
                0xA9,
                0x0B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IInternetProtocolSinkStackable
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF0,
                0xC9,
                0xEA,
                0x79,
                0xF9,
                0xBA,
                0xCE,
                0x11,
                0x8C,
                0x82,
                0x00,
                0xAA,
                0x00,
                0x4B,
                0xA9,
                0x0B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IInternetSession
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE7,
                0xC9,
                0xEA,
                0x79,
                0xF9,
                0xBA,
                0xCE,
                0x11,
                0x8C,
                0x82,
                0x00,
                0xAA,
                0x00,
                0x4B,
                0xA9,
                0x0B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IInternetThreadSwitch
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE8,
                0xC9,
                0xEA,
                0x79,
                0xF9,
                0xBA,
                0xCE,
                0x11,
                0x8C,
                0x82,
                0x00,
                0xAA,
                0x00,
                0x4B,
                0xA9,
                0x0B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IInternetPriority
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xEB,
                0xC9,
                0xEA,
                0x79,
                0xF9,
                0xBA,
                0xCE,
                0x11,
                0x8C,
                0x82,
                0x00,
                0xAA,
                0x00,
                0x4B,
                0xA9,
                0x0B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IInternetProtocolInfo
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xEC,
                0xC9,
                0xEA,
                0x79,
                0xF9,
                0xBA,
                0xCE,
                0x11,
                0x8C,
                0x82,
                0x00,
                0xAA,
                0x00,
                0x4B,
                0xA9,
                0x0B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IInternetSecurityMgrSite
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xED,
                0xC9,
                0xEA,
                0x79,
                0xF9,
                0xBA,
                0xCE,
                0x11,
                0x8C,
                0x82,
                0x00,
                0xAA,
                0x00,
                0x4B,
                0xA9,
                0x0B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IInternetSecurityManager
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xEE,
                0xC9,
                0xEA,
                0x79,
                0xF9,
                0xBA,
                0xCE,
                0x11,
                0x8C,
                0x82,
                0x00,
                0xAA,
                0x00,
                0x4B,
                0xA9,
                0x0B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IInternetSecurityManagerEx
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF1,
                0xED,
                0x64,
                0xF1,
                0x7C,
                0xCC,
                0x0D,
                0x4F,
                0x9A,
                0x94,
                0x34,
                0x22,
                0x26,
                0x25,
                0xC3,
                0x93,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IInternetSecurityManagerEx2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x92,
                0x02,
                0xE5,
                0xF1,
                0x95,
                0xA7,
                0x17,
                0x41,
                0x8E,
                0x09,
                0x2B,
                0x56,
                0x0A,
                0x72,
                0xAC,
                0x60,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IZoneIdentifier
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x85,
                0xF1,
                0x45,
                0xCD,
                0x21,
                0x1B,
                0xE2,
                0x48,
                0x96,
                0x7B,
                0xEA,
                0xD7,
                0x43,
                0xA8,
                0x91,
                0x4E,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IZoneIdentifier2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x0C,
                0x76,
                0x5E,
                0xEB,
                0xEF,
                0x09,
                0xC0,
                0x45,
                0xB5,
                0x10,
                0x70,
                0x83,
                0x0C,
                0xE3,
                0x1E,
                0x6A,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IInternetHostSecurityManager
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB6,
                0x80,
                0xF2,
                0x3A,
                0x3F,
                0xCB,
                0xD0,
                0x11,
                0x89,
                0x1E,
                0x00,
                0xC0,
                0x4F,
                0xB6,
                0xBF,
                0xC4,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IInternetZoneManager
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xEF,
                0xC9,
                0xEA,
                0x79,
                0xF9,
                0xBA,
                0xCE,
                0x11,
                0x8C,
                0x82,
                0x00,
                0xAA,
                0x00,
                0x4B,
                0xA9,
                0x0B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IInternetZoneManagerEx
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x39,
                0x33,
                0xC2,
                0xA4,
                0x06,
                0x8E,
                0x1E,
                0x43,
                0x9B,
                0xF4,
                0x7E,
                0x71,
                0x1C,
                0x08,
                0x56,
                0x48,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IInternetZoneManagerEx2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x59,
                0x75,
                0xC1,
                0xED,
                0x5D,
                0xDD,
                0x46,
                0x48,
                0x8E,
                0xEF,
                0x8B,
                0xEC,
                0xBA,
                0x5A,
                0x4A,
                0xBF,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISoftDistExt
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC1,
                0x8D,
                0x5B,
                0xB1,
                0xE1,
                0xC7,
                0xD0,
                0x11,
                0x86,
                0x80,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCB,
                0x71,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICatalogFileInfo
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x00,
                0x76,
                0x1C,
                0x71,
                0x48,
                0x6B,
                0xD1,
                0x11,
                0xB4,
                0x03,
                0x00,
                0xAA,
                0x00,
                0xB9,
                0x2A,
                0xF1,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDataFilter
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x80,
                0x4C,
                0xD1,
                0x69,
                0x8E,
                0xC1,
                0xD0,
                0x11,
                0xA9,
                0xCE,
                0x00,
                0x60,
                0x97,
                0x94,
                0x23,
                0x11,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IEncodingFilterFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x00,
                0xDE,
                0xBD,
                0x70,
                0x8E,
                0xC1,
                0xD0,
                0x11,
                0xA9,
                0xCE,
                0x00,
                0x60,
                0x97,
                0x94,
                0x23,
                0x11,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IWrappedProtocol
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x85,
                0x47,
                0xC8,
                0x53,
                0x25,
                0x84,
                0xC5,
                0x4D,
                0x97,
                0x1B,
                0xE5,
                0x8D,
                0x9C,
                0x19,
                0xF9,
                0xB6,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IGetBindHandle
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x08,
                0xF4,
                0x0F,
                0xAF,
                0x9D,
                0x12,
                0x20,
                0x4B,
                0x91,
                0xF0,
                0x02,
                0xBD,
                0x23,
                0xD8,
                0x83,
                0x52,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IBindCallbackRedirect
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC2,
                0x1B,
                0xC8,
                0x11,
                0x1E,
                0x12,
                0xD5,
                0x4E,
                0xB9,
                0xC4,
                0xB4,
                0x30,
                0xBD,
                0x54,
                0xF2,
                0xC0,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IBindHttpSecurity
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x67,
                0xA9,
                0xED,
                0xA9,
                0x0E,
                0xF5,
                0x33,
                0x4A,
                0xB3,
                0x58,
                0x20,
                0x6F,
                0x6E,
                0xF3,
                0x08,
                0x6D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
