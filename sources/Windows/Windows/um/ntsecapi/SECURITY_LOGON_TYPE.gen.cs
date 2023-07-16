// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ntsecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='SECURITY_LOGON_TYPE.xml' path='doc/member[@name="SECURITY_LOGON_TYPE"]/*'/>
public enum SECURITY_LOGON_TYPE
{
    /// <include file='SECURITY_LOGON_TYPE.xml' path='doc/member[@name="SECURITY_LOGON_TYPE.UndefinedLogonType"]/*'/>
    UndefinedLogonType = 0,
    /// <include file='SECURITY_LOGON_TYPE.xml' path='doc/member[@name="SECURITY_LOGON_TYPE.Interactive"]/*'/>
    Interactive = 2,
    /// <include file='SECURITY_LOGON_TYPE.xml' path='doc/member[@name="SECURITY_LOGON_TYPE.Network"]/*'/>
    Network,
    /// <include file='SECURITY_LOGON_TYPE.xml' path='doc/member[@name="SECURITY_LOGON_TYPE.Batch"]/*'/>
    Batch,
    /// <include file='SECURITY_LOGON_TYPE.xml' path='doc/member[@name="SECURITY_LOGON_TYPE.Service"]/*'/>
    Service,
    /// <include file='SECURITY_LOGON_TYPE.xml' path='doc/member[@name="SECURITY_LOGON_TYPE.Proxy"]/*'/>
    Proxy,
    /// <include file='SECURITY_LOGON_TYPE.xml' path='doc/member[@name="SECURITY_LOGON_TYPE.Unlock"]/*'/>
    Unlock,
    /// <include file='SECURITY_LOGON_TYPE.xml' path='doc/member[@name="SECURITY_LOGON_TYPE.NetworkCleartext"]/*'/>
    NetworkCleartext,
    /// <include file='SECURITY_LOGON_TYPE.xml' path='doc/member[@name="SECURITY_LOGON_TYPE.NewCredentials"]/*'/>
    NewCredentials,
    /// <include file='SECURITY_LOGON_TYPE.xml' path='doc/member[@name="SECURITY_LOGON_TYPE.RemoteInteractive"]/*'/>
    RemoteInteractive,
    /// <include file='SECURITY_LOGON_TYPE.xml' path='doc/member[@name="SECURITY_LOGON_TYPE.CachedInteractive"]/*'/>
    CachedInteractive,
    /// <include file='SECURITY_LOGON_TYPE.xml' path='doc/member[@name="SECURITY_LOGON_TYPE.CachedRemoteInteractive"]/*'/>
    CachedRemoteInteractive,
    /// <include file='SECURITY_LOGON_TYPE.xml' path='doc/member[@name="SECURITY_LOGON_TYPE.CachedUnlock"]/*'/>
    CachedUnlock,
}