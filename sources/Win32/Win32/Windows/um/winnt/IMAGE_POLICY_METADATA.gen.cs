// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct IMAGE_POLICY_METADATA
{
    public byte Version;

    [NativeTypeName("BYTE[7]")]
    public _Reserved0_e__FixedBuffer Reserved0;

    [NativeTypeName("ULONGLONG")]
    public ulong ApplicationId;

    [NativeTypeName("IMAGE_POLICY_ENTRY[]")]
    public _Policies_e__FixedBuffer Policies;

    [InlineArray(7)]
    public partial struct _Reserved0_e__FixedBuffer
    {
        public byte e0;
    }

    public partial struct _Policies_e__FixedBuffer
    {
        public IMAGE_POLICY_ENTRY e0;

        [UnscopedRef]
        public ref IMAGE_POLICY_ENTRY this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref Unsafe.Add(ref e0, index); }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<IMAGE_POLICY_ENTRY> AsSpan(int length) =>
            MemoryMarshal.CreateSpan(ref e0, length);
    }
}
