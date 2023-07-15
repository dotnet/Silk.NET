// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/msctf.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;
/// <include file='TF_DA_COLOR.xml' path='doc/member[@name="TF_DA_COLOR"]/*'/>
public partial struct TF_DA_COLOR
{
    /// <include file='TF_DA_COLOR.xml' path='doc/member[@name="TF_DA_COLOR.type"]/*'/>
    public TF_DA_COLORTYPE type;
    /// <include file='TF_DA_COLOR.xml' path='doc/member[@name="TF_DA_COLOR.Anonymous"]/*'/>
    [NativeTypeName("__AnonymousRecord_msctf_L10803_C36")]
    public _Anonymous_e__Union Anonymous;
    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.nIndex"]/*'/>
    [UnscopedRef]
    public ref int nIndex
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.nIndex;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.cr"]/*'/>
    [UnscopedRef]
    public ref COLORREF cr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.cr;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*'/>
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.nIndex"]/*'/>
        [FieldOffset(0)]
        public int nIndex;
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.cr"]/*'/>
        [FieldOffset(0)]
        public COLORREF cr;
    }
}