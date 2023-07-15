// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;
/// <include file='TVINSERTSTRUCTA.xml' path='doc/member[@name="TVINSERTSTRUCTA"]/*'/>
public partial struct TVINSERTSTRUCTA
{
    /// <include file='TVINSERTSTRUCTA.xml' path='doc/member[@name="TVINSERTSTRUCTA.hParent"]/*'/>
    public HTREEITEM hParent;
    /// <include file='TVINSERTSTRUCTA.xml' path='doc/member[@name="TVINSERTSTRUCTA.hInsertAfter"]/*'/>
    public HTREEITEM hInsertAfter;
    /// <include file='TVINSERTSTRUCTA.xml' path='doc/member[@name="TVINSERTSTRUCTA.Anonymous"]/*'/>
    [NativeTypeName("__AnonymousRecord_CommCtrl_L5001_C5")]
    public _Anonymous_e__Union Anonymous;
    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.itemex"]/*'/>
    [UnscopedRef]
    public ref TVITEMEXA itemex
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.itemex;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.item"]/*'/>
    [UnscopedRef]
    public ref TVITEMA item
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.item;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*'/>
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.itemex"]/*'/>
        [FieldOffset(0)]
        public TVITEMEXA itemex;
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.item"]/*'/>
        [FieldOffset(0)]
        public TVITEMA item;
    }
}