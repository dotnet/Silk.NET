// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='PIN_DIRECTION.xml' path='doc/member[@name="PIN_DIRECTION"]/*' />
public enum PIN_DIRECTION
{
    /// <include file='PIN_DIRECTION.xml' path='doc/member[@name="PIN_DIRECTION.PINDIR_INPUT"]/*' />
    PINDIR_INPUT = 0,

    /// <include file='PIN_DIRECTION.xml' path='doc/member[@name="PIN_DIRECTION.PINDIR_OUTPUT"]/*' />
    PINDIR_OUTPUT = (PINDIR_INPUT + 1),
}
