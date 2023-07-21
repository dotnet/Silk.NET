// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='TP_CALLBACK_PRIORITY.xml' path='doc/member[@name="TP_CALLBACK_PRIORITY"]/*' />
public enum TP_CALLBACK_PRIORITY
{
    /// <include file='TP_CALLBACK_PRIORITY.xml' path='doc/member[@name="TP_CALLBACK_PRIORITY.TP_CALLBACK_PRIORITY_HIGH"]/*' />
    TP_CALLBACK_PRIORITY_HIGH,

    /// <include file='TP_CALLBACK_PRIORITY.xml' path='doc/member[@name="TP_CALLBACK_PRIORITY.TP_CALLBACK_PRIORITY_NORMAL"]/*' />
    TP_CALLBACK_PRIORITY_NORMAL,

    /// <include file='TP_CALLBACK_PRIORITY.xml' path='doc/member[@name="TP_CALLBACK_PRIORITY.TP_CALLBACK_PRIORITY_LOW"]/*' />
    TP_CALLBACK_PRIORITY_LOW,

    /// <include file='TP_CALLBACK_PRIORITY.xml' path='doc/member[@name="TP_CALLBACK_PRIORITY.TP_CALLBACK_PRIORITY_INVALID"]/*' />
    TP_CALLBACK_PRIORITY_INVALID,

    /// <include file='TP_CALLBACK_PRIORITY.xml' path='doc/member[@name="TP_CALLBACK_PRIORITY.TP_CALLBACK_PRIORITY_COUNT"]/*' />
    TP_CALLBACK_PRIORITY_COUNT = TP_CALLBACK_PRIORITY_INVALID,
}
