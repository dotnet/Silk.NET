// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dcommon.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public partial struct D2D_MATRIX_3X2_F
{
    [NativeTypeName("__AnonymousRecord_dcommon_L285_C5")]
    public _Anonymous_e__Union Anonymous;

    [UnscopedRef]
    public ref float m11
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous1.m11; }
    }

    [UnscopedRef]
    public ref float m12
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous1.m12; }
    }

    [UnscopedRef]
    public ref float m21
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous1.m21; }
    }

    [UnscopedRef]
    public ref float m22
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous1.m22; }
    }

    [UnscopedRef]
    public ref float dx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous1.dx; }
    }

    [UnscopedRef]
    public ref float dy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous1.dy; }
    }

    [UnscopedRef]
    public ref float _11
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous2._11; }
    }

    [UnscopedRef]
    public ref float _12
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous2._12; }
    }

    [UnscopedRef]
    public ref float _21
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous2._21; }
    }

    [UnscopedRef]
    public ref float _22
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous2._22; }
    }

    [UnscopedRef]
    public ref float _31
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous2._31; }
    }

    [UnscopedRef]
    public ref float _32
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous2._32; }
    }

    [UnscopedRef]
    public Span<float> m
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return Anonymous.m; }
    }

    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_dcommon_L287_C9")]
        public _Anonymous1_e__Struct Anonymous1;

        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_dcommon_L320_C9")]
        public _Anonymous2_e__Struct Anonymous2;

        [FieldOffset(0)]
        [NativeTypeName("FLOAT[3][2]")]
        public _m_e__FixedBuffer m;

        public partial struct _Anonymous1_e__Struct
        {
            public float m11;
            public float m12;
            public float m21;
            public float m22;
            public float dx;
            public float dy;
        }

        public partial struct _Anonymous2_e__Struct
        {
            public float _11;
            public float _12;
            public float _21;
            public float _22;
            public float _31;
            public float _32;
        }

        [InlineArray(3 * 2)]
        public partial struct _m_e__FixedBuffer
        {
            public float e0_0;
        }
    }
}
