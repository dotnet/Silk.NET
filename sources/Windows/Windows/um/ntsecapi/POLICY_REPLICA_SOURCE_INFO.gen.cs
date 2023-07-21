// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ntsecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='POLICY_REPLICA_SOURCE_INFO.xml' path='doc/member[@name="POLICY_REPLICA_SOURCE_INFO"]/*' />
public partial struct POLICY_REPLICA_SOURCE_INFO
{
    /// <include file='POLICY_REPLICA_SOURCE_INFO.xml' path='doc/member[@name="POLICY_REPLICA_SOURCE_INFO.ReplicaSource"]/*' />
    public LSA_UNICODE_STRING ReplicaSource;

    /// <include file='POLICY_REPLICA_SOURCE_INFO.xml' path='doc/member[@name="POLICY_REPLICA_SOURCE_INFO.ReplicaAccountName"]/*' />
    public LSA_UNICODE_STRING ReplicaAccountName;
}
