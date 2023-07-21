// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='TRANSACTIONMANAGER_RECOVERY_INFORMATION.xml' path='doc/member[@name="TRANSACTIONMANAGER_RECOVERY_INFORMATION"]/*' />
public partial struct TRANSACTIONMANAGER_RECOVERY_INFORMATION
{
    /// <include file='TRANSACTIONMANAGER_RECOVERY_INFORMATION.xml' path='doc/member[@name="TRANSACTIONMANAGER_RECOVERY_INFORMATION.LastRecoveredLsn"]/*' />
    [NativeTypeName("ULONGLONG")]
    public ulong LastRecoveredLsn;
}
