// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='TOKEN_INFORMATION_CLASS.xml' path='doc/member[@name="TOKEN_INFORMATION_CLASS"]/*' />
public enum TOKEN_INFORMATION_CLASS
{
    /// <include file='TOKEN_INFORMATION_CLASS.xml' path='doc/member[@name="TOKEN_INFORMATION_CLASS.TokenUser"]/*' />
    TokenUser = 1,

    /// <include file='TOKEN_INFORMATION_CLASS.xml' path='doc/member[@name="TOKEN_INFORMATION_CLASS.TokenGroups"]/*' />
    TokenGroups,

    /// <include file='TOKEN_INFORMATION_CLASS.xml' path='doc/member[@name="TOKEN_INFORMATION_CLASS.TokenPrivileges"]/*' />
    TokenPrivileges,

    /// <include file='TOKEN_INFORMATION_CLASS.xml' path='doc/member[@name="TOKEN_INFORMATION_CLASS.TokenOwner"]/*' />
    TokenOwner,

    /// <include file='TOKEN_INFORMATION_CLASS.xml' path='doc/member[@name="TOKEN_INFORMATION_CLASS.TokenPrimaryGroup"]/*' />
    TokenPrimaryGroup,

    /// <include file='TOKEN_INFORMATION_CLASS.xml' path='doc/member[@name="TOKEN_INFORMATION_CLASS.TokenDefaultDacl"]/*' />
    TokenDefaultDacl,

    /// <include file='TOKEN_INFORMATION_CLASS.xml' path='doc/member[@name="TOKEN_INFORMATION_CLASS.TokenSource"]/*' />
    TokenSource,

    /// <include file='TOKEN_INFORMATION_CLASS.xml' path='doc/member[@name="TOKEN_INFORMATION_CLASS.TokenType"]/*' />
    TokenType,

    /// <include file='TOKEN_INFORMATION_CLASS.xml' path='doc/member[@name="TOKEN_INFORMATION_CLASS.TokenImpersonationLevel"]/*' />
    TokenImpersonationLevel,

    /// <include file='TOKEN_INFORMATION_CLASS.xml' path='doc/member[@name="TOKEN_INFORMATION_CLASS.TokenStatistics"]/*' />
    TokenStatistics,

    /// <include file='TOKEN_INFORMATION_CLASS.xml' path='doc/member[@name="TOKEN_INFORMATION_CLASS.TokenRestrictedSids"]/*' />
    TokenRestrictedSids,

    /// <include file='TOKEN_INFORMATION_CLASS.xml' path='doc/member[@name="TOKEN_INFORMATION_CLASS.TokenSessionId"]/*' />
    TokenSessionId,

    /// <include file='TOKEN_INFORMATION_CLASS.xml' path='doc/member[@name="TOKEN_INFORMATION_CLASS.TokenGroupsAndPrivileges"]/*' />
    TokenGroupsAndPrivileges,

    /// <include file='TOKEN_INFORMATION_CLASS.xml' path='doc/member[@name="TOKEN_INFORMATION_CLASS.TokenSessionReference"]/*' />
    TokenSessionReference,

    /// <include file='TOKEN_INFORMATION_CLASS.xml' path='doc/member[@name="TOKEN_INFORMATION_CLASS.TokenSandBoxInert"]/*' />
    TokenSandBoxInert,

    /// <include file='TOKEN_INFORMATION_CLASS.xml' path='doc/member[@name="TOKEN_INFORMATION_CLASS.TokenAuditPolicy"]/*' />
    TokenAuditPolicy,

    /// <include file='TOKEN_INFORMATION_CLASS.xml' path='doc/member[@name="TOKEN_INFORMATION_CLASS.TokenOrigin"]/*' />
    TokenOrigin,

    /// <include file='TOKEN_INFORMATION_CLASS.xml' path='doc/member[@name="TOKEN_INFORMATION_CLASS.TokenElevationType"]/*' />
    TokenElevationType,

    /// <include file='TOKEN_INFORMATION_CLASS.xml' path='doc/member[@name="TOKEN_INFORMATION_CLASS.TokenLinkedToken"]/*' />
    TokenLinkedToken,

    /// <include file='TOKEN_INFORMATION_CLASS.xml' path='doc/member[@name="TOKEN_INFORMATION_CLASS.TokenElevation"]/*' />
    TokenElevation,

    /// <include file='TOKEN_INFORMATION_CLASS.xml' path='doc/member[@name="TOKEN_INFORMATION_CLASS.TokenHasRestrictions"]/*' />
    TokenHasRestrictions,

    /// <include file='TOKEN_INFORMATION_CLASS.xml' path='doc/member[@name="TOKEN_INFORMATION_CLASS.TokenAccessInformation"]/*' />
    TokenAccessInformation,

    /// <include file='TOKEN_INFORMATION_CLASS.xml' path='doc/member[@name="TOKEN_INFORMATION_CLASS.TokenVirtualizationAllowed"]/*' />
    TokenVirtualizationAllowed,

    /// <include file='TOKEN_INFORMATION_CLASS.xml' path='doc/member[@name="TOKEN_INFORMATION_CLASS.TokenVirtualizationEnabled"]/*' />
    TokenVirtualizationEnabled,

    /// <include file='TOKEN_INFORMATION_CLASS.xml' path='doc/member[@name="TOKEN_INFORMATION_CLASS.TokenIntegrityLevel"]/*' />
    TokenIntegrityLevel,

