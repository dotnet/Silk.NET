// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/SyncMgr.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='SYNCMGR_RESOLUTION_FEEDBACK.xml' path='doc/member[@name="SYNCMGR_RESOLUTION_FEEDBACK"]/*'/>
public enum SYNCMGR_RESOLUTION_FEEDBACK
{
    /// <include file='SYNCMGR_RESOLUTION_FEEDBACK.xml' path='doc/member[@name="SYNCMGR_RESOLUTION_FEEDBACK.SYNCMGR_RF_CONTINUE"]/*'/>
    SYNCMGR_RF_CONTINUE = 0,
    /// <include file='SYNCMGR_RESOLUTION_FEEDBACK.xml' path='doc/member[@name="SYNCMGR_RESOLUTION_FEEDBACK.SYNCMGR_RF_REFRESH"]/*'/>
    SYNCMGR_RF_REFRESH = (SYNCMGR_RF_CONTINUE + 1),
    /// <include file='SYNCMGR_RESOLUTION_FEEDBACK.xml' path='doc/member[@name="SYNCMGR_RESOLUTION_FEEDBACK.SYNCMGR_RF_CANCEL"]/*'/>
    SYNCMGR_RF_CANCEL = (SYNCMGR_RF_REFRESH + 1),
}