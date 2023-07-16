// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='TASKDIALOG_FLAGS.xml' path='doc/member[@name="TASKDIALOG_FLAGS"]/*'/>
public enum TASKDIALOG_FLAGS
{
    /// <include file='TASKDIALOG_FLAGS.xml' path='doc/member[@name="TASKDIALOG_FLAGS.TDF_ENABLE_HYPERLINKS"]/*'/>
    TDF_ENABLE_HYPERLINKS = 0x0001,
    /// <include file='TASKDIALOG_FLAGS.xml' path='doc/member[@name="TASKDIALOG_FLAGS.TDF_USE_HICON_MAIN"]/*'/>
    TDF_USE_HICON_MAIN = 0x0002,
    /// <include file='TASKDIALOG_FLAGS.xml' path='doc/member[@name="TASKDIALOG_FLAGS.TDF_USE_HICON_FOOTER"]/*'/>
    TDF_USE_HICON_FOOTER = 0x0004,
    /// <include file='TASKDIALOG_FLAGS.xml' path='doc/member[@name="TASKDIALOG_FLAGS.TDF_ALLOW_DIALOG_CANCELLATION"]/*'/>
    TDF_ALLOW_DIALOG_CANCELLATION = 0x0008,
    /// <include file='TASKDIALOG_FLAGS.xml' path='doc/member[@name="TASKDIALOG_FLAGS.TDF_USE_COMMAND_LINKS"]/*'/>
    TDF_USE_COMMAND_LINKS = 0x0010,
    /// <include file='TASKDIALOG_FLAGS.xml' path='doc/member[@name="TASKDIALOG_FLAGS.TDF_USE_COMMAND_LINKS_NO_ICON"]/*'/>
    TDF_USE_COMMAND_LINKS_NO_ICON = 0x0020,
    /// <include file='TASKDIALOG_FLAGS.xml' path='doc/member[@name="TASKDIALOG_FLAGS.TDF_EXPAND_FOOTER_AREA"]/*'/>
    TDF_EXPAND_FOOTER_AREA = 0x0040,
    /// <include file='TASKDIALOG_FLAGS.xml' path='doc/member[@name="TASKDIALOG_FLAGS.TDF_EXPANDED_BY_DEFAULT"]/*'/>
    TDF_EXPANDED_BY_DEFAULT = 0x0080,
    /// <include file='TASKDIALOG_FLAGS.xml' path='doc/member[@name="TASKDIALOG_FLAGS.TDF_VERIFICATION_FLAG_CHECKED"]/*'/>
    TDF_VERIFICATION_FLAG_CHECKED = 0x0100,
    /// <include file='TASKDIALOG_FLAGS.xml' path='doc/member[@name="TASKDIALOG_FLAGS.TDF_SHOW_PROGRESS_BAR"]/*'/>
    TDF_SHOW_PROGRESS_BAR = 0x0200,
    /// <include file='TASKDIALOG_FLAGS.xml' path='doc/member[@name="TASKDIALOG_FLAGS.TDF_SHOW_MARQUEE_PROGRESS_BAR"]/*'/>
    TDF_SHOW_MARQUEE_PROGRESS_BAR = 0x0400,
    /// <include file='TASKDIALOG_FLAGS.xml' path='doc/member[@name="TASKDIALOG_FLAGS.TDF_CALLBACK_TIMER"]/*'/>
    TDF_CALLBACK_TIMER = 0x0800,
    /// <include file='TASKDIALOG_FLAGS.xml' path='doc/member[@name="TASKDIALOG_FLAGS.TDF_POSITION_RELATIVE_TO_WINDOW"]/*'/>
    TDF_POSITION_RELATIVE_TO_WINDOW = 0x1000,
    /// <include file='TASKDIALOG_FLAGS.xml' path='doc/member[@name="TASKDIALOG_FLAGS.TDF_RTL_LAYOUT"]/*'/>
    TDF_RTL_LAYOUT = 0x2000,
    /// <include file='TASKDIALOG_FLAGS.xml' path='doc/member[@name="TASKDIALOG_FLAGS.TDF_NO_DEFAULT_RADIO_BUTTON"]/*'/>
    TDF_NO_DEFAULT_RADIO_BUTTON = 0x4000,
    /// <include file='TASKDIALOG_FLAGS.xml' path='doc/member[@name="TASKDIALOG_FLAGS.TDF_CAN_BE_MINIMIZED"]/*'/>
    TDF_CAN_BE_MINIMIZED = 0x8000,
    /// <include file='TASKDIALOG_FLAGS.xml' path='doc/member[@name="TASKDIALOG_FLAGS.TDF_NO_SET_FOREGROUND"]/*'/>
    TDF_NO_SET_FOREGROUND = 0x00010000,
    /// <include file='TASKDIALOG_FLAGS.xml' path='doc/member[@name="TASKDIALOG_FLAGS.TDF_SIZE_TO_CONTENT"]/*'/>
    TDF_SIZE_TO_CONTENT = 0x01000000,
}