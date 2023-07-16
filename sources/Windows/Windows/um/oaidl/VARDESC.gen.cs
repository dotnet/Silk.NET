// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/oaidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;
/// <include file='VARDESC.xml' path='doc/member[@name="VARDESC"]/*'/>
public unsafe partial struct VARDESC
{
    /// <include file='VARDESC.xml' path='doc/member[@name="VARDESC.memid"]/*'/>
    [NativeTypeName("MEMBERID")]
    public int memid;
    /// <include file='VARDESC.xml' path='doc/member[@name="VARDESC.lpstrSchema"]/*'/>
    [NativeTypeName("LPOLESTR")]
    public ushort* lpstrSchema;
    /// <include file='VARDESC.xml' path='doc/member[@name="VARDESC.Anonymous"]/*'/>
    [NativeTypeName("__AnonymousRecord_oaidl_L880_C36")]
    public _Anonymous_e__Union Anonymous;
    /// <include file='VARDESC.xml' path='doc/member[@name="VARDESC.elemdescVar"]/*'/>
    public ELEMDESC elemdescVar;
    /// <include file='VARDESC.xml' path='doc/member[@name="VARDESC.wVarFlags"]/*'/>
    [NativeTypeName("WORD")]
    public ushort wVarFlags;
    /// <include file='VARDESC.xml' path='doc/member[@name="VARDESC.varkind"]/*'/>
    public VARKIND varkind;
    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.oInst"]/*'/>
    [UnscopedRef]
    public ref uint oInst
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.oInst;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.lpvarValue"]/*'/>
    [UnscopedRef]
    public ref VARIANT* lpvarValue
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.lpvarValue;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*'/>
    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.oInst"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("ULONG")]
        public uint oInst;
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.lpvarValue"]/*'/>
        [FieldOffset(0)]
        public VARIANT* lpvarValue;
    }
}