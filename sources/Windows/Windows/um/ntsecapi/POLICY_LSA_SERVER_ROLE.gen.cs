// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ntsecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='POLICY_LSA_SERVER_ROLE.xml' path='doc/member[@name="POLICY_LSA_SERVER_ROLE"]/*' />
public enum POLICY_LSA_SERVER_ROLE
{
    /// <include file='POLICY_LSA_SERVER_ROLE.xml' path='doc/member[@name="POLICY_LSA_SERVER_ROLE.PolicyServerRoleBackup"]/*' />
    PolicyServerRoleBackup = 2,

    /// <include file='POLICY_LSA_SERVER_ROLE.xml' path='doc/member[@name="POLICY_LSA_SERVER_ROLE.PolicyServerRolePrimary"]/*' />
    PolicyServerRolePrimary,
}
