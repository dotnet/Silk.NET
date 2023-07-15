// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='TASKDIALOG_MESSAGES.xml' path='doc/member[@name="TASKDIALOG_MESSAGES"]/*'/>
public enum TASKDIALOG_MESSAGES
{
    /// <include file='TASKDIALOG_MESSAGES.xml' path='doc/member[@name="TASKDIALOG_MESSAGES.TDM_NAVIGATE_PAGE"]/*'/>
    TDM_NAVIGATE_PAGE = 0x0400 + 101,
    /// <include file='TASKDIALOG_MESSAGES.xml' path='doc/member[@name="TASKDIALOG_MESSAGES.TDM_CLICK_BUTTON"]/*'/>
    TDM_CLICK_BUTTON = 0x0400 + 102,
    /// <include file='TASKDIALOG_MESSAGES.xml' path='doc/member[@name="TASKDIALOG_MESSAGES.TDM_SET_MARQUEE_PROGRESS_BAR"]/*'/>
    TDM_SET_MARQUEE_PROGRESS_BAR = 0x0400 + 103,
    /// <include file='TASKDIALOG_MESSAGES.xml' path='doc/member[@name="TASKDIALOG_MESSAGES.TDM_SET_PROGRESS_BAR_STATE"]/*'/>
    TDM_SET_PROGRESS_BAR_STATE = 0x0400 + 104,
    /// <include file='TASKDIALOG_MESSAGES.xml' path='doc/member[@name="TASKDIALOG_MESSAGES.TDM_SET_PROGRESS_BAR_RANGE"]/*'/>
    TDM_SET_PROGRESS_BAR_RANGE = 0x0400 + 105,
    /// <include file='TASKDIALOG_MESSAGES.xml' path='doc/member[@name="TASKDIALOG_MESSAGES.TDM_SET_PROGRESS_BAR_POS"]/*'/>
    TDM_SET_PROGRESS_BAR_POS = 0x0400 + 106,
    /// <include file='TASKDIALOG_MESSAGES.xml' path='doc/member[@name="TASKDIALOG_MESSAGES.TDM_SET_PROGRESS_BAR_MARQUEE"]/*'/>
    TDM_SET_PROGRESS_BAR_MARQUEE = 0x0400 + 107,
    /// <include file='TASKDIALOG_MESSAGES.xml' path='doc/member[@name="TASKDIALOG_MESSAGES.TDM_SET_ELEMENT_TEXT"]/*'/>
    TDM_SET_ELEMENT_TEXT = 0x0400 + 108,
    /// <include file='TASKDIALOG_MESSAGES.xml' path='doc/member[@name="TASKDIALOG_MESSAGES.TDM_CLICK_RADIO_BUTTON"]/*'/>
    TDM_CLICK_RADIO_BUTTON = 0x0400 + 110,
    /// <include file='TASKDIALOG_MESSAGES.xml' path='doc/member[@name="TASKDIALOG_MESSAGES.TDM_ENABLE_BUTTON"]/*'/>
    TDM_ENABLE_BUTTON = 0x0400 + 111,
    /// <include file='TASKDIALOG_MESSAGES.xml' path='doc/member[@name="TASKDIALOG_MESSAGES.TDM_ENABLE_RADIO_BUTTON"]/*'/>
    TDM_ENABLE_RADIO_BUTTON = 0x0400 + 112,
    /// <include file='TASKDIALOG_MESSAGES.xml' path='doc/member[@name="TASKDIALOG_MESSAGES.TDM_CLICK_VERIFICATION"]/*'/>
    TDM_CLICK_VERIFICATION = 0x0400 + 113,
    /// <include file='TASKDIALOG_MESSAGES.xml' path='doc/member[@name="TASKDIALOG_MESSAGES.TDM_UPDATE_ELEMENT_TEXT"]/*'/>
    TDM_UPDATE_ELEMENT_TEXT = 0x0400 + 114,
    /// <include file='TASKDIALOG_MESSAGES.xml' path='doc/member[@name="TASKDIALOG_MESSAGES.TDM_SET_BUTTON_ELEVATION_REQUIRED_STATE"]/*'/>
    TDM_SET_BUTTON_ELEVATION_REQUIRED_STATE = 0x0400 + 115,
    /// <include file='TASKDIALOG_MESSAGES.xml' path='doc/member[@name="TASKDIALOG_MESSAGES.TDM_UPDATE_ICON"]/*'/>
    TDM_UPDATE_ICON = 0x0400 + 116,
}