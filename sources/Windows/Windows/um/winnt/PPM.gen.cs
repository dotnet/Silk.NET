// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;

public static partial class PPM
{
    [NativeTypeName("const GUID")]
    public static ref readonly Guid PPM_PERFSTATE_CHANGE_GUID
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xDD, 0x2D, 0xB3, 0xA5,
                0x39, 0x7F,
                0xBC, 0x4A,
                0xB8,
                0x92,
                0x90,
                0x0E,
                0x43,
                0xB5,
                0x9E,
                0xBB
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid PPM_PERFSTATE_DOMAIN_CHANGE_GUID
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x7F, 0x6B, 0x5E, 0x99,
                0x53, 0xD6,
                0x7A, 0x49,
                0xB9,
                0x78,
                0x36,
                0xA3,
                0x0C,
                0x29,
                0xBF,
                0x01
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid PPM_IDLESTATE_CHANGE_GUID
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x4F, 0xFE, 0x38, 0x48,
                0x1C, 0xF7,
                0x51, 0x4E,
                0x9E,
                0xCC,
                0x84,
                0x30,
                0xA7,
                0xAC,
                0x4C,
                0x6C
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid PPM_PERFSTATES_DATA_GUID
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x20, 0xCC, 0x08, 0x57,
                0x40, 0x7D,
                0xF4, 0x4B,
                0xB4,
                0xAA,
                0x2B,
                0x01,
                0x33,
                0x8D,
                0x01,
                0x26
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid PPM_IDLESTATES_DATA_GUID
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x10, 0x8E, 0x13, 0xBA,
                0x50, 0xE2,
                0xD7, 0x4A,
                0x86,
                0x16,
                0xCF,
                0x1A,
                0x7A,
                0xD4,
                0x10,
                0xE7
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid PPM_IDLE_ACCOUNTING_GUID
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x78, 0x6F, 0xA2, 0xE2,
                0x07, 0xAE,
                0xE0, 0x4E,
                0xA3,
                0x0F,
                0xCE,
                0x54,
                0xF5,
                0x5A,
                0x94,
                0xCD
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid PPM_IDLE_ACCOUNTING_EX_GUID
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x39, 0xBD, 0x7A, 0xD6,
                0xF8, 0x81,
                0x5E, 0x4A,
                0x81,
                0x52,
                0x72,
                0xE3,
                0x1E,
                0xC9,
                0x12,
                0xEE
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid PPM_THERMALCONSTRAINT_GUID
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xC8, 0xC2, 0x52, 0xA8,
                0x4C, 0x1A,
                0x3B, 0x42,
                0x8C,
                0x2C,
                0xF3,
                0x0D,
                0x82,
                0x93,
                0x1A,
                0x88
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid PPM_PERFMON_PERFSTATE_GUID
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x52, 0x86, 0xD1, 0x7F,
                0xFE, 0x0C,
                0xD2, 0x40,
                0xB0,
                0xA1,
                0x0B,
                0x06,
                0x6A,
                0x87,
                0x75,
                0x9E
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid PPM_THERMAL_POLICY_CHANGE_GUID
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xB8, 0x77, 0xF3, 0x48,
                0x80, 0x68,
                0x7B, 0x4C,
                0x8B,
                0xDC,
                0x38,
                0x01,
                0x76,
                0xC6,
                0x65,
                0x4D
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("#define PPM_FIRMWARE_ACPI1C2 0x00000001")]
    public const int PPM_FIRMWARE_ACPI1C2 = 0x00000001;

    [NativeTypeName("#define PPM_FIRMWARE_ACPI1C3 0x00000002")]
    public const int PPM_FIRMWARE_ACPI1C3 = 0x00000002;

    [NativeTypeName("#define PPM_FIRMWARE_ACPI1TSTATES 0x00000004")]
    public const int PPM_FIRMWARE_ACPI1TSTATES = 0x00000004;

    [NativeTypeName("#define PPM_FIRMWARE_CST 0x00000008")]
    public const int PPM_FIRMWARE_CST = 0x00000008;

    [NativeTypeName("#define PPM_FIRMWARE_CSD 0x00000010")]
    public const int PPM_FIRMWARE_CSD = 0x00000010;

    [NativeTypeName("#define PPM_FIRMWARE_PCT 0x00000020")]
    public const int PPM_FIRMWARE_PCT = 0x00000020;

    [NativeTypeName("#define PPM_FIRMWARE_PSS 0x00000040")]
    public const int PPM_FIRMWARE_PSS = 0x00000040;

    [NativeTypeName("#define PPM_FIRMWARE_XPSS 0x00000080")]
    public const int PPM_FIRMWARE_XPSS = 0x00000080;

    [NativeTypeName("#define PPM_FIRMWARE_PPC 0x00000100")]
    public const int PPM_FIRMWARE_PPC = 0x00000100;

    [NativeTypeName("#define PPM_FIRMWARE_PSD 0x00000200")]
    public const int PPM_FIRMWARE_PSD = 0x00000200;

    [NativeTypeName("#define PPM_FIRMWARE_PTC 0x00000400")]
    public const int PPM_FIRMWARE_PTC = 0x00000400;

    [NativeTypeName("#define PPM_FIRMWARE_TSS 0x00000800")]
    public const int PPM_FIRMWARE_TSS = 0x00000800;

    [NativeTypeName("#define PPM_FIRMWARE_TPC 0x00001000")]
    public const int PPM_FIRMWARE_TPC = 0x00001000;

    [NativeTypeName("#define PPM_FIRMWARE_TSD 0x00002000")]
    public const int PPM_FIRMWARE_TSD = 0x00002000;

    [NativeTypeName("#define PPM_FIRMWARE_PCCH 0x00004000")]
    public const int PPM_FIRMWARE_PCCH = 0x00004000;

    [NativeTypeName("#define PPM_FIRMWARE_PCCP 0x00008000")]
    public const int PPM_FIRMWARE_PCCP = 0x00008000;

    [NativeTypeName("#define PPM_FIRMWARE_OSC 0x00010000")]
    public const int PPM_FIRMWARE_OSC = 0x00010000;

    [NativeTypeName("#define PPM_FIRMWARE_PDC 0x00020000")]
    public const int PPM_FIRMWARE_PDC = 0x00020000;

    [NativeTypeName("#define PPM_FIRMWARE_CPC 0x00040000")]
    public const int PPM_FIRMWARE_CPC = 0x00040000;

    [NativeTypeName("#define PPM_FIRMWARE_LPI 0x00080000")]
    public const int PPM_FIRMWARE_LPI = 0x00080000;

    [NativeTypeName("#define PPM_PERFORMANCE_IMPLEMENTATION_NONE 0x00000000")]
    public const int PPM_PERFORMANCE_IMPLEMENTATION_NONE = 0x00000000;

    [NativeTypeName("#define PPM_PERFORMANCE_IMPLEMENTATION_PSTATES 0x00000001")]
    public const int PPM_PERFORMANCE_IMPLEMENTATION_PSTATES = 0x00000001;

    [NativeTypeName("#define PPM_PERFORMANCE_IMPLEMENTATION_PCCV1 0x00000002")]
    public const int PPM_PERFORMANCE_IMPLEMENTATION_PCCV1 = 0x00000002;

    [NativeTypeName("#define PPM_PERFORMANCE_IMPLEMENTATION_CPPC 0x00000003")]
    public const int PPM_PERFORMANCE_IMPLEMENTATION_CPPC = 0x00000003;

    [NativeTypeName("#define PPM_PERFORMANCE_IMPLEMENTATION_PEP 0x00000004")]
    public const int PPM_PERFORMANCE_IMPLEMENTATION_PEP = 0x00000004;

    [NativeTypeName("#define PPM_IDLE_IMPLEMENTATION_NONE 0x00000000")]
    public const int PPM_IDLE_IMPLEMENTATION_NONE = 0x00000000;

    [NativeTypeName("#define PPM_IDLE_IMPLEMENTATION_CSTATES 0x00000001")]
    public const int PPM_IDLE_IMPLEMENTATION_CSTATES = 0x00000001;

    [NativeTypeName("#define PPM_IDLE_IMPLEMENTATION_PEP 0x00000002")]
    public const int PPM_IDLE_IMPLEMENTATION_PEP = 0x00000002;

    [NativeTypeName("#define PPM_IDLE_IMPLEMENTATION_MICROPEP 0x00000003")]
    public const int PPM_IDLE_IMPLEMENTATION_MICROPEP = 0x00000003;

    [NativeTypeName("#define PPM_IDLE_IMPLEMENTATION_LPISTATES 0x00000004")]
    public const int PPM_IDLE_IMPLEMENTATION_LPISTATES = 0x00000004;
}
