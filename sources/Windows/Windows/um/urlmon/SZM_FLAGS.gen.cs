// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace Silk.NET.Windows;

/// <include file='SZM_FLAGS.xml' path='doc/member[@name="SZM_FLAGS"]/*' />
[Flags]
public enum SZM_FLAGS
{
    /// <include file='SZM_FLAGS.xml' path='doc/member[@name="SZM_FLAGS.SZM_CREATE"]/*' />
    SZM_CREATE = 0,

    /// <include file='SZM_FLAGS.xml' path='doc/member[@name="SZM_FLAGS.SZM_DELETE"]/*' />
    SZM_DELETE = 0x1,
}
