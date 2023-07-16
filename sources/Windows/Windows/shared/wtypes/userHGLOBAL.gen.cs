// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/wtypes.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;
/// <include file='userHGLOBAL.xml' path='doc/member[@name="userHGLOBAL"]/*'/>
public partial struct userHGLOBAL
{
    /// <include file='userHGLOBAL.xml' path='doc/member[@name="userHGLOBAL.fContext"]/*'/>
    [NativeTypeName("LONG")]
    public int fContext;
    /// <include file='userHGLOBAL.xml' path='doc/member[@name="userHGLOBAL.u"]/*'/>
    [NativeTypeName("union __MIDL_IWinTypes_0003")]
    public _u_e__Union u;
    /// <include file='_u_e__Union.xml' path='doc/member[@name="_u_e__Union"]/*'/>
    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _u_e__Union
    {
        /// <include file='_u_e__Union.xml' path='doc/member[@name="_u_e__Union.hInproc"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("LONG")]
        public int hInproc;
        /// <include file='_u_e__Union.xml' path='doc/member[@name="_u_e__Union.hRemote"]/*'/>
        [FieldOffset(0)]
        public FLAGGED_BYTE_BLOB* hRemote;
        /// <include file='_u_e__Union.xml' path='doc/member[@name="_u_e__Union.hInproc64"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("long long")]
        public long hInproc64;
    }
}