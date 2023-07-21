// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/IntShCut.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='URLASSOCIATIONDIALOG_IN_FLAGS.xml' path='doc/member[@name="URLASSOCIATIONDIALOG_IN_FLAGS"]/*' />
public enum URLASSOCIATIONDIALOG_IN_FLAGS
{
    /// <include file='URLASSOCIATIONDIALOG_IN_FLAGS.xml' path='doc/member[@name="URLASSOCIATIONDIALOG_IN_FLAGS.URLASSOCDLG_FL_USE_DEFAULT_NAME"]/*' />
    URLASSOCDLG_FL_USE_DEFAULT_NAME = 0x0001,

    /// <include file='URLASSOCIATIONDIALOG_IN_FLAGS.xml' path='doc/member[@name="URLASSOCIATIONDIALOG_IN_FLAGS.URLASSOCDLG_FL_REGISTER_ASSOC"]/*' />
    URLASSOCDLG_FL_REGISTER_ASSOC = 0x0002,
}
