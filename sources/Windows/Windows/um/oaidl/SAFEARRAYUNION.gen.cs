// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/oaidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;
/// <include file='SAFEARRAYUNION.xml' path='doc/member[@name="SAFEARRAYUNION"]/*'/>
public partial struct SAFEARRAYUNION
{
    /// <include file='SAFEARRAYUNION.xml' path='doc/member[@name="SAFEARRAYUNION.sfType"]/*'/>
    [NativeTypeName("ULONG")]
    public uint sfType;
    /// <include file='SAFEARRAYUNION.xml' path='doc/member[@name="SAFEARRAYUNION.u"]/*'/>
    [NativeTypeName("union __MIDL_IOleAutomationTypes_0001")]
    public _u_e__Union u;
    /// <include file='_u_e__Union.xml' path='doc/member[@name="_u_e__Union"]/*'/>
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _u_e__Union
    {
        /// <include file='_u_e__Union.xml' path='doc/member[@name="_u_e__Union.BstrStr"]/*'/>
        [FieldOffset(0)]
        public SAFEARR_BSTR BstrStr;
        /// <include file='_u_e__Union.xml' path='doc/member[@name="_u_e__Union.UnknownStr"]/*'/>
        [FieldOffset(0)]
        public SAFEARR_UNKNOWN UnknownStr;
        /// <include file='_u_e__Union.xml' path='doc/member[@name="_u_e__Union.DispatchStr"]/*'/>
        [FieldOffset(0)]
        public SAFEARR_DISPATCH DispatchStr;
        /// <include file='_u_e__Union.xml' path='doc/member[@name="_u_e__Union.VariantStr"]/*'/>
        [FieldOffset(0)]
        public SAFEARR_VARIANT VariantStr;
        /// <include file='_u_e__Union.xml' path='doc/member[@name="_u_e__Union.RecordStr"]/*'/>
        [FieldOffset(0)]
        public SAFEARR_BRECORD RecordStr;
        /// <include file='_u_e__Union.xml' path='doc/member[@name="_u_e__Union.HaveIidStr"]/*'/>
        [FieldOffset(0)]
        public SAFEARR_HAVEIID HaveIidStr;
        /// <include file='_u_e__Union.xml' path='doc/member[@name="_u_e__Union.ByteStr"]/*'/>
        [FieldOffset(0)]
        public BYTE_SIZEDARR ByteStr;
        /// <include file='_u_e__Union.xml' path='doc/member[@name="_u_e__Union.WordStr"]/*'/>
        [FieldOffset(0)]
        public WORD_SIZEDARR WordStr;
        /// <include file='_u_e__Union.xml' path='doc/member[@name="_u_e__Union.LongStr"]/*'/>
        [FieldOffset(0)]
        public DWORD_SIZEDARR LongStr;
        /// <include file='_u_e__Union.xml' path='doc/member[@name="_u_e__Union.HyperStr"]/*'/>
        [FieldOffset(0)]
        public HYPER_SIZEDARR HyperStr;
    }
}