// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ntsecapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public unsafe partial struct SECURITY_LOGON_SESSION_DATA
{
    [NativeTypeName("ULONG")]
    public uint Size;
    public LUID LogonId;
    public LSA_UNICODE_STRING UserName;
    public LSA_UNICODE_STRING LogonDomain;
    public LSA_UNICODE_STRING AuthenticationPackage;

    [NativeTypeName("ULONG")]
    public uint LogonType;

    [NativeTypeName("ULONG")]
    public uint Session;

    [NativeTypeName("PSID")]
    public void* Sid;
    public LARGE_INTEGER LogonTime;
    public LSA_UNICODE_STRING LogonServer;
    public LSA_UNICODE_STRING DnsDomainName;
    public LSA_UNICODE_STRING Upn;

    [NativeTypeName("ULONG")]
    public uint UserFlags;
    public LSA_LAST_INTER_LOGON_INFO LastLogonInfo;
    public LSA_UNICODE_STRING LogonScript;
    public LSA_UNICODE_STRING ProfilePath;
    public LSA_UNICODE_STRING HomeDirectory;
    public LSA_UNICODE_STRING HomeDirectoryDrive;
    public LARGE_INTEGER LogoffTime;
    public LARGE_INTEGER KickOffTime;
    public LARGE_INTEGER PasswordLastSet;
    public LARGE_INTEGER PasswordCanChange;
    public LARGE_INTEGER PasswordMustChange;
}
