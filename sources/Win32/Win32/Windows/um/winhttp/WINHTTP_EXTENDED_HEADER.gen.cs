// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winhttp.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public unsafe partial struct WINHTTP_EXTENDED_HEADER
{
    [NativeTypeName("__AnonymousRecord_winhttp_L514_C5")]
    public _Anonymous1_e__Union Anonymous1;

    [NativeTypeName("__AnonymousRecord_winhttp_L519_C5")]
    public _Anonymous2_e__Union Anonymous2;

    [UnscopedRef]
    public ref ushort* pwszName
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous1.pwszName; }
    }

    [UnscopedRef]
    public ref sbyte* pszName
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous1.pszName; }
    }

    [UnscopedRef]
    public ref ushort* pwszValue
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous2.pwszValue; }
    }

    [UnscopedRef]
    public ref sbyte* pszValue
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous2.pszValue; }
    }

    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _Anonymous1_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("PCWSTR")]
        public ushort* pwszName;

        [FieldOffset(0)]
        [NativeTypeName("PCSTR")]
        public sbyte* pszName;
    }

    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _Anonymous2_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("PCWSTR")]
        public ushort* pwszValue;

        [FieldOffset(0)]
        [NativeTypeName("PCSTR")]
        public sbyte* pszValue;
    }
}