    /// <include file='TOKEN_INFORMATION_CLASS.xml' path='doc/member[@name="TOKEN_INFORMATION_CLASS.TokenUIAccess"]/*' />
    TokenUIAccess,

    /// <include file='TOKEN_INFORMATION_CLASS.xml' path='doc/member[@name="TOKEN_INFORMATION_CLASS.TokenMandatoryPolicy"]/*' />
    TokenMandatoryPolicy,

    /// <include file='TOKEN_INFORMATION_CLASS.xml' path='doc/member[@name="TOKEN_INFORMATION_CLASS.TokenLogonSid"]/*' />
    TokenLogonSid,

    /// <include file='TOKEN_INFORMATION_CLASS.xml' path='doc/member[@name="TOKEN_INFORMATION_CLASS.TokenIsAppContainer"]/*' />
    TokenIsAppContainer,

    /// <include file='TOKEN_INFORMATION_CLASS.xml' path='doc/member[@name="TOKEN_INFORMATION_CLASS.TokenCapabilities"]/*' />
    TokenCapabilities,

    /// <include file='TOKEN_INFORMATION_CLASS.xml' path='doc/member[@name="TOKEN_INFORMATION_CLASS.TokenAppContainerSid"]/*' />
    TokenAppContainerSid,

    /// <include file='TOKEN_INFORMATION_CLASS.xml' path='doc/member[@name="TOKEN_INFORMATION_CLASS.TokenAppContainerNumber"]/*' />
    TokenAppContainerNumber,

    /// <include file='TOKEN_INFORMATION_CLASS.xml' path='doc/member[@name="TOKEN_INFORMATION_CLASS.TokenUserClaimAttributes"]/*' />
    TokenUserClaimAttributes,

    /// <include file='TOKEN_INFORMATION_CLASS.xml' path='doc/member[@name="TOKEN_INFORMATION_CLASS.TokenDeviceClaimAttributes"]/*' />
    TokenDeviceClaimAttributes,

    /// <include file='TOKEN_INFORMATION_CLASS.xml' path='doc/member[@name="TOKEN_INFORMATION_CLASS.TokenRestrictedUserClaimAttributes"]/*' />
    TokenRestrictedUserClaimAttributes,

    /// <include file='TOKEN_INFORMATION_CLASS.xml' path='doc/member[@name="TOKEN_INFORMATION_CLASS.TokenRestrictedDeviceClaimAttributes"]/*' />
    TokenRestrictedDeviceClaimAttributes,

    /// <include file='TOKEN_INFORMATION_CLASS.xml' path='doc/member[@name="TOKEN_INFORMATION_CLASS.TokenDeviceGroups"]/*' />
    TokenDeviceGroups,

    /// <include file='TOKEN_INFORMATION_CLASS.xml' path='doc/member[@name="TOKEN_INFORMATION_CLASS.TokenRestrictedDeviceGroups"]/*' />
    TokenRestrictedDeviceGroups,

    /// <include file='TOKEN_INFORMATION_CLASS.xml' path='doc/member[@name="TOKEN_INFORMATION_CLASS.TokenSecurityAttributes"]/*' />
    TokenSecurityAttributes,

    /// <include file='TOKEN_INFORMATION_CLASS.xml' path='doc/member[@name="TOKEN_INFORMATION_CLASS.TokenIsRestricted"]/*' />
    TokenIsRestricted,

    /// <include file='TOKEN_INFORMATION_CLASS.xml' path='doc/member[@name="TOKEN_INFORMATION_CLASS.TokenProcessTrustLevel"]/*' />
    TokenProcessTrustLevel,

    /// <include file='TOKEN_INFORMATION_CLASS.xml' path='doc/member[@name="TOKEN_INFORMATION_CLASS.TokenPrivateNameSpace"]/*' />
    TokenPrivateNameSpace,

    /// <include file='TOKEN_INFORMATION_CLASS.xml' path='doc/member[@name="TOKEN_INFORMATION_CLASS.TokenSingletonAttributes"]/*' />
    TokenSingletonAttributes,

    /// <include file='TOKEN_INFORMATION_CLASS.xml' path='doc/member[@name="TOKEN_INFORMATION_CLASS.TokenBnoIsolation"]/*' />
    TokenBnoIsolation,

    /// <include file='TOKEN_INFORMATION_CLASS.xml' path='doc/member[@name="TOKEN_INFORMATION_CLASS.TokenChildProcessFlags"]/*' />
    TokenChildProcessFlags,

    /// <include file='TOKEN_INFORMATION_CLASS.xml' path='doc/member[@name="TOKEN_INFORMATION_CLASS.TokenIsLessPrivilegedAppContainer"]/*' />
    TokenIsLessPrivilegedAppContainer,

    /// <include file='TOKEN_INFORMATION_CLASS.xml' path='doc/member[@name="TOKEN_INFORMATION_CLASS.TokenIsSandboxed"]/*' />
    TokenIsSandboxed,

    /// <include file='TOKEN_INFORMATION_CLASS.xml' path='doc/member[@name="TOKEN_INFORMATION_CLASS.TokenIsAppSilo"]/*' />
    TokenIsAppSilo,

    /// <include file='TOKEN_INFORMATION_CLASS.xml' path='doc/member[@name="TOKEN_INFORMATION_CLASS.MaxTokenInfoClass"]/*' />
    MaxTokenInfoClass,
}
