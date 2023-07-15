// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/SyncMgr.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='SYNCMGR_SYNC_CONTROL_FLAGS.xml' path='doc/member[@name="SYNCMGR_SYNC_CONTROL_FLAGS"]/*'/>
public enum SYNCMGR_SYNC_CONTROL_FLAGS
{
    /// <include file='SYNCMGR_SYNC_CONTROL_FLAGS.xml' path='doc/member[@name="SYNCMGR_SYNC_CONTROL_FLAGS.SYNCMGR_SCF_NONE"]/*'/>
    SYNCMGR_SCF_NONE = 0,
    /// <include file='SYNCMGR_SYNC_CONTROL_FLAGS.xml' path='doc/member[@name="SYNCMGR_SYNC_CONTROL_FLAGS.SYNCMGR_SCF_IGNORE_IF_ALREADY_SYNCING"]/*'/>
    SYNCMGR_SCF_IGNORE_IF_ALREADY_SYNCING = 0x1,
    /// <include file='SYNCMGR_SYNC_CONTROL_FLAGS.xml' path='doc/member[@name="SYNCMGR_SYNC_CONTROL_FLAGS.SYNCMGR_SCF_VALID"]/*'/>
    SYNCMGR_SCF_VALID = 0x1,
}