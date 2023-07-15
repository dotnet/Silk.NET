// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/credentialprovider.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;
public static partial class Windows
{
    [NativeTypeName("const GUID")]
    public static ref readonly Guid Identity_LocalUserProvider
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x9B,
                0x52,
                0x98,
                0xA1,
                0x0F,
                0x73,
                0x89,
                0x40,
                0xB6,
                0x46,
                0xA1,
                0x25,
                0x57,
                0xF5,
                0x66,
                0x5E
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("#define CREDENTIAL_PROVIDER_NO_DEFAULT ((DWORD)-1)")]
    public const uint CREDENTIAL_PROVIDER_NO_DEFAULT = unchecked((uint)(-1));
}