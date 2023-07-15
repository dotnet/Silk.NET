// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/oaidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;
public static partial class IID
{
    public static ref readonly Guid IID_ICreateTypeInfo
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x05,
                0x04,
                0x02,
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

    public static ref readonly Guid IID_ICreateTypeInfo2
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x0E,
                0x04,
                0x02,
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

    public static ref readonly Guid IID_ICreateTypeLib
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x06,
                0x04,
                0x02,
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

    public static ref readonly Guid IID_ICreateTypeLib2
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x0F,
                0x04,
                0x02,
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

    public static ref readonly Guid IID_IDispatch
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x00,
                0x04,
                0x02,
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

    public static ref readonly Guid IID_IEnumVARIANT
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x04,
                0x04,
                0x02,
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

    public static ref readonly Guid IID_ITypeComp
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x03,
                0x04,
                0x02,
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

    public static ref readonly Guid IID_ITypeInfo
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x01,
                0x04,
                0x02,
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

    public static ref readonly Guid IID_ITypeInfo2
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x12,
                0x04,
                0x02,
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

    public static ref readonly Guid IID_ITypeLib
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x02,
                0x04,
                0x02,
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

    public static ref readonly Guid IID_ITypeLib2
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x11,
                0x04,
                0x02,
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

    public static ref readonly Guid IID_ITypeChangeEvents
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x10,
                0x04,
                0x02,
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

    public static ref readonly Guid IID_IErrorInfo
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x20,
                0xB1,
                0xF2,
                0x1C,
                0x7D,
                0x54,
                0x1B,
                0x10,
                0x8E,
                0x65,
                0x08,
                0x00,
                0x2B,
                0x2B,
                0xD1,
                0x19
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ICreateErrorInfo
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x40,
                0x33,
                0xF0,
                0x22,
                0x7D,
                0x54,
                0x1B,
                0x10,
                0x8E,
                0x65,
                0x08,
                0x00,
                0x2B,
                0x2B,
                0xD1,
                0x19
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISupportErrorInfo
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x60,
                0x3D,
                0x0B,
                0xDF,
                0x8F,
                0x54,
                0x1B,
                0x10,
                0x8E,
                0x65,
                0x08,
                0x00,
                0x2B,
                0x2B,
                0xD1,
                0x19
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ITypeFactory
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x2E,
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

    public static ref readonly Guid IID_ITypeMarshal
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x2D,
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

    public static ref readonly Guid IID_IRecordInfo
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x2F,
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

    public static ref readonly Guid IID_IErrorLog
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x40,
                0xCA,
                0x27,
                0x31,
                0x6E,
                0x44,
                0xCE,
                0x11,
                0x81,
                0x35,
                0x00,
                0xAA,
                0x00,
                0x4B,
                0xB8,
                0x51
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IPropertyBag
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x00,
                0x2A,
                0x27,
                0x55,
                0xCB,
                0x42,
                0xCE,
                0x11,
                0x81,
                0x35,
                0x00,
                0xAA,
                0x00,
                0x4B,
                0xB8,
                0x51
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ITypeLibRegistrationReader
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x2A,
                0x8A,
                0x6A,
                0xED,
                0x60,
                0xB1,
                0x77,
                0x4E,
                0x8F,
                0x73,
                0xAA,
                0x74,
                0x35,
                0xCD,
                0x5C,
                0x27
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ITypeLibRegistration
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x35,
                0xE7,
                0xA3,
                0x76,
                0xDF,
                0x02,
                0x12,
                0x4A,
                0x98,
                0xEB,
                0x04,
                0x3A,
                0xD3,
                0x60,
                0x0A,
                0xF3
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}