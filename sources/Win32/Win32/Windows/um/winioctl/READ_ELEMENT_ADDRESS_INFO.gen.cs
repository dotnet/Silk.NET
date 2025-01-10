// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct READ_ELEMENT_ADDRESS_INFO
{
    [NativeTypeName("DWORD")]
    public uint NumberOfElements;

    [NativeTypeName("CHANGER_ELEMENT_STATUS[1]")]
    public _ElementStatus_e__FixedBuffer ElementStatus;

    public partial struct _ElementStatus_e__FixedBuffer
    {
        public CHANGER_ELEMENT_STATUS e0;

        [UnscopedRef]
        public ref CHANGER_ELEMENT_STATUS this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref Unsafe.Add(ref e0, index); }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<CHANGER_ELEMENT_STATUS> AsSpan(int length) =>
            MemoryMarshal.CreateSpan(ref e0, length);
    }
}
