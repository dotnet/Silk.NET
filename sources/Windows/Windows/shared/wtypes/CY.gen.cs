// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/wtypes.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;
/// <include file='CY.xml' path='doc/member[@name="CY"]/*'/>
[StructLayout(LayoutKind.Explicit)]
public partial struct CY
{
    /// <include file='CY.xml' path='doc/member[@name="CY.Anonymous"]/*'/>
    [FieldOffset(0)]
    [NativeTypeName("__AnonymousRecord_wtypes_L679_C5")]
    public _Anonymous_e__Struct Anonymous;
    /// <include file='CY.xml' path='doc/member[@name="CY.int64"]/*'/>
    [FieldOffset(0)]
    [NativeTypeName("LONGLONG")]
    public long int64;
    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.Lo"]/*'/>
    [UnscopedRef]
    public ref uint Lo
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Lo;
        }
    }

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.Hi"]/*'/>
    [UnscopedRef]
    public ref int Hi
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Hi;
        }
    }

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct"]/*'/>
    public partial struct _Anonymous_e__Struct
    {
        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.Lo"]/*'/>
        [NativeTypeName("ULONG")]
        public uint Lo;
        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.Hi"]/*'/>
        [NativeTypeName("LONG")]
        public int Hi;
    }
}