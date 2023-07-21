// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/projectedfslib.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.Versioning;

namespace Silk.NET.Windows;

/// <include file='PRJ_CALLBACK_DATA_FLAGS.xml' path='doc/member[@name="PRJ_CALLBACK_DATA_FLAGS"]/*' />
[Flags]
[SupportedOSPlatform("windows10.0.17763.0")]
public enum PRJ_CALLBACK_DATA_FLAGS
{
    /// <include file='PRJ_CALLBACK_DATA_FLAGS.xml' path='doc/member[@name="PRJ_CALLBACK_DATA_FLAGS.PRJ_CB_DATA_FLAG_ENUM_RESTART_SCAN"]/*' />
    PRJ_CB_DATA_FLAG_ENUM_RESTART_SCAN = 0x00000001,

    /// <include file='PRJ_CALLBACK_DATA_FLAGS.xml' path='doc/member[@name="PRJ_CALLBACK_DATA_FLAGS.PRJ_CB_DATA_FLAG_ENUM_RETURN_SINGLE_ENTRY"]/*' />
    PRJ_CB_DATA_FLAG_ENUM_RETURN_SINGLE_ENTRY = 0x00000002,
}
