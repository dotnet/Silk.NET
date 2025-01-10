// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/wtypes.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct DECIMAL
{
    public ushort wReserved;

    [NativeTypeName("__AnonymousRecord_wtypes_L705_C5")]
    public _Anonymous1_e__Union Anonymous1;

    [NativeTypeName("ULONG")]
    public uint Hi32;

    [NativeTypeName("__AnonymousRecord_wtypes_L713_C5")]
    public _Anonymous2_e__Union Anonymous2;

    [UnscopedRef]
    public ref byte scale
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous1.Anonymous.scale; }
    }

    [UnscopedRef]
    public ref byte sign
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous1.Anonymous.sign; }
    }

    [UnscopedRef]
    public ref ushort signscale
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous1.signscale; }
    }

    [UnscopedRef]
    public ref uint Lo32
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous2.Anonymous.Lo32; }
    }

    [UnscopedRef]
    public ref uint Mid32
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous2.Anonymous.Mid32; }
    }

    [UnscopedRef]
    public ref ulong Lo64
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous2.Lo64; }
    }

    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous1_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_wtypes_L706_C9")]
        public _Anonymous_e__Struct Anonymous;

        [FieldOffset(0)]
        public ushort signscale;

        public partial struct _Anonymous_e__Struct
        {
            public byte scale;
            public byte sign;
        }
    }

    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous2_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_wtypes_L714_C9")]
        public _Anonymous_e__Struct Anonymous;

        [FieldOffset(0)]
        [NativeTypeName("ULONGLONG")]
        public ulong Lo64;

        public partial struct _Anonymous_e__Struct
        {
            [NativeTypeName("ULONG")]
            public uint Lo32;

            [NativeTypeName("ULONG")]
            public uint Mid32;
        }
    }
}
