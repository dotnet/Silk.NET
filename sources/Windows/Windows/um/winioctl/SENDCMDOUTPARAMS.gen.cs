// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;
/// <include file='SENDCMDOUTPARAMS.xml' path='doc/member[@name="SENDCMDOUTPARAMS"]/*'/>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe partial struct SENDCMDOUTPARAMS
{
    /// <include file='SENDCMDOUTPARAMS.xml' path='doc/member[@name="SENDCMDOUTPARAMS.cBufferSize"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cBufferSize;
    /// <include file='SENDCMDOUTPARAMS.xml' path='doc/member[@name="SENDCMDOUTPARAMS.DriverStatus"]/*'/>
    public DRIVERSTATUS DriverStatus;
    /// <include file='SENDCMDOUTPARAMS.xml' path='doc/member[@name="SENDCMDOUTPARAMS.bBuffer"]/*'/>
    [NativeTypeName("BYTE[1]")]
    public fixed byte bBuffer[1];
}