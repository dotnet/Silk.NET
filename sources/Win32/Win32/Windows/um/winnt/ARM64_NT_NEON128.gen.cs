// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[StructLayout(LayoutKind.Explicit)]
public partial struct ARM64_NT_NEON128
{
    [FieldOffset(0)]
    [NativeTypeName("__AnonymousRecord_winnt_L6782_C5")]
    public _Anonymous_e__Struct Anonymous;

    [FieldOffset(0)]
    [NativeTypeName("double[2]")]
    public _D_e__FixedBuffer D;

    [FieldOffset(0)]
    [NativeTypeName("float[4]")]
    public _S_e__FixedBuffer S;

    [FieldOffset(0)]
    [NativeTypeName("WORD[8]")]
    public _H_e__FixedBuffer H;

    [FieldOffset(0)]
    [NativeTypeName("BYTE[16]")]
    public _B_e__FixedBuffer B;

    [UnscopedRef]
    public ref ulong Low
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Low; }
    }

    [UnscopedRef]
    public ref long High
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.High; }
    }

    public partial struct _Anonymous_e__Struct
    {
        [NativeTypeName("ULONGLONG")]
        public ulong Low;

        [NativeTypeName("LONGLONG")]
        public long High;
    }

    [InlineArray(2)]
    public partial struct _D_e__FixedBuffer
    {
        public double e0;
    }

    [InlineArray(4)]
    public partial struct _S_e__FixedBuffer
    {
        public float e0;
    }

    [InlineArray(8)]
    public partial struct _H_e__FixedBuffer
    {
        public ushort e0;
    }

    [InlineArray(16)]
    public partial struct _B_e__FixedBuffer
    {
        public byte e0;
    }
}
