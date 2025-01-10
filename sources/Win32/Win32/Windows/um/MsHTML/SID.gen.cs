// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct SID
{
    [NativeTypeName("const GUID")]
    public static ref readonly Guid SID_SEditCommandTarget
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB5,
                0xF4,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid SID_SHTMLEditHost
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA0,
                0xF6,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid SID_SHTMLEditServices
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF9,
                0xF7,
                0x50,
                0x30,
                0xB5,
                0x98,
                0xCF,
                0x11,
                0xBB,
                0x82,
                0x00,
                0xAA,
                0x00,
                0xBD,
                0xCE,
                0x0B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("#define SID_SHTMLWindow IID_IHTMLWindow2")]
    public static ref readonly Guid SID_SHTMLWindow => ref IID_IHTMLWindow2;

    [NativeTypeName("#define SID_SElementBehaviorFactory IID_IElementBehaviorFactory")]
    public static ref readonly Guid SID_SElementBehaviorFactory => ref IID_IElementBehaviorFactory;

    [NativeTypeName("#define SID_STrackingProtection IID_ITrackingProtection")]
    public static ref readonly Guid SID_STrackingProtection => ref IID_ITrackingProtection;
}
