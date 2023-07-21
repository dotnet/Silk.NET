// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ddpbackup.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='DEDUP_BACKUP_SUPPORT_PARAM_TYPE.xml' path='doc/member[@name="DEDUP_BACKUP_SUPPORT_PARAM_TYPE"]/*' />
public enum DEDUP_BACKUP_SUPPORT_PARAM_TYPE
{
    /// <include file='DEDUP_BACKUP_SUPPORT_PARAM_TYPE.xml' path='doc/member[@name="DEDUP_BACKUP_SUPPORT_PARAM_TYPE.DEDUP_RECONSTRUCT_UNOPTIMIZED"]/*' />
    DEDUP_RECONSTRUCT_UNOPTIMIZED = 1,

    /// <include file='DEDUP_BACKUP_SUPPORT_PARAM_TYPE.xml' path='doc/member[@name="DEDUP_BACKUP_SUPPORT_PARAM_TYPE.DEDUP_RECONSTRUCT_OPTIMIZED"]/*' />
    DEDUP_RECONSTRUCT_OPTIMIZED = 2,
}
