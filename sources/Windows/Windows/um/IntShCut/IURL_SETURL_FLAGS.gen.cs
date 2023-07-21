// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/IntShCut.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='IURL_SETURL_FLAGS.xml' path='doc/member[@name="IURL_SETURL_FLAGS"]/*' />
public enum IURL_SETURL_FLAGS
{
    /// <include file='IURL_SETURL_FLAGS.xml' path='doc/member[@name="IURL_SETURL_FLAGS.IURL_SETURL_FL_GUESS_PROTOCOL"]/*' />
    IURL_SETURL_FL_GUESS_PROTOCOL = 0x0001,

    /// <include file='IURL_SETURL_FLAGS.xml' path='doc/member[@name="IURL_SETURL_FLAGS.IURL_SETURL_FL_USE_DEFAULT_PROTOCOL"]/*' />
    IURL_SETURL_FL_USE_DEFAULT_PROTOCOL = 0x0002,
}
