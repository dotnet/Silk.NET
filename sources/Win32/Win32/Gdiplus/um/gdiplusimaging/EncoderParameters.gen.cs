// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/gdiplusimaging.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Gdiplus;

public partial struct EncoderParameters
{
    public uint Count;

    [NativeTypeName("EncoderParameter[1]")]
    public _Parameter_e__FixedBuffer Parameter;

    public partial struct _Parameter_e__FixedBuffer
    {
        public EncoderParameter e0;

        [UnscopedRef]
        public ref EncoderParameter this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref Unsafe.Add(ref e0, index); }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<EncoderParameter> AsSpan(int length) =>
            MemoryMarshal.CreateSpan(ref e0, length);
    }
}
