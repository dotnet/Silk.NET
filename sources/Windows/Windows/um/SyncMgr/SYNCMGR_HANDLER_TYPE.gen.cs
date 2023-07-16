// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/SyncMgr.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='SYNCMGR_HANDLER_TYPE.xml' path='doc/member[@name="SYNCMGR_HANDLER_TYPE"]/*'/>
public enum SYNCMGR_HANDLER_TYPE
{
    /// <include file='SYNCMGR_HANDLER_TYPE.xml' path='doc/member[@name="SYNCMGR_HANDLER_TYPE.SYNCMGR_HT_UNSPECIFIED"]/*'/>
    SYNCMGR_HT_UNSPECIFIED = 0,
    /// <include file='SYNCMGR_HANDLER_TYPE.xml' path='doc/member[@name="SYNCMGR_HANDLER_TYPE.SYNCMGR_HT_APPLICATION"]/*'/>
    SYNCMGR_HT_APPLICATION = 1,
    /// <include file='SYNCMGR_HANDLER_TYPE.xml' path='doc/member[@name="SYNCMGR_HANDLER_TYPE.SYNCMGR_HT_DEVICE"]/*'/>
    SYNCMGR_HT_DEVICE = 2,
    /// <include file='SYNCMGR_HANDLER_TYPE.xml' path='doc/member[@name="SYNCMGR_HANDLER_TYPE.SYNCMGR_HT_FOLDER"]/*'/>
    SYNCMGR_HT_FOLDER = 3,
    /// <include file='SYNCMGR_HANDLER_TYPE.xml' path='doc/member[@name="SYNCMGR_HANDLER_TYPE.SYNCMGR_HT_SERVICE"]/*'/>
    SYNCMGR_HT_SERVICE = 4,
    /// <include file='SYNCMGR_HANDLER_TYPE.xml' path='doc/member[@name="SYNCMGR_HANDLER_TYPE.SYNCMGR_HT_COMPUTER"]/*'/>
    SYNCMGR_HT_COMPUTER = 5,
    /// <include file='SYNCMGR_HANDLER_TYPE.xml' path='doc/member[@name="SYNCMGR_HANDLER_TYPE.SYNCMGR_HT_MIN"]/*'/>
    SYNCMGR_HT_MIN = 0,
    /// <include file='SYNCMGR_HANDLER_TYPE.xml' path='doc/member[@name="SYNCMGR_HANDLER_TYPE.SYNCMGR_HT_MAX"]/*'/>
    SYNCMGR_HT_MAX = SYNCMGR_HT_COMPUTER,
}