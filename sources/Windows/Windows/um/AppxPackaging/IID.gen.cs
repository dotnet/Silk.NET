// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;
public static partial class IID
{
    public static ref readonly Guid IID_IAppxFactory
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x09,
                0x49,
                0xB9,
                0xBE,
                0x51,
                0xE4,
                0x8B,
                0x43,
                0xB5,
                0xA7,
                0xD7,
                0x9E,
                0x76,
                0x7B,
                0x75,
                0xD8
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IAppxFactory2
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xF2,
                0x6D,
                0x34,
                0xF1,
                0x82,
                0xC2,
                0x22,
                0x4E,
                0xB9,
                0x18,
                0x74,
                0x3A,
                0x92,
                0x9A,
                0x8D,
                0x55
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IAppxFactory3
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x05,
                0x2C,
                0x6B,
                0x77,
                0x1D,
                0xE2,
                0x24,
                0x4E,
                0xBA,
                0x1A,
                0xCD,
                0x52,
                0x9A,
                0x8B,
                0xFD,
                0xBB
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IAppxPackageReader
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x50,
                0x96,
                0xC4,
                0xB5,
                0xBC,
                0x99,
                0x1C,
                0x48,
                0x9A,
                0x34,
                0x3D,
                0x53,
                0xA4,
                0x10,
                0x67,
                0x08
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IAppxPackageWriter
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x3B,
                0xE3,
                0x99,
                0x90,
                0x6F,
                0x24,
                0xE4,
                0x41,
                0x88,
                0x1A,
                0x00,
                0x8E,
                0xB6,
                0x13,
                0xF8,
                0x58
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IAppxPackageWriter2
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xFD,
                0xC4,
                0xF5,
                0x2C,
                0x4C,
                0xE5,
                0xA5,
                0x4E,
                0xBA,
                0x4E,
                0xF8,
                0xC4,
                0xB1,
                0x05,
                0xA8,
                0xC8
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IAppxPackageWriter3
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xD3,
                0xAC,
                0x3A,
                0xA8,
                0xC0,
                0x41,
                0x01,
                0x45,
                0xB8,
                0xA3,
                0x74,
                0x16,
                0x4F,
                0x50,
                0xB2,
                0xFD
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IAppxFile
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x7B,
                0x82,
                0xDF,
                0x91,
                0xFD,
                0x94,
                0x8F,
                0x46,
                0x82,
                0x7B,
                0x57,
                0xF4,
                0x1B,
                0x2F,
                0x6F,
                0x2E
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IAppxFilesEnumerator
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xAF,
                0xEE,
                0x07,
                0xF0,
                0x31,
                0x98,
                0x1C,
                0x41,
                0x98,
                0x47,
                0x91,
                0x7C,
                0xDC,
                0x62,
                0xD1,
                0xFE
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IAppxBlockMapReader
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x91,
                0xC9,
                0xFE,
                0x5E,
                0xA3,
                0xBC,
                0xD1,
                0x42,
                0x9E,
                0xC2,
                0xE9,
                0x2D,
                0x60,
                0x9E,
                0xC2,
                0x2A
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IAppxBlockMapFile
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xAC,
                0x72,
                0x76,
                0x27,
                0x63,
                0x4F,
                0xC1,
                0x42,
                0x8A,
                0xBC,
                0xBE,
                0xAE,
                0x36,
                0x00,
                0xEB,
                0x59
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IAppxBlockMapFilesEnumerator
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xA2,
                0x56,
                0xB8,
                0x02,
                0x62,
                0x42,
                0x70,
                0x40,
                0xBA,
                0xCB,
                0x1A,
                0x8C,
                0xBB,
                0xC4,
                0x23,
                0x05
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IAppxBlockMapBlock
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x30,
                0x39,
                0xCF,
                0x75,
                0x44,
                0x32,
                0xE0,
                0x4F,
                0xA8,
                0xC8,
                0xE0,
                0xBC,
                0xB2,
                0x70,
                0xB8,
                0x89
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IAppxBlockMapBlocksEnumerator
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x5B,
                0x9B,
                0x42,
                0x6B,
                0xEF,
                0x36,
                0x9E,
                0x47,
                0xB9,
                0xEB,
                0x0C,
                0x14,
                0x82,
                0xB4,
                0x9E,
                0x16
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IAppxManifestReader
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x48,
                0xD1,
                0x1B,
                0x4E,
                0xA0,
                0x55,
                0x80,
                0x44,
                0xA3,
                0xD1,
                0x15,
                0x54,
                0x47,
                0x10,
                0x63,
                0x7C
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IAppxManifestReader2
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xBC,
                0x67,
                0x6F,
                0xD0,
                0x1D,
                0xB3,
                0xBA,
                0x4E,
                0xA8,
                0xAF,
                0x63,
                0x8E,
                0x73,
                0xE7,
                0x7B,
                0x4D
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IAppxManifestReader3
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xAB,
                0x25,
                0x38,
                0xC4,
                0xB7,
                0x69,
                0x0A,
                0x40,
                0x97,
                0x09,
                0xCC,
                0x37,
                0xF5,
                0xA7,
                0x2D,
                0x24
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IAppxManifestReader4
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x7C,
                0xBB,
                0x79,
                0x45,
                0x1D,
                0x74,
                0x61,
                0x41,
                0xB5,
                0xA1,
                0x47,
                0xBD,
                0x3B,
                0x78,
                0xAD,
                0x9B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IAppxManifestReader5
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x32,
                0xE1,
                0x7A,
                0x8D,
                0x90,
                0xA6,
                0x00,
                0x4C,
                0xB7,
                0x5A,
                0x6A,
                0xAE,
                0x1F,
                0xEA,
                0xAC,
                0x80
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IAppxManifestReader6
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xA4,
                0xAC,
                0xDE,
                0x34,
                0xC0,
                0xD3,
                0x3E,
                0x4E,
                0xB3,
                0x12,
                0xE4,
                0x26,
                0x25,
                0xE3,
                0x80,
                0x7E
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IAppxManifestReader7
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x27,
                0x6F,
                0xFE,
                0x8E,
                0xE0,
                0x0C,
                0x88,
                0x49,
                0xB3,
                0x2D,
                0x73,
                0x8E,
                0xB6,
                0x3D,
                0xB3,
                0xB7
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IAppxManifestDriverDependenciesEnumerator
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xB2,
                0x9D,
                0x03,
                0xFE,
                0x7F,
                0x46,
                0x55,
                0x47,
                0x84,
                0x04,
                0x8F,
                0x5E,
                0xB6,
                0x86,
                0x5B,
                0x33
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IAppxManifestDriverDependency
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x94,
                0xCB,
                0x10,
                0x12,
                0x92,
                0x5A,
                0x02,
                0x46,
                0xBE,
                0x24,
                0x79,
                0xF3,
                0x18,
                0xAF,
                0x4A,
                0xF9
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IAppxManifestDriverConstraintsEnumerator
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xD1,
                0xB2,
                0x02,
                0xD4,
                0x00,
                0xF6,
                0xE0,
                0x49,
                0x95,
                0xE6,
                0x97,
                0x5D,
                0x8D,
                0xA1,
                0x3D,
                0x89
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IAppxManifestDriverConstraint
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xE4,
                0xBE,
                0x31,
                0xC0,
                0xCC,
                0xBB,
                0xEA,
                0x48,
                0xA2,
                0x37,
                0xC3,
                0x40,
                0x45,
                0xC8,
                0x0A,
                0x07
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IAppxManifestOSPackageDependenciesEnumerator
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xC3,
                0x2F,
                0x4E,
                0xB8,
                0xEC,
                0xF8,
                0xC1,
                0x4B,
                0x8A,
                0xE2,
                0x15,
                0x63,
                0x46,
                0xF5,
                0xFF,
                0xEA
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IAppxManifestOSPackageDependency
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xEE,
                0x95,
                0x49,
                0x15,
                0xA6,
                0x54,
                0x14,
                0x4F,
                0xAC,
                0x97,
                0xD8,
                0xCF,
                0x05,
                0x19,
                0x64,
                0x4B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IAppxManifestHostRuntimeDependenciesEnumerator
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x46,
                0xA6,
                0x27,
                0x64,
                0x49,
                0x7F,
                0x3E,
                0x43,
                0xB1,
                0xA6,
                0x0D,
                0xA3,
                0x09,
                0xF6,
                0x88,
                0x5A
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IAppxManifestHostRuntimeDependency
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x34,
                0xD2,
                0x55,
                0x34,
                0x14,
                0x84,
                0x0D,
                0x41,
                0x95,
                0xC7,
                0x7B,
                0x35,
                0x25,
                0x5B,
                0x83,
                0x91
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IAppxManifestHostRuntimeDependency2
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xA8,
                0x23,
                0x6F,
                0xC2,
                0x10,
                0xEE,
                0xD6,
                0x4A,
                0xB8,
                0x98,
                0x2B,
                0x4D,
                0x7A,
                0xEB,
                0xFE,
                0x6A
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IAppxManifestOptionalPackageInfo
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x7D,
                0x84,
                0x34,
                0x26,
                0x5D,
                0x5B,
                0xE5,
                0x4F,
                0xA2,
                0x43,
                0x00,
                0x2F,
                0xF9,
                0x5E,
                0xDC,
                0x7E
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IAppxManifestMainPackageDependenciesEnumerator
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x00,
                0x4F,
                0x9C,
                0xA9,
                0xD2,
                0x51,
                0x0F,
                0x4F,
                0xBA,
                0x46,
                0x7E,
                0xD5,
                0x25,
                0x5E,
                0xBD,
                0xFF
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IAppxManifestMainPackageDependency
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x1C,
                0x61,
                0xD0,
                0x05,
                0x29,
                0xBC,
                0xD5,
                0x46,
                0x97,
                0xE2,
                0x84,
                0xB9,
                0xC7,
                0x9B,
                0xD8,
                0xAE
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IAppxManifestPackageId
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xD7,
                0xE2,
                0x3C,
                0x28,
                0x53,
                0x71,
                0x91,
                0x4A,
                0x96,
                0x49,
                0x7A,
                0x0F,
                0x72,
                0x40,
                0x94,
                0x5F
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IAppxManifestPackageId2
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x9D,
                0x99,
                0x56,
                0x22,
                0x17,
                0xD6,
                0xF1,
                0x42,
                0x88,
                0x0E,
                0x0B,
                0xA4,
                0x54,
                0x23,
                0x19,
                0xD5
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IAppxManifestProperties
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x4D,
                0xF6,
                0xFA,
                0x03,
                0x6F,
                0xF2,
                0x2C,
                0x4B,
                0xAA,
                0xF7,
                0x8F,
                0xE7,
                0x78,
                0x9B,
                0x8B,
                0xCA
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IAppxManifestTargetDeviceFamiliesEnumerator
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x36,
                0x7F,
                0x53,
                0x36,
                0xA4,
                0x27,
                0x88,
                0x47,
                0x88,
                0xC0,
                0x73,
                0x38,
                0x19,
                0x57,
                0x50,
                0x17
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IAppxManifestTargetDeviceFamily
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x9B,
                0xB0,
                0x91,
                0x90,
                0xD5,
                0xC8,
                0x31,
                0x4F,
                0x86,
                0x87,
                0xA3,
                0x38,
                0x25,
                0x9F,
                0xAE,
                0xFB
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IAppxManifestPackageDependenciesEnumerator
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xF9,
                0xBC,
                0x3B,
                0xB4,
                0xA6,
                0x65,
                0xDD,
                0x42,
                0xBA,
                0xC0,
                0x8C,
                0x67,
                0x41,
                0xE7,
                0xF5,
                0xA4
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IAppxManifestPackageDependency
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x59,
                0x6B,
                0x94,
                0xE4,
                0x3E,
                0x73,
                0xF0,
                0x43,
                0xA7,
                0x24,
                0x3B,
                0xDE,
                0x4C,
                0x12,
                0x85,
                0xA0
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IAppxManifestPackageDependency2
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x13,
                0xB7,
                0xA0,
                0xDD,
                0xFF,
                0xF3,
                0xD3,
                0x49,
                0x89,
                0x8A,
                0x27,
                0x86,
                0x78,
                0x0C,
                0x5D,
                0x98
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IAppxManifestPackageDependency3
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x74,
                0x63,
                0xC5,
                0x1A,
                0x98,
                0x61,
                0x6B,
                0x4D,
                0x92,
                0xE4,
                0x74,
                0x9D,
                0x5A,
                0xB8,
                0xA8,
                0x95
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IAppxManifestResourcesEnumerator
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xBD,
                0xFB,
                0x4D,
                0xDE,
                0x1A,
                0x88,
                0xBB,
                0x48,
                0x85,
                0x8C,
                0xD6,
                0xF2,
                0xBA,
                0xEA,
                0xE6,
                0xED
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IAppxManifestDeviceCapabilitiesEnumerator
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x41,
                0x45,
                0x20,
                0x30,
                0x7B,
                0x42,
                0x1C,
                0x4A,
                0xBA,
                0xCF,
                0x65,
                0x5B,
                0xF4,
                0x63,
                0xA5,
                0x40
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IAppxManifestCapabilitiesEnumerator
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x58,
                0x22,
                0xD2,
                0x11,
                0x70,
                0xF4,
                0xC1,
                0x42,
                0xB2,
                0x91,
                0x83,
                0x61,
                0xC5,
                0x43,
                0x7E,
                0x41
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IAppxManifestApplicationsEnumerator
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x5A,
                0xA5,
                0xB8,
                0x9E,
                0x4B,
                0xF0,
                0x0D,
                0x4D,
                0x80,
                0x8D,
                0x68,
                0x61,
                0x85,
                0xD4,
                0x84,
                0x7A
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IAppxManifestApplication
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xF4,
                0x9B,
                0xA8,
                0x5D,
                0x73,
                0x37,
                0xBE,
                0x46,
                0xB6,
                0x50,
                0x7E,
                0x74,
                0x48,
                0x63,
                0xB7,
                0xE8
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IAppxManifestQualifiedResourcesEnumerator
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xFE,
                0xAD,
                0xF6,
                0x8E,
                0x62,
                0x37,
                0x8F,
                0x4A,
                0x93,
                0x73,
                0x2F,
                0xC5,
                0xD4,
                0x44,
                0xC8,
                0xD2
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IAppxManifestQualifiedResource
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x97,
                0xA4,
                0x53,
                0x3B,
                0x5C,
                0x3C,
                0xD1,
                0x48,
                0x9E,
                0xA3,
                0xBB,
                0x7E,
                0xAC,
                0x8C,
                0xD7,
                0xD4
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IAppxBundleFactory
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x64,
                0x58,
                0xA6,
                0xBB,
                0x5F,
                0x96,
                0x5F,
                0x4A,
                0x85,
                0x5F,
                0xF0,
                0x74,
                0xBD,
                0xBF,
                0x3A,
                0x7B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IAppxBundleFactory2
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x3D,
                0xB8,
                0x25,
                0x73,
                0x85,
                0x01,
                0xC4,
                0x42,
                0x82,
                0xAC,
                0xBE,
                0x34,
                0xAB,
                0x1A,
                0x2A,
                0x8A
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IAppxBundleWriter
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xE8,
                0x6F,
                0x44,
                0xEC,
                0xEC,
                0xBF,
                0x64,
                0x4C,
                0xAB,
                0x4F,
                0x49,
                0xF0,
                0x38,
                0xF0,
                0xC6,
                0xD2
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IAppxBundleWriter2
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x71,
                0xE9,
                0x8F,
                0x6D,
                0xCC,
                0x01,
                0xA0,
                0x49,
                0xB6,
                0x85,
                0x23,
                0x38,
                0x51,
                0x27,
                0x99,
                0x62
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IAppxBundleWriter3
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x52,
                0x11,
                0x71,
                0xAD,
                0x69,
                0xF9,
                0x93,
                0x41,
                0x82,
                0xD5,
                0x9D,
                0xDF,
                0x27,
                0x86,
                0xD2,
                0x1A
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IAppxBundleWriter4
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x23,
                0xD5,
                0xD9,
                0x9C,
                0x09,
                0x50,
                0x01,
                0x4C,
                0x98,
                0x82,
                0xDC,
                0x02,
                0x9F,
                0xBD,
                0x47,
                0xA3
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IAppxBundleReader
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xC0,
                0xB8,
                0x75,
                0xDD,
                0x76,
                0xBA,
                0xB0,
                0x43,
                0xAE,
                0x0F,
                0x68,
                0x65,
                0x6A,
                0x1D,
                0xC5,
                0xC8
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IAppxBundleManifestReader
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xC1,
                0xBB,
                0x0E,
                0xCF,
                0x99,
                0xCC,
                0x06,
                0x41,
                0x91,
                0xEB,
                0xE6,
                0x74,
                0x62,
                0xE0,
                0x4F,
                0xB0
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IAppxBundleManifestReader2
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x70,
                0xDF,
                0x17,
                0x55,
                0x3F,
                0x03,
                0xF2,
                0x4A,
                0x82,
                0x13,
                0x87,
                0xD7,
                0x66,
                0x80,
                0x5C,
                0x02
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IAppxBundleManifestPackageInfoEnumerator
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xEE,
                0x56,
                0xB8,
                0xF9,
                0xA6,
                0x49,
                0x19,
                0x4E,
                0xB2,
                0xB0,
                0x6A,
                0x24,
                0x06,
                0xD6,
                0x3A,
                0x32
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IAppxBundleManifestPackageInfo
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xC1,
                0x06,
                0xCD,
                0x54,
                0x8F,
                0x26,
                0xBB,
                0x40,
                0x8E,
                0xD2,
                0x75,
                0x7A,
                0x9E,
                0xBA,
                0xEC,
                0x8D
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IAppxBundleManifestPackageInfo2
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xBC,
                0xAC,
                0xC2,
                0x44,
                0xCF,
                0xB2,
                0xCB,
                0x4C,
                0xBB,
                0xDB,
                0x9C,
                0x6D,
                0xA8,
                0xC3,
                0xBC,
                0x9E
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IAppxBundleManifestPackageInfo3
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x98,
                0x4B,
                0xA7,
                0x6B,
                0x74,
                0xBB,
                0x96,
                0x42,
                0x80,
                0xD0,
                0x5F,
                0x42,
                0x56,
                0xA9,
                0x96,
                0x75
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IAppxBundleManifestPackageInfo4
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x3D,
                0xF1,
                0xA6,
                0x5D,
                0xA7,
                0xA8,
                0x32,
                0x45,
                0x85,
                0x7C,
                0x13,
                0x93,
                0xD6,
                0x59,
                0x37,
                0x1D
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IAppxBundleManifestOptionalBundleInfoEnumerator
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x93,
                0x87,
                0x17,
                0x9A,
                0x7E,
                0xF9,
                0xAC,
                0x46,
                0xAA,
                0xCA,
                0xDD,
                0x5B,
                0xA4,
                0xC1,
                0x77,
                0xC8
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IAppxBundleManifestOptionalBundleInfo
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xE8,
                0xF2,
                0x5B,
                0x51,
                0xB0,
                0xBC,
                0x69,
                0x4D,
                0x8C,
                0x48,
                0xE3,
                0x83,
                0x14,
                0x7B,
                0x6E,
                0x12
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IAppxContentGroupFilesEnumerator
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xFD,
                0xA2,
                0x09,
                0x1A,
                0x40,
                0x74,
                0xEB,
                0x44,
                0x8C,
                0x84,
                0x84,
                0x82,
                0x05,
                0xA6,
                0xA1,
                0xCC
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IAppxContentGroup
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x68,
                0x64,
                0x8F,
                0x32,
                0x4F,
                0xC0,
                0x3C,
                0x4E,
                0xB6,
                0xFA,
                0x6B,
                0x8D,
                0x27,
                0xF3,
                0x00,
                0x3A
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IAppxContentGroupsEnumerator
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x77,
                0xE4,
                0x64,
                0x32,
                0xD1,
                0x16,
                0x63,
                0x4D,
                0x82,
                0x3E,
                0x7D,
                0x29,
                0x84,
                0x69,
                0x66,
                0x34
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IAppxContentGroupMapReader
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xD8,
                0x26,
                0x87,
                0x41,
                0x99,
                0xDD,
                0x5D,
                0x4F,
                0x98,
                0x86,
                0x15,
                0x7A,
                0xDD,
                0x20,
                0xDE,
                0x01
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IAppxSourceContentGroupMapReader
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x1D,
                0x79,
                0x29,
                0xF3,
                0x0B,
                0x54,
                0x9F,
                0x4A,
                0xBC,
                0x75,
                0x32,
                0x82,
                0xB7,
                0xD7,
                0x31,
                0x93
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IAppxContentGroupMapWriter
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x76,
                0xB7,
                0x7A,
                0xD0,
                0xDE,
                0xA9,
                0x98,
                0x47,
                0x8C,
                0x14,
                0x3D,
                0xB3,
                0x1E,
                0x68,
                0x7C,
                0x78
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IAppxPackagingDiagnosticEventSink
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x47,
                0x9D,
                0x23,
                0x17,
                0xDB,
                0x6A,
                0xD2,
                0x45,
                0x80,
                0xF6,
                0xF9,
                0xCB,
                0xC3,
                0xBF,
                0x05,
                0x9D
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IAppxPackagingDiagnosticEventSinkManager
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xFA,
                0x48,
                0x96,
                0x36,
                0xEB,
                0xA7,
                0x09,
                0x49,
                0xA1,
                0x5D,
                0x69,
                0x54,
                0xA0,
                0x78,
                0xF1,
                0x8A
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IAppxAppInstallerReader
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x8C,
                0xC3,
                0x5B,
                0xF3,
                0x2F,
                0x1D,
                0xDB,
                0x43,
                0xA1,
                0xF4,
                0x58,
                0x64,
                0x30,
                0xD1,
                0xFE,
                0xD2
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IAppxDigestProvider
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x2B,
                0x70,
                0xE2,
                0x9F,
                0x40,
                0x76,
                0x59,
                0x46,
                0x8E,
                0x6C,
                0x34,
                0x9E,
                0x43,
                0xC4,
                0xCD,
                0xBD
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IAppxEncryptionFactory
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x4D,
                0xE0,
                0xE8,
                0x80,
                0x88,
                0x8C,
                0xAE,
                0x44,
                0xA0,
                0x11,
                0x7C,
                0xAD,
                0xF6,
                0xFB,
                0x2E,
                0x72
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IAppxEncryptionFactory2
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xEE,
                0x1E,
                0xB1,
                0xC1,
                0xBA,
                0xC4,
                0xB2,
                0x4A,
                0xA5,
                0x5D,
                0xD0,
                0x15,
                0xFE,
                0x8F,
                0xF6,
                0x4F
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IAppxEncryptionFactory3
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x37,
                0xCA,
                0xED,
                0x09,
                0x64,
                0xCD,
                0xD6,
                0x47,
                0xB7,
                0xE8,
                0x1C,
                0xB1,
                0x1D,
                0x4F,
                0x7E,
                0x05
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IAppxEncryptionFactory4
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x1F,
                0x61,
                0x79,
                0xA8,
                0xFD,
                0x12,
                0xFE,
                0x41,
                0x85,
                0xD5,
                0x06,
                0xAE,
                0x77,
                0x9B,
                0xBA,
                0xF5
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IAppxEncryptionFactory5
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x7A,
                0xE7,
                0xD6,
                0x68,
                0x46,
                0xF4,
                0x0F,
                0x48,
                0xB0,
                0xF0,
                0xD9,
                0x1A,
                0x24,
                0xC6,
                0x07,
                0x46
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IAppxEncryptedPackageWriter
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x0B,
                0x0B,
                0x3D,
                0xF4,
                0x79,
                0x13,
                0xE2,
                0x40,
                0x9B,
                0x29,
                0x68,
                0x2E,
                0xA2,
                0xBF,
                0x42,
                0xAF
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IAppxEncryptedPackageWriter2
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x47,
                0x54,
                0x47,
                0x3E,
                0x25,
                0x3A,
                0xB5,
                0x40,
                0x8A,
                0xD2,
                0xF9,
                0x53,
                0xAE,
                0x50,
                0xC9,
                0x2D
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IAppxEncryptedBundleWriter
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x2F,
                0x90,
                0xB0,
                0x80,
                0xF0,
                0x7B,
                0x17,
                0x41,
                0xB8,
                0xC6,
                0x42,
                0x79,
                0xEF,
                0x81,
                0xEE,
                0x77
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IAppxEncryptedBundleWriter2
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x82,
                0xBE,
                0x44,
                0xE6,
                0xFA,
                0xF0,
                0xB8,
                0x42,
                0xA9,
                0x56,
                0x8D,
                0x1C,
                0xB4,
                0x8E,
                0xE3,
                0x79
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IAppxEncryptedBundleWriter3
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xB3,
                0xDE,
                0x34,
                0x0D,
                0xAE,
                0x5C,
                0xD3,
                0x4D,
                0x97,
                0x7C,
                0x50,
                0x49,
                0x32,
                0xA5,
                0x1D,
                0x31
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IAppxPackageEditor
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xDC,
                0xB6,
                0xAD,
                0xE2,
                0x71,
                0x5E,
                0x16,
                0x44,
                0x86,
                0xB6,
                0x86,
                0xE5,
                0xF5,
                0x29,
                0x1A,
                0x6B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_AppxFactory
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x40,
                0xA1,
                0x42,
                0x58,
                0x9F,
                0xFF,
                0x66,
                0x41,
                0x8F,
                0x5C,
                0x62,
                0xF5,
                0xB7,
                0xB0,
                0xC7,
                0x81
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_AppxBundleFactory
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x46,
                0x04,
                0x8E,
                0x37,
                0x84,
                0x53,
                0xB7,
                0x43,
                0x88,
                0x77,
                0xE7,
                0xDB,
                0xDD,
                0x88,
                0x34,
                0x46
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_AppxPackagingDiagnosticEventSinkManager
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x46,
                0x0A,
                0xCA,
                0x50,
                0x88,
                0x15,
                0x61,
                0x41,
                0x8E,
                0xD2,
                0xEF,
                0x9E,
                0x46,
                0x9C,
                0xED,
                0x5D
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_AppxEncryptionFactory
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xDD,
                0x4F,
                0x66,
                0xDC,
                0x68,
                0xD8,
                0xEE,
                0x46,
                0x87,
                0x80,
                0x8D,
                0x19,
                0x6C,
                0xB7,
                0x39,
                0xF7
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_AppxPackageEditor
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xCA,
                0xF2,
                0x04,
                0xF0,
                0xBC,
                0xAE,
                0x0D,
                0x4B,
                0xBF,
                0x58,
                0xE5,
                0x16,
                0xD5,
                0xBC,
                0xC0,
                0xAB
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}