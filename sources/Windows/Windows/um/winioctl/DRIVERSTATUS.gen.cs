// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;
/// <include file='DRIVERSTATUS.xml' path='doc/member[@name="DRIVERSTATUS"]/*'/>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe partial struct DRIVERSTATUS
{
    /// <include file='DRIVERSTATUS.xml' path='doc/member[@name="DRIVERSTATUS.bDriverError"]/*'/>
    public byte bDriverError;
    /// <include file='DRIVERSTATUS.xml' path='doc/member[@name="DRIVERSTATUS.bIDEError"]/*'/>
    public byte bIDEError;
    /// <include file='DRIVERSTATUS.xml' path='doc/member[@name="DRIVERSTATUS.bReserved"]/*'/>
    [NativeTypeName("BYTE[2]")]
    public fixed byte bReserved[2];
    /// <include file='DRIVERSTATUS.xml' path='doc/member[@name="DRIVERSTATUS.dwReserved"]/*'/>
    [NativeTypeName("DWORD[2]")]
    public fixed uint dwReserved[2];
}