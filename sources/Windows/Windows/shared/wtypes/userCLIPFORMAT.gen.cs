// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/wtypes.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace Silk.NET.Windows;

/// <include file='userCLIPFORMAT.xml' path='doc/member[@name="userCLIPFORMAT"]/*' />
public partial struct userCLIPFORMAT
{
    /// <include file='userCLIPFORMAT.xml' path='doc/member[@name="userCLIPFORMAT.fContext"]/*' />
    [NativeTypeName("LONG")]
    public int fContext;

    /// <include file='userCLIPFORMAT.xml' path='doc/member[@name="userCLIPFORMAT.u"]/*' />
    [NativeTypeName("union __MIDL_IWinTypes_0001")]
    public _u_e__Union u;

    /// <include file='_u_e__Union.xml' path='doc/member[@name="_u_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _u_e__Union
    {
        /// <include file='_u_e__Union.xml' path='doc/member[@name="_u_e__Union.dwValue"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint dwValue;

        /// <include file='_u_e__Union.xml' path='doc/member[@name="_u_e__Union.pwszName"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("wchar_t *")]
        public ushort* pwszName;
    }
}
