// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WbemCli.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='WBEM_BACKUP_RESTORE_FLAGS.xml' path='doc/member[@name="WBEM_BACKUP_RESTORE_FLAGS"]/*'/>
public enum WBEM_BACKUP_RESTORE_FLAGS
{
    /// <include file='WBEM_BACKUP_RESTORE_FLAGS.xml' path='doc/member[@name="WBEM_BACKUP_RESTORE_FLAGS.WBEM_FLAG_BACKUP_RESTORE_DEFAULT"]/*'/>
    WBEM_FLAG_BACKUP_RESTORE_DEFAULT = 0,
    /// <include file='WBEM_BACKUP_RESTORE_FLAGS.xml' path='doc/member[@name="WBEM_BACKUP_RESTORE_FLAGS.WBEM_FLAG_BACKUP_RESTORE_FORCE_SHUTDOWN"]/*'/>
    WBEM_FLAG_BACKUP_RESTORE_FORCE_SHUTDOWN = 1,
}