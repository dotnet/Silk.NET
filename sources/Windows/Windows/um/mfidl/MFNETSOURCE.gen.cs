// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;
public static partial class MFNETSOURCE
{
    [NativeTypeName("const IID")]
    public static ref readonly Guid MFNETSOURCE_SSLCERTIFICATE_MANAGER
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x27,
                0xCB,
                0xE6,
                0x55,
                0x9B,
                0xE6,
                0x67,
                0x42,
                0x94,
                0x0C,
                0x2D,
                0x7E,
                0xC5,
                0xBB,
                0x8A,
                0x0F
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MFNETSOURCE_RESOURCE_FILTER
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xF6,
                0x0F,
                0x5D,
                0x81,
                0x5A,
                0x26,
                0x77,
                0x44,
                0x9E,
                0x46,
                0x7B,
                0x80,
                0xAD,
                0x80,
                0xB5,
                0xFB
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MFNETSOURCE_STATISTICS_SERVICE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x75,
                0xF2,
                0xB1,
                0x3C,
                0x05,
                0x05,
                0x5D,
                0x4C,
                0xAE,
                0x71,
                0x0A,
                0x55,
                0x63,
                0x44,
                0xEF,
                0xA1
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MFNETSOURCE_STATISTICS
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x74,
                0xF2,
                0xB1,
                0x3C,
                0x05,
                0x05,
                0x5D,
                0x4C,
                0xAE,
                0x71,
                0x0A,
                0x55,
                0x63,
                0x44,
                0xEF,
                0xA1
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MFNETSOURCE_BUFFERINGTIME
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x76,
                0xF2,
                0xB1,
                0x3C,
                0x05,
                0x05,
                0x5D,
                0x4C,
                0xAE,
                0x71,
                0x0A,
                0x55,
                0x63,
                0x44,
                0xEF,
                0xA1
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MFNETSOURCE_ACCELERATEDSTREAMINGDURATION
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x77,
                0xF2,
                0xB1,
                0x3C,
                0x05,
                0x05,
                0x5D,
                0x4C,
                0xAE,
                0x71,
                0x0A,
                0x55,
                0x63,
                0x44,
                0xEF,
                0xA1
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MFNETSOURCE_MAXUDPACCELERATEDSTREAMINGDURATION
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x79,
                0x28,
                0xAB,
                0x4A,
                0xE1,
                0xBB,
                0x94,
                0x49,
                0x9F,
                0xF0,
                0x54,
                0x95,
                0xBD,
                0x25,
                0x01,
                0x29
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MFNETSOURCE_MAXBUFFERTIMEMS
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xE6,
                0x24,
                0x8B,
                0x40,
                0x38,
                0x40,
                0x01,
                0x44,
                0xB5,
                0xB2,
                0xFE,
                0x70,
                0x1A,
                0x9E,
                0xBF,
                0x10
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MFNETSOURCE_CONNECTIONBANDWIDTH
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x78,
                0xF2,
                0xB1,
                0x3C,
                0x05,
                0x05,
                0x5D,
                0x4C,
                0xAE,
                0x71,
                0x0A,
                0x55,
                0x63,
                0x44,
                0xEF,
                0xA1
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MFNETSOURCE_CACHEENABLED
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x79,
                0xF2,
                0xB1,
                0x3C,
                0x05,
                0x05,
                0x5D,
                0x4C,
                0xAE,
                0x71,
                0x0A,
                0x55,
                0x63,
                0x44,
                0xEF,
                0xA1
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MFNETSOURCE_AUTORECONNECTLIMIT
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x7A,
                0xF2,
                0xB1,
                0x3C,
                0x05,
                0x05,
                0x5D,
                0x4C,
                0xAE,
                0x71,
                0x0A,
                0x55,
                0x63,
                0x44,
                0xEF,
                0xA1
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MFNETSOURCE_RESENDSENABLED
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x7B,
                0xF2,
                0xB1,
                0x3C,
                0x05,
                0x05,
                0x5D,
                0x4C,
                0xAE,
                0x71,
                0x0A,
                0x55,
                0x63,
                0x44,
                0xEF,
                0xA1
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MFNETSOURCE_THINNINGENABLED
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x7C,
                0xF2,
                0xB1,
                0x3C,
                0x05,
                0x05,
                0x5D,
                0x4C,
                0xAE,
                0x71,
                0x0A,
                0x55,
                0x63,
                0x44,
                0xEF,
                0xA1
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MFNETSOURCE_PROTOCOL
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x7D,
                0xF2,
                0xB1,
                0x3C,
                0x05,
                0x05,
                0x5D,
                0x4C,
                0xAE,
                0x71,
                0x0A,
                0x55,
                0x63,
                0x44,
                0xEF,
                0xA1
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MFNETSOURCE_TRANSPORT
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x7E,
                0xF2,
                0xB1,
                0x3C,
                0x05,
                0x05,
                0x5D,
                0x4C,
                0xAE,
                0x71,
                0x0A,
                0x55,
                0x63,
                0x44,
                0xEF,
                0xA1
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MFNETSOURCE_PREVIEWMODEENABLED
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x7F,
                0xF2,
                0xB1,
                0x3C,
                0x05,
                0x05,
                0x5D,
                0x4C,
                0xAE,
                0x71,
                0x0A,
                0x55,
                0x63,
                0x44,
                0xEF,
                0xA1
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MFNETSOURCE_CREDENTIAL_MANAGER
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x80,
                0xF2,
                0xB1,
                0x3C,
                0x05,
                0x05,
                0x5D,
                0x4C,
                0xAE,
                0x71,
                0x0A,
                0x55,
                0x63,
                0x44,
                0xEF,
                0xA1
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MFNETSOURCE_PPBANDWIDTH
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x81,
                0xF2,
                0xB1,
                0x3C,
                0x05,
                0x05,
                0x5D,
                0x4C,
                0xAE,
                0x71,
                0x0A,
                0x55,
                0x63,
                0x44,
                0xEF,
                0xA1
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MFNETSOURCE_AUTORECONNECTPROGRESS
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x82,
                0xF2,
                0xB1,
                0x3C,
                0x05,
                0x05,
                0x5D,
                0x4C,
                0xAE,
                0x71,
                0x0A,
                0x55,
                0x63,
                0x44,
                0xEF,
                0xA1
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MFNETSOURCE_PROXYLOCATORFACTORY
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x83,
                0xF2,
                0xB1,
                0x3C,
                0x05,
                0x05,
                0x5D,
                0x4C,
                0xAE,
                0x71,
                0x0A,
                0x55,
                0x63,
                0x44,
                0xEF,
                0xA1
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MFNETSOURCE_BROWSERUSERAGENT
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x8B,
                0xF2,
                0xB1,
                0x3C,
                0x05,
                0x05,
                0x5D,
                0x4C,
                0xAE,
                0x71,
                0x0A,
                0x55,
                0x63,
                0x44,
                0xEF,
                0xA1
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MFNETSOURCE_BROWSERWEBPAGE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x8C,
                0xF2,
                0xB1,
                0x3C,
                0x05,
                0x05,
                0x5D,
                0x4C,
                0xAE,
                0x71,
                0x0A,
                0x55,
                0x63,
                0x44,
                0xEF,
                0xA1
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MFNETSOURCE_PLAYERVERSION
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x8D,
                0xF2,
                0xB1,
                0x3C,
                0x05,
                0x05,
                0x5D,
                0x4C,
                0xAE,
                0x71,
                0x0A,
                0x55,
                0x63,
                0x44,
                0xEF,
                0xA1
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MFNETSOURCE_PLAYERID
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x8E,
                0xF2,
                0xB1,
                0x3C,
                0x05,
                0x05,
                0x5D,
                0x4C,
                0xAE,
                0x71,
                0x0A,
                0x55,
                0x63,
                0x44,
                0xEF,
                0xA1
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MFNETSOURCE_HOSTEXE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x8F,
                0xF2,
                0xB1,
                0x3C,
                0x05,
                0x05,
                0x5D,
                0x4C,
                0xAE,
                0x71,
                0x0A,
                0x55,
                0x63,
                0x44,
                0xEF,
                0xA1
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MFNETSOURCE_HOSTVERSION
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x91,
                0xF2,
                0xB1,
                0x3C,
                0x05,
                0x05,
                0x5D,
                0x4C,
                0xAE,
                0x71,
                0x0A,
                0x55,
                0x63,
                0x44,
                0xEF,
                0xA1
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MFNETSOURCE_PLAYERUSERAGENT
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x92,
                0xF2,
                0xB1,
                0x3C,
                0x05,
                0x05,
                0x5D,
                0x4C,
                0xAE,
                0x71,
                0x0A,
                0x55,
                0x63,
                0x44,
                0xEF,
                0xA1
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MFNETSOURCE_CLIENTGUID
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xA6,
                0xC4,
                0xA2,
                0x60,
                0x97,
                0xF1,
                0x14,
                0x4C,
                0xA5,
                0xBF,
                0x88,
                0x83,
                0x0D,
                0x24,
                0x58,
                0xAF
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MFNETSOURCE_LOGURL
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x93,
                0xF2,
                0xB1,
                0x3C,
                0x05,
                0x05,
                0x5D,
                0x4C,
                0xAE,
                0x71,
                0x0A,
                0x55,
                0x63,
                0x44,
                0xEF,
                0xA1
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MFNETSOURCE_ENABLE_UDP
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x94,
                0xF2,
                0xB1,
                0x3C,
                0x05,
                0x05,
                0x5D,
                0x4C,
                0xAE,
                0x71,
                0x0A,
                0x55,
                0x63,
                0x44,
                0xEF,
                0xA1
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MFNETSOURCE_ENABLE_TCP
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x95,
                0xF2,
                0xB1,
                0x3C,
                0x05,
                0x05,
                0x5D,
                0x4C,
                0xAE,
                0x71,
                0x0A,
                0x55,
                0x63,
                0x44,
                0xEF,
                0xA1
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MFNETSOURCE_ENABLE_MSB
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x96,
                0xF2,
                0xB1,
                0x3C,
                0x05,
                0x05,
                0x5D,
                0x4C,
                0xAE,
                0x71,
                0x0A,
                0x55,
                0x63,
                0x44,
                0xEF,
                0xA1
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MFNETSOURCE_ENABLE_RTSP
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x98,
                0xF2,
                0xB1,
                0x3C,
                0x05,
                0x05,
                0x5D,
                0x4C,
                0xAE,
                0x71,
                0x0A,
                0x55,
                0x63,
                0x44,
                0xEF,
                0xA1
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MFNETSOURCE_ENABLE_HTTP
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x99,
                0xF2,
                0xB1,
                0x3C,
                0x05,
                0x05,
                0x5D,
                0x4C,
                0xAE,
                0x71,
                0x0A,
                0x55,
                0x63,
                0x44,
                0xEF,
                0xA1
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MFNETSOURCE_ENABLE_STREAMING
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x9C,
                0xF2,
                0xB1,
                0x3C,
                0x05,
                0x05,
                0x5D,
                0x4C,
                0xAE,
                0x71,
                0x0A,
                0x55,
                0x63,
                0x44,
                0xEF,
                0xA1
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MFNETSOURCE_ENABLE_DOWNLOAD
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x9D,
                0xF2,
                0xB1,
                0x3C,
                0x05,
                0x05,
                0x5D,
                0x4C,
                0xAE,
                0x71,
                0x0A,
                0x55,
                0x63,
                0x44,
                0xEF,
                0xA1
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MFNETSOURCE_ENABLE_PRIVATEMODE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xD8,
                0x79,
                0x47,
                0x82,
                0x8B,
                0xF1,
                0x05,
                0x44,
                0x8C,
                0xF1,
                0x46,
                0x4F,
                0xB5,
                0xAA,
                0x8F,
                0x71
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MFNETSOURCE_UDP_PORT_RANGE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x9A,
                0xF2,
                0xB1,
                0x3C,
                0x05,
                0x05,
                0x5D,
                0x4C,
                0xAE,
                0x71,
                0x0A,
                0x55,
                0x63,
                0x44,
                0xEF,
                0xA1
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MFNETSOURCE_PROXYINFO
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x9B,
                0xF2,
                0xB1,
                0x3C,
                0x05,
                0x05,
                0x5D,
                0x4C,
                0xAE,
                0x71,
                0x0A,
                0x55,
                0x63,
                0x44,
                0xEF,
                0xA1
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MFNETSOURCE_DRMNET_LICENSE_REPRESENTATION
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xBD,
                0xE1,
                0xEA,
                0x47,
                0xFE,
                0xBD,
                0xE2,
                0x42,
                0x82,
                0xF3,
                0x54,
                0xA4,
                0x8C,
                0x17,
                0x96,
                0x2D
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MFNETSOURCE_PROXYSETTINGS
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x87,
                0xF2,
                0xB1,
                0x3C,
                0x05,
                0x05,
                0x5D,
                0x4C,
                0xAE,
                0x71,
                0x0A,
                0x55,
                0x63,
                0x44,
                0xEF,
                0xA1
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MFNETSOURCE_PROXYHOSTNAME
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x84,
                0xF2,
                0xB1,
                0x3C,
                0x05,
                0x05,
                0x5D,
                0x4C,
                0xAE,
                0x71,
                0x0A,
                0x55,
                0x63,
                0x44,
                0xEF,
                0xA1
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MFNETSOURCE_PROXYPORT
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x88,
                0xF2,
                0xB1,
                0x3C,
                0x05,
                0x05,
                0x5D,
                0x4C,
                0xAE,
                0x71,
                0x0A,
                0x55,
                0x63,
                0x44,
                0xEF,
                0xA1
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MFNETSOURCE_PROXYEXCEPTIONLIST
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x85,
                0xF2,
                0xB1,
                0x3C,
                0x05,
                0x05,
                0x5D,
                0x4C,
                0xAE,
                0x71,
                0x0A,
                0x55,
                0x63,
                0x44,
                0xEF,
                0xA1
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MFNETSOURCE_PROXYBYPASSFORLOCAL
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x86,
                0xF2,
                0xB1,
                0x3C,
                0x05,
                0x05,
                0x5D,
                0x4C,
                0xAE,
                0x71,
                0x0A,
                0x55,
                0x63,
                0x44,
                0xEF,
                0xA1
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MFNETSOURCE_PROXYRERUNAUTODETECTION
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x89,
                0xF2,
                0xB1,
                0x3C,
                0x05,
                0x05,
                0x5D,
                0x4C,
                0xAE,
                0x71,
                0x0A,
                0x55,
                0x63,
                0x44,
                0xEF,
                0xA1
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MFNETSOURCE_STREAM_LANGUAGE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x18,
                0x43,
                0xB4,
                0x9A,
                0xCD,
                0xF7,
                0x2D,
                0x4F,
                0x8D,
                0x6D,
                0xFA,
                0x35,
                0xB4,
                0x92,
                0xCE,
                0xCB
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MFNETSOURCE_LOGPARAMS
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xE8,
                0x6A,
                0x93,
                0x64,
                0x18,
                0x94,
                0x3A,
                0x45,
                0x8C,
                0xDA,
                0x3E,
                0x0A,
                0x66,
                0x8B,
                0x35,
                0x3B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MFNETSOURCE_PEERMANAGER
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xDB,
                0x9A,
                0xB2,
                0x48,
                0xBF,
                0xFE,
                0xEE,
                0x45,
                0xA9,
                0xBF,
                0xEF,
                0xB8,
                0x1C,
                0x49,
                0x2E,
                0xFC
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MFNETSOURCE_FRIENDLYNAME
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x57,
                0x77,
                0x2A,
                0x5B,
                0x6B,
                0xBC,
                0x7E,
                0x44,
                0xAA,
                0x06,
                0x0D,
                0xDA,
                0x1C,
                0x64,
                0x6E,
                0x2F
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MFNETSOURCE_CROSS_ORIGIN_SUPPORT
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x7C,
                0x20,
                0x42,
                0x98,
                0x2C,
                0xB0,
                0x71,
                0x42,
                0xA2,
                0xFC,
                0x72,
                0xE4,
                0x93,
                0x08,
                0xE5,
                0xC2
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MFNETSOURCE_HTTP_DOWNLOAD_SESSION_PROVIDER
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x1E,
                0x08,
                0x55,
                0x7D,
                0x7D,
                0x30,
                0x6D,
                0x4D,
                0xA6,
                0x63,
                0xA9,
                0x3B,
                0xE9,
                0x7C,
                0x4B,
                0x5C
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}