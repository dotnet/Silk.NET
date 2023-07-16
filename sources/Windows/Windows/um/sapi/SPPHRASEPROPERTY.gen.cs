// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;
/// <include file='SPPHRASEPROPERTY.xml' path='doc/member[@name="SPPHRASEPROPERTY"]/*'/>
public unsafe partial struct SPPHRASEPROPERTY
{
    /// <include file='SPPHRASEPROPERTY.xml' path='doc/member[@name="SPPHRASEPROPERTY.pszName"]/*'/>
    [NativeTypeName("LPCWSTR")]
    public ushort* pszName;
    /// <include file='SPPHRASEPROPERTY.xml' path='doc/member[@name="SPPHRASEPROPERTY.Anonymous"]/*'/>
    [NativeTypeName("__AnonymousRecord_sapi_L5779_C5")]
    public _Anonymous_e__Union Anonymous;
    /// <include file='SPPHRASEPROPERTY.xml' path='doc/member[@name="SPPHRASEPROPERTY.pszValue"]/*'/>
    [NativeTypeName("LPCWSTR")]
    public ushort* pszValue;
    /// <include file='SPPHRASEPROPERTY.xml' path='doc/member[@name="SPPHRASEPROPERTY.vValue"]/*'/>
    public VARIANT vValue;
    /// <include file='SPPHRASEPROPERTY.xml' path='doc/member[@name="SPPHRASEPROPERTY.ulFirstElement"]/*'/>
    [NativeTypeName("ULONG")]
    public uint ulFirstElement;
    /// <include file='SPPHRASEPROPERTY.xml' path='doc/member[@name="SPPHRASEPROPERTY.ulCountOfElements"]/*'/>
    [NativeTypeName("ULONG")]
    public uint ulCountOfElements;
    /// <include file='SPPHRASEPROPERTY.xml' path='doc/member[@name="SPPHRASEPROPERTY.pNextSibling"]/*'/>
    [NativeTypeName("const SPPHRASEPROPERTY *")]
    public SPPHRASEPROPERTY* pNextSibling;
    /// <include file='SPPHRASEPROPERTY.xml' path='doc/member[@name="SPPHRASEPROPERTY.pFirstChild"]/*'/>
    [NativeTypeName("const SPPHRASEPROPERTY *")]
    public SPPHRASEPROPERTY* pFirstChild;
    /// <include file='SPPHRASEPROPERTY.xml' path='doc/member[@name="SPPHRASEPROPERTY.SREngineConfidence"]/*'/>
    public float SREngineConfidence;
    /// <include file='SPPHRASEPROPERTY.xml' path='doc/member[@name="SPPHRASEPROPERTY.Confidence"]/*'/>
    [NativeTypeName("signed char")]
    public sbyte Confidence;
    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.ulId"]/*'/>
    [UnscopedRef]
    public ref uint ulId
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.ulId;
        }
    }

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.bType"]/*'/>
    [UnscopedRef]
    public ref byte bType
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Anonymous.bType;
        }
    }

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.bReserved"]/*'/>
    [UnscopedRef]
    public ref byte bReserved
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Anonymous.bReserved;
        }
    }

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.usArrayIndex"]/*'/>
    [UnscopedRef]
    public ref ushort usArrayIndex
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Anonymous.usArrayIndex;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*'/>
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.ulId"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("ULONG")]
        public uint ulId;
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Anonymous"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_sapi_L5782_C9")]
        public _Anonymous_e__Struct Anonymous;
        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct"]/*'/>
        public partial struct _Anonymous_e__Struct
        {
            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.bType"]/*'/>
            public byte bType;
            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.bReserved"]/*'/>
            public byte bReserved;
            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.usArrayIndex"]/*'/>
            [NativeTypeName("unsigned short")]
            public ushort usArrayIndex;
        }
    }
}