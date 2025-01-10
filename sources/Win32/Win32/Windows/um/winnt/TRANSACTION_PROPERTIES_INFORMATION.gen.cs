// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct TRANSACTION_PROPERTIES_INFORMATION
{
    [NativeTypeName("DWORD")]
    public uint IsolationLevel;

    [NativeTypeName("DWORD")]
    public uint IsolationFlags;
    public LARGE_INTEGER Timeout;

    [NativeTypeName("DWORD")]
    public uint Outcome;

    [NativeTypeName("DWORD")]
    public uint DescriptionLength;

    [NativeTypeName("WCHAR[1]")]
    public _Description_e__FixedBuffer Description;

    public partial struct _Description_e__FixedBuffer
    {
        public ushort e0;

        [UnscopedRef]
        public ref ushort this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref Unsafe.Add(ref e0, index); }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<ushort> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
    }
}
