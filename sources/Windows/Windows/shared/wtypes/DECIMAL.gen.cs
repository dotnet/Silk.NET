// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/wtypes.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;
/// <include file='DECIMAL.xml' path='doc/member[@name="DECIMAL"]/*'/>
public partial struct DECIMAL
{
    /// <include file='DECIMAL.xml' path='doc/member[@name="DECIMAL.wReserved"]/*'/>
    public ushort wReserved;
    /// <include file='DECIMAL.xml' path='doc/member[@name="DECIMAL.Anonymous1"]/*'/>
    [NativeTypeName("__AnonymousRecord_wtypes_L705_C5")]
    public _Anonymous1_e__Union Anonymous1;
    /// <include file='DECIMAL.xml' path='doc/member[@name="DECIMAL.Hi32"]/*'/>
    [NativeTypeName("ULONG")]
    public uint Hi32;
    /// <include file='DECIMAL.xml' path='doc/member[@name="DECIMAL.Anonymous2"]/*'/>
    [NativeTypeName("__AnonymousRecord_wtypes_L713_C5")]
    public _Anonymous2_e__Union Anonymous2;
    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.scale"]/*'/>
    [UnscopedRef]
    public ref byte scale
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous1.Anonymous.scale;
        }
    }

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.sign"]/*'/>
    [UnscopedRef]
    public ref byte sign
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous1.Anonymous.sign;
        }
    }

    /// <include file='_Anonymous1_e__Union.xml' path='doc/member[@name="_Anonymous1_e__Union.signscale"]/*'/>
    [UnscopedRef]
    public ref ushort signscale
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous1.signscale;
        }
    }

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.Lo32"]/*'/>
    [UnscopedRef]
    public ref uint Lo32
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous2.Anonymous.Lo32;
        }
    }

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.Mid32"]/*'/>
    [UnscopedRef]
    public ref uint Mid32
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous2.Anonymous.Mid32;
        }
    }

    /// <include file='_Anonymous2_e__Union.xml' path='doc/member[@name="_Anonymous2_e__Union.Lo64"]/*'/>
    [UnscopedRef]
    public ref ulong Lo64
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous2.Lo64;
        }
    }

    /// <include file='_Anonymous1_e__Union.xml' path='doc/member[@name="_Anonymous1_e__Union"]/*'/>
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous1_e__Union
    {
        /// <include file='_Anonymous1_e__Union.xml' path='doc/member[@name="_Anonymous1_e__Union.Anonymous"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_wtypes_L706_C9")]
        public _Anonymous_e__Struct Anonymous;
        /// <include file='_Anonymous1_e__Union.xml' path='doc/member[@name="_Anonymous1_e__Union.signscale"]/*'/>
        [FieldOffset(0)]
        public ushort signscale;
        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct"]/*'/>
        public partial struct _Anonymous_e__Struct
        {
            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.scale"]/*'/>
            public byte scale;
            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.sign"]/*'/>
            public byte sign;
        }
    }

    /// <include file='_Anonymous2_e__Union.xml' path='doc/member[@name="_Anonymous2_e__Union"]/*'/>
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous2_e__Union
    {
        /// <include file='_Anonymous2_e__Union.xml' path='doc/member[@name="_Anonymous2_e__Union.Anonymous"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_wtypes_L714_C9")]
        public _Anonymous_e__Struct Anonymous;
        /// <include file='_Anonymous2_e__Union.xml' path='doc/member[@name="_Anonymous2_e__Union.Lo64"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("ULONGLONG")]
        public ulong Lo64;
        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct"]/*'/>
        public partial struct _Anonymous_e__Struct
        {
            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.Lo32"]/*'/>
            [NativeTypeName("ULONG")]
            public uint Lo32;
            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.Mid32"]/*'/>
            [NativeTypeName("ULONG")]
            public uint Mid32;
        }
    }
}