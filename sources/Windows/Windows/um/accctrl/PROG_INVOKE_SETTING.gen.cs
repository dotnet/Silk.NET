// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/accctrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='PROG_INVOKE_SETTING.xml' path='doc/member[@name="PROG_INVOKE_SETTING"]/*' />
public enum PROG_INVOKE_SETTING
{
    /// <include file='PROG_INVOKE_SETTING.xml' path='doc/member[@name="PROG_INVOKE_SETTING.ProgressInvokeNever"]/*' />
    ProgressInvokeNever = 1,

    /// <include file='PROG_INVOKE_SETTING.xml' path='doc/member[@name="PROG_INVOKE_SETTING.ProgressInvokeEveryObject"]/*' />
    ProgressInvokeEveryObject,

    /// <include file='PROG_INVOKE_SETTING.xml' path='doc/member[@name="PROG_INVOKE_SETTING.ProgressInvokeOnError"]/*' />
    ProgressInvokeOnError,

    /// <include file='PROG_INVOKE_SETTING.xml' path='doc/member[@name="PROG_INVOKE_SETTING.ProgressCancelOperation"]/*' />
    ProgressCancelOperation,

    /// <include file='PROG_INVOKE_SETTING.xml' path='doc/member[@name="PROG_INVOKE_SETTING.ProgressRetryOperation"]/*' />
    ProgressRetryOperation,

    /// <include file='PROG_INVOKE_SETTING.xml' path='doc/member[@name="PROG_INVOKE_SETTING.ProgressInvokePrePostError"]/*' />
    ProgressInvokePrePostError,
}
