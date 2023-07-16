// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/SyncMgr.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='SYNCMGR_CONTROL_FLAGS.xml' path='doc/member[@name="SYNCMGR_CONTROL_FLAGS"]/*'/>
public enum SYNCMGR_CONTROL_FLAGS
{
    /// <include file='SYNCMGR_CONTROL_FLAGS.xml' path='doc/member[@name="SYNCMGR_CONTROL_FLAGS.SYNCMGR_CF_NONE"]/*'/>
    SYNCMGR_CF_NONE = 0,
    /// <include file='SYNCMGR_CONTROL_FLAGS.xml' path='doc/member[@name="SYNCMGR_CONTROL_FLAGS.SYNCMGR_CF_NOWAIT"]/*'/>
    SYNCMGR_CF_NOWAIT = 0,
    /// <include file='SYNCMGR_CONTROL_FLAGS.xml' path='doc/member[@name="SYNCMGR_CONTROL_FLAGS.SYNCMGR_CF_WAIT"]/*'/>
    SYNCMGR_CF_WAIT = 0x1,
    /// <include file='SYNCMGR_CONTROL_FLAGS.xml' path='doc/member[@name="SYNCMGR_CONTROL_FLAGS.SYNCMGR_CF_NOUI"]/*'/>
    SYNCMGR_CF_NOUI = 0x2,
    /// <include file='SYNCMGR_CONTROL_FLAGS.xml' path='doc/member[@name="SYNCMGR_CONTROL_FLAGS.SYNCMGR_CF_VALID"]/*'/>
    SYNCMGR_CF_VALID = 0x3,
}