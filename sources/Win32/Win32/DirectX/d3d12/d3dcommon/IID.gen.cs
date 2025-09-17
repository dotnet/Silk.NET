// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/minwinbase.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using Silk.NET.DirectX;
using Silk.NET.Win32;
using Silk.NET.WinRT;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public static partial class IID
{
    [NativeTypeName("const GUID")]
    public static ref readonly Guid ID3D10Blob
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x08,
                0xFB,
                0xA5,
                0x8B,
                0x95,
                0x51,
                0xE2,
                0x40,
                0xAC,
                0x58,
                0x0D,
                0x98,
                0x9C,
                0x3A,
                0x01,
                0x02,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("#define IID_ID3DBlob IID_ID3D10Blob")]
    public static ref readonly Guid ID3DBlob => ref ID3D10Blob;
    public static ref readonly Guid ID3DDestructionNotifier
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x9A,
                0xB3,
                0x6E,
                0xA0,
                0xDA,
                0x50,
                0x5B,
                0x42,
                0x8C,
                0x31,
                0x4E,
                0xEC,
                0xD6,
                0xC2,
                0x70,
                0xF3,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
