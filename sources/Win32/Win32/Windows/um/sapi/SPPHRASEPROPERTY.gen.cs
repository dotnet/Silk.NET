// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public unsafe partial struct SPPHRASEPROPERTY
{
    [NativeTypeName("LPCWSTR")]
    public ushort* pszName;

    [NativeTypeName("__AnonymousRecord_sapi_L5779_C5")]
    public _Anonymous_e__Union Anonymous;

    [NativeTypeName("LPCWSTR")]
    public ushort* pszValue;
    public VARIANT vValue;

    [NativeTypeName("ULONG")]
    public uint ulFirstElement;

    [NativeTypeName("ULONG")]
    public uint ulCountOfElements;

    [NativeTypeName("const SPPHRASEPROPERTY *")]
    public SPPHRASEPROPERTY* pNextSibling;

    [NativeTypeName("const SPPHRASEPROPERTY *")]
    public SPPHRASEPROPERTY* pFirstChild;
    public float SREngineConfidence;

    [NativeTypeName("signed char")]
    public sbyte Confidence;

    [UnscopedRef]
    public ref uint ulId
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.ulId; }
    }

    [UnscopedRef]
    public ref byte bType
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.bType; }
    }

    [UnscopedRef]
    public ref byte bReserved
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.bReserved; }
    }

    [UnscopedRef]
    public ref ushort usArrayIndex
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.usArrayIndex; }
    }

    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("ULONG")]
        public uint ulId;

        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_sapi_L5782_C9")]
        public _Anonymous_e__Struct Anonymous;

        public partial struct _Anonymous_e__Struct
        {
            public byte bType;
            public byte bReserved;

            [NativeTypeName("unsigned short")]
            public ushort usArrayIndex;
        }
    }
}
