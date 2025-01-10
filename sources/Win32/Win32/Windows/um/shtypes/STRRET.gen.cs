// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/shtypes.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public unsafe partial struct STRRET
{
    public uint uType;

    [NativeTypeName("__AnonymousRecord_shtypes_L285_C36")]
    public _Anonymous_e__Union Anonymous;

    [UnscopedRef]
    public ref ushort* pOleStr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.pOleStr; }
    }

    [UnscopedRef]
    public ref uint uOffset
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.uOffset; }
    }

    [UnscopedRef]
    public Span<sbyte> cStr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return Anonymous.cStr; }
    }

    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("LPWSTR")]
        public ushort* pOleStr;

        [FieldOffset(0)]
        public uint uOffset;

        [FieldOffset(0)]
        [NativeTypeName("char[260]")]
        public _cStr_e__FixedBuffer cStr;

        [InlineArray(260)]
        public partial struct _cStr_e__FixedBuffer
        {
            public sbyte e0;
        }
    }
}
