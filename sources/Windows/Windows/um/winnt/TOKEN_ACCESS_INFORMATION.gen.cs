// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='TOKEN_ACCESS_INFORMATION.xml' path='doc/member[@name="TOKEN_ACCESS_INFORMATION"]/*' />
public unsafe partial struct TOKEN_ACCESS_INFORMATION
{
    /// <include file='TOKEN_ACCESS_INFORMATION.xml' path='doc/member[@name="TOKEN_ACCESS_INFORMATION.SidHash"]/*' />
    [NativeTypeName("PSID_AND_ATTRIBUTES_HASH")]
    public SID_AND_ATTRIBUTES_HASH* SidHash;

    /// <include file='TOKEN_ACCESS_INFORMATION.xml' path='doc/member[@name="TOKEN_ACCESS_INFORMATION.RestrictedSidHash"]/*' />
    [NativeTypeName("PSID_AND_ATTRIBUTES_HASH")]
    public SID_AND_ATTRIBUTES_HASH* RestrictedSidHash;

    /// <include file='TOKEN_ACCESS_INFORMATION.xml' path='doc/member[@name="TOKEN_ACCESS_INFORMATION.Privileges"]/*' />
    [NativeTypeName("PTOKEN_PRIVILEGES")]
    public TOKEN_PRIVILEGES* Privileges;

    /// <include file='TOKEN_ACCESS_INFORMATION.xml' path='doc/member[@name="TOKEN_ACCESS_INFORMATION.AuthenticationId"]/*' />
    public LUID AuthenticationId;

    /// <include file='TOKEN_ACCESS_INFORMATION.xml' path='doc/member[@name="TOKEN_ACCESS_INFORMATION.TokenType"]/*' />
    public TOKEN_TYPE TokenType;

    /// <include file='TOKEN_ACCESS_INFORMATION.xml' path='doc/member[@name="TOKEN_ACCESS_INFORMATION.ImpersonationLevel"]/*' />
    public SECURITY_IMPERSONATION_LEVEL ImpersonationLevel;

    /// <include file='TOKEN_ACCESS_INFORMATION.xml' path='doc/member[@name="TOKEN_ACCESS_INFORMATION.MandatoryPolicy"]/*' />
    public TOKEN_MANDATORY_POLICY MandatoryPolicy;

    /// <include file='TOKEN_ACCESS_INFORMATION.xml' path='doc/member[@name="TOKEN_ACCESS_INFORMATION.Flags"]/*' />
    [NativeTypeName("DWORD")]
    public uint Flags;

    /// <include file='TOKEN_ACCESS_INFORMATION.xml' path='doc/member[@name="TOKEN_ACCESS_INFORMATION.AppContainerNumber"]/*' />
    [NativeTypeName("DWORD")]
    public uint AppContainerNumber;

    /// <include file='TOKEN_ACCESS_INFORMATION.xml' path='doc/member[@name="TOKEN_ACCESS_INFORMATION.PackageSid"]/*' />
    [NativeTypeName("PSID")]
    public void* PackageSid;

    /// <include file='TOKEN_ACCESS_INFORMATION.xml' path='doc/member[@name="TOKEN_ACCESS_INFORMATION.CapabilitiesHash"]/*' />
    [NativeTypeName("PSID_AND_ATTRIBUTES_HASH")]
    public SID_AND_ATTRIBUTES_HASH* CapabilitiesHash;

    /// <include file='TOKEN_ACCESS_INFORMATION.xml' path='doc/member[@name="TOKEN_ACCESS_INFORMATION.TrustLevelSid"]/*' />
    [NativeTypeName("PSID")]
    public void* TrustLevelSid;

    /// <include file='TOKEN_ACCESS_INFORMATION.xml' path='doc/member[@name="TOKEN_ACCESS_INFORMATION.SecurityAttributes"]/*' />
    [NativeTypeName("PSECURITY_ATTRIBUTES_OPAQUE")]
    public void* SecurityAttributes;
}
