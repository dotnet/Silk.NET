// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='TASKDIALOG_NOTIFICATIONS.xml' path='doc/member[@name="TASKDIALOG_NOTIFICATIONS"]/*'/>
public enum TASKDIALOG_NOTIFICATIONS
{
    /// <include file='TASKDIALOG_NOTIFICATIONS.xml' path='doc/member[@name="TASKDIALOG_NOTIFICATIONS.TDN_CREATED"]/*'/>
    TDN_CREATED = 0,
    /// <include file='TASKDIALOG_NOTIFICATIONS.xml' path='doc/member[@name="TASKDIALOG_NOTIFICATIONS.TDN_NAVIGATED"]/*'/>
    TDN_NAVIGATED = 1,
    /// <include file='TASKDIALOG_NOTIFICATIONS.xml' path='doc/member[@name="TASKDIALOG_NOTIFICATIONS.TDN_BUTTON_CLICKED"]/*'/>
    TDN_BUTTON_CLICKED = 2,
    /// <include file='TASKDIALOG_NOTIFICATIONS.xml' path='doc/member[@name="TASKDIALOG_NOTIFICATIONS.TDN_HYPERLINK_CLICKED"]/*'/>
    TDN_HYPERLINK_CLICKED = 3,
    /// <include file='TASKDIALOG_NOTIFICATIONS.xml' path='doc/member[@name="TASKDIALOG_NOTIFICATIONS.TDN_TIMER"]/*'/>
    TDN_TIMER = 4,
    /// <include file='TASKDIALOG_NOTIFICATIONS.xml' path='doc/member[@name="TASKDIALOG_NOTIFICATIONS.TDN_DESTROYED"]/*'/>
    TDN_DESTROYED = 5,
    /// <include file='TASKDIALOG_NOTIFICATIONS.xml' path='doc/member[@name="TASKDIALOG_NOTIFICATIONS.TDN_RADIO_BUTTON_CLICKED"]/*'/>
    TDN_RADIO_BUTTON_CLICKED = 6,
    /// <include file='TASKDIALOG_NOTIFICATIONS.xml' path='doc/member[@name="TASKDIALOG_NOTIFICATIONS.TDN_DIALOG_CONSTRUCTED"]/*'/>
    TDN_DIALOG_CONSTRUCTED = 7,
    /// <include file='TASKDIALOG_NOTIFICATIONS.xml' path='doc/member[@name="TASKDIALOG_NOTIFICATIONS.TDN_VERIFICATION_CLICKED"]/*'/>
    TDN_VERIFICATION_CLICKED = 8,
    /// <include file='TASKDIALOG_NOTIFICATIONS.xml' path='doc/member[@name="TASKDIALOG_NOTIFICATIONS.TDN_HELP"]/*'/>
    TDN_HELP = 9,
    /// <include file='TASKDIALOG_NOTIFICATIONS.xml' path='doc/member[@name="TASKDIALOG_NOTIFICATIONS.TDN_EXPANDO_BUTTON_CLICKED"]/*'/>
    TDN_EXPANDO_BUTTON_CLICKED = 10,
}