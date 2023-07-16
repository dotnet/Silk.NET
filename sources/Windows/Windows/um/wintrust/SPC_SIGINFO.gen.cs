// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinTrust.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;

namespace Silk.NET.Windows;
/// <include file='SPC_SIGINFO.xml' path='doc/member[@name="SPC_SIGINFO"]/*'/>
public partial struct SPC_SIGINFO
{
    /// <include file='SPC_SIGINFO.xml' path='doc/member[@name="SPC_SIGINFO.dwSipVersion"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwSipVersion;
    /// <include file='SPC_SIGINFO.xml' path='doc/member[@name="SPC_SIGINFO.gSIPGuid"]/*'/>
    public Guid gSIPGuid;
    /// <include file='SPC_SIGINFO.xml' path='doc/member[@name="SPC_SIGINFO.dwReserved1"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwReserved1;
    /// <include file='SPC_SIGINFO.xml' path='doc/member[@name="SPC_SIGINFO.dwReserved2"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwReserved2;
    /// <include file='SPC_SIGINFO.xml' path='doc/member[@name="SPC_SIGINFO.dwReserved3"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwReserved3;
    /// <include file='SPC_SIGINFO.xml' path='doc/member[@name="SPC_SIGINFO.dwReserved4"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwReserved4;
    /// <include file='SPC_SIGINFO.xml' path='doc/member[@name="SPC_SIGINFO.dwReserved5"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwReserved5;
}