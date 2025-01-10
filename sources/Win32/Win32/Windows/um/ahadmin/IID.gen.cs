// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ahadmin.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class IID
{
    public static ref readonly Guid IID_IAppHostMethodExtension
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC9,
                0x4A,
                0x18,
                0x70,
                0x73,
                0x76,
                0x70,
                0x47,
                0x96,
                0xB1,
                0x44,
                0x5C,
                0xE0,
                0x35,
                0xCF,
                0x70,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAppHostPropertyExtension
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF3,
                0x20,
                0xE2,
                0x88,
                0xE8,
                0x33,
                0x34,
                0x45,
                0xAF,
                0xAC,
                0xB4,
                0xA9,
                0x8E,
                0xCC,
                0xF9,
                0xAE,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAppHostElementExtension
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x7D,
                0xB3,
                0x8E,
                0x51,
                0xF4,
                0x1F,
                0xDD,
                0x42,
                0x86,
                0xC3,
                0x31,
                0x40,
                0xBC,
                0x35,
                0xB8,
                0x23,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAppHostMappingExtension
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA0,
                0x3E,
                0xA8,
                0x31,
                0xE4,
                0xC0,
                0x2C,
                0x4A,
                0x8A,
                0x01,
                0x35,
                0x3C,
                0xC2,
                0xA4,
                0xC6,
                0x0A,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAppHostChildElementCollection
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x5F,
                0x0F,
                0xA9,
                0x08,
                0x02,
                0x07,
                0xD6,
                0x48,
                0xB4,
                0x5F,
                0x02,
                0xA9,
                0x88,
                0x5A,
                0x97,
                0x68,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAppHostPropertyCollection
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x5E,
                0x77,
                0x91,
                0x01,
                0xFF,
                0xBC,
                0x5A,
                0x44,
                0xB4,
                0xF4,
                0x3B,
                0xDD,
                0xA5,
                0x4E,
                0x28,
                0x16,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAppHostConfigLocationCollection
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF7,
                0x32,
                0x2A,
                0x83,
                0xEA,
                0xB3,
                0x8C,
                0x4B,
                0xB2,
                0x60,
                0x9A,
                0x29,
                0x23,
                0x00,
                0x11,
                0x84,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAppHostMethodCollection
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x8F,
                0xCD,
                0xC7,
                0xD6,
                0x8D,
                0xBB,
                0x96,
                0x4F,
                0xB5,
                0x91,
                0xD3,
                0xA5,
                0xF1,
                0x32,
                0x02,
                0x69,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAppHostElementSchemaCollection
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xDA,
                0xCD,
                0x44,
                0x03,
                0x1E,
                0x15,
                0xBF,
                0x4C,
                0x82,
                0xDA,
                0x66,
                0xAE,
                0x61,
                0xE9,
                0x77,
                0x54,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAppHostPropertySchemaCollection
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x68,
                0x2C,
                0xED,
                0x8B,
                0xFB,
                0xA5,
                0x28,
                0x4B,
                0x85,
                0x81,
                0xA0,
                0xDC,
                0x52,
                0x67,
                0x41,
                0x9F,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAppHostConstantValueCollection
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE6,
                0x68,
                0x5A,
                0x5B,
                0x9F,
                0x8B,
                0xE1,
                0x45,
                0x81,
                0x99,
                0xA9,
                0x5F,
                0xFC,
                0xCD,
                0xFF,
                0xFF,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAppHostConstantValue
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF8,
                0xCA,
                0x16,
                0x07,
                0x05,
                0x7D,
                0x46,
                0x4A,
                0x80,
                0x99,
                0x77,
                0x59,
                0x4B,
                0xE9,
                0x13,
                0x94,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAppHostPropertySchema
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xDB,
                0x86,
                0x03,
                0x45,
                0x09,
                0x74,
                0x67,
                0x46,
                0x93,
                0x5E,
                0x38,
                0x4D,
                0xBB,
                0xEE,
                0x2A,
                0x9E,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAppHostCollectionSchema
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB1,
                0x5D,
                0x09,
                0xDE,
                0x68,
                0x53,
                0x11,
                0x4D,
                0x81,
                0xF6,
                0xEF,
                0xEF,
                0x61,
                0x9B,
                0x7B,
                0xCF,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAppHostElementSchema
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x85,
                0xD8,
                0x13,
                0xEF,
                0x2C,
                0x64,
                0x09,
                0x47,
                0x99,
                0xEC,
                0xB8,
                0x95,
                0x61,
                0xC6,
                0xBC,
                0x69,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAppHostMethodSchema
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xFB,
                0x15,
                0x99,
                0x2D,
                0x42,
                0x9D,
                0x28,
                0x43,
                0xB7,
                0x82,
                0x1B,
                0x46,
                0x81,
                0x9F,
                0xAB,
                0x9E,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAppHostMethodInstance
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x42,
                0x3C,
                0x0F,
                0xB8,
                0xE0,
                0x60,
                0xE0,
                0x4A,
                0x90,
                0x07,
                0xF5,
                0x28,
                0x52,
                0xD3,
                0xDB,
                0xED,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAppHostMethod
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x1C,
                0xCA,
                0x83,
                0x78,
                0x12,
                0x11,
                0x47,
                0x44,
                0x84,
                0xC3,
                0x52,
                0xFB,
                0xEB,
                0x38,
                0x06,
                0x9D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAppHostConfigException
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF3,
                0x1D,
                0xFA,
                0x4D,
                0x00,
                0x89,
                0xC7,
                0x4B,
                0xBB,
                0xB5,
                0xD1,
                0xA4,
                0x58,
                0xC5,
                0x24,
                0x10,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAppHostPropertyException
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x95,
                0x48,
                0xFE,
                0xEA,
                0x29,
                0xA9,
                0xEA,
                0x41,
                0xB1,
                0x4D,
                0x61,
                0x3E,
                0x23,
                0xF6,
                0x2B,
                0x71,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAppHostElementCollection
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xFF,
                0x0B,
                0x55,
                0xC8,
                0x81,
                0x52,
                0x1E,
                0x4B,
                0xAC,
                0x34,
                0x99,
                0xB6,
                0xFA,
                0x38,
                0x46,
                0x4D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAppHostElement
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xCC,
                0x8C,
                0xFF,
                0x64,
                0x87,
                0xB2,
                0xAE,
                0x4D,
                0xB0,
                0x8A,
                0xA7,
                0x2C,
                0xBF,
                0x45,
                0xF4,
                0x53,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAppHostProperty
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA1,
                0xF7,
                0x35,
                0xED,
                0x24,
                0x50,
                0x7B,
                0x4E,
                0xA4,
                0x4D,
                0x07,
                0xDD,
                0xAF,
                0x4B,
                0x52,
                0x4D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAppHostConfigLocation
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x78,
                0xF1,
                0x0A,
                0x37,
                0x58,
                0x77,
                0xAD,
                0x4D,
                0x81,
                0x46,
                0x73,
                0x91,
                0xF6,
                0xE1,
                0x85,
                0x85,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAppHostSectionDefinition
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x95,
                0x47,
                0xC0,
                0xC5,
                0x1C,
                0x32,
                0x14,
                0x40,
                0x8F,
                0xD6,
                0xD4,
                0x46,
                0x58,
                0x79,
                0x93,
                0x93,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAppHostSectionDefinitionCollection
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xEE,
                0x81,
                0xD3,
                0xB7,
                0x60,
                0x88,
                0xA1,
                0x47,
                0x8A,
                0xF4,
                0x1F,
                0x33,
                0xB2,
                0xB1,
                0xF3,
                0x25,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAppHostSectionGroup
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x58,
                0xA1,
                0xD8,
                0x0D,
                0xE6,
                0xEB,
                0x08,
                0x40,
                0xA1,
                0xD9,
                0xB7,
                0xEC,
                0xC8,
                0xF1,
                0x10,
                0x4B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAppHostConfigFile
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xFB,
                0xE6,
                0xA4,
                0xAD,
                0x25,
                0xE0,
                0x1E,
                0x40,
                0xA5,
                0xD0,
                0xC3,
                0x13,
                0x4A,
                0x28,
                0x1F,
                0x07,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAppHostPathMapper
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x75,
                0x75,
                0x92,
                0xE7,
                0xC3,
                0x5C,
                0x3B,
                0x40,
                0x82,
                0x2E,
                0x32,
                0x8A,
                0x6B,
                0x90,
                0x4B,
                0xEE,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAppHostPathMapper2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x01,
                0xE9,
                0x80,
                0x0F,
                0x4C,
                0x8F,
                0x9A,
                0x44,
                0xBF,
                0x90,
                0x13,
                0xD5,
                0xD0,
                0x82,
                0xF1,
                0x87,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAppHostChangeHandler
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x52,
                0x93,
                0x82,
                0x09,
                0xC2,
                0x87,
                0x8D,
                0x41,
                0x8D,
                0x79,
                0x41,
                0x33,
                0x96,
                0x9A,
                0x48,
                0x9D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAppHostAdminManager
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x78,
                0x79,
                0xE7,
                0x9B,
                0xED,
                0x73,
                0x9A,
                0x4A,
                0x87,
                0xFD,
                0x13,
                0xF0,
                0x9F,
                0xEC,
                0x1B,
                0x13,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAppHostWritableAdminManager
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF6,
                0x60,
                0x76,
                0xFA,
                0x3F,
                0x7B,
                0x37,
                0x42,
                0xA8,
                0xBF,
                0xED,
                0x0A,
                0xD0,
                0xDC,
                0xBB,
                0xD9,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAppHostConfigManager
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x0F,
                0x76,
                0x6D,
                0x8F,
                0xCB,
                0xF0,
                0x69,
                0x4D,
                0xB5,
                0xF6,
                0x84,
                0x8B,
                0x33,
                0xE9,
                0xBD,
                0xC6,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_AppHostAdminManager
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF7,
                0xB8,
                0x8F,
                0x22,
                0x53,
                0xFB,
                0xD5,
                0x4F,
                0x8C,
                0x7B,
                0xFF,
                0x59,
                0xDE,
                0x60,
                0x6C,
                0x5B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_AppHostWritableAdminManager
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x3B,
                0x13,
                0x72,
                0x2B,
                0x5B,
                0x3F,
                0x02,
                0x46,
                0x89,
                0x52,
                0x80,
                0x35,
                0x46,
                0xCE,
                0x33,
                0x44,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
