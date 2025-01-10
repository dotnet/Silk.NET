// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dcommon.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public partial struct D2D_MATRIX_5X4_F
{
    [NativeTypeName("__AnonymousRecord_dcommon_L381_C5")]
    public _Anonymous_e__Union Anonymous;

    [UnscopedRef]
    public ref float _11
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous._11; }
    }

    [UnscopedRef]
    public ref float _12
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous._12; }
    }

    [UnscopedRef]
    public ref float _13
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous._13; }
    }

    [UnscopedRef]
    public ref float _14
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous._14; }
    }

    [UnscopedRef]
    public ref float _21
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous._21; }
    }

    [UnscopedRef]
    public ref float _22
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous._22; }
    }

    [UnscopedRef]
    public ref float _23
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous._23; }
    }

    [UnscopedRef]
    public ref float _24
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous._24; }
    }

    [UnscopedRef]
    public ref float _31
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous._31; }
    }

    [UnscopedRef]
    public ref float _32
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous._32; }
    }

    [UnscopedRef]
    public ref float _33
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous._33; }
    }

    [UnscopedRef]
    public ref float _34
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous._34; }
    }

    [UnscopedRef]
    public ref float _41
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous._41; }
    }

    [UnscopedRef]
    public ref float _42
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous._42; }
    }

    [UnscopedRef]
    public ref float _43
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous._43; }
    }

    [UnscopedRef]
    public ref float _44
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous._44; }
    }

    [UnscopedRef]
    public ref float _51
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous._51; }
    }

    [UnscopedRef]
    public ref float _52
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous._52; }
    }

    [UnscopedRef]
    public ref float _53
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous._53; }
    }

    [UnscopedRef]
    public ref float _54
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous._54; }
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
        [NativeTypeName("__AnonymousRecord_dcommon_L383_C9")]
        public _Anonymous_e__Struct Anonymous;

        [FieldOffset(0)]
        [NativeTypeName("FLOAT[5][4]")]
        public _m_e__FixedBuffer m;

        public partial struct _Anonymous_e__Struct
        {
            public float _11;
            public float _12;
            public float _13;
            public float _14;
            public float _21;
            public float _22;
            public float _23;
            public float _24;
            public float _31;
            public float _32;
            public float _33;
            public float _34;
            public float _41;
            public float _42;
            public float _43;
            public float _44;
            public float _51;
            public float _52;
            public float _53;
            public float _54;
        }

        [InlineArray(5 * 4)]
        public partial struct _m_e__FixedBuffer
        {
            public float e0_0;
        }
    }
}
