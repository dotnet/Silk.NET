// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/oaidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;
/// <include file='ELEMDESC.xml' path='doc/member[@name="ELEMDESC"]/*'/>
public partial struct ELEMDESC
{
    /// <include file='ELEMDESC.xml' path='doc/member[@name="ELEMDESC.tdesc"]/*'/>
    public TYPEDESC tdesc;
    /// <include file='ELEMDESC.xml' path='doc/member[@name="ELEMDESC.Anonymous"]/*'/>
    [NativeTypeName("__AnonymousRecord_oaidl_L733_C5")]
    public _Anonymous_e__Union Anonymous;
    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.idldesc"]/*'/>
    [UnscopedRef]
    public ref IDLDESC idldesc
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.idldesc;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.paramdesc"]/*'/>
    [UnscopedRef]
    public ref PARAMDESC paramdesc
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.paramdesc;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*'/>
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.idldesc"]/*'/>
        [FieldOffset(0)]
        public IDLDESC idldesc;
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.paramdesc"]/*'/>
        [FieldOffset(0)]
        public PARAMDESC paramdesc;
    }
}