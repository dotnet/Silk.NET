// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='InterleavingMode.xml' path='doc/member[@name="InterleavingMode"]/*' />
public enum InterleavingMode
{
    /// <include file='InterleavingMode.xml' path='doc/member[@name="InterleavingMode.INTERLEAVE_NONE"]/*' />
    INTERLEAVE_NONE = 0,

    /// <include file='InterleavingMode.xml' path='doc/member[@name="InterleavingMode.INTERLEAVE_CAPTURE"]/*' />
    INTERLEAVE_CAPTURE = (INTERLEAVE_NONE + 1),

    /// <include file='InterleavingMode.xml' path='doc/member[@name="InterleavingMode.INTERLEAVE_FULL"]/*' />
    INTERLEAVE_FULL = (INTERLEAVE_CAPTURE + 1),

    /// <include file='InterleavingMode.xml' path='doc/member[@name="InterleavingMode.INTERLEAVE_NONE_BUFFERED"]/*' />
    INTERLEAVE_NONE_BUFFERED = (INTERLEAVE_FULL + 1),
}
