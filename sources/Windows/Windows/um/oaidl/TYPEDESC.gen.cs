// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/oaidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;
/// <include file='TYPEDESC.xml' path='doc/member[@name="TYPEDESC"]/*'/>
public unsafe partial struct TYPEDESC
{
    /// <include file='TYPEDESC.xml' path='doc/member[@name="TYPEDESC.Anonymous"]/*'/>
    [NativeTypeName("__AnonymousRecord_oaidl_L653_C36")]
    public _Anonymous_e__Union Anonymous;
    /// <include file='TYPEDESC.xml' path='doc/member[@name="TYPEDESC.vt"]/*'/>
    [NativeTypeName("VARTYPE")]
    public ushort vt;
    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.lptdesc"]/*'/>
    [UnscopedRef]
    public ref TYPEDESC* lptdesc
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.lptdesc;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.lpadesc"]/*'/>
    [UnscopedRef]
    public ref ARRAYDESC* lpadesc
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.lpadesc;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.hreftype"]/*'/>
    [UnscopedRef]
    public ref uint hreftype
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.hreftype;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*'/>
    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.lptdesc"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("struct tagTYPEDESC *")]
        public TYPEDESC* lptdesc;
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.lpadesc"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("struct tagARRAYDESC *")]
        public ARRAYDESC* lpadesc;
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.hreftype"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("HREFTYPE")]
        public uint hreftype;
    }
}