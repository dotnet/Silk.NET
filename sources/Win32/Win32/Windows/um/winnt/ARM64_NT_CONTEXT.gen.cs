// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct ARM64_NT_CONTEXT
{
    [NativeTypeName("DWORD")]
    public uint ContextFlags;

    [NativeTypeName("DWORD")]
    public uint Cpsr;

    [NativeTypeName("__AnonymousRecord_winnt_L6823_C18")]
    public _Anonymous_e__Union Anonymous;

    [NativeTypeName("DWORD64")]
    public ulong Sp;

    [NativeTypeName("DWORD64")]
    public ulong Pc;

    [NativeTypeName("ARM64_NT_NEON128[32]")]
    public _V_e__FixedBuffer V;

    [NativeTypeName("DWORD")]
    public uint Fpcr;

    [NativeTypeName("DWORD")]
    public uint Fpsr;

    [NativeTypeName("DWORD[8]")]
    public _Bcr_e__FixedBuffer Bcr;

    [NativeTypeName("DWORD64[8]")]
    public _Bvr_e__FixedBuffer Bvr;

    [NativeTypeName("DWORD[2]")]
    public _Wcr_e__FixedBuffer Wcr;

    [NativeTypeName("DWORD64[2]")]
    public _Wvr_e__FixedBuffer Wvr;

    [UnscopedRef]
    public ref ulong X0
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.X0; }
    }

    [UnscopedRef]
    public ref ulong X1
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.X1; }
    }

    [UnscopedRef]
    public ref ulong X2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.X2; }
    }

    [UnscopedRef]
    public ref ulong X3
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.X3; }
    }

    [UnscopedRef]
    public ref ulong X4
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.X4; }
    }

    [UnscopedRef]
    public ref ulong X5
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.X5; }
    }

    [UnscopedRef]
    public ref ulong X6
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.X6; }
    }

    [UnscopedRef]
    public ref ulong X7
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.X7; }
    }

    [UnscopedRef]
    public ref ulong X8
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.X8; }
    }

    [UnscopedRef]
    public ref ulong X9
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.X9; }
    }

    [UnscopedRef]
    public ref ulong X10
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.X10; }
    }

    [UnscopedRef]
    public ref ulong X11
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.X11; }
    }

    [UnscopedRef]
    public ref ulong X12
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.X12; }
    }

    [UnscopedRef]
    public ref ulong X13
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.X13; }
    }

    [UnscopedRef]
    public ref ulong X14
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.X14; }
    }

    [UnscopedRef]
    public ref ulong X15
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.X15; }
    }

    [UnscopedRef]
    public ref ulong X16
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.X16; }
    }

    [UnscopedRef]
    public ref ulong X17
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.X17; }
    }

    [UnscopedRef]
    public ref ulong X18
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.X18; }
    }

    [UnscopedRef]
    public ref ulong X19
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.X19; }
    }

    [UnscopedRef]
    public ref ulong X20
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.X20; }
    }

    [UnscopedRef]
    public ref ulong X21
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.X21; }
    }

    [UnscopedRef]
    public ref ulong X22
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.X22; }
    }

    [UnscopedRef]
    public ref ulong X23
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.X23; }
    }

    [UnscopedRef]
    public ref ulong X24
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.X24; }
    }

    [UnscopedRef]
    public ref ulong X25
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.X25; }
    }

    [UnscopedRef]
    public ref ulong X26
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.X26; }
    }

    [UnscopedRef]
    public ref ulong X27
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.X27; }
    }

    [UnscopedRef]
    public ref ulong X28
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.X28; }
    }

    [UnscopedRef]
    public ref ulong Fp
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.Fp; }
    }

    [UnscopedRef]
    public ref ulong Lr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.Lr; }
    }

    [UnscopedRef]
    public Span<ulong> X
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return Anonymous.X; }
    }

    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_winnt_L6824_C21")]
        public _Anonymous_e__Struct Anonymous;

        [FieldOffset(0)]
        [NativeTypeName("DWORD64[31]")]
        public _X_e__FixedBuffer X;

        public partial struct _Anonymous_e__Struct
        {
            [NativeTypeName("DWORD64")]
            public ulong X0;

            [NativeTypeName("DWORD64")]
            public ulong X1;

            [NativeTypeName("DWORD64")]
            public ulong X2;

            [NativeTypeName("DWORD64")]
            public ulong X3;

            [NativeTypeName("DWORD64")]
            public ulong X4;

            [NativeTypeName("DWORD64")]
            public ulong X5;

            [NativeTypeName("DWORD64")]
            public ulong X6;

            [NativeTypeName("DWORD64")]
            public ulong X7;

            [NativeTypeName("DWORD64")]
            public ulong X8;

            [NativeTypeName("DWORD64")]
            public ulong X9;

            [NativeTypeName("DWORD64")]
            public ulong X10;

            [NativeTypeName("DWORD64")]
            public ulong X11;

            [NativeTypeName("DWORD64")]
            public ulong X12;

            [NativeTypeName("DWORD64")]
            public ulong X13;

            [NativeTypeName("DWORD64")]
            public ulong X14;

            [NativeTypeName("DWORD64")]
            public ulong X15;

            [NativeTypeName("DWORD64")]
            public ulong X16;

            [NativeTypeName("DWORD64")]
            public ulong X17;

            [NativeTypeName("DWORD64")]
            public ulong X18;

            [NativeTypeName("DWORD64")]
            public ulong X19;

            [NativeTypeName("DWORD64")]
            public ulong X20;

            [NativeTypeName("DWORD64")]
            public ulong X21;

            [NativeTypeName("DWORD64")]
            public ulong X22;

            [NativeTypeName("DWORD64")]
            public ulong X23;

            [NativeTypeName("DWORD64")]
            public ulong X24;

            [NativeTypeName("DWORD64")]
            public ulong X25;

            [NativeTypeName("DWORD64")]
            public ulong X26;

            [NativeTypeName("DWORD64")]
            public ulong X27;

            [NativeTypeName("DWORD64")]
            public ulong X28;

            [NativeTypeName("DWORD64")]
            public ulong Fp;

            [NativeTypeName("DWORD64")]
            public ulong Lr;
        }

        [InlineArray(31)]
        public partial struct _X_e__FixedBuffer
        {
            public ulong e0;
        }
    }

    [InlineArray(32)]
    public partial struct _V_e__FixedBuffer
    {
        public ARM64_NT_NEON128 e0;
    }

    [InlineArray(8)]
    public partial struct _Bcr_e__FixedBuffer
    {
        public uint e0;
    }

    [InlineArray(8)]
    public partial struct _Bvr_e__FixedBuffer
    {
        public ulong e0;
    }

    [InlineArray(2)]
    public partial struct _Wcr_e__FixedBuffer
    {
        public uint e0;
    }

    [InlineArray(2)]
    public partial struct _Wvr_e__FixedBuffer
    {
        public ulong e0;
    }
}
