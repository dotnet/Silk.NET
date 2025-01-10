// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct SE_TOKEN_USER
{
    [NativeTypeName("__AnonymousRecord_winnt_L12112_C5")]
    public _Anonymous1_e__Union Anonymous1;

    [NativeTypeName("__AnonymousRecord_winnt_L12117_C5")]
    public _Anonymous2_e__Union Anonymous2;

    [UnscopedRef]
    public ref TOKEN_USER TokenUser
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous1.TokenUser; }
    }

    [UnscopedRef]
    public ref SID_AND_ATTRIBUTES User
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous1.User; }
    }

    [UnscopedRef]
    public ref SID Sid
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous2.Sid; }
    }

    [UnscopedRef]
    public Span<byte> Buffer
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return Anonymous2.Buffer; }
    }

    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous1_e__Union
    {
        [FieldOffset(0)]
        public TOKEN_USER TokenUser;

        [FieldOffset(0)]
        public SID_AND_ATTRIBUTES User;
    }

    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous2_e__Union
    {
        [FieldOffset(0)]
        public SID Sid;

        [FieldOffset(0)]
        [NativeTypeName("BYTE[68]")]
        public _Buffer_e__FixedBuffer Buffer;

        [InlineArray(68)]
        public partial struct _Buffer_e__FixedBuffer
        {
            public byte e0;
        }
    }
}
