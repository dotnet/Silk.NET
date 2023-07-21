// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace Silk.NET.Windows;

/// <include file='CATSORT_FLAGS.xml' path='doc/member[@name="CATSORT_FLAGS"]/*' />
[Flags]
public enum CATSORT_FLAGS
{
    /// <include file='CATSORT_FLAGS.xml' path='doc/member[@name="CATSORT_FLAGS.CATSORT_DEFAULT"]/*' />
    CATSORT_DEFAULT = 0,

    /// <include file='CATSORT_FLAGS.xml' path='doc/member[@name="CATSORT_FLAGS.CATSORT_NAME"]/*' />
    CATSORT_NAME = 0x1,
}
