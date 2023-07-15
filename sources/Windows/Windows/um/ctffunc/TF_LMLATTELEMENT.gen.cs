// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ctffunc.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;
/// <include file='TF_LMLATTELEMENT.xml' path='doc/member[@name="TF_LMLATTELEMENT"]/*'/>
public unsafe partial struct TF_LMLATTELEMENT
{
    /// <include file='TF_LMLATTELEMENT.xml' path='doc/member[@name="TF_LMLATTELEMENT.dwFrameStart"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwFrameStart;
    /// <include file='TF_LMLATTELEMENT.xml' path='doc/member[@name="TF_LMLATTELEMENT.dwFrameLen"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwFrameLen;
    /// <include file='TF_LMLATTELEMENT.xml' path='doc/member[@name="TF_LMLATTELEMENT.dwFlags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwFlags;
    /// <include file='TF_LMLATTELEMENT.xml' path='doc/member[@name="TF_LMLATTELEMENT.Anonymous"]/*'/>
    [NativeTypeName("__AnonymousRecord_ctffunc_L2394_C36")]
    public _Anonymous_e__Union Anonymous;
    /// <include file='TF_LMLATTELEMENT.xml' path='doc/member[@name="TF_LMLATTELEMENT.bstrText"]/*'/>
    [NativeTypeName("BSTR")]
    public ushort* bstrText;
    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.iCost"]/*'/>
    [UnscopedRef]
    public ref int iCost
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.iCost;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*'/>
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.iCost"]/*'/>
        [FieldOffset(0)]
        public int iCost;
    }
}