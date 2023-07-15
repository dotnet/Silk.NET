// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/SyncMgr.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='SYNCMGR_RESOLUTION_ABILITIES.xml' path='doc/member[@name="SYNCMGR_RESOLUTION_ABILITIES"]/*'/>
public enum SYNCMGR_RESOLUTION_ABILITIES
{
    /// <include file='SYNCMGR_RESOLUTION_ABILITIES.xml' path='doc/member[@name="SYNCMGR_RESOLUTION_ABILITIES.SYNCMGR_RA_KEEPOTHER"]/*'/>
    SYNCMGR_RA_KEEPOTHER = 0x1,
    /// <include file='SYNCMGR_RESOLUTION_ABILITIES.xml' path='doc/member[@name="SYNCMGR_RESOLUTION_ABILITIES.SYNCMGR_RA_KEEPRECENT"]/*'/>
    SYNCMGR_RA_KEEPRECENT = 0x2,
    /// <include file='SYNCMGR_RESOLUTION_ABILITIES.xml' path='doc/member[@name="SYNCMGR_RESOLUTION_ABILITIES.SYNCMGR_RA_REMOVEFROMSYNCSET"]/*'/>
    SYNCMGR_RA_REMOVEFROMSYNCSET = 0x4,
    /// <include file='SYNCMGR_RESOLUTION_ABILITIES.xml' path='doc/member[@name="SYNCMGR_RESOLUTION_ABILITIES.SYNCMGR_RA_KEEP_SINGLE"]/*'/>
    SYNCMGR_RA_KEEP_SINGLE = 0x8,
    /// <include file='SYNCMGR_RESOLUTION_ABILITIES.xml' path='doc/member[@name="SYNCMGR_RESOLUTION_ABILITIES.SYNCMGR_RA_KEEP_MULTIPLE"]/*'/>
    SYNCMGR_RA_KEEP_MULTIPLE = 0x10,
    /// <include file='SYNCMGR_RESOLUTION_ABILITIES.xml' path='doc/member[@name="SYNCMGR_RESOLUTION_ABILITIES.SYNCMGR_RA_VALID"]/*'/>
    SYNCMGR_RA_VALID = 0x1f,
}