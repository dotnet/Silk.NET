// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/objidlbase.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;
public static partial class IID
{
    public static ref readonly Guid IID_IMarshal
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x03,
                0x00,
                0x00,
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
                0x46
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_INoMarshal
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x1B,
                0x69,
                0xC8,
                0xEC,
                0xDB,
                0xC1,
                0xC0,
                0x4D,
                0x85,
                0x5E,
                0x65,
                0xF6,
                0xC5,
                0x51,
                0xAF,
                0x49
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IAgileObject
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x94,
                0x2B,
                0xEA,
                0x94,
                0xCC,
                0xE9,
                0xE0,
                0x49,
                0xC0,
                0xFF,
                0xEE,
                0x64,
                0xCA,
                0x8F,
                0x5B,
                0x90
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IActivationFilter
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x17,
                0x00,
                0x00,
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
                0x46
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMarshal2
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xCF,
                0x01,
                0x00,
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
                0x46
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMalloc
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x02,
                0x00,
                0x00,
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
                0x46
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IStdMarshalInfo
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x18,
                0x00,
                0x00,
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
                0x46
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IExternalConnection
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x19,
                0x00,
                0x00,
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
                0x46
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMultiQI
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x20,
                0x00,
                0x00,
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
                0x46
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_AsyncIMultiQI
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x20,
                0x00,
                0x0E,
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
                0x46
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IInternalUnknown
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x21,
                0x00,
                0x00,
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
                0x46
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IEnumUnknown
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x00,
                0x01,
                0x00,
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
                0x46
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IEnumString
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x01,
                0x01,
                0x00,
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
                0x46
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISequentialStream
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x30,
                0x3A,
                0x73,
                0x0C,
                0x1C,
                0x2A,
                0xCE,
                0x11,
                0xAD,
                0xE5,
                0x00,
                0xAA,
                0x00,
                0x44,
                0x77,
                0x3D
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IStream
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x0C,
                0x00,
                0x00,
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
                0x46
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IRpcChannelBuffer
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x60,
                0x6B,
                0xF5,
                0xD5,
                0x3B,
                0x59,
                0x1A,
                0x10,
                0xB5,
                0x69,
                0x08,
                0x00,
                0x2B,
                0x2D,
                0xBF,
                0x7A
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IRpcChannelBuffer2
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xD0,
                0x31,
                0x4F,
                0x59,
                0x19,
                0x7F,
                0xD0,
                0x11,
                0xB1,
                0x94,
                0x00,
                0xA0,
                0xC9,
                0x0D,
                0xC8,
                0xBF
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IAsyncRpcChannelBuffer
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xB6,
                0x9F,
                0x02,
                0xA5,
                0x34,
                0x3C,
                0xD1,
                0x11,
                0x9C,
                0x99,
                0x00,
                0xC0,
                0x4F,
                0xB9,
                0x98,
                0xAA
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IRpcChannelBuffer3
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x00,
                0x56,
                0xB1,
                0x25,
                0x15,
                0x01,
                0xD0,
                0x11,
                0xBF,
                0x0D,
                0x00,
                0xAA,
                0x00,
                0xB8,
                0xDF,
                0xD2
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IRpcSyntaxNegotiate
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x19,
                0x85,
                0xA0,
                0x58,
                0xC8,
                0x24,
                0x35,
                0x49,
                0xB4,
                0x82,
                0x3F,
                0xD8,
                0x23,
                0x33,
                0x3A,
                0x4F
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IRpcProxyBuffer
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x34,
                0x6A,
                0xF5,
                0xD5,
                0x3B,
                0x59,
                0x1A,
                0x10,
                0xB5,
                0x69,
                0x08,
                0x00,
                0x2B,
                0x2D,
                0xBF,
                0x7A
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IRpcStubBuffer
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xFC,
                0x6A,
                0xF5,
                0xD5,
                0x3B,
                0x59,
                0x1A,
                0x10,
                0xB5,
                0x69,
                0x08,
                0x00,
                0x2B,
                0x2D,
                0xBF,
                0x7A
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IPSFactoryBuffer
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xD0,
                0x69,
                0xF5,
                0xD5,
                0x3B,
                0x59,
                0x1A,
                0x10,
                0xB5,
                0x69,
                0x08,
                0x00,
                0x2B,
                0x2D,
                0xBF,
                0x7A
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IChannelHook
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xA0,
                0xC4,
                0x08,
                0x10,
                0x13,
                0x76,
                0xCF,
                0x11,
                0x9A,
                0xF1,
                0x00,
                0x20,
                0xAF,
                0x6E,
                0x72,
                0xF4
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IClientSecurity
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x3D,
                0x01,
                0x00,
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
                0x46
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IServerSecurity
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x3E,
                0x01,
                0x00,
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
                0x46
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IRpcOptions
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x44,
                0x01,
                0x00,
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
                0x46
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IGlobalOptions
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x5B,
                0x01,
                0x00,
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
                0x46
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISurrogate
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x22,
                0x00,
                0x00,
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
                0x46
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IGlobalInterfaceTable
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x46,
                0x01,
                0x00,
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
                0x46
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISynchronize
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x30,
                0x00,
                0x00,
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
                0x46
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISynchronizeHandle
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x31,
                0x00,
                0x00,
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
                0x46
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISynchronizeEvent
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x32,
                0x00,
                0x00,
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
                0x46
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISynchronizeContainer
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x33,
                0x00,
                0x00,
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
                0x46
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISynchronizeMutex
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x25,
                0x00,
                0x00,
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
                0x46
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ICancelMethodCalls
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x29,
                0x00,
                0x00,
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
                0x46
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IAsyncManager
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x2A,
                0x00,
                0x00,
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
                0x46
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ICallFactory
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x30,
                0x3A,
                0x73,
                0x1C,
                0x1C,
                0x2A,
                0xCE,
                0x11,
                0xAD,
                0xE5,
                0x00,
                0xAA,
                0x00,
                0x44,
                0x77,
                0x3D
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IRpcHelper
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x49,
                0x01,
                0x00,
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
                0x46
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IReleaseMarshalBuffers
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xE8,
                0xB9,
                0x0C,
                0xEB,
                0x96,
                0x79,
                0xD2,
                0x11,
                0x87,
                0x2E,
                0x00,
                0x00,
                0xF8,
                0x08,
                0x08,
                0x59
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IWaitMultiple
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x2B,
                0x00,
                0x00,
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
                0x46
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IAddrTrackingControl
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x47,
                0x01,
                0x00,
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
                0x46
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IAddrExclusionControl
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x48,
                0x01,
                0x00,
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
                0x46
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IPipeByte
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xCA,
                0x3A,
                0x2F,
                0xDB,
                0x86,
                0x2F,
                0xD1,
                0x11,
                0x8E,
                0x04,
                0x00,
                0xC0,
                0x4F,
                0xB9,
                0x98,
                0x9A
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_AsyncIPipeByte
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xCB,
                0x3A,
                0x2F,
                0xDB,
                0x86,
                0x2F,
                0xD1,
                0x11,
                0x8E,
                0x04,
                0x00,
                0xC0,
                0x4F,
                0xB9,
                0x98,
                0x9A
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IPipeLong
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xCC,
                0x3A,
                0x2F,
                0xDB,
                0x86,
                0x2F,
                0xD1,
                0x11,
                0x8E,
                0x04,
                0x00,
                0xC0,
                0x4F,
                0xB9,
                0x98,
                0x9A
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_AsyncIPipeLong
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xCD,
                0x3A,
                0x2F,
                0xDB,
                0x86,
                0x2F,
                0xD1,
                0x11,
                0x8E,
                0x04,
                0x00,
                0xC0,
                0x4F,
                0xB9,
                0x98,
                0x9A
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IPipeDouble
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xCE,
                0x3A,
                0x2F,
                0xDB,
                0x86,
                0x2F,
                0xD1,
                0x11,
                0x8E,
                0x04,
                0x00,
                0xC0,
                0x4F,
                0xB9,
                0x98,
                0x9A
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_AsyncIPipeDouble
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xCF,
                0x3A,
                0x2F,
                0xDB,
                0x86,
                0x2F,
                0xD1,
                0x11,
                0x8E,
                0x04,
                0x00,
                0xC0,
                0x4F,
                0xB9,
                0x98,
                0x9A
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IComThreadingInfo
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xCE,
                0x01,
                0x00,
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
                0x46
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IProcessInitControl
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x55,
                0x0D,
                0x38,
                0x72,
                0x2B,
                0x8D,
                0xA3,
                0x43,
                0x85,
                0x13,
                0x2B,
                0x6E,
                0xF3,
                0x14,
                0x34,
                0xE9
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IFastRundown
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x40,
                0x00,
                0x00,
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
                0x46
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMarshalingStream
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xE6,
                0xF5,
                0xF2,
                0xD8,
                0x02,
                0x61,
                0x63,
                0x48,
                0x9F,
                0x26,
                0x38,
                0x9A,
                0x46,
                0x76,
                0xEF,
                0xDE
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IAgileReference
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x43,
                0x6A,
                0x3F,
                0xC0,
                0xA4,
                0x65,
                0x18,
                0x98,
                0x98,
                0x7E,
                0xE0,
                0xB8,
                0x10,
                0xD2,
                0xA6,
                0xF2
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMachineGlobalObjectTable
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xAC,
                0x09,
                0xD7,
                0x26,
                0x0B,
                0xF7,
                0x21,
                0x44,
                0xA9,
                0x6F,
                0xD2,
                0x87,
                0x8F,
                0xAF,
                0xB0,
                0x0D
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISupportAllowLowerTrustActivation
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xF2,
                0x6E,
                0x95,
                0xE9,
                0x28,
                0x38,
                0x4B,
                0x4B,
                0x8F,
                0xA9,
                0x7D,
                0xB6,
                0x1D,
                0xEE,
                0x49,
                0x54
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}