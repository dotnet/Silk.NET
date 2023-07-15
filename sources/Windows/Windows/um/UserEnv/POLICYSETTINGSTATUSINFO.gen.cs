// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/UserEnv.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='POLICYSETTINGSTATUSINFO.xml' path='doc/member[@name="POLICYSETTINGSTATUSINFO"]/*'/>
public unsafe partial struct POLICYSETTINGSTATUSINFO
{
    /// <include file='POLICYSETTINGSTATUSINFO.xml' path='doc/member[@name="POLICYSETTINGSTATUSINFO.szKey"]/*'/>
    [NativeTypeName("LPWSTR")]
    public ushort* szKey;
    /// <include file='POLICYSETTINGSTATUSINFO.xml' path='doc/member[@name="POLICYSETTINGSTATUSINFO.szEventSource"]/*'/>
    [NativeTypeName("LPWSTR")]
    public ushort* szEventSource;
    /// <include file='POLICYSETTINGSTATUSINFO.xml' path='doc/member[@name="POLICYSETTINGSTATUSINFO.szEventLogName"]/*'/>
    [NativeTypeName("LPWSTR")]
    public ushort* szEventLogName;
    /// <include file='POLICYSETTINGSTATUSINFO.xml' path='doc/member[@name="POLICYSETTINGSTATUSINFO.dwEventID"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwEventID;
    /// <include file='POLICYSETTINGSTATUSINFO.xml' path='doc/member[@name="POLICYSETTINGSTATUSINFO.dwErrorCode"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwErrorCode;
    /// <include file='POLICYSETTINGSTATUSINFO.xml' path='doc/member[@name="POLICYSETTINGSTATUSINFO.status"]/*'/>
    public SETTINGSTATUS status;
    /// <include file='POLICYSETTINGSTATUSINFO.xml' path='doc/member[@name="POLICYSETTINGSTATUSINFO.timeLogged"]/*'/>
    public SYSTEMTIME timeLogged;
}