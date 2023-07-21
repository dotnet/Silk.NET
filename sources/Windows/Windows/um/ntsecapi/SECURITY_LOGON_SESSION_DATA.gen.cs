// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ntsecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='SECURITY_LOGON_SESSION_DATA.xml' path='doc/member[@name="SECURITY_LOGON_SESSION_DATA"]/*' />
public unsafe partial struct SECURITY_LOGON_SESSION_DATA
{
    /// <include file='SECURITY_LOGON_SESSION_DATA.xml' path='doc/member[@name="SECURITY_LOGON_SESSION_DATA.Size"]/*' />
    [NativeTypeName("ULONG")]
    public uint Size;

    /// <include file='SECURITY_LOGON_SESSION_DATA.xml' path='doc/member[@name="SECURITY_LOGON_SESSION_DATA.LogonId"]/*' />
    public LUID LogonId;

    /// <include file='SECURITY_LOGON_SESSION_DATA.xml' path='doc/member[@name="SECURITY_LOGON_SESSION_DATA.UserName"]/*' />
    public LSA_UNICODE_STRING UserName;

    /// <include file='SECURITY_LOGON_SESSION_DATA.xml' path='doc/member[@name="SECURITY_LOGON_SESSION_DATA.LogonDomain"]/*' />
    public LSA_UNICODE_STRING LogonDomain;

    /// <include file='SECURITY_LOGON_SESSION_DATA.xml' path='doc/member[@name="SECURITY_LOGON_SESSION_DATA.AuthenticationPackage"]/*' />
    public LSA_UNICODE_STRING AuthenticationPackage;

    /// <include file='SECURITY_LOGON_SESSION_DATA.xml' path='doc/member[@name="SECURITY_LOGON_SESSION_DATA.LogonType"]/*' />
    [NativeTypeName("ULONG")]
    public uint LogonType;

    /// <include file='SECURITY_LOGON_SESSION_DATA.xml' path='doc/member[@name="SECURITY_LOGON_SESSION_DATA.Session"]/*' />
    [NativeTypeName("ULONG")]
    public uint Session;

    /// <include file='SECURITY_LOGON_SESSION_DATA.xml' path='doc/member[@name="SECURITY_LOGON_SESSION_DATA.Sid"]/*' />
    [NativeTypeName("PSID")]
    public void* Sid;

    /// <include file='SECURITY_LOGON_SESSION_DATA.xml' path='doc/member[@name="SECURITY_LOGON_SESSION_DATA.LogonTime"]/*' />
    public LARGE_INTEGER LogonTime;

    /// <include file='SECURITY_LOGON_SESSION_DATA.xml' path='doc/member[@name="SECURITY_LOGON_SESSION_DATA.LogonServer"]/*' />
    public LSA_UNICODE_STRING LogonServer;

    /// <include file='SECURITY_LOGON_SESSION_DATA.xml' path='doc/member[@name="SECURITY_LOGON_SESSION_DATA.DnsDomainName"]/*' />
    public LSA_UNICODE_STRING DnsDomainName;

    /// <include file='SECURITY_LOGON_SESSION_DATA.xml' path='doc/member[@name="SECURITY_LOGON_SESSION_DATA.Upn"]/*' />
    public LSA_UNICODE_STRING Upn;

    /// <include file='SECURITY_LOGON_SESSION_DATA.xml' path='doc/member[@name="SECURITY_LOGON_SESSION_DATA.UserFlags"]/*' />
    [NativeTypeName("ULONG")]
    public uint UserFlags;

    /// <include file='SECURITY_LOGON_SESSION_DATA.xml' path='doc/member[@name="SECURITY_LOGON_SESSION_DATA.LastLogonInfo"]/*' />
    public LSA_LAST_INTER_LOGON_INFO LastLogonInfo;

    /// <include file='SECURITY_LOGON_SESSION_DATA.xml' path='doc/member[@name="SECURITY_LOGON_SESSION_DATA.LogonScript"]/*' />
    public LSA_UNICODE_STRING LogonScript;

    /// <include file='SECURITY_LOGON_SESSION_DATA.xml' path='doc/member[@name="SECURITY_LOGON_SESSION_DATA.ProfilePath"]/*' />
    public LSA_UNICODE_STRING ProfilePath;

    /// <include file='SECURITY_LOGON_SESSION_DATA.xml' path='doc/member[@name="SECURITY_LOGON_SESSION_DATA.HomeDirectory"]/*' />
    public LSA_UNICODE_STRING HomeDirectory;

    /// <include file='SECURITY_LOGON_SESSION_DATA.xml' path='doc/member[@name="SECURITY_LOGON_SESSION_DATA.HomeDirectoryDrive"]/*' />
    public LSA_UNICODE_STRING HomeDirectoryDrive;

    /// <include file='SECURITY_LOGON_SESSION_DATA.xml' path='doc/member[@name="SECURITY_LOGON_SESSION_DATA.LogoffTime"]/*' />
    public LARGE_INTEGER LogoffTime;

    /// <include file='SECURITY_LOGON_SESSION_DATA.xml' path='doc/member[@name="SECURITY_LOGON_SESSION_DATA.KickOffTime"]/*' />
    public LARGE_INTEGER KickOffTime;

    /// <include file='SECURITY_LOGON_SESSION_DATA.xml' path='doc/member[@name="SECURITY_LOGON_SESSION_DATA.PasswordLastSet"]/*' />
    public LARGE_INTEGER PasswordLastSet;

    /// <include file='SECURITY_LOGON_SESSION_DATA.xml' path='doc/member[@name="SECURITY_LOGON_SESSION_DATA.PasswordCanChange"]/*' />
    public LARGE_INTEGER PasswordCanChange;

    /// <include file='SECURITY_LOGON_SESSION_DATA.xml' path='doc/member[@name="SECURITY_LOGON_SESSION_DATA.PasswordMustChange"]/*' />
    public LARGE_INTEGER PasswordMustChange;
}
