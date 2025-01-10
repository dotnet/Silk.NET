// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct MFINPUTTRUSTAUTHORITY_ACCESS_PARAMS
{
    [NativeTypeName("DWORD")]
    public uint dwSize;

    [NativeTypeName("DWORD")]
    public uint dwVer;

    [NativeTypeName("DWORD")]
    public uint cbSignatureOffset;

    [NativeTypeName("DWORD")]
    public uint cbSignatureSize;

    [NativeTypeName("DWORD")]
    public uint cbExtensionOffset;

    [NativeTypeName("DWORD")]
    public uint cbExtensionSize;

    [NativeTypeName("DWORD")]
    public uint cActions;

    [NativeTypeName("MFINPUTTRUSTAUTHORITY_ACCESS_ACTION[1]")]
    public _rgOutputActions_e__FixedBuffer rgOutputActions;

    public partial struct _rgOutputActions_e__FixedBuffer
    {
        public MFINPUTTRUSTAUTHORITY_ACCESS_ACTION e0;

        [UnscopedRef]
        public ref MFINPUTTRUSTAUTHORITY_ACCESS_ACTION this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref Unsafe.Add(ref e0, index); }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<MFINPUTTRUSTAUTHORITY_ACCESS_ACTION> AsSpan(int length) =>
            MemoryMarshal.CreateSpan(ref e0, length);
    }
}
