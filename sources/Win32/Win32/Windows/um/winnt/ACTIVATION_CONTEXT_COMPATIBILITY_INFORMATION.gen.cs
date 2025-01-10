// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct ACTIVATION_CONTEXT_COMPATIBILITY_INFORMATION
{
    [NativeTypeName("DWORD")]
    public uint ElementCount;

    [NativeTypeName("COMPATIBILITY_CONTEXT_ELEMENT[]")]
    public _Elements_e__FixedBuffer Elements;

    public partial struct _Elements_e__FixedBuffer
    {
        public COMPATIBILITY_CONTEXT_ELEMENT e0;

        [UnscopedRef]
        public ref COMPATIBILITY_CONTEXT_ELEMENT this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref Unsafe.Add(ref e0, index); }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<COMPATIBILITY_CONTEXT_ELEMENT> AsSpan(int length) =>
            MemoryMarshal.CreateSpan(ref e0, length);
    }
}
