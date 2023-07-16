// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='SECURITY_IMPERSONATION_LEVEL.xml' path='doc/member[@name="SECURITY_IMPERSONATION_LEVEL"]/*'/>
public enum SECURITY_IMPERSONATION_LEVEL
{
    /// <include file='SECURITY_IMPERSONATION_LEVEL.xml' path='doc/member[@name="SECURITY_IMPERSONATION_LEVEL.SecurityAnonymous"]/*'/>
    SecurityAnonymous,
    /// <include file='SECURITY_IMPERSONATION_LEVEL.xml' path='doc/member[@name="SECURITY_IMPERSONATION_LEVEL.SecurityIdentification"]/*'/>
    SecurityIdentification,
    /// <include file='SECURITY_IMPERSONATION_LEVEL.xml' path='doc/member[@name="SECURITY_IMPERSONATION_LEVEL.SecurityImpersonation"]/*'/>
    SecurityImpersonation,
    /// <include file='SECURITY_IMPERSONATION_LEVEL.xml' path='doc/member[@name="SECURITY_IMPERSONATION_LEVEL.SecurityDelegation"]/*'/>
    SecurityDelegation,
}