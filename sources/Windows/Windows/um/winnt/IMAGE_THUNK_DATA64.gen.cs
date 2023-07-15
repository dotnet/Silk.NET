// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;
/// <include file='IMAGE_THUNK_DATA64.xml' path='doc/member[@name="IMAGE_THUNK_DATA64"]/*'/>
public partial struct IMAGE_THUNK_DATA64
{
    /// <include file='IMAGE_THUNK_DATA64.xml' path='doc/member[@name="IMAGE_THUNK_DATA64.u1"]/*'/>
    [NativeTypeName("__AnonymousRecord_winnt_L19541_C5")]
    public _u1_e__Union u1;
    /// <include file='_u1_e__Union.xml' path='doc/member[@name="_u1_e__Union"]/*'/>
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _u1_e__Union
    {
        /// <include file='_u1_e__Union.xml' path='doc/member[@name="_u1_e__Union.ForwarderString"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("ULONGLONG")]
        public ulong ForwarderString;
        /// <include file='_u1_e__Union.xml' path='doc/member[@name="_u1_e__Union.Function"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("ULONGLONG")]
        public ulong Function;
        /// <include file='_u1_e__Union.xml' path='doc/member[@name="_u1_e__Union.Ordinal"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("ULONGLONG")]
        public ulong Ordinal;
        /// <include file='_u1_e__Union.xml' path='doc/member[@name="_u1_e__Union.AddressOfData"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("ULONGLONG")]
        public ulong AddressOfData;
    }
}