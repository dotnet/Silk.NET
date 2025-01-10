// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/propsys.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class IID
{
    public static ref readonly Guid IID_IInitializeWithFile
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x66,
                0x45,
                0xD1,
                0xB7,
                0x09,
                0x05,
                0xCE,
                0x4C,
                0xA7,
                0x1F,
                0x0A,
                0x55,
                0x42,
                0x33,
                0xBD,
                0x9B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IInitializeWithStream
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x9D,
                0xB4,
                0x24,
                0xB8,
                0xAC,
                0x22,
                0x61,
                0x41,
                0xAC,
                0x8A,
                0x99,
                0x16,
                0xE8,
                0xFA,
                0x3F,
                0x7F,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPropertyStore
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xEB,
                0x8E,
                0x6D,
                0x88,
                0xF2,
                0x8C,
                0x46,
                0x44,
                0x8D,
                0x02,
                0xCD,
                0xBA,
                0x1D,
                0xBD,
                0xCF,
                0x99,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_INamedPropertyStore
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x0F,
                0x4B,
                0x60,
                0x71,
                0xB0,
                0x97,
                0x64,
                0x47,
                0x85,
                0x77,
                0x2F,
                0x13,
                0xE9,
                0x8A,
                0x14,
                0x22,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IObjectWithPropertyKey
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA7,
                0xA0,
                0x0C,
                0xFC,
                0x16,
                0xC3,
                0xD2,
                0x4F,
                0x90,
                0x31,
                0x3E,
                0x62,
                0x8E,
                0x6D,
                0x4F,
                0x23,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPropertyChange
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x8A,
                0xBC,
                0x17,
                0xF9,
                0xBA,
                0x1B,
                0x78,
                0x44,
                0xA2,
                0x45,
                0x1B,
                0xDE,
                0x03,
                0xEB,
                0x94,
                0x31,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPropertyChangeArray
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xAD,
                0x5C,
                0x0F,
                0x38,
                0x5E,
                0x1B,
                0xF2,
                0x42,
                0x80,
                0x5D,
                0x63,
                0x7F,
                0xD3,
                0x92,
                0xD3,
                0x1E,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPropertyStoreCapabilities
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x66,
                0xD5,
                0xE2,
                0xC8,
                0x6E,
                0x18,
                0x49,
                0x4D,
                0xBF,
                0x41,
                0x69,
                0x09,
                0xEA,
                0xD5,
                0x6A,
                0xCC,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPropertyStoreCache
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x6D,
                0x05,
                0x17,
                0x30,
                0x91,
                0x9A,
                0x90,
                0x4E,
                0x93,
                0x7D,
                0x74,
                0x6C,
                0x72,
                0xAB,
                0xBF,
                0x4F,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPropertyEnumType
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF9,
                0xFB,
                0xE1,
                0x11,
                0x56,
                0x2D,
                0x6B,
                0x4A,
                0x8D,
                0xB3,
                0x7C,
                0xD1,
                0x93,
                0xA4,
                0x71,
                0xF2,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPropertyEnumType2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x1C,
                0x05,
                0x6E,
                0x9B,
                0xDD,
                0x5D,
                0x21,
                0x43,
                0x90,
                0x70,
                0xFE,
                0x2A,
                0xCB,
                0x55,
                0xE7,
                0x94,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPropertyEnumTypeList
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF4,
                0x00,
                0x94,
                0xA9,
                0x84,
                0x3D,
                0x57,
                0x45,
                0x94,
                0xBA,
                0x12,
                0x42,
                0xFB,
                0x2C,
                0xC9,
                0xA6,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPropertyDescription
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x58,
                0xD5,
                0x79,
                0x6F,
                0x96,
                0x3E,
                0x49,
                0x45,
                0xA1,
                0xD1,
                0x7D,
                0x75,
                0xD2,
                0x28,
                0x88,
                0x14,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPropertyDescription2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xED,
                0xED,
                0xD2,
                0x57,
                0x62,
                0x50,
                0x0E,
                0x40,
                0xB1,
                0x07,
                0x5D,
                0xAE,
                0x79,
                0xFE,
                0x57,
                0xA6,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPropertyDescriptionAliasInfo
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xFC,
                0x04,
                0x71,
                0xF6,
                0xF9,
                0x2A,
                0xFD,
                0x46,
                0xB3,
                0x2D,
                0x24,
                0x3C,
                0x14,
                0x04,
                0xF3,
                0xD1,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPropertyDescriptionSearchInfo
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xBD,
                0x91,
                0x8F,
                0x07,
                0xA2,
                0x29,
                0x0F,
                0x44,
                0x92,
                0x4E,
                0x46,
                0xA2,
                0x91,
                0x52,
                0x45,
                0x20,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPropertyDescriptionRelatedPropertyInfo
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF4,
                0x93,
                0x73,
                0x50,
                0x3D,
                0x2A,
                0x60,
                0x4A,
                0xB5,
                0x9E,
                0xD9,
                0xC7,
                0x57,
                0x16,
                0xC2,
                0xDD,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPropertySystem
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x8A,
                0x4E,
                0x72,
                0xCA,
                0xE6,
                0xC3,
                0x2B,
                0x44,
                0x88,
                0xA4,
                0x6F,
                0xB0,
                0xDB,
                0x80,
                0x35,
                0xA3,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPropertyDescriptionList
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD0,
                0xC1,
                0x9F,
                0x1F,
                0x9B,
                0xC3,
                0x26,
                0x4B,
                0x81,
                0x7F,
                0x01,
                0x19,
                0x67,
                0xD3,
                0x44,
                0x0E,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPropertyStoreFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x6D,
                0x0B,
                0x11,
                0xBC,
                0xE8,
                0x57,
                0x48,
                0x41,
                0xA9,
                0xC6,
                0x91,
                0x01,
                0x5A,
                0xB2,
                0xF3,
                0xA5,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDelayedPropertyStoreFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x7F,
                0x57,
                0xD4,
                0x40,
                0x37,
                0xE2,
                0xDB,
                0x4B,
                0xBD,
                0x69,
                0x58,
                0xF0,
                0x89,
                0x43,
                0x1B,
                0x6A,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPersistSerializedPropStorage
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x57,
                0xAD,
                0x18,
                0xE3,
                0xA0,
                0x0A,
                0x0F,
                0x45,
                0xAC,
                0xA5,
                0x6F,
                0xAB,
                0x71,
                0x03,
                0xD9,
                0x17,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPersistSerializedPropStorage2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x68,
                0xFA,
                0xEF,
                0x77,
                0x98,
                0x4F,
                0x66,
                0x43,
                0xBA,
                0x72,
                0x57,
                0x3B,
                0x3D,
                0x88,
                0x05,
                0x71,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPropertySystemChangeNotify
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD9,
                0x5F,
                0x95,
                0xFA,
                0xBE,
                0x38,
                0x79,
                0x48,
                0xA6,
                0xCE,
                0x82,
                0x4C,
                0xF5,
                0x2D,
                0x60,
                0x9F,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICreateObject
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x52,
                0x19,
                0x12,
                0x75,
                0xD0,
                0xE0,
                0xE5,
                0x43,
                0x93,
                0x80,
                0x1D,
                0x80,
                0x48,
                0x3A,
                0xCF,
                0x72,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
