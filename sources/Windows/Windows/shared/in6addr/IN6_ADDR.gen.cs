// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/in6addr.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;
/// <include file='IN6_ADDR.xml' path='doc/member[@name="IN6_ADDR"]/*'/>
public partial struct IN6_ADDR
{
    /// <include file='IN6_ADDR.xml' path='doc/member[@name="IN6_ADDR.u"]/*'/>
    [NativeTypeName("__AnonymousRecord_in6addr_L26_C5")]
    public _u_e__Union u;
    /// <include file='_u_e__Union.xml' path='doc/member[@name="_u_e__Union"]/*'/>
    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _u_e__Union
    {
        /// <include file='_u_e__Union.xml' path='doc/member[@name="_u_e__Union.Byte"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("UCHAR[16]")]
        public fixed byte Byte[16];
        /// <include file='_u_e__Union.xml' path='doc/member[@name="_u_e__Union.Word"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("USHORT[8]")]
        public fixed ushort Word[8];
    }
}