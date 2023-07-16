// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;
/// <include file='SENDCMDINPARAMS.xml' path='doc/member[@name="SENDCMDINPARAMS"]/*'/>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe partial struct SENDCMDINPARAMS
{
    /// <include file='SENDCMDINPARAMS.xml' path='doc/member[@name="SENDCMDINPARAMS.cBufferSize"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cBufferSize;
    /// <include file='SENDCMDINPARAMS.xml' path='doc/member[@name="SENDCMDINPARAMS.irDriveRegs"]/*'/>
    public IDEREGS irDriveRegs;
    /// <include file='SENDCMDINPARAMS.xml' path='doc/member[@name="SENDCMDINPARAMS.bDriveNumber"]/*'/>
    public byte bDriveNumber;
    /// <include file='SENDCMDINPARAMS.xml' path='doc/member[@name="SENDCMDINPARAMS.bReserved"]/*'/>
    [NativeTypeName("BYTE[3]")]
    public fixed byte bReserved[3];
    /// <include file='SENDCMDINPARAMS.xml' path='doc/member[@name="SENDCMDINPARAMS.dwReserved"]/*'/>
    [NativeTypeName("DWORD[4]")]
    public fixed uint dwReserved[4];
    /// <include file='SENDCMDINPARAMS.xml' path='doc/member[@name="SENDCMDINPARAMS.bBuffer"]/*'/>
    [NativeTypeName("BYTE[1]")]
    public fixed byte bBuffer[1];
}