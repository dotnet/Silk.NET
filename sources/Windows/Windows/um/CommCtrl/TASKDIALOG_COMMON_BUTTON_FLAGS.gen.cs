// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='TASKDIALOG_COMMON_BUTTON_FLAGS.xml' path='doc/member[@name="TASKDIALOG_COMMON_BUTTON_FLAGS"]/*' />
public enum TASKDIALOG_COMMON_BUTTON_FLAGS
{
    /// <include file='TASKDIALOG_COMMON_BUTTON_FLAGS.xml' path='doc/member[@name="TASKDIALOG_COMMON_BUTTON_FLAGS.TDCBF_OK_BUTTON"]/*' />
    TDCBF_OK_BUTTON = 0x0001,

    /// <include file='TASKDIALOG_COMMON_BUTTON_FLAGS.xml' path='doc/member[@name="TASKDIALOG_COMMON_BUTTON_FLAGS.TDCBF_YES_BUTTON"]/*' />
    TDCBF_YES_BUTTON = 0x0002,

    /// <include file='TASKDIALOG_COMMON_BUTTON_FLAGS.xml' path='doc/member[@name="TASKDIALOG_COMMON_BUTTON_FLAGS.TDCBF_NO_BUTTON"]/*' />
    TDCBF_NO_BUTTON = 0x0004,

    /// <include file='TASKDIALOG_COMMON_BUTTON_FLAGS.xml' path='doc/member[@name="TASKDIALOG_COMMON_BUTTON_FLAGS.TDCBF_CANCEL_BUTTON"]/*' />
    TDCBF_CANCEL_BUTTON = 0x0008,

    /// <include file='TASKDIALOG_COMMON_BUTTON_FLAGS.xml' path='doc/member[@name="TASKDIALOG_COMMON_BUTTON_FLAGS.TDCBF_RETRY_BUTTON"]/*' />
    TDCBF_RETRY_BUTTON = 0x0010,

    /// <include file='TASKDIALOG_COMMON_BUTTON_FLAGS.xml' path='doc/member[@name="TASKDIALOG_COMMON_BUTTON_FLAGS.TDCBF_CLOSE_BUTTON"]/*' />
    TDCBF_CLOSE_BUTTON = 0x0020,
}
